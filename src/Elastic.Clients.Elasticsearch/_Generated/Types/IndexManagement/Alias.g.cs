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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class Alias
	{
		[JsonInclude]
		[JsonPropertyName("filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_routing")]
		public Elastic.Clients.Elasticsearch.Routing? IndexRouting { get; set; }

		[JsonInclude]
		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; set; }

		[JsonInclude]
		[JsonPropertyName("is_write_index")]
		public bool? IsWriteIndex { get; set; }

		[JsonInclude]
		[JsonPropertyName("routing")]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

		[JsonInclude]
		[JsonPropertyName("search_routing")]
		public Elastic.Clients.Elasticsearch.Routing? SearchRouting { get; set; }
	}

	public sealed partial class AliasDescriptor<TDocument> : DescriptorBase<AliasDescriptor<TDocument>>
	{
		public AliasDescriptor()
		{
		}

		internal AliasDescriptor(Action<AliasDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Routing? IndexRoutingValue { get; private set; }

		internal bool? IsHiddenValue { get; private set; }

		internal bool? IsWriteIndexValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Routing? SearchRoutingValue { get; private set; }

		internal QueryDsl.QueryContainerDescriptor<TDocument> FilterDescriptor { get; private set; }

		internal Action<QueryDsl.QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; private set; }

		public AliasDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			return Assign(filter, (a, v) => a.FilterValue = v);
		}

		public AliasDescriptor<TDocument> Filter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.FilterDescriptor = v);
		}

		public AliasDescriptor<TDocument> Filter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(configure, (a, v) => a.FilterDescriptorAction = v);
		}

		public AliasDescriptor<TDocument> IndexRouting(Elastic.Clients.Elasticsearch.Routing? indexRouting) => Assign(indexRouting, (a, v) => a.IndexRoutingValue = v);
		public AliasDescriptor<TDocument> IsHidden(bool? isHidden = true) => Assign(isHidden, (a, v) => a.IsHiddenValue = v);
		public AliasDescriptor<TDocument> IsWriteIndex(bool? isWriteIndex = true) => Assign(isWriteIndex, (a, v) => a.IsWriteIndexValue = v);
		public AliasDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Assign(routing, (a, v) => a.RoutingValue = v);
		public AliasDescriptor<TDocument> SearchRouting(Elastic.Clients.Elasticsearch.Routing? searchRouting) => Assign(searchRouting, (a, v) => a.SearchRoutingValue = v);
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
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (IndexRoutingValue is not null)
			{
				writer.WritePropertyName("index_routing");
				JsonSerializer.Serialize(writer, IndexRoutingValue, options);
			}

			if (IsHiddenValue.HasValue)
			{
				writer.WritePropertyName("is_hidden");
				writer.WriteBooleanValue(IsHiddenValue.Value);
			}

			if (IsWriteIndexValue.HasValue)
			{
				writer.WritePropertyName("is_write_index");
				writer.WriteBooleanValue(IsWriteIndexValue.Value);
			}

			if (RoutingValue is not null)
			{
				writer.WritePropertyName("routing");
				JsonSerializer.Serialize(writer, RoutingValue, options);
			}

			if (SearchRoutingValue is not null)
			{
				writer.WritePropertyName("search_routing");
				JsonSerializer.Serialize(writer, SearchRoutingValue, options);
			}

			writer.WriteEndObject();
		}
	}
}