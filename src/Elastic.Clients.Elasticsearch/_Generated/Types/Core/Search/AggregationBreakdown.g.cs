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

namespace Elastic.Clients.Elasticsearch.Core.Search;

public sealed partial class AggregationBreakdown
{
	[JsonInclude, JsonPropertyName("build_aggregation")]
	public long BuildAggregation { get; init; }
	[JsonInclude, JsonPropertyName("build_aggregation_count")]
	public long BuildAggregationCount { get; init; }
	[JsonInclude, JsonPropertyName("build_leaf_collector")]
	public long BuildLeafCollector { get; init; }
	[JsonInclude, JsonPropertyName("build_leaf_collector_count")]
	public long BuildLeafCollectorCount { get; init; }
	[JsonInclude, JsonPropertyName("collect")]
	public long Collect { get; init; }
	[JsonInclude, JsonPropertyName("collect_count")]
	public long CollectCount { get; init; }
	[JsonInclude, JsonPropertyName("initialize")]
	public long Initialize { get; init; }
	[JsonInclude, JsonPropertyName("initialize_count")]
	public long InitializeCount { get; init; }
	[JsonInclude, JsonPropertyName("post_collection")]
	public long? PostCollection { get; init; }
	[JsonInclude, JsonPropertyName("post_collection_count")]
	public long? PostCollectionCount { get; init; }
	[JsonInclude, JsonPropertyName("reduce")]
	public long Reduce { get; init; }
	[JsonInclude, JsonPropertyName("reduce_count")]
	public long ReduceCount { get; init; }
}