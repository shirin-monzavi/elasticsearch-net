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
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Nodes;

public sealed partial class ReloadSecureSettingsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Period to wait for a response.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Reloads the keystore on nodes in the cluster.
/// </para>
/// </summary>
public sealed partial class ReloadSecureSettingsRequest : PlainRequest<ReloadSecureSettingsRequestParameters>
{
	public ReloadSecureSettingsRequest()
	{
	}

	public ReloadSecureSettingsRequest(Elastic.Clients.Elasticsearch.NodeIds? nodeId) : base(r => r.Optional("node_id", nodeId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NodesReloadSecureSettings;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "nodes.reload_secure_settings";

	/// <summary>
	/// <para>
	/// Period to wait for a response.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// The password for the Elasticsearch keystore.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("secure_settings_password")]
	public string? SecureSettingsPassword { get; set; }
}

/// <summary>
/// <para>
/// Reloads the keystore on nodes in the cluster.
/// </para>
/// </summary>
public sealed partial class ReloadSecureSettingsRequestDescriptor : RequestDescriptor<ReloadSecureSettingsRequestDescriptor, ReloadSecureSettingsRequestParameters>
{
	internal ReloadSecureSettingsRequestDescriptor(Action<ReloadSecureSettingsRequestDescriptor> configure) => configure.Invoke(this);

	public ReloadSecureSettingsRequestDescriptor(Elastic.Clients.Elasticsearch.NodeIds? nodeId) : base(r => r.Optional("node_id", nodeId))
	{
	}

	public ReloadSecureSettingsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NodesReloadSecureSettings;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "nodes.reload_secure_settings";

	public ReloadSecureSettingsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public ReloadSecureSettingsRequestDescriptor NodeId(Elastic.Clients.Elasticsearch.NodeIds? nodeId)
	{
		RouteValues.Optional("node_id", nodeId);
		return Self;
	}

	private string? SecureSettingsPasswordValue { get; set; }

	/// <summary>
	/// <para>
	/// The password for the Elasticsearch keystore.
	/// </para>
	/// </summary>
	public ReloadSecureSettingsRequestDescriptor SecureSettingsPassword(string? secureSettingsPassword)
	{
		SecureSettingsPasswordValue = secureSettingsPassword;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(SecureSettingsPasswordValue))
		{
			writer.WritePropertyName("secure_settings_password");
			writer.WriteStringValue(SecureSettingsPasswordValue);
		}

		writer.WriteEndObject();
	}
}