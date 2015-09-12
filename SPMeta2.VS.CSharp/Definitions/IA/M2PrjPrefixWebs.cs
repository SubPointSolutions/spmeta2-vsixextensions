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

        public static WebDefinition Archive = new WebDefinition
        {
            Title = "Archive",
            Url = "archive",
            WebTemplate = BuiltInWebTemplates.Collaboration.TeamSite
        };

        #region samples

        ///// <summary>
        ///// Defining publishing portal for the news
        ///// </summary>
        //public static WebDefinition NewsSite = new WebDefinition
        //{
        //    Title = "News Site",
        //    Url = "News",
        //    WebTemplate = BuiltInWebTemplates.Publishing.PublishingPortal
        //};

        #endregion
    }
}
