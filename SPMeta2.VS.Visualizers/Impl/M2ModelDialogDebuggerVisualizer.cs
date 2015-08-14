using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;
using SPMeta2.Models;
using SPMeta2.Syntax.Default;
using SPMeta2.VS.Visualizers.Impl;

[assembly: DebuggerVisualizer(
       typeof(M2ModelDialogDebuggerVisualizer),
       typeof(M2ModelDialogDebuggerVisualizerObjectSource),
       Target = typeof(ModelNode),
       Description = "SPMeta2 Model Visualizer")]

namespace SPMeta2.VS.Visualizers.Impl
{
    public class M2ModelDialogDebuggerVisualizer : DialogDebuggerVisualizer
    {
        override protected void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            try
            {
                var obj = objectProvider.GetData();
                var modelNode = new M2ModelDialogDebuggerVisualizerService().DeserializeDataFromStream<ModelNode>(obj);

                var form = new Form
                {
                    ClientSize = new Size(800, 600),
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                };

                var treeView = new TreeView();
                treeView.Parent = form;
                treeView.Dock = DockStyle.Fill;

                InitNodes(treeView.Nodes, modelNode);
                treeView.ExpandAll();

                windowService.ShowDialog(form);
            }
            catch (Exception e)
            {
                // TODO
                throw;
            }
        }

        private void InitNodes(TreeNodeCollection treeNodeCollection, ModelNode modelNode)
        {
            var nodeValue = modelNode.Value;

            var newTreeNode = treeNodeCollection.Add(nodeValue == null
                ? "NULL"
                : string.Format("{0} - {1}", nodeValue.GetType().Name, nodeValue));

            foreach (var childNode in modelNode.ChildModels)
                InitNodes(newTreeNode.Nodes, childNode);
        }
    }
}
