using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;

namespace M2RootNamespace.Definitions.IA
{
    public static class M2ProjectPrefixLists
    {
        // Tend to use 'CustomUrl' property - it is web-relative URL of the list or library
        // Lists some with 'lists/mylist' and libraries come as 'mylibrary'
        // Use BuiltInListTemplateTypeId to refer OOTB SharePoint list types

        public static ListDefinition Orders = new ListDefinition
        {
            Title = "Orders",
            CustomUrl = "lists/Orders",
            ContentTypesEnabled = true,
            TemplateType = BuiltInListTemplateTypeId.GenericList,
        };

        public static ListDefinition CompanyDocuments = new ListDefinition
        {
            Title = "Company Documents",
            CustomUrl = "CompanyDocuments",
            ContentTypesEnabled = true,
            TemplateType = BuiltInListTemplateTypeId.DocumentLibrary,
        };

        public static ListDefinition Services = new ListDefinition
        {
            Title = "Services",
            CustomUrl = "lists/Services",
            ContentTypesEnabled = true,
            TemplateType = BuiltInListTemplateTypeId.GenericList,
        };

        public static ListDefinition SalesTasks = new ListDefinition
        {
            Title = "Sales Tasks",
            CustomUrl = "lists/SaleTasks",
            ContentTypesEnabled = true,
            TemplateType = BuiltInListTemplateTypeId.TasksWithTimelineAndHierarchy,
        };

        public static ListDefinition SalesEvents = new ListDefinition
        {
            Title = "Sales Events",
            CustomUrl = "lists/SaleEvents",
            ContentTypesEnabled = true,
            TemplateType = BuiltInListTemplateTypeId.Events,
        };
    }
}
