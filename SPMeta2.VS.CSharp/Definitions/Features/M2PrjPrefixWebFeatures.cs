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
    public static class M2ProjectPrefixWebFeatures
    {
        // add your web scoped features here as per following samples

        public static FeatureDefinition DisableMinimalDownloadStrategy = BuiltInWebFeatures.MinimalDownloadStrategy.Inherit(def =>
        {
            def.Enable = false;
        });

        public static FeatureDefinition EnableTeamCollabirationLists = BuiltInWebFeatures.TeamCollaborationLists.Inherit(def =>
        {
            def.Enable = true;
        });

        #region samples

        ///// <summary>
        ///// Enables custom web scoped feature
        ///// </summary>
        //public static FeatureDefinition CustomWebFeatureDefinition = new FeatureDefinition
        //{
        //    Id = new Guid("your-feature-guid-here"),
        //    Enable = true,
        //    Scope = FeatureDefinitionScope.Web
        //};


        ///// <summary>
        ///// Enables OOTB SharePointServerPublishing web feature
        ///// </summary>
        //public static FeatureDefinition WebPublishing = BuiltInWebFeatures.SharePointServerPublishing.Inherit(def =>
        //{
        //    def.Enable = true;
        //});

        ///// <summary>
        ///// Enables MDS
        ///// </summary>
        //public static FeatureDefinition EnableMinimalDownloadStrategy = BuiltInWebFeatures.MinimalDownloadStrategy.Inherit(def =>
        //{
        //    def.Enable = true;
        //});

        ///// <summary>
        ///// Disables MDS
        ///// </summary>
        //public static FeatureDefinition DisableMinimalDownloadStrategy = BuiltInWebFeatures.MinimalDownloadStrategy.Inherit(def =>
        //{
        //    def.Enable = false;
        //});

        ///// <summary>
        ///// Enables OOTb lists and libraries
        ///// </summary>
        //public static FeatureDefinition EnableTeamCollabirationLists = BuiltInWebFeatures.TeamCollaborationLists.Inherit(def =>
        //{
        //    def.Enable = true;
        //});

        #endregion
    }
}
