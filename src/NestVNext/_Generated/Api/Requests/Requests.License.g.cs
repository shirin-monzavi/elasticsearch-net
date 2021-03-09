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
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;

namespace Nest
{
    public interface IDeleteLicenseRequest : IRequest<DeleteLicenseRequestParameters>
    {
    }

    public class DeleteLicenseRequest : PlainRequestBase<DeleteLicenseRequestParameters>, IDeleteLicenseRequest
    {
        protected IDeleteLicenseRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseDelete;
        protected override HttpMethod HttpMethod => HttpMethod.DELETE;
        protected override bool SupportsBody => false;
    }

    public interface IGetBasicLicenseStatusRequest : IRequest<GetBasicLicenseStatusRequestParameters>
    {
    }

    public class GetBasicLicenseStatusRequest : PlainRequestBase<GetBasicLicenseStatusRequestParameters>, IGetBasicLicenseStatusRequest
    {
        protected IGetBasicLicenseStatusRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseGetBasicStatus;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IGetLicenseRequest : IRequest<GetLicenseRequestParameters>
    {
    }

    public class GetLicenseRequest : PlainRequestBase<GetLicenseRequestParameters>, IGetLicenseRequest
    {
        protected IGetLicenseRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseGet;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IGetTrialLicenseStatusRequest : IRequest<GetTrialLicenseStatusRequestParameters>
    {
    }

    public class GetTrialLicenseStatusRequest : PlainRequestBase<GetTrialLicenseStatusRequestParameters>, IGetTrialLicenseStatusRequest
    {
        protected IGetTrialLicenseStatusRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseGetTrialStatus;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IPostLicenseRequest : IRequest<PostLicenseRequestParameters>
    {
    }

    public class PostLicenseRequest : PlainRequestBase<PostLicenseRequestParameters>, IPostLicenseRequest
    {
        protected IPostLicenseRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.LicensePost;
        protected override HttpMethod HttpMethod => HttpMethod.PUT;
        protected override bool SupportsBody => false;
    }

    public interface IStartBasicLicenseRequest : IRequest<StartBasicLicenseRequestParameters>
    {
    }

    public class StartBasicLicenseRequest : PlainRequestBase<StartBasicLicenseRequestParameters>, IStartBasicLicenseRequest
    {
        protected IStartBasicLicenseRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.LicensePostStartBasic;
        protected override HttpMethod HttpMethod => HttpMethod.POST;
        protected override bool SupportsBody => false;
    }

    public interface IStartTrialLicenseRequest : IRequest<StartTrialLicenseRequestParameters>
    {
    }

    public class StartTrialLicenseRequest : PlainRequestBase<StartTrialLicenseRequestParameters>, IStartTrialLicenseRequest
    {
        protected IStartTrialLicenseRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.LicensePostStartTrial;
        protected override HttpMethod HttpMethod => HttpMethod.POST;
        protected override bool SupportsBody => false;
    }
}