using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;
using System.Net;

namespace M2RootNamespace.Utils
{
    public partial class ConsoleUtils
    {
        public virtual void WithCSOMContext(string siteUrl, Action<ClientContext> action)
        {
            WithCSOMContext(siteUrl, string.Empty, string.Empty, string.Empty, action);
        }

        public virtual void WithCSOMContext(string siteUrl,
            string userName, string userPassword, string userDomain,
            Action<ClientContext> action)
        {
            // just a little check on URL, saves some typos
            new Uri(siteUrl);

            using (var context = new ClientContext(siteUrl))
            {
                if (!string.IsNullOrEmpty(userName)
                    && !string.IsNullOrEmpty(userPassword)
                    && !string.IsNullOrEmpty(userDomain))
                {
                    context.Credentials = new NetworkCredential(userName, userPassword, userDomain);
                }

                action(context);
            }
        }
    }
}
