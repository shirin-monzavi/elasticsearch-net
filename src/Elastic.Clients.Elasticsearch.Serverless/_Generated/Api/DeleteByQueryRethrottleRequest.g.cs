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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class DeleteByQueryRethrottleRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// The throttle for this request in sub-requests per second.
	/// </para>
	/// </summary>
	public float? RequestsPerSecond { get => Q<float?>("requests_per_second"); set => Q("requests_per_second", value); }
}

/// <summary>
/// <para>
/// Changes the number of requests per second for a particular Delete By Query operation.
/// </para>
/// </summary>
public sealed partial class DeleteByQueryRethrottleRequest : PlainRequest<DeleteByQueryRethrottleRequestParameters>
{
	public DeleteByQueryRethrottleRequest(Elastic.Clients.Elasticsearch.Serverless.TaskId taskId) : base(r => r.Required("task_id", taskId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceDeleteByQueryRethrottle;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "delete_by_query_rethrottle";

	/// <summary>
	/// <para>
	/// The throttle for this request in sub-requests per second.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public float? RequestsPerSecond { get => Q<float?>("requests_per_second"); set => Q("requests_per_second", value); }
}

/// <summary>
/// <para>
/// Changes the number of requests per second for a particular Delete By Query operation.
/// </para>
/// </summary>
public sealed partial class DeleteByQueryRethrottleRequestDescriptor : RequestDescriptor<DeleteByQueryRethrottleRequestDescriptor, DeleteByQueryRethrottleRequestParameters>
{
	internal DeleteByQueryRethrottleRequestDescriptor(Action<DeleteByQueryRethrottleRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteByQueryRethrottleRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.TaskId taskId) : base(r => r.Required("task_id", taskId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceDeleteByQueryRethrottle;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "delete_by_query_rethrottle";

	public DeleteByQueryRethrottleRequestDescriptor RequestsPerSecond(float? requestsPerSecond) => Qs("requests_per_second", requestsPerSecond);

	public DeleteByQueryRethrottleRequestDescriptor TaskId(Elastic.Clients.Elasticsearch.Serverless.TaskId taskId)
	{
		RouteValues.Required("task_id", taskId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}