using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace SPMeta2.VS.Tooling.Packages
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("M2 Extensions", "", "3.0")]
    [ProvideAutoLoad("{f1536ef8-92ec-443c-9ed7-fdadf150da82}")]
    //[ProvideAutoLoad(Microsoft.VisualStudio.VSConstants.UICONTEXT.NoSolution_string)]
    [Guid("CBBB8ABF-B5EA-460E-94CB-5757D2C885F9")]

    public sealed class M2Package : Package
    {
        #region constructors
        public M2Package()
        {
            Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", this.ToString()));

            InitVisFileNames();
        }

        private void InitVisFileNames()
        {
            VisFileNames = new List<string>
            {
                "SPMeta2.VS.Visualizers.dll"
            };
        }

        #endregion

        #region properties

        public List<string> VisFileNames { get; set; }

        #endregion

        #region methods

        protected override void Initialize()
        {
            Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));

            try
            {
                base.Initialize();

                EnsureVisFiles(VisFileNames);
            }
            catch (Exception ex)
            {
                // TODO
                Debug.WriteLine(ex.ToString());
            }

        }

        private void EnsureVisFiles(IEnumerable<string> visFileNames)
        {
            var myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            foreach (var fileName in visFileNames)
            {
                var srcFolderFullName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var srcFileFullName = Path.Combine(srcFolderFullName, fileName);

                var targetVsFolder = GetTargetVsFolder();

                var dstFolderFullName = Path.Combine(myDocumentsFolder, targetVsFolder);
                var dstFileFullName = Path.Combine(dstFolderFullName, fileName);

                if (File.Exists(dstFileFullName))
                {
                    File.Copy(srcFileFullName, dstFileFullName, true);
                }
                else
                {
                    File.Copy(srcFileFullName, dstFileFullName);
                }
            }
        }

        private static string GetTargetVsFolder()
        {
            var targetVsFolder = "Visual Studio 2013\\Visualizers";

            var version = ((EnvDTE.DTE)ServiceProvider.GlobalProvider.GetService(typeof(EnvDTE.DTE).GUID)).Version;
            var typedVersion = Version.Parse(version);

            if (typedVersion.Major == 10)
                targetVsFolder = "Visual Studio 2010\\Visualizers";
            else if (typedVersion.Major == 11)
                targetVsFolder = "Visual Studio 2012\\Visualizers";
            else if (typedVersion.Major == 12)
                targetVsFolder = "Visual Studio 2013\\Visualizers";
            else if (typedVersion.Major == 14)
                targetVsFolder = "Visual Studio 2015\\Visualizers";
            else
            {
                // TODO
                Debug.WriteLine("Unsupported VS Version: " + version);
                return string.Empty;
            }

            return targetVsFolder;
        }

        #endregion

    }
}
