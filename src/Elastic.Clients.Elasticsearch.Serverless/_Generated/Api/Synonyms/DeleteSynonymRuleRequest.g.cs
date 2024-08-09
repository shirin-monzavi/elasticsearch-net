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

namespace Elastic.Clients.Elasticsearch.Serverless.Synonyms;

public sealed partial class DeleteSynonymRuleRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Deletes a synonym rule in a synonym set
/// </para>
/// </summary>
public sealed partial class DeleteSynonymRuleRequest : PlainRequest<DeleteSynonymRuleRequestParameters>
{
	public DeleteSynonymRuleRequest(Elastic.Clients.Elasticsearch.Serverless.Id setId, Elastic.Clients.Elasticsearch.Serverless.Id ruleId) : base(r => r.Required("set_id", setId).Required("rule_id", ruleId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsDeleteSynonymRule;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.delete_synonym_rule";
}

/// <summary>
/// <para>
/// Deletes a synonym rule in a synonym set
/// </para>
/// </summary>
public sealed partial class DeleteSynonymRuleRequestDescriptor : RequestDescriptor<DeleteSynonymRuleRequestDescriptor, DeleteSynonymRuleRequestParameters>
{
	internal DeleteSynonymRuleRequestDescriptor(Action<DeleteSynonymRuleRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteSynonymRuleRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id setId, Elastic.Clients.Elasticsearch.Serverless.Id ruleId) : base(r => r.Required("set_id", setId).Required("rule_id", ruleId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsDeleteSynonymRule;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.delete_synonym_rule";

	public DeleteSynonymRuleRequestDescriptor RuleId(Elastic.Clients.Elasticsearch.Serverless.Id ruleId)
	{
		RouteValues.Required("rule_id", ruleId);
		return Self;
	}

	public DeleteSynonymRuleRequestDescriptor SetId(Elastic.Clients.Elasticsearch.Serverless.Id setId)
	{
		RouteValues.Required("set_id", setId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}