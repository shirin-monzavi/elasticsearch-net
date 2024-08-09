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

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

internal sealed partial class FrequentItemSetsBucketConverter : JsonConverter<FrequentItemSetsBucket>
{
	public override FrequentItemSetsBucket Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		long docCount = default;
		IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, IReadOnlyCollection<string>> key = default;
		double support = default;
		Dictionary<string, Elastic.Clients.Elasticsearch.Serverless.Aggregations.IAggregate> additionalProperties = null;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "doc_count")
				{
					docCount = JsonSerializer.Deserialize<long>(ref reader, options);
					continue;
				}

				if (property == "key")
				{
					key = JsonSerializer.Deserialize<IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, IReadOnlyCollection<string>>>(ref reader, options);
					continue;
				}

				if (property == "support")
				{
					support = JsonSerializer.Deserialize<double>(ref reader, options);
					continue;
				}

				if (property.Contains("#"))
				{
					additionalProperties ??= new Dictionary<string, Elastic.Clients.Elasticsearch.Serverless.Aggregations.IAggregate>();
					AggregateDictionaryConverter.ReadItem(ref reader, options, additionalProperties, property);
					continue;
				}

				throw new JsonException("Unknown property read from JSON.");
			}
		}

		return new FrequentItemSetsBucket { Aggregations = new Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregateDictionary(additionalProperties), DocCount = docCount, Key = key, Support = support };
	}

	public override void Write(Utf8JsonWriter writer, FrequentItemSetsBucket value, JsonSerializerOptions options)
	{
		throw new NotImplementedException("'FrequentItemSetsBucket' is a readonly type, used only on responses and does not support being written to JSON.");
	}
}

[JsonConverter(typeof(FrequentItemSetsBucketConverter))]
public sealed partial class FrequentItemSetsBucket
{
	/// <summary>
	/// <para>
	/// Nested aggregations
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregateDictionary Aggregations { get; init; }
	public long DocCount { get; init; }
	public IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, IReadOnlyCollection<string>> Key { get; init; }
	public double Support { get; init; }
}