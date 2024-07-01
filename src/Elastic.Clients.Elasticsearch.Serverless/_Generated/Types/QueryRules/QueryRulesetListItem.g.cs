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
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.QueryRules;

public sealed partial class QueryRulesetListItem
{
	/// <summary>
	/// <para>A map of criteria type to the number of rules of that type</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("rule_criteria_types_counts")]
	public IReadOnlyDictionary<string, string> RuleCriteriaTypesCounts { get; init; }

	/// <summary>
	/// <para>Ruleset unique identifier</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ruleset_id")]
	public string RulesetId { get; init; }

	/// <summary>
	/// <para>The number of rules associated with this ruleset</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("rule_total_count")]
	public int RuleTotalCount { get; init; }
}