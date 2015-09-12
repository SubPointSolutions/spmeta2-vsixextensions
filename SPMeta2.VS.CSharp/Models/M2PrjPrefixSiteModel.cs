using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Definitions.Features;
using M2RootNamespace.Definitions.IA;
using M2RootNamespace.Definitions.Security;
using M2RootNamespace.Definitions.Solutions;
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

                //site.AddSandboxSolution(M2ProjectPrefixSandboxSolutions.WebsiteBranding);
                //site.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixSandboxSolutions));
            });

            return model;
        }

        public ModelNode GetSiteSecurityModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {
                // either use AddXXX() or just import everything with .AddDefinitionsFromStaticClassType() 

                // adding security groups
                //site
                //    .AddSecurityGroup(M2ProjectPrefixSecurityGroups.OrderApprovers)
                //    .AddSecurityGroup(M2ProjectPrefixSecurityGroups.OrderReviewers);

                //site.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixSecurityGroups));

                //// adding security roles
                //site
                //    .AddSecurityRole(M2ProjectPrefixSecurityRoles.OrderAuthor)
                //    .AddSecurityRole(M2ProjectPrefixSecurityRoles.OrderRead);

                //site.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixSecurityRoles));
            });

            return model;
        }

        public ModelNode GetSiteFeaturesModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {
                // either use AddXXX() or just import everything with .AddDefinitionsFromStaticClassType() 

                //site.AddSiteFeature(M2ProjectPrefixSiteFeatures.BasicWebParts);

                //site.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixSiteFeatures));
            });

            return model;
        }

        public ModelNode GetFieldsAndContentTypesModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {
                #region sample

                // building up fields
                // use AddField() or just mport all fields from M2ProjectPrefixFields class
                //site
                //    .AddField(M2ProjectPrefixFields.OrderName)
                //    .AddField(M2ProjectPrefixFields.OrderDescription)
                //    .AddField(M2ProjectPrefixFields.OrderDate)
                //    .AddField(M2ProjectPrefixFields.OrderPrice);

                //site.AddDefinitionsFromStaticClassType(typeof(M2ProjectPrefixFields));

                // building up content types
                //site.AddContentType(M2ProjectPrefixContentTypes.IntranetContract, contentType =>
                //{
                //    contentType
                //        .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderName)
                //        .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderDescription)
                //        .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderAddressState)
                //        .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderDate)
                //        .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderPrice);
                //});

                //site.AddContentType(M2ProjectPrefixContentTypes.IntranetOrder, contentType =>
                //{
                //    contentType
                //        .AddContentTypeFieldLink(M2ProjectPrefixFields.IsOrderActive)
                //        .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderSalePercentage)
                //        .AddContentTypeFieldLink(M2ProjectPrefixFields.OrderTrackingUrl);
                //});

                #endregion
            });

            return model;
        }

        public ModelNode GetTaxonomyModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {

            });

            return model;
        }
    }
}
