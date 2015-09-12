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
            ScriptSrc = "~sitecollection/Style Library/M2ProjectPrefix.Intranet/3rd part/jQuery/jQuery.js",
            Sequence = 15000
        };
    }
}
