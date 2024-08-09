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

namespace Elastic.Clients.Elasticsearch.Serverless.Cluster;

public sealed partial class OperatingSystemMemoryInfo
{
	/// <summary>
	/// <para>
	/// Total amount, in bytes, of memory across all selected nodes, but using the value specified using the <c>es.total_memory_bytes</c> system property instead of measured total memory for those nodes where that system property was set.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("adjusted_total_in_bytes")]
	public long? AdjustedTotalInBytes { get; init; }

	/// <summary>
	/// <para>
	/// Amount, in bytes, of free physical memory across all selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("free_in_bytes")]
	public long FreeInBytes { get; init; }

	/// <summary>
	/// <para>
	/// Percentage of free physical memory across all selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("free_percent")]
	public int FreePercent { get; init; }

	/// <summary>
	/// <para>
	/// Total amount, in bytes, of physical memory across all selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("total_in_bytes")]
	public long TotalInBytes { get; init; }

	/// <summary>
	/// <para>
	/// Amount, in bytes, of physical memory in use across all selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("used_in_bytes")]
	public long UsedInBytes { get; init; }

	/// <summary>
	/// <para>
	/// Percentage of physical memory in use across all selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("used_percent")]
	public int UsedPercent { get; init; }
}