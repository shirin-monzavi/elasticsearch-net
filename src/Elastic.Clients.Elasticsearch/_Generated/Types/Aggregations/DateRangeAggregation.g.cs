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
	internal sealed class DateRangeAggregationConverter : JsonConverter<DateRangeAggregation>
	{
		public override DateRangeAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "date_range")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new DateRangeAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("field"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("format"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("missing"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.Missing?>(ref reader, options);
						if (value is not null)
						{
							agg.Missing = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("ranges"))
					{
						var value = JsonSerializer.Deserialize<IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpression>?>(ref reader, options);
						if (value is not null)
						{
							agg.Ranges = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("time_zone"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.TimeZone = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("keyed"))
					{
						var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
						if (value is not null)
						{
							agg.Keyed = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("aggs") || reader.ValueTextEquals("aggregations"))
					{
						var value = JsonSerializer.Deserialize<AggregationDictionary>(ref reader, options);
						if (value is not null)
						{
							agg.Aggregations = value;
						}

						continue;
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, DateRangeAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("date_range");
			writer.WriteStartObject();
			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.Missing is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, value.Missing, options);
			}

			if (value.Ranges is not null)
			{
				writer.WritePropertyName("ranges");
				JsonSerializer.Serialize(writer, value.Ranges, options);
			}

			if (!string.IsNullOrEmpty(value.TimeZone))
			{
				writer.WritePropertyName("time_zone");
				writer.WriteStringValue(value.TimeZone);
			}

			if (value.Keyed.HasValue)
			{
				writer.WritePropertyName("keyed");
				writer.WriteBooleanValue(value.Keyed.Value);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			if (value.Aggregations is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, value.Aggregations, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(DateRangeAggregationConverter))]
	public partial class DateRangeAggregation : Aggregations.BucketAggregationBase
	{
		public DateRangeAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public Elastic.Clients.Elasticsearch.Aggregations.Missing? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("ranges")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpression>? Ranges { get; set; }

		[JsonInclude]
		[JsonPropertyName("time_zone")]
		public string? TimeZone { get; set; }

		[JsonInclude]
		[JsonPropertyName("keyed")]
		public bool? Keyed { get; set; }
	}

	public sealed partial class DateRangeAggregationDescriptor<TDocument> : DescriptorBase<DateRangeAggregationDescriptor<TDocument>>
	{
		public DateRangeAggregationDescriptor()
		{
		}

		internal DateRangeAggregationDescriptor(Action<DateRangeAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal string? FormatValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.Missing? MissingValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpression>? RangesValue { get; private set; }

		internal string? TimeZoneValue { get; private set; }

		internal bool? KeyedValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> AggregationsDescriptor { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> AggregationsDescriptorAction { get; private set; }

		public DateRangeAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public DateRangeAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public DateRangeAggregationDescriptor<TDocument> Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public DateRangeAggregationDescriptor<TDocument> Missing(Elastic.Clients.Elasticsearch.Aggregations.Missing? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public DateRangeAggregationDescriptor<TDocument> Ranges(IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpression>? ranges) => Assign(ranges, (a, v) => a.RangesValue = v);
		public DateRangeAggregationDescriptor<TDocument> TimeZone(string? timeZone) => Assign(timeZone, (a, v) => a.TimeZoneValue = v);
		public DateRangeAggregationDescriptor<TDocument> Keyed(bool? keyed = true) => Assign(keyed, (a, v) => a.KeyedValue = v);
		public DateRangeAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			return Assign(aggregations, (a, v) => a.AggregationsValue = v);
		}

		public DateRangeAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.AggregationsDescriptor = v);
		}

		public DateRangeAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			return Assign(configure, (a, v) => a.AggregationsDescriptorAction = v);
		}

		public DateRangeAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("date_range");
			writer.WriteStartObject();
			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (RangesValue is not null)
			{
				writer.WritePropertyName("ranges");
				JsonSerializer.Serialize(writer, RangesValue, options);
			}

			if (!string.IsNullOrEmpty(TimeZoneValue))
			{
				writer.WritePropertyName("time_zone");
				writer.WriteStringValue(TimeZoneValue);
			}

			if (KeyedValue.HasValue)
			{
				writer.WritePropertyName("keyed");
				writer.WriteBooleanValue(KeyedValue.Value);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AggregationsDescriptor is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
			}
			else if (AggregationsDescriptorAction is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, new AggregationContainerDescriptor<TDocument>(AggregationsDescriptorAction), options);
			}
			else if (AggregationsValue is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsValue, options);
			}

			writer.WriteEndObject();
		}
	}
}