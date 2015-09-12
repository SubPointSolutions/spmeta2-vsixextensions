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

        public static QuickLaunchNavigationNodeDefinition OrderDocuments = new QuickLaunchNavigationNodeDefinition
        {
            Title = "Order Documents",
            Url = "~sitecollection/OrderDocuments",
            IsExternal = true
        };

        public static QuickLaunchNavigationNodeDefinition OrderTasks = new QuickLaunchNavigationNodeDefinition
        {
            Title = "Order Tasks",
            Url = UrlUtility.CombineUrl("~sitecollection", M2ProjectPrefixLists.OrderTasks.CustomUrl),
            IsExternal = true
        };
    }
}
