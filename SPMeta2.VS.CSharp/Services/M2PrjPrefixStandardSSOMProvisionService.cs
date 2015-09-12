using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Models;
using M2RootNamespace.Models.SubWebs;
using Microsoft.SharePoint;
using SPMeta2.SSOM.Services;
using SPMeta2.SSOM.Standard.Services;

namespace M2RootNamespace.Services
{
    public class M2ProjectPrefixStandardSSOMProvisionService : StandardSSOMProvisionService
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
            // pushing site model
            if (options.DeploySite)
            {
                var siteModel = new M2ProjectPrefixSiteModel();

                this.DeploySiteModel(site, siteModel.GetSandboxSolutionsModel());
                this.DeploySiteModel(site, siteModel.GetSiteFeaturesModel());
                this.DeploySiteModel(site, siteModel.GetSiteSecurityModel());
                this.DeploySiteModel(site, siteModel.GetFieldsAndContentTypesModel());
            }

            // pushing root web model
            if (options.DeployRootWeb)
            {
                var rootWebModel = new M2ProjectPrefixRootWebModel();

                this.DeployWebModel(site.RootWeb, rootWebModel.GetStyleLibraryModel());
                this.DeployWebModel(site.RootWeb, rootWebModel.GetModel());
            }

            // pushing 'How-tow' sub web
            if (options.DeployHowTosWeb)
            {
                var howTosWebModel = new M2ProjectPrefixHowTosWebModel();

                this.DeployWebModel(site.RootWeb, howTosWebModel.GetModel());
            }
        }

        #endregion
    }
}
