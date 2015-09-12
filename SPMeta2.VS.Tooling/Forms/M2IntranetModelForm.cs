using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPMeta2.VS.Tooling.Options;

namespace SPMeta2.VS.Tooling.Forms
{
    public partial class M2IntranetModelForm : Form, IM2WizardForm<M2IntranetProjectOptions>
    {
        public M2IntranetModelForm()
        {
            ProjectOptions = new M2IntranetProjectOptions();

            InitializeComponent();
            InitDefaultOptions();
        }

        private void InitDefaultOptions()
        {
            tbProjectPrefix.Text = ProjectOptions.ProjectPrefix;

            tbSiteFieldsGroup.Text = ProjectOptions.SiteFieldsGroupName;
            tbContentTypesGroup.Text = ProjectOptions.SiteContentTypesGroupName;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // TODO :)
            base.OnClosing(e);

            MapProjectOptions();

            if (HasValidOptions())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            MapProjectOptions();

            if (HasValidOptions())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void MapProjectOptions()
        {
            // global prefix
            if (!string.IsNullOrEmpty(tbProjectPrefix.Text))
                ProjectOptions.ProjectPrefix = tbProjectPrefix.Text.Trim();

            // consts
            if (!string.IsNullOrEmpty(tbSiteFieldsGroup.Text))
                ProjectOptions.SiteFieldsGroupName = tbSiteFieldsGroup.Text.Trim();

            if (!string.IsNullOrEmpty(tbProjectPrefix.Text))
                ProjectOptions.SiteContentTypesGroupName = tbContentTypesGroup.Text.Trim();

            // platform
            if (rbPlatformNoRefs.Checked)
                ProjectOptions.ProjectPlatform = ProjectPlatform.None;
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

        private bool HasValidOptions()
        {
            // TODO
            return true;
        }

        public M2IntranetProjectOptions ProjectOptions { get; set; }
    }
}
