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

namespace Elastic.Clients.Elasticsearch.TransformManagement;

[JsonConverter(typeof(PivotGroupByConverter))]
public sealed partial class PivotGroupBy
{
	internal PivotGroupBy(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantName = variantName;
		Variant = variant;
	}

	internal object Variant { get; }
	internal string VariantName { get; }

	public static PivotGroupBy DateHistogram(Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregation dateHistogramAggregation) => new PivotGroupBy("date_histogram", dateHistogramAggregation);
	public static PivotGroupBy Histogram(Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregation histogramAggregation) => new PivotGroupBy("histogram", histogramAggregation);
	public static PivotGroupBy Terms(Elastic.Clients.Elasticsearch.Aggregations.TermsAggregation termsAggregation) => new PivotGroupBy("terms", termsAggregation);
}

internal sealed partial class PivotGroupByConverter : JsonConverter<PivotGroupBy>
{
	public override PivotGroupBy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		reader.Read();
		if (reader.TokenType != JsonTokenType.PropertyName)
		{
			throw new JsonException("Expected a property name token representing the variant held within this container.");
		}

		var propertyName = reader.GetString();
		reader.Read();
		if (propertyName == "date_histogram")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregation?>(ref reader, options);
			reader.Read();
			return new PivotGroupBy(propertyName, variant);
		}

		if (propertyName == "histogram")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregation?>(ref reader, options);
			reader.Read();
			return new PivotGroupBy(propertyName, variant);
		}

		if (propertyName == "terms")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.TermsAggregation?>(ref reader, options);
			reader.Read();
			return new PivotGroupBy(propertyName, variant);
		}

		throw new JsonException();
	}

	public override void Write(Utf8JsonWriter writer, PivotGroupBy value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.VariantName is not null & value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "date_histogram":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregation>(writer, (Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregation)value.Variant, options);
					break;
				case "histogram":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregation>(writer, (Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregation)value.Variant, options);
					break;
				case "terms":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Aggregations.TermsAggregation>(writer, (Elastic.Clients.Elasticsearch.Aggregations.TermsAggregation)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class PivotGroupByDescriptor<TDocument> : SerializableDescriptor<PivotGroupByDescriptor<TDocument>>
{
	internal PivotGroupByDescriptor(Action<PivotGroupByDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PivotGroupByDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private PivotGroupByDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private PivotGroupByDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public PivotGroupByDescriptor<TDocument> DateHistogram(Aggregations.DateHistogramAggregation dateHistogramAggregation) => Set(dateHistogramAggregation, "date_histogram");
	public PivotGroupByDescriptor<TDocument> DateHistogram(Action<Aggregations.DateHistogramAggregationDescriptor<TDocument>> configure) => Set(configure, "date_histogram");
	public PivotGroupByDescriptor<TDocument> Histogram(Aggregations.HistogramAggregation histogramAggregation) => Set(histogramAggregation, "histogram");
	public PivotGroupByDescriptor<TDocument> Histogram(Action<Aggregations.HistogramAggregationDescriptor<TDocument>> configure) => Set(configure, "histogram");
	public PivotGroupByDescriptor<TDocument> Terms(Aggregations.TermsAggregation termsAggregation) => Set(termsAggregation, "terms");
	public PivotGroupByDescriptor<TDocument> Terms(Action<Aggregations.TermsAggregationDescriptor<TDocument>> configure) => Set(configure, "terms");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
		writer.WritePropertyName(ContainedVariantName);
		if (Variant is not null)
		{
			JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			writer.WriteEndObject();
			return;
		}

		JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		writer.WriteEndObject();
	}
}

public sealed partial class PivotGroupByDescriptor : SerializableDescriptor<PivotGroupByDescriptor>
{
	internal PivotGroupByDescriptor(Action<PivotGroupByDescriptor> configure) => configure.Invoke(this);

	public PivotGroupByDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private PivotGroupByDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private PivotGroupByDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public PivotGroupByDescriptor DateHistogram(Aggregations.DateHistogramAggregation dateHistogramAggregation) => Set(dateHistogramAggregation, "date_histogram");
	public PivotGroupByDescriptor DateHistogram(Action<Aggregations.DateHistogramAggregationDescriptor> configure) => Set(configure, "date_histogram");
	public PivotGroupByDescriptor DateHistogram<TDocument>(Action<Aggregations.DateHistogramAggregationDescriptor<TDocument>> configure) => Set(configure, "date_histogram");
	public PivotGroupByDescriptor Histogram(Aggregations.HistogramAggregation histogramAggregation) => Set(histogramAggregation, "histogram");
	public PivotGroupByDescriptor Histogram(Action<Aggregations.HistogramAggregationDescriptor> configure) => Set(configure, "histogram");
	public PivotGroupByDescriptor Histogram<TDocument>(Action<Aggregations.HistogramAggregationDescriptor<TDocument>> configure) => Set(configure, "histogram");
	public PivotGroupByDescriptor Terms(Aggregations.TermsAggregation termsAggregation) => Set(termsAggregation, "terms");
	public PivotGroupByDescriptor Terms(Action<Aggregations.TermsAggregationDescriptor> configure) => Set(configure, "terms");
	public PivotGroupByDescriptor Terms<TDocument>(Action<Aggregations.TermsAggregationDescriptor<TDocument>> configure) => Set(configure, "terms");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
		writer.WritePropertyName(ContainedVariantName);
		if (Variant is not null)
		{
			JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			writer.WriteEndObject();
			return;
		}

		JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		writer.WriteEndObject();
	}
}