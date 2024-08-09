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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless.Esql;

public partial class EsqlNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>
	/// Initializes a new instance of the <see cref="EsqlNamespacedClient"/> class for mocking.
	/// </para>
	/// </summary>
	protected EsqlNamespacedClient() : base()
	{
	}

	internal EsqlNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>
	/// Executes an ES|QL request
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.14/esql-rest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EsqlQueryResponse> QueryAsync(EsqlQueryRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<EsqlQueryRequest, EsqlQueryResponse, EsqlQueryRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Executes an ES|QL request
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.14/esql-rest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EsqlQueryResponse> QueryAsync<TDocument>(EsqlQueryRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<EsqlQueryRequestDescriptor<TDocument>, EsqlQueryResponse, EsqlQueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Executes an ES|QL request
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.14/esql-rest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EsqlQueryResponse> QueryAsync<TDocument>(CancellationToken cancellationToken = default)
	{
		var descriptor = new EsqlQueryRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequestAsync<EsqlQueryRequestDescriptor<TDocument>, EsqlQueryResponse, EsqlQueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Executes an ES|QL request
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.14/esql-rest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EsqlQueryResponse> QueryAsync<TDocument>(Action<EsqlQueryRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new EsqlQueryRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<EsqlQueryRequestDescriptor<TDocument>, EsqlQueryResponse, EsqlQueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Executes an ES|QL request
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.14/esql-rest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EsqlQueryResponse> QueryAsync(EsqlQueryRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<EsqlQueryRequestDescriptor, EsqlQueryResponse, EsqlQueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Executes an ES|QL request
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.14/esql-rest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EsqlQueryResponse> QueryAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new EsqlQueryRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<EsqlQueryRequestDescriptor, EsqlQueryResponse, EsqlQueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Executes an ES|QL request
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.14/esql-rest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EsqlQueryResponse> QueryAsync(Action<EsqlQueryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new EsqlQueryRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<EsqlQueryRequestDescriptor, EsqlQueryResponse, EsqlQueryRequestParameters>(descriptor, cancellationToken);
	}
}