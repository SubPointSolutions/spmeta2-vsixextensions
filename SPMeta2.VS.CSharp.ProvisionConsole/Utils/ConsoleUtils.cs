using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Services;
using System.Diagnostics;

namespace M2RootNamespace.Utils
{
    public partial class ConsoleUtils
    {
        #region utils

        public virtual void TraceDeploymentProgress(ProvisionServiceBase provisionService)
        {
            provisionService.OnModelNodeProcessed += (sender, args) =>
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine(string.Empty);

                var message = string.Format("Processed: [{0}/{1}] - [{2:00.0} %] - [{3}] [{4}]",
                    new object[]
                    {
                        args.ProcessedModelNodeCount,
                        args.TotalModelNodeCount,
                        100d*(double) args.ProcessedModelNodeCount/(double) args.TotalModelNodeCount,
                        args.CurrentNode.Value.GetType().Name,
                        args.CurrentNode.Value
                    });

                Trace.WriteLine(message);
                Console.WriteLine(message);
            };
        }

        private static SecureString GetSecurePasswordString(string password)
        {
            var securePassword = new SecureString();

            foreach (var s in password)
                securePassword.AppendChar(s);

            return securePassword;
        }

        #endregion

    }
}
