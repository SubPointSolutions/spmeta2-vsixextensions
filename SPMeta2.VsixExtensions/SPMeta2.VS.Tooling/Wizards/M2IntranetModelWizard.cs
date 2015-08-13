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
using SPMeta2.VS.Tooling.Forms;
using SPMeta2.VS.Tooling.Options;
using SPMeta2.VS.Tooling.Utils;
using VSLangProj;

namespace SPMeta2.VS.Tooling.Wizards
{
    public class M2IntranetModelWizard : IWizard
    {
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
            wizard.BeforeOpeningFile(projectItem);
        }

        public void ProjectFinishedGenerating(Project project)
        {
            var vsProject = (VSProject)project.Object;

            if (options.IsSSOM)
            {
                vsProject.References.Add("Microsoft.SharePoint");
                vsProject.References.Add("Microsoft.SharePoint.Security");
            }
            else
            {
                vsProject.References.Add("Microsoft.SharePoint.Client");
                vsProject.References.Add("Microsoft.SharePoint.Client.Runtime");
            }

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

            wizard.ProjectFinishedGenerating(project);
        }

        protected string ProjectPrefix = string.Empty;

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            wizard.ProjectItemFinishedGenerating(projectItem);
        }

        public void RunFinished()
        {
            wizard.RunFinished();
        }

        private M2IntranetProjectOptions options;

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            var form = new M2IntranetModelForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                options = form.Options;

                ProjectPrefix = options.ProjectPrefix;

                replacementsDictionary.Add("$M2PrjPrefix$", options.ProjectPrefix);
                replacementsDictionary.Add("$rootnamespace$", replacementsDictionary["$safeprojectname$"]);

                // pre-load M2
                var vsDefPath = customParams[0].ToString();

                var packages = new List<XElement>();

                packages.Add(new XElement("package",
                    new XAttribute("id", "spmeta2.core"),
                    new XAttribute("version", "1.1.100")

                    ));

                var tmp = "spmeta2.csom.foundation";

                if (options.IsSSOM)
                    tmp = "spmeta2.ssom.foundation";

                packages.Add(new XElement("package",
                    new XAttribute("id", tmp),
                    new XAttribute("version", "1.1.100")
                    ));

                var xDoc = XDocument.Parse(File.ReadAllText(vsDefPath));
                xDoc.Root.Add(new XElement("WizardData", new XElement("packages", packages)));

                File.WriteAllText(vsDefPath, xDoc.ToString());

                Assembly asm = Assembly.Load("NuGet.VisualStudio.Interop, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a");
                wizard = (IWizard)asm.CreateInstance("NuGet.VisualStudio.TemplateWizard");

                wizard.RunStarted(automationObject, replacementsDictionary, runKind, customParams);
            }
        }

        private IWizard wizard;

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
