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
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.DanglingIndices
{
	public class DeleteDanglingIndexRequestParameters : RequestParameters<DeleteDanglingIndexRequestParameters>
	{
		[JsonIgnore]
		public bool AcceptDataLoss { get => Q<bool>("accept_data_loss"); set => Q("accept_data_loss", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	public class ImportDanglingIndexRequestParameters : RequestParameters<ImportDanglingIndexRequestParameters>
	{
		[JsonIgnore]
		public bool AcceptDataLoss { get => Q<bool>("accept_data_loss"); set => Q("accept_data_loss", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	public class ListDanglingIndicesRequestParameters : RequestParameters<ListDanglingIndicesRequestParameters>
	{
	}
}