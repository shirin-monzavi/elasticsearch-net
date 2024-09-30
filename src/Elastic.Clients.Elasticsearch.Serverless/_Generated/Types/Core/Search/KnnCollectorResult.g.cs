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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Core.Search;

public sealed partial class KnnCollectorResult
{
	[JsonInclude, JsonPropertyName("children")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Core.Search.KnnCollectorResult>? Children { get; init; }
	[JsonInclude, JsonPropertyName("name")]
	public string Name { get; init; }
	[JsonInclude, JsonPropertyName("reason")]
	public string Reason { get; init; }
	[JsonInclude, JsonPropertyName("time")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Time { get; init; }
	[JsonInclude, JsonPropertyName("time_in_nanos")]
	public long TimeInNanos { get; init; }
}