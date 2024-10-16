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
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class UpdateDataFrameAnalyticsRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Update a data frame analytics job.
/// </para>
/// </summary>
public sealed partial class UpdateDataFrameAnalyticsRequest : PlainRequest<UpdateDataFrameAnalyticsRequestParameters>
{
	public UpdateDataFrameAnalyticsRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningUpdateDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.update_data_frame_analytics";

	/// <summary>
	/// <para>
	/// Specifies whether this job can start when there is insufficient machine
	/// learning node capacity for it to be immediately assigned to a node.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("allow_lazy_start")]
	public bool? AllowLazyStart { get; set; }

	/// <summary>
	/// <para>
	/// A description of the job.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>
	/// The maximum number of threads to be used by the analysis. Using more
	/// threads may decrease the time necessary to complete the analysis at the
	/// cost of using more CPU. Note that the process may use additional threads
	/// for operational functionality other than the analysis itself.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_num_threads")]
	public int? MaxNumThreads { get; set; }

	/// <summary>
	/// <para>
	/// The approximate maximum amount of memory resources that are permitted for
	/// analytical processing. If your <c>elasticsearch.yml</c> file contains an
	/// <c>xpack.ml.max_model_memory_limit</c> setting, an error occurs when you try
	/// to create data frame analytics jobs that have <c>model_memory_limit</c> values
	/// greater than that setting.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("model_memory_limit")]
	public string? ModelMemoryLimit { get; set; }
}

/// <summary>
/// <para>
/// Update a data frame analytics job.
/// </para>
/// </summary>
public sealed partial class UpdateDataFrameAnalyticsRequestDescriptor<TDocument> : RequestDescriptor<UpdateDataFrameAnalyticsRequestDescriptor<TDocument>, UpdateDataFrameAnalyticsRequestParameters>
{
	internal UpdateDataFrameAnalyticsRequestDescriptor(Action<UpdateDataFrameAnalyticsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public UpdateDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningUpdateDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.update_data_frame_analytics";

	public UpdateDataFrameAnalyticsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	private bool? AllowLazyStartValue { get; set; }
	private string? DescriptionValue { get; set; }
	private int? MaxNumThreadsValue { get; set; }
	private string? ModelMemoryLimitValue { get; set; }

	/// <summary>
	/// <para>
	/// Specifies whether this job can start when there is insufficient machine
	/// learning node capacity for it to be immediately assigned to a node.
	/// </para>
	/// </summary>
	public UpdateDataFrameAnalyticsRequestDescriptor<TDocument> AllowLazyStart(bool? allowLazyStart = true)
	{
		AllowLazyStartValue = allowLazyStart;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A description of the job.
	/// </para>
	/// </summary>
	public UpdateDataFrameAnalyticsRequestDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The maximum number of threads to be used by the analysis. Using more
	/// threads may decrease the time necessary to complete the analysis at the
	/// cost of using more CPU. Note that the process may use additional threads
	/// for operational functionality other than the analysis itself.
	/// </para>
	/// </summary>
	public UpdateDataFrameAnalyticsRequestDescriptor<TDocument> MaxNumThreads(int? maxNumThreads)
	{
		MaxNumThreadsValue = maxNumThreads;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The approximate maximum amount of memory resources that are permitted for
	/// analytical processing. If your <c>elasticsearch.yml</c> file contains an
	/// <c>xpack.ml.max_model_memory_limit</c> setting, an error occurs when you try
	/// to create data frame analytics jobs that have <c>model_memory_limit</c> values
	/// greater than that setting.
	/// </para>
	/// </summary>
	public UpdateDataFrameAnalyticsRequestDescriptor<TDocument> ModelMemoryLimit(string? modelMemoryLimit)
	{
		ModelMemoryLimitValue = modelMemoryLimit;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowLazyStartValue.HasValue)
		{
			writer.WritePropertyName("allow_lazy_start");
			writer.WriteBooleanValue(AllowLazyStartValue.Value);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (MaxNumThreadsValue.HasValue)
		{
			writer.WritePropertyName("max_num_threads");
			writer.WriteNumberValue(MaxNumThreadsValue.Value);
		}

		if (!string.IsNullOrEmpty(ModelMemoryLimitValue))
		{
			writer.WritePropertyName("model_memory_limit");
			writer.WriteStringValue(ModelMemoryLimitValue);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Update a data frame analytics job.
/// </para>
/// </summary>
public sealed partial class UpdateDataFrameAnalyticsRequestDescriptor : RequestDescriptor<UpdateDataFrameAnalyticsRequestDescriptor, UpdateDataFrameAnalyticsRequestParameters>
{
	internal UpdateDataFrameAnalyticsRequestDescriptor(Action<UpdateDataFrameAnalyticsRequestDescriptor> configure) => configure.Invoke(this);

	public UpdateDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningUpdateDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.update_data_frame_analytics";

	public UpdateDataFrameAnalyticsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	private bool? AllowLazyStartValue { get; set; }
	private string? DescriptionValue { get; set; }
	private int? MaxNumThreadsValue { get; set; }
	private string? ModelMemoryLimitValue { get; set; }

	/// <summary>
	/// <para>
	/// Specifies whether this job can start when there is insufficient machine
	/// learning node capacity for it to be immediately assigned to a node.
	/// </para>
	/// </summary>
	public UpdateDataFrameAnalyticsRequestDescriptor AllowLazyStart(bool? allowLazyStart = true)
	{
		AllowLazyStartValue = allowLazyStart;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A description of the job.
	/// </para>
	/// </summary>
	public UpdateDataFrameAnalyticsRequestDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The maximum number of threads to be used by the analysis. Using more
	/// threads may decrease the time necessary to complete the analysis at the
	/// cost of using more CPU. Note that the process may use additional threads
	/// for operational functionality other than the analysis itself.
	/// </para>
	/// </summary>
	public UpdateDataFrameAnalyticsRequestDescriptor MaxNumThreads(int? maxNumThreads)
	{
		MaxNumThreadsValue = maxNumThreads;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The approximate maximum amount of memory resources that are permitted for
	/// analytical processing. If your <c>elasticsearch.yml</c> file contains an
	/// <c>xpack.ml.max_model_memory_limit</c> setting, an error occurs when you try
	/// to create data frame analytics jobs that have <c>model_memory_limit</c> values
	/// greater than that setting.
	/// </para>
	/// </summary>
	public UpdateDataFrameAnalyticsRequestDescriptor ModelMemoryLimit(string? modelMemoryLimit)
	{
		ModelMemoryLimitValue = modelMemoryLimit;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowLazyStartValue.HasValue)
		{
			writer.WritePropertyName("allow_lazy_start");
			writer.WriteBooleanValue(AllowLazyStartValue.Value);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (MaxNumThreadsValue.HasValue)
		{
			writer.WritePropertyName("max_num_threads");
			writer.WriteNumberValue(MaxNumThreadsValue.Value);
		}

		if (!string.IsNullOrEmpty(ModelMemoryLimitValue))
		{
			writer.WritePropertyName("model_memory_limit");
			writer.WriteStringValue(ModelMemoryLimitValue);
		}

		writer.WriteEndObject();
	}
}