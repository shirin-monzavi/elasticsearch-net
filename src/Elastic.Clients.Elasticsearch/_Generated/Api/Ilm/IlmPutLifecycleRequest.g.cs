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
namespace Elastic.Clients.Elasticsearch.Ilm
{
	public sealed class IlmPutLifecycleRequestParameters : RequestParameters<IlmPutLifecycleRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public partial class IlmPutLifecycleRequest : PlainRequestBase<IlmPutLifecycleRequestParameters>
	{
		public IlmPutLifecycleRequest(Elastic.Clients.Elasticsearch.Name policy) : base(r => r.Required("policy", policy))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementPutLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public sealed partial class IlmPutLifecycleRequestDescriptor : RequestDescriptorBase<IlmPutLifecycleRequestDescriptor, IlmPutLifecycleRequestParameters>
	{
		internal IlmPutLifecycleRequestDescriptor(Action<IlmPutLifecycleRequestDescriptor> configure) => configure.Invoke(this);
		public IlmPutLifecycleRequestDescriptor(Elastic.Clients.Elasticsearch.Name policy) : base(r => r.Required("policy", policy))
		{
		}

		internal IlmPutLifecycleRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementPutLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		public IlmPutLifecycleRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IlmPutLifecycleRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
		public IlmPutLifecycleRequestDescriptor Policy(Elastic.Clients.Elasticsearch.Name policy)
		{
			RouteValues.Required("policy", policy);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}