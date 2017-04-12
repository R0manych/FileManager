using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyFileManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormUtils.SetRoot(treeViewFiles);
        }

        /// <summary>
        /// Loading directories and files to current node
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewFiles_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (!FileUtils.IsFile(TreeUtils.CreateFullPath(e.Node)))
            {
                e.Node.Nodes.Clear();
                try
                {
                    var path = TreeUtils.CreateFullPath(e.Node);
                    var t = FormUtils.SetDirectory(treeViewFiles, e.Node, path);
                    t.Start();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }
        }

        /// <summary>
        /// If file was selected, writes its data to the textboxFileData ands loads info about file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (FileUtils.IsFile(TreeUtils.CreateFullPath(treeViewFiles.SelectedNode)))
            {
                e.Node.SelectedImageIndex = 1;
            }
            textBoxPath.Text = TreeUtils.CreateFullPath(treeViewFiles.SelectedNode);
        }

        /// <summary>
        /// Deletes selected node
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmForm = new ConfirmFirm();
                Enabled = false;
                confirmForm.ShowDialog(this);
                Enabled = true;
                if (confirmForm.Result)
                {
                    var path = TreeUtils.CreateFullPath(treeViewFiles.SelectedNode);
                    try
                    {
                        if (FileUtils.IsFile(path))
                        {
                            FileSystem.DeleteFile(path, UIOption.AllDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);
                        }
                        else
                        {
                            FileSystem.DeleteDirectory(path, UIOption.AllDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);
                        }
                        treeViewFiles.SelectedNode.Remove();
                    }
                    catch
                    {
                        MessageBox.Show("You can't delete this.");
                    }
                }
                confirmForm.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Creates a copy of a selected node if it is a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            var path = TreeUtils.CreateFullPath(treeViewFiles.SelectedNode);
            try
            {
                var node = new TreeNode();
                var pathCopy = "";
                if (FileUtils.IsFile(path))
                {
                    pathCopy = FileUtils.MakeCopyFileName(path);
                    File.Copy(path, pathCopy, false);                    
                    node.ImageIndex = 1;
                }
                else
                {
                    pathCopy = FileUtils.MakeCopyDirectoryName(path);
                    FileSystem.CopyDirectory(path, pathCopy, false);
                    node.ImageIndex = 0;
                    node.Nodes.Add("dummy");
                }
                node.Text = Path.GetFileName(pathCopy);
                treeViewFiles.SelectedNode.Parent.Nodes.Add(node);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Refrershes selected node
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            var path = TreeUtils.CreateFullPath(treeViewFiles.SelectedNode);
            if (!FileUtils.IsFile(path))
            {
                var t = TreeUtils.Refresh(treeViewFiles, treeViewFiles.SelectedNode);
                t.Start();
            }
        }

        private void treeViewFiles_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void treeViewFiles_DragEnter(object sender, DragEventArgs e) => e.Effect = e.AllowedEffect;

        private void treeViewFiles_DragDrop(object sender, DragEventArgs e)
        {
            var targetPoint = treeViewFiles.PointToClient(new Point(e.X, e.Y));
            var targetNode = treeViewFiles.GetNodeAt(targetPoint);
            var draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (!draggedNode.Equals(targetNode) && !FormUtils.ContainsNode(draggedNode, targetNode))
            {
                try
                {
                    FormUtils.DragNodeFiles(draggedNode, targetNode);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (e.Effect == DragDropEffects.Move)
                {
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                }                            
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = TreeUtils.CreateFullPath(treeViewFiles.SelectedNode);
            if (FileUtils.IsFile(path))
            {
                var infoForm = new FileInfoForm();
                infoForm.SetFileInfo(path);
                infoForm.Owner = this;
                infoForm.Show();
            }
            else
            {
                var infoForm = new FolderInfoForm();
                infoForm.SetFolderInfo(path);
                infoForm.Owner = this;
                infoForm.Show();
            }
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            var fileName = InputFormString();
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    FileUtils.Rename(TreeUtils.CreateFullPath(treeViewFiles.SelectedNode), fileName);
                    treeViewFiles.SelectedNode.Text = fileName;
                    textBoxPath.Text = TreeUtils.CreateFullPath(treeViewFiles.SelectedNode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonNewFolder_Click(object sender, EventArgs e)
        {
            var folderName = InputFormString();
            if (!String.IsNullOrEmpty(folderName))
            {
                var path = TreeUtils.CreateFullPath(treeViewFiles.SelectedNode) + '\\' + folderName;
                Directory.CreateDirectory(path);
                var node = new TreeNode(folderName) {ImageIndex = 0};
                treeViewFiles.SelectedNode.Nodes.Add(node);
            }
        }

        private void buttonNewFile_Click(object sender, EventArgs e)
        {
            var fileName = InputFormString();
            if  (!String.IsNullOrEmpty(fileName))
            {
                try
                {
                    File.Create(TreeUtils.CreateFullPath(treeViewFiles.SelectedNode) + '\\' + fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                var node = new TreeNode(fileName);
                node.ImageIndex = 1;
                treeViewFiles.SelectedNode.Nodes.Add(node);
            }
        }

        private string InputFormString()
        {
            var fileName = "";
            using (var inputForm = new InputNameForm())
            {
                Enabled = false;
                inputForm.ShowDialog(this);
                fileName = inputForm.FileName;
                inputForm.Dispose();
            }
            Enabled = true;
            return fileName;
        }

        private void treeViewFiles_DoubleClick(object sender, EventArgs e)
        {
            var path = TreeUtils.CreateFullPath(treeViewFiles.SelectedNode);
            if (FileUtils.IsFile(path))
                Process.Start(path);
        }

        private void buttonSortDesc_Click(object sender, EventArgs e) => TreeUtils.SortTreeView(treeViewFiles.SelectedNode, new DescTreeViewSorter());

        private void buttonSortAsc_Click(object sender, EventArgs e) => TreeUtils.SortTreeView(treeViewFiles.SelectedNode, new AscTreeViewSorter());

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var refresh = TreeUtils.Refresh(treeViewFiles, treeViewFiles.SelectedNode);
                var search = TreeUtils.SearchNodeByName(treeViewFiles.SelectedNode, textBoxSearch.Text);             
                refresh.RunSynchronously();
                search.RunSynchronously();
            }
        }
    }   
}
