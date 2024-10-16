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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class GetCalendarsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Skips the specified number of calendars. This parameter is supported only when you omit the calendar identifier.
	/// </para>
	/// </summary>
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// Specifies the maximum number of calendars to obtain. This parameter is supported only when you omit the calendar identifier.
	/// </para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>
/// Get calendar configuration info.
/// </para>
/// </summary>
public sealed partial class GetCalendarsRequest : PlainRequest<GetCalendarsRequestParameters>
{
	public GetCalendarsRequest()
	{
	}

	public GetCalendarsRequest(Elastic.Clients.Elasticsearch.Serverless.Id? calendarId) : base(r => r.Optional("calendar_id", calendarId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetCalendars;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.get_calendars";

	/// <summary>
	/// <para>
	/// Skips the specified number of calendars. This parameter is supported only when you omit the calendar identifier.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// Specifies the maximum number of calendars to obtain. This parameter is supported only when you omit the calendar identifier.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }

	/// <summary>
	/// <para>
	/// This object is supported only when you omit the calendar identifier.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("page")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.Page? Page { get; set; }
}

/// <summary>
/// <para>
/// Get calendar configuration info.
/// </para>
/// </summary>
public sealed partial class GetCalendarsRequestDescriptor : RequestDescriptor<GetCalendarsRequestDescriptor, GetCalendarsRequestParameters>
{
	internal GetCalendarsRequestDescriptor(Action<GetCalendarsRequestDescriptor> configure) => configure.Invoke(this);

	public GetCalendarsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id? calendarId) : base(r => r.Optional("calendar_id", calendarId))
	{
	}

	public GetCalendarsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetCalendars;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.get_calendars";

	public GetCalendarsRequestDescriptor From(int? from) => Qs("from", from);
	public GetCalendarsRequestDescriptor Size(int? size) => Qs("size", size);

	public GetCalendarsRequestDescriptor CalendarId(Elastic.Clients.Elasticsearch.Serverless.Id? calendarId)
	{
		RouteValues.Optional("calendar_id", calendarId);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.MachineLearning.Page? PageValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PageDescriptor PageDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PageDescriptor> PageDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// This object is supported only when you omit the calendar identifier.
	/// </para>
	/// </summary>
	public GetCalendarsRequestDescriptor Page(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.Page? page)
	{
		PageDescriptor = null;
		PageDescriptorAction = null;
		PageValue = page;
		return Self;
	}

	public GetCalendarsRequestDescriptor Page(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PageDescriptor descriptor)
	{
		PageValue = null;
		PageDescriptorAction = null;
		PageDescriptor = descriptor;
		return Self;
	}

	public GetCalendarsRequestDescriptor Page(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PageDescriptor> configure)
	{
		PageValue = null;
		PageDescriptor = null;
		PageDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (PageDescriptor is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, PageDescriptor, options);
		}
		else if (PageDescriptorAction is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PageDescriptor(PageDescriptorAction), options);
		}
		else if (PageValue is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, PageValue, options);
		}

		writer.WriteEndObject();
	}
}