﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using Postman2CSharp.Core.Infrastructure;
using Postman2CSharp.Core.Models.PostmanCollection.Http;
using Postman2CSharp.Core.Models.PostmanCollection.Http.Request;
using Postman2CSharp.Core.Utilities;

namespace Postman2CSharp.Core.Models;

public class ApiResponse
{
    public bool IsSuccessCode => Code is >= 200 and < 300;
    public int Code { get; }
    public string? ClassName { get; set; }
    public string? SourceCode { get; set; }
    public DataType DataType { get; }

    private string? _statusCode;
    public string StatusCode()
    {
        return _statusCode ??= $"Status{Code}{(HttpStatusCode)Code}";
    }

    public ApiResponse(int code, string? className, string? sourceCode, DataType dataType)
    {
        Code = code;
        ClassName = className;
        SourceCode = sourceCode;
        DataType = dataType;
    }
}

public class Field
{
    public required string MemberName { get; set; }
    public required string JsonMemberName { get; set; }
}

public class ClassType
{
    public required string AssignedName { get; set; }
    public required List<Field> Fields { get; set; }
}

public class HttpCall
{
    public required string Name { get; init; }
    public DataType RequestDataType { get; init; }
    public string? RequestSourceCode { get; set; }
    public required Request Request { get; init; }
    public required string? RequestClassName { get; set; }
    public required List<ClassType>? RequestTypes { get; set; }

    public required string? QueryParameterClassName { get; set; }
    public required string? QueryParameterSourceCode { get; set; }
    public required List<ClassType>? QueryParameterTypes { get; init; }

    public required string HttpClientFunction { get; init; }
    public required string? FormDataClassName { get; set; }
    public required string? FormDataSourceCode { get; set; }

    public ApiResponse? SuccessResponse => AllResponses.FirstOrDefault(x => x is {Code: >= 200 and < 300});
    public required List<ApiResponse> AllResponses { get; init; }

    public required List<Header> UniqueHeaders { get; init; }

    public List<HttpCallMethodParameter> MethodParameters()
    {
        List<HttpCallMethodParameter> methodParameters = new();
        if (QueryParameterClassName != null)
        {
            var queryParameters = new HttpCallMethodParameter(HttpCallMethodParameterType.QueryParameters, QueryParameterClassName, "queryParameters");
            methodParameters.Add(queryParameters);
        }

        if (RequestClassName != null)
        {
            var request = new HttpCallMethodParameter(HttpCallMethodParameterType.Request, RequestClassName, "request");
            methodParameters.Add(request);
        }

        if (FormDataClassName != null)
        {
            var formData = new HttpCallMethodParameter(HttpCallMethodParameterType.FormData, FormDataClassName, "formData");
            methodParameters.Add(formData);
        }

        if (RequestDataType == DataType.Html)
        {
            var html = new HttpCallMethodParameter(HttpCallMethodParameterType.RawText, "string", "html");
            methodParameters.Add(html);
        }

        if (RequestDataType == DataType.Xml)
        {
            var xml = new HttpCallMethodParameter(HttpCallMethodParameterType.RawText, "string", "xml");
            methodParameters.Add(xml);
        }

        if (RequestDataType == DataType.Text)
        {
            var text = new HttpCallMethodParameter(HttpCallMethodParameterType.RawText, "string", "text");
            methodParameters.Add(text);
        }

        if (RequestDataType == DataType.Binary)
        {
            methodParameters.Add(new HttpCallMethodParameter(HttpCallMethodParameterType.Stream, "Stream", "stream"));
        }

        foreach (var path in Request.Url.Path ?? new List<Path>())
        {
            if (path.IsVariable())
            {
                var pathVariable = new HttpCallMethodParameter(HttpCallMethodParameterType.Path, "string", path.CsPropertyName(CsharpPropertyType.Local));
                methodParameters.Add(pathVariable);
            }
        }
        return methodParameters;
    }

    public void RenameRequest(string newName)
    {
        if (RequestClassName == null) throw new UnreachableException("RenameRequest");
        RequestSourceCode = RequestSourceCode?.Replace(RequestClassName, newName);
        RequestClassName = newName;
    }

    public void RenameResponses(string oldName, string newName)
    {
        var responses = AllResponses.Where(x => x.ClassName == oldName).ToList();
        if (responses.Count == 0) throw new UnreachableException("RenameResponse");
        foreach (var response in responses)
        {
            response.SourceCode = response.SourceCode?.Replace(response.ClassName!, newName);
            response.ClassName = newName;
        }
    }

    public void RenameFormData(string newName)
    {
        if (FormDataClassName == null) throw new UnreachableException("RenameRequest");
        FormDataSourceCode = FormDataSourceCode?.Replace(FormDataClassName, newName);
        FormDataClassName = newName;
    }

    public void RenameQueryParameters(string newName)
    {
        if (QueryParameterClassName == null) throw new UnreachableException("RenameRequest");
        QueryParameterSourceCode = QueryParameterSourceCode?.Replace(QueryParameterClassName, newName);
        QueryParameterClassName = newName;
    }
}
public record HttpCallMethodParameter(HttpCallMethodParameterType Type, string VariableType, string ParameterName)
{
    public static readonly HttpCallMethodParameter CancellationToken = new (HttpCallMethodParameterType.CancellationToken, "CancellationToken", "cancellationToken = default");
    public string LocalParameterDeclaration => VariableType + " " + ParameterName;
};

public enum HttpCallMethodParameterType
{
    QueryParameters,
    Request,
    FormData,
    RawText,
    Path,
    Stream,
    CancellationToken
}