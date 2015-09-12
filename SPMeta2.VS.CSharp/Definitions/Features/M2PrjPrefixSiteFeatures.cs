using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;
using SPMeta2.Syntax.Default;

namespace M2RootNamespace.Definitions.Features
{
    public static class M2ProjectPrefixSiteFeatures
    {
        // add your site scoped features here as per following samples

        public static FeatureDefinition BasicWebParts = BuiltInSiteFeatures.BasicWebParts.Inherit(def =>
        {
            def.Enable = true;
        });

        #region samples

        ///// <summary>
        ///// Enables custom site scoped feature
        ///// </summary>
        //public static FeatureDefinition CustomSiteFeatureDefinition = new FeatureDefinition
        //{
        //    Id = new Guid("your-feature-guid-here"),
        //    Enable = true,
        //    Scope = FeatureDefinitionScope.Site
        //};

        ///// <summary>
        ///// Enables OOTB SharePointServerPublishingInfrastructure site feature
        ///// </summary>
        //public static FeatureDefinition SitePublishing = BuiltInSiteFeatures.SharePointServerPublishingInfrastructure.Inherit(def =>
        //{
        //    def.Enable = true;
        //});

        ///// <summary>
        ///// Enables document sets
        ///// </summary>
        //public static FeatureDefinition EnableDocumentSets = BuiltInSiteFeatures.DocumentSets.Inherit(def =>
        //{
        //    def.Enable = true;
        //});


        ///// <summary>
        ///// Disables document sets
        ///// </summary>
        //public static FeatureDefinition DisableDocumentSets = BuiltInSiteFeatures.DocumentSets.Inherit(def =>
        //{
        //    def.Enable = false;
        //});

        #endregion
    }
}
