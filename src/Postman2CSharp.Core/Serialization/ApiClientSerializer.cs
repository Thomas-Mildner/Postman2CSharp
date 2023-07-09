﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Postman2CSharp.Core.Infrastructure;
using Postman2CSharp.Core.Models;
using Postman2CSharp.Core.Models.PostmanCollection.Authorization;
using Postman2CSharp.Core.Models.PostmanCollection.Http;
using Postman2CSharp.Core.Utilities;
using Xamasoft.JsonClassGenerator.Models;

namespace Postman2CSharp.Core.Serialization;

public static class ApiClientSerializer
{
    public static string SerializeApiClient(ApiClient client)
    {
        var logsExceptions = client.Options.ErrorHandlingStrategy != ErrorHandlingStrategy.None && client.Options.ErrorHandlingSinks.Any(x => x == ErrorHandlingSinks.LogException);

        var sb = new StringBuilder();
        if (client.Options.XmlCommentTypes.Contains(XmlCommentTypes.ApiClient) && !string.IsNullOrWhiteSpace(client.Description))
        {
            var xmlComment = XmlCommentHelpers.ToXmlSummary(client.Description.HtmlToPlainText(), string.Empty);
            sb.Append(xmlComment);
        }
        sb.AppendLine($"public class {client.Name} : {client.InterfaceName}");
        sb.AppendLine("{");
        var indent = Consts.Indent(1);
        sb.AppendLine(indent + "private readonly HttpClient _httpClient;");
        if (logsExceptions)
        {
            sb.AppendLine(indent + $"private readonly ILogger<{client.Name}> _logger;");
        }
        VariableUsagesAsPrivateProperties(sb, client.VariableUsages, indent);
        AuthProperties(client.CollectionAuth, sb, indent);
        foreach (var otherUniqueAuth in client.UniqueAuths.Where(x => x.EnumType() != client.CollectionAuth?.EnumType()))
        {
            AuthProperties(otherUniqueAuth, sb, indent);
        }
        var addAuthHeaderToConstructor = client.AllRequestsInheritAuth || client.AllRequestsHaveSameAuth;
        ApiClientConstructor(sb, client.CommonHeaders, client.UniqueAuths, client.Name, client.BaseUrl,
            addAuthHeaderToConstructor, logsExceptions);
        if (client.CollectionAuth?.EnumType() == PostmanAuthType.oauth2)
        {
            sb.AppendLine();
            AddOAuth2Methods(sb, client.CollectionAuth, client.BaseUrl, 1);
        }

        if (client.UniqueAuths.FirstOrDefault(x => x.EnumType() == PostmanAuthType.oauth2) is { } uniqueAuthOAuth2)
        {
            AddOAuth2Methods(sb, uniqueAuthOAuth2, client.BaseUrl, 1);
        }

        var options = client.Options;
        ApiClientCalls(sb, client.CollectionAuth, client.BaseUrl, client.HttpCalls, constructorHasAuthHeader: addAuthHeaderToConstructor, options.EnsureResponseIsSuccessStatusCode,
            options.XmlCommentTypes, options.CatchExceptionTypes, options.ErrorHandlingSinks, options.ErrorHandlingStrategy, options.LogLevel, options.JsonLibrary, options.HandleMultipleResponses, options.MultipleResponseHandling, options.UseCancellationTokens);
        sb.AppendLine();
        sb.AppendLine("}");
        return sb.ToString();
    }

    private static void ApiClientConstructor(StringBuilder sb, List<Header> headers, List<AuthSettings> uniqueAuths, string apiClientName, 
        string? leastPossibleUri, bool addAuthHeaderToConstructor, bool logsExceptions)
    {
        var indent = Consts.Indent(1);
        sb.Append(indent + $"public {apiClientName}(HttpClient httpClient");
        if (logsExceptions)
        {
            sb.Append($", ILogger<{apiClientName}> logger");
        }
        if (uniqueAuths.Any(x => x.EnumType() is PostmanAuthType.apikey or PostmanAuthType.oauth1 or PostmanAuthType.oauth2
                or PostmanAuthType.awsv4 or PostmanAuthType.bearer or PostmanAuthType.jwt))
        {
            sb.Append(", IConfiguration config");
        }
        sb.AppendLine(")");
        sb.AppendLine(indent + "{");

        indent = Consts.Indent(2);
        sb.AppendLine(indent + "_httpClient = httpClient;");
        if (leastPossibleUri != null)
        {
            if (!leastPossibleUri.EndsWith("/"))
            {
                leastPossibleUri += "/";
            }
            sb.AppendLine(indent + $"_httpClient.BaseAddress = new Uri($\"{leastPossibleUri}\");");
        }
        if (logsExceptions)
        {
            sb.AppendLine(indent + "_logger = logger;");
        }

        if (uniqueAuths.Count > 0)
        {
            sb.AppendLine();
        }

        if (addAuthHeaderToConstructor)
        {
            var auth = uniqueAuths.Single();
            sb.AddAuthToConstructor(auth, indent, true);
        }
        else
        {
            foreach (var unique in uniqueAuths)
            {
                sb.AddAuthToConstructor(unique, indent, false);
            }
        }

        var importantHeaders = headers.Where(Header.IsImportant).ToList();
        if (importantHeaders.Count > 0)
        {
            sb.AppendLine();
        }

        foreach (var header in importantHeaders)
        {
            sb.AddDefaultRequestHeader(indent, $"$\"{header.Key}\"", $"$\"{header.Value}\"");
        }

        indent = Consts.Indent(1);
        sb.AppendLine(indent + "}");
    }

