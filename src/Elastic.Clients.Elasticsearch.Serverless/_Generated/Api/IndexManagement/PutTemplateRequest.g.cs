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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class PutTemplateRequestParameters : RequestParameters
{
	public string? Cause { get => Q<string?>("cause"); set => Q("cause", value); }

	/// <summary>
	/// <para>
	/// If true, this request cannot replace or update existing index templates.
	/// </para>
	/// </summary>
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is
	/// received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>
/// Create or update an index template.
/// Index templates define settings, mappings, and aliases that can be applied automatically to new indices.
/// </para>
/// </summary>
public sealed partial class PutTemplateRequest : PlainRequest<PutTemplateRequestParameters>
{
	public PutTemplateRequest(Elastic.Clients.Elasticsearch.Serverless.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.put_template";

	[JsonIgnore]
	public string? Cause { get => Q<string?>("cause"); set => Q("cause", value); }

	/// <summary>
	/// <para>
	/// If true, this request cannot replace or update existing index templates.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is
	/// received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Aliases for the index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("aliases")]
	public IDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.Alias>? Aliases { get; set; }

	/// <summary>
	/// <para>
	/// Array of wildcard expressions used to match the names
	/// of indices during creation.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_patterns")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? IndexPatterns { get; set; }

	/// <summary>
	/// <para>
	/// Mapping for fields in the index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("mappings")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? Mappings { get; set; }

	/// <summary>
	/// <para>
	/// Order in which Elasticsearch applies this template if index
	/// matches multiple templates.
	/// </para>
	/// <para>
	/// Templates with lower 'order' values are merged first. Templates with higher
	/// 'order' values are merged later, overriding templates with lower values.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("order")]
	public int? Order { get; set; }

	/// <summary>
	/// <para>
	/// Configuration options for the index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("settings")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? Settings { get; set; }

	/// <summary>
	/// <para>
	/// Version number used to manage index templates externally. This number
	/// is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; set; }
}

/// <summary>
/// <para>
/// Create or update an index template.
/// Index templates define settings, mappings, and aliases that can be applied automatically to new indices.
/// </para>
/// </summary>
public sealed partial class PutTemplateRequestDescriptor<TDocument> : RequestDescriptor<PutTemplateRequestDescriptor<TDocument>, PutTemplateRequestParameters>
{
	internal PutTemplateRequestDescriptor(Action<PutTemplateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PutTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.put_template";

	public PutTemplateRequestDescriptor<TDocument> Cause(string? cause) => Qs("cause", cause);
	public PutTemplateRequestDescriptor<TDocument> Create(bool? create = true) => Qs("create", create);
	public PutTemplateRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public PutTemplateRequestDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Serverless.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.AliasDescriptor<TDocument>> AliasesValue { get; set; }
	private ICollection<string>? IndexPatternsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? MappingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMappingDescriptor<TDocument> MappingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMappingDescriptor<TDocument>> MappingsDescriptorAction { get; set; }
	private int? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? SettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsDescriptor<TDocument> SettingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsDescriptor<TDocument>> SettingsDescriptorAction { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>
	/// Aliases for the index.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor<TDocument> Aliases(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.AliasDescriptor<TDocument>>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.AliasDescriptor<TDocument>>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.AliasDescriptor<TDocument>>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of wildcard expressions used to match the names
	/// of indices during creation.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor<TDocument> IndexPatterns(ICollection<string>? indexPatterns)
	{
		IndexPatternsValue = indexPatterns;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Mapping for fields in the index.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor<TDocument> Mappings(Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public PutTemplateRequestDescriptor<TDocument> Mappings(Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMappingDescriptor<TDocument> descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public PutTemplateRequestDescriptor<TDocument> Mappings(Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMappingDescriptor<TDocument>> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Order in which Elasticsearch applies this template if index
	/// matches multiple templates.
	/// </para>
	/// <para>
	/// Templates with lower 'order' values are merged first. Templates with higher
	/// 'order' values are merged later, overriding templates with lower values.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor<TDocument> Order(int? order)
	{
		OrderValue = order;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Configuration options for the index.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor<TDocument> Settings(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public PutTemplateRequestDescriptor<TDocument> Settings(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsDescriptor<TDocument> descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public PutTemplateRequestDescriptor<TDocument> Settings(Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsDescriptor<TDocument>> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Version number used to manage index templates externally. This number
	/// is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor<TDocument> Version(long? version)
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMappingDescriptor<TDocument>(MappingsDescriptorAction), options);
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

		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsDescriptor<TDocument>(SettingsDescriptorAction), options);
		}
		else if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		if (VersionValue.HasValue)
		{
			writer.WritePropertyName("version");
			writer.WriteNumberValue(VersionValue.Value);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Create or update an index template.
/// Index templates define settings, mappings, and aliases that can be applied automatically to new indices.
/// </para>
/// </summary>
public sealed partial class PutTemplateRequestDescriptor : RequestDescriptor<PutTemplateRequestDescriptor, PutTemplateRequestParameters>
{
	internal PutTemplateRequestDescriptor(Action<PutTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public PutTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.put_template";

	public PutTemplateRequestDescriptor Cause(string? cause) => Qs("cause", cause);
	public PutTemplateRequestDescriptor Create(bool? create = true) => Qs("create", create);
	public PutTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public PutTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.AliasDescriptor> AliasesValue { get; set; }
	private ICollection<string>? IndexPatternsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? MappingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMappingDescriptor MappingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; set; }
	private int? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? SettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsDescriptor SettingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsDescriptor> SettingsDescriptorAction { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>
	/// Aliases for the index.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor Aliases(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.AliasDescriptor>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.AliasDescriptor>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.AliasDescriptor>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of wildcard expressions used to match the names
	/// of indices during creation.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor IndexPatterns(ICollection<string>? indexPatterns)
	{
		IndexPatternsValue = indexPatterns;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Mapping for fields in the index.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor Mappings(Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public PutTemplateRequestDescriptor Mappings(Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMappingDescriptor descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public PutTemplateRequestDescriptor Mappings(Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMappingDescriptor> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Order in which Elasticsearch applies this template if index
	/// matches multiple templates.
	/// </para>
	/// <para>
	/// Templates with lower 'order' values are merged first. Templates with higher
	/// 'order' values are merged later, overriding templates with lower values.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor Order(int? order)
	{
		OrderValue = order;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Configuration options for the index.
	/// </para>
	/// </summary>
	public PutTemplateRequestDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public PutTemplateRequestDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsDescriptor descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public PutTemplateRequestDescriptor Settings(Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsDescriptor> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Version number used to manage index templates externally. This number
	/// is not automatically generated by Elasticsearch.
	/// </para>
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMappingDescriptor(MappingsDescriptorAction), options);
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

		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsDescriptor(SettingsDescriptorAction), options);
		}
		else if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		if (VersionValue.HasValue)
		{
			writer.WritePropertyName("version");
			writer.WriteNumberValue(VersionValue.Value);
		}

		writer.WriteEndObject();
	}
}