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

namespace Elastic.Clients.Elasticsearch.Synonyms;

public sealed partial class DeleteSynonymRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Deletes a synonym set
/// </para>
/// </summary>
public sealed partial class DeleteSynonymRequest : PlainRequest<DeleteSynonymRequestParameters>
{
	public DeleteSynonymRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsDeleteSynonym;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.delete_synonym";
}

/// <summary>
/// <para>
/// Deletes a synonym set
/// </para>
/// </summary>
public sealed partial class DeleteSynonymRequestDescriptor<TDocument> : RequestDescriptor<DeleteSynonymRequestDescriptor<TDocument>, DeleteSynonymRequestParameters>
{
	internal DeleteSynonymRequestDescriptor(Action<DeleteSynonymRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DeleteSynonymRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsDeleteSynonym;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.delete_synonym";

	public DeleteSynonymRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Deletes a synonym set
/// </para>
/// </summary>
public sealed partial class DeleteSynonymRequestDescriptor : RequestDescriptor<DeleteSynonymRequestDescriptor, DeleteSynonymRequestParameters>
{
	internal DeleteSynonymRequestDescriptor(Action<DeleteSynonymRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteSynonymRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsDeleteSynonym;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.delete_synonym";

	public DeleteSynonymRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}