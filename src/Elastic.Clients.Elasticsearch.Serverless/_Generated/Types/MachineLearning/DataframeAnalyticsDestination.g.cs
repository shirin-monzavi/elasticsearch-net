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

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class DataframeAnalyticsDestination
{
	/// <summary>
	/// <para>
	/// Defines the destination index to store the results of the data frame analytics job.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexName Index { get; set; }

	/// <summary>
	/// <para>
	/// Defines the name of the field in which to store the results of the analysis. Defaults to <c>ml</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("results_field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? ResultsField { get; set; }
}

public sealed partial class DataframeAnalyticsDestinationDescriptor<TDocument> : SerializableDescriptor<DataframeAnalyticsDestinationDescriptor<TDocument>>
{
	internal DataframeAnalyticsDestinationDescriptor(Action<DataframeAnalyticsDestinationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DataframeAnalyticsDestinationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.IndexName IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? ResultsFieldValue { get; set; }

	/// <summary>
	/// <para>
	/// Defines the destination index to store the results of the data frame analytics job.
	/// </para>
	/// </summary>
	public DataframeAnalyticsDestinationDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.Serverless.IndexName index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines the name of the field in which to store the results of the analysis. Defaults to <c>ml</c>.
	/// </para>
	/// </summary>
	public DataframeAnalyticsDestinationDescriptor<TDocument> ResultsField(Elastic.Clients.Elasticsearch.Serverless.Field? resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines the name of the field in which to store the results of the analysis. Defaults to <c>ml</c>.
	/// </para>
	/// </summary>
	public DataframeAnalyticsDestinationDescriptor<TDocument> ResultsField<TValue>(Expression<Func<TDocument, TValue>> resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines the name of the field in which to store the results of the analysis. Defaults to <c>ml</c>.
	/// </para>
	/// </summary>
	public DataframeAnalyticsDestinationDescriptor<TDocument> ResultsField(Expression<Func<TDocument, object>> resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("index");
		JsonSerializer.Serialize(writer, IndexValue, options);
		if (ResultsFieldValue is not null)
		{
			writer.WritePropertyName("results_field");
			JsonSerializer.Serialize(writer, ResultsFieldValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DataframeAnalyticsDestinationDescriptor : SerializableDescriptor<DataframeAnalyticsDestinationDescriptor>
{
	internal DataframeAnalyticsDestinationDescriptor(Action<DataframeAnalyticsDestinationDescriptor> configure) => configure.Invoke(this);

	public DataframeAnalyticsDestinationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.IndexName IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? ResultsFieldValue { get; set; }

	/// <summary>
	/// <para>
	/// Defines the destination index to store the results of the data frame analytics job.
	/// </para>
	/// </summary>
	public DataframeAnalyticsDestinationDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.IndexName index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines the name of the field in which to store the results of the analysis. Defaults to <c>ml</c>.
	/// </para>
	/// </summary>
	public DataframeAnalyticsDestinationDescriptor ResultsField(Elastic.Clients.Elasticsearch.Serverless.Field? resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines the name of the field in which to store the results of the analysis. Defaults to <c>ml</c>.
	/// </para>
	/// </summary>
	public DataframeAnalyticsDestinationDescriptor ResultsField<TDocument, TValue>(Expression<Func<TDocument, TValue>> resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines the name of the field in which to store the results of the analysis. Defaults to <c>ml</c>.
	/// </para>
	/// </summary>
	public DataframeAnalyticsDestinationDescriptor ResultsField<TDocument>(Expression<Func<TDocument, object>> resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("index");
		JsonSerializer.Serialize(writer, IndexValue, options);
		if (ResultsFieldValue is not null)
		{
			writer.WritePropertyName("results_field");
			JsonSerializer.Serialize(writer, ResultsFieldValue, options);
		}

		writer.WriteEndObject();
	}
}