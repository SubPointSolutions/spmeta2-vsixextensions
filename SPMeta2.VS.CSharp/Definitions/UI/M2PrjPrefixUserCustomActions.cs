using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions;

namespace M2RootNamespace.Definitions.UI
{
    public static class M2ProjectPrefixUserCustomActions
    {
        // define your user custom actions as per the samples below

        // use ~sitecollection or ~site tokens, they are suppoerted by M2
        // use UrlUtility.CombineUrl() to construct URL in a safely manner

        public static UserCustomActionDefinition jQuery = new UserCustomActionDefinition
        {
            Name = "M2ProjectPrefixjQuery",
            Location = "ScriptLink",
            ScriptSrc = "~sitecollection/Style Library/M2PrjPrefix.Intranet/3rd part/jQuery/jquery-1.11.3.min.js",
            Sequence = 15000
        };

        public static UserCustomActionDefinition M2PrjPrefixJs = new UserCustomActionDefinition
        {
            Name = "M2ProjectPrefixjs",
            Location = "ScriptLink",
            ScriptSrc = "~sitecollection/Style Library/M2PrjPrefix.Intranet/js/M2PrjPrefix.Intranet.js",
            Sequence = 17000
        };
    }
}
