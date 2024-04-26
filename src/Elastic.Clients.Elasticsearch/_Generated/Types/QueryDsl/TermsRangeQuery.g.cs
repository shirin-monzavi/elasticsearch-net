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

namespace Elastic.Clients.Elasticsearch.QueryDsl;

internal sealed partial class TermsRangeQueryConverter : JsonConverter<TermsRangeQuery>
{
	public override TermsRangeQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var fieldName = reader.GetString();
		reader.Read();
		var variant = new TermsRangeQuery(fieldName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "boost")
				{
					variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
					continue;
				}

				if (property == "from")
				{
					variant.From = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "gt")
				{
					variant.Gt = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "gte")
				{
					variant.Gte = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "lt")
				{
					variant.Lt = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "lte")
				{
					variant.Lte = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "_name")
				{
					variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "relation")
				{
					variant.Relation = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation?>(ref reader, options);
					continue;
				}

				if (property == "to")
				{
					variant.To = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}
			}
		}

		reader.Read();
		return variant;
	}

	public override void Write(Utf8JsonWriter writer, TermsRangeQuery value, JsonSerializerOptions options)
	{
		if (value.Field is null)
			throw new JsonException("Unable to serialize TermsRangeQuery because the `Field` property is not set. Field name queries must include a valid field name.");
		if (!options.TryGetClientSettings(out var settings))
			throw new JsonException("Unable to retrieve client settings required to infer field.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(value.Field));
		writer.WriteStartObject();
		if (value.Boost.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(value.Boost.Value);
		}

		if (!string.IsNullOrEmpty(value.From))
		{
			writer.WritePropertyName("from");
			writer.WriteStringValue(value.From);
		}

		if (!string.IsNullOrEmpty(value.Gt))
		{
			writer.WritePropertyName("gt");
			writer.WriteStringValue(value.Gt);
		}

		if (!string.IsNullOrEmpty(value.Gte))
		{
			writer.WritePropertyName("gte");
			writer.WriteStringValue(value.Gte);
		}

		if (!string.IsNullOrEmpty(value.Lt))
		{
			writer.WritePropertyName("lt");
			writer.WriteStringValue(value.Lt);
		}

		if (!string.IsNullOrEmpty(value.Lte))
		{
			writer.WritePropertyName("lte");
			writer.WriteStringValue(value.Lte);
		}

		if (!string.IsNullOrEmpty(value.QueryName))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(value.QueryName);
		}

		if (value.Relation is not null)
		{
			writer.WritePropertyName("relation");
			JsonSerializer.Serialize(writer, value.Relation, options);
		}

		if (!string.IsNullOrEmpty(value.To))
		{
			writer.WritePropertyName("to");
			writer.WriteStringValue(value.To);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(TermsRangeQueryConverter))]
public sealed partial class TermsRangeQuery
{
	public TermsRangeQuery(Elastic.Clients.Elasticsearch.Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		Field = field;
	}

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public float? Boost { get; set; }
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }
	public string? From { get; set; }

	/// <summary>
	/// <para>Greater than.</para>
	/// </summary>
	public string? Gt { get; set; }

	/// <summary>
	/// <para>Greater than or equal to.</para>
	/// </summary>
	public string? Gte { get; set; }

	/// <summary>
	/// <para>Less than.</para>
	/// </summary>
	public string? Lt { get; set; }

	/// <summary>
	/// <para>Less than or equal to.</para>
	/// </summary>
	public string? Lte { get; set; }
	public string? QueryName { get; set; }

	/// <summary>
	/// <para>Indicates how the range query matches values for `range` fields.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? Relation { get; set; }
	public string? To { get; set; }
}

