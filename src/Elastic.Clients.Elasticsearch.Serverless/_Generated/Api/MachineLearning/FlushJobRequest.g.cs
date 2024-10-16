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

public sealed partial class FlushJobRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Force buffered data to be processed.
/// The flush jobs API is only applicable when sending data for analysis using
/// the post data API. Depending on the content of the buffer, then it might
/// additionally calculate new results. Both flush and close operations are
/// similar, however the flush is more efficient if you are expecting to send
/// more data for analysis. When flushing, the job remains open and is available
/// to continue analyzing data. A close operation additionally prunes and
/// persists the model state to disk and the job must be opened again before
/// analyzing further data.
/// </para>
/// </summary>
public sealed partial class FlushJobRequest : PlainRequest<FlushJobRequestParameters>
{
	public FlushJobRequest(Elastic.Clients.Elasticsearch.Serverless.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningFlushJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.flush_job";

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>advance_time</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("advance_time")]
	public DateTimeOffset? AdvanceTime { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>calc_interim</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("calc_interim")]
	public bool? CalcInterim { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>end</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("end")]
	public DateTimeOffset? End { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>skip_time</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("skip_time")]
	public DateTimeOffset? SkipTime { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>start</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("start")]
	public DateTimeOffset? Start { get; set; }
}

/// <summary>
/// <para>
/// Force buffered data to be processed.
/// The flush jobs API is only applicable when sending data for analysis using
/// the post data API. Depending on the content of the buffer, then it might
/// additionally calculate new results. Both flush and close operations are
/// similar, however the flush is more efficient if you are expecting to send
/// more data for analysis. When flushing, the job remains open and is available
/// to continue analyzing data. A close operation additionally prunes and
/// persists the model state to disk and the job must be opened again before
/// analyzing further data.
/// </para>
/// </summary>
public sealed partial class FlushJobRequestDescriptor : RequestDescriptor<FlushJobRequestDescriptor, FlushJobRequestParameters>
{
	internal FlushJobRequestDescriptor(Action<FlushJobRequestDescriptor> configure) => configure.Invoke(this);

	public FlushJobRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningFlushJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.flush_job";

	public FlushJobRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Serverless.Id jobId)
	{
		RouteValues.Required("job_id", jobId);
		return Self;
	}

	private DateTimeOffset? AdvanceTimeValue { get; set; }
	private bool? CalcInterimValue { get; set; }
	private DateTimeOffset? EndValue { get; set; }
	private DateTimeOffset? SkipTimeValue { get; set; }
	private DateTimeOffset? StartValue { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>advance_time</c> query parameter.
	/// </para>
	/// </summary>
	public FlushJobRequestDescriptor AdvanceTime(DateTimeOffset? advanceTime)
	{
		AdvanceTimeValue = advanceTime;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>calc_interim</c> query parameter.
	/// </para>
	/// </summary>
	public FlushJobRequestDescriptor CalcInterim(bool? calcInterim = true)
	{
		CalcInterimValue = calcInterim;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>end</c> query parameter.
	/// </para>
	/// </summary>
	public FlushJobRequestDescriptor End(DateTimeOffset? end)
	{
		EndValue = end;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>skip_time</c> query parameter.
	/// </para>
	/// </summary>
	public FlushJobRequestDescriptor SkipTime(DateTimeOffset? skipTime)
	{
		SkipTimeValue = skipTime;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>start</c> query parameter.
	/// </para>
	/// </summary>
	public FlushJobRequestDescriptor Start(DateTimeOffset? start)
	{
		StartValue = start;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AdvanceTimeValue is not null)
		{
			writer.WritePropertyName("advance_time");
			JsonSerializer.Serialize(writer, AdvanceTimeValue, options);
		}

		if (CalcInterimValue.HasValue)
		{
			writer.WritePropertyName("calc_interim");
			writer.WriteBooleanValue(CalcInterimValue.Value);
		}

		if (EndValue is not null)
		{
			writer.WritePropertyName("end");
			JsonSerializer.Serialize(writer, EndValue, options);
		}

		if (SkipTimeValue is not null)
		{
			writer.WritePropertyName("skip_time");
			JsonSerializer.Serialize(writer, SkipTimeValue, options);
		}

		if (StartValue is not null)
		{
			writer.WritePropertyName("start");
			JsonSerializer.Serialize(writer, StartValue, options);
		}

		writer.WriteEndObject();
	}
}