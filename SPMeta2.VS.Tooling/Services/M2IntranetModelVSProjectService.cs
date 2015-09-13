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
    public class M2IntranetModelVSProjectService : VSProjectSetupServiceBase<M2IntranetProjectOptions>
    {
        public override void SetupM2IntranetProject(Project project, M2IntranetProjectOptions options)
        {
            var vsProject = (VSProject)project.Object;

            HandleDefaultReferenciesForProjectOptions(vsProject, options);
            HandleDefaultProjectPrefix(project, options);
            HandleExcludedProjectFiles(project, options);
            HandleRenamedFiles(project, new Dictionary<string, string>
            {
                { "jq_", "jquery-1.11.3.min.js" }
            });
        }

        private void HandleExcludedProjectFiles(Project project, M2IntranetProjectOptions options)
        {
            var itemsToExclude = new List<string> { "m2.png" };


            // if foundation, remove all 'standard+' stuff
            if (options.ProjectType == ProjectType.Foundation)
            {
                itemsToExclude.Add(options.ProjectPrefix + "WebNavigationSettings.cs");
                itemsToExclude.Add(options.ProjectPrefix + "PublishingPages.cs");
                itemsToExclude.Add(options.ProjectPrefix + "PublishingPageLayouts.cs");

                itemsToExclude.Add("Taxonomy");
            }

            switch (options.ProjectPlatform)
            {
                case ProjectPlatform.None:
                    {
                        itemsToExclude.Add("Services");
                    }
                    break;

                case ProjectPlatform.SP2013CSOM:
                case ProjectPlatform.O365CSOM:
                    {
                        itemsToExclude.Add(options.ProjectPrefix + "SSOMProvisionService.cs");
                        itemsToExclude.Add(options.ProjectPrefix + "StandardSSOMProvisionService.cs");

                        if (options.ProjectType == ProjectType.Foundation)
                            itemsToExclude.Add(options.ProjectPrefix + "StandardCSOMProvisionService.cs");
                        else
                            itemsToExclude.Add(options.ProjectPrefix + "CSOMProvisionService.cs");
                    }
                    break;

                case ProjectPlatform.SP2013SSOM:
                    {
                        itemsToExclude.Add(options.ProjectPrefix + "CSOMProvisionService.cs");
                        itemsToExclude.Add(options.ProjectPrefix + "StandardCSOMProvisionService.cs");

                        if (options.ProjectType == ProjectType.Foundation)
                            itemsToExclude.Add(options.ProjectPrefix + "StandardSSOMProvisionService.cs");
                        else
                            itemsToExclude.Add(options.ProjectPrefix + "SSOMProvisionService.cs");
                    }
                    break;

            }

            HandleExcludedFiles(project, itemsToExclude);
        }

        #region utils

        private void FixUpProjectTemplateReferencies(VSProject project, M2IntranetProjectOptions options)
        {
            return;

            //var rawReferencies = new List<string>();

            //if (options.ProjectType == ProjectType.Foundation)
            //{
            //    // downgrading M2 to foundation

            //    rawReferencies.Add("SPMeta2.CSOM.Standard");
            //    rawReferencies.Add("SPMeta2.SSOM.Standard");
            //    rawReferencies.Add("SPMeta2.Standard");
            //}

            //if (options.ProjectPlatform == ProjectPlatform.None)
            //{
            //    rawReferencies.Add("SPMeta2.CSOM.Standard");
            //    rawReferencies.Add("SPMeta2.SSOM.Standard");

            //    rawReferencies.Add("SPMeta2.CSOM");
            //    rawReferencies.Add("SPMeta2.SSOM");
            //}

            //rawReferencies = rawReferencies.Distinct().ToList();

            //// always clean up sharepoint assemblies
            //rawReferencies.AddRange(project.References
            //                               .OfType<Reference>()
            //                               .Where(r => r.Name.ToLower().Contains("microsoft.sharepoint"))
            //                               .Select(r => r.Name));

            //var refs = project.References
            //    .OfType<Reference>()
            //    .Where(r => rawReferencies.Any(rr => String.Equals(rr, r.Name, StringComparison.CurrentCultureIgnoreCase)))
            //    .ToArray();

            //for (int i = 0; i < rawReferencies.Count(); i++)
            //    refs[i].Remove();
        }

        #endregion

        #region nuget

        public override bool UpdateVSProjectNuGetPackages(M2IntranetProjectOptions options, string vsDefPath)
        {
            HandleNuGetPackagesUpdate(vsDefPath, GetDefaultNuGetPackagesForProjectOptions(options));

            return true;
        }

        #endregion
    }
}
