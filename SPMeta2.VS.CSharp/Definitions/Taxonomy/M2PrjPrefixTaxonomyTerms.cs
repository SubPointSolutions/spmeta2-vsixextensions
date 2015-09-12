using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Standard.Definitions.Taxonomy;

namespace M2RootNamespace.Definitions.Taxonomy
{
    public static class M2ProjectPrefixTaxonomyTerms
    {
        public static TaxonomyTermDefinition SmallBusiness = new TaxonomyTermDefinition
        {
            Name = "Small Business"
        };

        public static TaxonomyTermDefinition MediumBusiness = new TaxonomyTermDefinition
        {
            Name = "Medium Business"
        };

        public static TaxonomyTermDefinition Enterprise = new TaxonomyTermDefinition
        {
            Name = "Enterprise"
        };
    }
}