public sealed partial class TermsRangeQueryDescriptor<TDocument> : SerializableDescriptor<TermsRangeQueryDescriptor<TDocument>>
{
	internal TermsRangeQueryDescriptor(Action<TermsRangeQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public TermsRangeQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? FromValue { get; set; }
	private string? GtValue { get; set; }
	private string? GteValue { get; set; }
	private string? LtValue { get; set; }
	private string? LteValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? RelationValue { get; set; }
	private string? ToValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public TermsRangeQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public TermsRangeQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsRangeQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsRangeQueryDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsRangeQueryDescriptor<TDocument> From(string? from)
	{
		FromValue = from;
		return Self;
	}

	/// <summary>
	/// <para>Greater than.</para>
	/// </summary>
	public TermsRangeQueryDescriptor<TDocument> Gt(string? gt)
	{
		GtValue = gt;
		return Self;
	}

	/// <summary>
	/// <para>Greater than or equal to.</para>
	/// </summary>
	public TermsRangeQueryDescriptor<TDocument> Gte(string? gte)
	{
		GteValue = gte;
		return Self;
	}

	/// <summary>
	/// <para>Less than.</para>
	/// </summary>
	public TermsRangeQueryDescriptor<TDocument> Lt(string? lt)
	{
		LtValue = lt;
		return Self;
	}

	/// <summary>
	/// <para>Less than or equal to.</para>
	/// </summary>
	public TermsRangeQueryDescriptor<TDocument> Lte(string? lte)
	{
		LteValue = lte;
		return Self;
	}

	public TermsRangeQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>Indicates how the range query matches values for `range` fields.</para>
	/// </summary>
	public TermsRangeQueryDescriptor<TDocument> Relation(Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? relation)
	{
		RelationValue = relation;
		return Self;
	}

	public TermsRangeQueryDescriptor<TDocument> To(string? to)
	{
		ToValue = to;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (!string.IsNullOrEmpty(FromValue))
		{
			writer.WritePropertyName("from");
			writer.WriteStringValue(FromValue);
		}

		if (!string.IsNullOrEmpty(GtValue))
		{
			writer.WritePropertyName("gt");
			writer.WriteStringValue(GtValue);
		}

		if (!string.IsNullOrEmpty(GteValue))
		{
			writer.WritePropertyName("gte");
			writer.WriteStringValue(GteValue);
		}

		if (!string.IsNullOrEmpty(LtValue))
		{
			writer.WritePropertyName("lt");
			writer.WriteStringValue(LtValue);
		}

		if (!string.IsNullOrEmpty(LteValue))
		{
			writer.WritePropertyName("lte");
			writer.WriteStringValue(LteValue);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (RelationValue is not null)
		{
			writer.WritePropertyName("relation");
			JsonSerializer.Serialize(writer, RelationValue, options);
		}

		if (!string.IsNullOrEmpty(ToValue))
		{
			writer.WritePropertyName("to");
			writer.WriteStringValue(ToValue);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

public sealed partial class TermsRangeQueryDescriptor : SerializableDescriptor<TermsRangeQueryDescriptor>
{
	internal TermsRangeQueryDescriptor(Action<TermsRangeQueryDescriptor> configure) => configure.Invoke(this);

	public TermsRangeQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? FromValue { get; set; }
	private string? GtValue { get; set; }
	private string? GteValue { get; set; }
	private string? LtValue { get; set; }
	private string? LteValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? RelationValue { get; set; }
	private string? ToValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public TermsRangeQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public TermsRangeQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsRangeQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsRangeQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsRangeQueryDescriptor From(string? from)
	{
		FromValue = from;
		return Self;
	}

	/// <summary>
	/// <para>Greater than.</para>
	/// </summary>
	public TermsRangeQueryDescriptor Gt(string? gt)
	{
		GtValue = gt;
		return Self;
	}

	/// <summary>
	/// <para>Greater than or equal to.</para>
	/// </summary>
	public TermsRangeQueryDescriptor Gte(string? gte)
	{
		GteValue = gte;
		return Self;
	}

	/// <summary>
	/// <para>Less than.</para>
	/// </summary>
	public TermsRangeQueryDescriptor Lt(string? lt)
	{
		LtValue = lt;
		return Self;
	}

	/// <summary>
	/// <para>Less than or equal to.</para>
	/// </summary>
	public TermsRangeQueryDescriptor Lte(string? lte)
	{
		LteValue = lte;
		return Self;
	}

	public TermsRangeQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>Indicates how the range query matches values for `range` fields.</para>
	/// </summary>
	public TermsRangeQueryDescriptor Relation(Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? relation)
	{
		RelationValue = relation;
		return Self;
	}

	public TermsRangeQueryDescriptor To(string? to)
	{
		ToValue = to;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (!string.IsNullOrEmpty(FromValue))
		{
			writer.WritePropertyName("from");
			writer.WriteStringValue(FromValue);
		}

		if (!string.IsNullOrEmpty(GtValue))
		{
			writer.WritePropertyName("gt");
			writer.WriteStringValue(GtValue);
		}

		if (!string.IsNullOrEmpty(GteValue))
		{
			writer.WritePropertyName("gte");
			writer.WriteStringValue(GteValue);
		}

		if (!string.IsNullOrEmpty(LtValue))
		{
			writer.WritePropertyName("lt");
			writer.WriteStringValue(LtValue);
		}

		if (!string.IsNullOrEmpty(LteValue))
		{
			writer.WritePropertyName("lte");
			writer.WriteStringValue(LteValue);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (RelationValue is not null)
		{
			writer.WritePropertyName("relation");
			JsonSerializer.Serialize(writer, RelationValue, options);
		}

		if (!string.IsNullOrEmpty(ToValue))
		{
			writer.WritePropertyName("to");
			writer.WriteStringValue(ToValue);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}