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
	internal sealed class MovingFunctionAggregationConverter : JsonConverter<MovingFunctionAggregation>
	{
		public override MovingFunctionAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "moving_fn")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new MovingFunctionAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("shift"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.Shift = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("window"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.Window = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("buckets_path"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.BucketsPath?>(ref reader, options);
						if (value is not null)
						{
							agg.BucketsPath = value;
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

					if (reader.ValueTextEquals("gap_policy"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.GapPolicy?>(ref reader, options);
						if (value is not null)
						{
							agg.GapPolicy = value;
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
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, MovingFunctionAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("moving_fn");
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(value.Script))
			{
				writer.WritePropertyName("script");
				writer.WriteStringValue(value.Script);
			}

			if (value.Shift.HasValue)
			{
				writer.WritePropertyName("shift");
				writer.WriteNumberValue(value.Shift.Value);
			}

			if (value.Window.HasValue)
			{
				writer.WritePropertyName("window");
				writer.WriteNumberValue(value.Window.Value);
			}

			if (value.BucketsPath is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, value.BucketsPath, options);
			}

			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.GapPolicy is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, value.GapPolicy, options);
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

	[JsonConverter(typeof(MovingFunctionAggregationConverter))]
	public partial class MovingFunctionAggregation : Aggregations.PipelineAggregationBase
	{
		public MovingFunctionAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("script")]
		public string? Script { get; set; }

		[JsonInclude]
		[JsonPropertyName("shift")]
		public int? Shift { get; set; }

		[JsonInclude]
		[JsonPropertyName("window")]
		public int? Window { get; set; }
	}

	public sealed partial class MovingFunctionAggregationDescriptor : DescriptorBase<MovingFunctionAggregationDescriptor>
	{
		public MovingFunctionAggregationDescriptor()
		{
		}

		internal MovingFunctionAggregationDescriptor(Action<MovingFunctionAggregationDescriptor> configure) => configure.Invoke(this);
		internal string? ScriptValue { get; private set; }

		internal int? ShiftValue { get; private set; }

		internal int? WindowValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; private set; }

		internal string? FormatValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		public MovingFunctionAggregationDescriptor Script(string? script) => Assign(script, (a, v) => a.ScriptValue = v);
		public MovingFunctionAggregationDescriptor Shift(int? shift) => Assign(shift, (a, v) => a.ShiftValue = v);
		public MovingFunctionAggregationDescriptor Window(int? window) => Assign(window, (a, v) => a.WindowValue = v);
		public MovingFunctionAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath) => Assign(bucketsPath, (a, v) => a.BucketsPathValue = v);
		public MovingFunctionAggregationDescriptor Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public MovingFunctionAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy) => Assign(gapPolicy, (a, v) => a.GapPolicyValue = v);
		public MovingFunctionAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("moving_fn");
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(ScriptValue))
			{
				writer.WritePropertyName("script");
				writer.WriteStringValue(ScriptValue);
			}

			if (ShiftValue.HasValue)
			{
				writer.WritePropertyName("shift");
				writer.WriteNumberValue(ShiftValue.Value);
			}

			if (WindowValue.HasValue)
			{
				writer.WritePropertyName("window");
				writer.WriteNumberValue(WindowValue.Value);
			}

			if (BucketsPathValue is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, BucketsPathValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (GapPolicyValue is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, GapPolicyValue, options);
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