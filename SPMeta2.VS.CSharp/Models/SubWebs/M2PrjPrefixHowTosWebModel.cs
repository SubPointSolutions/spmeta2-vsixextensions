using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Definitions.Features;
using M2RootNamespace.Definitions.IA;
using M2RootNamespace.Definitions.Pages;
using M2RootNamespace.Definitions.UI;
using SPMeta2.BuiltInDefinitions;
using SPMeta2.Models;
using SPMeta2.Syntax.Default;

namespace M2RootNamespace.Models.SubWebs
{
    /// <summary>
    /// Describes a particular, dedicared to something web.
    /// 
    /// The main responcibility is to describe and separate what needs to be deployed on the web level:
    /// - lists and libraries, links to content types, links to security, list views
    /// - anything else
    /// 
    /// Construct your model using AddXXX() or AddHostXXX() syntax.
    /// If you have bunch of the 'plain' things to push, then use .AddDefinitionsFromStaticClassType() method.
    /// 
    /// It is a good idea to avoid big model preferring small model per every reasonable operation.
    /// The final artifact separation and grouping is tootally up to you and your prpoject needs.
    /// 
    /// Read more here - http://docs.subpointsolutions.com/spmeta2/models/
    /// </summary>
    public class M2PrjPrefixHowTosWebModel
    {
        public ModelNode GetModel()
        {
            var model = SPMeta2Model.NewWebModel(rootWeb =>
            {
                rootWeb.AddWeb(M2ProjectPrefixWebs.HowTos, howTosWeb =>
                {
                    // fill out the web here, and the deploy as usual
                });
            });

            return model;
        }
    }
}
