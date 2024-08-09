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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class IndexingSlowlogTresholds
{
	/// <summary>
	/// <para>
	/// The indexing slow log, similar in functionality to the search slow log. The log file name ends with <c>_index_indexing_slowlog.json</c>.
	/// Log and the thresholds are configured in the same way as the search slowlog.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogTresholdLevels? Index { get; set; }
}

public sealed partial class IndexingSlowlogTresholdsDescriptor : SerializableDescriptor<IndexingSlowlogTresholdsDescriptor>
{
	internal IndexingSlowlogTresholdsDescriptor(Action<IndexingSlowlogTresholdsDescriptor> configure) => configure.Invoke(this);

	public IndexingSlowlogTresholdsDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogTresholdLevels? IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogTresholdLevelsDescriptor IndexDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogTresholdLevelsDescriptor> IndexDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// The indexing slow log, similar in functionality to the search slow log. The log file name ends with <c>_index_indexing_slowlog.json</c>.
	/// Log and the thresholds are configured in the same way as the search slowlog.
	/// </para>
	/// </summary>
	public IndexingSlowlogTresholdsDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogTresholdLevels? index)
	{
		IndexDescriptor = null;
		IndexDescriptorAction = null;
		IndexValue = index;
		return Self;
	}

	public IndexingSlowlogTresholdsDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogTresholdLevelsDescriptor descriptor)
	{
		IndexValue = null;
		IndexDescriptorAction = null;
		IndexDescriptor = descriptor;
		return Self;
	}

	public IndexingSlowlogTresholdsDescriptor Index(Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogTresholdLevelsDescriptor> configure)
	{
		IndexValue = null;
		IndexDescriptor = null;
		IndexDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IndexDescriptor is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexDescriptor, options);
		}
		else if (IndexDescriptorAction is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogTresholdLevelsDescriptor(IndexDescriptorAction), options);
		}
		else if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		writer.WriteEndObject();
	}
}