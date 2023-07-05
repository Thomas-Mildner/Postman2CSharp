﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Serialization;
using Postman2CSharp.Core.Infrastructure;
using Postman2CSharp.Core.Models.PostmanCollection.Authorization;
using Postman2CSharp.Core.Models.PostmanCollection.Http;
using Postman2CSharp.Core.Serialization;
using Postman2CSharp.Core.Utilities;
using Xamasoft.JsonClassGenerator.Models;

namespace Postman2CSharp.Core.Models;

public class DuplicateRoot
{
    public required string ClassName { get; set; }
    public required List<DuplicateRootUsage> Usages { get; set; }
    public required bool Resolved { get; set; }

    [JsonConstructor]
    [SetsRequiredMembers]
    public DuplicateRoot(string className, List<DuplicateRootUsage> usages, bool resolved = false)
    {
        ClassName = className;
        Usages = usages;
        Resolved = resolved;
    }
}
public record DuplicateRootUsage(string HttpCallName, string? IntendedClassName, GeneratedClassType ClassType);

public class ApiClient
{
    private static readonly List<string> ImplicitNamespaces = new() {"System", "System.IO", "System.Net.Http", "System.Threading.Tasks"};
    private static readonly List<string> DefaultApiClientNamespaces = new() { "System.Net.Http.Headers", "System.Text" };

    private bool? _allRequestsInheritAuth;
    public bool AllRequestsInheritAuth => _allRequestsInheritAuth ??= HttpCalls.All(x => x.Request.Auth == null);
    private bool? _allRequestsHaveSameAuth;
    public bool AllRequestsHaveSameAuth
    {
        get
        {
            var firstAuth = HttpCalls.First().Request.Auth;
            if (firstAuth == null)
            {
                return _allRequestsHaveSameAuth ??= false;
            }
            return _allRequestsHaveSameAuth ??= HttpCalls.All(x => x.Request.Auth != null && x.Request.Auth.EnumType() != PostmanAuthType.noauth && x.Request.Auth.EnumType() == firstAuth.EnumType());
        }
    }

    public string Id { get; init; } = Guid.NewGuid().ToString();
    public required string NameSpace { get; set; }
    public required string Name { get; set; }
    public required string? Description { get; set; }
    public string InterfaceName => $"I{Name}";
    public string TestClassName => $"{Name}Tests";
    public string ControllerClassName => $"{NameSpace}Controller";
    public required string TestClassSourceCode { get; set; }
    private string? _controllerSourceCode;
    public required string ControllerSourceCode
    {
        get => _controllerSourceCode ??= ControllerSerializer.SerializeController(this);
        set => _controllerSourceCode = value;
    }
    public required List<DuplicateRoot> DuplicateRoots { get; set; }
    public required string? BaseUrl { get; set; }
    public required List<HttpCall> HttpCalls { get; set; }
    public required List<Header> CommonHeaders { get; set; }
    public required AuthSettings? CollectionAuth { get; set; }
    public required string SourceCode { get; set; }
    public required string InterfaceSourceCode { get; set; }
    public required List<VariableUsage> VariableUsages { get; set; }
    public required ApiClientOptions Options { get; set; }
    public required int TotalClassesGenerated { get; set; }

    private List<AuthSettings>? _uniqueAuths;
    public List<AuthSettings> UniqueAuths => _uniqueAuths ??= GetUniqueAuths();

    private List<AuthSettings> GetUniqueAuths()
    {
        var allRequestAuths = HttpCalls.Select(x => x.Request.Auth).ToList();
        if (AnyRequestInheritsAuth)
        {
            allRequestAuths.Add(CollectionAuth);
        }
        return allRequestAuths
            .Where(x => (x?.EnumType() ?? PostmanAuthType.noauth) != PostmanAuthType.noauth)
            .DistinctBy(x => x!.EnumType()).ToList()!;
    }

    private bool? _anyRequestInheritsAuth;
    private bool AnyRequestInheritsAuth => _anyRequestInheritsAuth ??= HttpCalls.Any(x => x.Request.Auth == null);

    [JsonConstructor]
    [SetsRequiredMembers]
#pragma warning disable CS8618
    public ApiClient(string name, string? description, string nameSpace, string? baseUrl, List<HttpCall> httpCalls,
#pragma warning restore CS8618
        List<Header> commonHeaders, AuthSettings? collectionAuth, List<VariableUsage> variableUsages, ApiClientOptions options, int totalClassesGenerated, List<DuplicateRoot> duplicateRoots)
    {
        Name = name;
        Description = description;
        NameSpace = nameSpace;
        BaseUrl = baseUrl;
        HttpCalls = httpCalls;
        CommonHeaders = commonHeaders;
        CollectionAuth = collectionAuth;
        VariableUsages = variableUsages;
        Options = options;
        TotalClassesGenerated = totalClassesGenerated;
        DuplicateRoots = duplicateRoots;
    }

