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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	internal sealed class CardinalityAggregationConverter : JsonConverter<CardinalityAggregation>
	{
		public override CardinalityAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			return new CardinalityAggregation("");
		}

		public override void Write(Utf8JsonWriter writer, CardinalityAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("cardinality");
			writer.WriteStartObject();
			if (value.PrecisionThreshold.HasValue)
			{
				writer.WritePropertyName("precision_threshold");
				writer.WriteNumberValue(value.PrecisionThreshold.Value);
			}

			if (value.Rehash.HasValue)
			{
				writer.WritePropertyName("rehash");
				writer.WriteBooleanValue(value.Rehash.Value);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (value.Missing is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, value.Missing, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(CardinalityAggregationConverter))]
	public partial class CardinalityAggregation : Aggregations.MetricAggregationBase
	{
		public CardinalityAggregation(string name, Field field) : base(name) => Field = field;
		public CardinalityAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("precision_threshold")]
		public int? PrecisionThreshold { get; set; }

		[JsonInclude]
		[JsonPropertyName("rehash")]
		public bool? Rehash { get; set; }
	}

	public sealed partial class CardinalityAggregationDescriptor<T> : DescriptorBase<CardinalityAggregationDescriptor<T>>
	{
		public CardinalityAggregationDescriptor()
		{
		}

		internal CardinalityAggregationDescriptor(Action<CardinalityAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal int? PrecisionThresholdValue { get; private set; }

		internal bool? RehashValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.Missing? MissingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? ScriptValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		public CardinalityAggregationDescriptor<T> PrecisionThreshold(int? precisionThreshold) => Assign(precisionThreshold, (a, v) => a.PrecisionThresholdValue = v);
		public CardinalityAggregationDescriptor<T> Rehash(bool? rehash = true) => Assign(rehash, (a, v) => a.RehashValue = v);
		public CardinalityAggregationDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public CardinalityAggregationDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public CardinalityAggregationDescriptor<T> Missing(Elastic.Clients.Elasticsearch.Aggregations.Missing? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public CardinalityAggregationDescriptor<T> Script(Elastic.Clients.Elasticsearch.Script? script) => Assign(script, (a, v) => a.ScriptValue = v);
		public CardinalityAggregationDescriptor<T> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("cardinality");
			writer.WriteStartObject();
			if (PrecisionThresholdValue.HasValue)
			{
				writer.WritePropertyName("precision_threshold");
				writer.WriteNumberValue(PrecisionThresholdValue.Value);
			}

			if (RehashValue.HasValue)
			{
				writer.WritePropertyName("rehash");
				writer.WriteBooleanValue(RehashValue.Value);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}