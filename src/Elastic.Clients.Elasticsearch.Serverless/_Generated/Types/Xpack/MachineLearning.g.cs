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

namespace Elastic.Clients.Elasticsearch.Serverless.Xpack;

public sealed partial class MachineLearning
{
	[JsonInclude, JsonPropertyName("available")]
	public bool Available { get; init; }
	[JsonInclude, JsonPropertyName("datafeeds")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Serverless.Xpack.Datafeed> Datafeeds { get; init; }
	[JsonInclude, JsonPropertyName("data_frame_analytics_jobs")]
	public Elastic.Clients.Elasticsearch.Serverless.Xpack.MlDataFrameAnalyticsJobs DataFrameAnalyticsJobs { get; init; }
	[JsonInclude, JsonPropertyName("enabled")]
	public bool Enabled { get; init; }
	[JsonInclude, JsonPropertyName("inference")]
	public Elastic.Clients.Elasticsearch.Serverless.Xpack.MlInference Inference { get; init; }

	/// <summary>
	/// <para>
	/// Job usage statistics. The <c>_all</c> entry is always present and gathers statistics for all jobs.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("jobs")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Serverless.Xpack.JobUsage> Jobs { get; init; }
	[JsonInclude, JsonPropertyName("node_count")]
	public int NodeCount { get; init; }
}