using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Definitions.Features;
using M2RootNamespace.Definitions.IA;
using M2RootNamespace.Definitions.Security;
using M2RootNamespace.Definitions.Solutions;
using M2RootNamespace.Definitions.UI;
using SPMeta2.Extensions;
using SPMeta2.Models;
using SPMeta2.Syntax.Default;

namespace M2RootNamespace.Models
{
    /// <summary>
    /// Describes the site collection.
    /// 
    /// The main responcibility is to describe and separate what needs to be deployed on the site collection level:
    /// - sandbox solutions
    /// - site features
    /// - security group and roles
    /// - fields
    /// - content types
    /// - user custom actions
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
    public class M2ProjectPrefixSiteModel
    {
        public ModelNode GetSandboxSolutionsModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {
                // either use AddXXX() or just import everything with .AddDefinitionsFromStaticClassType() 
                // !!! commented out as there is no *.wsp package out there !!!

                //site.AddSandboxSolution(M2ProjectPrefixSandboxSolutions.WebsiteBranding);
                //site.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixSandboxSolutions));
            });

            return model;
        }

        public ModelNode GetSiteSecurityModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {
                site.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixSecurityGroups));
                site.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixSecurityRoles));
            });

            return model;
        }

        public ModelNode GetSiteFeaturesModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {
                // either use AddXXX() or just import everything with .AddDefinitionsFromStaticClassType() 

                site.AddSiteFeature(M2ProjectPrefixSiteFeatures.BasicWebParts);
                //site.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixSiteFeatures));
            });

            return model;
        }

        public ModelNode GetFieldsAndContentTypesModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {
                // adding all fields from M2ProjectPrefixFields class
                site.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixFields));

                // building up content types
                site
                    .AddContentType(M2ProjectPrefixContentTypes.CompanyDocument, contentType =>
                    {
                        contentType
                            .AddContentTypeFieldLink(M2ProjectPrefixFields.DocumentHighlights)
                            .AddContentTypeFieldLink(M2ProjectPrefixFields.DocumentDescription);
                    })
                    .AddContentType(M2ProjectPrefixContentTypes.SalesProposal, contentType =>
                    {

                    })
                    .AddContentType(M2ProjectPrefixContentTypes.ProductDocument, contentType =>
                    {

                    })
                    .AddContentType(M2ProjectPrefixContentTypes.OrderDocument, contentType =>
                    {
                        contentType
                            .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderDate)
                            .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderAddressState)
                            .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderPrice)
                            .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderSalePercentage)
                            .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderTrackingUrl);
                    })
                    .AddContentType(M2ProjectPrefixContentTypes.ProductOrService, contentType =>
                    {
                        contentType
                            .AddContentTypeFieldLink(M2ProjectPrefixFields.ProductDescription)
                            .AddContentTypeFieldLink(M2ProjectPrefixFields.ProductType)
                            .AddContentTypeFieldLink(M2ProjectPrefixFields.IsProductActive);
                    })
                    .AddContentType(M2ProjectPrefixContentTypes.SaleEvents, contentType =>
                    {

                    });
            });

            return model;
        }

        public ModelNode GetTaxonomyModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {
                // skipped, it it might be a foundation project setup
                // refer to Taxonomy provision scenarios here:

                // http://docs.subpointsolutions.com/spmeta2/scenarios/
                // http://docs.subpointsolutions.com/spmeta2/definitions/sharepoint-standard/taxonomy/taxonomytermdefinition/
            });

            return model;
        }

        public ModelNode GetUserCustomActionModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {
                site.AddUserCustomAction(M2ProjectPrefixUserCustomActions.jQuery);
                site.AddUserCustomAction(M2ProjectPrefixUserCustomActions.M2PrjPrefixJs);
            });

            return model;
        }
    }
}
