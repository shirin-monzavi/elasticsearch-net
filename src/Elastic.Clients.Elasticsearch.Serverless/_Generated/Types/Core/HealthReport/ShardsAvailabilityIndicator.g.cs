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

namespace Elastic.Clients.Elasticsearch.Serverless.Core.HealthReport;

/// <summary>
/// <para>
/// SHARDS_AVAILABILITY
/// </para>
/// </summary>
public sealed partial class ShardsAvailabilityIndicator
{
	[JsonInclude, JsonPropertyName("details")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.HealthReport.ShardsAvailabilityIndicatorDetails? Details { get; init; }
	[JsonInclude, JsonPropertyName("diagnosis")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Core.HealthReport.Diagnosis>? Diagnosis { get; init; }
	[JsonInclude, JsonPropertyName("impacts")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Core.HealthReport.Impact>? Impacts { get; init; }
	[JsonInclude, JsonPropertyName("status")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.HealthReport.IndicatorHealthStatus Status { get; init; }
	[JsonInclude, JsonPropertyName("symptom")]
	public string Symptom { get; init; }
}