using M2RootNamespace.Definitions.IA;
using SPMeta2.Definitions;
using SPMeta2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2RootNamespace.Definitions.Navigation
{
    public static class M2ProjectPrefixTopNavigationNodes
    {
        // use ~sitecollection or ~site tokens, they are suppoerted by M2
        // use UrlUtility.CombineUrl() to construct URL in a safely manner
        // refer your definition, reuse them - enable refactoring

        public static TopNavigationNodeDefinition CompanyDocuments = new TopNavigationNodeDefinition
        {
            Title = "Company Documents",
            Url = "~sitecollection/CompanyDocuments",
            IsExternal = true
        };

        public static TopNavigationNodeDefinition SaleTasks = new TopNavigationNodeDefinition
        {
            Title = "Sales Tasks",
            Url = UrlUtility.CombineUrl("~sitecollection", M2ProjectPrefixLists.SalesTasks.CustomUrl),
            IsExternal = true
        };

        public static TopNavigationNodeDefinition SaleEvents = new TopNavigationNodeDefinition
        {
            Title = "Sales Events",
            Url = UrlUtility.CombineUrl("~sitecollection", M2ProjectPrefixLists.SalesEvents.CustomUrl),
            IsExternal = true
        };
    }
}
