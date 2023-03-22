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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch;

public sealed class ReindexRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Should the affected indexes be refreshed?</para>
	/// </summary>
	public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>The throttle to set on this request in sub-requests per second. -1 means no throttle.</para>
	/// </summary>
	public float? RequestsPerSecond { get => Q<float?>("requests_per_second"); set => Q("requests_per_second", value); }

	/// <summary>
	/// <para>Control how long to keep the search context alive</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Scroll { get => Q<Elastic.Clients.Elasticsearch.Duration?>("scroll"); set => Q("scroll", value); }

	/// <summary>
	/// <para>The number of slices this task should be divided into. Defaults to 1, meaning the task isn't sliced into subtasks. Can be set to `auto`.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Slices? Slices { get => Q<Elastic.Clients.Elasticsearch.Slices?>("slices"); set => Q("slices", value); }

	/// <summary>
	/// <para>Time each individual bulk request should wait for shards that are unavailable.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Sets the number of shard copies that must be active before proceeding with the reindex operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	/// <summary>
	/// <para>Should the request should block until the reindex is complete.</para>
	/// </summary>
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }
}

/// <summary>
/// <para>Allows to copy documents from one index to another, optionally filtering the source<br/>documents by a query, changing the destination index settings, or fetching the<br/>documents from a remote cluster.</para>
/// </summary>
public sealed partial class ReindexRequest : PlainRequest<ReindexRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceReindex;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	/// <summary>
	/// <para>Should the affected indexes be refreshed?</para>
	/// </summary>
	[JsonIgnore]
	public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>The throttle to set on this request in sub-requests per second. -1 means no throttle.</para>
	/// </summary>
	[JsonIgnore]
	public float? RequestsPerSecond { get => Q<float?>("requests_per_second"); set => Q("requests_per_second", value); }

	/// <summary>
	/// <para>Control how long to keep the search context alive</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Scroll { get => Q<Elastic.Clients.Elasticsearch.Duration?>("scroll"); set => Q("scroll", value); }

	/// <summary>
	/// <para>The number of slices this task should be divided into. Defaults to 1, meaning the task isn't sliced into subtasks. Can be set to `auto`.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Slices? Slices { get => Q<Elastic.Clients.Elasticsearch.Slices?>("slices"); set => Q("slices", value); }

	/// <summary>
	/// <para>Time each individual bulk request should wait for shards that are unavailable.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Sets the number of shard copies that must be active before proceeding with the reindex operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	/// <summary>
	/// <para>Should the request should block until the reindex is complete.</para>
	/// </summary>
	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	[JsonIgnore]
	public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }
	[JsonInclude, JsonPropertyName("conflicts")]
	public Elastic.Clients.Elasticsearch.Conflicts? Conflicts { get; set; }
	[JsonInclude, JsonPropertyName("dest")]
	public Elastic.Clients.Elasticsearch.Core.Reindex.Destination Dest { get; set; }
	[JsonInclude, JsonPropertyName("max_docs")]
	public long? MaxDocs { get; set; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }
	[JsonInclude, JsonPropertyName("size")]
	public long? Size { get; set; }
	[JsonInclude, JsonPropertyName("source")]
	public Elastic.Clients.Elasticsearch.Core.Reindex.Source Source { get; set; }
}

