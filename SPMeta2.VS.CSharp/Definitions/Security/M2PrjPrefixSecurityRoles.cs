using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;

namespace M2RootNamespace.Definitions.Security
{
    public static class M2ProjectPrefixSecurityRoles
    {
        // add your security roles here as per the following samples

        public static SecurityRoleDefinition OrderRead = new SecurityRoleDefinition
        {
            Name = "Order Read",
            Description = "Can view pages and list items and download documents",
            BasePermissions = new System.Collections.ObjectModel.Collection<string>
            {
                BuiltInBasePermissions.ViewListItems,
                BuiltInBasePermissions.OpenItems,
                BuiltInBasePermissions.CreateAlerts,
                BuiltInBasePermissions.ViewFormPages,
                BuiltInBasePermissions.ViewPages,
                BuiltInBasePermissions.BrowseUserInfo,
                BuiltInBasePermissions.UseClientIntegration,
                BuiltInBasePermissions.Open
            }
        };

        public static SecurityRoleDefinition OrderAuthor = new SecurityRoleDefinition
        {
            Name = "Order Author",
            Description = "Can view, add, update and approve list items and documents but cannot delete list items or any documents.",
            BasePermissions = new System.Collections.ObjectModel.Collection<string>
            {
                BuiltInBasePermissions.AddListItems,
                BuiltInBasePermissions.EditListItems,

                BuiltInBasePermissions.ViewListItems,
                BuiltInBasePermissions.ApproveItems,

                BuiltInBasePermissions.OpenItems,
                BuiltInBasePermissions.CreateAlerts,
                BuiltInBasePermissions.ViewFormPages,

                BuiltInBasePermissions.BrowseDirectories,

                BuiltInBasePermissions.ViewPages,
                BuiltInBasePermissions.BrowseUserInfo,

                BuiltInBasePermissions.UseRemoteAPIs,
                BuiltInBasePermissions.UseClientIntegration,
                BuiltInBasePermissions.Open,

                BuiltInBasePermissions.ManagePersonalViews
            }
        };
    }
}
