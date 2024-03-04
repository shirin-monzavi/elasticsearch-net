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

namespace Elastic.Clients.Elasticsearch.Serverless.Core.Search;

public sealed partial class FieldCollapse
{
	[JsonInclude, JsonPropertyName("collapse")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.FieldCollapse? Collapse { get; set; }

	/// <summary>
	/// <para>The field to collapse the result set on</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }

	/// <summary>
	/// <para>The number of inner hits and their sort order</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("inner_hits")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits))]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits>? InnerHits { get; set; }

	/// <summary>
	/// <para>The number of concurrent requests allowed to retrieve the inner_hits per group</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_concurrent_group_searches")]
	public int? MaxConcurrentGroupSearches { get; set; }
}

public sealed partial class FieldCollapseDescriptor<TDocument> : SerializableDescriptor<FieldCollapseDescriptor<TDocument>>
{
	internal FieldCollapseDescriptor(Action<FieldCollapseDescriptor<TDocument>> configure) => configure.Invoke(this);

	public FieldCollapseDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.FieldCollapse? CollapseValue { get; set; }
	private FieldCollapseDescriptor<TDocument> CollapseDescriptor { get; set; }
	private Action<FieldCollapseDescriptor<TDocument>> CollapseDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits>? InnerHitsValue { get; set; }
	private InnerHitsDescriptor<TDocument> InnerHitsDescriptor { get; set; }
	private Action<InnerHitsDescriptor<TDocument>> InnerHitsDescriptorAction { get; set; }
	private Action<InnerHitsDescriptor<TDocument>>[] InnerHitsDescriptorActions { get; set; }
	private int? MaxConcurrentGroupSearchesValue { get; set; }

	public FieldCollapseDescriptor<TDocument> Collapse(Elastic.Clients.Elasticsearch.Serverless.Core.Search.FieldCollapse? collapse)
	{
		CollapseDescriptor = null;
		CollapseDescriptorAction = null;
		CollapseValue = collapse;
		return Self;
	}

	public FieldCollapseDescriptor<TDocument> Collapse(FieldCollapseDescriptor<TDocument> descriptor)
	{
		CollapseValue = null;
		CollapseDescriptorAction = null;
		CollapseDescriptor = descriptor;
		return Self;
	}

	public FieldCollapseDescriptor<TDocument> Collapse(Action<FieldCollapseDescriptor<TDocument>> configure)
	{
		CollapseValue = null;
		CollapseDescriptor = null;
		CollapseDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The field to collapse the result set on</para>
	/// </summary>
	public FieldCollapseDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to collapse the result set on</para>
	/// </summary>
	public FieldCollapseDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The number of inner hits and their sort order</para>
	/// </summary>
	public FieldCollapseDescriptor<TDocument> InnerHits(ICollection<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits>? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptorActions = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public FieldCollapseDescriptor<TDocument> InnerHits(InnerHitsDescriptor<TDocument> descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptorActions = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public FieldCollapseDescriptor<TDocument> InnerHits(Action<InnerHitsDescriptor<TDocument>> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorActions = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	public FieldCollapseDescriptor<TDocument> InnerHits(params Action<InnerHitsDescriptor<TDocument>>[] configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>The number of concurrent requests allowed to retrieve the inner_hits per group</para>
	/// </summary>
	public FieldCollapseDescriptor<TDocument> MaxConcurrentGroupSearches(int? maxConcurrentGroupSearches)
	{
		MaxConcurrentGroupSearchesValue = maxConcurrentGroupSearches;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CollapseDescriptor is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseDescriptor, options);
		}
		else if (CollapseDescriptorAction is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, new FieldCollapseDescriptor<TDocument>(CollapseDescriptorAction), options);
		}
		else if (CollapseValue is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new InnerHitsDescriptor<TDocument>(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsDescriptorActions is not null)
		{
			writer.WritePropertyName("inner_hits");
			if (InnerHitsDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in InnerHitsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new InnerHitsDescriptor<TDocument>(action), options);
			}

			if (InnerHitsDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits>(InnerHitsValue, writer, options);
		}

		if (MaxConcurrentGroupSearchesValue.HasValue)
		{
			writer.WritePropertyName("max_concurrent_group_searches");
			writer.WriteNumberValue(MaxConcurrentGroupSearchesValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class FieldCollapseDescriptor : SerializableDescriptor<FieldCollapseDescriptor>
{
	internal FieldCollapseDescriptor(Action<FieldCollapseDescriptor> configure) => configure.Invoke(this);

	public FieldCollapseDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.FieldCollapse? CollapseValue { get; set; }
	private FieldCollapseDescriptor CollapseDescriptor { get; set; }
	private Action<FieldCollapseDescriptor> CollapseDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits>? InnerHitsValue { get; set; }
	private InnerHitsDescriptor InnerHitsDescriptor { get; set; }
	private Action<InnerHitsDescriptor> InnerHitsDescriptorAction { get; set; }
	private Action<InnerHitsDescriptor>[] InnerHitsDescriptorActions { get; set; }
	private int? MaxConcurrentGroupSearchesValue { get; set; }

	public FieldCollapseDescriptor Collapse(Elastic.Clients.Elasticsearch.Serverless.Core.Search.FieldCollapse? collapse)
	{
		CollapseDescriptor = null;
		CollapseDescriptorAction = null;
		CollapseValue = collapse;
		return Self;
	}

	public FieldCollapseDescriptor Collapse(FieldCollapseDescriptor descriptor)
	{
		CollapseValue = null;
		CollapseDescriptorAction = null;
		CollapseDescriptor = descriptor;
		return Self;
	}

	public FieldCollapseDescriptor Collapse(Action<FieldCollapseDescriptor> configure)
	{
		CollapseValue = null;
		CollapseDescriptor = null;
		CollapseDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The field to collapse the result set on</para>
	/// </summary>
	public FieldCollapseDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to collapse the result set on</para>
	/// </summary>
	public FieldCollapseDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to collapse the result set on</para>
	/// </summary>
	public FieldCollapseDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The number of inner hits and their sort order</para>
	/// </summary>
	public FieldCollapseDescriptor InnerHits(ICollection<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits>? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptorActions = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public FieldCollapseDescriptor InnerHits(InnerHitsDescriptor descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptorActions = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public FieldCollapseDescriptor InnerHits(Action<InnerHitsDescriptor> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorActions = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	public FieldCollapseDescriptor InnerHits(params Action<InnerHitsDescriptor>[] configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>The number of concurrent requests allowed to retrieve the inner_hits per group</para>
	/// </summary>
	public FieldCollapseDescriptor MaxConcurrentGroupSearches(int? maxConcurrentGroupSearches)
	{
		MaxConcurrentGroupSearchesValue = maxConcurrentGroupSearches;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CollapseDescriptor is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseDescriptor, options);
		}
		else if (CollapseDescriptorAction is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, new FieldCollapseDescriptor(CollapseDescriptorAction), options);
		}
		else if (CollapseValue is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new InnerHitsDescriptor(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsDescriptorActions is not null)
		{
			writer.WritePropertyName("inner_hits");
			if (InnerHitsDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in InnerHitsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new InnerHitsDescriptor(action), options);
			}

			if (InnerHitsDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits>(InnerHitsValue, writer, options);
		}

		if (MaxConcurrentGroupSearchesValue.HasValue)
		{
			writer.WritePropertyName("max_concurrent_group_searches");
			writer.WriteNumberValue(MaxConcurrentGroupSearchesValue.Value);
		}

		writer.WriteEndObject();
	}
}