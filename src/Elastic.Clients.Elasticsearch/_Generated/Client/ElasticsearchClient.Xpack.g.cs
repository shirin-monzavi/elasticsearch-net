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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Xpack
{
	public class XpackNamespace : NamespacedClientProxy
	{
		internal XpackNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public XpackInfoResponse Info(XpackInfoRequest request)
		{
			request.BeforeRequest();
			return DoRequest<XpackInfoRequest, XpackInfoResponse>(request);
		}

		public Task<XpackInfoResponse> InfoAsync(XpackInfoRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<XpackInfoRequest, XpackInfoResponse>(request, cancellationToken);
		}

		public XpackInfoResponse Info()
		{
			var descriptor = new XpackInfoRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<XpackInfoRequestDescriptor, XpackInfoResponse>(descriptor);
		}

		public XpackInfoResponse Info(Action<XpackInfoRequestDescriptor> configureRequest)
		{
			var descriptor = new XpackInfoRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<XpackInfoRequestDescriptor, XpackInfoResponse>(descriptor);
		}

		public Task<XpackInfoResponse> InfoAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new XpackInfoRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<XpackInfoRequestDescriptor, XpackInfoResponse>(descriptor);
		}

		public Task<XpackInfoResponse> InfoAsync(Action<XpackInfoRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new XpackInfoRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<XpackInfoRequestDescriptor, XpackInfoResponse>(descriptor);
		}

		public XpackUsageResponse Usage(XpackUsageRequest request)
		{
			request.BeforeRequest();
			return DoRequest<XpackUsageRequest, XpackUsageResponse>(request);
		}

		public Task<XpackUsageResponse> UsageAsync(XpackUsageRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<XpackUsageRequest, XpackUsageResponse>(request, cancellationToken);
		}

		public XpackUsageResponse Usage()
		{
			var descriptor = new XpackUsageRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<XpackUsageRequestDescriptor, XpackUsageResponse>(descriptor);
		}

		public XpackUsageResponse Usage(Action<XpackUsageRequestDescriptor> configureRequest)
		{
			var descriptor = new XpackUsageRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<XpackUsageRequestDescriptor, XpackUsageResponse>(descriptor);
		}

		public Task<XpackUsageResponse> UsageAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new XpackUsageRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<XpackUsageRequestDescriptor, XpackUsageResponse>(descriptor);
		}

		public Task<XpackUsageResponse> UsageAsync(Action<XpackUsageRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new XpackUsageRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<XpackUsageRequestDescriptor, XpackUsageResponse>(descriptor);
		}
	}
}