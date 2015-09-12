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

    public class M2ProjectOptions
    {
        public ProjectPlatform ProjectPlatform { get; set; }
        public ProjectType ProjectType { get; set; }
    }

    public class M2ConsoleProjectOptions : M2ProjectOptions
    {

    }

    public class M2IntranetProjectOptions : M2ProjectOptions
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

        public string M2ProjectPrefix
        {
            get { return ProjectPrefix; }
        }
        
        public string SiteFieldsGroupName { get; set; }
        public string SiteContentTypesGroupName { get; set; }

        #endregion

    }
}
