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

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ccr.FollowInfo
{
	[JsonConverter(typeof(FollowerIndexStatusConverter))]
	public enum FollowerIndexStatus
	{
		[EnumMember(Value = "paused")]
		Paused,
		[EnumMember(Value = "active")]
		Active
	}

	internal sealed class FollowerIndexStatusConverter : JsonConverter<FollowerIndexStatus>
	{
		public override FollowerIndexStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "paused":
					return FollowerIndexStatus.Paused;
				case "active":
					return FollowerIndexStatus.Active;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, FollowerIndexStatus value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case FollowerIndexStatus.Paused:
					writer.WriteStringValue("paused");
					return;
				case FollowerIndexStatus.Active:
					writer.WriteStringValue("active");
					return;
			}

			writer.WriteNullValue();
		}
	}
}