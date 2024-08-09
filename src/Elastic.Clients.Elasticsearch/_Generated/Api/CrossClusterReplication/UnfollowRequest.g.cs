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

namespace Elastic.Clients.Elasticsearch.CrossClusterReplication;

public sealed partial class UnfollowRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Stops the following task associated with a follower index and removes index metadata and settings associated with cross-cluster replication.
/// </para>
/// </summary>
public sealed partial class UnfollowRequest : PlainRequest<UnfollowRequestParameters>
{
	public UnfollowRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.CrossClusterReplicationUnfollow;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ccr.unfollow";
}

/// <summary>
/// <para>
/// Stops the following task associated with a follower index and removes index metadata and settings associated with cross-cluster replication.
/// </para>
/// </summary>
public sealed partial class UnfollowRequestDescriptor<TDocument> : RequestDescriptor<UnfollowRequestDescriptor<TDocument>, UnfollowRequestParameters>
{
	internal UnfollowRequestDescriptor(Action<UnfollowRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public UnfollowRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	public UnfollowRequestDescriptor() : this(typeof(TDocument))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.CrossClusterReplicationUnfollow;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ccr.unfollow";

	public UnfollowRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Stops the following task associated with a follower index and removes index metadata and settings associated with cross-cluster replication.
/// </para>
/// </summary>
public sealed partial class UnfollowRequestDescriptor : RequestDescriptor<UnfollowRequestDescriptor, UnfollowRequestParameters>
{
	internal UnfollowRequestDescriptor(Action<UnfollowRequestDescriptor> configure) => configure.Invoke(this);

	public UnfollowRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.CrossClusterReplicationUnfollow;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ccr.unfollow";

	public UnfollowRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}