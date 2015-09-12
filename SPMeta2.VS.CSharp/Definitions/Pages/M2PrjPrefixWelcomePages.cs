using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.BuiltInDefinitions;
using SPMeta2.Definitions;
using SPMeta2.Utils;

namespace M2RootNamespace.Definitions.Pages
{
    public static class M2ProjectPrefixWelcomePages
    {
        // use UrlUtility.CombineUrl() to construct URL in a safely manner
        // refer your definition, reuse them - enable refactoring

        public static WelcomePageDefinition HomeLandingPage = new WelcomePageDefinition
        {
            Url = UrlUtility.CombineUrl("SitePages", M2ProjectPrefixWebPartPages.LandingPage.FileName)
        };
    }
}
