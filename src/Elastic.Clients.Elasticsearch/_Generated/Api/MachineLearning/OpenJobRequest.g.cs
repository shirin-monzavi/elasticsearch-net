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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class OpenJobRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Open anomaly detection jobs.
/// An anomaly detection job must be opened to be ready to receive and analyze
/// data. It can be opened and closed multiple times throughout its lifecycle.
/// When you open a new job, it starts with an empty model.
/// When you open an existing job, the most recent model state is automatically
/// loaded. The job is ready to resume its analysis from where it left off, once
/// new data is received.
/// </para>
/// </summary>
public sealed partial class OpenJobRequest : PlainRequest<OpenJobRequestParameters>
{
	public OpenJobRequest(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningOpenJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.open_job";

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>timeout</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timeout")]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get; set; }
}

/// <summary>
/// <para>
/// Open anomaly detection jobs.
/// An anomaly detection job must be opened to be ready to receive and analyze
/// data. It can be opened and closed multiple times throughout its lifecycle.
/// When you open a new job, it starts with an empty model.
/// When you open an existing job, the most recent model state is automatically
/// loaded. The job is ready to resume its analysis from where it left off, once
/// new data is received.
/// </para>
/// </summary>
public sealed partial class OpenJobRequestDescriptor : RequestDescriptor<OpenJobRequestDescriptor, OpenJobRequestParameters>
{
	internal OpenJobRequestDescriptor(Action<OpenJobRequestDescriptor> configure) => configure.Invoke(this);

	public OpenJobRequestDescriptor(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningOpenJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.open_job";

	public OpenJobRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id jobId)
	{
		RouteValues.Required("job_id", jobId);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Duration? TimeoutValue { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>timeout</c> query parameter.
	/// </para>
	/// </summary>
	public OpenJobRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout)
	{
		TimeoutValue = timeout;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (TimeoutValue is not null)
		{
			writer.WritePropertyName("timeout");
			JsonSerializer.Serialize(writer, TimeoutValue, options);
		}

		writer.WriteEndObject();
	}
}