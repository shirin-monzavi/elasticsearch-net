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

namespace Elastic.Clients.Elasticsearch.Serverless.Ingest;

public sealed partial class DatabaseConfiguration
{
	/// <summary>
	/// <para>
	/// The configuration necessary to identify which IP geolocation provider to use to download the database, as well as any provider-specific configuration necessary for such downloading.
	/// At present, the only supported provider is maxmind, and the maxmind provider requires that an account_id (string) is configured.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("maxmind")]
	public Elastic.Clients.Elasticsearch.Serverless.Ingest.Maxmind Maxmind { get; init; }

	/// <summary>
	/// <para>
	/// The provider-assigned name of the IP geolocation database to download.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("name")]
	public string Name { get; init; }
}