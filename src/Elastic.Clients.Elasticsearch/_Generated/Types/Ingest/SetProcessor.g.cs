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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class SetProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "set";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("override")]
		public bool? Override { get; set; }

		[JsonInclude]
		[JsonPropertyName("value")]
		public object Value { get; set; }
	}

	public sealed partial class SetProcessorDescriptor<TDocument> : DescriptorBase<SetProcessorDescriptor<TDocument>>
	{
		public SetProcessorDescriptor()
		{
		}

		internal SetProcessorDescriptor(Action<SetProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Field FieldValue { get; private set; }

		internal bool? OverrideValue { get; private set; }

		internal object ValueValue { get; private set; }

		internal string? IfValue { get; private set; }

		internal bool? IgnoreFailureValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; private set; }

		internal string? TagValue { get; private set; }

		public SetProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field) => Assign(field, (a, v) => a.FieldValue = v);
		public SetProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public SetProcessorDescriptor<TDocument> Override(bool? overrideValue = true) => Assign(overrideValue, (a, v) => a.OverrideValue = v);
		public SetProcessorDescriptor<TDocument> Value(object value) => Assign(value, (a, v) => a.ValueValue = v);
		public SetProcessorDescriptor<TDocument> If(string? ifValue) => Assign(ifValue, (a, v) => a.IfValue = v);
		public SetProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true) => Assign(ignoreFailure, (a, v) => a.IgnoreFailureValue = v);
		public SetProcessorDescriptor<TDocument> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure) => Assign(onFailure, (a, v) => a.OnFailureValue = v);
		public SetProcessorDescriptor<TDocument> Tag(string? tag) => Assign(tag, (a, v) => a.TagValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (OverrideValue.HasValue)
			{
				writer.WritePropertyName("override");
				writer.WriteBooleanValue(OverrideValue.Value);
			}

			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WriteEndObject();
		}
	}
}