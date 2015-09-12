using System;
using M2RootNamespace.Models;
using M2RootNamespace.Services;
using Microsoft.SharePoint.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPMeta2.CSOM.Services;

namespace SPMeta2.VS.CSharp.Tests
{
    [TestClass]
    public class IntranetProvisionTests
    {
        #region constructors

        public IntranetProvisionTests()
        {
            SiteUrl = "http://dev42/sites/m2";
        }

        #endregion

        #region props

        public string SiteUrl { get; set; }

        #endregion

        #region tests

        [TestMethod]
        [TestCategory("SPMeta2.VS.CSharp.Site")]
        public void CanProvisionIntranet_SiteModel()
        {
            WithCSOMContext(context =>
            {
                var siteModel = new M2ProjectPrefixSiteModel();
                var rootWebModel = new M2ProjectPrefixRootWebModel();

                var provisionService = new CSOMProvisionService();

                // site
                provisionService.DeploySiteModel(context, siteModel.GetSiteFeaturesModel());
                provisionService.DeploySiteModel(context, siteModel.GetUserCustomActionModel());
                provisionService.DeploySiteModel(context, siteModel.GetSiteSecurityModel());

                provisionService.DeploySiteModel(context, siteModel.GetFieldsAndContentTypesModel());
                provisionService.DeploySiteModel(context, siteModel.GetSandboxSolutionsModel());

                // root web
                provisionService.DeployWebModel(context, rootWebModel.GetStyleLibraryModel());
                provisionService.DeployWebModel(context, rootWebModel.GetModel());
            });
        }

        [TestMethod]
        [TestCategory("SPMeta2.VS.CSharp.Site")]
        public void CanProvisionIntranet_SiteModel_FromService()
        {
            WithCSOMContext(context =>
            {
                var intranetProvisionService = new M2ProjectPrefixCSOMProvisionService();

                intranetProvisionService.DeployIntranet(context);
            });
        }

        #endregion

        #region utils
        private void WithCSOMContext(Action<ClientContext> action)
        {
            WithCSOMContext(SiteUrl, action);
        }

        private void WithCSOMContext(string siteUrl, Action<ClientContext> action)
        {
            using (var context = new ClientContext(siteUrl))
            {
                action(context);
            }
        }
        #endregion
    }
}