/// <summary>
/// <para>Allows to copy documents from one index to another, optionally filtering the source<br/>documents by a query, changing the destination index settings, or fetching the<br/>documents from a remote cluster.</para>
/// </summary>
public sealed partial class ReindexRequestDescriptor<TDocument> : RequestDescriptor<ReindexRequestDescriptor<TDocument>, ReindexRequestParameters>
{
	internal ReindexRequestDescriptor(Action<ReindexRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public ReindexRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceReindex;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	public ReindexRequestDescriptor<TDocument> Refresh(bool? refresh = true) => Qs("refresh", refresh);
	public ReindexRequestDescriptor<TDocument> RequestsPerSecond(float? requestsPerSecond) => Qs("requests_per_second", requestsPerSecond);
	public ReindexRequestDescriptor<TDocument> RequireAlias(bool? requireAlias = true) => Qs("require_alias", requireAlias);
	public ReindexRequestDescriptor<TDocument> Scroll(Elastic.Clients.Elasticsearch.Duration? scroll) => Qs("scroll", scroll);
	public ReindexRequestDescriptor<TDocument> Slices(Elastic.Clients.Elasticsearch.Slices? slices) => Qs("slices", slices);
	public ReindexRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public ReindexRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	public ReindexRequestDescriptor<TDocument> WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	private Elastic.Clients.Elasticsearch.Core.Reindex.Source SourceValue { get; set; }
	private Core.Reindex.SourceDescriptor<TDocument> SourceDescriptor { get; set; }
	private Action<Core.Reindex.SourceDescriptor<TDocument>> SourceDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Conflicts? ConflictsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Reindex.Destination DestValue { get; set; }
	private Core.Reindex.DestinationDescriptor DestDescriptor { get; set; }
	private Action<Core.Reindex.DestinationDescriptor> DestDescriptorAction { get; set; }
	private long? MaxDocsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private long? SizeValue { get; set; }

	public ReindexRequestDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Core.Reindex.Source source)
	{
		SourceDescriptor = null;
		SourceDescriptorAction = null;
		SourceValue = source;
		return Self;
	}

	public ReindexRequestDescriptor<TDocument> Source(Core.Reindex.SourceDescriptor<TDocument> descriptor)
	{
		SourceValue = null;
		SourceDescriptorAction = null;
		SourceDescriptor = descriptor;
		return Self;
	}

	public ReindexRequestDescriptor<TDocument> Source(Action<Core.Reindex.SourceDescriptor<TDocument>> configure)
	{
		SourceValue = null;
		SourceDescriptor = null;
		SourceDescriptorAction = configure;
		return Self;
	}

	public ReindexRequestDescriptor<TDocument> Conflicts(Elastic.Clients.Elasticsearch.Conflicts? conflicts)
	{
		ConflictsValue = conflicts;
		return Self;
	}

	public ReindexRequestDescriptor<TDocument> Dest(Elastic.Clients.Elasticsearch.Core.Reindex.Destination dest)
	{
		DestDescriptor = null;
		DestDescriptorAction = null;
		DestValue = dest;
		return Self;
	}

	public ReindexRequestDescriptor<TDocument> Dest(Core.Reindex.DestinationDescriptor descriptor)
	{
		DestValue = null;
		DestDescriptorAction = null;
		DestDescriptor = descriptor;
		return Self;
	}

	public ReindexRequestDescriptor<TDocument> Dest(Action<Core.Reindex.DestinationDescriptor> configure)
	{
		DestValue = null;
		DestDescriptor = null;
		DestDescriptorAction = configure;
		return Self;
	}

	public ReindexRequestDescriptor<TDocument> MaxDocs(long? maxDocs)
	{
		MaxDocsValue = maxDocs;
		return Self;
	}

