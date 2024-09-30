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

namespace Elastic.Clients.Elasticsearch.Serverless.Sql;

public sealed partial class QueryRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Format for the response.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Sql.SqlFormat? Format { get => Q<Elastic.Clients.Elasticsearch.Serverless.Sql.SqlFormat?>("format"); set => Q("format", value); }
}

/// <summary>
/// <para>
/// Executes a SQL request
/// </para>
/// </summary>
public sealed partial class QueryRequest : PlainRequest<QueryRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlQuery;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "sql.query";

	/// <summary>
	/// <para>
	/// Format for the response.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Sql.SqlFormat? Format { get => Q<Elastic.Clients.Elasticsearch.Serverless.Sql.SqlFormat?>("format"); set => Q("format", value); }

	/// <summary>
	/// <para>
	/// Default catalog (cluster) for queries. If unspecified, the queries execute on the data in the local cluster only.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("catalog")]
	public string? Catalog { get; set; }

	/// <summary>
	/// <para>
	/// If true, the results in a columnar fashion: one row represents all the values of a certain column from the current page of results.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("columnar")]
	public bool? Columnar { get; set; }

	/// <summary>
	/// <para>
	/// Cursor used to retrieve a set of paginated results.
	/// If you specify a cursor, the API only uses the <c>columnar</c> and <c>time_zone</c> request body parameters.
	/// It ignores other request body parameters.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("cursor")]
	public string? Cursor { get; set; }

	/// <summary>
	/// <para>
	/// The maximum number of rows (or entries) to return in one response
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fetch_size")]
	public int? FetchSize { get; set; }

	/// <summary>
	/// <para>
	/// Throw an exception when encountering multiple values for a field (default) or be lenient and return the first value from the list (without any guarantees of what that will be - typically the first in natural ascending order).
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field_multi_value_leniency")]
	public bool? FieldMultiValueLeniency { get; set; }

	/// <summary>
	/// <para>
	/// Elasticsearch query DSL for additional filtering.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? Filter { get; set; }

	/// <summary>
	/// <para>
	/// If true, the search can run on frozen indices. Defaults to false.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_using_frozen")]
	public bool? IndexUsingFrozen { get; set; }

	/// <summary>
	/// <para>
	/// Retention period for an async or saved synchronous search.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("keep_alive")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? KeepAlive { get; set; }

	/// <summary>
	/// <para>
	/// If true, Elasticsearch stores synchronous searches if you also specify the wait_for_completion_timeout parameter. If false, Elasticsearch only stores async searches that don’t finish before the wait_for_completion_timeout.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("keep_on_completion")]
	public bool? KeepOnCompletion { get; set; }

	/// <summary>
	/// <para>
	/// The timeout before a pagination request fails.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("page_timeout")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? PageTimeout { get; set; }

	/// <summary>
	/// <para>
	/// Values for parameters in the query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("params")]
	public IDictionary<string, object>? Params { get; set; }

	/// <summary>
	/// <para>
	/// SQL query to run.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public string? Query { get; set; }

	/// <summary>
	/// <para>
	/// The timeout before the request fails.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("request_timeout")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? RequestTimeout { get; set; }

	/// <summary>
	/// <para>
	/// Defines one or more runtime fields in the search request. These fields take
	/// precedence over mapped fields with the same name.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("runtime_mappings")]
	public IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeField>? RuntimeMappings { get; set; }

	/// <summary>
	/// <para>
	/// ISO-8601 time zone ID for the search.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_zone")]
	public string? TimeZone { get; set; }

	/// <summary>
	/// <para>
	/// Period to wait for complete results. Defaults to no timeout, meaning the request waits for complete search results. If the search doesn’t finish within this period, the search becomes async.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("wait_for_completion_timeout")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? WaitForCompletionTimeout { get; set; }
}

