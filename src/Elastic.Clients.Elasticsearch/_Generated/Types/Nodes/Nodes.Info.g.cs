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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Nodes.Info
{
	public partial class NodeInfo
	{
		[JsonPropertyName("aggregations")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoAggregation>? Aggregations
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("attributes")]
		public Dictionary<string, string> Attributes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("build_flavor")]
		public string BuildFlavor
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("build_hash")]
		public string BuildHash
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("build_type")]
		public string BuildType
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("host")]
		public Elastic.Clients.Elasticsearch.Host Host
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("http")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoHttp? Http
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ingest")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoIngest? Ingest
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ip")]
		public Elastic.Clients.Elasticsearch.Ip Ip
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("jvm")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeJvmInfo? Jvm
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("modules")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.PluginStats>? Modules
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("network")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoNetwork? Network
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("os")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeOperatingSystemInfo? Os
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("plugins")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.PluginStats>? Plugins
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("process")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeProcessInfo? Process
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("roles")]
		public Elastic.Clients.Elasticsearch.NodeRoles Roles
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("settings")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSettings? Settings
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("thread_pool")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Nodes.Info.NodeThreadPoolInfo>? ThreadPool
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_indexing_buffer")]
		public long? TotalIndexingBuffer
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_indexing_buffer_in_bytes")]
		public Elastic.Clients.Elasticsearch.ByteSize? TotalIndexingBufferInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transport")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoTransport? Transport
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transport_address")]
		public Elastic.Clients.Elasticsearch.TransportAddress TransportAddress
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionString Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoAction
	{
		[JsonPropertyName("destructive_requires_name")]
		public string DestructiveRequiresName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoAggregation
	{
		[JsonPropertyName("types")]
		public IReadOnlyCollection<string> Types
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoBootstrap
	{
		[JsonPropertyName("memory_lock")]
		public string MemoryLock
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoClient
	{
		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoDiscover
	{
		[JsonPropertyName("seed_hosts")]
		public string SeedHosts
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoHttp
	{
		[JsonPropertyName("bound_address")]
		public IReadOnlyCollection<string> BoundAddress
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_content_length")]
		public Elastic.Clients.Elasticsearch.ByteSize? MaxContentLength
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_content_length_in_bytes")]
		public long MaxContentLengthInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("publish_address")]
		public string PublishAddress
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoIngest
	{
		[JsonPropertyName("processors")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoIngestProcessor> Processors
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoIngestProcessor
	{
		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoJvmMemory
	{
		[JsonPropertyName("direct_max")]
		public Elastic.Clients.Elasticsearch.ByteSize? DirectMax
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("direct_max_in_bytes")]
		public long DirectMaxInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("heap_init")]
		public Elastic.Clients.Elasticsearch.ByteSize? HeapInit
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("heap_init_in_bytes")]
		public long HeapInitInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("heap_max")]
		public Elastic.Clients.Elasticsearch.ByteSize? HeapMax
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("heap_max_in_bytes")]
		public long HeapMaxInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("non_heap_init")]
		public Elastic.Clients.Elasticsearch.ByteSize? NonHeapInit
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("non_heap_init_in_bytes")]
		public long NonHeapInitInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("non_heap_max")]
		public Elastic.Clients.Elasticsearch.ByteSize? NonHeapMax
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("non_heap_max_in_bytes")]
		public long NonHeapMaxInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoMemory
	{
		[JsonPropertyName("total")]
		public string Total
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_in_bytes")]
		public long TotalInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoNetwork
	{
		[JsonPropertyName("primary_interface")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoNetworkInterface PrimaryInterface
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("refresh_interval")]
		public int RefreshInterval
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoNetworkInterface
	{
		[JsonPropertyName("address")]
		public string Address
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("mac_address")]
		public string MacAddress
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoOSCPU
	{
		[JsonPropertyName("cache_size")]
		public string CacheSize
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cache_size_in_bytes")]
		public int CacheSizeInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cores_per_socket")]
		public int CoresPerSocket
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("mhz")]
		public int Mhz
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("model")]
		public string Model
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_cores")]
		public int TotalCores
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_sockets")]
		public int TotalSockets
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("vendor")]
		public string Vendor
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoPath
	{
		[JsonPropertyName("data")]
		public IReadOnlyCollection<string>? Data
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("home")]
		public string Home
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("logs")]
		public string Logs
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("repo")]
		public IReadOnlyCollection<string> Repo
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoRepositories
	{
		[JsonPropertyName("url")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoRepositoriesUrl Url
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoRepositoriesUrl
	{
		[JsonPropertyName("allowed_urls")]
		public string AllowedUrls
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoScript
	{
		[JsonPropertyName("allowed_types")]
		public string AllowedTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("disable_max_compilations_rate")]
		public string DisableMaxCompilationsRate
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSearch
	{
		[JsonPropertyName("remote")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSearchRemote Remote
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSearchRemote
	{
		[JsonPropertyName("connect")]
		public string Connect
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSettings
	{
		[JsonPropertyName("action")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoAction? Action
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("bootstrap")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoBootstrap? Bootstrap
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("client")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoClient Client
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cluster")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSettingsCluster Cluster
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("discovery")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoDiscover? Discovery
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("http")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSettingsHttp Http
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("network")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSettingsNetwork? Network
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSettingsNode Node
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("path")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoPath Path
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("repositories")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoRepositories? Repositories
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoScript? Script
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("search")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSearch? Search
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transport")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSettingsTransport Transport
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("xpack")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpack? Xpack
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSettingsCluster
	{
		[JsonPropertyName("election")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSettingsClusterElection Election
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("initial_master_nodes")]
		public string? InitialMasterNodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("routing")]
		public Elastic.Clients.Elasticsearch.IndexManagement.IndexRouting? Routing
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSettingsClusterElection
	{
		[JsonPropertyName("strategy")]
		public Elastic.Clients.Elasticsearch.Name Strategy
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSettingsHttp
	{
		[JsonPropertyName("compression")]
		public Union<bool, string>? Compression
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("port")]
		public Union<int, string>? Port
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public Union<string, Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSettingsHttpType> Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type.default")]
		public string? TypeDefault
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSettingsHttpType
	{
		[JsonPropertyName("default")]
		public string Default
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSettingsNetwork
	{
		[JsonPropertyName("host")]
		public Elastic.Clients.Elasticsearch.Host Host
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSettingsNode
	{
		[JsonPropertyName("attr")]
		public Dictionary<string, object> Attr
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_local_storage_nodes")]
		public string? MaxLocalStorageNodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSettingsTransport
	{
		[JsonPropertyName("features")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSettingsTransportFeatures? Features
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public Union<string, Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoSettingsTransportType> Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type.default")]
		public string? TypeDefault
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSettingsTransportFeatures
	{
		[JsonPropertyName("x-pack")]
		public string XPack
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoSettingsTransportType
	{
		[JsonPropertyName("default")]
		public string Default
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoTransport
	{
		[JsonPropertyName("bound_address")]
		public IReadOnlyCollection<string> BoundAddress
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("profiles")]
		public Dictionary<string, string> Profiles
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("publish_address")]
		public string PublishAddress
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoXpack
	{
		[JsonPropertyName("license")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackLicense? License
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("notification")]
		public Dictionary<string, object>? Notification
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("security")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackSecurity Security
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoXpackLicense
	{
		[JsonPropertyName("self_generated")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackLicenseType SelfGenerated
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoXpackLicenseType
	{
		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoXpackSecurity
	{
		[JsonPropertyName("authc")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackSecurityAuthc? Authc
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("enabled")]
		public string Enabled
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("http")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackSecuritySsl Http
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transport")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackSecuritySsl Transport
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoXpackSecurityAuthc
	{
		[JsonPropertyName("realms")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackSecurityAuthcRealms Realms
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("token")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackSecurityAuthcToken Token
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoXpackSecurityAuthcRealms
	{
		[JsonPropertyName("file")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackSecurityAuthcRealmsStatus>? File
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("native")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackSecurityAuthcRealmsStatus>? Native
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pki")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoXpackSecurityAuthcRealmsStatus>? Pki
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoXpackSecurityAuthcRealmsStatus
	{
		[JsonPropertyName("enabled")]
		public string? Enabled
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("order")]
		public string Order
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoXpackSecurityAuthcToken
	{
		[JsonPropertyName("enabled")]
		public string Enabled
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeInfoXpackSecuritySsl
	{
		[JsonPropertyName("ssl")]
		public Dictionary<string, string> Ssl
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeJvmInfo
	{
		[JsonPropertyName("bundled_jdk")]
		public bool BundledJdk
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("gc_collectors")]
		public IReadOnlyCollection<string> GcCollectors
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("input_arguments")]
		public IReadOnlyCollection<string> InputArguments
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("mem")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoJvmMemory Mem
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("memory_pools")]
		public IReadOnlyCollection<string> MemoryPools
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pid")]
		public int Pid
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("start_time_in_millis")]
		public long StartTimeInMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("using_bundled_jdk")]
		public bool UsingBundledJdk
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("using_compressed_ordinary_object_pointers")]
		public Union<bool, string>? UsingCompressedOrdinaryObjectPointers
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionString Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("vm_name")]
		public Elastic.Clients.Elasticsearch.Name VmName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("vm_vendor")]
		public string VmVendor
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("vm_version")]
		public Elastic.Clients.Elasticsearch.VersionString VmVersion
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeOperatingSystemInfo
	{
		[JsonPropertyName("allocated_processors")]
		public int? AllocatedProcessors
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("arch")]
		public string Arch
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("available_processors")]
		public int AvailableProcessors
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cpu")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoOSCPU? Cpu
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("mem")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoMemory? Mem
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pretty_name")]
		public Elastic.Clients.Elasticsearch.Name PrettyName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("refresh_interval_in_millis")]
		public int RefreshIntervalInMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("swap")]
		public Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfoMemory? Swap
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionString Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeProcessInfo
	{
		[JsonPropertyName("id")]
		public long Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("mlockall")]
		public bool Mlockall
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("refresh_interval_in_millis")]
		public long RefreshIntervalInMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeThreadPoolInfo
	{
		[JsonPropertyName("core")]
		public int? Core
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("keep_alive")]
		public string? KeepAlive
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max")]
		public int? Max
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("queue_size")]
		public int QueueSize
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("size")]
		public int? Size
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}