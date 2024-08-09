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

internal sealed partial class NodeInfoDiscoverConverter : JsonConverter<NodeInfoDiscover>
{
	public override NodeInfoDiscover Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		IReadOnlyCollection<string>? seedHosts = default;
		IReadOnlyCollection<string>? seedProviders = default;
		string? type = default;
		Dictionary<string, object> additionalProperties = null;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "seed_hosts")
				{
					seedHosts = JsonSerializer.Deserialize<IReadOnlyCollection<string>?>(ref reader, options);
					continue;
				}

				if (property == "seed_providers")
				{
					seedProviders = JsonSerializer.Deserialize<IReadOnlyCollection<string>?>(ref reader, options);
					continue;
				}

				if (property == "type")
				{
					type = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				additionalProperties ??= new Dictionary<string, object>();
				var additionalValue = JsonSerializer.Deserialize<object>(ref reader, options);
				additionalProperties.Add(property, additionalValue);
			}
		}

		return new NodeInfoDiscover { SeedHosts = seedHosts, SeedProviders = seedProviders, Settings = additionalProperties, Type = type };
	}

	public override void Write(Utf8JsonWriter writer, NodeInfoDiscover value, JsonSerializerOptions options)
	{
		throw new NotImplementedException("'NodeInfoDiscover' is a readonly type, used only on responses and does not support being written to JSON.");
	}
}

[JsonConverter(typeof(NodeInfoDiscoverConverter))]
public sealed partial class NodeInfoDiscover
{
	public IReadOnlyCollection<string>? SeedHosts { get; init; }
	public IReadOnlyCollection<string>? SeedProviders { get; init; }

	/// <summary>
	/// <para>
	/// Additional or alternative settings
	/// </para>
	/// </summary>
	public IReadOnlyDictionary<string, object> Settings { get; init; }
	public string? Type { get; init; }
}