using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions;
using System.IO;

namespace M2RootNamespace.Definitions.Solutions
{
    public static class M2ProjectPrefixSandboxSolutions
    {
        // Set 'FileName' which will be in the solution gallery
        // Set SolutionId (get it from the visual studio or from the unpacked *.wsp

        // Set byte[] Content as your *.wsp package, reading from the file system or assembly resource

        public static SandboxSolutionDefinition WebsiteBranding = new SandboxSolutionDefinition
        {
            FileName = "MyWebsiteBranding.wsp",
            SolutionId = new Guid("correct-solution-id-here"),
            Activate = true,
            Content = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\MyWebsiteBranding.wsp")
        };
    }
}