    private static void ApiClientCalls(StringBuilder sb, AuthSettings? auth, string? baseUrl, List<HttpCall> calls, bool constructorHasAuthHeader, 
        bool ensureSuccessStatusCode, List<XmlCommentTypes> commentTypes, List<CatchExceptionTypes> catchExceptionTypes, List<ErrorHandlingSinks> errorHandlingSinks,
        ErrorHandlingStrategy errorHandlingStrategy, LogLevel logLevel, JsonLibrary jsonLibrary, bool handleMultipleResponses, MultipleResponseHandling multipleResponseHandling, bool useCancellationTokens)
    {
        var last = calls.Last();
        foreach (var call in calls)
        {
            sb.AppendLine();
            HttpCallSerializer.SerializeHttpCall(sb, auth, baseUrl, call, constructorHasAuthHeader, ensureSuccessStatusCode, commentTypes, catchExceptionTypes,
                errorHandlingSinks, errorHandlingStrategy, logLevel, jsonLibrary, handleMultipleResponses, multipleResponseHandling, useCancellationTokens);
            if (!Equals(call, last))
            {
                sb.AppendLine();
            }
        }
    }

    private static void AuthProperties(AuthSettings? authSettings, StringBuilder sb, string indent)
    {
        if (authSettings == null) return;
        if (authSettings.EnumType() == PostmanAuthType.oauth2)
        {
            AddOAuth2Properties(authSettings, sb, indent);
        }
        if (authSettings.EnumType() == PostmanAuthType.apikey)
        {
            sb.AddPrivateReadonlyString(indent, Consts._apiKey);
        }
        if (authSettings.EnumType() == PostmanAuthType.bearer)
        {
            sb.AddPrivateReadonlyString(indent, Consts._bearerToken);
        }
        if (authSettings.EnumType() == PostmanAuthType.awsv4)
        {
            sb.AddPrivateReadonlyString(indent, Consts._awsSignature);
        }
        if (authSettings.EnumType() == PostmanAuthType.jwt)
        {
            sb.AddPrivateReadonlyString(indent, Consts._jwt);
        }
        if (authSettings.EnumType() == PostmanAuthType.basic)
        {
            sb.AddPrivateReadonlyString(indent, Consts._encodedCredentials);
        }
    }

    private static void VariableUsagesAsPrivateProperties(StringBuilder sb, List<VariableUsage> variableUsages, string indent)
    {
        foreach (var variableUsage in variableUsages.Where(x => !x.Original.StartsWith(":")))
        {
            var normalizedKey = variableUsage.CSPropertyUsage(CsharpPropertyType.Private);
            var valueLiteral = string.IsNullOrWhiteSpace(variableUsage.Value) ? "string.Empty" : $"\"{variableUsage.Value}\"";
            sb.AppendLine(indent + $"private string {normalizedKey} = {valueLiteral};");
        }
    }

