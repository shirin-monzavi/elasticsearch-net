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
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class TrainedModelDeploymentNodesStats
	{
		[JsonInclude]
		[JsonPropertyName("average_inference_time_ms")]
		public double AverageInferenceTimeMs { get; init; }

		[JsonInclude]
		[JsonPropertyName("error_count")]
		public int ErrorCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("inference_count")]
		public int InferenceCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("inference_threads")]
		public int InferenceThreads { get; init; }

		[JsonInclude]
		[JsonPropertyName("last_access")]
		public long LastAccess { get; init; }

		[JsonInclude]
		[JsonPropertyName("model_threads")]
		public int ModelThreads { get; init; }

		[JsonInclude]
		[JsonPropertyName("node")]
		public Elastic.Clients.Elasticsearch.Ml.DiscoveryNode Node { get; init; }

		[JsonInclude]
		[JsonPropertyName("number_of_pending_requests")]
		public int NumberOfPendingRequests { get; init; }

		[JsonInclude]
		[JsonPropertyName("rejection_execution_count")]
		public int RejectionExecutionCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("routing_state")]
		public Elastic.Clients.Elasticsearch.Ml.TrainedModelAllocationRoutingTable RoutingState { get; init; }

		[JsonInclude]
		[JsonPropertyName("start_time")]
		public long StartTime { get; init; }

		[JsonInclude]
		[JsonPropertyName("timeout_count")]
		public int TimeoutCount { get; init; }
	}
}