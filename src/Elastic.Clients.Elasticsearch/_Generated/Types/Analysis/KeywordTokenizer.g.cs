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
namespace Elastic.Clients.Elasticsearch.Analysis;
public sealed partial class KeywordTokenizer : ITokenizer
{
	[JsonInclude]
	[JsonPropertyName("buffer_size")]
	public int BufferSize { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "keyword";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class KeywordTokenizerDescriptor : SerializableDescriptor<KeywordTokenizerDescriptor>, IBuildableDescriptor<KeywordTokenizer>
{
	internal KeywordTokenizerDescriptor(Action<KeywordTokenizerDescriptor> configure) => configure.Invoke(this);
	public KeywordTokenizerDescriptor() : base()
	{
	}

	private int BufferSizeValue { get; set; }

	private string? VersionValue { get; set; }

	public KeywordTokenizerDescriptor BufferSize(int bufferSize)
	{
		BufferSizeValue = bufferSize;
		return Self;
	}

	public KeywordTokenizerDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("buffer_size");
		writer.WriteNumberValue(BufferSizeValue);
		writer.WritePropertyName("type");
		writer.WriteStringValue("keyword");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	KeywordTokenizer IBuildableDescriptor<KeywordTokenizer>.Build() => new()
	{ BufferSize = BufferSizeValue, Version = VersionValue };
}