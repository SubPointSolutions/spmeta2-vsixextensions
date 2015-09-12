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
        // add your lists here as per following samples

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

        public static ListDefinition OrderDocuments = new ListDefinition
        {
            Title = "Order Documents",
            CustomUrl = "OrderDocuments",
            ContentTypesEnabled = true,
            TemplateType = BuiltInListTemplateTypeId.DocumentLibrary,
        };

        public static ListDefinition OrderTasks = new ListDefinition
        {
            Title = "Order Tasks",
            CustomUrl = "lists/OrderTasks",
            ContentTypesEnabled = true,
            TemplateType = BuiltInListTemplateTypeId.TasksWithTimelineAndHierarchy,
        };

        public static ListDefinition OrderEvents = new ListDefinition
        {
            Title = "Order Events",
            CustomUrl = "lists/OrderEvents",
            ContentTypesEnabled = true,
            TemplateType = BuiltInListTemplateTypeId.Events,
        };
    }
}
