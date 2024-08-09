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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class KnnRetriever
{
	/// <summary>
	/// <para>
	/// The name of the vector field to search against.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public string Field { get; set; }

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Filter { get; set; }

	/// <summary>
	/// <para>
	/// Number of nearest neighbors to return as top hits.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("k")]
	public int k { get; set; }

	/// <summary>
	/// <para>
	/// Number of nearest neighbor candidates to consider per shard.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("num_candidates")]
	public int NumCandidates { get; set; }

	/// <summary>
	/// <para>
	/// Query vector. Must have the same number of dimensions as the vector field you are searching against. You must provide a query_vector_builder or query_vector, but not both.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query_vector")]
	public ICollection<float>? QueryVector { get; set; }

	/// <summary>
	/// <para>
	/// Defines a model to build a query vector.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query_vector_builder")]
	public Elastic.Clients.Elasticsearch.QueryVectorBuilder? QueryVectorBuilder { get; set; }

	/// <summary>
	/// <para>
	/// The minimum similarity required for a document to be considered a match.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("similarity")]
	public float? Similarity { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Retriever(KnnRetriever knnRetriever) => Elastic.Clients.Elasticsearch.Retriever.Knn(knnRetriever);
}

public sealed partial class KnnRetrieverDescriptor<TDocument> : SerializableDescriptor<KnnRetrieverDescriptor<TDocument>>
{
	internal KnnRetrieverDescriptor(Action<KnnRetrieverDescriptor<TDocument>> configure) => configure.Invoke(this);

	public KnnRetrieverDescriptor() : base()
	{
	}

	private string FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }
	private int kValue { get; set; }
	private int NumCandidatesValue { get; set; }
	private ICollection<float>? QueryVectorValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilder? QueryVectorBuilderValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor QueryVectorBuilderDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> QueryVectorBuilderDescriptorAction { get; set; }
	private float? SimilarityValue { get; set; }

	/// <summary>
	/// <para>
	/// The name of the vector field to search against.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> Field(string field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public KnnRetrieverDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public KnnRetrieverDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public KnnRetrieverDescriptor<TDocument> Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of nearest neighbors to return as top hits.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> k(int k)
	{
		kValue = k;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of nearest neighbor candidates to consider per shard.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> NumCandidates(int numCandidates)
	{
		NumCandidatesValue = numCandidates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query vector. Must have the same number of dimensions as the vector field you are searching against. You must provide a query_vector_builder or query_vector, but not both.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> QueryVector(ICollection<float>? queryVector)
	{
		QueryVectorValue = queryVector;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines a model to build a query vector.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilder? queryVectorBuilder)
	{
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderValue = queryVectorBuilder;
		return Self;
	}

	public KnnRetrieverDescriptor<TDocument> QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor descriptor)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderDescriptor = descriptor;
		return Self;
	}

	public KnnRetrieverDescriptor<TDocument> QueryVectorBuilder(Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> configure)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum similarity required for a document to be considered a match.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> Similarity(float? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		writer.WriteStringValue(FieldValue);
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			if (FilterDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(action), options);
			}

			if (FilterDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(FilterValue, writer, options);
		}

		writer.WritePropertyName("k");
		writer.WriteNumberValue(kValue);
		writer.WritePropertyName("num_candidates");
		writer.WriteNumberValue(NumCandidatesValue);
		if (QueryVectorValue is not null)
		{
			writer.WritePropertyName("query_vector");
			JsonSerializer.Serialize(writer, QueryVectorValue, options);
		}

		if (QueryVectorBuilderDescriptor is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderDescriptor, options);
		}
		else if (QueryVectorBuilderDescriptorAction is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor(QueryVectorBuilderDescriptorAction), options);
		}
		else if (QueryVectorBuilderValue is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderValue, options);
		}

		if (SimilarityValue.HasValue)
		{
			writer.WritePropertyName("similarity");
			writer.WriteNumberValue(SimilarityValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class KnnRetrieverDescriptor : SerializableDescriptor<KnnRetrieverDescriptor>
{
	internal KnnRetrieverDescriptor(Action<KnnRetrieverDescriptor> configure) => configure.Invoke(this);

	public KnnRetrieverDescriptor() : base()
	{
	}

	private string FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] FilterDescriptorActions { get; set; }
	private int kValue { get; set; }
	private int NumCandidatesValue { get; set; }
	private ICollection<float>? QueryVectorValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilder? QueryVectorBuilderValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor QueryVectorBuilderDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> QueryVectorBuilderDescriptorAction { get; set; }
	private float? SimilarityValue { get; set; }

	/// <summary>
	/// <para>
	/// The name of the vector field to search against.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor Field(string field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public KnnRetrieverDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public KnnRetrieverDescriptor Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public KnnRetrieverDescriptor Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of nearest neighbors to return as top hits.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor k(int k)
	{
		kValue = k;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of nearest neighbor candidates to consider per shard.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor NumCandidates(int numCandidates)
	{
		NumCandidatesValue = numCandidates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query vector. Must have the same number of dimensions as the vector field you are searching against. You must provide a query_vector_builder or query_vector, but not both.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor QueryVector(ICollection<float>? queryVector)
	{
		QueryVectorValue = queryVector;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines a model to build a query vector.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilder? queryVectorBuilder)
	{
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderValue = queryVectorBuilder;
		return Self;
	}

	public KnnRetrieverDescriptor QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor descriptor)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderDescriptor = descriptor;
		return Self;
	}

	public KnnRetrieverDescriptor QueryVectorBuilder(Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> configure)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum similarity required for a document to be considered a match.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor Similarity(float? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		writer.WriteStringValue(FieldValue);
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			if (FilterDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(action), options);
			}

			if (FilterDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(FilterValue, writer, options);
		}

		writer.WritePropertyName("k");
		writer.WriteNumberValue(kValue);
		writer.WritePropertyName("num_candidates");
		writer.WriteNumberValue(NumCandidatesValue);
		if (QueryVectorValue is not null)
		{
			writer.WritePropertyName("query_vector");
			JsonSerializer.Serialize(writer, QueryVectorValue, options);
		}

		if (QueryVectorBuilderDescriptor is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderDescriptor, options);
		}
		else if (QueryVectorBuilderDescriptorAction is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor(QueryVectorBuilderDescriptorAction), options);
		}
		else if (QueryVectorBuilderValue is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderValue, options);
		}

		if (SimilarityValue.HasValue)
		{
			writer.WritePropertyName("similarity");
			writer.WriteNumberValue(SimilarityValue.Value);
		}

		writer.WriteEndObject();
	}
}