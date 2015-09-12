using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions;

namespace M2RootNamespace.Definitions.Security
{
    public static class M2ProjectPrefixSecurityGroups
    {
        // add your security groups here as per the following samples

        public static SecurityGroupDefinition OrderApprovers = new SecurityGroupDefinition
        {
            Name = "Order Approvers",
            Description = "People who can approve orders."
        };

        public static SecurityGroupDefinition OrderReviewers = new SecurityGroupDefinition
        {
            Name = "Order Reviewers",
            Description = "People who can review orders."
        };
    }
}
