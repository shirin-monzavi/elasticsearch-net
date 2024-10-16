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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Security;

public sealed partial class HasPrivilegesRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Check user privileges.
/// Determines whether the specified user has a specified list of privileges.
/// </para>
/// </summary>
public sealed partial class HasPrivilegesRequest : PlainRequest<HasPrivilegesRequestParameters>
{
	public HasPrivilegesRequest()
	{
	}

	public HasPrivilegesRequest(Elastic.Clients.Elasticsearch.Serverless.Name? user) : base(r => r.Optional("user", user))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityHasPrivileges;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.has_privileges";

	[JsonInclude, JsonPropertyName("application")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheck>? Application { get; set; }

	/// <summary>
	/// <para>
	/// A list of the cluster privileges that you want to check.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("cluster")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.ClusterPrivilege>? Cluster { get; set; }
	[JsonInclude, JsonPropertyName("index")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheck>? Index { get; set; }
}

/// <summary>
/// <para>
/// Check user privileges.
/// Determines whether the specified user has a specified list of privileges.
/// </para>
/// </summary>
public sealed partial class HasPrivilegesRequestDescriptor : RequestDescriptor<HasPrivilegesRequestDescriptor, HasPrivilegesRequestParameters>
{
	internal HasPrivilegesRequestDescriptor(Action<HasPrivilegesRequestDescriptor> configure) => configure.Invoke(this);

	public HasPrivilegesRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Name? user) : base(r => r.Optional("user", user))
	{
	}

	public HasPrivilegesRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityHasPrivileges;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.has_privileges";

	public HasPrivilegesRequestDescriptor User(Elastic.Clients.Elasticsearch.Serverless.Name? user)
	{
		RouteValues.Optional("user", user);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheck>? ApplicationValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheckDescriptor ApplicationDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheckDescriptor> ApplicationDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheckDescriptor>[] ApplicationDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.ClusterPrivilege>? ClusterValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheck>? IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheckDescriptor IndexDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheckDescriptor> IndexDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheckDescriptor>[] IndexDescriptorActions { get; set; }

	public HasPrivilegesRequestDescriptor Application(ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheck>? application)
	{
		ApplicationDescriptor = null;
		ApplicationDescriptorAction = null;
		ApplicationDescriptorActions = null;
		ApplicationValue = application;
		return Self;
	}

	public HasPrivilegesRequestDescriptor Application(Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheckDescriptor descriptor)
	{
		ApplicationValue = null;
		ApplicationDescriptorAction = null;
		ApplicationDescriptorActions = null;
		ApplicationDescriptor = descriptor;
		return Self;
	}

	public HasPrivilegesRequestDescriptor Application(Action<Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheckDescriptor> configure)
	{
		ApplicationValue = null;
		ApplicationDescriptor = null;
		ApplicationDescriptorActions = null;
		ApplicationDescriptorAction = configure;
		return Self;
	}

	public HasPrivilegesRequestDescriptor Application(params Action<Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheckDescriptor>[] configure)
	{
		ApplicationValue = null;
		ApplicationDescriptor = null;
		ApplicationDescriptorAction = null;
		ApplicationDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A list of the cluster privileges that you want to check.
	/// </para>
	/// </summary>
	public HasPrivilegesRequestDescriptor Cluster(ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.ClusterPrivilege>? cluster)
	{
		ClusterValue = cluster;
		return Self;
	}

	public HasPrivilegesRequestDescriptor Index(ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheck>? index)
	{
		IndexDescriptor = null;
		IndexDescriptorAction = null;
		IndexDescriptorActions = null;
		IndexValue = index;
		return Self;
	}

	public HasPrivilegesRequestDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheckDescriptor descriptor)
	{
		IndexValue = null;
		IndexDescriptorAction = null;
		IndexDescriptorActions = null;
		IndexDescriptor = descriptor;
		return Self;
	}

	public HasPrivilegesRequestDescriptor Index(Action<Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheckDescriptor> configure)
	{
		IndexValue = null;
		IndexDescriptor = null;
		IndexDescriptorActions = null;
		IndexDescriptorAction = configure;
		return Self;
	}

	public HasPrivilegesRequestDescriptor Index(params Action<Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheckDescriptor>[] configure)
	{
		IndexValue = null;
		IndexDescriptor = null;
		IndexDescriptorAction = null;
		IndexDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ApplicationDescriptor is not null)
		{
			writer.WritePropertyName("application");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ApplicationDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ApplicationDescriptorAction is not null)
		{
			writer.WritePropertyName("application");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheckDescriptor(ApplicationDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ApplicationDescriptorActions is not null)
		{
			writer.WritePropertyName("application");
			writer.WriteStartArray();
			foreach (var action in ApplicationDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivilegesCheckDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ApplicationValue is not null)
		{
			writer.WritePropertyName("application");
			JsonSerializer.Serialize(writer, ApplicationValue, options);
		}

		if (ClusterValue is not null)
		{
			writer.WritePropertyName("cluster");
			JsonSerializer.Serialize(writer, ClusterValue, options);
		}

		if (IndexDescriptor is not null)
		{
			writer.WritePropertyName("index");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, IndexDescriptor, options);
			writer.WriteEndArray();
		}
		else if (IndexDescriptorAction is not null)
		{
			writer.WritePropertyName("index");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheckDescriptor(IndexDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (IndexDescriptorActions is not null)
		{
			writer.WritePropertyName("index");
			writer.WriteStartArray();
			foreach (var action in IndexDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Security.IndexPrivilegesCheckDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		writer.WriteEndObject();
	}
}