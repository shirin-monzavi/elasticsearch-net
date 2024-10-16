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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Inference;

/// <summary>
/// <para>
/// Represents an inference endpoint as returned by the GET API
/// </para>
/// </summary>
public sealed partial class InferenceEndpointInfo
{
	/// <summary>
	/// <para>
	/// The inference Id
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("inference_id")]
	public string InferenceId { get; init; }

	/// <summary>
	/// <para>
	/// The service type
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("service")]
	public string Service { get; init; }

	/// <summary>
	/// <para>
	/// Settings specific to the service
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("service_settings")]
	public object ServiceSettings { get; init; }

	/// <summary>
	/// <para>
	/// Task settings specific to the service and task type
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("task_settings")]
	public object? TaskSettings { get; init; }

	/// <summary>
	/// <para>
	/// The task type
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("task_type")]
	public Elastic.Clients.Elasticsearch.Inference.TaskType TaskType { get; init; }
}