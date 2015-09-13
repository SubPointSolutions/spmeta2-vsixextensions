using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;

namespace M2RootNamespace.Utils
{
    public partial class ConsoleUtils
    {
        public virtual void WithO365Context(string siteUrl,
            string userName, string userPassword,
            Action<ClientContext> action)
        {
            // just a little check on URL, saves some typos
            new Uri(siteUrl);

            using (var context = new ClientContext(siteUrl))
            {
                context.Credentials = new SharePointOnlineCredentials(userName, GetSecurePasswordString(userPassword));

                action(context);
            }
        }

    }
}
