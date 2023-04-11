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

namespace Elastic.Clients.Elasticsearch.Cluster;

public sealed class ClusterStatsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Return settings in flat format (default: false)</para>
	/// </summary>
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>Period to wait for each node to respond. If a node does not respond before its timeout expires, the response does not include its stats. However, timed out nodes are included in the response’s _nodes.failed property. Defaults to no timeout.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Returns high-level overview of cluster statistics.</para>
/// </summary>
public sealed partial class ClusterStatsRequest : PlainRequest<ClusterStatsRequestParameters>
{
	public ClusterStatsRequest()
	{
	}

	public ClusterStatsRequest(Elastic.Clients.Elasticsearch.NodeIds? node_id) : base(r => r.Optional("node_id", node_id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.ClusterStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	/// <summary>
	/// <para>Return settings in flat format (default: false)</para>
	/// </summary>
	[JsonIgnore]
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>Period to wait for each node to respond. If a node does not respond before its timeout expires, the response does not include its stats. However, timed out nodes are included in the response’s _nodes.failed property. Defaults to no timeout.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Returns high-level overview of cluster statistics.</para>
/// </summary>
public sealed partial class ClusterStatsRequestDescriptor : RequestDescriptor<ClusterStatsRequestDescriptor, ClusterStatsRequestParameters>
{
	internal ClusterStatsRequestDescriptor(Action<ClusterStatsRequestDescriptor> configure) => configure.Invoke(this);

	public ClusterStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.ClusterStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	public ClusterStatsRequestDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
	public ClusterStatsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public ClusterStatsRequestDescriptor NodeId(Elastic.Clients.Elasticsearch.NodeIds? node_id)
	{
		RouteValues.Optional("node_id", node_id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}