using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Consts;
using M2RootNamespace.Definitions.Features;
using SPMeta2.BuiltInDefinitions;
using SPMeta2.Extensions;
using SPMeta2.Models;
using SPMeta2.Syntax.Default;
using SPMeta2.Syntax.Default.Utils;

namespace M2RootNamespace.Models
{
    /// <summary>
    /// Describes the root web.
    /// 
    /// The main responcibility is to describe and separate what needs to be deployed on the root web level:
    /// - web features
    /// - style library provision
    /// - anything else
    /// 
    /// Construct your model using AddXXX() or AddHostXXX() syntax.
    /// If you have bunch of the 'plain' things to push, then use .AddDefinitionsFromStaticClassType() method.
    /// 
    /// It is a good idea to avoid big model preferring small model per every reasonable operation.
    /// The final artifact separation and grouping is tootally up to you and your prpoject needs.
    /// 
    /// 
    /// Read more here - http://docs.subpointsolutions.com/spmeta2/models/
    /// </summary>
    public class M2ProjectPrefixRootWebModel
    {
        public ModelNode GetWebFeaturesModel()
        {
            var model = SPMeta2Model.NewWebModel(web =>
            {
                // either use AddXXX() or just import everything with .AddDefinitionsFromStaticClassType() 

                //web.AddWebFeature(M2ProjectPrefixWebFeatures.DisableMinimalDownloadStrategy);
                //web.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixSiteFeatures));
            });

            return model;
        }

        public ModelNode GetStyleLibraryModel()
        {
            var webModel = SPMeta2Model.NewWebModel(rootWeb =>
            {
                //// AddHostList() to indicate that we don't provision list, but just look it up
                //rootWeb.AddHostList(BuiltInListDefinitions.StyleLibrary, list =>
                //{
                //    //LoadModuleFilesFromLocalFolder() helper gets everything from the local folder
                //    //and creates a new M2 model full of folders/module files

                //    //everything you have in M2ProjectPrefixConsts.DefaultStyleLibraryPath
                //    //will be pushed to 'Style Library' back to back

                //    if (Directory.Exists(M2ProjectPrefixConsts.DefaultStyleLibraryPath))
                //        ModuleFileUtils.LoadModuleFilesFromLocalFolder(list, M2ProjectPrefixConsts.DefaultStyleLibraryPath);
                //});
            });

            return webModel;
        }
    }
}
