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
    public partial class M2IntranetModelForm : Form
    {
        public M2IntranetModelForm()
        {
            Options = new M2IntranetProjectOptions();

            InitializeComponent();
            InitDefaultOptions();
        }

        private void InitDefaultOptions()
        {
            tbProjectPrefix.Text = Options.ProjectPrefix;
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
                Options.ProjectPrefix = tbProjectPrefix.Text.Trim();

            // platform
            if (rbPlatformSP2013SSOM.Checked)
                Options.ProjectPlatform = ProjectPlatform.SP2013SSOM;
            else if (rbPlatformSP2013CSOM.Checked)
                Options.ProjectPlatform = ProjectPlatform.SP2013CSOM;
            else if (rbPlatformO365CSOM.Checked)
                Options.ProjectPlatform = ProjectPlatform.O365CSOM;

            // type
            if (rbFoundation.Checked)
                Options.ProjectType = ProjectType.Foundation;
            else if (rbStandard.Checked)
                Options.ProjectType = ProjectType.Standard;
        }

        private bool HasValidOptions()
        {
            // TODO
            return true;
        }

        public M2IntranetProjectOptions Options { get; set; }
    }


}
