using System.Collections.Generic;
using System.Windows.Forms;

namespace MyFileManager
{
    class DescTreeViewSorter : IComparer<TreeNode>
    {
        public int Compare(TreeNode x, TreeNode y)
        {
            var tx = x as TreeNode;
            var ty = y as TreeNode;
            return string.Compare(tx.Text, ty.Text);
        }          
    }

    class AscTreeViewSorter : IComparer<TreeNode>
    {
        public int Compare(TreeNode x, TreeNode y)
        {
            var tx = x as TreeNode;
            var ty = y as TreeNode;
            return string.Compare(ty.Text, tx.Text);
        }
    }
}
