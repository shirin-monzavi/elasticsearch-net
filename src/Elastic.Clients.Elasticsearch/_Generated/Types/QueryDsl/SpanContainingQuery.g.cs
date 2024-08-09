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

public sealed partial class SpanContainingQuery
{
	/// <summary>
	/// <para>
	/// Can be any span query.
	/// Matching spans from <c>big</c> that contain matches from <c>little</c> are returned.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("big")]
	public Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery Big { get; set; }

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>
	/// Can be any span query.
	/// Matching spans from <c>big</c> that contain matches from <c>little</c> are returned.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("little")]
	public Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery Little { get; set; }
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.QueryDsl.Query(SpanContainingQuery spanContainingQuery) => Elastic.Clients.Elasticsearch.QueryDsl.Query.SpanContaining(spanContainingQuery);
	public static implicit operator Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery(SpanContainingQuery spanContainingQuery) => Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery.SpanContaining(spanContainingQuery);
}

public sealed partial class SpanContainingQueryDescriptor<TDocument> : SerializableDescriptor<SpanContainingQueryDescriptor<TDocument>>
{
	internal SpanContainingQueryDescriptor(Action<SpanContainingQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SpanContainingQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery BigValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument> BigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>> BigDescriptorAction { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery LittleValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument> LittleDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>> LittleDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>
	/// Can be any span query.
	/// Matching spans from <c>big</c> that contain matches from <c>little</c> are returned.
	/// </para>
	/// </summary>
	public SpanContainingQueryDescriptor<TDocument> Big(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery big)
	{
		BigDescriptor = null;
		BigDescriptorAction = null;
		BigValue = big;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> Big(Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument> descriptor)
	{
		BigValue = null;
		BigDescriptorAction = null;
		BigDescriptor = descriptor;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> Big(Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>> configure)
	{
		BigValue = null;
		BigDescriptor = null;
		BigDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public SpanContainingQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Can be any span query.
	/// Matching spans from <c>big</c> that contain matches from <c>little</c> are returned.
	/// </para>
	/// </summary>
	public SpanContainingQueryDescriptor<TDocument> Little(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery little)
	{
		LittleDescriptor = null;
		LittleDescriptorAction = null;
		LittleValue = little;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> Little(Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument> descriptor)
	{
		LittleValue = null;
		LittleDescriptorAction = null;
		LittleDescriptor = descriptor;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> Little(Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>> configure)
	{
		LittleValue = null;
		LittleDescriptor = null;
		LittleDescriptorAction = configure;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BigDescriptor is not null)
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, BigDescriptor, options);
		}
		else if (BigDescriptorAction is not null)
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>(BigDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, BigValue, options);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (LittleDescriptor is not null)
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, LittleDescriptor, options);
		}
		else if (LittleDescriptorAction is not null)
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>(LittleDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, LittleValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class SpanContainingQueryDescriptor : SerializableDescriptor<SpanContainingQueryDescriptor>
{
	internal SpanContainingQueryDescriptor(Action<SpanContainingQueryDescriptor> configure) => configure.Invoke(this);

	public SpanContainingQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery BigValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor BigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor> BigDescriptorAction { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery LittleValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor LittleDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor> LittleDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>
	/// Can be any span query.
	/// Matching spans from <c>big</c> that contain matches from <c>little</c> are returned.
	/// </para>
	/// </summary>
	public SpanContainingQueryDescriptor Big(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery big)
	{
		BigDescriptor = null;
		BigDescriptorAction = null;
		BigValue = big;
		return Self;
	}

	public SpanContainingQueryDescriptor Big(Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor descriptor)
	{
		BigValue = null;
		BigDescriptorAction = null;
		BigDescriptor = descriptor;
		return Self;
	}

	public SpanContainingQueryDescriptor Big(Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor> configure)
	{
		BigValue = null;
		BigDescriptor = null;
		BigDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public SpanContainingQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Can be any span query.
	/// Matching spans from <c>big</c> that contain matches from <c>little</c> are returned.
	/// </para>
	/// </summary>
	public SpanContainingQueryDescriptor Little(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery little)
	{
		LittleDescriptor = null;
		LittleDescriptorAction = null;
		LittleValue = little;
		return Self;
	}

	public SpanContainingQueryDescriptor Little(Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor descriptor)
	{
		LittleValue = null;
		LittleDescriptorAction = null;
		LittleDescriptor = descriptor;
		return Self;
	}

	public SpanContainingQueryDescriptor Little(Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor> configure)
	{
		LittleValue = null;
		LittleDescriptor = null;
		LittleDescriptorAction = configure;
		return Self;
	}

	public SpanContainingQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BigDescriptor is not null)
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, BigDescriptor, options);
		}
		else if (BigDescriptorAction is not null)
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor(BigDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, BigValue, options);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (LittleDescriptor is not null)
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, LittleDescriptor, options);
		}
		else if (LittleDescriptorAction is not null)
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor(LittleDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, LittleValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
	}
}