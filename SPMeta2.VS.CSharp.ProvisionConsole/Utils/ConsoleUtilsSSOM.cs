using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2RootNamespace.Utils
{
    public partial class ConsoleUtils
    {
        public virtual void WithSSOMContext(string siteUrl, Action<SPSite, SPWeb> action)
        {
            // just a little check on URL, saves some typos
            new Uri(siteUrl);

            using (var site = new SPSite(siteUrl))
            {
                using (var web = site.OpenWeb())
                {
                    action(site, web);
                }
            }
        }
    }
}
