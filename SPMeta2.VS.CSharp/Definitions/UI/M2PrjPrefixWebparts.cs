using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Definitions.IA;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Enumerations;

namespace M2RootNamespace.Definitions.UI
{
    public static class M2ProjectPrefixWebparts
    {
        // Use WebPartDefinition to define a generic or custom web part
        // One of WebpartType, WebpartXmlTemplate or WebpartFileName needs to be defined
        // http://docs.subpointsolutions.com/spmeta2/definitions/sharepoint-foundation/webpartdefinition

        // SharePoint Foundation web part are defined under 'SPMeta2.Definitions.Webparts'
        // SharePoint Standard web part are under 'SPMeta2.Standard.Definitions.Webparts'

        // Id, Title, ZoneId and ZoneIndex are to be always defined

        // More information can be found here
        // * WebPartDefinition - http://docs.subpointsolutions.com/spmeta2/definitions/sharepoint-foundation/webpartdefinition
        // * Provision scenarios - http://docs.subpointsolutions.com/spmeta2/scenarios/

        public static XsltListViewWebPartDefinition SalesTasks = new XsltListViewWebPartDefinition
        {
            Title = "Sales Tasks",
            Id = "intrSalesTasks",

            ZoneId = "Header",
            ZoneIndex = 10,

            ChromeType = BuiltInPartChromeType.TitleOnly,
            ListTitle = M2ProjectPrefixLists.SalesTasks.Title
        };

        public static XsltListViewWebPartDefinition LastDocuments = new XsltListViewWebPartDefinition
        {
            Title = "New Documents",
            Id = "intrLastDocuments",

            ZoneId = "LeftColumn",
            ZoneIndex = 10,

            ChromeType = BuiltInPartChromeType.TitleOnly,
            ListTitle = M2ProjectPrefixLists.CompanyDocuments.Title,
            ViewName = M2ProjectPrefixListViews.LastTenDocumentsMainPage.Title
        };

        public static XsltListViewWebPartDefinition LastOrders = new XsltListViewWebPartDefinition
        {
            Title = "New Orders",
            Id = "intrLastOrders",

            ZoneId = "MiddleColumn",
            ZoneIndex = 10,

            ChromeType = BuiltInPartChromeType.TitleOnly,
            ListTitle = M2ProjectPrefixLists.Orders.Title,
            ViewName = M2ProjectPrefixListViews.Last10OrdersMainPage.Title
        };

        public static XsltListViewWebPartDefinition NewServices = new XsltListViewWebPartDefinition
        {
            Title = "New Services",
            Id = "intrNewServices",

            ZoneId = "RightColumn",
            ZoneIndex = 10,

            ChromeType = BuiltInPartChromeType.TitleOnly,
            ListTitle = M2ProjectPrefixLists.Services.Title,
            ViewName = M2ProjectPrefixListViews.LastTenServices.Title
        };

        public static ListViewWebPartDefinition SalesEvents = new ListViewWebPartDefinition
        {
            Title = "Sales Events",
            Id = "intrSalesEvents",

            ZoneId = "Footer",
            ZoneIndex = 10,

            ChromeType = BuiltInPartChromeType.TitleOnly,
            ListTitle = M2ProjectPrefixLists.SalesEvents.Title
        };


        public static ContentEditorWebPartDefinition AboutThisSite = new ContentEditorWebPartDefinition
        {
            Title = "About This Site",
            Id = "intrAboutThisSite",

            ZoneId = "LeftColumn",
            ZoneIndex = 10,

            ChromeType = BuiltInPartChromeType.TitleOnly,
            ContentLink = "~sitecollection/Style Library/M2ProjectPrefix.Intranet/AboutThisSite/about-site.html",
        };

        public static ContentEditorWebPartDefinition M2YammerFeed = new ContentEditorWebPartDefinition
        {
            Title = "SPMeta2 Yammer Network",
            Id = "intrM2YammerNetwork",

            ZoneId = "MiddleColumn",
            ZoneIndex = 10,

            ChromeType = BuiltInPartChromeType.TitleOnly,
            ContentLink = "~sitecollection/Style Library/M2ProjectPrefix.Intranet/Yammer/yammer-group-feed.html",
        };
    }
}
