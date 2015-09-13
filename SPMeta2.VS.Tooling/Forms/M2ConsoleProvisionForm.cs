using SPMeta2.VS.Tooling.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPMeta2.VS.Tooling.Forms
{
    public partial class M2ConsoleProvisionForm : Form,
        IM2WizardForm<M2ConsoleProjectOptions>
    {
        public M2ConsoleProvisionForm()
        {
            InitializeComponent();

            ProjectOptions = new M2ConsoleProjectOptions();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // TODO :)
            base.OnClosing(e);

            MapProjectOptions();

            DialogResult = DialogResult.OK;
        }

        private void MapProjectOptions()
        {
            if (rbPlatformSP2013SSOM.Checked)
                ProjectOptions.ProjectPlatform = ProjectPlatform.SP2013SSOM;
            else if (rbPlatformSP2013CSOM.Checked)
                ProjectOptions.ProjectPlatform = ProjectPlatform.SP2013CSOM;
            else if (rbPlatformO365CSOM.Checked)
                ProjectOptions.ProjectPlatform = ProjectPlatform.O365CSOM;

            // type
            if (rbFoundation.Checked)
                ProjectOptions.ProjectType = ProjectType.Foundation;
            else if (rbStandard.Checked)
                ProjectOptions.ProjectType = ProjectType.Standard;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            MapProjectOptions();

            DialogResult = DialogResult.OK;
            Close();
        }

        public M2ConsoleProjectOptions ProjectOptions { get; set; }
    }
}
