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

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Tasks
{
	public partial class CancelResponse : ResponseBase
	{
		[JsonPropertyName("node_failures")]
		public IReadOnlyCollection<Nest.ErrorCause>? NodeFailures
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Nest.Tasks.TaskExecutingNode> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetResponse : ResponseBase
	{
		[JsonPropertyName("completed")]
		public bool Completed
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("response")]
		public Nest.Tasks.Status? Response
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("task")]
		public Nest.Tasks.Info Task
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ListResponse : ResponseBase
	{
		[JsonPropertyName("node_failures")]
		public IReadOnlyCollection<Nest.ErrorCause>? NodeFailures
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Nest.Tasks.TaskExecutingNode>? Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("tasks")]
		public Union<Dictionary<string, Nest.Tasks.Info>, IReadOnlyCollection<Nest.Tasks.Info>>? Tasks
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}