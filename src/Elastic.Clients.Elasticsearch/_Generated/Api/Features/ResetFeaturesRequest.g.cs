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

namespace Elastic.Clients.Elasticsearch.Features;

public sealed partial class ResetFeaturesRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Resets the internal state of features, usually by deleting system indices
/// </para>
/// </summary>
public sealed partial class ResetFeaturesRequest : PlainRequest<ResetFeaturesRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.FeaturesResetFeatures;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "features.reset_features";
}

/// <summary>
/// <para>
/// Resets the internal state of features, usually by deleting system indices
/// </para>
/// </summary>
public sealed partial class ResetFeaturesRequestDescriptor : RequestDescriptor<ResetFeaturesRequestDescriptor, ResetFeaturesRequestParameters>
{
	internal ResetFeaturesRequestDescriptor(Action<ResetFeaturesRequestDescriptor> configure) => configure.Invoke(this);

	public ResetFeaturesRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.FeaturesResetFeatures;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "features.reset_features";

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}