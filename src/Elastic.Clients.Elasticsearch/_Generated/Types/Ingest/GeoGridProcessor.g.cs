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

public sealed partial class GeoGridProcessor
{
	/// <summary>
	/// <para>
	/// If specified and children tiles exist, save those tile addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("children_field")]
	public Elastic.Clients.Elasticsearch.Field? ChildrenField { get; set; }

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
	/// The field to interpret as a geo-tile.=
	/// The field format is determined by the <c>tile_type</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public string Field { get; set; }

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
	/// If <c>true</c> and <c>field</c> does not exist, the processor quietly exits without modifying the document.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_missing")]
	public bool? IgnoreMissing { get; set; }

	/// <summary>
	/// <para>
	/// If specified and intersecting non-child tiles exist, save their addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("non_children_field")]
	public Elastic.Clients.Elasticsearch.Field? NonChildrenField { get; set; }

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>
	/// If specified and a parent tile exists, save that tile address to this field.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("parent_field")]
	public Elastic.Clients.Elasticsearch.Field? ParentField { get; set; }

	/// <summary>
	/// <para>
	/// If specified, save the tile precision (zoom) as an integer to this field.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("precision_field")]
	public Elastic.Clients.Elasticsearch.Field? PrecisionField { get; set; }

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// <para>
	/// The field to assign the polygon shape to, by default, the <c>field</c> is updated in-place.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }

	/// <summary>
	/// <para>
	/// Which format to save the generated polygon in.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_format")]
	public Elastic.Clients.Elasticsearch.Ingest.GeoGridTargetFormat? TargetFormat { get; set; }

