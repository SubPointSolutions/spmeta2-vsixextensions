using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.VS.Tooling.Utils
{
    public class ProjectItemIterator : IEnumerable<EnvDTE.ProjectItem>
    {
        IEnumerable<EnvDTE.Project> projects;

        public ProjectItemIterator(EnvDTE.Solution solution)
        {
            if (solution == null)
                throw new ArgumentNullException("solution");

            projects = solution.Projects.Cast<EnvDTE.Project>();
        }

        public ProjectItemIterator(IEnumerable<EnvDTE.Project> projects)
        {
            if (projects == null)
                throw new ArgumentNullException("projects");

            this.projects = projects;
        }

        public IEnumerator<EnvDTE.ProjectItem> GetEnumerator()
        {
            foreach (EnvDTE.Project currentProject in projects)
                foreach (var currentProjectItem in Enumerate(currentProject.ProjectItems))
                    yield return currentProjectItem;
        }

        IEnumerable<EnvDTE.ProjectItem> Enumerate(EnvDTE.ProjectItems projectItems)
        {
            foreach (EnvDTE.ProjectItem item in projectItems)
            {
                yield return item;

                if (item.SubProject != null)
                {
                    foreach (EnvDTE.ProjectItem childItem in Enumerate(item.SubProject.ProjectItems))
                        yield return childItem;
                }
                else
                {
                    foreach (EnvDTE.ProjectItem childItem in Enumerate(item.ProjectItems))
                        yield return childItem;
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
