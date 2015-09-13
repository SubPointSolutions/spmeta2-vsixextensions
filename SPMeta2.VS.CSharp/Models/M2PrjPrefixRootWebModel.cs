using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Consts;
using M2RootNamespace.Definitions.Features;
using M2RootNamespace.Definitions.IA;
using M2RootNamespace.Definitions.Navigation;
using M2RootNamespace.Definitions.Pages;
using M2RootNamespace.Definitions.UI;
using SPMeta2.BuiltInDefinitions;
using SPMeta2.Extensions;
using SPMeta2.Models;
using SPMeta2.Syntax.Default;
using SPMeta2.Syntax.Default.Utils;
using SPMeta2.VS.CSharp.Extensions;

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
        public ModelNode GetModel()
        {
            var model = SPMeta2Model.NewWebModel(web =>
            {
                web
                    .AddWebFeature(M2ProjectPrefixWebFeatures.DisableMinimalDownloadStrategy)
                    .AddWebFeature(M2ProjectPrefixWebFeatures.EnableTeamCollabirationLists)
                    .AddWebFeature(M2ProjectPrefixWebFeatures.WikiPageHomePage)

                    .AddTopNavigationNode(M2ProjectPrefixTopNavigationNodes.CompanyDocuments)
                    .AddTopNavigationNode(M2ProjectPrefixTopNavigationNodes.SaleTasks)
                    .AddTopNavigationNode(M2ProjectPrefixTopNavigationNodes.SaleEvents)
                    .AddTopNavigationNode(M2ProjectPrefixTopNavigationNodes.AboutThisSite)

                    .AddQuickLaunchNavigationNode(M2ProjectPrefixQuickNavigationNodes.CompanyDocuments)
                    .AddQuickLaunchNavigationNode(M2ProjectPrefixQuickNavigationNodes.Services)
                    .AddQuickLaunchNavigationNode(M2ProjectPrefixQuickNavigationNodes.Orders)
                    .AddQuickLaunchNavigationNode(M2ProjectPrefixQuickNavigationNodes.SaleTasks)
                    .AddQuickLaunchNavigationNode(M2ProjectPrefixQuickNavigationNodes.SaleEvents)
                    .AddQuickLaunchNavigationNode(M2ProjectPrefixQuickNavigationNodes.AboutThisSite)

                    .AddList(M2ProjectPrefixLists.CompanyDocuments, list =>
                    {
                        list
                            .AddContentTypeLink(M2ProjectPrefixContentTypes.CompanyDocument)
                            .AddContentTypeLink(M2ProjectPrefixContentTypes.SalesProposal)
                            .AddContentTypeLink(M2ProjectPrefixContentTypes.ProductDocument)

                            .AddListView(M2ProjectPrefixListViews.LastTenDocuments)
                            .AddListView(M2ProjectPrefixListViews.LastTenDocumentsMainPage)

                            .M2ProjectPrefixSetDefaultListContentType(M2ProjectPrefixContentTypes.CompanyDocument);
                    })
                    .AddList(M2ProjectPrefixLists.Orders, list =>
                    {
                        list
                            .AddContentTypeLink(M2ProjectPrefixContentTypes.OrderDocument)
                            .AddListView(M2ProjectPrefixListViews.Last25Orders)
                            .AddListView(M2ProjectPrefixListViews.Last10OrdersMainPage)

                            .M2ProjectPrefixSetDefaultListContentType(M2ProjectPrefixContentTypes.OrderDocument);
                    })
                    .AddList(M2ProjectPrefixLists.Services, list =>
                    {
                        list
                            .AddContentTypeLink(M2ProjectPrefixContentTypes.ProductOrService)
                            .AddListView(M2ProjectPrefixListViews.AllProducts)
                            .AddListView(M2ProjectPrefixListViews.LastTenServices)

                            .M2ProjectPrefixSetDefaultListContentType(M2ProjectPrefixContentTypes.ProductOrService);
                    })
                    .AddList(M2ProjectPrefixLists.SalesTasks, list =>
                    {

                    })
                    .AddList(M2ProjectPrefixLists.SalesEvents, list =>
                    {
                        list
                            .AddContentTypeLink(M2ProjectPrefixContentTypes.SaleEvents)

                            .M2ProjectPrefixSetDefaultListContentType(M2ProjectPrefixContentTypes.SaleEvents);
                    })
                    .AddHostList(BuiltInListDefinitions.SitePages, list =>
                    {
                        list.AddWebPartPage(M2ProjectPrefixWebPartPages.LandingPage, page =>
                        {
                            page
                                .AddWebPart(M2ProjectPrefixWebparts.NewServices)
                                .AddWebPart(M2ProjectPrefixWebparts.SalesTasks)
                                .AddWebPart(M2ProjectPrefixWebparts.LastDocuments)
                                .AddWebPart(M2ProjectPrefixWebparts.LastOrders)
                                .AddWebPart(M2ProjectPrefixWebparts.SalesEvents);
                        });

                        list.AddWebPartPage(M2ProjectPrefixWebPartPages.AboutThisSite, page =>
                        {
                            page
                                .AddWebPart(M2ProjectPrefixWebparts.M2YammerFeed)
                                .AddWebPart(M2ProjectPrefixWebparts.AboutThisSite);
                        });
                    })

                    .AddWelcomePage(M2ProjectPrefixWelcomePages.HomeLandingPage);
            });

            return model;
        }

        public ModelNode GetStyleLibraryModel()
        {
            var webModel = SPMeta2Model.NewWebModel(rootWeb =>
            {
                // AddHostList() to indicate that we don't provision list, but just look it up
                rootWeb.AddHostList(BuiltInListDefinitions.StyleLibrary, list =>
                {
                    //LoadModuleFilesFromLocalFolder() helper gets everything from the local folder
                    //and creates a new M2 model full of folders/module files

                    //everything you have in M2ProjectPrefixConsts.DefaultStyleLibraryPath
                    //will be pushed to 'Style Library' back to back

                    if (Directory.Exists(M2ProjectPrefixConsts.DefaultStyleLibraryPath))
                        ModuleFileUtils.LoadModuleFilesFromLocalFolder(list, M2ProjectPrefixConsts.DefaultStyleLibraryPath);
                });
            });

            return webModel;
        }
    }
}
