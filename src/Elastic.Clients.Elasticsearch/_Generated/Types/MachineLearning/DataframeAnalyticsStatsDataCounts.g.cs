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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class DataframeAnalyticsStatsDataCounts
{
	/// <summary>
	/// <para>
	/// The number of documents that are skipped during the analysis because they contained values that are not supported by the analysis. For example, outlier detection does not support missing fields so it skips documents with missing fields. Likewise, all types of analysis skip documents that contain arrays with more than one element.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("skipped_docs_count")]
	public int SkippedDocsCount { get; init; }

	/// <summary>
	/// <para>
	/// The number of documents that are not used for training the model and can be used for testing.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("test_docs_count")]
	public int TestDocsCount { get; init; }

	/// <summary>
	/// <para>
	/// The number of documents that are used for training the model.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("training_docs_count")]
	public int TrainingDocsCount { get; init; }
}