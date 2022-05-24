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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class UaxEmailUrlTokenizer : TokenizerBase, ITokenizerDefinition
	{
		[JsonInclude]
		[JsonPropertyName("max_token_length")]
		public int? MaxTokenLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "uax_url_email";
	}

	public sealed partial class UaxEmailUrlTokenizerDescriptor : SerializableDescriptorBase<UaxEmailUrlTokenizerDescriptor>, IBuildableDescriptor<UaxEmailUrlTokenizer>
	{
		internal UaxEmailUrlTokenizerDescriptor(Action<UaxEmailUrlTokenizerDescriptor> configure) => configure.Invoke(this);
		public UaxEmailUrlTokenizerDescriptor() : base()
		{
		}

		private int? MaxTokenLengthValue { get; set; }

		private string? VersionValue { get; set; }

		public UaxEmailUrlTokenizerDescriptor MaxTokenLength(int? maxTokenLength)
		{
			MaxTokenLengthValue = maxTokenLength;
			return Self;
		}

		public UaxEmailUrlTokenizerDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MaxTokenLengthValue.HasValue)
			{
				writer.WritePropertyName("max_token_length");
				writer.WriteNumberValue(MaxTokenLengthValue.Value);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("uax_url_email");
			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		UaxEmailUrlTokenizer IBuildableDescriptor<UaxEmailUrlTokenizer>.Build() => new()
		{ MaxTokenLength = MaxTokenLengthValue, Version = VersionValue };
	}
}