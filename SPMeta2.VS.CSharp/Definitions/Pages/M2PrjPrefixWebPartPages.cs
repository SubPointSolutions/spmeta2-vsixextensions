using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;
using SPMeta2.VS.CSharp.Modules;

namespace M2RootNamespace.Definitions.Pages
{
    public static class M2ProjectPrefixWebPartPages
    {
        public static WebPartPageDefinition LandingPage = new WebPartPageDefinition
        {
            Title = "Landing Page",
            FileName = "LandingPage.aspx",
            CustomPageLayout = StringResources.CustomWebpartPageMarkup
        };

        public static WebPartPageDefinition AboutThisSite = new WebPartPageDefinition
        {
            Title = "About This Site",
            FileName = "AboutThisSite.aspx",
            CustomPageLayout = StringResources.CustomWebpartPageMarkup
        };
    }
}
