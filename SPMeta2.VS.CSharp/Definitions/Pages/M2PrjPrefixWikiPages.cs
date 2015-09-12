using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;

namespace M2RootNamespace.Definitions.Pages
{
    public static class M2ProjectPrefixWikiPages
    {
        // add your wiki pages here as per the following samples

        public static WikiPageDefinition FAQ = new WikiPageDefinition
        {
            Title = "FAQ",
            FileName = "FAQ.aspx",
        };

        public static WikiPageDefinition HowTos = new WikiPageDefinition
        {
            Title = "HowTos",
            FileName = "HowTos.aspx",
            Content = "Some fascinating how-tows here..."
        };
    }
}
