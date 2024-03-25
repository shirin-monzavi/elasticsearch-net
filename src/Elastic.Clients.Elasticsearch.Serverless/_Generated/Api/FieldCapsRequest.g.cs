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

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class FieldCapsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If false, the request returns an error if any wildcard expression, index alias,<br/>or `_all` value targets only missing or closed indices. This behavior applies even if the request targets other open indices. For example, a request<br/>targeting `foo*,bar*` returns an error if an index starts with foo but no index starts with bar.</para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match. If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams. Supports comma-separated values, such as `open,hidden`.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>An optional set of filters: can include +metadata,-metadata,-nested,-multifield,-parent</para>
	/// </summary>
	public string? Filters { get => Q<string?>("filters"); set => Q("filters", value); }

	/// <summary>
	/// <para>If `true`, missing or closed indices are not included in the response.</para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>If true, unmapped fields are included in the response.</para>
	/// </summary>
	public bool? IncludeUnmapped { get => Q<bool?>("include_unmapped"); set => Q("include_unmapped", value); }

	/// <summary>
	/// <para>Only return results for fields that have one of the types in the list</para>
	/// </summary>
	public ICollection<string>? Types { get => Q<ICollection<string>?>("types"); set => Q("types", value); }
}

/// <summary>
/// <para>The field capabilities API returns the information about the capabilities of fields among multiple indices.<br/>The field capabilities API returns runtime fields like any other field. For example, a runtime field with a type<br/>of keyword is returned as any other field that belongs to the `keyword` family.</para>
/// </summary>
public sealed partial class FieldCapsRequest : PlainRequest<FieldCapsRequestParameters>
{
	public FieldCapsRequest()
	{
	}

	public FieldCapsRequest(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceFieldCaps;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "field_caps";

	/// <summary>
	/// <para>If false, the request returns an error if any wildcard expression, index alias,<br/>or `_all` value targets only missing or closed indices. This behavior applies even if the request targets other open indices. For example, a request<br/>targeting `foo*,bar*` returns an error if an index starts with foo but no index starts with bar.</para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match. If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams. Supports comma-separated values, such as `open,hidden`.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>An optional set of filters: can include +metadata,-metadata,-nested,-multifield,-parent</para>
	/// </summary>
	[JsonIgnore]
	public string? Filters { get => Q<string?>("filters"); set => Q("filters", value); }

	/// <summary>
	/// <para>If `true`, missing or closed indices are not included in the response.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>If true, unmapped fields are included in the response.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeUnmapped { get => Q<bool?>("include_unmapped"); set => Q("include_unmapped", value); }

	/// <summary>
	/// <para>Only return results for fields that have one of the types in the list</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<string>? Types { get => Q<ICollection<string>?>("types"); set => Q("types", value); }

	/// <summary>
	/// <para>List of fields to retrieve capabilities for. Wildcard (`*`) expressions are supported.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? Fields { get; set; }

	/// <summary>
	/// <para>Allows to filter indices if the provided query rewrites to match_none on every shard.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_filter")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? IndexFilter { get; set; }

	/// <summary>
	/// <para>Defines ad-hoc runtime fields in the request similar to the way it is done in search requests.<br/>These fields exist only as part of the query and take precedence over fields defined with the same name in the index mappings.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("runtime_mappings")]
	public IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeField>? RuntimeMappings { get; set; }
}

/// <summary>
/// <para>The field capabilities API returns the information about the capabilities of fields among multiple indices.<br/>The field capabilities API returns runtime fields like any other field. For example, a runtime field with a type<br/>of keyword is returned as any other field that belongs to the `keyword` family.</para>
/// </summary>
public sealed partial class FieldCapsRequestDescriptor<TDocument> : RequestDescriptor<FieldCapsRequestDescriptor<TDocument>, FieldCapsRequestParameters>
{
	internal FieldCapsRequestDescriptor(Action<FieldCapsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public FieldCapsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceFieldCaps;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "field_caps";

	public FieldCapsRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public FieldCapsRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public FieldCapsRequestDescriptor<TDocument> Filters(string? filters) => Qs("filters", filters);
	public FieldCapsRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public FieldCapsRequestDescriptor<TDocument> IncludeUnmapped(bool? includeUnmapped = true) => Qs("include_unmapped", includeUnmapped);
	public FieldCapsRequestDescriptor<TDocument> Types(ICollection<string>? types) => Qs("types", types);

	public FieldCapsRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? IndexFilterValue { get; set; }
	private QueryDsl.QueryDescriptor<TDocument> IndexFilterDescriptor { get; set; }
	private Action<QueryDsl.QueryDescriptor<TDocument>> IndexFilterDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeField>? RuntimeMappingsValue { get; set; }

	/// <summary>
	/// <para>List of fields to retrieve capabilities for. Wildcard (`*`) expressions are supported.</para>
	/// </summary>
	public FieldCapsRequestDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Serverless.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Allows to filter indices if the provided query rewrites to match_none on every shard.</para>
	/// </summary>
	public FieldCapsRequestDescriptor<TDocument> IndexFilter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? indexFilter)
	{
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = null;
		IndexFilterValue = indexFilter;
		return Self;
	}

