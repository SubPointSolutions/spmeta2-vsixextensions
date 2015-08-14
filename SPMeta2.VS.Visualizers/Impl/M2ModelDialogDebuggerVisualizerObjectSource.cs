using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DebuggerVisualizers;
using SPMeta2.Models;
using SPMeta2.Syntax.Default;

namespace SPMeta2.VS.Visualizers.Impl
{
    public class M2ModelDialogDebuggerVisualizerObjectSource : VisualizerObjectSource
    {
        public override void GetData(object target, Stream outgoingData)
        {
            new M2ModelDialogDebuggerVisualizerService().SerializeDataToStream(target, outgoingData);
        }
    }
}
