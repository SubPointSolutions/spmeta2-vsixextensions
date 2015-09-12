using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Models;
using M2RootNamespace.Models.SubWebs;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Client;
using SPMeta2.CSOM.Services;
using SPMeta2.SSOM.Services;

namespace M2RootNamespace.Services
{
    public class M2PrjPrefixSSOMProvisionService 
    {
        #region options

        public class Options
        {
            public bool DeploySite { get; set; }
            public bool DeployRootWeb { get; set; }
            public bool DeployHowTosWeb { get; set; }
        }

        #endregion

        #region methods

        public void DeployIntranet(SPSite site)
        {
            DeployIntranet(site, new Options
            {
                DeploySite = true,
                DeployRootWeb = true,
                DeployHowTosWeb = true
            });
        }

        public void DeployIntranet(SPSite site, Options options)
        {
            var provisionService = new SSOMProvisionService();

            // pushing site model
            if (options.DeploySite)
            {
                var siteModel = new M2ProjectPrefixSiteModel();

                provisionService.DeploySiteModel(site, siteModel.GetSandboxSolutionsModel());
                provisionService.DeploySiteModel(site, siteModel.GetSiteFeaturesModel());
                provisionService.DeploySiteModel(site, siteModel.GetSiteSecurityModel());
                provisionService.DeploySiteModel(site, siteModel.GetFieldsAndContentTypesModel());
            }

            // pushing root web model
            if (options.DeployRootWeb)
            {
                var rootWebModel = new M2ProjectPrefixRootWebModel();

                provisionService.DeployWebModel(site.RootWeb, rootWebModel.GetStyleLibraryModel());
                provisionService.DeployWebModel(site.RootWeb, rootWebModel.GetModel());
            }

            // pushing 'How-tow' sub web
            if (options.DeployHowTosWeb)
            {
                var howTosWebModel = new M2PrjPrefixHowTosWebModel();

                provisionService.DeployWebModel(site.RootWeb, howTosWebModel.GetModel());
            }
        }

        #endregion
    }
}