/// <summary>
/// <para>
/// Executes a SQL request
/// </para>
/// </summary>
public sealed partial class QueryRequestDescriptor<TDocument> : RequestDescriptor<QueryRequestDescriptor<TDocument>, QueryRequestParameters>
{
	internal QueryRequestDescriptor(Action<QueryRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public QueryRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlQuery;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "sql.query";

	public QueryRequestDescriptor<TDocument> Format(Elastic.Clients.Elasticsearch.Serverless.Sql.SqlFormat? format) => Qs("format", format);

	private string? CatalogValue { get; set; }
	private bool? ColumnarValue { get; set; }
	private string? CursorValue { get; set; }
	private int? FetchSizeValue { get; set; }
	private bool? FieldMultiValueLeniencyValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private bool? IndexUsingFrozenValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? KeepAliveValue { get; set; }
	private bool? KeepOnCompletionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? PageTimeoutValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private string? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? RequestTimeoutValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeFieldDescriptor<TDocument>> RuntimeMappingsValue { get; set; }
	private string? TimeZoneValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? WaitForCompletionTimeoutValue { get; set; }

	/// <summary>
	/// <para>
	/// Default catalog (cluster) for queries. If unspecified, the queries execute on the data in the local cluster only.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> Catalog(string? catalog)
	{
		CatalogValue = catalog;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If true, the results in a columnar fashion: one row represents all the values of a certain column from the current page of results.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> Columnar(bool? columnar = true)
	{
		ColumnarValue = columnar;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Cursor used to retrieve a set of paginated results.
	/// If you specify a cursor, the API only uses the <c>columnar</c> and <c>time_zone</c> request body parameters.
	/// It ignores other request body parameters.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> Cursor(string? cursor)
	{
		CursorValue = cursor;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The maximum number of rows (or entries) to return in one response
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> FetchSize(int? fetchSize)
	{
		FetchSizeValue = fetchSize;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Throw an exception when encountering multiple values for a field (default) or be lenient and return the first value from the list (without any guarantees of what that will be - typically the first in natural ascending order).
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> FieldMultiValueLeniency(bool? fieldMultiValueLeniency = true)
	{
		FieldMultiValueLeniencyValue = fieldMultiValueLeniency;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Elasticsearch query DSL for additional filtering.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If true, the search can run on frozen indices. Defaults to false.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> IndexUsingFrozen(bool? indexUsingFrozen = true)
	{
		IndexUsingFrozenValue = indexUsingFrozen;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Retention period for an async or saved synchronous search.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> KeepAlive(Elastic.Clients.Elasticsearch.Serverless.Duration? keepAlive)
	{
		KeepAliveValue = keepAlive;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If true, Elasticsearch stores synchronous searches if you also specify the wait_for_completion_timeout parameter. If false, Elasticsearch only stores async searches that don’t finish before the wait_for_completion_timeout.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> KeepOnCompletion(bool? keepOnCompletion = true)
	{
		KeepOnCompletionValue = keepOnCompletion;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The timeout before a pagination request fails.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> PageTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? pageTimeout)
	{
		PageTimeoutValue = pageTimeout;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Values for parameters in the query.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// SQL query to run.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> Query(string? query)
	{
		QueryValue = query;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The timeout before the request fails.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> RequestTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? requestTimeout)
	{
		RequestTimeoutValue = requestTimeout;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines one or more runtime fields in the search request. These fields take
	/// precedence over mapped fields with the same name.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> RuntimeMappings(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeFieldDescriptor<TDocument>>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeFieldDescriptor<TDocument>>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeFieldDescriptor<TDocument>>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// ISO-8601 time zone ID for the search.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Period to wait for complete results. Defaults to no timeout, meaning the request waits for complete search results. If the search doesn’t finish within this period, the search becomes async.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor<TDocument> WaitForCompletionTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? waitForCompletionTimeout)
	{
		WaitForCompletionTimeoutValue = waitForCompletionTimeout;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(CatalogValue))
		{
			writer.WritePropertyName("catalog");
			writer.WriteStringValue(CatalogValue);
		}

		if (ColumnarValue.HasValue)
		{
			writer.WritePropertyName("columnar");
			writer.WriteBooleanValue(ColumnarValue.Value);
		}

		if (!string.IsNullOrEmpty(CursorValue))
		{
			writer.WritePropertyName("cursor");
			writer.WriteStringValue(CursorValue);
		}

		if (FetchSizeValue.HasValue)
		{
			writer.WritePropertyName("fetch_size");
			writer.WriteNumberValue(FetchSizeValue.Value);
		}

		if (FieldMultiValueLeniencyValue.HasValue)
		{
			writer.WritePropertyName("field_multi_value_leniency");
			writer.WriteBooleanValue(FieldMultiValueLeniencyValue.Value);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (IndexUsingFrozenValue.HasValue)
		{
			writer.WritePropertyName("index_using_frozen");
			writer.WriteBooleanValue(IndexUsingFrozenValue.Value);
		}

		if (KeepAliveValue is not null)
		{
			writer.WritePropertyName("keep_alive");
			JsonSerializer.Serialize(writer, KeepAliveValue, options);
		}

		if (KeepOnCompletionValue.HasValue)
		{
			writer.WritePropertyName("keep_on_completion");
			writer.WriteBooleanValue(KeepOnCompletionValue.Value);
		}

		if (PageTimeoutValue is not null)
		{
			writer.WritePropertyName("page_timeout");
			JsonSerializer.Serialize(writer, PageTimeoutValue, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (!string.IsNullOrEmpty(QueryValue))
		{
			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
		}

		if (RequestTimeoutValue is not null)
		{
			writer.WritePropertyName("request_timeout");
			JsonSerializer.Serialize(writer, RequestTimeoutValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
		}

		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		if (WaitForCompletionTimeoutValue is not null)
		{
			writer.WritePropertyName("wait_for_completion_timeout");
			JsonSerializer.Serialize(writer, WaitForCompletionTimeoutValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Executes a SQL request
/// </para>
/// </summary>
public sealed partial class QueryRequestDescriptor : RequestDescriptor<QueryRequestDescriptor, QueryRequestParameters>
{
	internal QueryRequestDescriptor(Action<QueryRequestDescriptor> configure) => configure.Invoke(this);

	public QueryRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlQuery;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "sql.query";

	public QueryRequestDescriptor Format(Elastic.Clients.Elasticsearch.Serverless.Sql.SqlFormat? format) => Qs("format", format);

	private string? CatalogValue { get; set; }
	private bool? ColumnarValue { get; set; }
	private string? CursorValue { get; set; }
	private int? FetchSizeValue { get; set; }
	private bool? FieldMultiValueLeniencyValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private bool? IndexUsingFrozenValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? KeepAliveValue { get; set; }
	private bool? KeepOnCompletionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? PageTimeoutValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private string? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? RequestTimeoutValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeFieldDescriptor> RuntimeMappingsValue { get; set; }
	private string? TimeZoneValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? WaitForCompletionTimeoutValue { get; set; }

	/// <summary>
	/// <para>
	/// Default catalog (cluster) for queries. If unspecified, the queries execute on the data in the local cluster only.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor Catalog(string? catalog)
	{
		CatalogValue = catalog;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If true, the results in a columnar fashion: one row represents all the values of a certain column from the current page of results.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor Columnar(bool? columnar = true)
	{
		ColumnarValue = columnar;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Cursor used to retrieve a set of paginated results.
	/// If you specify a cursor, the API only uses the <c>columnar</c> and <c>time_zone</c> request body parameters.
	/// It ignores other request body parameters.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor Cursor(string? cursor)
	{
		CursorValue = cursor;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The maximum number of rows (or entries) to return in one response
	/// </para>
	/// </summary>
	public QueryRequestDescriptor FetchSize(int? fetchSize)
	{
		FetchSizeValue = fetchSize;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Throw an exception when encountering multiple values for a field (default) or be lenient and return the first value from the list (without any guarantees of what that will be - typically the first in natural ascending order).
	/// </para>
	/// </summary>
	public QueryRequestDescriptor FieldMultiValueLeniency(bool? fieldMultiValueLeniency = true)
	{
		FieldMultiValueLeniencyValue = fieldMultiValueLeniency;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Elasticsearch query DSL for additional filtering.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor Filter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public QueryRequestDescriptor Filter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public QueryRequestDescriptor Filter(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If true, the search can run on frozen indices. Defaults to false.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor IndexUsingFrozen(bool? indexUsingFrozen = true)
	{
		IndexUsingFrozenValue = indexUsingFrozen;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Retention period for an async or saved synchronous search.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor KeepAlive(Elastic.Clients.Elasticsearch.Serverless.Duration? keepAlive)
	{
		KeepAliveValue = keepAlive;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If true, Elasticsearch stores synchronous searches if you also specify the wait_for_completion_timeout parameter. If false, Elasticsearch only stores async searches that don’t finish before the wait_for_completion_timeout.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor KeepOnCompletion(bool? keepOnCompletion = true)
	{
		KeepOnCompletionValue = keepOnCompletion;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The timeout before a pagination request fails.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor PageTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? pageTimeout)
	{
		PageTimeoutValue = pageTimeout;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Values for parameters in the query.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// SQL query to run.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor Query(string? query)
	{
		QueryValue = query;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The timeout before the request fails.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor RequestTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? requestTimeout)
	{
		RequestTimeoutValue = requestTimeout;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines one or more runtime fields in the search request. These fields take
	/// precedence over mapped fields with the same name.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor RuntimeMappings(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeFieldDescriptor>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeFieldDescriptor>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Mapping.RuntimeFieldDescriptor>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// ISO-8601 time zone ID for the search.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Period to wait for complete results. Defaults to no timeout, meaning the request waits for complete search results. If the search doesn’t finish within this period, the search becomes async.
	/// </para>
	/// </summary>
	public QueryRequestDescriptor WaitForCompletionTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? waitForCompletionTimeout)
	{
		WaitForCompletionTimeoutValue = waitForCompletionTimeout;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(CatalogValue))
		{
			writer.WritePropertyName("catalog");
			writer.WriteStringValue(CatalogValue);
		}

		if (ColumnarValue.HasValue)
		{
			writer.WritePropertyName("columnar");
			writer.WriteBooleanValue(ColumnarValue.Value);
		}

		if (!string.IsNullOrEmpty(CursorValue))
		{
			writer.WritePropertyName("cursor");
			writer.WriteStringValue(CursorValue);
		}

		if (FetchSizeValue.HasValue)
		{
			writer.WritePropertyName("fetch_size");
			writer.WriteNumberValue(FetchSizeValue.Value);
		}

		if (FieldMultiValueLeniencyValue.HasValue)
		{
			writer.WritePropertyName("field_multi_value_leniency");
			writer.WriteBooleanValue(FieldMultiValueLeniencyValue.Value);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (IndexUsingFrozenValue.HasValue)
		{
			writer.WritePropertyName("index_using_frozen");
			writer.WriteBooleanValue(IndexUsingFrozenValue.Value);
		}

		if (KeepAliveValue is not null)
		{
			writer.WritePropertyName("keep_alive");
			JsonSerializer.Serialize(writer, KeepAliveValue, options);
		}

		if (KeepOnCompletionValue.HasValue)
		{
			writer.WritePropertyName("keep_on_completion");
			writer.WriteBooleanValue(KeepOnCompletionValue.Value);
		}

		if (PageTimeoutValue is not null)
		{
			writer.WritePropertyName("page_timeout");
			JsonSerializer.Serialize(writer, PageTimeoutValue, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (!string.IsNullOrEmpty(QueryValue))
		{
			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
		}

		if (RequestTimeoutValue is not null)
		{
			writer.WritePropertyName("request_timeout");
			JsonSerializer.Serialize(writer, RequestTimeoutValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
		}

		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		if (WaitForCompletionTimeoutValue is not null)
		{
			writer.WritePropertyName("wait_for_completion_timeout");
			JsonSerializer.Serialize(writer, WaitForCompletionTimeoutValue, options);
		}

		writer.WriteEndObject();
	}
}