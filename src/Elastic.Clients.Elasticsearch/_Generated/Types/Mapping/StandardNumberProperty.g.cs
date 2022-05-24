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
namespace Elastic.Clients.Elasticsearch.Mapping
{
	public partial class StandardNumberProperty : NumberPropertyBase
	{
		[JsonInclude]
		[JsonPropertyName("coerce")]
		public bool? Coerce { get; set; }

		[JsonInclude]
		[JsonPropertyName("on_script_error")]
		public Elastic.Clients.Elasticsearch.Mapping.OnScriptError? OnScriptError { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public ScriptBase? Script { get; set; }
	}

	public sealed partial class StandardNumberPropertyDescriptor<TDocument> : SerializableDescriptorBase<StandardNumberPropertyDescriptor<TDocument>>
	{
		internal StandardNumberPropertyDescriptor(Action<StandardNumberPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);
		public StandardNumberPropertyDescriptor() : base()
		{
		}

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private bool? CoerceValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

		private bool? DocValuesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private bool? IgnoreMalformedValue { get; set; }

		private bool? IndexValue { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.OnScriptError? OnScriptErrorValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private string? SimilarityValue { get; set; }

		private bool? StoreValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? TimeSeriesMetricValue { get; set; }

		public StandardNumberPropertyDescriptor<TDocument> Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptor = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Coerce(bool? coerce = true)
		{
			CoerceValue = coerce;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> CopyTo<TValue>(Expression<Func<TDocument, TValue>> copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> DocValues(bool? docValues = true)
		{
			DocValuesValue = docValues;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Fields(PropertiesDescriptor<TDocument> descriptor)
		{
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Fields(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> IgnoreMalformed(bool? ignoreMalformed = true)
		{
			IgnoreMalformedValue = ignoreMalformed;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Index(bool? index = true)
		{
			IndexValue = index;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> OnScriptError(Elastic.Clients.Elasticsearch.Mapping.OnScriptError? onScriptError)
		{
			OnScriptErrorValue = onScriptError;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Properties(PropertiesDescriptor<TDocument> descriptor)
		{
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Properties(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Similarity(string? similarity)
		{
			SimilarityValue = similarity;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> Store(bool? store = true)
		{
			StoreValue = store;
			return Self;
		}

		public StandardNumberPropertyDescriptor<TDocument> TimeSeriesMetric(Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? timeSeriesMetric)
		{
			TimeSeriesMetricValue = timeSeriesMetric;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (CoerceValue.HasValue)
			{
				writer.WritePropertyName("coerce");
				writer.WriteBooleanValue(CoerceValue.Value);
			}

			if (CopyToValue is not null)
			{
				writer.WritePropertyName("copy_to");
				JsonSerializer.Serialize(writer, CopyToValue, options);
			}

			if (DocValuesValue.HasValue)
			{
				writer.WritePropertyName("doc_values");
				writer.WriteBooleanValue(DocValuesValue.Value);
			}

			if (DynamicValue is not null)
			{
				writer.WritePropertyName("dynamic");
				JsonSerializer.Serialize(writer, DynamicValue, options);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (IgnoreAboveValue.HasValue)
			{
				writer.WritePropertyName("ignore_above");
				writer.WriteNumberValue(IgnoreAboveValue.Value);
			}

			if (IgnoreMalformedValue.HasValue)
			{
				writer.WritePropertyName("ignore_malformed");
				writer.WriteBooleanValue(IgnoreMalformedValue.Value);
			}

			if (IndexValue.HasValue)
			{
				writer.WritePropertyName("index");
				writer.WriteBooleanValue(IndexValue.Value);
			}

			if (LocalMetadataValue is not null)
			{
				writer.WritePropertyName("local_metadata");
				JsonSerializer.Serialize(writer, LocalMetadataValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (OnScriptErrorValue is not null)
			{
				writer.WritePropertyName("on_script_error");
				JsonSerializer.Serialize(writer, OnScriptErrorValue, options);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (!string.IsNullOrEmpty(SimilarityValue))
			{
				writer.WritePropertyName("similarity");
				writer.WriteStringValue(SimilarityValue);
			}

			if (StoreValue.HasValue)
			{
				writer.WritePropertyName("store");
				writer.WriteBooleanValue(StoreValue.Value);
			}

			if (TimeSeriesMetricValue is not null)
			{
				writer.WritePropertyName("time_series_metric");
				JsonSerializer.Serialize(writer, TimeSeriesMetricValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class StandardNumberPropertyDescriptor : SerializableDescriptorBase<StandardNumberPropertyDescriptor>
	{
		internal StandardNumberPropertyDescriptor(Action<StandardNumberPropertyDescriptor> configure) => configure.Invoke(this);
		public StandardNumberPropertyDescriptor() : base()
		{
		}

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private bool? CoerceValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

		private bool? DocValuesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private bool? IgnoreMalformedValue { get; set; }

		private bool? IndexValue { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.OnScriptError? OnScriptErrorValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private string? SimilarityValue { get; set; }

		private bool? StoreValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? TimeSeriesMetricValue { get; set; }

		public StandardNumberPropertyDescriptor Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public StandardNumberPropertyDescriptor Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public StandardNumberPropertyDescriptor Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptor = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public StandardNumberPropertyDescriptor Coerce(bool? coerce = true)
		{
			CoerceValue = coerce;
			return Self;
		}

		public StandardNumberPropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public StandardNumberPropertyDescriptor CopyTo<TDocument, TValue>(Expression<Func<TDocument, TValue>> copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public StandardNumberPropertyDescriptor CopyTo<TDocument>(Expression<Func<TDocument, object>> copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public StandardNumberPropertyDescriptor DocValues(bool? docValues = true)
		{
			DocValuesValue = docValues;
			return Self;
		}

		public StandardNumberPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public StandardNumberPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public StandardNumberPropertyDescriptor Fields<TDocument>(PropertiesDescriptor<TDocument> descriptor)
		{
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public StandardNumberPropertyDescriptor Fields<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public StandardNumberPropertyDescriptor IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public StandardNumberPropertyDescriptor IgnoreMalformed(bool? ignoreMalformed = true)
		{
			IgnoreMalformedValue = ignoreMalformed;
			return Self;
		}

		public StandardNumberPropertyDescriptor Index(bool? index = true)
		{
			IndexValue = index;
			return Self;
		}

		public StandardNumberPropertyDescriptor LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public StandardNumberPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public StandardNumberPropertyDescriptor OnScriptError(Elastic.Clients.Elasticsearch.Mapping.OnScriptError? onScriptError)
		{
			OnScriptErrorValue = onScriptError;
			return Self;
		}

		public StandardNumberPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public StandardNumberPropertyDescriptor Properties<TDocument>(PropertiesDescriptor<TDocument> descriptor)
		{
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public StandardNumberPropertyDescriptor Properties<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public StandardNumberPropertyDescriptor Similarity(string? similarity)
		{
			SimilarityValue = similarity;
			return Self;
		}

		public StandardNumberPropertyDescriptor Store(bool? store = true)
		{
			StoreValue = store;
			return Self;
		}

		public StandardNumberPropertyDescriptor TimeSeriesMetric(Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? timeSeriesMetric)
		{
			TimeSeriesMetricValue = timeSeriesMetric;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (CoerceValue.HasValue)
			{
				writer.WritePropertyName("coerce");
				writer.WriteBooleanValue(CoerceValue.Value);
			}

			if (CopyToValue is not null)
			{
				writer.WritePropertyName("copy_to");
				JsonSerializer.Serialize(writer, CopyToValue, options);
			}

			if (DocValuesValue.HasValue)
			{
				writer.WritePropertyName("doc_values");
				writer.WriteBooleanValue(DocValuesValue.Value);
			}

			if (DynamicValue is not null)
			{
				writer.WritePropertyName("dynamic");
				JsonSerializer.Serialize(writer, DynamicValue, options);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (IgnoreAboveValue.HasValue)
			{
				writer.WritePropertyName("ignore_above");
				writer.WriteNumberValue(IgnoreAboveValue.Value);
			}

			if (IgnoreMalformedValue.HasValue)
			{
				writer.WritePropertyName("ignore_malformed");
				writer.WriteBooleanValue(IgnoreMalformedValue.Value);
			}

			if (IndexValue.HasValue)
			{
				writer.WritePropertyName("index");
				writer.WriteBooleanValue(IndexValue.Value);
			}

			if (LocalMetadataValue is not null)
			{
				writer.WritePropertyName("local_metadata");
				JsonSerializer.Serialize(writer, LocalMetadataValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (OnScriptErrorValue is not null)
			{
				writer.WritePropertyName("on_script_error");
				JsonSerializer.Serialize(writer, OnScriptErrorValue, options);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (!string.IsNullOrEmpty(SimilarityValue))
			{
				writer.WritePropertyName("similarity");
				writer.WriteStringValue(SimilarityValue);
			}

			if (StoreValue.HasValue)
			{
				writer.WritePropertyName("store");
				writer.WriteBooleanValue(StoreValue.Value);
			}

			if (TimeSeriesMetricValue is not null)
			{
				writer.WritePropertyName("time_series_metric");
				JsonSerializer.Serialize(writer, TimeSeriesMetricValue, options);
			}

			writer.WriteEndObject();
		}
	}
}