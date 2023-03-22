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

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;
using Elastic.Clients.Elasticsearch.Serialization;

namespace Elastic.Clients.Elasticsearch.Watcher;

[JsonConverter(typeof(ActionStatusOptionsConverter))]
public enum ActionStatusOptions
{
	[EnumMember(Value = "throttled")]
	Throttled,
	[EnumMember(Value = "success")]
	Success,
	[EnumMember(Value = "simulated")]
	Simulated,
	[EnumMember(Value = "failure")]
	Failure
}

internal sealed class ActionStatusOptionsConverter : JsonConverter<ActionStatusOptions>
{
	public override ActionStatusOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "throttled":
				return ActionStatusOptions.Throttled;
			case "success":
				return ActionStatusOptions.Success;
			case "simulated":
				return ActionStatusOptions.Simulated;
			case "failure":
				return ActionStatusOptions.Failure;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, ActionStatusOptions value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case ActionStatusOptions.Throttled:
				writer.WriteStringValue("throttled");
				return;
			case ActionStatusOptions.Success:
				writer.WriteStringValue("success");
				return;
			case ActionStatusOptions.Simulated:
				writer.WriteStringValue("simulated");
				return;
			case ActionStatusOptions.Failure:
				writer.WriteStringValue("failure");
				return;
		}

		writer.WriteNullValue();
	}
}