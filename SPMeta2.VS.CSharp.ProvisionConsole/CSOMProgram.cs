using M2RootNamespace.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.CSOM.Services;
using SPMeta2.Models;

namespace M2RootNamespace
{
    class CSOMPProgram
    {
        static void Main(string[] args)
        {
            var siteUrl = "http://portal";
            var consoleUtils = new ConsoleUtils();

            consoleUtils.WithCSOMContext(siteUrl, context =>
            {
                // replace it with your M2 models
                var siteModel = default(ModelNode);
                var rotWebModel = default(ModelNode);

                // create a provision service - CSOMProvisionService or StandardCSOMProvisionService
                var provisionService = new CSOMProvisionService();

                // little nice thing, tracing the progress
                consoleUtils.TraceDeploymentProgress(provisionService);

                // deploy!
                provisionService.DeploySiteModel(context, siteModel);
                provisionService.DeployWebModel(context, rotWebModel);
            });
        }
    }
}
