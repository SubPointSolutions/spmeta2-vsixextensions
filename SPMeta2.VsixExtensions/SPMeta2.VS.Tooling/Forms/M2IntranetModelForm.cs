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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text))
                Options.ProjectPrefix = textBox1.Text;

            Options.IsSSOM = cbIsSSOM.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        public M2IntranetProjectOptions Options { get; set; }
    }


}
