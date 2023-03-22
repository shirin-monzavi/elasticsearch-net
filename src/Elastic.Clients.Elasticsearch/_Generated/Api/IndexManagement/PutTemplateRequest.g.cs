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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed class PutTemplateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If true, this request cannot replace or update existing index templates.</para>
	/// </summary>
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node. If no response is<br/>received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Creates or updates an index template.</para>
/// </summary>
public sealed partial class PutTemplateRequest : PlainRequest<PutTemplateRequestParameters>
{
	public PutTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	/// <summary>
	/// <para>If true, this request cannot replace or update existing index templates.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }
	[JsonIgnore]
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node. If no response is<br/>received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Aliases for the index.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("aliases")]
	public IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? Aliases { get; set; }

	/// <summary>
	/// <para>Array of wildcard expressions used to match the names<br/>of indices during creation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_patterns"), SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? IndexPatterns { get; set; }

	/// <summary>
	/// <para>Mapping for fields in the index.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("mappings")]
	public Elastic.Clients.Elasticsearch.Mapping.TypeMapping? Mappings { get; set; }

	/// <summary>
	/// <para>Order in which Elasticsearch applies this template if index<br/>matches multiple templates.</para>
	/// <para>Templates with lower 'order' values are merged first. Templates with higher<br/>'order' values are merged later, overriding templates with lower values.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("order")]
	public int? Order { get; set; }

	/// <summary>
	/// <para>Configuration options for the index.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("settings")]
	public IDictionary<string, object>? Settings { get; set; }

	/// <summary>
	/// <para>Version number used to manage index templates externally. This number<br/>is not automatically generated by Elasticsearch.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; set; }
}

/// <summary>
/// <para>Creates or updates an index template.</para>
/// </summary>
public sealed partial class PutTemplateRequestDescriptor : RequestDescriptor<PutTemplateRequestDescriptor, PutTemplateRequestParameters>
{
	internal PutTemplateRequestDescriptor(Action<PutTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public PutTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal PutTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	public PutTemplateRequestDescriptor Create(bool? create = true) => Qs("create", create);
	public PutTemplateRequestDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
	public PutTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public PutTemplateRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public PutTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? AliasesValue { get; set; }
	private ICollection<string>? IndexPatternsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }
	private Mapping.TypeMappingDescriptor MappingsDescriptor { get; set; }
	private Action<Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; set; }
	private int? OrderValue { get; set; }
	private IDictionary<string, object>? SettingsValue { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>Aliases for the index.</para>
	/// </summary>
	public PutTemplateRequestDescriptor Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>());
		return Self;
	}

	/// <summary>
	/// <para>Array of wildcard expressions used to match the names<br/>of indices during creation.</para>
	/// </summary>
	public PutTemplateRequestDescriptor IndexPatterns(ICollection<string>? indexPatterns)
	{
		IndexPatternsValue = indexPatterns;
		return Self;
	}

	/// <summary>
	/// <para>Mapping for fields in the index.</para>
	/// </summary>
	public PutTemplateRequestDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public PutTemplateRequestDescriptor Mappings(Mapping.TypeMappingDescriptor descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public PutTemplateRequestDescriptor Mappings(Action<Mapping.TypeMappingDescriptor> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Order in which Elasticsearch applies this template if index<br/>matches multiple templates.</para>
	/// <para>Templates with lower 'order' values are merged first. Templates with higher<br/>'order' values are merged later, overriding templates with lower values.</para>
	/// </summary>
	public PutTemplateRequestDescriptor Order(int? order)
	{
		OrderValue = order;
		return Self;
	}

	/// <summary>
	/// <para>Configuration options for the index.</para>
	/// </summary>
	public PutTemplateRequestDescriptor Settings(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		SettingsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Version number used to manage index templates externally. This number<br/>is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PutTemplateRequestDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AliasesValue is not null)
		{
			writer.WritePropertyName("aliases");
			JsonSerializer.Serialize(writer, AliasesValue, options);
		}

		if (IndexPatternsValue is not null)
		{
			writer.WritePropertyName("index_patterns");
			SingleOrManySerializationHelper.Serialize<string>(IndexPatternsValue, writer, options);
		}

		if (MappingsDescriptor is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsDescriptor, options);
		}
		else if (MappingsDescriptorAction is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, new Mapping.TypeMappingDescriptor(MappingsDescriptorAction), options);
		}
		else if (MappingsValue is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsValue, options);
		}

		if (OrderValue.HasValue)
		{
			writer.WritePropertyName("order");
			writer.WriteNumberValue(OrderValue.Value);
		}

		if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}