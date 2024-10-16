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
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class MultiSearchTemplateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If <c>true</c>, network round-trips are minimized for cross-cluster search requests.
	/// </para>
	/// </summary>
	public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

	/// <summary>
	/// <para>
	/// Maximum number of concurrent searches the API can run.
	/// </para>
	/// </summary>
	public long? MaxConcurrentSearches { get => Q<long?>("max_concurrent_searches"); set => Q("max_concurrent_searches", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response returns <c>hits.total</c> as an integer.
	/// If <c>false</c>, it returns <c>hits.total</c> as an object.
	/// </para>
	/// </summary>
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	/// <summary>
	/// <para>
	/// The type of the search operation.
	/// Available options: <c>query_then_fetch</c>, <c>dfs_query_then_fetch</c>.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.Serverless.SearchType?>("search_type"); set => Q("search_type", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response prefixes aggregation and suggester names with their respective types.
	/// </para>
	/// </summary>
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }
}

/// <summary>
/// <para>
/// Runs multiple templated searches with a single request.
/// </para>
/// </summary>
public sealed partial class MultiSearchTemplateRequest : PlainRequest<MultiSearchTemplateRequestParameters>, IStreamSerializable
{
	public MultiSearchTemplateRequest()
	{
	}

	public MultiSearchTemplateRequest(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMultiSearchTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "msearch_template";

	/// <summary>
	/// <para>
	/// If <c>true</c>, network round-trips are minimized for cross-cluster search requests.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

	/// <summary>
	/// <para>
	/// Maximum number of concurrent searches the API can run.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public long? MaxConcurrentSearches { get => Q<long?>("max_concurrent_searches"); set => Q("max_concurrent_searches", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response returns <c>hits.total</c> as an integer.
	/// If <c>false</c>, it returns <c>hits.total</c> as an object.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	/// <summary>
	/// <para>
	/// The type of the search operation.
	/// Available options: <c>query_then_fetch</c>, <c>dfs_query_then_fetch</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.Serverless.SearchType?>("search_type"); set => Q("search_type", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response prefixes aggregation and suggester names with their respective types.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }
	public List<Elastic.Clients.Elasticsearch.Serverless.Core.MSearchTemplate.SearchTemplateRequestItem> SearchTemplates { get; set; }

	void IStreamSerializable.Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (SearchTemplates is null)
			return;
		foreach (var item in SearchTemplates)
		{
			if (item is IStreamSerializable serializable)
				serializable.Serialize(stream, settings, formatting);
		}
	}

	async Task IStreamSerializable.SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (SearchTemplates is null)
			return;
		foreach (var item in SearchTemplates)
		{
			if (item is IStreamSerializable serializable)
				await serializable.SerializeAsync(stream, settings, formatting).ConfigureAwait(false);
		}
	}
}

/// <summary>
/// <para>
/// Runs multiple templated searches with a single request.
/// </para>
/// </summary>
public sealed partial class MultiSearchTemplateRequestDescriptor<TDocument> : RequestDescriptor<MultiSearchTemplateRequestDescriptor<TDocument>, MultiSearchTemplateRequestParameters>, IStreamSerializable
{
	internal MultiSearchTemplateRequestDescriptor(Action<MultiSearchTemplateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MultiSearchTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public MultiSearchTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMultiSearchTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "msearch_template";

	public MultiSearchTemplateRequestDescriptor<TDocument> CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips = true) => Qs("ccs_minimize_roundtrips", ccsMinimizeRoundtrips);
	public MultiSearchTemplateRequestDescriptor<TDocument> MaxConcurrentSearches(long? maxConcurrentSearches) => Qs("max_concurrent_searches", maxConcurrentSearches);
	public MultiSearchTemplateRequestDescriptor<TDocument> RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	public MultiSearchTemplateRequestDescriptor<TDocument> SearchType(Elastic.Clients.Elasticsearch.Serverless.SearchType? searchType) => Qs("search_type", searchType);
	public MultiSearchTemplateRequestDescriptor<TDocument> TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);

	public MultiSearchTemplateRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}

	List<Elastic.Clients.Elasticsearch.Serverless.Core.MSearchTemplate.SearchTemplateRequestItem> _items = new();

	void IStreamSerializable.Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				serializable.Serialize(stream, settings, formatting);
		}
	}

	async Task IStreamSerializable.SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				await serializable.SerializeAsync(stream, settings, formatting).ConfigureAwait(false);
		}
	}

	public MultiSearchTemplateRequestDescriptor<TDocument> AddSearchTemplates(Elastic.Clients.Elasticsearch.Serverless.Core.MSearchTemplate.SearchTemplateRequestItem searchTemplates)
	{
		_items.Add(searchTemplates);
		return this;
	}
}

/// <summary>
/// <para>
/// Runs multiple templated searches with a single request.
/// </para>
/// </summary>
public sealed partial class MultiSearchTemplateRequestDescriptor : RequestDescriptor<MultiSearchTemplateRequestDescriptor, MultiSearchTemplateRequestParameters>, IStreamSerializable
{
	internal MultiSearchTemplateRequestDescriptor(Action<MultiSearchTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public MultiSearchTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public MultiSearchTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMultiSearchTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "msearch_template";

	public MultiSearchTemplateRequestDescriptor CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips = true) => Qs("ccs_minimize_roundtrips", ccsMinimizeRoundtrips);
	public MultiSearchTemplateRequestDescriptor MaxConcurrentSearches(long? maxConcurrentSearches) => Qs("max_concurrent_searches", maxConcurrentSearches);
	public MultiSearchTemplateRequestDescriptor RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	public MultiSearchTemplateRequestDescriptor SearchType(Elastic.Clients.Elasticsearch.Serverless.SearchType? searchType) => Qs("search_type", searchType);
	public MultiSearchTemplateRequestDescriptor TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);

	public MultiSearchTemplateRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}

	List<Elastic.Clients.Elasticsearch.Serverless.Core.MSearchTemplate.SearchTemplateRequestItem> _items = new();

	void IStreamSerializable.Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				serializable.Serialize(stream, settings, formatting);
		}
	}

	async Task IStreamSerializable.SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				await serializable.SerializeAsync(stream, settings, formatting).ConfigureAwait(false);
		}
	}

	public MultiSearchTemplateRequestDescriptor AddSearchTemplates(Elastic.Clients.Elasticsearch.Serverless.Core.MSearchTemplate.SearchTemplateRequestItem searchTemplates)
	{
		_items.Add(searchTemplates);
		return this;
	}
}