    private static void AddOAuth2Methods(StringBuilder sb, AuthSettings authSettings, string? baseUrl, int indent)
    {
        AddNotImplementedFunction(sb, OAuth2Functions.GetAccessToken, indent, returnType: "string");
        sb.AppendLine();
        AddNotImplementedFunction(sb, OAuth2Functions.GetRefreshToken, indent, returnType: "string");
        sb.AppendLine();
        AddNotImplementedFunction(sb, OAuth2Functions.PersistAccessToken, indent, paramaters: new List<string>() { "string accessToken" });
        sb.AppendLine();
        AddNotImplementedFunction(sb, OAuth2Functions.PersistRefreshToken, indent, paramaters: new List<string>() { "string refreshToken" });
        sb.AppendLine();
        if (authSettings.TryGetAuth2Config(OAuth2Config.AddTokenTo, out var addTokenToValue))
        {
            if (Enum.TryParse<AddTokenTo>(addTokenToValue, true, out var addTokenTo))
            {
                if (addTokenTo == AddTokenTo.Header)
                {
                    authSettings.TryGetAuth2Config(OAuth2Config.HeaderPrefix, out var headerPrefix);
                    AddAccessTokenToHeader(sb, headerPrefix, indent);
                    sb.AppendLine();
                }

                if (addTokenTo == AddTokenTo.QueryParams)
                {

                }
            }
        }
        if (authSettings.TryGetAuth2Config(OAuth2Config.GrantType, out var grantTypeValue))
        {
            grantTypeValue = grantTypeValue?.Replace("_", string.Empty);
            if (Enum.TryParse<GrantType>(grantTypeValue, true, out var grantType))
            {
                if (grantType == GrantType.AuthorizationCode)
                {
                    AuthorizationCode(sb, authSettings, indent);
                    sb.AppendLine();
                    Auth(sb, authSettings, indent);
                }

                if (grantType == GrantType.Implicit)
                {
                    Implicit(sb, authSettings, indent);
                    sb.AppendLine();
                    Auth(sb, authSettings, indent);
                }
            }
        }
        // For some reason if we don't have a grant type we can usually assume it's authorization code
        else
        {
            AuthorizationCode(sb, authSettings, indent);
            sb.AppendLine();
            Auth(sb, authSettings, indent);
        }

        sb.AppendLine();

        static void AddAccessTokenToHeader(StringBuilder sb, string? headerPrefix, int intIndent)
        {
            headerPrefix ??= "Bearer";
            var indent = Consts.Indent(intIndent);
            sb.AppendLine(indent + $"private async Task {OAuth2Functions.AddAccessTokenToRequest}()");
            sb.AppendLine(indent + "{");
            indent = Consts.Indent(intIndent + 1);
            var accessToken = "accessToken";
            sb.AppendLine(indent + $"var {accessToken} = await {OAuth2Functions.GetAccessToken}();");
            sb.AddDefaultAuthorizationHeader(indent, $"$\"{headerPrefix}\"", accessToken);
            indent = Consts.Indent(intIndent);
            sb.AppendLine(indent + "}");
        }

        static void Implicit(StringBuilder sb, AuthSettings auth, int intIndent)
        {
            var indent = Consts.Indent(intIndent);
            sb.AppendLine(indent + "public async Task DoAuth()");
            sb.AppendLine(indent + "{");
            indent = Consts.Indent(2);
            sb.AppendLine(indent + "var oauthQueryParameters = new OAuth2QueryParameters();");
            sb.AppendLine(indent + "oauthQueryParameters.ResponseType = \"token\";");
            sb.AppendLine(indent + "oauthQueryParameters.ClientId = _clientId;");

            sb.AddCommonApiClientInstanceAuthVariablesToOAuthQueryParameters(auth, indent);

            auth.TryGetAuth2Config(OAuth2Config.AuthUrl, out var authUrl);
            sb.AppendLine(indent + $"var queryString = QueryHelpers.AddQueryString(\"{authUrl}\", oauthQueryParameters.ToDictionary());");
            sb.AppendLine(indent + $"await _httpClient.GetAsync(queryString);");
            indent = Consts.Indent(intIndent);
            sb.AppendLine(indent + "}");
        }

        static void AuthorizationCode(StringBuilder sb, AuthSettings auth, int intIndent)
        {
            var indent = Consts.Indent(intIndent);
            sb.AppendLine(indent + "public async Task DoAuth()");
            sb.AppendLine(indent + "{");
            indent = Consts.Indent(2);
            sb.AppendLine(indent + "var oauthQueryParameters = new OAuth2QueryParameters();");
            sb.AppendLine(indent + "oauthQueryParameters.ResponseType = \"code\";");
            sb.AppendLine(indent + "oauthQueryParameters.ClientId = _clientId;");

            sb.AddCommonApiClientInstanceAuthVariablesToOAuthQueryParameters(auth, indent);

            auth.TryGetAuth2Config(OAuth2Config.AuthUrl, out var authUrl);
            sb.AppendLine(indent + $"var queryString = QueryHelpers.AddQueryString(\"{authUrl}\", oauthQueryParameters.ToDictionary());");
            sb.AppendLine(indent + $"await _httpClient.GetAsync(queryString);");
            indent = Consts.Indent(intIndent);
            sb.AppendLine(indent + "}");
        }
        static void Auth(StringBuilder sb, AuthSettings auth, int intIndent)
        {
            var indent = Consts.Indent(intIndent);
            sb.Append(indent + "public async Task Auth(string code");
            if (auth.TryGetAuth2Config(OAuth2Config.State, out var _))
            {
                sb.Append(", string state");
            }
            sb.AppendLine(")");
            sb.AppendLine(indent + "{");
            indent = Consts.Indent(2);
            sb.AppendLine(indent + $"var encoded = Convert.ToBase64String(Encoding.GetEncoding(\"ISO-8859-1\").GetBytes({OAuth2Properties.ClientId} + \":\" + {OAuth2Properties.ClientSecret}));");
            sb.AppendLine(indent + "_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(\"Basic\", encoded);");
            sb.AppendLine();
            sb.AppendLine(indent + "var oauthQueryParameters = new OAuth2QueryParameters();");
            sb.AppendLine(indent + "oauthQueryParameters.Code = code;");
            sb.AppendLine(indent + "oauthQueryParameters.GrantType = \"authorization_code\";");

            sb.AddCommonApiClientInstanceAuthVariablesToOAuthQueryParameters(auth, indent);

            auth.TryGetAuth2Config(OAuth2Config.AccessTokenUrl, out var accessTokenUrl);
            sb.AppendLine(indent + $"var response = await _httpClient.PostAsync(\"{accessTokenUrl}\", new FormUrlEncodedContent(oauthQueryParameters.ToDictionary()));");
            indent = Consts.Indent(intIndent);
            sb.AppendLine(indent + "}");
        }
    }

