using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.VS.Tooling.Options
{

    public enum ProjectPlatform
    {
        None,
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
        #region constructors

        public M2IntranetProjectOptions()
        {
            ProjectPrefix = "Intr";

            SiteFieldsGroupName = "_Intr";
            SiteContentTypesGroupName = "_Intr";

            ProjectPlatform = ProjectPlatform.SP2013CSOM;
            ProjectType = ProjectType.Standard;
        }

        #endregion

        #region properties

        public string ProjectPrefix { get; set; }

        public ProjectPlatform ProjectPlatform { get; set; }
        public ProjectType ProjectType { get; set; }

        public string SiteFieldsGroupName { get; set; }
        public string SiteContentTypesGroupName { get; set; }

        #endregion

    }
}
