using Microsoft.SharePoint;
using SPMeta2.SSOM.Standard.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Models;
using M2RootNamespace.Models.SubWebs;
using Microsoft.SharePoint.Client;
using SPMeta2.CSOM.Services;
using SPMeta2.CSOM.Standard.Services;
using SPMeta2.SSOM.Services;

namespace M2RootNamespace.Services
{
    // put your provision service here in case you use SSOM/CSOM in the same assembly

    // Use CSOMProvisionService / SSOMProvisionService for foundation models
    // Use StandardCSOMProvisionService / StandardSSOMProvisionService found standard+ models

    // Consider DeploySiteModel() and DeployWebModel() extension methods 
    // Consider boolean flags to turn on/off some bits of provision

    public class M2ProjectPrefixProvisionService
    {
        #region samples

        ///// <summary>
        ///// SSOM provision sample.
        ///// 
        ///// Consider if-flags driven by config or options to proviison needed bit of the model.
        ///// Consider splitting up provision into several functions to improve maintability.
        ///// </summary>
        ///// <param name="site"></param>
        //public void DeployIntranetViaSSOM(SPSite site)
        //{
        //    var siteModel = new M2ProjectPrefixSiteModel();
        //    var rootWebModel = new M2ProjectPrefixRootWebModel();
        //    var customerWebModel = new M2PrjPrefixCustomerWebModel();

        //    var provisionService = new StandardSSOMProvisionService();

        //    // pushing site model
        //    provisionService.DeploySiteModel(site, siteModel.GetSandboxSolutionsModel());
        //    provisionService.DeploySiteModel(site, siteModel.GetSiteFeaturesModel());
        //    provisionService.DeploySiteModel(site, siteModel.GetSiteSecurityModel());
        //    provisionService.DeploySiteModel(site, siteModel.GetFieldsAndContentTypesModel());

        //    // pushing root web model
        //    provisionService.DeployWebModel(site.RootWeb, rootWebModel.GetWebFeaturesModel());
        //    provisionService.DeployWebModel(site.RootWeb, rootWebModel.GetStyleLibraryModel());

        //    // pushing sun web, customer web model
        //    provisionService.DeployWebModel(site.RootWeb, customerWebModel.GetModel());
        //}

        ///// <summary>
        ///// SSOM provision sample.
        ///// 
        ///// Consider if-flags driven by config or options to proviison needed bit of the model.
        ///// Consider splitting up provision into several functions to improve maintability.
        ///// </summary>
        ///// <param name="site"></param>
        //public void DeployIntranetViaCSOM(ClientContext context)
        //{
        //    var siteModel = new M2ProjectPrefixSiteModel();
        //    var rootWebModel = new M2ProjectPrefixRootWebModel();
        //    var customerWebModel = new M2PrjPrefixCustomerWebModel();

        //    var provisionService = new StandardCSOMProvisionService();

        //    // pushing site model
        //    provisionService.DeploySiteModel(context, siteModel.GetSandboxSolutionsModel());
        //    provisionService.DeploySiteModel(context, siteModel.GetSiteFeaturesModel());
        //    provisionService.DeploySiteModel(context, siteModel.GetSiteSecurityModel());
        //    provisionService.DeploySiteModel(context, siteModel.GetFieldsAndContentTypesModel());

        //    // pushing root web model
        //    provisionService.DeployWebModel(context, rootWebModel.GetWebFeaturesModel());
        //    provisionService.DeployWebModel(context, rootWebModel.GetStyleLibraryModel());

        //    // pushing sun web, customer web model
        //    provisionService.DeployWebModel(context, customerWebModel.GetModel());
        //}

        #endregion
    }
}
