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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class DataStreamVisibility
{
	[JsonInclude, JsonPropertyName("allow_custom_routing")]
	public bool? AllowCustomRouting { get; set; }
	[JsonInclude, JsonPropertyName("hidden")]
	public bool? Hidden { get; set; }
}

public sealed partial class DataStreamVisibilityDescriptor : SerializableDescriptor<DataStreamVisibilityDescriptor>
{
	internal DataStreamVisibilityDescriptor(Action<DataStreamVisibilityDescriptor> configure) => configure.Invoke(this);

	public DataStreamVisibilityDescriptor() : base()
	{
	}

	private bool? AllowCustomRoutingValue { get; set; }
	private bool? HiddenValue { get; set; }

	public DataStreamVisibilityDescriptor AllowCustomRouting(bool? allowCustomRouting = true)
	{
		AllowCustomRoutingValue = allowCustomRouting;
		return Self;
	}

	public DataStreamVisibilityDescriptor Hidden(bool? hidden = true)
	{
		HiddenValue = hidden;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowCustomRoutingValue.HasValue)
		{
			writer.WritePropertyName("allow_custom_routing");
			writer.WriteBooleanValue(AllowCustomRoutingValue.Value);
		}

		if (HiddenValue.HasValue)
		{
			writer.WritePropertyName("hidden");
			writer.WriteBooleanValue(HiddenValue.Value);
		}

		writer.WriteEndObject();
	}
}