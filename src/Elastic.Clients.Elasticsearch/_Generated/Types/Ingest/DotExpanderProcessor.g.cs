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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class DotExpanderProcessor
{
	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>
	/// The field to expand into an object field.
	/// If set to <c>*</c>, all top-level fields will be expanded.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>
	/// Controls the behavior when there is already an existing nested object that conflicts with the expanded field.
	/// When <c>false</c>, the processor will merge conflicts by combining the old and the new values into an array.
	/// When <c>true</c>, the value from the expanded field will overwrite the existing value.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("override")]
	public bool? Override { get; set; }

	/// <summary>
	/// <para>
	/// The field that contains the field to expand.
	/// Only required if the field to expand is part another object field, because the <c>field</c> option can only understand leaf fields.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("path")]
	public string? Path { get; set; }

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Ingest.Processor(DotExpanderProcessor dotExpanderProcessor) => Elastic.Clients.Elasticsearch.Ingest.Processor.DotExpander(dotExpanderProcessor);
}

public sealed partial class DotExpanderProcessorDescriptor<TDocument> : SerializableDescriptor<DotExpanderProcessorDescriptor<TDocument>>
{
	internal DotExpanderProcessorDescriptor(Action<DotExpanderProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DotExpanderProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private bool? OverrideValue { get; set; }
	private string? PathValue { get; set; }
	private string? TagValue { get; set; }

	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to expand into an object field.
	/// If set to <c>*</c>, all top-level fields will be expanded.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to expand into an object field.
	/// If set to <c>*</c>, all top-level fields will be expanded.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to expand into an object field.
	/// If set to <c>*</c>, all top-level fields will be expanded.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor<TDocument> If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public DotExpanderProcessorDescriptor<TDocument> OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public DotExpanderProcessorDescriptor<TDocument> OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public DotExpanderProcessorDescriptor<TDocument> OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Controls the behavior when there is already an existing nested object that conflicts with the expanded field.
	/// When <c>false</c>, the processor will merge conflicts by combining the old and the new values into an array.
	/// When <c>true</c>, the value from the expanded field will overwrite the existing value.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor<TDocument> Override(bool? value = true)
	{
		OverrideValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field that contains the field to expand.
	/// Only required if the field to expand is part another object field, because the <c>field</c> option can only understand leaf fields.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor<TDocument> Path(string? path)
	{
		PathValue = path;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
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

		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (OverrideValue.HasValue)
		{
			writer.WritePropertyName("override");
			writer.WriteBooleanValue(OverrideValue.Value);
		}

		if (!string.IsNullOrEmpty(PathValue))
		{
			writer.WritePropertyName("path");
			writer.WriteStringValue(PathValue);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DotExpanderProcessorDescriptor : SerializableDescriptor<DotExpanderProcessorDescriptor>
{
	internal DotExpanderProcessorDescriptor(Action<DotExpanderProcessorDescriptor> configure) => configure.Invoke(this);

	public DotExpanderProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private bool? OverrideValue { get; set; }
	private string? PathValue { get; set; }
	private string? TagValue { get; set; }

	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to expand into an object field.
	/// If set to <c>*</c>, all top-level fields will be expanded.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to expand into an object field.
	/// If set to <c>*</c>, all top-level fields will be expanded.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to expand into an object field.
	/// If set to <c>*</c>, all top-level fields will be expanded.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public DotExpanderProcessorDescriptor OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public DotExpanderProcessorDescriptor OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public DotExpanderProcessorDescriptor OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Controls the behavior when there is already an existing nested object that conflicts with the expanded field.
	/// When <c>false</c>, the processor will merge conflicts by combining the old and the new values into an array.
	/// When <c>true</c>, the value from the expanded field will overwrite the existing value.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor Override(bool? value = true)
	{
		OverrideValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field that contains the field to expand.
	/// Only required if the field to expand is part another object field, because the <c>field</c> option can only understand leaf fields.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor Path(string? path)
	{
		PathValue = path;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	public DotExpanderProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
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

		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (OverrideValue.HasValue)
		{
			writer.WritePropertyName("override");
			writer.WriteBooleanValue(OverrideValue.Value);
		}

		if (!string.IsNullOrEmpty(PathValue))
		{
			writer.WritePropertyName("path");
			writer.WriteStringValue(PathValue);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		writer.WriteEndObject();
	}
}