	public ReindexRequestDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	public ReindexRequestDescriptor<TDocument> Size(long? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (SourceDescriptor is not null)
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, SourceDescriptor, options);
		}
		else if (SourceDescriptorAction is not null)
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, new Core.Reindex.SourceDescriptor<TDocument>(SourceDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, SourceValue, options);
		}

		if (ConflictsValue is not null)
		{
			writer.WritePropertyName("conflicts");
			JsonSerializer.Serialize(writer, ConflictsValue, options);
		}

		if (DestDescriptor is not null)
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, DestDescriptor, options);
		}
		else if (DestDescriptorAction is not null)
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, new Core.Reindex.DestinationDescriptor(DestDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, DestValue, options);
		}

		if (MaxDocsValue.HasValue)
		{
			writer.WritePropertyName("max_docs");
			writer.WriteNumberValue(MaxDocsValue.Value);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Allows to copy documents from one index to another, optionally filtering the source<br/>documents by a query, changing the destination index settings, or fetching the<br/>documents from a remote cluster.</para>
/// </summary>
public sealed partial class ReindexRequestDescriptor : RequestDescriptor<ReindexRequestDescriptor, ReindexRequestParameters>
{
	internal ReindexRequestDescriptor(Action<ReindexRequestDescriptor> configure) => configure.Invoke(this);

	public ReindexRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceReindex;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	public ReindexRequestDescriptor Refresh(bool? refresh = true) => Qs("refresh", refresh);
	public ReindexRequestDescriptor RequestsPerSecond(float? requestsPerSecond) => Qs("requests_per_second", requestsPerSecond);
	public ReindexRequestDescriptor RequireAlias(bool? requireAlias = true) => Qs("require_alias", requireAlias);
	public ReindexRequestDescriptor Scroll(Elastic.Clients.Elasticsearch.Duration? scroll) => Qs("scroll", scroll);
	public ReindexRequestDescriptor Slices(Elastic.Clients.Elasticsearch.Slices? slices) => Qs("slices", slices);
	public ReindexRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public ReindexRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	public ReindexRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	private Elastic.Clients.Elasticsearch.Core.Reindex.Source SourceValue { get; set; }
	private Core.Reindex.SourceDescriptor SourceDescriptor { get; set; }
	private Action<Core.Reindex.SourceDescriptor> SourceDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Conflicts? ConflictsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Reindex.Destination DestValue { get; set; }
	private Core.Reindex.DestinationDescriptor DestDescriptor { get; set; }
	private Action<Core.Reindex.DestinationDescriptor> DestDescriptorAction { get; set; }
	private long? MaxDocsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private long? SizeValue { get; set; }

	public ReindexRequestDescriptor Source(Elastic.Clients.Elasticsearch.Core.Reindex.Source source)
	{
		SourceDescriptor = null;
		SourceDescriptorAction = null;
		SourceValue = source;
		return Self;
	}

	public ReindexRequestDescriptor Source(Core.Reindex.SourceDescriptor descriptor)
	{
		SourceValue = null;
		SourceDescriptorAction = null;
		SourceDescriptor = descriptor;
		return Self;
	}

	public ReindexRequestDescriptor Source(Action<Core.Reindex.SourceDescriptor> configure)
	{
		SourceValue = null;
		SourceDescriptor = null;
		SourceDescriptorAction = configure;
		return Self;
	}

	public ReindexRequestDescriptor Conflicts(Elastic.Clients.Elasticsearch.Conflicts? conflicts)
	{
		ConflictsValue = conflicts;
		return Self;
	}

	public ReindexRequestDescriptor Dest(Elastic.Clients.Elasticsearch.Core.Reindex.Destination dest)
	{
		DestDescriptor = null;
		DestDescriptorAction = null;
		DestValue = dest;
		return Self;
	}

	public ReindexRequestDescriptor Dest(Core.Reindex.DestinationDescriptor descriptor)
	{
		DestValue = null;
		DestDescriptorAction = null;
		DestDescriptor = descriptor;
		return Self;
	}

	public ReindexRequestDescriptor Dest(Action<Core.Reindex.DestinationDescriptor> configure)
	{
		DestValue = null;
		DestDescriptor = null;
		DestDescriptorAction = configure;
		return Self;
	}

	public ReindexRequestDescriptor MaxDocs(long? maxDocs)
	{
		MaxDocsValue = maxDocs;
		return Self;
	}

	public ReindexRequestDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	public ReindexRequestDescriptor Size(long? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (SourceDescriptor is not null)
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, SourceDescriptor, options);
		}
		else if (SourceDescriptorAction is not null)
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, new Core.Reindex.SourceDescriptor(SourceDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, SourceValue, options);
		}

		if (ConflictsValue is not null)
		{
			writer.WritePropertyName("conflicts");
			JsonSerializer.Serialize(writer, ConflictsValue, options);
		}

		if (DestDescriptor is not null)
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, DestDescriptor, options);
		}
		else if (DestDescriptorAction is not null)
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, new Core.Reindex.DestinationDescriptor(DestDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, DestValue, options);
		}

		if (MaxDocsValue.HasValue)
		{
			writer.WritePropertyName("max_docs");
			writer.WriteNumberValue(MaxDocsValue.Value);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
	}
}