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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.TransformManagement;

public sealed partial class PreviewTransformRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the
	/// timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Preview a transform.
/// Generates a preview of the results that you will get when you create a transform with the same configuration.
/// </para>
/// <para>
/// It returns a maximum of 100 results. The calculations are based on all the current data in the source index. It also
/// generates a list of mappings and settings for the destination index. These values are determined based on the field
/// types of the source index and the transform aggregations.
/// </para>
/// </summary>
public sealed partial class PreviewTransformRequest : PlainRequest<PreviewTransformRequestParameters>
{
	public PreviewTransformRequest()
	{
	}

	public PreviewTransformRequest(Elastic.Clients.Elasticsearch.Serverless.Id? transformId) : base(r => r.Optional("transform_id", transformId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementPreviewTransform;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "transform.preview_transform";

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the
	/// timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// Free text description of the transform.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>
	/// The destination for the transform.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("dest")]
	public Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Destination? Dest { get; set; }

	/// <summary>
	/// <para>
	/// The interval between checks for changes in the source indices when the
	/// transform is running continuously. Also determines the retry interval in
	/// the event of transient failures while the transform is searching or
	/// indexing. The minimum value is 1s and the maximum is 1h.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("frequency")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Frequency { get; set; }

	/// <summary>
	/// <para>
	/// The latest method transforms the data by finding the latest document for
	/// each unique key.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("latest")]
	public Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Latest? Latest { get; set; }

	/// <summary>
	/// <para>
	/// The pivot method transforms the data by aggregating and grouping it.
	/// These objects define the group by fields and the aggregation to reduce
	/// the data.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("pivot")]
	public Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Pivot? Pivot { get; set; }

	/// <summary>
	/// <para>
	/// Defines a retention policy for the transform. Data that meets the defined
	/// criteria is deleted from the destination index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("retention_policy")]
	public Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicy? RetentionPolicy { get; set; }

	/// <summary>
	/// <para>
	/// Defines optional transform settings.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("settings")]
	public Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Settings? Settings { get; set; }

	/// <summary>
	/// <para>
	/// The source of the data for the transform.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("source")]
	public Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Source? Source { get; set; }

	/// <summary>
	/// <para>
	/// Defines the properties transforms require to run continuously.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sync")]
	public Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Sync? Sync { get; set; }
}

/// <summary>
/// <para>
/// Preview a transform.
/// Generates a preview of the results that you will get when you create a transform with the same configuration.
/// </para>
/// <para>
/// It returns a maximum of 100 results. The calculations are based on all the current data in the source index. It also
/// generates a list of mappings and settings for the destination index. These values are determined based on the field
/// types of the source index and the transform aggregations.
/// </para>
/// </summary>
public sealed partial class PreviewTransformRequestDescriptor<TDocument> : RequestDescriptor<PreviewTransformRequestDescriptor<TDocument>, PreviewTransformRequestParameters>
{
	internal PreviewTransformRequestDescriptor(Action<PreviewTransformRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PreviewTransformRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id? transformId) : base(r => r.Optional("transform_id", transformId))
	{
	}

	public PreviewTransformRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementPreviewTransform;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "transform.preview_transform";

	public PreviewTransformRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public PreviewTransformRequestDescriptor<TDocument> TransformId(Elastic.Clients.Elasticsearch.Serverless.Id? transformId)
	{
		RouteValues.Optional("transform_id", transformId);
		return Self;
	}

	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Destination? DestValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.DestinationDescriptor DestDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.DestinationDescriptor> DestDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? FrequencyValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Latest? LatestValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.LatestDescriptor<TDocument> LatestDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.LatestDescriptor<TDocument>> LatestDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Pivot? PivotValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotDescriptor<TDocument> PivotDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotDescriptor<TDocument>> PivotDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicy? RetentionPolicyValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicyDescriptor<TDocument> RetentionPolicyDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicyDescriptor<TDocument>> RetentionPolicyDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Settings? SettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SettingsDescriptor SettingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SettingsDescriptor> SettingsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Source? SourceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SourceDescriptor<TDocument> SourceDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SourceDescriptor<TDocument>> SourceDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Sync? SyncValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SyncDescriptor<TDocument> SyncDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SyncDescriptor<TDocument>> SyncDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// Free text description of the transform.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The destination for the transform.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor<TDocument> Dest(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Destination? dest)
	{
		DestDescriptor = null;
		DestDescriptorAction = null;
		DestValue = dest;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Dest(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.DestinationDescriptor descriptor)
	{
		DestValue = null;
		DestDescriptorAction = null;
		DestDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Dest(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.DestinationDescriptor> configure)
	{
		DestValue = null;
		DestDescriptor = null;
		DestDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The interval between checks for changes in the source indices when the
	/// transform is running continuously. Also determines the retry interval in
	/// the event of transient failures while the transform is searching or
	/// indexing. The minimum value is 1s and the maximum is 1h.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor<TDocument> Frequency(Elastic.Clients.Elasticsearch.Serverless.Duration? frequency)
	{
		FrequencyValue = frequency;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The latest method transforms the data by finding the latest document for
	/// each unique key.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor<TDocument> Latest(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Latest? latest)
	{
		LatestDescriptor = null;
		LatestDescriptorAction = null;
		LatestValue = latest;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Latest(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.LatestDescriptor<TDocument> descriptor)
	{
		LatestValue = null;
		LatestDescriptorAction = null;
		LatestDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Latest(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.LatestDescriptor<TDocument>> configure)
	{
		LatestValue = null;
		LatestDescriptor = null;
		LatestDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The pivot method transforms the data by aggregating and grouping it.
	/// These objects define the group by fields and the aggregation to reduce
	/// the data.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor<TDocument> Pivot(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Pivot? pivot)
	{
		PivotDescriptor = null;
		PivotDescriptorAction = null;
		PivotValue = pivot;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Pivot(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotDescriptor<TDocument> descriptor)
	{
		PivotValue = null;
		PivotDescriptorAction = null;
		PivotDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Pivot(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotDescriptor<TDocument>> configure)
	{
		PivotValue = null;
		PivotDescriptor = null;
		PivotDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines a retention policy for the transform. Data that meets the defined
	/// criteria is deleted from the destination index.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor<TDocument> RetentionPolicy(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicy? retentionPolicy)
	{
		RetentionPolicyDescriptor = null;
		RetentionPolicyDescriptorAction = null;
		RetentionPolicyValue = retentionPolicy;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> RetentionPolicy(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicyDescriptor<TDocument> descriptor)
	{
		RetentionPolicyValue = null;
		RetentionPolicyDescriptorAction = null;
		RetentionPolicyDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> RetentionPolicy(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicyDescriptor<TDocument>> configure)
	{
		RetentionPolicyValue = null;
		RetentionPolicyDescriptor = null;
		RetentionPolicyDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines optional transform settings.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor<TDocument> Settings(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Settings? settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Settings(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SettingsDescriptor descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Settings(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SettingsDescriptor> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The source of the data for the transform.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Source? source)
	{
		SourceDescriptor = null;
		SourceDescriptorAction = null;
		SourceValue = source;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SourceDescriptor<TDocument> descriptor)
	{
		SourceValue = null;
		SourceDescriptorAction = null;
		SourceDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Source(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SourceDescriptor<TDocument>> configure)
	{
		SourceValue = null;
		SourceDescriptor = null;
		SourceDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines the properties transforms require to run continuously.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor<TDocument> Sync(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Sync? sync)
	{
		SyncDescriptor = null;
		SyncDescriptorAction = null;
		SyncValue = sync;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Sync(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SyncDescriptor<TDocument> descriptor)
	{
		SyncValue = null;
		SyncDescriptorAction = null;
		SyncDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor<TDocument> Sync(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SyncDescriptor<TDocument>> configure)
	{
		SyncValue = null;
		SyncDescriptor = null;
		SyncDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (DestDescriptor is not null)
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, DestDescriptor, options);
		}
		else if (DestDescriptorAction is not null)
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.DestinationDescriptor(DestDescriptorAction), options);
		}
		else if (DestValue is not null)
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, DestValue, options);
		}

		if (FrequencyValue is not null)
		{
			writer.WritePropertyName("frequency");
			JsonSerializer.Serialize(writer, FrequencyValue, options);
		}

		if (LatestDescriptor is not null)
		{
			writer.WritePropertyName("latest");
			JsonSerializer.Serialize(writer, LatestDescriptor, options);
		}
		else if (LatestDescriptorAction is not null)
		{
			writer.WritePropertyName("latest");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.LatestDescriptor<TDocument>(LatestDescriptorAction), options);
		}
		else if (LatestValue is not null)
		{
			writer.WritePropertyName("latest");
			JsonSerializer.Serialize(writer, LatestValue, options);
		}

		if (PivotDescriptor is not null)
		{
			writer.WritePropertyName("pivot");
			JsonSerializer.Serialize(writer, PivotDescriptor, options);
		}
		else if (PivotDescriptorAction is not null)
		{
			writer.WritePropertyName("pivot");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotDescriptor<TDocument>(PivotDescriptorAction), options);
		}
		else if (PivotValue is not null)
		{
			writer.WritePropertyName("pivot");
			JsonSerializer.Serialize(writer, PivotValue, options);
		}

		if (RetentionPolicyDescriptor is not null)
		{
			writer.WritePropertyName("retention_policy");
			JsonSerializer.Serialize(writer, RetentionPolicyDescriptor, options);
		}
		else if (RetentionPolicyDescriptorAction is not null)
		{
			writer.WritePropertyName("retention_policy");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicyDescriptor<TDocument>(RetentionPolicyDescriptorAction), options);
		}
		else if (RetentionPolicyValue is not null)
		{
			writer.WritePropertyName("retention_policy");
			JsonSerializer.Serialize(writer, RetentionPolicyValue, options);
		}

		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SettingsDescriptor(SettingsDescriptorAction), options);
		}
		else if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		if (SourceDescriptor is not null)
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, SourceDescriptor, options);
		}
		else if (SourceDescriptorAction is not null)
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SourceDescriptor<TDocument>(SourceDescriptorAction), options);
		}
		else if (SourceValue is not null)
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, SourceValue, options);
		}

		if (SyncDescriptor is not null)
		{
			writer.WritePropertyName("sync");
			JsonSerializer.Serialize(writer, SyncDescriptor, options);
		}
		else if (SyncDescriptorAction is not null)
		{
			writer.WritePropertyName("sync");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SyncDescriptor<TDocument>(SyncDescriptorAction), options);
		}
		else if (SyncValue is not null)
		{
			writer.WritePropertyName("sync");
			JsonSerializer.Serialize(writer, SyncValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Preview a transform.
/// Generates a preview of the results that you will get when you create a transform with the same configuration.
/// </para>
/// <para>
/// It returns a maximum of 100 results. The calculations are based on all the current data in the source index. It also
/// generates a list of mappings and settings for the destination index. These values are determined based on the field
/// types of the source index and the transform aggregations.
/// </para>
/// </summary>
public sealed partial class PreviewTransformRequestDescriptor : RequestDescriptor<PreviewTransformRequestDescriptor, PreviewTransformRequestParameters>
{
	internal PreviewTransformRequestDescriptor(Action<PreviewTransformRequestDescriptor> configure) => configure.Invoke(this);

	public PreviewTransformRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id? transformId) : base(r => r.Optional("transform_id", transformId))
	{
	}

	public PreviewTransformRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementPreviewTransform;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "transform.preview_transform";

	public PreviewTransformRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public PreviewTransformRequestDescriptor TransformId(Elastic.Clients.Elasticsearch.Serverless.Id? transformId)
	{
		RouteValues.Optional("transform_id", transformId);
		return Self;
	}

	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Destination? DestValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.DestinationDescriptor DestDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.DestinationDescriptor> DestDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? FrequencyValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Latest? LatestValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.LatestDescriptor LatestDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.LatestDescriptor> LatestDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Pivot? PivotValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotDescriptor PivotDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotDescriptor> PivotDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicy? RetentionPolicyValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicyDescriptor RetentionPolicyDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicyDescriptor> RetentionPolicyDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Settings? SettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SettingsDescriptor SettingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SettingsDescriptor> SettingsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Source? SourceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SourceDescriptor SourceDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SourceDescriptor> SourceDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Sync? SyncValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SyncDescriptor SyncDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SyncDescriptor> SyncDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// Free text description of the transform.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The destination for the transform.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor Dest(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Destination? dest)
	{
		DestDescriptor = null;
		DestDescriptorAction = null;
		DestValue = dest;
		return Self;
	}

	public PreviewTransformRequestDescriptor Dest(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.DestinationDescriptor descriptor)
	{
		DestValue = null;
		DestDescriptorAction = null;
		DestDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor Dest(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.DestinationDescriptor> configure)
	{
		DestValue = null;
		DestDescriptor = null;
		DestDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The interval between checks for changes in the source indices when the
	/// transform is running continuously. Also determines the retry interval in
	/// the event of transient failures while the transform is searching or
	/// indexing. The minimum value is 1s and the maximum is 1h.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor Frequency(Elastic.Clients.Elasticsearch.Serverless.Duration? frequency)
	{
		FrequencyValue = frequency;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The latest method transforms the data by finding the latest document for
	/// each unique key.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor Latest(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Latest? latest)
	{
		LatestDescriptor = null;
		LatestDescriptorAction = null;
		LatestValue = latest;
		return Self;
	}

	public PreviewTransformRequestDescriptor Latest(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.LatestDescriptor descriptor)
	{
		LatestValue = null;
		LatestDescriptorAction = null;
		LatestDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor Latest(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.LatestDescriptor> configure)
	{
		LatestValue = null;
		LatestDescriptor = null;
		LatestDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The pivot method transforms the data by aggregating and grouping it.
	/// These objects define the group by fields and the aggregation to reduce
	/// the data.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor Pivot(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Pivot? pivot)
	{
		PivotDescriptor = null;
		PivotDescriptorAction = null;
		PivotValue = pivot;
		return Self;
	}

	public PreviewTransformRequestDescriptor Pivot(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotDescriptor descriptor)
	{
		PivotValue = null;
		PivotDescriptorAction = null;
		PivotDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor Pivot(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotDescriptor> configure)
	{
		PivotValue = null;
		PivotDescriptor = null;
		PivotDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines a retention policy for the transform. Data that meets the defined
	/// criteria is deleted from the destination index.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor RetentionPolicy(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicy? retentionPolicy)
	{
		RetentionPolicyDescriptor = null;
		RetentionPolicyDescriptorAction = null;
		RetentionPolicyValue = retentionPolicy;
		return Self;
	}

	public PreviewTransformRequestDescriptor RetentionPolicy(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicyDescriptor descriptor)
	{
		RetentionPolicyValue = null;
		RetentionPolicyDescriptorAction = null;
		RetentionPolicyDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor RetentionPolicy(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicyDescriptor> configure)
	{
		RetentionPolicyValue = null;
		RetentionPolicyDescriptor = null;
		RetentionPolicyDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines optional transform settings.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Settings? settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public PreviewTransformRequestDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SettingsDescriptor descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor Settings(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SettingsDescriptor> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The source of the data for the transform.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor Source(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Source? source)
	{
		SourceDescriptor = null;
		SourceDescriptorAction = null;
		SourceValue = source;
		return Self;
	}

	public PreviewTransformRequestDescriptor Source(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SourceDescriptor descriptor)
	{
		SourceValue = null;
		SourceDescriptorAction = null;
		SourceDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor Source(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SourceDescriptor> configure)
	{
		SourceValue = null;
		SourceDescriptor = null;
		SourceDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines the properties transforms require to run continuously.
	/// </para>
	/// </summary>
	public PreviewTransformRequestDescriptor Sync(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.Sync? sync)
	{
		SyncDescriptor = null;
		SyncDescriptorAction = null;
		SyncValue = sync;
		return Self;
	}

	public PreviewTransformRequestDescriptor Sync(Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SyncDescriptor descriptor)
	{
		SyncValue = null;
		SyncDescriptorAction = null;
		SyncDescriptor = descriptor;
		return Self;
	}

	public PreviewTransformRequestDescriptor Sync(Action<Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SyncDescriptor> configure)
	{
		SyncValue = null;
		SyncDescriptor = null;
		SyncDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (DestDescriptor is not null)
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, DestDescriptor, options);
		}
		else if (DestDescriptorAction is not null)
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.DestinationDescriptor(DestDescriptorAction), options);
		}
		else if (DestValue is not null)
		{
			writer.WritePropertyName("dest");
			JsonSerializer.Serialize(writer, DestValue, options);
		}

		if (FrequencyValue is not null)
		{
			writer.WritePropertyName("frequency");
			JsonSerializer.Serialize(writer, FrequencyValue, options);
		}

		if (LatestDescriptor is not null)
		{
			writer.WritePropertyName("latest");
			JsonSerializer.Serialize(writer, LatestDescriptor, options);
		}
		else if (LatestDescriptorAction is not null)
		{
			writer.WritePropertyName("latest");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.LatestDescriptor(LatestDescriptorAction), options);
		}
		else if (LatestValue is not null)
		{
			writer.WritePropertyName("latest");
			JsonSerializer.Serialize(writer, LatestValue, options);
		}

		if (PivotDescriptor is not null)
		{
			writer.WritePropertyName("pivot");
			JsonSerializer.Serialize(writer, PivotDescriptor, options);
		}
		else if (PivotDescriptorAction is not null)
		{
			writer.WritePropertyName("pivot");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotDescriptor(PivotDescriptorAction), options);
		}
		else if (PivotValue is not null)
		{
			writer.WritePropertyName("pivot");
			JsonSerializer.Serialize(writer, PivotValue, options);
		}

		if (RetentionPolicyDescriptor is not null)
		{
			writer.WritePropertyName("retention_policy");
			JsonSerializer.Serialize(writer, RetentionPolicyDescriptor, options);
		}
		else if (RetentionPolicyDescriptorAction is not null)
		{
			writer.WritePropertyName("retention_policy");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.RetentionPolicyDescriptor(RetentionPolicyDescriptorAction), options);
		}
		else if (RetentionPolicyValue is not null)
		{
			writer.WritePropertyName("retention_policy");
			JsonSerializer.Serialize(writer, RetentionPolicyValue, options);
		}

		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SettingsDescriptor(SettingsDescriptorAction), options);
		}
		else if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		if (SourceDescriptor is not null)
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, SourceDescriptor, options);
		}
		else if (SourceDescriptorAction is not null)
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SourceDescriptor(SourceDescriptorAction), options);
		}
		else if (SourceValue is not null)
		{
			writer.WritePropertyName("source");
			JsonSerializer.Serialize(writer, SourceValue, options);
		}

		if (SyncDescriptor is not null)
		{
			writer.WritePropertyName("sync");
			JsonSerializer.Serialize(writer, SyncDescriptor, options);
		}
		else if (SyncDescriptorAction is not null)
		{
			writer.WritePropertyName("sync");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.TransformManagement.SyncDescriptor(SyncDescriptorAction), options);
		}
		else if (SyncValue is not null)
		{
			writer.WritePropertyName("sync");
			JsonSerializer.Serialize(writer, SyncValue, options);
		}

		writer.WriteEndObject();
	}
}