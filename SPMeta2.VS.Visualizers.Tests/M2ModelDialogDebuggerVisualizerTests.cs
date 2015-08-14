using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;
using SPMeta2.Models;
using SPMeta2.Syntax.Default;
using SPMeta2.VS.Visualizers.Impl;

namespace SPMeta2.VS.Visualizers.Tests
{
    [TestClass]
    public class M2ModelDialogDebuggerVisualizerTests
    {
        #region tests

        [TestMethod]
        public void CanCreate_Visualizer()
        {
            new M2ModelDialogDebuggerVisualizer();
        }

        [TestMethod]
        public void CanShow_Visualizer()
        {
            var model = GetTestModel();
            var vizType = typeof(M2ModelDialogDebuggerVisualizer);

            ValidateVizualizerForm(vizType, model);
        }

        [TestMethod]
        public void CanHandle_Visualizer_Exceptions()
        {
            try
            {
                M2ModelDialogDebuggerVisualizerService.ShouldThrowException = true;

                var model = GetTestModel();
                var vizType = typeof(M2ModelDialogDebuggerVisualizer);

                ValidateVizualizerForm(vizType, model);
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                M2ModelDialogDebuggerVisualizerService.ShouldThrowException = false;
            }

            Assert.IsTrue(M2ModelDialogDebuggerVisualizerService.HadException);
        }

        #endregion

        #region utils

        private static void ValidateVizualizerForm(Type vizType, ModelNode model)
        {
            var vizTypeConverter =
                Type.GetType(vizType.Assembly.GetCustomAttributes(typeof(DebuggerVisualizerAttribute), false)
                    .OfType<DebuggerVisualizerAttribute>()
                    .FirstOrDefault(a => a.VisualizerTypeName == vizType.AssemblyQualifiedName)
                    .VisualizerObjectSourceTypeName);

            var visualizerHost = new VisualizerDevelopmentHost(model,
                vizType,
                vizTypeConverter);

            var form = new Form();

            Timer r = new Timer();
            r.Tick += delegate
            {
                r.Stop();
                form.Close();
            };
            r.Interval = 1000;
            r.Start();

            visualizerHost.ShowVisualizer(form);

            r.Stop();
        }

        private static ModelNode GetTestModel()
        {
            var approvedDocuments = new ListViewDefinition
            {
                Title = "Approved Documents",
                Fields = new Collection<string>
        {
            BuiltInInternalFieldNames.ID,
            BuiltInInternalFieldNames.FileLeafRef
        }
            };

            var inProgressDocuments = new ListViewDefinition
            {
                Title = "In Progress Documents",
                Fields = new Collection<string>
        {
            BuiltInInternalFieldNames.ID,
            BuiltInInternalFieldNames.FileLeafRef
        }
            };

            var documentLibrary = new ListDefinition
            {
                Title = "CustomerDocuments",
                Description = "A customr document library.",
                TemplateType = BuiltInListTemplateTypeId.DocumentLibrary,
                Url = "CustomerDocuments"
            };

            var model = SPMeta2Model.NewWebModel(web =>
            {
                web.AddList(documentLibrary, list =>
                {
                    list.AddListView(approvedDocuments);
                    list.AddListView(inProgressDocuments);

                });
            });

            return model;
        }

        #endregion
    }
}
