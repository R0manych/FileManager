using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFileManager
{
    /// <summary>
    /// TreeUtils contains methods for treenodes
    /// </summary>
    public static class TreeUtils
    {
        /// <summary>
        /// Refreshes node in treeView
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public static Task Refresh(TreeView treeView, TreeNode node)
        {
            node.Nodes.Clear();
            return FormUtils.SetDirectory(treeView, node, CreateFullPath(node));
        }

        public static Task SearchNodeByName(TreeNode owner, string name)
        {
            var t = new Task(() =>
            {
                var result = new List<TreeNode>();
                foreach (TreeNode elem in owner.Nodes)
                {
                    if (elem.Text.Contains(name))
                    {
                        result.Add(elem);
                    }
                }
                owner.Nodes.Clear();    
                owner.Nodes.AddRange(result.ToArray());
            });
            return t;
        }

        /// <summary>
        /// Sorts TreeView owner using specified comparer
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="comparer"></param>
        public static void SortTreeView(TreeNode owner, IComparer<TreeNode> comparer)
        {
            var files = new List<TreeNode>();
            var dirs = new List<TreeNode>();
            foreach (TreeNode elem in owner.Nodes)
            {
                if (!FileUtils.IsFile(CreateFullPath(elem)))
                    dirs.Add(elem);
                else
                    files.Add(elem);
            }
            files.Sort(comparer);
            dirs.Sort(comparer);
            owner.Nodes.Clear();
            owner.Nodes.AddRange(dirs.ToArray());
            owner.Nodes.AddRange(files.ToArray());
        }

        /// <summary>
        /// Recursively creates full path for node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static string CreateFullPath(TreeNode node)
        {
            var path = node.Text;
            var parentNode = node.Parent;
            while (parentNode != null)
            {
                path = parentNode.Text + '\\' + path;
                parentNode = parentNode.Parent;
            }
            return path;
        }
    }
}
