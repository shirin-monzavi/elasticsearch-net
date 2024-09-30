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

namespace Elastic.Clients.Elasticsearch.Esql;

public sealed partial class EsqlQueryRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// The character to use between values within a CSV row. Only valid for the CSV format.
	/// </para>
	/// </summary>
	public string? Delimiter { get => Q<string?>("delimiter"); set => Q("delimiter", value); }

	/// <summary>
	/// <para>
	/// Should columns that are entirely <c>null</c> be removed from the <c>columns</c> and <c>values</c> portion of the results?
	/// Defaults to <c>false</c>. If <c>true</c> then the response will include an extra section under the name <c>all_columns</c> which has the name of all columns.
	/// </para>
	/// </summary>
	public bool? DropNullColumns { get => Q<bool?>("drop_null_columns"); set => Q("drop_null_columns", value); }

	/// <summary>
	/// <para>
	/// A short version of the Accept header, e.g. json, yaml.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Esql.EsqlFormat? Format { get => Q<Elastic.Clients.Elasticsearch.Esql.EsqlFormat?>("format"); set => Q("format", value); }
}

/// <summary>
/// <para>
/// Executes an ES|QL request
/// </para>
/// </summary>
public sealed partial class EsqlQueryRequest : PlainRequest<EsqlQueryRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.EsqlQuery;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "esql.query";

	/// <summary>
	/// <para>
	/// The character to use between values within a CSV row. Only valid for the CSV format.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public string? Delimiter { get => Q<string?>("delimiter"); set => Q("delimiter", value); }

	/// <summary>
	/// <para>
	/// Should columns that are entirely <c>null</c> be removed from the <c>columns</c> and <c>values</c> portion of the results?
	/// Defaults to <c>false</c>. If <c>true</c> then the response will include an extra section under the name <c>all_columns</c> which has the name of all columns.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? DropNullColumns { get => Q<bool?>("drop_null_columns"); set => Q("drop_null_columns", value); }

	/// <summary>
	/// <para>
	/// A short version of the Accept header, e.g. json, yaml.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Esql.EsqlFormat? Format { get => Q<Elastic.Clients.Elasticsearch.Esql.EsqlFormat?>("format"); set => Q("format", value); }

	/// <summary>
	/// <para>
	/// By default, ES|QL returns results as rows. For example, FROM returns each individual document as one row. For the JSON, YAML, CBOR and smile formats, ES|QL can return the results in a columnar fashion where one row represents all the values of a certain column in the results.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("columnar")]
	public bool? Columnar { get; set; }

	/// <summary>
	/// <para>
	/// Specify a Query DSL query in the filter parameter to filter the set of documents that an ES|QL query runs on.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? Filter { get; set; }
	[JsonInclude, JsonPropertyName("locale")]
	public string? Locale { get; set; }

	/// <summary>
	/// <para>
	/// To avoid any attempts of hacking or code injection, extract the values in a separate list of parameters. Use question mark placeholders (?) in the query string for each of the parameters.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("params")]
	public ICollection<Elastic.Clients.Elasticsearch.FieldValue>? Params { get; set; }

	/// <summary>
	/// <para>
	/// If provided and <c>true</c> the response will include an extra <c>profile</c> object
	/// with information on how the query was executed. This information is for human debugging
	/// and its format can change at any time but it can give some insight into the performance
	/// of each part of the query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("profile")]
	public bool? Profile { get; set; }

	/// <summary>
	/// <para>
	/// The ES|QL query API accepts an ES|QL query string in the query parameter, runs it, and returns the results.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public string Query { get; set; }
}

