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

namespace Elastic.Clients.Elasticsearch.Aggregations;

public sealed partial class AdjacencyMatrixAggregation
{
	/// <summary>
	/// <para>
	/// Filters used to create buckets.
	/// At least one filter is required.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filters")]
	public IDictionary<string, Elastic.Clients.Elasticsearch.QueryDsl.Query>? Filters { get; set; }

	/// <summary>
	/// <para>
	/// Separator used to concatenate filter names. Defaults to &amp;.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("separator")]
	public string? Separator { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(AdjacencyMatrixAggregation adjacencyMatrixAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.AdjacencyMatrix(adjacencyMatrixAggregation);
}

public sealed partial class AdjacencyMatrixAggregationDescriptor<TDocument> : SerializableDescriptor<AdjacencyMatrixAggregationDescriptor<TDocument>>
{
	internal AdjacencyMatrixAggregationDescriptor(Action<AdjacencyMatrixAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public AdjacencyMatrixAggregationDescriptor() : base()
	{
	}

	private IDictionary<string, Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> FiltersValue { get; set; }
	private string? SeparatorValue { get; set; }

	/// <summary>
	/// <para>
	/// Filters used to create buckets.
	/// At least one filter is required.
	/// </para>
	/// </summary>
	public AdjacencyMatrixAggregationDescriptor<TDocument> Filters(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>> selector)
	{
		FiltersValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Separator used to concatenate filter names. Defaults to &amp;.
	/// </para>
	/// </summary>
	public AdjacencyMatrixAggregationDescriptor<TDocument> Separator(string? separator)
	{
		SeparatorValue = separator;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FiltersValue is not null)
		{
			writer.WritePropertyName("filters");
			JsonSerializer.Serialize(writer, FiltersValue, options);
		}

		if (!string.IsNullOrEmpty(SeparatorValue))
		{
			writer.WritePropertyName("separator");
			writer.WriteStringValue(SeparatorValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class AdjacencyMatrixAggregationDescriptor : SerializableDescriptor<AdjacencyMatrixAggregationDescriptor>
{
	internal AdjacencyMatrixAggregationDescriptor(Action<AdjacencyMatrixAggregationDescriptor> configure) => configure.Invoke(this);

	public AdjacencyMatrixAggregationDescriptor() : base()
	{
	}

	private IDictionary<string, Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> FiltersValue { get; set; }
	private string? SeparatorValue { get; set; }

	/// <summary>
	/// <para>
	/// Filters used to create buckets.
	/// At least one filter is required.
	/// </para>
	/// </summary>
	public AdjacencyMatrixAggregationDescriptor Filters(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>> selector)
	{
		FiltersValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Separator used to concatenate filter names. Defaults to &amp;.
	/// </para>
	/// </summary>
	public AdjacencyMatrixAggregationDescriptor Separator(string? separator)
	{
		SeparatorValue = separator;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FiltersValue is not null)
		{
			writer.WritePropertyName("filters");
			JsonSerializer.Serialize(writer, FiltersValue, options);
		}

		if (!string.IsNullOrEmpty(SeparatorValue))
		{
			writer.WritePropertyName("separator");
			writer.WriteStringValue(SeparatorValue);
		}

		writer.WriteEndObject();
	}
}