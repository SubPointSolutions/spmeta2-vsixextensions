using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.VS.Tooling.Options
{

    public enum ProjectPlatform
    {
        SP2013SSOM,
        SP2013CSOM,
        O365CSOM
    }

    public enum ProjectType
    {
        Foundation,
        Standard
    }

    public class M2IntranetProjectOptions
    {
        public M2IntranetProjectOptions()
        {
            ProjectPrefix = "Intr";
            ProjectPlatform = ProjectPlatform.SP2013CSOM;
            ProjectType = ProjectType.Standard;
        }

        public string ProjectPrefix { get; set; }

        public ProjectPlatform ProjectPlatform { get; set; }
        public ProjectType ProjectType { get; set; }

    }
}