    public void GenerateSourceCode()
    {
        SourceCode = ApiClientSerializer.SerializeApiClient(this);
        InterfaceSourceCode = InterfaceSerializer.CreateInterface(HttpCalls, NameSpace, Name, Options.MultipleResponseHandling, Options.UseCancellationTokens);
        TestClassSourceCode = TestSerializer.SerializeTestClass(this);
        ControllerSourceCode = ControllerSerializer.SerializeController(this);
    }

    public List<string> NameSpaces()
    {
        var namespaces = new List<string>(DefaultApiClientNamespaces);
        namespaces.AddRange(ImplicitNamespaces);
        if (Options.JsonLibrary == JsonLibrary.SystemTextJson && Options.ErrorHandlingStrategy != ErrorHandlingStrategy.None && Options.CatchExceptionTypes.Contains(CatchExceptionTypes.JsonException))
        {
            namespaces.Add("System.Text.Json");
        }
        else if (Options.JsonLibrary == JsonLibrary.NewtonsoftJson && Options.ErrorHandlingStrategy != ErrorHandlingStrategy.None && Options.CatchExceptionTypes.Contains(CatchExceptionTypes.JsonException))
        {
            namespaces.Add("Newtonsoft.Json");
        }

        if (Options.ErrorHandlingStrategy != ErrorHandlingStrategy.None &&
            Options.ErrorHandlingSinks.Contains(ErrorHandlingSinks.DebugWriteLine))
        {
            namespaces.Add("System.Diagnostics");
        }

        if (HttpCalls.Any(x => x.AllResponses.Count > 1))
        {
            namespaces.Add("System.Net");
        }
        return namespaces;
    }

    public void FixNamespaces(string oldNamespace, string newNewspace)
    {
        foreach (var httpCall in HttpCalls)
        {
            if (httpCall.SuccessResponse?.ClassName != null)
            {
                httpCall.SuccessResponse.SourceCode = httpCall.SuccessResponse.ClassName.Replace($"namespace {oldNamespace}", $"namespace {newNewspace}");
            }
            if (httpCall.RequestClassName != null)
            {
                httpCall.RequestSourceCode = httpCall.RequestSourceCode?.Replace($"namespace {oldNamespace}", $"namespace {newNewspace}");
            }
            if (httpCall.QueryParameterClassName != null)
            {
                httpCall.QueryParameterSourceCode = httpCall.QueryParameterSourceCode?.Replace($"namespace {oldNamespace}", $"namespace {newNewspace}");
            }
            if (httpCall.FormDataClassName != null)
            {
                httpCall.FormDataSourceCode = httpCall.FormDataSourceCode?.Replace($"namespace {oldNamespace}", $"namespace {newNewspace}");
            }
        }
    }

    public int FixCommonClass(string commonClassOld, string commonClassNew)
    {
        int fixedClasses = 0;
        foreach (var httpCall in HttpCalls)
        {
            if (httpCall.RequestClassName == commonClassOld)
            {
                httpCall.RenameRequest(commonClassNew);
                fixedClasses++;
            }
            if (httpCall.AllResponses.Any(x => x.ClassName == commonClassOld))
            {
                httpCall.RenameResponses(commonClassOld, commonClassNew);
                fixedClasses++;
            }
            if (httpCall.QueryParameterClassName == commonClassOld)
            {
                httpCall.RenameQueryParameters(commonClassNew);
                fixedClasses++;
            }
            if (httpCall.FormDataClassName == commonClassOld)
            {
                httpCall.RenameFormData(commonClassNew);
                fixedClasses++;
            }
        }
        return fixedClasses;
    }
    public string? GetClassSourceCode(string className)
    {
        foreach (var httpCall in HttpCalls)
        {
            if (httpCall.RequestClassName == className && !string.IsNullOrWhiteSpace(httpCall.RequestSourceCode))
            {
                return httpCall.RequestSourceCode.ExtractClassDeclaration(className);
            }
            if (httpCall.AllResponses.FirstOrDefault(x => x.ClassName == className) is { } response && response.SourceCode != null)
            {
                return response.SourceCode.ExtractClassDeclaration(className);
            }
            if (httpCall.QueryParameterClassName == className && httpCall.QueryParameterSourceCode != null)
            {
                return httpCall.QueryParameterSourceCode.ExtractClassDeclaration(className);
            }
            if (httpCall.FormDataClassName == className && httpCall.FormDataSourceCode != null)
            {
                return httpCall.FormDataSourceCode.ExtractClassDeclaration(className);
            }
        }
        return null;
    }

}