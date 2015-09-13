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

            HandleDefaultReferenciesForProjectOptions(vsProject, options);
            HandleExcludedProjectFiles(project, options);
        }

        private void HandleExcludedProjectFiles(Project project, M2ConsoleProjectOptions options)
        {
            var itemsToExclude = new List<string> { "m2.png" };

            switch (options.ProjectPlatform)
            {
                case ProjectPlatform.SP2013CSOM:
                    {
                        itemsToExclude.Add("ConsoleUtilsSSOM.cs");
                        itemsToExclude.Add("ConsoleUtilsO365.cs");

                        itemsToExclude.Add("O365Program.cs");
                        itemsToExclude.Add("SSOMProgram.cs");
                    }
                    break;
                case ProjectPlatform.O365CSOM:
                    {
                        itemsToExclude.Add("ConsoleUtilsSSOM.cs");
                        itemsToExclude.Add("ConsoleUtilsCSOM.cs");

                        itemsToExclude.Add("CSOMProgram.cs");
                        itemsToExclude.Add("SSOMProgram.cs");
                    }
                    break;

                case ProjectPlatform.SP2013SSOM:
                    {
                        itemsToExclude.Add("ConsoleUtilsCSOM.cs");
                        itemsToExclude.Add("ConsoleUtilsO365.cs");

                        itemsToExclude.Add("O365Program.cs");
                        itemsToExclude.Add("CSOMProgram.cs");
                    }
                    break;
            }

            HandleExcludedFiles(project, itemsToExclude);
        }

        #region utils

        #endregion

        #region nuget

        public override bool UpdateVSProjectNuGetPackages(M2ConsoleProjectOptions options, string vsDefPath)
        {
            HandleNuGetPackagesUpdate(vsDefPath, GetDefaultNuGetPackagesForProjectOptions(options));

            return true;
        }

        #endregion
    }
}
