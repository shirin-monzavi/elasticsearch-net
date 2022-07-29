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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public sealed partial class BoxPlotAggregate : IAggregate
	{
		[JsonInclude]
		[JsonPropertyName("lower")]
		public double Lower { get; init; }

		[JsonInclude]
		[JsonPropertyName("lower_as_string")]
		public string? LowerAsString { get; init; }

		[JsonInclude]
		[JsonPropertyName("max")]
		public double Max { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_as_string")]
		public string? MaxAsString { get; init; }

		[JsonInclude]
		[JsonPropertyName("meta")]
		public Dictionary<string, object>? Meta { get; init; }

		[JsonInclude]
		[JsonPropertyName("min")]
		public double Min { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_as_string")]
		public string? MinAsString { get; init; }

		[JsonInclude]
		[JsonPropertyName("q1")]
		public double Q1 { get; init; }

		[JsonInclude]
		[JsonPropertyName("q1_as_string")]
		public string? Q1AsString { get; init; }

		[JsonInclude]
		[JsonPropertyName("q2")]
		public double Q2 { get; init; }

		[JsonInclude]
		[JsonPropertyName("q2_as_string")]
		public string? Q2AsString { get; init; }

		[JsonInclude]
		[JsonPropertyName("q3")]
		public double Q3 { get; init; }

		[JsonInclude]
		[JsonPropertyName("q3_as_string")]
		public string? Q3AsString { get; init; }

		[JsonInclude]
		[JsonPropertyName("upper")]
		public double Upper { get; init; }

		[JsonInclude]
		[JsonPropertyName("upper_as_string")]
		public string? UpperAsString { get; init; }
	}
}