	/// <summary>
	/// <para>
	/// Three tile formats are understood: geohash, geotile and geohex.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tile_type")]
	public Elastic.Clients.Elasticsearch.Ingest.GeoGridTileType TileType { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Ingest.Processor(GeoGridProcessor geoGridProcessor) => Elastic.Clients.Elasticsearch.Ingest.Processor.GeoGrid(geoGridProcessor);
}

public sealed partial class GeoGridProcessorDescriptor<TDocument> : SerializableDescriptor<GeoGridProcessorDescriptor<TDocument>>
{
	internal GeoGridProcessorDescriptor(Action<GeoGridProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoGridProcessorDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? ChildrenFieldValue { get; set; }
	private string? DescriptionValue { get; set; }
	private string FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? NonChildrenFieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Field? ParentFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? PrecisionFieldValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.GeoGridTargetFormat? TargetFormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.GeoGridTileType TileTypeValue { get; set; }

	/// <summary>
	/// <para>
	/// If specified and children tiles exist, save those tile addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> ChildrenField(Elastic.Clients.Elasticsearch.Field? childrenField)
	{
		ChildrenFieldValue = childrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and children tiles exist, save those tile addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> ChildrenField<TValue>(Expression<Func<TDocument, TValue>> childrenField)
	{
		ChildrenFieldValue = childrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and children tiles exist, save those tile addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> ChildrenField(Expression<Func<TDocument, object>> childrenField)
	{
		ChildrenFieldValue = childrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to interpret as a geo-tile.=
	/// The field format is determined by the <c>tile_type</c>.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> Field(string field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c> and <c>field</c> does not exist, the processor quietly exits without modifying the document.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and intersecting non-child tiles exist, save their addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> NonChildrenField(Elastic.Clients.Elasticsearch.Field? nonChildrenField)
	{
		NonChildrenFieldValue = nonChildrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and intersecting non-child tiles exist, save their addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> NonChildrenField<TValue>(Expression<Func<TDocument, TValue>> nonChildrenField)
	{
		NonChildrenFieldValue = nonChildrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and intersecting non-child tiles exist, save their addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> NonChildrenField(Expression<Func<TDocument, object>> nonChildrenField)
	{
		NonChildrenFieldValue = nonChildrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public GeoGridProcessorDescriptor<TDocument> OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public GeoGridProcessorDescriptor<TDocument> OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public GeoGridProcessorDescriptor<TDocument> OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and a parent tile exists, save that tile address to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> ParentField(Elastic.Clients.Elasticsearch.Field? parentField)
	{
		ParentFieldValue = parentField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and a parent tile exists, save that tile address to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> ParentField<TValue>(Expression<Func<TDocument, TValue>> parentField)
	{
		ParentFieldValue = parentField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and a parent tile exists, save that tile address to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> ParentField(Expression<Func<TDocument, object>> parentField)
	{
		ParentFieldValue = parentField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified, save the tile precision (zoom) as an integer to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> PrecisionField(Elastic.Clients.Elasticsearch.Field? precisionField)
	{
		PrecisionFieldValue = precisionField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified, save the tile precision (zoom) as an integer to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> PrecisionField<TValue>(Expression<Func<TDocument, TValue>> precisionField)
	{
		PrecisionFieldValue = precisionField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified, save the tile precision (zoom) as an integer to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> PrecisionField(Expression<Func<TDocument, object>> precisionField)
	{
		PrecisionFieldValue = precisionField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to assign the polygon shape to, by default, the <c>field</c> is updated in-place.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to assign the polygon shape to, by default, the <c>field</c> is updated in-place.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to assign the polygon shape to, by default, the <c>field</c> is updated in-place.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> TargetField(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Which format to save the generated polygon in.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> TargetFormat(Elastic.Clients.Elasticsearch.Ingest.GeoGridTargetFormat? targetFormat)
	{
		TargetFormatValue = targetFormat;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Three tile formats are understood: geohash, geotile and geohex.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor<TDocument> TileType(Elastic.Clients.Elasticsearch.Ingest.GeoGridTileType tileType)
	{
		TileTypeValue = tileType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ChildrenFieldValue is not null)
		{
			writer.WritePropertyName("children_field");
			JsonSerializer.Serialize(writer, ChildrenFieldValue, options);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		writer.WriteStringValue(FieldValue);
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

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
		}

		if (NonChildrenFieldValue is not null)
		{
			writer.WritePropertyName("non_children_field");
			JsonSerializer.Serialize(writer, NonChildrenFieldValue, options);
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

		if (ParentFieldValue is not null)
		{
			writer.WritePropertyName("parent_field");
			JsonSerializer.Serialize(writer, ParentFieldValue, options);
		}

		if (PrecisionFieldValue is not null)
		{
			writer.WritePropertyName("precision_field");
			JsonSerializer.Serialize(writer, PrecisionFieldValue, options);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		if (TargetFormatValue is not null)
		{
			writer.WritePropertyName("target_format");
			JsonSerializer.Serialize(writer, TargetFormatValue, options);
		}

		writer.WritePropertyName("tile_type");
		JsonSerializer.Serialize(writer, TileTypeValue, options);
		writer.WriteEndObject();
	}
}

public sealed partial class GeoGridProcessorDescriptor : SerializableDescriptor<GeoGridProcessorDescriptor>
{
	internal GeoGridProcessorDescriptor(Action<GeoGridProcessorDescriptor> configure) => configure.Invoke(this);

	public GeoGridProcessorDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? ChildrenFieldValue { get; set; }
	private string? DescriptionValue { get; set; }
	private string FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? NonChildrenFieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Field? ParentFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? PrecisionFieldValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.GeoGridTargetFormat? TargetFormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.GeoGridTileType TileTypeValue { get; set; }

	/// <summary>
	/// <para>
	/// If specified and children tiles exist, save those tile addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor ChildrenField(Elastic.Clients.Elasticsearch.Field? childrenField)
	{
		ChildrenFieldValue = childrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and children tiles exist, save those tile addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor ChildrenField<TDocument, TValue>(Expression<Func<TDocument, TValue>> childrenField)
	{
		ChildrenFieldValue = childrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and children tiles exist, save those tile addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor ChildrenField<TDocument>(Expression<Func<TDocument, object>> childrenField)
	{
		ChildrenFieldValue = childrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to interpret as a geo-tile.=
	/// The field format is determined by the <c>tile_type</c>.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor Field(string field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c> and <c>field</c> does not exist, the processor quietly exits without modifying the document.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and intersecting non-child tiles exist, save their addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor NonChildrenField(Elastic.Clients.Elasticsearch.Field? nonChildrenField)
	{
		NonChildrenFieldValue = nonChildrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and intersecting non-child tiles exist, save their addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor NonChildrenField<TDocument, TValue>(Expression<Func<TDocument, TValue>> nonChildrenField)
	{
		NonChildrenFieldValue = nonChildrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and intersecting non-child tiles exist, save their addresses to this field as an array of strings.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor NonChildrenField<TDocument>(Expression<Func<TDocument, object>> nonChildrenField)
	{
		NonChildrenFieldValue = nonChildrenField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public GeoGridProcessorDescriptor OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public GeoGridProcessorDescriptor OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public GeoGridProcessorDescriptor OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and a parent tile exists, save that tile address to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor ParentField(Elastic.Clients.Elasticsearch.Field? parentField)
	{
		ParentFieldValue = parentField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and a parent tile exists, save that tile address to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor ParentField<TDocument, TValue>(Expression<Func<TDocument, TValue>> parentField)
	{
		ParentFieldValue = parentField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified and a parent tile exists, save that tile address to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor ParentField<TDocument>(Expression<Func<TDocument, object>> parentField)
	{
		ParentFieldValue = parentField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified, save the tile precision (zoom) as an integer to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor PrecisionField(Elastic.Clients.Elasticsearch.Field? precisionField)
	{
		PrecisionFieldValue = precisionField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified, save the tile precision (zoom) as an integer to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor PrecisionField<TDocument, TValue>(Expression<Func<TDocument, TValue>> precisionField)
	{
		PrecisionFieldValue = precisionField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If specified, save the tile precision (zoom) as an integer to this field.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor PrecisionField<TDocument>(Expression<Func<TDocument, object>> precisionField)
	{
		PrecisionFieldValue = precisionField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to assign the polygon shape to, by default, the <c>field</c> is updated in-place.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to assign the polygon shape to, by default, the <c>field</c> is updated in-place.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field to assign the polygon shape to, by default, the <c>field</c> is updated in-place.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Which format to save the generated polygon in.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor TargetFormat(Elastic.Clients.Elasticsearch.Ingest.GeoGridTargetFormat? targetFormat)
	{
		TargetFormatValue = targetFormat;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Three tile formats are understood: geohash, geotile and geohex.
	/// </para>
	/// </summary>
	public GeoGridProcessorDescriptor TileType(Elastic.Clients.Elasticsearch.Ingest.GeoGridTileType tileType)
	{
		TileTypeValue = tileType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ChildrenFieldValue is not null)
		{
			writer.WritePropertyName("children_field");
			JsonSerializer.Serialize(writer, ChildrenFieldValue, options);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		writer.WriteStringValue(FieldValue);
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

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
		}

		if (NonChildrenFieldValue is not null)
		{
			writer.WritePropertyName("non_children_field");
			JsonSerializer.Serialize(writer, NonChildrenFieldValue, options);
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

		if (ParentFieldValue is not null)
		{
			writer.WritePropertyName("parent_field");
			JsonSerializer.Serialize(writer, ParentFieldValue, options);
		}

		if (PrecisionFieldValue is not null)
		{
			writer.WritePropertyName("precision_field");
			JsonSerializer.Serialize(writer, PrecisionFieldValue, options);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		if (TargetFormatValue is not null)
		{
			writer.WritePropertyName("target_format");
			JsonSerializer.Serialize(writer, TargetFormatValue, options);
		}

		writer.WritePropertyName("tile_type");
		JsonSerializer.Serialize(writer, TileTypeValue, options);
		writer.WriteEndObject();
	}
}