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

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

internal sealed class MedianAbsoluteDeviationAggregationConverter : JsonConverter<MedianAbsoluteDeviationAggregation>
{
	public override MedianAbsoluteDeviationAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "median_absolute_deviation")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new MedianAbsoluteDeviationAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("compression"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<double?>(ref reader, options);
					if (value is not null)
					{
						agg.Compression = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("field"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Field?>(ref reader, options);
					if (value is not null)
					{
						agg.Field = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("format"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.Format = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("missing"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<FieldValue?>(ref reader, options);
					if (value is not null)
					{
						agg.Missing = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.Script = value;
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

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, MedianAbsoluteDeviationAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("median_absolute_deviation");
		writer.WriteStartObject();
		if (value.Compression.HasValue)
		{
			writer.WritePropertyName("compression");
			writer.WriteNumberValue(value.Compression.Value);
		}

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

[JsonConverter(typeof(MedianAbsoluteDeviationAggregationConverter))]
public sealed partial class MedianAbsoluteDeviationAggregation : SearchAggregation
{
	public MedianAbsoluteDeviationAggregation(string name, Field field) : this(name) => Field = field;
	public MedianAbsoluteDeviationAggregation(string name) => Name = name;

	internal MedianAbsoluteDeviationAggregation()
	{
	}

	/// <summary>
	/// <para>Limits the maximum number of nodes used by the underlying TDigest algorithm to `20 * compression`, enabling control of memory usage and approximation error.</para>
	/// </summary>
	public double? Compression { get; set; }
	public Elastic.Clients.Elasticsearch.Serverless.Field? Field { get; set; }
	public string? Format { get; set; }
	public IDictionary<string, object>? Meta { get; set; }
	public FieldValue? Missing { get; set; }
	override public string? Name { get; internal set; }
	public Elastic.Clients.Elasticsearch.Serverless.Script? Script { get; set; }
}

public sealed partial class MedianAbsoluteDeviationAggregationDescriptor<TDocument> : SerializableDescriptor<MedianAbsoluteDeviationAggregationDescriptor<TDocument>>
{
	internal MedianAbsoluteDeviationAggregationDescriptor(Action<MedianAbsoluteDeviationAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MedianAbsoluteDeviationAggregationDescriptor() : base()
	{
	}

	private double? CompressionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }

	/// <summary>
	/// <para>Limits the maximum number of nodes used by the underlying TDigest algorithm to `20 * compression`, enabling control of memory usage and approximation error.</para>
	/// </summary>
	public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Compression(double? compression)
	{
		CompressionValue = compression;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("median_absolute_deviation");
		writer.WriteStartObject();
		if (CompressionValue.HasValue)
		{
			writer.WritePropertyName("compression");
			writer.WriteNumberValue(CompressionValue.Value);
		}

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

public sealed partial class MedianAbsoluteDeviationAggregationDescriptor : SerializableDescriptor<MedianAbsoluteDeviationAggregationDescriptor>
{
	internal MedianAbsoluteDeviationAggregationDescriptor(Action<MedianAbsoluteDeviationAggregationDescriptor> configure) => configure.Invoke(this);

	public MedianAbsoluteDeviationAggregationDescriptor() : base()
	{
	}

	private double? CompressionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }

	/// <summary>
	/// <para>Limits the maximum number of nodes used by the underlying TDigest algorithm to `20 * compression`, enabling control of memory usage and approximation error.</para>
	/// </summary>
	public MedianAbsoluteDeviationAggregationDescriptor Compression(double? compression)
	{
		CompressionValue = compression;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public MedianAbsoluteDeviationAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("median_absolute_deviation");
		writer.WriteStartObject();
		if (CompressionValue.HasValue)
		{
			writer.WritePropertyName("compression");
			writer.WriteNumberValue(CompressionValue.Value);
		}

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