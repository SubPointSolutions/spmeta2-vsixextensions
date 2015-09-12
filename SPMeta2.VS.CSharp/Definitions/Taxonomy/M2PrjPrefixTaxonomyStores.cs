using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Standard.Definitions.Taxonomy;

namespace M2RootNamespace.Definitions.Taxonomy
{
    public static class M2ProjectPrefixTaxonomyStores
    {
        // define your taxonomy stores as per the samples below

        // M2 never creates a taxonomy store
        // The definitions are used only to 'lookup' existing one and continute taxonomy provision 

        public static TaxonomyTermStoreDefinition DefaultSiteTermStore = new TaxonomyTermStoreDefinition
        {
            UseDefaultSiteCollectionTermStore = true
        };

        #region samples

        //public static TaxonomyTermStoreDefinition MMSTermStore = new TaxonomyTermStoreDefinition
        //{
        //    Name = "Managed Metadata Store"
        //};

        //public static TaxonomyTermStoreDefinition TermStoreById = new TaxonomyTermStoreDefinition
        //{
        //    Id = new Guid("3DFBD3D1-396F-42E5-8787-20FDBF35F54A")
        //};

        #endregion
    }
}
