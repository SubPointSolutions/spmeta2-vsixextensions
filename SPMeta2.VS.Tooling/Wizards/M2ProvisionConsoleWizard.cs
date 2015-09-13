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
using SPMeta2.VS.Tooling.Services;
using SPMeta2.VS.Tooling.Utils;
using VSLangProj;

namespace SPMeta2.VS.Tooling.Wizards
{
    public class M2ProvisionConsoleWizard : M2WizardBase<M2ConsoleProvisionProjectService, M2ConsoleProjectOptions, M2ConsoleProvisionForm>
    {

    }
}
