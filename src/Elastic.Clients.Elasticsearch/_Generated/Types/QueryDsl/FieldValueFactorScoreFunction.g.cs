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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class FieldValueFactorScoreFunction : ScoreFunctionBase, IFunctionScoreContainerVariant
	{
		[JsonIgnore]
		string IFunctionScoreContainerVariant.FunctionScoreContainerVariantName => "field_value_factor";
		[JsonInclude]
		[JsonPropertyName("factor")]
		public double? Factor { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public double? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("modifier")]
		public Elastic.Clients.Elasticsearch.QueryDsl.FieldValueFactorModifier? Modifier { get; set; }
	}

	public sealed partial class FieldValueFactorScoreFunctionDescriptor<TDocument> : SerializableDescriptorBase<FieldValueFactorScoreFunctionDescriptor<TDocument>>
	{
		internal FieldValueFactorScoreFunctionDescriptor(Action<FieldValueFactorScoreFunctionDescriptor<TDocument>> configure) => configure.Invoke(this);
		public FieldValueFactorScoreFunctionDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

		private QueryContainerDescriptor<TDocument> FilterDescriptor { get; set; }

		private Action<QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; set; }

		private double? FactorValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private double? MissingValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.FieldValueFactorModifier? ModifierValue { get; set; }

		private double? WeightValue { get; set; }

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterValue = filter;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Filter(QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Filter(Action<QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Factor(double? factor)
		{
			FactorValue = factor;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Missing(double? missing)
		{
			MissingValue = missing;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Modifier(Elastic.Clients.Elasticsearch.QueryDsl.FieldValueFactorModifier? modifier)
		{
			ModifierValue = modifier;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Weight(double? weight)
		{
			WeightValue = weight;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (FactorValue.HasValue)
			{
				writer.WritePropertyName("factor");
				writer.WriteNumberValue(FactorValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (MissingValue.HasValue)
			{
				writer.WritePropertyName("missing");
				writer.WriteNumberValue(MissingValue.Value);
			}

			if (ModifierValue is not null)
			{
				writer.WritePropertyName("modifier");
				JsonSerializer.Serialize(writer, ModifierValue, options);
			}

			if (WeightValue.HasValue)
			{
				writer.WritePropertyName("weight");
				writer.WriteNumberValue(WeightValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class FieldValueFactorScoreFunctionDescriptor : SerializableDescriptorBase<FieldValueFactorScoreFunctionDescriptor>
	{
		internal FieldValueFactorScoreFunctionDescriptor(Action<FieldValueFactorScoreFunctionDescriptor> configure) => configure.Invoke(this);
		public FieldValueFactorScoreFunctionDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

		private QueryContainerDescriptor FilterDescriptor { get; set; }

		private Action<QueryContainerDescriptor> FilterDescriptorAction { get; set; }

		private double? FactorValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private double? MissingValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.FieldValueFactorModifier? ModifierValue { get; set; }

		private double? WeightValue { get; set; }

		public FieldValueFactorScoreFunctionDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterValue = filter;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor Filter(QueryContainerDescriptor descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor Filter(Action<QueryContainerDescriptor> configure)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor Factor(double? factor)
		{
			FactorValue = factor;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor Missing(double? missing)
		{
			MissingValue = missing;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor Modifier(Elastic.Clients.Elasticsearch.QueryDsl.FieldValueFactorModifier? modifier)
		{
			ModifierValue = modifier;
			return Self;
		}

		public FieldValueFactorScoreFunctionDescriptor Weight(double? weight)
		{
			WeightValue = weight;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (FactorValue.HasValue)
			{
				writer.WritePropertyName("factor");
				writer.WriteNumberValue(FactorValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (MissingValue.HasValue)
			{
				writer.WritePropertyName("missing");
				writer.WriteNumberValue(MissingValue.Value);
			}

			if (ModifierValue is not null)
			{
				writer.WritePropertyName("modifier");
				JsonSerializer.Serialize(writer, ModifierValue, options);
			}

			if (WeightValue.HasValue)
			{
				writer.WritePropertyName("weight");
				writer.WriteNumberValue(WeightValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}