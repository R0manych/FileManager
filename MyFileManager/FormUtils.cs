using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.IO.Directory;

namespace MyFileManager
{
    public static class FormUtils
    {
        delegate void SetNodeCallBack(TreeView treeViewFiles, TreeNode node, string name);

        /// <summary>
        /// SetRoot sets the root directory to the explorer
        /// </summary>
        public static void SetRoot(TreeView treeViewFiles)
        {
            var driveNames = FileUtils.GetDriveName();
            foreach (var driveName in driveNames)
            {
                var node = new TreeNode(driveName);
                node.Nodes.Add("dummy");
                treeViewFiles.Nodes.Add(node);
            }
        }

        /// <summary>
        /// SetDirectory lists directories and files for the directory in node
        /// </summary>
        /// <param name="node"></param>
        public static Task SetDirectory(TreeView treeViewFiles, TreeNode node, string path)
        {
            var t = new Task(() =>
            {
                var dirs = new ConcurrentBag<string>();
                try
                {
                    FileUtils.GetDirsIndDirectory(path, dirs);
                    foreach (var dirName in dirs)
                    {
                        SetDirToNode(treeViewFiles, node, dirName);
                    }
                    var files = FileUtils.GetFilesInDirectory(path);
                    foreach (var file in files)
                    {
                        SetFileToNode(treeViewFiles, node, file);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            });
            return t;
        }

        /// <summary>
        /// Adds directory name to directory in node
        /// </summary>
        /// <param name="node">Selected node</param>
        /// <param name="name">Name of the directory we want to attach to node</param>
        public static void SetDirToNode(TreeView treeViewFiles, TreeNode node, string name)
        {
            if (treeViewFiles.InvokeRequired)
            {
                var s = new SetNodeCallBack(SetDirToNode);
                treeViewFiles.Invoke(s, new object[] { treeViewFiles, node, name });
            }
            else
            {
                var tempNode = node.Nodes.Add(name);
                tempNode.ImageIndex = 0;
                tempNode.Nodes.Add("dummy");
            }
        }

        /// <summary>
        /// Adds file name to directory in node
        /// </summary>
        /// <param name="treeViewFiles"></param>
        /// <param name="node">Selected node</param>
        /// <param name="name">Name of the file we want to attach to node</param>
        public static void SetFileToNode(TreeView treeViewFiles, TreeNode node, string name)
        {
            if (treeViewFiles.InvokeRequired)
            {
                var s = new SetNodeCallBack(SetFileToNode);
                treeViewFiles.Invoke(s, treeViewFiles, node, name);
            }
            else
            {
                var tempNode = node.Nodes.Add(name);
                tempNode.ImageIndex = 1;
            }
        }

        /// <summary>
        /// Determine whether one node is a parent or ancestor of a second node.
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2" />
        /// <returns></returns>
        public static bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            if (node2.Parent == null) return false;
            if (node2.Parent.Equals(node1)) return true;
            return ContainsNode(node1, node2.Parent);
        }

        public static void DragNodeFiles(TreeNode draggedNode, TreeNode targetNode)
        {
            Move(TreeUtils.CreateFullPath(draggedNode), TreeUtils.CreateFullPath(targetNode) + '\\' + draggedNode.Text);
        }  
    }
}
