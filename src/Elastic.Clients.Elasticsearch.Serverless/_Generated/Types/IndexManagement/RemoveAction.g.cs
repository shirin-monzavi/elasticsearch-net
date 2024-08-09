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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class RemoveAction
{
	/// <summary>
	/// <para>
	/// Alias for the action.
	/// Index alias names support date math.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("alias")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexAlias? Alias { get; set; }

	/// <summary>
	/// <para>
	/// Aliases for the action.
	/// Index alias names support date math.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("aliases")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.Serverless.IndexAlias))]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.IndexAlias>? Aliases { get; set; }

	/// <summary>
	/// <para>
	/// Data stream or index for the action.
	/// Supports wildcards (<c>*</c>).
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexName? Index { get; set; }

	/// <summary>
	/// <para>
	/// Data streams or indices for the action.
	/// Supports wildcards (<c>*</c>).
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("indices")]
	public Elastic.Clients.Elasticsearch.Serverless.Indices? Indices { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the alias must exist to perform the action.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("must_exist")]
	public bool? MustExist { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexUpdateAliasesAction(RemoveAction removeAction) => Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexUpdateAliasesAction.Remove(removeAction);
}

public sealed partial class RemoveActionDescriptor : SerializableDescriptor<RemoveActionDescriptor>
{
	internal RemoveActionDescriptor(Action<RemoveActionDescriptor> configure) => configure.Invoke(this);

	public RemoveActionDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.IndexAlias? AliasValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.IndexAlias>? AliasesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexName? IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Indices? IndicesValue { get; set; }
	private bool? MustExistValue { get; set; }

	/// <summary>
	/// <para>
	/// Alias for the action.
	/// Index alias names support date math.
	/// </para>
	/// </summary>
	public RemoveActionDescriptor Alias(Elastic.Clients.Elasticsearch.Serverless.IndexAlias? alias)
	{
		AliasValue = alias;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Aliases for the action.
	/// Index alias names support date math.
	/// </para>
	/// </summary>
	public RemoveActionDescriptor Aliases(ICollection<Elastic.Clients.Elasticsearch.Serverless.IndexAlias>? aliases)
	{
		AliasesValue = aliases;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Data stream or index for the action.
	/// Supports wildcards (<c>*</c>).
	/// </para>
	/// </summary>
	public RemoveActionDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Data streams or indices for the action.
	/// Supports wildcards (<c>*</c>).
	/// </para>
	/// </summary>
	public RemoveActionDescriptor Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		IndicesValue = indices;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, the alias must exist to perform the action.
	/// </para>
	/// </summary>
	public RemoveActionDescriptor MustExist(bool? mustExist = true)
	{
		MustExistValue = mustExist;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AliasValue is not null)
		{
			writer.WritePropertyName("alias");
			JsonSerializer.Serialize(writer, AliasValue, options);
		}

		if (AliasesValue is not null)
		{
			writer.WritePropertyName("aliases");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Serverless.IndexAlias>(AliasesValue, writer, options);
		}

		if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (IndicesValue is not null)
		{
			writer.WritePropertyName("indices");
			JsonSerializer.Serialize(writer, IndicesValue, options);
		}

		if (MustExistValue.HasValue)
		{
			writer.WritePropertyName("must_exist");
			writer.WriteBooleanValue(MustExistValue.Value);
		}

		writer.WriteEndObject();
	}
}