using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPMeta2.VS.Tooling.Options;

namespace SPMeta2.VS.Tooling.Forms
{
    public interface IM2WizardForm<TProjectOptions>
        where TProjectOptions : M2ProjectOptions, new()
    {
        TProjectOptions ProjectOptions { get; set; }
    }
}
