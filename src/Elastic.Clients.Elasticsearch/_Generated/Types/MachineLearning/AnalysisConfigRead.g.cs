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

public sealed partial class AnalysisConfigRead
{
	/// <summary>
	/// <para>
	/// The size of the interval that the analysis is aggregated into, typically between <c>5m</c> and <c>1h</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("bucket_span")]
	public Elastic.Clients.Elasticsearch.Duration BucketSpan { get; init; }

	/// <summary>
	/// <para>
	/// If <c>categorization_field_name</c> is specified, you can also define the analyzer that is used to interpret the categorization field.
	/// This property cannot be used at the same time as <c>categorization_filters</c>.
	/// The categorization analyzer specifies how the <c>categorization_field</c> is interpreted by the categorization process.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("categorization_analyzer")]
	public Elastic.Clients.Elasticsearch.MachineLearning.CategorizationAnalyzer? CategorizationAnalyzer { get; init; }

	/// <summary>
	/// <para>
	/// If this property is specified, the values of the specified field will be categorized.
	/// The resulting categories must be used in a detector by setting <c>by_field_name</c>, <c>over_field_name</c>, or <c>partition_field_name</c> to the keyword <c>mlcategory</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("categorization_field_name")]
	public string? CategorizationFieldName { get; init; }

	/// <summary>
	/// <para>
	/// If <c>categorization_field_name</c> is specified, you can also define optional filters.
	/// This property expects an array of regular expressions.
	/// The expressions are used to filter out matching sequences from the categorization field values.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("categorization_filters")]
	public IReadOnlyCollection<string>? CategorizationFilters { get; init; }

	/// <summary>
	/// <para>
	/// An array of detector configuration objects.
	/// Detector configuration objects specify which data fields a job analyzes.
	/// They also specify which analytical functions are used.
	/// You can specify multiple detectors for a job.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("detectors")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.MachineLearning.DetectorRead> Detectors { get; init; }

	/// <summary>
	/// <para>
	/// A comma separated list of influencer field names.
	/// Typically these can be the by, over, or partition fields that are used in the detector configuration.
	/// You might also want to use a field name that is not specifically named in a detector, but is available as part of the input data.
	/// When you use multiple detectors, the use of influencers is recommended as it aggregates results for each influencer entity.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("influencers")]
	public IReadOnlyCollection<string> Influencers { get; init; }

	/// <summary>
	/// <para>
	/// The size of the window in which to expect data that is out of time order.
	/// Defaults to no latency.
	/// If you specify a non-zero value, it must be greater than or equal to one second.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("latency")]
	public Elastic.Clients.Elasticsearch.Duration? Latency { get; init; }

	/// <summary>
	/// <para>
	/// Advanced configuration option.
	/// Affects the pruning of models that have not been updated for the given time duration.
	/// The value must be set to a multiple of the <c>bucket_span</c>.
	/// If set too low, important information may be removed from the model.
	/// Typically, set to <c>30d</c> or longer.
	/// If not set, model pruning only occurs if the model memory status reaches the soft limit or the hard limit.
	/// For jobs created in 8.1 and later, the default value is the greater of <c>30d</c> or 20 times <c>bucket_span</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("model_prune_window")]
	public Elastic.Clients.Elasticsearch.Duration? ModelPruneWindow { get; init; }

	/// <summary>
	/// <para>
	/// This functionality is reserved for internal use.
	/// It is not supported for use in customer environments and is not subject to the support SLA of official GA features.
	/// If set to <c>true</c>, the analysis will automatically find correlations between metrics for a given by field value and report anomalies when those correlations cease to hold.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("multivariate_by_fields")]
	public bool? MultivariateByFields { get; init; }

	/// <summary>
	/// <para>
	/// Settings related to how categorization interacts with partition fields.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("per_partition_categorization")]
	public Elastic.Clients.Elasticsearch.MachineLearning.PerPartitionCategorization? PerPartitionCategorization { get; init; }

	/// <summary>
	/// <para>
	/// If this property is specified, the data that is fed to the job is expected to be pre-summarized.
	/// This property value is the name of the field that contains the count of raw data points that have been summarized.
	/// The same <c>summary_count_field_name</c> applies to all detectors in the job.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("summary_count_field_name")]
	public string? SummaryCountFieldName { get; init; }
}