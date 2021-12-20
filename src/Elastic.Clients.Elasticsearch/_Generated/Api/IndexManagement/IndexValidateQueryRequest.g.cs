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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexValidateQueryRequestParameters : RequestParameters<IndexValidateQueryRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? AllShards { get => Q<bool?>("all_shards"); set => Q("all_shards", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.QueryDsl.Operator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public bool? Rewrite { get => Q<bool?>("rewrite"); set => Q("rewrite", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }
	}

	public partial class IndexValidateQueryRequest : PlainRequestBase<IndexValidateQueryRequestParameters>
	{
		public IndexValidateQueryRequest()
		{
		}

		public IndexValidateQueryRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementValidateQuery;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? AllShards { get => Q<bool?>("all_shards"); set => Q("all_shards", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.QueryDsl.Operator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public bool? Rewrite { get => Q<bool?>("rewrite"); set => Q("rewrite", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Query { get; set; }
	}

	public sealed partial class IndexValidateQueryRequestDescriptor<TDocument> : RequestDescriptorBase<IndexValidateQueryRequestDescriptor<TDocument>, IndexValidateQueryRequestParameters>
	{
		public IndexValidateQueryRequestDescriptor() : this(typeof(TDocument))
		{
		}

		public IndexValidateQueryRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal IndexValidateQueryRequestDescriptor(Action<IndexValidateQueryRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementValidateQuery;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public IndexValidateQueryRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public IndexValidateQueryRequestDescriptor<TDocument> AllShards(bool? allShards) => Qs("all_shards", allShards);
		public IndexValidateQueryRequestDescriptor<TDocument> Analyzer(string? analyzer) => Qs("analyzer", analyzer);
		public IndexValidateQueryRequestDescriptor<TDocument> AnalyzeWildcard(bool? analyzeWildcard) => Qs("analyze_wildcard", analyzeWildcard);
		public IndexValidateQueryRequestDescriptor<TDocument> DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator) => Qs("default_operator", defaultOperator);
		public IndexValidateQueryRequestDescriptor<TDocument> Df(string? df) => Qs("df", df);
		public IndexValidateQueryRequestDescriptor<TDocument> ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public IndexValidateQueryRequestDescriptor<TDocument> Explain(bool? explain) => Qs("explain", explain);
		public IndexValidateQueryRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public IndexValidateQueryRequestDescriptor<TDocument> Lenient(bool? lenient) => Qs("lenient", lenient);
		public IndexValidateQueryRequestDescriptor<TDocument> Rewrite(bool? rewrite) => Qs("rewrite", rewrite);
		public IndexValidateQueryRequestDescriptor<TDocument> QueryLuceneSyntax(string? q) => Qs("q", q);
		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; private set; }

		internal QueryDsl.QueryContainerDescriptor<TDocument> QueryDescriptor { get; private set; }

		internal Action<QueryDsl.QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; private set; }

		public IndexValidateQueryRequestDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			return Assign(query, (a, v) => a.QueryValue = v);
		}

		public IndexValidateQueryRequestDescriptor<TDocument> Query(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.QueryDescriptor = v);
		}

		public IndexValidateQueryRequestDescriptor<TDocument> Query(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(configure, (a, v) => a.QueryDescriptorAction = v);
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else if (QueryValue is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			writer.WriteEndObject();
		}
	}
}