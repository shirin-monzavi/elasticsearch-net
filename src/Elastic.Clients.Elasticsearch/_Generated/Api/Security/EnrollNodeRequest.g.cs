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

namespace Elastic.Clients.Elasticsearch.Security;

public sealed partial class EnrollNodeRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Allows a new node to join an existing cluster with security features enabled.
/// </para>
/// </summary>
public sealed partial class EnrollNodeRequest : PlainRequest<EnrollNodeRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityEnrollNode;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.enroll_node";
}

/// <summary>
/// <para>
/// Allows a new node to join an existing cluster with security features enabled.
/// </para>
/// </summary>
public sealed partial class EnrollNodeRequestDescriptor : RequestDescriptor<EnrollNodeRequestDescriptor, EnrollNodeRequestParameters>
{
	internal EnrollNodeRequestDescriptor(Action<EnrollNodeRequestDescriptor> configure) => configure.Invoke(this);

	public EnrollNodeRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityEnrollNode;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.enroll_node";

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}