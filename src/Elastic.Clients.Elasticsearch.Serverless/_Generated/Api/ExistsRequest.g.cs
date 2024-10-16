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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class ExistsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Specifies the node or shard the operation should be performed on.
	/// Random by default.
	/// </para>
	/// </summary>
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the request is real-time as opposed to near-real-time.
	/// </para>
	/// </summary>
	public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, Elasticsearch refreshes all shards involved in the delete by query after the request completes.
	/// </para>
	/// </summary>
	public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>
	/// Target the specified primary shard.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Serverless.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// <c>true</c> or <c>false</c> to return the <c>_source</c> field or not, or a list of fields to return.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam?>("_source"); set => Q("_source", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of source fields to exclude in the response.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of source fields to include in the response.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	/// <summary>
	/// <para>
	/// List of stored fields to return as part of a hit.
	/// If no fields are specified, no stored fields are included in the response.
	/// If this field is specified, the <c>_source</c> parameter defaults to false.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("stored_fields"); set => Q("stored_fields", value); }

	/// <summary>
	/// <para>
	/// Explicit version number for concurrency control.
	/// The specified version must match the current version of the document for the request to succeed.
	/// </para>
	/// </summary>
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	/// <summary>
	/// <para>
	/// Specific version type: <c>external</c>, <c>external_gte</c>.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.Serverless.VersionType?>("version_type"); set => Q("version_type", value); }
}

/// <summary>
/// <para>
/// Check a document.
/// Checks if a specified document exists.
/// </para>
/// </summary>
public sealed partial class ExistsRequest : PlainRequest<ExistsRequestParameters>
{
	public ExistsRequest(Elastic.Clients.Elasticsearch.Serverless.IndexName index, Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceExists;

	protected override HttpMethod StaticHttpMethod => HttpMethod.HEAD;

	internal override bool SupportsBody => false;

	internal override string OperationName => "exists";

	/// <summary>
	/// <para>
	/// Specifies the node or shard the operation should be performed on.
	/// Random by default.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the request is real-time as opposed to near-real-time.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, Elasticsearch refreshes all shards involved in the delete by query after the request completes.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>
	/// Target the specified primary shard.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Serverless.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// <c>true</c> or <c>false</c> to return the <c>_source</c> field or not, or a list of fields to return.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam?>("_source"); set => Q("_source", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of source fields to exclude in the response.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of source fields to include in the response.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	/// <summary>
	/// <para>
	/// List of stored fields to return as part of a hit.
	/// If no fields are specified, no stored fields are included in the response.
	/// If this field is specified, the <c>_source</c> parameter defaults to false.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("stored_fields"); set => Q("stored_fields", value); }

	/// <summary>
	/// <para>
	/// Explicit version number for concurrency control.
	/// The specified version must match the current version of the document for the request to succeed.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	/// <summary>
	/// <para>
	/// Specific version type: <c>external</c>, <c>external_gte</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.Serverless.VersionType?>("version_type"); set => Q("version_type", value); }
}

/// <summary>
/// <para>
/// Check a document.
/// Checks if a specified document exists.
/// </para>
/// </summary>
public sealed partial class ExistsRequestDescriptor<TDocument> : RequestDescriptor<ExistsRequestDescriptor<TDocument>, ExistsRequestParameters>
{
	internal ExistsRequestDescriptor(Action<ExistsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public ExistsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.IndexName index, Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	public ExistsRequestDescriptor(TDocument document) : this(typeof(TDocument), Elastic.Clients.Elasticsearch.Serverless.Id.From(document))
	{
	}

	public ExistsRequestDescriptor(TDocument document, Elastic.Clients.Elasticsearch.Serverless.IndexName index) : this(index, Elastic.Clients.Elasticsearch.Serverless.Id.From(document))
	{
	}

	public ExistsRequestDescriptor(TDocument document, Elastic.Clients.Elasticsearch.Serverless.Id id) : this(typeof(TDocument), id)
	{
	}

	public ExistsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : this(typeof(TDocument), id)
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceExists;

	protected override HttpMethod StaticHttpMethod => HttpMethod.HEAD;

	internal override bool SupportsBody => false;

	internal override string OperationName => "exists";

	public ExistsRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
	public ExistsRequestDescriptor<TDocument> Realtime(bool? realtime = true) => Qs("realtime", realtime);
	public ExistsRequestDescriptor<TDocument> Refresh(bool? refresh = true) => Qs("refresh", refresh);
	public ExistsRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing) => Qs("routing", routing);
	public ExistsRequestDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam? source) => Qs("_source", source);
	public ExistsRequestDescriptor<TDocument> SourceExcludes(Elastic.Clients.Elasticsearch.Serverless.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
	public ExistsRequestDescriptor<TDocument> SourceIncludes(Elastic.Clients.Elasticsearch.Serverless.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
	public ExistsRequestDescriptor<TDocument> StoredFields(Elastic.Clients.Elasticsearch.Serverless.Fields? storedFields) => Qs("stored_fields", storedFields);
	public ExistsRequestDescriptor<TDocument> Version(long? version) => Qs("version", version);
	public ExistsRequestDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.Serverless.VersionType? versionType) => Qs("version_type", versionType);

	public ExistsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	public ExistsRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.Serverless.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Check a document.
/// Checks if a specified document exists.
/// </para>
/// </summary>
public sealed partial class ExistsRequestDescriptor : RequestDescriptor<ExistsRequestDescriptor, ExistsRequestParameters>
{
	internal ExistsRequestDescriptor(Action<ExistsRequestDescriptor> configure) => configure.Invoke(this);

	public ExistsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.IndexName index, Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceExists;

	protected override HttpMethod StaticHttpMethod => HttpMethod.HEAD;

	internal override bool SupportsBody => false;

	internal override string OperationName => "exists";

	public ExistsRequestDescriptor Preference(string? preference) => Qs("preference", preference);
	public ExistsRequestDescriptor Realtime(bool? realtime = true) => Qs("realtime", realtime);
	public ExistsRequestDescriptor Refresh(bool? refresh = true) => Qs("refresh", refresh);
	public ExistsRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing) => Qs("routing", routing);
	public ExistsRequestDescriptor Source(Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam? source) => Qs("_source", source);
	public ExistsRequestDescriptor SourceExcludes(Elastic.Clients.Elasticsearch.Serverless.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
	public ExistsRequestDescriptor SourceIncludes(Elastic.Clients.Elasticsearch.Serverless.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
	public ExistsRequestDescriptor StoredFields(Elastic.Clients.Elasticsearch.Serverless.Fields? storedFields) => Qs("stored_fields", storedFields);
	public ExistsRequestDescriptor Version(long? version) => Qs("version", version);
	public ExistsRequestDescriptor VersionType(Elastic.Clients.Elasticsearch.Serverless.VersionType? versionType) => Qs("version_type", versionType);

	public ExistsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	public ExistsRequestDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}