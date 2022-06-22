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
namespace Elastic.Clients.Elasticsearch.Snapshot
{
	public sealed class DeleteSnapshotRequestParameters : RequestParameters<DeleteSnapshotRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public partial class DeleteSnapshotRequest : PlainRequestBase<DeleteSnapshotRequestParameters>
	{
		public DeleteSnapshotRequest(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public sealed partial class DeleteSnapshotRequestDescriptor : RequestDescriptorBase<DeleteSnapshotRequestDescriptor, DeleteSnapshotRequestParameters>
	{
		internal DeleteSnapshotRequestDescriptor(Action<DeleteSnapshotRequestDescriptor> configure) => configure.Invoke(this);
		public DeleteSnapshotRequestDescriptor(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		internal DeleteSnapshotRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public DeleteSnapshotRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public DeleteSnapshotRequestDescriptor Repository(Elastic.Clients.Elasticsearch.Name repository)
		{
			RouteValues.Required("repository", repository);
			return Self;
		}

		public DeleteSnapshotRequestDescriptor Snapshot(Elastic.Clients.Elasticsearch.Name snapshot)
		{
			RouteValues.Required("snapshot", snapshot);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}