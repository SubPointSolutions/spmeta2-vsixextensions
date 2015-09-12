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

            HandleProjectPlatform(vsProject, options);
            HandleProjectPrefix(project, options);

            var itemsToExclude = new List<string>();

            itemsToExclude.Add("m2.png");

            // if foundation, remove all 'standard+' stuff
            if (options.ProjectType == ProjectType.Foundation)
            {
                itemsToExclude.Add(options.ProjectPrefix + "WebNavigationSettings.cs");
                itemsToExclude.Add(options.ProjectPrefix + "PublishingPages.cs");
                itemsToExclude.Add(options.ProjectPrefix + "PublishingPageLayouts.cs");

                itemsToExclude.Add("Taxonomy");
            }

            if (options.ProjectPlatform == ProjectPlatform.None)
            {
                itemsToExclude.Add("Services");
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

        private void HandleProjectPlatform(VSProject project, M2IntranetProjectOptions options)
        {
            FixUpProjectTemplateReferencies(project, options);

            // adding correct
            switch (options.ProjectPlatform)
            {
                case ProjectPlatform.SP2013SSOM:
                    {
                        project.References.Add("Microsoft.SharePoint");
                        project.References.Add("Microsoft.SharePoint.Security");

                        if (options.ProjectType == ProjectType.Standard)
                        {
                            project.References.Add("Microsoft.SharePoint.Portal");
                            project.References.Add("Microsoft.SharePoint.Publishing");
                            project.References.Add("Microsoft.SharePoint.Taxonomy");
                        }
                    }
                    break;

                case ProjectPlatform.SP2013CSOM:
                    {
                        project.References.Add("Microsoft.SharePoint.Client");
                        project.References.Add("Microsoft.SharePoint.Client.Runtime");

                        if (options.ProjectType == ProjectType.Standard)
                        {
                            project.References.Add("Microsoft.SharePoint.Client.Publishing");
                            project.References.Add("Microsoft.SharePoint.Client.Taxonomy");
                        }
                    }
                    break;

                case ProjectPlatform.O365CSOM:
                    {
                        project.References.Add("Microsoft.SharePoint.Client");
                        project.References.Add("Microsoft.SharePoint.Client.Runtime");

                        if (options.ProjectType == ProjectType.Standard)
                        {
                            project.References.Add("Microsoft.SharePoint.Client.Publishing");
                            project.References.Add("Microsoft.SharePoint.Client.Taxonomy");
                        }
                    }
                    break;
            }
        }

        private void HandleProjectPrefix(Project project, M2IntranetProjectOptions options)
        {
            var projectPrefix = options.ProjectPrefix;

            if (!string.IsNullOrEmpty(projectPrefix))
            {
                var it = new ProjectItemIterator(new[] { project }).GetEnumerator();

                while (it.MoveNext())
                {
                    var item = it.Current;

                    if (!string.IsNullOrEmpty(item.Name))
                    {
                        if (item.Name == "Packages")
                        {
                            item.Remove();
                        }

                        if (item.Name.StartsWith("M2PrjPrefix"))
                            item.Name = item.Name.Replace("M2PrjPrefix", options.ProjectPrefix);

                        if (item.Name.StartsWith("M2ProjectPrefix"))
                            item.Name = item.Name.Replace("M2ProjectPrefix", options.ProjectPrefix);
                    }
                }
            }
        }

        #endregion

        #region nuget

        public override void UpdateVSProjectNuGetPackages(M2IntranetProjectOptions options, string vsDefPath)
        {
            var packageIds = new List<string>();

            switch (options.ProjectType)
            {
                case ProjectType.Foundation:
                    {
                        packageIds.Add("spmeta2.core");
                    } break;

                case ProjectType.Standard:
                    {
                        packageIds.Add("spmeta2.core");
                        packageIds.Add("spmeta2.core.standard");
                    } break;
            }

            switch (options.ProjectPlatform)
            {
                case ProjectPlatform.SP2013SSOM:
                    {
                        packageIds.Add("spmeta2.core");
                        packageIds.Add("spmeta2.ssom.foundation");

                        if (options.ProjectType == ProjectType.Standard)
                        {
                            packageIds.Add("spmeta2.ssom.standard");
                        }

                    }; break;

                case ProjectPlatform.SP2013CSOM:
                    {
                        packageIds.Add("spmeta2.core");
                        packageIds.Add("spmeta2.csom.foundation");

                        if (options.ProjectType == ProjectType.Standard)
                        {
                            packageIds.Add("spmeta2.csom.standard");
                        }
                    }; break;

                case ProjectPlatform.O365CSOM:
                    {
                        packageIds.Add("spmeta2.core");
                        packageIds.Add("SPMeta2.CSOM.Foundation-v16");

                        if (options.ProjectType == ProjectType.Standard)
                        {
                            packageIds.Add("SPMeta2.CSOM.Standard-v16");
                        }
                    }; break;
            }

            HandleNuGetPackagesUpdate(vsDefPath, packageIds.Distinct().ToList());
        }

        #endregion
    }
}
