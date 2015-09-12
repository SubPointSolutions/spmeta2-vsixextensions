using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;

namespace M2RootNamespace.Definitions.IA
{
    public static class M2ProjectPrefixWebs
    {
        // add your webs here as per following samples

        // Use BuiltInWebTemplates to refer OOT web templates
        // BuiltInWebTemplates.Collaboration.TeamSite -> team sites
        // BuiltInWebTemplates.Publishing.PublishingPortal -> publishing portal

        public static WebDefinition Clients = new WebDefinition
        {
            Title = "Clients",
            Url = "clients",
            WebTemplate = BuiltInWebTemplates.Collaboration.TeamSite
        };

        public static WebDefinition HowTows = new WebDefinition
        {
            Title = "HowTos",
            Url = "HowTos",
            WebTemplate = BuiltInWebTemplates.Collaboration.TeamSite
        };
    }
}
