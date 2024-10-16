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
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Sql;

public sealed partial class GetAsyncStatusRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Returns the current status of an async SQL search or a stored synchronous SQL search
/// </para>
/// </summary>
public sealed partial class GetAsyncStatusRequest : PlainRequest<GetAsyncStatusRequestParameters>
{
	public GetAsyncStatusRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlGetAsyncStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "sql.get_async_status";
}

/// <summary>
/// <para>
/// Returns the current status of an async SQL search or a stored synchronous SQL search
/// </para>
/// </summary>
public sealed partial class GetAsyncStatusRequestDescriptor<TDocument> : RequestDescriptor<GetAsyncStatusRequestDescriptor<TDocument>, GetAsyncStatusRequestParameters>
{
	internal GetAsyncStatusRequestDescriptor(Action<GetAsyncStatusRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GetAsyncStatusRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlGetAsyncStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "sql.get_async_status";

	public GetAsyncStatusRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Returns the current status of an async SQL search or a stored synchronous SQL search
/// </para>
/// </summary>
public sealed partial class GetAsyncStatusRequestDescriptor : RequestDescriptor<GetAsyncStatusRequestDescriptor, GetAsyncStatusRequestParameters>
{
	internal GetAsyncStatusRequestDescriptor(Action<GetAsyncStatusRequestDescriptor> configure) => configure.Invoke(this);

	public GetAsyncStatusRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlGetAsyncStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "sql.get_async_status";

	public GetAsyncStatusRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}