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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch;
public sealed class ScriptContextRequestParameters : RequestParameters<ScriptContextRequestParameters>
{
}

public sealed partial class ScriptContextRequest : PlainRequest<ScriptContextRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGetScriptContext;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
}

public sealed partial class ScriptContextRequestDescriptor : RequestDescriptor<ScriptContextRequestDescriptor, ScriptContextRequestParameters>
{
	internal ScriptContextRequestDescriptor(Action<ScriptContextRequestDescriptor> configure) => configure.Invoke(this);
	public ScriptContextRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGetScriptContext;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}