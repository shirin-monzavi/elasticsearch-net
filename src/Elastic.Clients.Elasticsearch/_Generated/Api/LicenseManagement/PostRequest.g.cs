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

namespace Elastic.Clients.Elasticsearch.LicenseManagement;

public sealed partial class PostRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Specifies whether you acknowledge the license changes.
	/// </para>
	/// </summary>
	public bool? Acknowledge { get => Q<bool?>("acknowledge"); set => Q("acknowledge", value); }
}

/// <summary>
/// <para>
/// Updates the license for the cluster.
/// </para>
/// </summary>
public sealed partial class PostRequest : PlainRequest<PostRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.LicenseManagementPost;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "license.post";

	/// <summary>
	/// <para>
	/// Specifies whether you acknowledge the license changes.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Acknowledge { get => Q<bool?>("acknowledge"); set => Q("acknowledge", value); }
	[JsonInclude, JsonPropertyName("license")]
	public Elastic.Clients.Elasticsearch.LicenseManagement.License? License { get; set; }

	/// <summary>
	/// <para>
	/// A sequence of one or more JSON documents containing the license information.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("licenses")]
	public ICollection<Elastic.Clients.Elasticsearch.LicenseManagement.License>? Licenses { get; set; }
}

/// <summary>
/// <para>
/// Updates the license for the cluster.
/// </para>
/// </summary>
public sealed partial class PostRequestDescriptor : RequestDescriptor<PostRequestDescriptor, PostRequestParameters>
{
	internal PostRequestDescriptor(Action<PostRequestDescriptor> configure) => configure.Invoke(this);

	public PostRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.LicenseManagementPost;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "license.post";

	public PostRequestDescriptor Acknowledge(bool? acknowledge = true) => Qs("acknowledge", acknowledge);

	private Elastic.Clients.Elasticsearch.LicenseManagement.License? LicenseValue { get; set; }
	private Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor LicenseDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor> LicenseDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.LicenseManagement.License>? LicensesValue { get; set; }
	private Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor LicensesDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor> LicensesDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor>[] LicensesDescriptorActions { get; set; }

	public PostRequestDescriptor License(Elastic.Clients.Elasticsearch.LicenseManagement.License? license)
	{
		LicenseDescriptor = null;
		LicenseDescriptorAction = null;
		LicenseValue = license;
		return Self;
	}

	public PostRequestDescriptor License(Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor descriptor)
	{
		LicenseValue = null;
		LicenseDescriptorAction = null;
		LicenseDescriptor = descriptor;
		return Self;
	}

	public PostRequestDescriptor License(Action<Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor> configure)
	{
		LicenseValue = null;
		LicenseDescriptor = null;
		LicenseDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A sequence of one or more JSON documents containing the license information.
	/// </para>
	/// </summary>
	public PostRequestDescriptor Licenses(ICollection<Elastic.Clients.Elasticsearch.LicenseManagement.License>? licenses)
	{
		LicensesDescriptor = null;
		LicensesDescriptorAction = null;
		LicensesDescriptorActions = null;
		LicensesValue = licenses;
		return Self;
	}

	public PostRequestDescriptor Licenses(Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor descriptor)
	{
		LicensesValue = null;
		LicensesDescriptorAction = null;
		LicensesDescriptorActions = null;
		LicensesDescriptor = descriptor;
		return Self;
	}

	public PostRequestDescriptor Licenses(Action<Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor> configure)
	{
		LicensesValue = null;
		LicensesDescriptor = null;
		LicensesDescriptorActions = null;
		LicensesDescriptorAction = configure;
		return Self;
	}

	public PostRequestDescriptor Licenses(params Action<Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor>[] configure)
	{
		LicensesValue = null;
		LicensesDescriptor = null;
		LicensesDescriptorAction = null;
		LicensesDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (LicenseDescriptor is not null)
		{
			writer.WritePropertyName("license");
			JsonSerializer.Serialize(writer, LicenseDescriptor, options);
		}
		else if (LicenseDescriptorAction is not null)
		{
			writer.WritePropertyName("license");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor(LicenseDescriptorAction), options);
		}
		else if (LicenseValue is not null)
		{
			writer.WritePropertyName("license");
			JsonSerializer.Serialize(writer, LicenseValue, options);
		}

		if (LicensesDescriptor is not null)
		{
			writer.WritePropertyName("licenses");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, LicensesDescriptor, options);
			writer.WriteEndArray();
		}
		else if (LicensesDescriptorAction is not null)
		{
			writer.WritePropertyName("licenses");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor(LicensesDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (LicensesDescriptorActions is not null)
		{
			writer.WritePropertyName("licenses");
			writer.WriteStartArray();
			foreach (var action in LicensesDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.LicenseManagement.LicenseDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (LicensesValue is not null)
		{
			writer.WritePropertyName("licenses");
			JsonSerializer.Serialize(writer, LicensesValue, options);
		}

		writer.WriteEndObject();
	}
}