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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

public sealed partial class MovingFunctionAggregation
{
	/// <summary>
	/// <para>Path to the buckets that contain one set of values to correlate.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("buckets_path")]
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.BucketsPath? BucketsPath { get; set; }

	/// <summary>
	/// <para>`DecimalFormat` pattern for the output value.<br/>If specified, the formatted value is returned in the aggregation’s `value_as_string` property.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }

	/// <summary>
	/// <para>Policy to apply when gaps are found in the data.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("gap_policy")]
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? GapPolicy { get; set; }

	/// <summary>
	/// <para>The script that should be executed on each window of data.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("script")]
	public string? Script { get; set; }

	/// <summary>
	/// <para>By default, the window consists of the last n values excluding the current bucket.<br/>Increasing `shift` by 1, moves the starting window position by 1 to the right.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("shift")]
	public int? Shift { get; set; }

	/// <summary>
	/// <para>The size of window to "slide" across the histogram.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("window")]
	public int? Window { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation(MovingFunctionAggregation movingFunctionAggregation) => Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation.MovingFn(movingFunctionAggregation);
}

public sealed partial class MovingFunctionAggregationDescriptor : SerializableDescriptor<MovingFunctionAggregationDescriptor>
{
	internal MovingFunctionAggregationDescriptor(Action<MovingFunctionAggregationDescriptor> configure) => configure.Invoke(this);

	public MovingFunctionAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.BucketsPath? BucketsPathValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? GapPolicyValue { get; set; }
	private string? ScriptValue { get; set; }
	private int? ShiftValue { get; set; }
	private int? WindowValue { get; set; }

	/// <summary>
	/// <para>Path to the buckets that contain one set of values to correlate.</para>
	/// </summary>
	public MovingFunctionAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Serverless.Aggregations.BucketsPath? bucketsPath)
	{
		BucketsPathValue = bucketsPath;
		return Self;
	}

	/// <summary>
	/// <para>`DecimalFormat` pattern for the output value.<br/>If specified, the formatted value is returned in the aggregation’s `value_as_string` property.</para>
	/// </summary>
	public MovingFunctionAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>Policy to apply when gaps are found in the data.</para>
	/// </summary>
	public MovingFunctionAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? gapPolicy)
	{
		GapPolicyValue = gapPolicy;
		return Self;
	}

	/// <summary>
	/// <para>The script that should be executed on each window of data.</para>
	/// </summary>
	public MovingFunctionAggregationDescriptor Script(string? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>By default, the window consists of the last n values excluding the current bucket.<br/>Increasing `shift` by 1, moves the starting window position by 1 to the right.</para>
	/// </summary>
	public MovingFunctionAggregationDescriptor Shift(int? shift)
	{
		ShiftValue = shift;
		return Self;
	}

	/// <summary>
	/// <para>The size of window to "slide" across the histogram.</para>
	/// </summary>
	public MovingFunctionAggregationDescriptor Window(int? window)
	{
		WindowValue = window;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BucketsPathValue is not null)
		{
			writer.WritePropertyName("buckets_path");
			JsonSerializer.Serialize(writer, BucketsPathValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (GapPolicyValue is not null)
		{
			writer.WritePropertyName("gap_policy");
			JsonSerializer.Serialize(writer, GapPolicyValue, options);
		}

		if (!string.IsNullOrEmpty(ScriptValue))
		{
			writer.WritePropertyName("script");
			writer.WriteStringValue(ScriptValue);
		}

		if (ShiftValue.HasValue)
		{
			writer.WritePropertyName("shift");
			writer.WriteNumberValue(ShiftValue.Value);
		}

		if (WindowValue.HasValue)
		{
			writer.WritePropertyName("window");
			writer.WriteNumberValue(WindowValue.Value);
		}

		writer.WriteEndObject();
	}
}