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
	internal sealed class ParentAggregationConverter : JsonConverter<ParentAggregation>
	{
		public override ParentAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "parent")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new ParentAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("type"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Type = value;
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

		public override void Write(Utf8JsonWriter writer, ParentAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("parent");
			writer.WriteStartObject();
			if (value.Type is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, value.Type, options);
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

	[JsonConverter(typeof(ParentAggregationConverter))]
	public partial class ParentAggregation : Aggregations.BucketAggregationBase
	{
		public ParentAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("type")]
		public string? Type { get; set; }
	}

	public sealed partial class ParentAggregationDescriptor<TDocument> : DescriptorBase<ParentAggregationDescriptor<TDocument>>
	{
		public ParentAggregationDescriptor()
		{
		}

		internal ParentAggregationDescriptor(Action<ParentAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal string? TypeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> AggregationsDescriptor { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> AggregationsDescriptorAction { get; private set; }

		public ParentAggregationDescriptor<TDocument> Type(string? type) => Assign(type, (a, v) => a.TypeValue = v);
		public ParentAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			return Assign(aggregations, (a, v) => a.AggregationsValue = v);
		}

		public ParentAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.AggregationsDescriptor = v);
		}

		public ParentAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			return Assign(configure, (a, v) => a.AggregationsDescriptorAction = v);
		}

		public ParentAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("parent");
			writer.WriteStartObject();
			if (TypeValue is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, TypeValue, options);
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