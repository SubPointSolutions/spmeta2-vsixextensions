using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using SPMeta2.VS.Tooling.Forms;
using SPMeta2.VS.Tooling.Options;
using SPMeta2.VS.Tooling.Services;

namespace SPMeta2.VS.Tooling.Wizards
{
    public class M2WizardBase<TProjectSetupService, TProjectOptions, TWizardForm> : IWizard
        where TProjectOptions : M2ProjectOptions, new()
        where TProjectSetupService : VSProjectSetupServiceBase<TProjectOptions>, new()
        where TWizardForm : Form, IM2WizardForm<TProjectOptions>, new()
    {
        protected IWizard _nuGetWizard;
        protected TWizardForm _wizardForm = new TWizardForm();

        private TProjectOptions _projectOptions;
        private TProjectSetupService _projectSetupService = new TProjectSetupService();

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
            if (_nuGetWizard != null)
                _nuGetWizard.BeforeOpeningFile(projectItem);
        }

        public void ProjectFinishedGenerating(Project project)
        {
            _projectSetupService.SetupM2IntranetProject(project, _projectOptions);

            if (_nuGetWizard != null)
                _nuGetWizard.ProjectFinishedGenerating(project);
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            if (_nuGetWizard != null)
                _nuGetWizard.ProjectItemFinishedGenerating(projectItem);
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        public void RunFinished()
        {
            if (_nuGetWizard != null)
                _nuGetWizard.RunFinished();
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary,
           WizardRunKind runKind, object[] customParams)
        {
            var shouldProcessProject = true;

            if (_wizardForm is HiddenForm<TProjectOptions>)
                shouldProcessProject = true;
            else
            {
                var result = _wizardForm.ShowDialog();
                shouldProcessProject = result == DialogResult.OK;
            }

            if (shouldProcessProject)
            {
                _projectOptions = _wizardForm.ProjectOptions;

                // update replacement mapppings
                _projectSetupService.MapProjectProperties(replacementsDictionary, _projectOptions);

                // re-generate nuget packages
                if (_projectSetupService.UpdateVSProjectNuGetPackages(_projectOptions, customParams[0].ToString()))
                {
                    // run nuget stuff
                    var asm = Assembly.Load("NuGet.VisualStudio.Interop, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a");

                    _nuGetWizard = (IWizard)asm.CreateInstance("NuGet.VisualStudio.TemplateWizard");
                    _nuGetWizard.RunStarted(automationObject, replacementsDictionary, runKind, customParams);
                }
            }
        }
    }
}
