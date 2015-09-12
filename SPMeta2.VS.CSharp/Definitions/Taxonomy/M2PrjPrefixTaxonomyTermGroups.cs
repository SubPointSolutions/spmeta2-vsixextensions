using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Standard.Definitions.Taxonomy;

namespace M2RootNamespace.Definitions.Taxonomy
{
    public static class M2ProjectPrefixTaxonomyTermGroups
    {
        // define your taxonomy groups as per the samples below

        // Use IsSiteCollectionGroup to indicate default site scoped taxonomy group 

        public static TaxonomyTermGroupDefinition OrdersCRM = new TaxonomyTermGroupDefinition
        {
            Name = "Orders CRM"
        };
    }
}
