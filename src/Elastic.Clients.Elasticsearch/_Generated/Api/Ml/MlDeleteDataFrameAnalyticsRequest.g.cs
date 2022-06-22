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
	public sealed class MlDeleteDataFrameAnalyticsRequestParameters : RequestParameters<MlDeleteDataFrameAnalyticsRequestParameters>
	{
		[JsonIgnore]
		public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public partial class MlDeleteDataFrameAnalyticsRequest : PlainRequestBase<MlDeleteDataFrameAnalyticsRequestParameters>
	{
		public MlDeleteDataFrameAnalyticsRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public sealed partial class MlDeleteDataFrameAnalyticsRequestDescriptor<TDocument> : RequestDescriptorBase<MlDeleteDataFrameAnalyticsRequestDescriptor<TDocument>, MlDeleteDataFrameAnalyticsRequestParameters>
	{
		internal MlDeleteDataFrameAnalyticsRequestDescriptor(Action<MlDeleteDataFrameAnalyticsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MlDeleteDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal MlDeleteDataFrameAnalyticsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public MlDeleteDataFrameAnalyticsRequestDescriptor<TDocument> Force(bool? force = true) => Qs("force", force);
		public MlDeleteDataFrameAnalyticsRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
		public MlDeleteDataFrameAnalyticsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class MlDeleteDataFrameAnalyticsRequestDescriptor : RequestDescriptorBase<MlDeleteDataFrameAnalyticsRequestDescriptor, MlDeleteDataFrameAnalyticsRequestParameters>
	{
		internal MlDeleteDataFrameAnalyticsRequestDescriptor(Action<MlDeleteDataFrameAnalyticsRequestDescriptor> configure) => configure.Invoke(this);
		public MlDeleteDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal MlDeleteDataFrameAnalyticsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public MlDeleteDataFrameAnalyticsRequestDescriptor Force(bool? force = true) => Qs("force", force);
		public MlDeleteDataFrameAnalyticsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
		public MlDeleteDataFrameAnalyticsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}