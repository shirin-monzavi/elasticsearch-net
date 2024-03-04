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

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class RrfRank
{
	/// <summary>
	/// <para>How much influence documents in individual result sets per query have over the final ranked result set</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("rank_constant")]
	public long? RankConstant { get; set; }

	/// <summary>
	/// <para>Size of the individual result sets per query</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("window_size")]
	public long? WindowSize { get; set; }

	public static implicit operator Rank(RrfRank rrfRank) => Rank.Rrf(rrfRank);
}

public sealed partial class RrfRankDescriptor : SerializableDescriptor<RrfRankDescriptor>
{
	internal RrfRankDescriptor(Action<RrfRankDescriptor> configure) => configure.Invoke(this);

	public RrfRankDescriptor() : base()
	{
	}

	private long? RankConstantValue { get; set; }
	private long? WindowSizeValue { get; set; }

	/// <summary>
	/// <para>How much influence documents in individual result sets per query have over the final ranked result set</para>
	/// </summary>
	public RrfRankDescriptor RankConstant(long? rankConstant)
	{
		RankConstantValue = rankConstant;
		return Self;
	}

	/// <summary>
	/// <para>Size of the individual result sets per query</para>
	/// </summary>
	public RrfRankDescriptor WindowSize(long? windowSize)
	{
		WindowSizeValue = windowSize;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (RankConstantValue.HasValue)
		{
			writer.WritePropertyName("rank_constant");
			writer.WriteNumberValue(RankConstantValue.Value);
		}

		if (WindowSizeValue.HasValue)
		{
			writer.WritePropertyName("window_size");
			writer.WriteNumberValue(WindowSizeValue.Value);
		}

		writer.WriteEndObject();
	}
}