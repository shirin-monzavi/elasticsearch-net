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

public sealed partial class OpenPointInTimeRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Type of index that wildcard patterns can match.<br/>If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.<br/>Supports comma-separated values, such as `open,hidden`. Valid values are: `all`, `open`, `closed`, `hidden`, `none`.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `false`, the request returns an error if it targets a missing or closed index.</para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>Extends the time to live of the corresponding point in time.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration KeepAlive { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration>("keep_alive"); set => Q("keep_alive", value); }

	/// <summary>
	/// <para>Specifies the node or shard the operation should be performed on.<br/>Random by default.</para>
	/// </summary>
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Serverless.Routing?>("routing"); set => Q("routing", value); }
}

/// <summary>
/// <para>A search request by default executes against the most recent visible data of the target indices,<br/>which is called point in time. Elasticsearch pit (point in time) is a lightweight view into the<br/>state of the data as it existed when initiated. In some cases, it’s preferred to perform multiple<br/>search requests using the same point in time. For example, if refreshes happen between<br/>`search_after` requests, then the results of those requests might not be consistent as changes happening<br/>between searches are only visible to the more recent point in time.</para>
/// </summary>
public sealed partial class OpenPointInTimeRequest : PlainRequest<OpenPointInTimeRequestParameters>
{
	public OpenPointInTimeRequest(Elastic.Clients.Elasticsearch.Serverless.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceOpenPointInTime;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "open_point_in_time";

	/// <summary>
	/// <para>Type of index that wildcard patterns can match.<br/>If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.<br/>Supports comma-separated values, such as `open,hidden`. Valid values are: `all`, `open`, `closed`, `hidden`, `none`.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `false`, the request returns an error if it targets a missing or closed index.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>Extends the time to live of the corresponding point in time.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration KeepAlive { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration>("keep_alive"); set => Q("keep_alive", value); }

	/// <summary>
	/// <para>Specifies the node or shard the operation should be performed on.<br/>Random by default.</para>
	/// </summary>
	[JsonIgnore]
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Serverless.Routing?>("routing"); set => Q("routing", value); }
}

/// <summary>
/// <para>A search request by default executes against the most recent visible data of the target indices,<br/>which is called point in time. Elasticsearch pit (point in time) is a lightweight view into the<br/>state of the data as it existed when initiated. In some cases, it’s preferred to perform multiple<br/>search requests using the same point in time. For example, if refreshes happen between<br/>`search_after` requests, then the results of those requests might not be consistent as changes happening<br/>between searches are only visible to the more recent point in time.</para>
/// </summary>
public sealed partial class OpenPointInTimeRequestDescriptor<TDocument> : RequestDescriptor<OpenPointInTimeRequestDescriptor<TDocument>, OpenPointInTimeRequestParameters>
{
	internal OpenPointInTimeRequestDescriptor(Action<OpenPointInTimeRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public OpenPointInTimeRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal OpenPointInTimeRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceOpenPointInTime;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "open_point_in_time";

	public OpenPointInTimeRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public OpenPointInTimeRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public OpenPointInTimeRequestDescriptor<TDocument> KeepAlive(Elastic.Clients.Elasticsearch.Serverless.Duration keepAlive) => Qs("keep_alive", keepAlive);
	public OpenPointInTimeRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
	public OpenPointInTimeRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing) => Qs("routing", routing);

	public OpenPointInTimeRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Serverless.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>A search request by default executes against the most recent visible data of the target indices,<br/>which is called point in time. Elasticsearch pit (point in time) is a lightweight view into the<br/>state of the data as it existed when initiated. In some cases, it’s preferred to perform multiple<br/>search requests using the same point in time. For example, if refreshes happen between<br/>`search_after` requests, then the results of those requests might not be consistent as changes happening<br/>between searches are only visible to the more recent point in time.</para>
/// </summary>
public sealed partial class OpenPointInTimeRequestDescriptor : RequestDescriptor<OpenPointInTimeRequestDescriptor, OpenPointInTimeRequestParameters>
{
	internal OpenPointInTimeRequestDescriptor(Action<OpenPointInTimeRequestDescriptor> configure) => configure.Invoke(this);

	public OpenPointInTimeRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal OpenPointInTimeRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceOpenPointInTime;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "open_point_in_time";

	public OpenPointInTimeRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public OpenPointInTimeRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public OpenPointInTimeRequestDescriptor KeepAlive(Elastic.Clients.Elasticsearch.Serverless.Duration keepAlive) => Qs("keep_alive", keepAlive);
	public OpenPointInTimeRequestDescriptor Preference(string? preference) => Qs("preference", preference);
	public OpenPointInTimeRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing) => Qs("routing", routing);

	public OpenPointInTimeRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Serverless.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}