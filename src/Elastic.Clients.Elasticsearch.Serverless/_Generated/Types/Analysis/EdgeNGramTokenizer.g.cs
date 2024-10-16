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

namespace Elastic.Clients.Elasticsearch.Serverless.Analysis;

public sealed partial class EdgeNGramTokenizer : ITokenizer
{
	[JsonInclude, JsonPropertyName("custom_token_chars")]
	public string? CustomTokenChars { get; set; }
	[JsonInclude, JsonPropertyName("max_gram")]
	public int? MaxGram { get; set; }
	[JsonInclude, JsonPropertyName("min_gram")]
	public int? MinGram { get; set; }
	[JsonInclude, JsonPropertyName("token_chars")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.TokenChar>? TokenChars { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "edge_ngram";

	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class EdgeNGramTokenizerDescriptor : SerializableDescriptor<EdgeNGramTokenizerDescriptor>, IBuildableDescriptor<EdgeNGramTokenizer>
{
	internal EdgeNGramTokenizerDescriptor(Action<EdgeNGramTokenizerDescriptor> configure) => configure.Invoke(this);

	public EdgeNGramTokenizerDescriptor() : base()
	{
	}

	private string? CustomTokenCharsValue { get; set; }
	private int? MaxGramValue { get; set; }
	private int? MinGramValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.TokenChar>? TokenCharsValue { get; set; }
	private string? VersionValue { get; set; }

	public EdgeNGramTokenizerDescriptor CustomTokenChars(string? customTokenChars)
	{
		CustomTokenCharsValue = customTokenChars;
		return Self;
	}

	public EdgeNGramTokenizerDescriptor MaxGram(int? maxGram)
	{
		MaxGramValue = maxGram;
		return Self;
	}

	public EdgeNGramTokenizerDescriptor MinGram(int? minGram)
	{
		MinGramValue = minGram;
		return Self;
	}

	public EdgeNGramTokenizerDescriptor TokenChars(ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.TokenChar>? tokenChars)
	{
		TokenCharsValue = tokenChars;
		return Self;
	}

	public EdgeNGramTokenizerDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(CustomTokenCharsValue))
		{
			writer.WritePropertyName("custom_token_chars");
			writer.WriteStringValue(CustomTokenCharsValue);
		}

		if (MaxGramValue.HasValue)
		{
			writer.WritePropertyName("max_gram");
			writer.WriteNumberValue(MaxGramValue.Value);
		}

		if (MinGramValue.HasValue)
		{
			writer.WritePropertyName("min_gram");
			writer.WriteNumberValue(MinGramValue.Value);
		}

		if (TokenCharsValue is not null)
		{
			writer.WritePropertyName("token_chars");
			JsonSerializer.Serialize(writer, TokenCharsValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("edge_ngram");
		if (!string.IsNullOrEmpty(VersionValue))
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(VersionValue);
		}

		writer.WriteEndObject();
	}

	EdgeNGramTokenizer IBuildableDescriptor<EdgeNGramTokenizer>.Build() => new()
	{
		CustomTokenChars = CustomTokenCharsValue,
		MaxGram = MaxGramValue,
		MinGram = MinGramValue,
		TokenChars = TokenCharsValue,
		Version = VersionValue
	};
}