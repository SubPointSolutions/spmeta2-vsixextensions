using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using SPMeta2.VS.Tooling.Consts;
using SPMeta2.VS.Tooling.Forms;
using SPMeta2.VS.Tooling.Options;
using SPMeta2.VS.Tooling.Utils;
using VSLangProj;

namespace SPMeta2.VS.Tooling.Wizards
{
    public class M2IntranetModelWizard : IWizard
    {
        #region properties

        private M2IntranetProjectOptions _options;
        private IWizard _wizard;

        #endregion

        #region methods

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
            _wizard.BeforeOpeningFile(projectItem);
        }

        public void ProjectFinishedGenerating(Project project)
        {
            var vsProject = (VSProject)project.Object;

            HandleProjectPlatform(vsProject, _options);
            HandleProjectPrefix(project, _options);


            _wizard.ProjectFinishedGenerating(project);
        }

        private void HandleProjectPrefix(Project project, M2IntranetProjectOptions options)
        {
            if (!string.IsNullOrEmpty(ProjectPrefix))
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
                        {
                            // Prefix is protected variable saved in RunStarted() call
                            item.Name = item.Name.Replace("M2PrjPrefix", ProjectPrefix);
                        }
                    }
                }
            }

        }

        private void HandleProjectPlatform(VSProject project, M2IntranetProjectOptions options)
        {
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

        protected string ProjectPrefix = string.Empty;

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            _wizard.ProjectItemFinishedGenerating(projectItem);
        }

        public void RunFinished()
        {
            _wizard.RunFinished();
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            var form = new M2IntranetModelForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _options = form.Options;

                ProjectPrefix = _options.ProjectPrefix;


                // replacementsDictionary.Add("M2ProjectPrefix", _options.ProjectPrefix);
                //replacementsDictionary.Add("$M2Prefix$", _options.);

                // legacy one
                replacementsDictionary.Add("M2ProjectPrefix", _options.ProjectPrefix);

                // sync M2Prj settings
                var props = _options.GetType().GetProperties();

                foreach (var prop in props)
                {
                    var propValue = prop.GetValue(_options);
                    var propValueString = string.Empty;

                    if (propValue != null)
                        propValueString = propValue.ToString();

                    var propName = string.Format("$M2{0}$", prop.Name);
                    var normalPropName = string.Format("M2{0}", prop.Name);

                    if (!replacementsDictionary.Keys.Contains(propName))
                        replacementsDictionary.Add(propName, propValueString);
                    else
                        replacementsDictionary[propName] = propValueString;

                    if (!replacementsDictionary.Keys.Contains(normalPropName))
                        replacementsDictionary.Add(normalPropName, propValueString);
                    else
                        replacementsDictionary[normalPropName] = propValueString;
                }

                // sync additional stuff
                replacementsDictionary.Add("$rootnamespace$", replacementsDictionary["$safeprojectname$"]);
                replacementsDictionary.Add("M2RootNamespace", replacementsDictionary["$safeprojectname$"]);

                HandleNuGetPackages(_options, automationObject, replacementsDictionary, runKind, customParams);
            }
        }

        private void HandleNuGetPackages(M2IntranetProjectOptions options,
            object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind,
            object[] customParams)
        {
            var vsDefPath = customParams[0].ToString();

            UpdateVSProjectNuGetPackages(options, vsDefPath);

            var asm = Assembly.Load("NuGet.VisualStudio.Interop, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a");
            _wizard = (IWizard)asm.CreateInstance("NuGet.VisualStudio.TemplateWizard");

            _wizard.RunStarted(automationObject, replacementsDictionary, runKind, customParams);
        }

        private XElement CreateNuGetPackageNode(string packageId)
        {
            return CreateNuGetPackageNode(packageId, M2Consts.M2RunTimeVersion);
        }

        private XElement CreateNuGetPackageNode(string packageId, string version)
        {
            return new XElement("package",
                new XAttribute("id", packageId),
                new XAttribute("version", version)
                );
        }

        private void UpdateVSProjectNuGetPackages(M2IntranetProjectOptions options, string vsDefPath)
        {
            var packageIds = new List<string>();

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

            var packages = packageIds.Select(p => CreateNuGetPackageNode(p));

            var xDoc = XDocument.Parse(File.ReadAllText(vsDefPath));
            var wizardDataNode = xDoc.Root.Descendants().FirstOrDefault(e => e.Name.LocalName.ToUpper() == "WizardData".ToUpper());

            if (wizardDataNode == null)
                xDoc.Root.Add(new XElement("WizardData", new XElement("packages", packages)));
            else
            {
                wizardDataNode.RemoveAll();
                wizardDataNode.Add(new XElement("packages", packages));
            }

            File.WriteAllText(vsDefPath, xDoc.ToString());
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        #endregion
    }
}
