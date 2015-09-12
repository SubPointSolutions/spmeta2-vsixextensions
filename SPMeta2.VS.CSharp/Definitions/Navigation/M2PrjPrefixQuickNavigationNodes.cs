using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Definitions.IA;
using SPMeta2.Definitions;
using SPMeta2.Utils;

namespace M2RootNamespace.Definitions.Navigation
{
    public static class M2ProjectPrefixQuickNavigationNodes
    {
        // add your quick navigation (left navigation) here as per following samples

        // use ~sitecollection or ~site tokens, they are suppoerted by M2
        // use UrlUtility.CombineUrl() to construct URL in a safely manner
        // refer your definition, reuse them - enable refactoring

        public static QuickLaunchNavigationNodeDefinition CompanyDocuments = new QuickLaunchNavigationNodeDefinition
        {
            Title = "Company Documents",
            Url = "~site/CompanyDocuments",
            IsExternal = true
        };

        public static QuickLaunchNavigationNodeDefinition Services = new QuickLaunchNavigationNodeDefinition
        {
            Title = "Services",
            Url = UrlUtility.CombineUrl("~site", M2ProjectPrefixLists.Services.CustomUrl),
            IsExternal = true
        };

        public static QuickLaunchNavigationNodeDefinition Orders = new QuickLaunchNavigationNodeDefinition
        {
            Title = "Orders",
            Url = UrlUtility.CombineUrl("~site", M2ProjectPrefixLists.Orders.CustomUrl),
            IsExternal = true
        };

        public static QuickLaunchNavigationNodeDefinition SaleTasks = new QuickLaunchNavigationNodeDefinition
        {
            Title = "Sales Tasks",
            Url = UrlUtility.CombineUrl("~site", M2ProjectPrefixLists.SalesTasks.CustomUrl),
            IsExternal = true
        };

        public static QuickLaunchNavigationNodeDefinition SaleEvents = new QuickLaunchNavigationNodeDefinition
        {
            Title = "Sales Events",
            Url = UrlUtility.CombineUrl("~site", M2ProjectPrefixLists.SalesEvents.CustomUrl),
            IsExternal = true
        };
    }
}