    private static void AddCommonApiClientInstanceAuthVariablesToOAuthQueryParameters(this StringBuilder sb, AuthSettings auth, string indent)
    {
        VariableOrEmpty(OAuth2Properties.RedirectUrl, OAuth2Config.RedirectUri, out var redirectUrl);
        sb.AppendLine(indent + $"oauthQueryParameters.RedirectUrl = {redirectUrl};");

        if (VariableOrEmpty(OAuth2Properties.Scope, OAuth2Config.Scope, out var scope))
        {
            sb.AppendLine(indent + $"oauthQueryParameters.Scope = {scope};");
        }

        if (VariableOrEmpty(OAuth2Properties.State, OAuth2Config.State, out var state))
        {
            sb.AppendLine(indent + $"oauthQueryParameters.State = {state};");
        }
        bool VariableOrEmpty(string str, OAuth2Config config, out string value)
        {
            if (!auth.TryGetAuth2Config(config, out var _))
            {
                value = "string.Empty";
                return false;
            }
            value = str;
            return true;
        }
    }

    private static void AddNotImplementedFunction(StringBuilder sb, string functionName, int intIndent, List<string>? paramaters = null, string? returnType = null)
    {
        returnType = returnType == null ? "Task" : $"Task<{returnType}>";
        var indent = Consts.Indent(intIndent);
        sb.AppendLine(indent + "// You must implement this yourself");
        sb.Append(indent + $"private async {returnType} {functionName}(");
        sb.AppendLine(string.Join(", ", paramaters ?? new()) + ")");
        sb.AppendLine(indent + "{");
        indent = Consts.Indent(intIndent + 1);
        sb.AppendLine(indent + "throw new NotImplementedException();");
        indent = Consts.Indent(intIndent);
        sb.AppendLine(indent + "}");
    }

    private static void AddOAuth2Properties(AuthSettings authSettings, StringBuilder sb, string indent)
    {
        sb.AddPrivateReadonlyString(indent, OAuth2Properties.ClientId);
        sb.AddPrivateReadonlyString(indent, OAuth2Properties.ClientSecret);
        if (authSettings.TryGetAuth2Config(OAuth2Config.AccessTokenUrl, out var _))
        {
            sb.AddPrivateReadonlyString(indent, OAuth2Properties.AccessTokenUrl);
        }
        if (authSettings.TryGetAuth2Config(OAuth2Config.RedirectUri, out var _))
        {
            sb.AddPrivateReadonlyString(indent, OAuth2Properties.RedirectUrl);
        }
        if (authSettings.TryGetAuth2Config(OAuth2Config.AuthUrl, out var _))
        {
            sb.AddPrivateReadonlyString(indent, OAuth2Properties.AuthUrl);
        }
        if (authSettings.TryGetAuth2Config(OAuth2Config.RefreshTokenUrl, out var _))
        {
            sb.AddPrivateReadonlyString(indent, OAuth2Properties.RefreshTokenUrl);
        }
        if (authSettings.TryGetAuth2Config(OAuth2Config.Scope, out var _))
        {
            sb.AddPrivateReadonlyString(indent, OAuth2Properties.Scope);
        }
        if (authSettings.TryGetAuth2Config(OAuth2Config.State, out var _))
        {
            sb.AddPrivateReadonlyString(indent, OAuth2Properties.State);
        }
    }
}