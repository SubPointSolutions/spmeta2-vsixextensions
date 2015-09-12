using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EnvDTE;
using SPMeta2.VS.Tooling.Consts;
using SPMeta2.VS.Tooling.Options;
using SPMeta2.VS.Tooling.Utils;
using VSLangProj;

namespace SPMeta2.VS.Tooling.Services
{
    public class M2ConsoleProvisionProjectService : VSProjectSetupServiceBase<M2ConsoleProjectOptions>
    {
        public override void SetupM2IntranetProject(Project project, M2ConsoleProjectOptions options)
        {
            var vsProject = (VSProject)project.Object;

            HandleRenamedFiles(project, new Dictionary<string, string>
            {
                { "AppSettings.tt_", "AppSettings.tt" }
            });

            HandleExcludedFiles(project, new[] { "m2.png" });
        }

        #region utils
     
        #endregion

        #region nuget

        public override bool UpdateVSProjectNuGetPackages(M2ConsoleProjectOptions options, string vsDefPath)
        {
            return false;
        }

        #endregion
    }
}
