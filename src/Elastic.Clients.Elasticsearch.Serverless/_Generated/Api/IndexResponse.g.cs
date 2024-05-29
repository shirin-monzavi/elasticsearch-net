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
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport.Products.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class IndexResponse : ElasticsearchResponse
{
	[JsonInclude, JsonPropertyName("forced_refresh")]
	public bool? ForcedRefresh { get; init; }
	[JsonInclude, JsonPropertyName("_id")]
	public string Id { get; init; }
	[JsonInclude, JsonPropertyName("_index")]
	public string Index { get; init; }
	[JsonInclude, JsonPropertyName("_primary_term")]
	public long? PrimaryTerm { get; init; }
	[JsonInclude, JsonPropertyName("result")]
	public Elastic.Clients.Elasticsearch.Serverless.Result Result { get; init; }
	[JsonInclude, JsonPropertyName("_seq_no")]
	public long? SeqNo { get; init; }
	[JsonInclude, JsonPropertyName("_shards")]
	public Elastic.Clients.Elasticsearch.Serverless.ShardStatistics Shards { get; init; }
	[JsonInclude, JsonPropertyName("_version")]
	public long Version { get; init; }
}