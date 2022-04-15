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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public class MlFlushJobRequestParameters : RequestParameters<MlFlushJobRequestParameters>
	{
	}

	public partial class MlFlushJobRequest : PlainRequestBase<MlFlushJobRequestParameters>
	{
		public MlFlushJobRequest(Elastic.Clients.Elasticsearch.Id job_id) : base(r => r.Required("job_id", job_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningFlushJob;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("advance_time")]
		public string? AdvanceTime { get; set; }

		[JsonInclude]
		[JsonPropertyName("calc_interim")]
		public bool? CalcInterim { get; set; }

		[JsonInclude]
		[JsonPropertyName("end")]
		public string? End { get; set; }

		[JsonInclude]
		[JsonPropertyName("skip_time")]
		public Elastic.Clients.Elasticsearch.EpochMillis? SkipTime { get; set; }

		[JsonInclude]
		[JsonPropertyName("start")]
		public string? Start { get; set; }
	}

	public sealed partial class MlFlushJobRequestDescriptor : RequestDescriptorBase<MlFlushJobRequestDescriptor, MlFlushJobRequestParameters>
	{
		internal MlFlushJobRequestDescriptor(Action<MlFlushJobRequestDescriptor> configure) => configure.Invoke(this);
		public MlFlushJobRequestDescriptor(Elastic.Clients.Elasticsearch.Id job_id) : base(r => r.Required("job_id", job_id))
		{
		}

		internal MlFlushJobRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningFlushJob;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlFlushJobRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id job_id)
		{
			RouteValues.Required("job_id", job_id);
			return Self;
		}

		private string? AdvanceTimeValue { get; set; }

		private bool? CalcInterimValue { get; set; }

		private string? EndValue { get; set; }

		private Elastic.Clients.Elasticsearch.EpochMillis? SkipTimeValue { get; set; }

		private string? StartValue { get; set; }

		public MlFlushJobRequestDescriptor AdvanceTime(string? advanceTime)
		{
			AdvanceTimeValue = advanceTime;
			return Self;
		}

		public MlFlushJobRequestDescriptor CalcInterim(bool? calcInterim = true)
		{
			CalcInterimValue = calcInterim;
			return Self;
		}

		public MlFlushJobRequestDescriptor End(string? end)
		{
			EndValue = end;
			return Self;
		}

		public MlFlushJobRequestDescriptor SkipTime(Elastic.Clients.Elasticsearch.EpochMillis? skipTime)
		{
			SkipTimeValue = skipTime;
			return Self;
		}

		public MlFlushJobRequestDescriptor Start(string? start)
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
}