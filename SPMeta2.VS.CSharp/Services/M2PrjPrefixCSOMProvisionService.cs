using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Models;
using M2RootNamespace.Models.SubWebs;
using Microsoft.SharePoint.Client;
using SPMeta2.CSOM.Services;

namespace M2RootNamespace.Services
{
    public class M2ProjectPrefixCSOMProvisionService 
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

        public void DeployIntranet(ClientContext context)
        {
            DeployIntranet(context, new Options
            {
                DeploySite = true,
                DeployRootWeb = true,
                DeployHowTosWeb = true
            });
        }

        public void DeployIntranet(ClientContext context, Options options)
        {
            var provisionService = new CSOMProvisionService();

            // pushing site model
            if (options.DeploySite)
            {
                var siteModel = new M2ProjectPrefixSiteModel();

                provisionService.DeploySiteModel(context, siteModel.GetSiteFeaturesModel());
                provisionService.DeploySiteModel(context, siteModel.GetUserCustomActionModel());
                provisionService.DeploySiteModel(context, siteModel.GetSiteSecurityModel());

                provisionService.DeploySiteModel(context, siteModel.GetFieldsAndContentTypesModel());
                provisionService.DeploySiteModel(context, siteModel.GetSandboxSolutionsModel());
            }

            // pushing root web model
            if (options.DeployRootWeb)
            {
                var rootWebModel = new M2ProjectPrefixRootWebModel();

                provisionService.DeployWebModel(context, rootWebModel.GetStyleLibraryModel());
                provisionService.DeployWebModel(context, rootWebModel.GetModel());
            }

            // pushing 'How-tow' sub web
            if (options.DeployHowTosWeb)
            {
                var howTosWebModel = new M2PrjPrefixHowTosWebModel();
                provisionService.DeployWebModel(context, howTosWebModel.GetModel());
            }
        }

        #endregion
    }
}
