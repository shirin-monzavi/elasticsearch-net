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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Nodes;

public sealed partial class PublishedClusterStates
{
	/// <summary>
	/// <para>
	/// Number of compatible differences between published cluster states.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("compatible_diffs")]
	public long? CompatibleDiffs { get; init; }

	/// <summary>
	/// <para>
	/// Number of published cluster states.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("full_states")]
	public long? FullStates { get; init; }

	/// <summary>
	/// <para>
	/// Number of incompatible differences between published cluster states.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("incompatible_diffs")]
	public long? IncompatibleDiffs { get; init; }
}