/// <summary>
/// <para>
/// Executes an ES|QL request
/// </para>
/// </summary>
public sealed partial class EsqlQueryRequestDescriptor<TDocument> : RequestDescriptor<EsqlQueryRequestDescriptor<TDocument>, EsqlQueryRequestParameters>
{
	internal EsqlQueryRequestDescriptor(Action<EsqlQueryRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public EsqlQueryRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EsqlQuery;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "esql.query";

	public EsqlQueryRequestDescriptor<TDocument> Delimiter(string? delimiter) => Qs("delimiter", delimiter);
	public EsqlQueryRequestDescriptor<TDocument> DropNullColumns(bool? dropNullColumns = true) => Qs("drop_null_columns", dropNullColumns);
	public EsqlQueryRequestDescriptor<TDocument> Format(Elastic.Clients.Elasticsearch.Esql.EsqlFormat? format) => Qs("format", format);

	private bool? ColumnarValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private string? LocaleValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.FieldValue>? ParamsValue { get; set; }
	private bool? ProfileValue { get; set; }
	private string QueryValue { get; set; }

	/// <summary>
	/// <para>
	/// By default, ES|QL returns results as rows. For example, FROM returns each individual document as one row. For the JSON, YAML, CBOR and smile formats, ES|QL can return the results in a columnar fashion where one row represents all the values of a certain column in the results.
	/// </para>
	/// </summary>
	public EsqlQueryRequestDescriptor<TDocument> Columnar(bool? columnar = true)
	{
		ColumnarValue = columnar;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specify a Query DSL query in the filter parameter to filter the set of documents that an ES|QL query runs on.
	/// </para>
	/// </summary>
	public EsqlQueryRequestDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.Query? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public EsqlQueryRequestDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public EsqlQueryRequestDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public EsqlQueryRequestDescriptor<TDocument> Locale(string? locale)
	{
		LocaleValue = locale;
		return Self;
	}

	/// <summary>
	/// <para>
	/// To avoid any attempts of hacking or code injection, extract the values in a separate list of parameters. Use question mark placeholders (?) in the query string for each of the parameters.
	/// </para>
	/// </summary>
	public EsqlQueryRequestDescriptor<TDocument> Params(ICollection<Elastic.Clients.Elasticsearch.FieldValue>? value)
	{
		ParamsValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If provided and <c>true</c> the response will include an extra <c>profile</c> object
	/// with information on how the query was executed. This information is for human debugging
	/// and its format can change at any time but it can give some insight into the performance
	/// of each part of the query.
	/// </para>
	/// </summary>
	public EsqlQueryRequestDescriptor<TDocument> Profile(bool? profile = true)
	{
		ProfileValue = profile;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The ES|QL query API accepts an ES|QL query string in the query parameter, runs it, and returns the results.
	/// </para>
	/// </summary>
	public EsqlQueryRequestDescriptor<TDocument> Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ColumnarValue.HasValue)
		{
			writer.WritePropertyName("columnar");
			writer.WriteBooleanValue(ColumnarValue.Value);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (!string.IsNullOrEmpty(LocaleValue))
		{
			writer.WritePropertyName("locale");
			writer.WriteStringValue(LocaleValue);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ProfileValue.HasValue)
		{
			writer.WritePropertyName("profile");
			writer.WriteBooleanValue(ProfileValue.Value);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Executes an ES|QL request
/// </para>
/// </summary>
public sealed partial class EsqlQueryRequestDescriptor : RequestDescriptor<EsqlQueryRequestDescriptor, EsqlQueryRequestParameters>
{
	internal EsqlQueryRequestDescriptor(Action<EsqlQueryRequestDescriptor> configure) => configure.Invoke(this);

	public EsqlQueryRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EsqlQuery;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "esql.query";

	public EsqlQueryRequestDescriptor Delimiter(string? delimiter) => Qs("delimiter", delimiter);
	public EsqlQueryRequestDescriptor DropNullColumns(bool? dropNullColumns = true) => Qs("drop_null_columns", dropNullColumns);
	public EsqlQueryRequestDescriptor Format(Elastic.Clients.Elasticsearch.Esql.EsqlFormat? format) => Qs("format", format);

	private bool? ColumnarValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private string? LocaleValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.FieldValue>? ParamsValue { get; set; }
	private bool? ProfileValue { get; set; }
	private string QueryValue { get; set; }

	/// <summary>
	/// <para>
	/// By default, ES|QL returns results as rows. For example, FROM returns each individual document as one row. For the JSON, YAML, CBOR and smile formats, ES|QL can return the results in a columnar fashion where one row represents all the values of a certain column in the results.
	/// </para>
	/// </summary>
	public EsqlQueryRequestDescriptor Columnar(bool? columnar = true)
	{
		ColumnarValue = columnar;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specify a Query DSL query in the filter parameter to filter the set of documents that an ES|QL query runs on.
	/// </para>
	/// </summary>
	public EsqlQueryRequestDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.Query? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public EsqlQueryRequestDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public EsqlQueryRequestDescriptor Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public EsqlQueryRequestDescriptor Locale(string? locale)
	{
		LocaleValue = locale;
		return Self;
	}

	/// <summary>
	/// <para>
	/// To avoid any attempts of hacking or code injection, extract the values in a separate list of parameters. Use question mark placeholders (?) in the query string for each of the parameters.
	/// </para>
	/// </summary>
	public EsqlQueryRequestDescriptor Params(ICollection<Elastic.Clients.Elasticsearch.FieldValue>? value)
	{
		ParamsValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If provided and <c>true</c> the response will include an extra <c>profile</c> object
	/// with information on how the query was executed. This information is for human debugging
	/// and its format can change at any time but it can give some insight into the performance
	/// of each part of the query.
	/// </para>
	/// </summary>
	public EsqlQueryRequestDescriptor Profile(bool? profile = true)
	{
		ProfileValue = profile;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The ES|QL query API accepts an ES|QL query string in the query parameter, runs it, and returns the results.
	/// </para>
	/// </summary>
	public EsqlQueryRequestDescriptor Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ColumnarValue.HasValue)
		{
			writer.WritePropertyName("columnar");
			writer.WriteBooleanValue(ColumnarValue.Value);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (!string.IsNullOrEmpty(LocaleValue))
		{
			writer.WritePropertyName("locale");
			writer.WriteStringValue(LocaleValue);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ProfileValue.HasValue)
		{
			writer.WritePropertyName("profile");
			writer.WriteBooleanValue(ProfileValue.Value);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		writer.WriteEndObject();
	}
}