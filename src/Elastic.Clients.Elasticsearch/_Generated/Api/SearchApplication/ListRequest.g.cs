// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.SearchApplication;

public sealed partial class ListRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Starting offset.</para>
	/// </summary>
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>Query in the Lucene query string syntax.</para>
	/// </summary>
	public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

	/// <summary>
	/// <para>Specifies a max number of results to get.</para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>Returns the existing search applications.</para>
/// </summary>
public sealed partial class ListRequest : PlainRequest<ListRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SearchApplicationList;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "search_application.list";

	/// <summary>
	/// <para>Starting offset.</para>
	/// </summary>
	[JsonIgnore]
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>Query in the Lucene query string syntax.</para>
	/// </summary>
	[JsonIgnore]
	public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

	/// <summary>
	/// <para>Specifies a max number of results to get.</para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>Returns the existing search applications.</para>
/// </summary>
public sealed partial class ListRequestDescriptor : RequestDescriptor<ListRequestDescriptor, ListRequestParameters>
{
	internal ListRequestDescriptor(Action<ListRequestDescriptor> configure) => configure.Invoke(this);

	public ListRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SearchApplicationList;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "search_application.list";

	public ListRequestDescriptor From(int? from) => Qs("from", from);
	public ListRequestDescriptor QueryLuceneSyntax(string? queryLuceneSyntax) => Qs("q", queryLuceneSyntax);
	public ListRequestDescriptor Size(int? size) => Qs("size", size);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}