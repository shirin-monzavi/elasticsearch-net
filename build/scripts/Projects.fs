﻿namespace Scripts

[<AutoOpen>]
module Projects = 
    type DotNetFrameworkIdentifier = { MSBuild: string; Nuget: string; DefineConstants: string; }

    type DotNetFramework = 
        | NetStandard2_0
        | Net461
        | NetCoreApp3_0
        static member All = [NetStandard2_0; Net461]
        static member AllTests = [NetCoreApp3_0; Net461] 
        member this.Identifier = 
            match this with
            | NetStandard2_0 -> { MSBuild = "netstandard2.0"; Nuget = "netstandard2.0"; DefineConstants = ""; }
            | NetCoreApp3_0 -> { MSBuild = "netcoreapp3.0"; Nuget = "netcoreapp3.0"; DefineConstants = ""; }
            | Net461 -> { MSBuild = "net461"; Nuget = "net461"; DefineConstants = ""; }

    type Project =
        | Nest
        | ElasticsearchNet
        | NestJsonNetSerializer
        
    type PrivateProject =
        | Tests
        | DocGenerator
        
    type DependencyProject = 
        | JsonNet 

    type DotNetProject = 
        | Project of Project
        | PrivateProject of PrivateProject
        | DepencyProject of DependencyProject

        static member All = 
            seq [
                Project Project.ElasticsearchNet; 
                Project Project.Nest; 
                PrivateProject PrivateProject.Tests
            ]

        static member AllPublishable = 
            seq [
                Project Project.ElasticsearchNet; 
                Project Project.Nest; 
                Project Project.NestJsonNetSerializer;
            ] 
        static member Tests = seq [PrivateProject PrivateProject.Tests]
        
        member this.MergeDependencies=
            match this with 
            | Project Nest -> [Project Project.Nest; DepencyProject DependencyProject.JsonNet]
            | _ -> []

        member this.VersionedMergeDependencies =
            match this with 
            | Project Nest -> [Project Project.Nest; Project Project.ElasticsearchNet; DepencyProject DependencyProject.JsonNet]
            | Project NestJsonNetSerializer -> [Project NestJsonNetSerializer; Project Project.Nest; Project Project.ElasticsearchNet ]
            | Project ElasticsearchNet -> [Project ElasticsearchNet]
            | _ -> []

        member this.Name =
            match this with
            | Project Nest -> "Nest"
            | Project ElasticsearchNet -> "Elasticsearch.Net"
            | Project NestJsonNetSerializer -> "Nest.JsonNetSerializer"
            | PrivateProject Tests -> "Tests"
            | PrivateProject DocGenerator -> "DocGenerator"
            | DepencyProject JsonNet -> "Newtonsoft.Json"
 
        member this.NugetId =
            match this with
            | Project Nest -> "NEST"
            | Project NestJsonNetSerializer -> "NEST.JsonNetSerializer"
            | _ -> this.Name
        
        member this.NeedsMerge = match this with | Project NestJsonNetSerializer -> false | _ -> true
                
        member this.Versioned name version =
            match version with
            | Some s -> sprintf "%s%s" name s
            | None -> name
            
        member this.InternalName =
            match this with
            | Project _ -> this.Name 
            | PrivateProject _ -> sprintf "Elastic.Internal.%s" this.Name
            | DepencyProject JsonNet -> "Elastic.Internal.JsonNet"
                
        static member TryFindName (name: string) =
            DotNetProject.All
            |> Seq.map(fun p -> p.Name)
            |> Seq.tryFind(fun p -> p.ToLowerInvariant() = name.ToLowerInvariant())

    type DotNetFrameworkProject = { framework: DotNetFramework; project: DotNetProject }
    let AllPublishableProjectsWithSupportedFrameworks = seq {
        for framework in DotNetFramework.All do
        for project in DotNetProject.AllPublishable do
            yield { framework = framework; project= project}
        }
