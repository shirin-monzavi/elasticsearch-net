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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed class SimulateIndexTemplateRequestParameters : RequestParameters
{
	[JsonIgnore]
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

public sealed partial class SimulateIndexTemplateRequest : PlainRequest<SimulateIndexTemplateRequestParameters>
{
	public SimulateIndexTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSimulateIndexTemplate;
	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	[JsonIgnore]
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	[JsonInclude]
	[JsonPropertyName("allow_auto_create")]
	public bool? AllowAutoCreate { get; set; }

	[JsonInclude]
	[JsonPropertyName("index_patterns")]
	public Elastic.Clients.Elasticsearch.Indices? IndexPatterns { get; set; }

	[JsonInclude]
	[JsonPropertyName("composed_of")]
	public ICollection<string>? ComposedOf { get; set; }

	[JsonInclude]
	[JsonPropertyName("template")]
	public Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? Template { get; set; }

	[JsonInclude]
	[JsonPropertyName("data_stream")]
	public Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? DataStream { get; set; }

	[JsonInclude]
	[JsonPropertyName("priority")]
	public int? Priority { get; set; }

	[JsonInclude]
	[JsonPropertyName("version")]
	public long? Version { get; set; }

	[JsonInclude]
	[JsonPropertyName("_meta")]
	public IDictionary<string, object>? Meta { get; set; }
}

public sealed partial class SimulateIndexTemplateRequestDescriptor<TDocument> : RequestDescriptor<SimulateIndexTemplateRequestDescriptor<TDocument>, SimulateIndexTemplateRequestParameters>
{
	internal SimulateIndexTemplateRequestDescriptor(Action<SimulateIndexTemplateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public SimulateIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal SimulateIndexTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSimulateIndexTemplate;
	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	public SimulateIndexTemplateRequestDescriptor<TDocument> Create(bool? create = true) => Qs("create", create);
	public SimulateIndexTemplateRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public SimulateIndexTemplateRequestDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? TemplateValue { get; set; }

	private IndexTemplateMappingDescriptor<TDocument> TemplateDescriptor { get; set; }

	private Action<IndexTemplateMappingDescriptor<TDocument>> TemplateDescriptorAction { get; set; }

	private IDictionary<string, object>? MetaValue { get; set; }

	private bool? AllowAutoCreateValue { get; set; }

	private ICollection<string>? ComposedOfValue { get; set; }

	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? DataStreamValue { get; set; }

	private DataStreamVisibilityDescriptor DataStreamDescriptor { get; set; }

	private Action<DataStreamVisibilityDescriptor> DataStreamDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.Indices? IndexPatternsValue { get; set; }

	private int? PriorityValue { get; set; }

	private long? VersionValue { get; set; }

	public SimulateIndexTemplateRequestDescriptor<TDocument> Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? template)
	{
		TemplateDescriptor = null;
		TemplateDescriptorAction = null;
		TemplateValue = template;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> Template(IndexTemplateMappingDescriptor<TDocument> descriptor)
	{
		TemplateValue = null;
		TemplateDescriptorAction = null;
		TemplateDescriptor = descriptor;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> Template(Action<IndexTemplateMappingDescriptor<TDocument>> configure)
	{
		TemplateValue = null;
		TemplateDescriptor = null;
		TemplateDescriptorAction = configure;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> AllowAutoCreate(bool? allowAutoCreate = true)
	{
		AllowAutoCreateValue = allowAutoCreate;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> ComposedOf(ICollection<string>? composedOf)
	{
		ComposedOfValue = composedOf;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? dataStream)
	{
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = null;
		DataStreamValue = dataStream;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> DataStream(DataStreamVisibilityDescriptor descriptor)
	{
		DataStreamValue = null;
		DataStreamDescriptorAction = null;
		DataStreamDescriptor = descriptor;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> DataStream(Action<DataStreamVisibilityDescriptor> configure)
	{
		DataStreamValue = null;
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = configure;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> IndexPatterns(Elastic.Clients.Elasticsearch.Indices? indexPatterns)
	{
		IndexPatternsValue = indexPatterns;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> Priority(int? priority)
	{
		PriorityValue = priority;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor<TDocument> Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (TemplateDescriptor is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateDescriptor, options);
		}
		else if (TemplateDescriptorAction is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, new IndexTemplateMappingDescriptor<TDocument>(TemplateDescriptorAction), options);
		}
		else if (TemplateValue is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("_meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (AllowAutoCreateValue.HasValue)
		{
			writer.WritePropertyName("allow_auto_create");
			writer.WriteBooleanValue(AllowAutoCreateValue.Value);
		}

		if (ComposedOfValue is not null)
		{
			writer.WritePropertyName("composed_of");
			JsonSerializer.Serialize(writer, ComposedOfValue, options);
		}

		if (DataStreamDescriptor is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamDescriptor, options);
		}
		else if (DataStreamDescriptorAction is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, new DataStreamVisibilityDescriptor(DataStreamDescriptorAction), options);
		}
		else if (DataStreamValue is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamValue, options);
		}

		if (IndexPatternsValue is not null)
		{
			writer.WritePropertyName("index_patterns");
			JsonSerializer.Serialize(writer, IndexPatternsValue, options);
		}

		if (PriorityValue.HasValue)
		{
			writer.WritePropertyName("priority");
			writer.WriteNumberValue(PriorityValue.Value);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class SimulateIndexTemplateRequestDescriptor : RequestDescriptor<SimulateIndexTemplateRequestDescriptor, SimulateIndexTemplateRequestParameters>
{
	internal SimulateIndexTemplateRequestDescriptor(Action<SimulateIndexTemplateRequestDescriptor> configure) => configure.Invoke(this);
	public SimulateIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal SimulateIndexTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSimulateIndexTemplate;
	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	public SimulateIndexTemplateRequestDescriptor Create(bool? create = true) => Qs("create", create);
	public SimulateIndexTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public SimulateIndexTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? TemplateValue { get; set; }

	private IndexTemplateMappingDescriptor TemplateDescriptor { get; set; }

	private Action<IndexTemplateMappingDescriptor> TemplateDescriptorAction { get; set; }

	private IDictionary<string, object>? MetaValue { get; set; }

	private bool? AllowAutoCreateValue { get; set; }

	private ICollection<string>? ComposedOfValue { get; set; }

	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? DataStreamValue { get; set; }

	private DataStreamVisibilityDescriptor DataStreamDescriptor { get; set; }

	private Action<DataStreamVisibilityDescriptor> DataStreamDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.Indices? IndexPatternsValue { get; set; }

	private int? PriorityValue { get; set; }

	private long? VersionValue { get; set; }

	public SimulateIndexTemplateRequestDescriptor Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? template)
	{
		TemplateDescriptor = null;
		TemplateDescriptorAction = null;
		TemplateValue = template;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor Template(IndexTemplateMappingDescriptor descriptor)
	{
		TemplateValue = null;
		TemplateDescriptorAction = null;
		TemplateDescriptor = descriptor;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor Template(Action<IndexTemplateMappingDescriptor> configure)
	{
		TemplateValue = null;
		TemplateDescriptor = null;
		TemplateDescriptorAction = configure;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor AllowAutoCreate(bool? allowAutoCreate = true)
	{
		AllowAutoCreateValue = allowAutoCreate;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor ComposedOf(ICollection<string>? composedOf)
	{
		ComposedOfValue = composedOf;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? dataStream)
	{
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = null;
		DataStreamValue = dataStream;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor DataStream(DataStreamVisibilityDescriptor descriptor)
	{
		DataStreamValue = null;
		DataStreamDescriptorAction = null;
		DataStreamDescriptor = descriptor;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor DataStream(Action<DataStreamVisibilityDescriptor> configure)
	{
		DataStreamValue = null;
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = configure;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor IndexPatterns(Elastic.Clients.Elasticsearch.Indices? indexPatterns)
	{
		IndexPatternsValue = indexPatterns;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor Priority(int? priority)
	{
		PriorityValue = priority;
		return Self;
	}

	public SimulateIndexTemplateRequestDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (TemplateDescriptor is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateDescriptor, options);
		}
		else if (TemplateDescriptorAction is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, new IndexTemplateMappingDescriptor(TemplateDescriptorAction), options);
		}
		else if (TemplateValue is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("_meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (AllowAutoCreateValue.HasValue)
		{
			writer.WritePropertyName("allow_auto_create");
			writer.WriteBooleanValue(AllowAutoCreateValue.Value);
		}

		if (ComposedOfValue is not null)
		{
			writer.WritePropertyName("composed_of");
			JsonSerializer.Serialize(writer, ComposedOfValue, options);
		}

		if (DataStreamDescriptor is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamDescriptor, options);
		}
		else if (DataStreamDescriptorAction is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, new DataStreamVisibilityDescriptor(DataStreamDescriptorAction), options);
		}
		else if (DataStreamValue is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamValue, options);
		}

		if (IndexPatternsValue is not null)
		{
			writer.WritePropertyName("index_patterns");
			JsonSerializer.Serialize(writer, IndexPatternsValue, options);
		}

		if (PriorityValue.HasValue)
		{
			writer.WritePropertyName("priority");
			writer.WriteNumberValue(PriorityValue.Value);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}