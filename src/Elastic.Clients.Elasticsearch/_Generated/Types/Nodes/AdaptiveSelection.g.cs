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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Nodes;

public sealed partial class AdaptiveSelection
{
	/// <summary>
	/// <para>
	/// The exponentially weighted moving average queue size of search requests on the keyed node.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("avg_queue_size")]
	public long? AvgQueueSize { get; init; }

	/// <summary>
	/// <para>
	/// The exponentially weighted moving average response time of search requests on the keyed node.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("avg_response_time")]
	public Elastic.Clients.Elasticsearch.Duration? AvgResponseTime { get; init; }

	/// <summary>
	/// <para>
	/// The exponentially weighted moving average response time, in nanoseconds, of search requests on the keyed node.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("avg_response_time_ns")]
	public long? AvgResponseTimeNs { get; init; }

	/// <summary>
	/// <para>
	/// The exponentially weighted moving average service time of search requests on the keyed node.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("avg_service_time")]
	public Elastic.Clients.Elasticsearch.Duration? AvgServiceTime { get; init; }

	/// <summary>
	/// <para>
	/// The exponentially weighted moving average service time, in nanoseconds, of search requests on the keyed node.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("avg_service_time_ns")]
	public long? AvgServiceTimeNs { get; init; }

	/// <summary>
	/// <para>
	/// The number of outstanding search requests to the keyed node from the node these stats are for.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("outgoing_searches")]
	public long? OutgoingSearches { get; init; }

	/// <summary>
	/// <para>
	/// The rank of this node; used for shard selection when routing search requests.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("rank")]
	public string? Rank { get; init; }
}