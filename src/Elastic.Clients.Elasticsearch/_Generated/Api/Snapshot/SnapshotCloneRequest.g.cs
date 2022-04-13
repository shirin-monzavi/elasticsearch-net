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
	public class SnapshotCloneRequestParameters : RequestParameters<SnapshotCloneRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class SnapshotCloneRequest : PlainRequestBase<SnapshotCloneRequestParameters>
	{
		public SnapshotCloneRequest(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Elastic.Clients.Elasticsearch.Name target_snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot).Required("target_snapshot", target_snapshot))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotClone;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonInclude]
		[JsonPropertyName("indices")]
		public string Indices { get; set; }
	}

	public sealed partial class SnapshotCloneRequestDescriptor : RequestDescriptorBase<SnapshotCloneRequestDescriptor, SnapshotCloneRequestParameters>
	{
		internal SnapshotCloneRequestDescriptor(Action<SnapshotCloneRequestDescriptor> configure) => configure.Invoke(this);
		public SnapshotCloneRequestDescriptor(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Elastic.Clients.Elasticsearch.Name target_snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot).Required("target_snapshot", target_snapshot))
		{
		}

		internal SnapshotCloneRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotClone;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public SnapshotCloneRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public SnapshotCloneRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public SnapshotCloneRequestDescriptor Repository(Elastic.Clients.Elasticsearch.Name repository)
		{
			RouteValues.Required("repository", repository);
			return Self;
		}

		public SnapshotCloneRequestDescriptor Snapshot(Elastic.Clients.Elasticsearch.Name snapshot)
		{
			RouteValues.Required("snapshot", snapshot);
			return Self;
		}

		public SnapshotCloneRequestDescriptor TargetSnapshot(Elastic.Clients.Elasticsearch.Name target_snapshot)
		{
			RouteValues.Required("target_snapshot", target_snapshot);
			return Self;
		}

		private string IndicesValue { get; set; }

		public SnapshotCloneRequestDescriptor Indices(string indices)
		{
			IndicesValue = indices;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("indices");
			writer.WriteStringValue(IndicesValue);
			writer.WriteEndObject();
		}
	}
}