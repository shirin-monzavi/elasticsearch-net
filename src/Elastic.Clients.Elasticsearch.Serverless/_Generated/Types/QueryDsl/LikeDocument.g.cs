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

namespace Elastic.Clients.Elasticsearch.Serverless.QueryDsl;

public sealed partial class LikeDocument
{
	/// <summary>
	/// <para>ID of a document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_id")]
	public Elastic.Clients.Elasticsearch.Serverless.Id? Id { get; set; }

	/// <summary>
	/// <para>Index of a document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_index")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexName? Index { get; set; }

	/// <summary>
	/// <para>A document not present in the index.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("doc")]
	public object? Doc { get; set; }
	[JsonInclude, JsonPropertyName("fields")]
	public Fields? Fields { get; set; }
	[JsonInclude, JsonPropertyName("per_field_analyzer")]
	public IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, string>? PerFieldAnalyzer { get; set; }
	[JsonInclude, JsonPropertyName("routing")]
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get; set; }
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; set; }
	[JsonInclude, JsonPropertyName("version_type")]
	public Elastic.Clients.Elasticsearch.Serverless.VersionType? VersionType { get; set; }
}

public sealed partial class LikeDocumentDescriptor<TDocument> : SerializableDescriptor<LikeDocumentDescriptor<TDocument>>
{
	internal LikeDocumentDescriptor(Action<LikeDocumentDescriptor<TDocument>> configure) => configure.Invoke(this);

	public LikeDocumentDescriptor() : base()
	{
	}

	private object? DocValue { get; set; }
	private Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Id? IdValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexName? IndexValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, string>? PerFieldAnalyzerValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Routing? RoutingValue { get; set; }
	private long? VersionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.VersionType? VersionTypeValue { get; set; }

	/// <summary>
	/// <para>A document not present in the index.</para>
	/// </summary>
	public LikeDocumentDescriptor<TDocument> Doc(object? doc)
	{
		DocValue = doc;
		return Self;
	}

	public LikeDocumentDescriptor<TDocument> Fields(Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>ID of a document.</para>
	/// </summary>
	public LikeDocumentDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id? id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>Index of a document.</para>
	/// </summary>
	public LikeDocumentDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.Serverless.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	public LikeDocumentDescriptor<TDocument> PerFieldAnalyzer(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, string>, FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, string>> selector)
	{
		PerFieldAnalyzerValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, string>());
		return Self;
	}

	public LikeDocumentDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	public LikeDocumentDescriptor<TDocument> Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	public LikeDocumentDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.Serverless.VersionType? versionType)
	{
		VersionTypeValue = versionType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DocValue is not null)
		{
			writer.WritePropertyName("doc");
			JsonSerializer.Serialize(writer, DocValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IdValue is not null)
		{
			writer.WritePropertyName("_id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (IndexValue is not null)
		{
			writer.WritePropertyName("_index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (PerFieldAnalyzerValue is not null)
		{
			writer.WritePropertyName("per_field_analyzer");
			JsonSerializer.Serialize(writer, PerFieldAnalyzerValue, options);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		if (VersionTypeValue is not null)
		{
			writer.WritePropertyName("version_type");
			JsonSerializer.Serialize(writer, VersionTypeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class LikeDocumentDescriptor : SerializableDescriptor<LikeDocumentDescriptor>
{
	internal LikeDocumentDescriptor(Action<LikeDocumentDescriptor> configure) => configure.Invoke(this);

	public LikeDocumentDescriptor() : base()
	{
	}

	private object? DocValue { get; set; }
	private Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Id? IdValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexName? IndexValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, string>? PerFieldAnalyzerValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Routing? RoutingValue { get; set; }
	private long? VersionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.VersionType? VersionTypeValue { get; set; }

	/// <summary>
	/// <para>A document not present in the index.</para>
	/// </summary>
	public LikeDocumentDescriptor Doc(object? doc)
	{
		DocValue = doc;
		return Self;
	}

	public LikeDocumentDescriptor Fields(Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>ID of a document.</para>
	/// </summary>
	public LikeDocumentDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id? id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>Index of a document.</para>
	/// </summary>
	public LikeDocumentDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	public LikeDocumentDescriptor PerFieldAnalyzer(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, string>, FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, string>> selector)
	{
		PerFieldAnalyzerValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, string>());
		return Self;
	}

	public LikeDocumentDescriptor Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	public LikeDocumentDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	public LikeDocumentDescriptor VersionType(Elastic.Clients.Elasticsearch.Serverless.VersionType? versionType)
	{
		VersionTypeValue = versionType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DocValue is not null)
		{
			writer.WritePropertyName("doc");
			JsonSerializer.Serialize(writer, DocValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IdValue is not null)
		{
			writer.WritePropertyName("_id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (IndexValue is not null)
		{
			writer.WritePropertyName("_index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (PerFieldAnalyzerValue is not null)
		{
			writer.WritePropertyName("per_field_analyzer");
			JsonSerializer.Serialize(writer, PerFieldAnalyzerValue, options);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		if (VersionTypeValue is not null)
		{
			writer.WritePropertyName("version_type");
			JsonSerializer.Serialize(writer, VersionTypeValue, options);
		}

		writer.WriteEndObject();
	}
}