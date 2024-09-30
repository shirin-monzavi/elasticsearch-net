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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class CalendarEvent
{
	/// <summary>
	/// <para>
	/// A string that uniquely identifies a calendar.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("calendar_id")]
	public Elastic.Clients.Elasticsearch.Id? CalendarId { get; set; }

	/// <summary>
	/// <para>
	/// A description of the scheduled event.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// <para>
	/// The timestamp for the end of the scheduled event in milliseconds since the epoch or ISO 8601 format.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("end_time")]
	public DateTimeOffset EndTime { get; set; }
	[JsonInclude, JsonPropertyName("event_id")]
	public Elastic.Clients.Elasticsearch.Id? EventId { get; set; }

	/// <summary>
	/// <para>
	/// Shift time by this many seconds. For example adjust time for daylight savings changes
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("force_time_shift")]
	public int? ForceTimeShift { get; set; }

	/// <summary>
	/// <para>
	/// When true the model will not be updated for this calendar period.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("skip_model_update")]
	public bool? SkipModelUpdate { get; set; }

	/// <summary>
	/// <para>
	/// When true the model will not create results for this calendar period.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("skip_result")]
	public bool? SkipResult { get; set; }

	/// <summary>
	/// <para>
	/// The timestamp for the beginning of the scheduled event in milliseconds since the epoch or ISO 8601 format.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("start_time")]
	public DateTimeOffset StartTime { get; set; }
}

public sealed partial class CalendarEventDescriptor : SerializableDescriptor<CalendarEventDescriptor>
{
	internal CalendarEventDescriptor(Action<CalendarEventDescriptor> configure) => configure.Invoke(this);

	public CalendarEventDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Id? CalendarIdValue { get; set; }
	private string DescriptionValue { get; set; }
	private DateTimeOffset EndTimeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Id? EventIdValue { get; set; }
	private int? ForceTimeShiftValue { get; set; }
	private bool? SkipModelUpdateValue { get; set; }
	private bool? SkipResultValue { get; set; }
	private DateTimeOffset StartTimeValue { get; set; }

	/// <summary>
	/// <para>
	/// A string that uniquely identifies a calendar.
	/// </para>
	/// </summary>
	public CalendarEventDescriptor CalendarId(Elastic.Clients.Elasticsearch.Id? calendarId)
	{
		CalendarIdValue = calendarId;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A description of the scheduled event.
	/// </para>
	/// </summary>
	public CalendarEventDescriptor Description(string description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The timestamp for the end of the scheduled event in milliseconds since the epoch or ISO 8601 format.
	/// </para>
	/// </summary>
	public CalendarEventDescriptor EndTime(DateTimeOffset endTime)
	{
		EndTimeValue = endTime;
		return Self;
	}

	public CalendarEventDescriptor EventId(Elastic.Clients.Elasticsearch.Id? eventId)
	{
		EventIdValue = eventId;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Shift time by this many seconds. For example adjust time for daylight savings changes
	/// </para>
	/// </summary>
	public CalendarEventDescriptor ForceTimeShift(int? forceTimeShift)
	{
		ForceTimeShiftValue = forceTimeShift;
		return Self;
	}

	/// <summary>
	/// <para>
	/// When true the model will not be updated for this calendar period.
	/// </para>
	/// </summary>
	public CalendarEventDescriptor SkipModelUpdate(bool? skipModelUpdate = true)
	{
		SkipModelUpdateValue = skipModelUpdate;
		return Self;
	}

	/// <summary>
	/// <para>
	/// When true the model will not create results for this calendar period.
	/// </para>
	/// </summary>
	public CalendarEventDescriptor SkipResult(bool? skipResult = true)
	{
		SkipResultValue = skipResult;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The timestamp for the beginning of the scheduled event in milliseconds since the epoch or ISO 8601 format.
	/// </para>
	/// </summary>
	public CalendarEventDescriptor StartTime(DateTimeOffset startTime)
	{
		StartTimeValue = startTime;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CalendarIdValue is not null)
		{
			writer.WritePropertyName("calendar_id");
			JsonSerializer.Serialize(writer, CalendarIdValue, options);
		}

		writer.WritePropertyName("description");
		writer.WriteStringValue(DescriptionValue);
		writer.WritePropertyName("end_time");
		JsonSerializer.Serialize(writer, EndTimeValue, options);
		if (EventIdValue is not null)
		{
			writer.WritePropertyName("event_id");
			JsonSerializer.Serialize(writer, EventIdValue, options);
		}

		if (ForceTimeShiftValue.HasValue)
		{
			writer.WritePropertyName("force_time_shift");
			writer.WriteNumberValue(ForceTimeShiftValue.Value);
		}

		if (SkipModelUpdateValue.HasValue)
		{
			writer.WritePropertyName("skip_model_update");
			writer.WriteBooleanValue(SkipModelUpdateValue.Value);
		}

		if (SkipResultValue.HasValue)
		{
			writer.WritePropertyName("skip_result");
			writer.WriteBooleanValue(SkipResultValue.Value);
		}

		writer.WritePropertyName("start_time");
		JsonSerializer.Serialize(writer, StartTimeValue, options);
		writer.WriteEndObject();
	}
}