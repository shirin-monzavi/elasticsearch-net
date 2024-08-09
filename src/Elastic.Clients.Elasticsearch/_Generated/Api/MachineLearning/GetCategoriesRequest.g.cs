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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class GetCategoriesRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Skips the specified number of categories.
	/// </para>
	/// </summary>
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// Only return categories for the specified partition.
	/// </para>
	/// </summary>
	public string? PartitionFieldValue { get => Q<string?>("partition_field_value"); set => Q("partition_field_value", value); }

	/// <summary>
	/// <para>
	/// Specifies the maximum number of categories to obtain.
	/// </para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>
/// Retrieves anomaly detection job results for one or more categories.
/// </para>
/// </summary>
public sealed partial class GetCategoriesRequest : PlainRequest<GetCategoriesRequestParameters>
{
	public GetCategoriesRequest(Elastic.Clients.Elasticsearch.Id jobId, string? categoryId) : base(r => r.Required("job_id", jobId).Optional("category_id", categoryId))
	{
	}

	public GetCategoriesRequest(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetCategories;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.get_categories";

	/// <summary>
	/// <para>
	/// Skips the specified number of categories.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// Only return categories for the specified partition.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public string? PartitionFieldValue { get => Q<string?>("partition_field_value"); set => Q("partition_field_value", value); }

	/// <summary>
	/// <para>
	/// Specifies the maximum number of categories to obtain.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }

	/// <summary>
	/// <para>
	/// Configures pagination.
	/// This parameter has the <c>from</c> and <c>size</c> properties.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("page")]
	public Elastic.Clients.Elasticsearch.MachineLearning.Page? Page { get; set; }
}

/// <summary>
/// <para>
/// Retrieves anomaly detection job results for one or more categories.
/// </para>
/// </summary>
public sealed partial class GetCategoriesRequestDescriptor : RequestDescriptor<GetCategoriesRequestDescriptor, GetCategoriesRequestParameters>
{
	internal GetCategoriesRequestDescriptor(Action<GetCategoriesRequestDescriptor> configure) => configure.Invoke(this);

	public GetCategoriesRequestDescriptor(Elastic.Clients.Elasticsearch.Id jobId, string? categoryId) : base(r => r.Required("job_id", jobId).Optional("category_id", categoryId))
	{
	}

	public GetCategoriesRequestDescriptor(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetCategories;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.get_categories";

	public GetCategoriesRequestDescriptor From(int? from) => Qs("from", from);
	public GetCategoriesRequestDescriptor PartitionFieldValue(string? partitionFieldValue) => Qs("partition_field_value", partitionFieldValue);
	public GetCategoriesRequestDescriptor Size(int? size) => Qs("size", size);

	public GetCategoriesRequestDescriptor CategoryId(string? categoryId)
	{
		RouteValues.Optional("category_id", categoryId);
		return Self;
	}

	public GetCategoriesRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id jobId)
	{
		RouteValues.Required("job_id", jobId);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.MachineLearning.Page? PageValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor PageDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor> PageDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// Configures pagination.
	/// This parameter has the <c>from</c> and <c>size</c> properties.
	/// </para>
	/// </summary>
	public GetCategoriesRequestDescriptor Page(Elastic.Clients.Elasticsearch.MachineLearning.Page? page)
	{
		PageDescriptor = null;
		PageDescriptorAction = null;
		PageValue = page;
		return Self;
	}

	public GetCategoriesRequestDescriptor Page(Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor descriptor)
	{
		PageValue = null;
		PageDescriptorAction = null;
		PageDescriptor = descriptor;
		return Self;
	}

	public GetCategoriesRequestDescriptor Page(Action<Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor> configure)
	{
		PageValue = null;
		PageDescriptor = null;
		PageDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (PageDescriptor is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, PageDescriptor, options);
		}
		else if (PageDescriptorAction is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor(PageDescriptorAction), options);
		}
		else if (PageValue is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, PageValue, options);
		}

		writer.WriteEndObject();
	}
}