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

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class Category
{
	/// <summary>
	/// <para>A unique identifier for the category. category_id is unique at the job level, even when per-partition categorization is enabled.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("category_id")]
	public long CategoryId { get; init; }

	/// <summary>
	/// <para>A list of examples of actual values that matched the category.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("examples")]
	public IReadOnlyCollection<string> Examples { get; init; }

	/// <summary>
	/// <para>[experimental] A Grok pattern that could be used in Logstash or an ingest pipeline to extract fields from messages that match the category. This field is experimental and may be changed or removed in a future release. The Grok patterns that are found are not optimal, but are often a good starting point for manual tweaking.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("grok_pattern")]
	public string? GrokPattern { get; init; }

	/// <summary>
	/// <para>Identifier for the anomaly detection job.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("job_id")]
	public string JobId { get; init; }

	/// <summary>
	/// <para>The maximum length of the fields that matched the category. The value is increased by 10% to enable matching for similar fields that have not been analyzed.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_matching_length")]
	public long MaxMatchingLength { get; init; }
	[JsonInclude, JsonPropertyName("mlcategory")]
	public string Mlcategory { get; init; }

	/// <summary>
	/// <para>The number of messages that have been matched by this category. This is only guaranteed to have the latest accurate count after a job _flush or _close</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("num_matches")]
	public long? NumMatches { get; init; }
	[JsonInclude, JsonPropertyName("p")]
	public string? p { get; init; }

	/// <summary>
	/// <para>If per-partition categorization is enabled, this property identifies the field used to segment the categorization. It is not present when per-partition categorization is disabled.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("partition_field_name")]
	public string? PartitionFieldName { get; init; }

	/// <summary>
	/// <para>If per-partition categorization is enabled, this property identifies the value of the partition_field_name for the category. It is not present when per-partition categorization is disabled.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("partition_field_value")]
	public string? PartitionFieldValue { get; init; }

	/// <summary>
	/// <para>A list of category_id entries that this current category encompasses. Any new message that is processed by the categorizer will match against this category and not any of the categories in this list. This is only guaranteed to have the latest accurate list of categories after a job _flush or _close</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("preferred_to_categories")]
	public IReadOnlyCollection<string>? PreferredToCategories { get; init; }

	/// <summary>
	/// <para>A regular expression that is used to search for values that match the category.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("regex")]
	public string Regex { get; init; }
	[JsonInclude, JsonPropertyName("result_type")]
	public string ResultType { get; init; }

	/// <summary>
	/// <para>A space separated list of the common tokens that are matched in values of the category.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("terms")]
	public string Terms { get; init; }
}