	public FieldCapsRequestDescriptor<TDocument> IndexFilter(QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		IndexFilterValue = null;
		IndexFilterDescriptorAction = null;
		IndexFilterDescriptor = descriptor;
		return Self;
	}

	public FieldCapsRequestDescriptor<TDocument> IndexFilter(Action<QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		IndexFilterValue = null;
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Defines ad-hoc runtime fields in the request similar to the way it is done in search requests.<br/>These fields exist only as part of the query and take precedence over fields defined with the same name in the index mappings.</para>
	/// </summary>
	public FieldCapsRequestDescriptor<TDocument> RuntimeMappings(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeField>, FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeField>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeField>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IndexFilterDescriptor is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterDescriptor, options);
		}
		else if (IndexFilterDescriptorAction is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor<TDocument>(IndexFilterDescriptorAction), options);
		}
		else if (IndexFilterValue is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>The field capabilities API returns the information about the capabilities of fields among multiple indices.<br/>The field capabilities API returns runtime fields like any other field. For example, a runtime field with a type<br/>of keyword is returned as any other field that belongs to the `keyword` family.</para>
/// </summary>
public sealed partial class FieldCapsRequestDescriptor : RequestDescriptor<FieldCapsRequestDescriptor, FieldCapsRequestParameters>
{
	internal FieldCapsRequestDescriptor(Action<FieldCapsRequestDescriptor> configure) => configure.Invoke(this);

	public FieldCapsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceFieldCaps;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "field_caps";

	public FieldCapsRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public FieldCapsRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public FieldCapsRequestDescriptor Filters(string? filters) => Qs("filters", filters);
	public FieldCapsRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public FieldCapsRequestDescriptor IncludeUnmapped(bool? includeUnmapped = true) => Qs("include_unmapped", includeUnmapped);
	public FieldCapsRequestDescriptor Types(ICollection<string>? types) => Qs("types", types);

	public FieldCapsRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? IndexFilterValue { get; set; }
	private QueryDsl.QueryDescriptor IndexFilterDescriptor { get; set; }
	private Action<QueryDsl.QueryDescriptor> IndexFilterDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeField>? RuntimeMappingsValue { get; set; }

	/// <summary>
	/// <para>List of fields to retrieve capabilities for. Wildcard (`*`) expressions are supported.</para>
	/// </summary>
	public FieldCapsRequestDescriptor Fields(Elastic.Clients.Elasticsearch.Serverless.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Allows to filter indices if the provided query rewrites to match_none on every shard.</para>
	/// </summary>
	public FieldCapsRequestDescriptor IndexFilter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? indexFilter)
	{
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = null;
		IndexFilterValue = indexFilter;
		return Self;
	}

	public FieldCapsRequestDescriptor IndexFilter(QueryDsl.QueryDescriptor descriptor)
	{
		IndexFilterValue = null;
		IndexFilterDescriptorAction = null;
		IndexFilterDescriptor = descriptor;
		return Self;
	}

	public FieldCapsRequestDescriptor IndexFilter(Action<QueryDsl.QueryDescriptor> configure)
	{
		IndexFilterValue = null;
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Defines ad-hoc runtime fields in the request similar to the way it is done in search requests.<br/>These fields exist only as part of the query and take precedence over fields defined with the same name in the index mappings.</para>
	/// </summary>
	public FieldCapsRequestDescriptor RuntimeMappings(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeField>, FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeField>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeField>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IndexFilterDescriptor is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterDescriptor, options);
		}
		else if (IndexFilterDescriptorAction is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor(IndexFilterDescriptorAction), options);
		}
		else if (IndexFilterValue is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
		}

		writer.WriteEndObject();
	}
}