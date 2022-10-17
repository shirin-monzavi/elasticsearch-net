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
namespace Elastic.Clients.Elasticsearch.QueryDsl;
public sealed partial class IntervalsAnyOf
{
	[JsonInclude]
	[JsonPropertyName("filter")]
	public Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFilter? Filter { get; set; }

	[JsonInclude]
	[JsonPropertyName("intervals")]
	public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsContainer> Intervals { get; set; }
}

public sealed partial class IntervalsAnyOfDescriptor<TDocument> : SerializableDescriptor<IntervalsAnyOfDescriptor<TDocument>>
{
	internal IntervalsAnyOfDescriptor(Action<IntervalsAnyOfDescriptor<TDocument>> configure) => configure.Invoke(this);
	public IntervalsAnyOfDescriptor() : base()
	{
	}

	private IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsContainer> IntervalsValue { get; set; }

	private IntervalsContainerDescriptor<TDocument> IntervalsDescriptor { get; set; }

	private Action<IntervalsContainerDescriptor<TDocument>> IntervalsDescriptorAction { get; set; }

	private Action<IntervalsContainerDescriptor<TDocument>>[] IntervalsDescriptorActions { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFilter? FilterValue { get; set; }

	private IntervalsFilterDescriptor FilterDescriptor { get; set; }

	private Action<IntervalsFilterDescriptor> FilterDescriptorAction { get; set; }

	public IntervalsAnyOfDescriptor<TDocument> Intervals(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsContainer> intervals)
	{
		IntervalsDescriptor = null;
		IntervalsDescriptorAction = null;
		IntervalsDescriptorActions = null;
		IntervalsValue = intervals;
		return Self;
	}

	public IntervalsAnyOfDescriptor<TDocument> Intervals(IntervalsContainerDescriptor<TDocument> descriptor)
	{
		IntervalsValue = null;
		IntervalsDescriptorAction = null;
		IntervalsDescriptorActions = null;
		IntervalsDescriptor = descriptor;
		return Self;
	}

	public IntervalsAnyOfDescriptor<TDocument> Intervals(Action<IntervalsContainerDescriptor<TDocument>> configure)
	{
		IntervalsValue = null;
		IntervalsDescriptor = null;
		IntervalsDescriptorActions = null;
		IntervalsDescriptorAction = configure;
		return Self;
	}

	public IntervalsAnyOfDescriptor<TDocument> Intervals(params Action<IntervalsContainerDescriptor<TDocument>>[] configure)
	{
		IntervalsValue = null;
		IntervalsDescriptor = null;
		IntervalsDescriptorAction = null;
		IntervalsDescriptorActions = configure;
		return Self;
	}

	public IntervalsAnyOfDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFilter? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public IntervalsAnyOfDescriptor<TDocument> Filter(IntervalsFilterDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public IntervalsAnyOfDescriptor<TDocument> Filter(Action<IntervalsFilterDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IntervalsDescriptor is not null)
		{
			writer.WritePropertyName("intervals");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, IntervalsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (IntervalsDescriptorAction is not null)
		{
			writer.WritePropertyName("intervals");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new IntervalsContainerDescriptor<TDocument>(IntervalsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (IntervalsDescriptorActions is not null)
		{
			writer.WritePropertyName("intervals");
			writer.WriteStartArray();
			foreach (var action in IntervalsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new IntervalsContainerDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("intervals");
			JsonSerializer.Serialize(writer, IntervalsValue, options);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new IntervalsFilterDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class IntervalsAnyOfDescriptor : SerializableDescriptor<IntervalsAnyOfDescriptor>
{
	internal IntervalsAnyOfDescriptor(Action<IntervalsAnyOfDescriptor> configure) => configure.Invoke(this);
	public IntervalsAnyOfDescriptor() : base()
	{
	}

	private IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsContainer> IntervalsValue { get; set; }

	private IntervalsContainerDescriptor IntervalsDescriptor { get; set; }

	private Action<IntervalsContainerDescriptor> IntervalsDescriptorAction { get; set; }

	private Action<IntervalsContainerDescriptor>[] IntervalsDescriptorActions { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFilter? FilterValue { get; set; }

	private IntervalsFilterDescriptor FilterDescriptor { get; set; }

	private Action<IntervalsFilterDescriptor> FilterDescriptorAction { get; set; }

	public IntervalsAnyOfDescriptor Intervals(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsContainer> intervals)
	{
		IntervalsDescriptor = null;
		IntervalsDescriptorAction = null;
		IntervalsDescriptorActions = null;
		IntervalsValue = intervals;
		return Self;
	}

	public IntervalsAnyOfDescriptor Intervals(IntervalsContainerDescriptor descriptor)
	{
		IntervalsValue = null;
		IntervalsDescriptorAction = null;
		IntervalsDescriptorActions = null;
		IntervalsDescriptor = descriptor;
		return Self;
	}

	public IntervalsAnyOfDescriptor Intervals(Action<IntervalsContainerDescriptor> configure)
	{
		IntervalsValue = null;
		IntervalsDescriptor = null;
		IntervalsDescriptorActions = null;
		IntervalsDescriptorAction = configure;
		return Self;
	}

	public IntervalsAnyOfDescriptor Intervals(params Action<IntervalsContainerDescriptor>[] configure)
	{
		IntervalsValue = null;
		IntervalsDescriptor = null;
		IntervalsDescriptorAction = null;
		IntervalsDescriptorActions = configure;
		return Self;
	}

	public IntervalsAnyOfDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFilter? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public IntervalsAnyOfDescriptor Filter(IntervalsFilterDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public IntervalsAnyOfDescriptor Filter(Action<IntervalsFilterDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IntervalsDescriptor is not null)
		{
			writer.WritePropertyName("intervals");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, IntervalsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (IntervalsDescriptorAction is not null)
		{
			writer.WritePropertyName("intervals");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new IntervalsContainerDescriptor(IntervalsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (IntervalsDescriptorActions is not null)
		{
			writer.WritePropertyName("intervals");
			writer.WriteStartArray();
			foreach (var action in IntervalsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new IntervalsContainerDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("intervals");
			JsonSerializer.Serialize(writer, IntervalsValue, options);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new IntervalsFilterDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		writer.WriteEndObject();
	}
}