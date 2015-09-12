using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;

namespace M2RootNamespace.Definitions.Pages
{
    public static class M2ProjectPrefixWebPartPages
    {
        // add your publishing pages here as per the following samples

        // use BuiltInWebPartPageTemplates to refer OOTB page layouts
        // use CustomPageLayout to define your page as needed

        public static WebPartPageDefinition SalesDashboard = new WebPartPageDefinition
        {
            Title = "Sales Dashboard",
            FileName = "SalesDashboard.aspx",
            PageLayoutTemplate = BuiltInWebPartPageTemplates.spstd1
        };

        public static WebPartPageDefinition RevenueDashboard = new WebPartPageDefinition
        {
            Title = "Revenue Dashboard",
            FileName = "RevenueDashboard.aspx",
            PageLayoutTemplate = BuiltInWebPartPageTemplates.spstd2
        };

        public static WebPartPageDefinition AboutThisSite = new WebPartPageDefinition
        {
            Title = "About This Site",
            FileName = "AboutThisSite.aspx",
            PageLayoutTemplate = BuiltInWebPartPageTemplates.spstd2
        };
    }
}
