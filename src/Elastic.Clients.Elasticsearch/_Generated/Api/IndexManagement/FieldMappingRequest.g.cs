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
public sealed class FieldMappingRequestParameters : RequestParameters<FieldMappingRequestParameters>
{
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public IList<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IList<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
}

public sealed partial class FieldMappingRequest : PlainRequest<FieldMappingRequestParameters>
{
	public FieldMappingRequest(Elastic.Clients.Elasticsearch.Fields fields) : base(r => r.Required("fields", fields))
	{
	}

	public FieldMappingRequest(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Fields fields) : base(r => r.Optional("index", indices).Required("fields", fields))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGetFieldMapping;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public IList<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IList<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
}

public sealed partial class FieldMappingRequestDescriptor<TDocument> : RequestDescriptor<FieldMappingRequestDescriptor<TDocument>, FieldMappingRequestParameters>
{
	internal FieldMappingRequestDescriptor(Action<FieldMappingRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public FieldMappingRequestDescriptor(Elastic.Clients.Elasticsearch.Fields fields) : base(r => r.Required("fields", fields))
	{
	}

	public FieldMappingRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Fields fields) : base(r => r.Optional("index", indices).Required("fields", fields))
	{
	}

	internal FieldMappingRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGetFieldMapping;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	public FieldMappingRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public FieldMappingRequestDescriptor<TDocument> ExpandWildcards(IList<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public FieldMappingRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public FieldMappingRequestDescriptor<TDocument> IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public FieldMappingRequestDescriptor<TDocument> Local(bool? local = true) => Qs("local", local);
	public FieldMappingRequestDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields fields)
	{
		RouteValues.Required("fields", fields);
		return Self;
	}

	public FieldMappingRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class FieldMappingRequestDescriptor : RequestDescriptor<FieldMappingRequestDescriptor, FieldMappingRequestParameters>
{
	internal FieldMappingRequestDescriptor(Action<FieldMappingRequestDescriptor> configure) => configure.Invoke(this);
	public FieldMappingRequestDescriptor(Elastic.Clients.Elasticsearch.Fields fields) : base(r => r.Required("fields", fields))
	{
	}

	public FieldMappingRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Fields fields) : base(r => r.Optional("index", indices).Required("fields", fields))
	{
	}

	internal FieldMappingRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGetFieldMapping;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	public FieldMappingRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public FieldMappingRequestDescriptor ExpandWildcards(IList<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public FieldMappingRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public FieldMappingRequestDescriptor IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public FieldMappingRequestDescriptor Local(bool? local = true) => Qs("local", local);
	public FieldMappingRequestDescriptor Fields(Elastic.Clients.Elasticsearch.Fields fields)
	{
		RouteValues.Required("fields", fields);
		return Self;
	}

	public FieldMappingRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}