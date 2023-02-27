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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl;
public sealed partial class ScriptScoreFunction
{
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script Script { get; set; }

	public static implicit operator FunctionScore(ScriptScoreFunction scriptScoreFunction) => QueryDsl.FunctionScore.ScriptScore(scriptScoreFunction);
}

public sealed partial class ScriptScoreFunctionDescriptor : SerializableDescriptor<ScriptScoreFunctionDescriptor>
{
	internal ScriptScoreFunctionDescriptor(Action<ScriptScoreFunctionDescriptor> configure) => configure.Invoke(this);
	public ScriptScoreFunctionDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Script ScriptValue { get; set; }

	public ScriptScoreFunctionDescriptor Script(Elastic.Clients.Elasticsearch.Script script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("script");
		JsonSerializer.Serialize(writer, ScriptValue, options);
		writer.WriteEndObject();
	}
}