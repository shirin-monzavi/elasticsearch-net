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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed class PutPipelineRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Required version for optimistic concurrency control for pipeline updates</para>
	/// </summary>
	public long? IfVersion { get => Q<long?>("if_version"); set => Q("if_version", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Creates or updates an ingest pipeline.<br/>Changes made using this API take effect immediately.</para>
/// </summary>
public sealed partial class PutPipelineRequest : PlainRequest<PutPipelineRequestParameters>
{
	public PutPipelineRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestPutPipeline;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ingest.put_pipeline";

	/// <summary>
	/// <para>Required version for optimistic concurrency control for pipeline updates</para>
	/// </summary>
	[JsonIgnore]
	public long? IfVersion { get => Q<long?>("if_version"); set => Q("if_version", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Description of the ingest pipeline.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>Optional metadata about the ingest pipeline. May have any contents. This map is not automatically generated by Elasticsearch.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_meta")]
	public IDictionary<string, object>? Meta { get; set; }

	/// <summary>
	/// <para>Processors to run immediately after a processor failure. Each processor supports a processor-level `on_failure` value. If a processor without an `on_failure` value fails, Elasticsearch uses this pipeline-level parameter as a fallback. The processors in this parameter run sequentially in the order specified. Elasticsearch will not attempt to run the pipeline's remaining processors.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>Processors used to perform transformations on documents before indexing. Processors run sequentially in the order specified.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("processors")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? Processors { get; set; }

	/// <summary>
	/// <para>Version number used by external systems to track ingest pipelines. This parameter is intended for external systems only. Elasticsearch does not use or validate pipeline version numbers.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; set; }
}

/// <summary>
/// <para>Creates or updates an ingest pipeline.<br/>Changes made using this API take effect immediately.</para>
/// </summary>
public sealed partial class PutPipelineRequestDescriptor<TDocument> : RequestDescriptor<PutPipelineRequestDescriptor<TDocument>, PutPipelineRequestParameters>
{
	internal PutPipelineRequestDescriptor(Action<PutPipelineRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PutPipelineRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal PutPipelineRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestPutPipeline;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ingest.put_pipeline";

	public PutPipelineRequestDescriptor<TDocument> IfVersion(long? ifVersion) => Qs("if_version", ifVersion);
	public PutPipelineRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public PutPipelineRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public PutPipelineRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	private string? DescriptionValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? ProcessorsValue { get; set; }
	private ProcessorDescriptor<TDocument> ProcessorsDescriptor { get; set; }
	private Action<ProcessorDescriptor<TDocument>> ProcessorsDescriptorAction { get; set; }
	private Action<ProcessorDescriptor<TDocument>>[] ProcessorsDescriptorActions { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>Description of the ingest pipeline.</para>
	/// </summary>
	public PutPipelineRequestDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>Optional metadata about the ingest pipeline. May have any contents. This map is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PutPipelineRequestDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Processors to run immediately after a processor failure. Each processor supports a processor-level `on_failure` value. If a processor without an `on_failure` value fails, Elasticsearch uses this pipeline-level parameter as a fallback. The processors in this parameter run sequentially in the order specified. Elasticsearch will not attempt to run the pipeline's remaining processors.</para>
	/// </summary>
	public PutPipelineRequestDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public PutPipelineRequestDescriptor<TDocument> OnFailure(ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public PutPipelineRequestDescriptor<TDocument> OnFailure(Action<ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public PutPipelineRequestDescriptor<TDocument> OnFailure(params Action<ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Processors used to perform transformations on documents before indexing. Processors run sequentially in the order specified.</para>
	/// </summary>
	public PutPipelineRequestDescriptor<TDocument> Processors(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? processors)
	{
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsValue = processors;
		return Self;
	}

	public PutPipelineRequestDescriptor<TDocument> Processors(ProcessorDescriptor<TDocument> descriptor)
	{
		ProcessorsValue = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptor = descriptor;
		return Self;
	}

	public PutPipelineRequestDescriptor<TDocument> Processors(Action<ProcessorDescriptor<TDocument>> configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptorAction = configure;
		return Self;
	}

	public PutPipelineRequestDescriptor<TDocument> Processors(params Action<ProcessorDescriptor<TDocument>>[] configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Version number used by external systems to track ingest pipelines. This parameter is intended for external systems only. Elasticsearch does not use or validate pipeline version numbers.</para>
	/// </summary>
	public PutPipelineRequestDescriptor<TDocument> Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("_meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (ProcessorsDescriptor is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ProcessorsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorAction is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(ProcessorsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorActions is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			foreach (var action in ProcessorsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ProcessorsValue is not null)
		{
			writer.WritePropertyName("processors");
			JsonSerializer.Serialize(writer, ProcessorsValue, options);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Creates or updates an ingest pipeline.<br/>Changes made using this API take effect immediately.</para>
/// </summary>
public sealed partial class PutPipelineRequestDescriptor : RequestDescriptor<PutPipelineRequestDescriptor, PutPipelineRequestParameters>
{
	internal PutPipelineRequestDescriptor(Action<PutPipelineRequestDescriptor> configure) => configure.Invoke(this);

	public PutPipelineRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal PutPipelineRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestPutPipeline;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ingest.put_pipeline";

	public PutPipelineRequestDescriptor IfVersion(long? ifVersion) => Qs("if_version", ifVersion);
	public PutPipelineRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public PutPipelineRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public PutPipelineRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	private string? DescriptionValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? ProcessorsValue { get; set; }
	private ProcessorDescriptor ProcessorsDescriptor { get; set; }
	private Action<ProcessorDescriptor> ProcessorsDescriptorAction { get; set; }
	private Action<ProcessorDescriptor>[] ProcessorsDescriptorActions { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>Description of the ingest pipeline.</para>
	/// </summary>
	public PutPipelineRequestDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>Optional metadata about the ingest pipeline. May have any contents. This map is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PutPipelineRequestDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Processors to run immediately after a processor failure. Each processor supports a processor-level `on_failure` value. If a processor without an `on_failure` value fails, Elasticsearch uses this pipeline-level parameter as a fallback. The processors in this parameter run sequentially in the order specified. Elasticsearch will not attempt to run the pipeline's remaining processors.</para>
	/// </summary>
	public PutPipelineRequestDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public PutPipelineRequestDescriptor OnFailure(ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public PutPipelineRequestDescriptor OnFailure(Action<ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public PutPipelineRequestDescriptor OnFailure(params Action<ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Processors used to perform transformations on documents before indexing. Processors run sequentially in the order specified.</para>
	/// </summary>
	public PutPipelineRequestDescriptor Processors(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? processors)
	{
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsValue = processors;
		return Self;
	}

	public PutPipelineRequestDescriptor Processors(ProcessorDescriptor descriptor)
	{
		ProcessorsValue = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptor = descriptor;
		return Self;
	}

	public PutPipelineRequestDescriptor Processors(Action<ProcessorDescriptor> configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptorAction = configure;
		return Self;
	}

	public PutPipelineRequestDescriptor Processors(params Action<ProcessorDescriptor>[] configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Version number used by external systems to track ingest pipelines. This parameter is intended for external systems only. Elasticsearch does not use or validate pipeline version numbers.</para>
	/// </summary>
	public PutPipelineRequestDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("_meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (ProcessorsDescriptor is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ProcessorsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorAction is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor(ProcessorsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorActions is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			foreach (var action in ProcessorsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ProcessorsValue is not null)
		{
			writer.WritePropertyName("processors");
			JsonSerializer.Serialize(writer, ProcessorsValue, options);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}