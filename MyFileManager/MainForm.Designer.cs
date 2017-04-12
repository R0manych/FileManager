namespace MyFileManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.contextMenuNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxExplorer = new System.Windows.Forms.GroupBox();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonSort = new System.Windows.Forms.ToolStripDropDownButton();
            this.ascToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonNewFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.contextMenuNode.SuspendLayout();
            this.groupBoxExplorer.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "folder.jpg");
            this.imageListIcons.Images.SetKeyName(1, "file.jpg");
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.AllowDrop = true;
            this.treeViewFiles.ContextMenuStrip = this.contextMenuNode;
            this.treeViewFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewFiles.ImageIndex = 0;
            this.treeViewFiles.ImageList = this.imageListIcons;
            this.treeViewFiles.Location = new System.Drawing.Point(6, 19);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.SelectedImageIndex = 0;
            this.treeViewFiles.Size = new System.Drawing.Size(687, 373);
            this.treeViewFiles.TabIndex = 0;
            this.treeViewFiles.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterExpand);
            this.treeViewFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewFiles_ItemDrag);
            this.treeViewFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterSelect);
            this.treeViewFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewFiles_DragDrop);
            this.treeViewFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewFiles_DragEnter);
            this.treeViewFiles.DoubleClick += new System.EventHandler(this.treeViewFiles_DoubleClick);
            // 
            // contextMenuNode
            // 
            this.contextMenuNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.contextMenuNode.Name = "contextMenuNode";
            this.contextMenuNode.Size = new System.Drawing.Size(118, 114);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // groupBoxExplorer
            // 
            this.groupBoxExplorer.Controls.Add(this.treeViewFiles);
            this.groupBoxExplorer.Location = new System.Drawing.Point(12, 88);
            this.groupBoxExplorer.Name = "groupBoxExplorer";
            this.groupBoxExplorer.Size = new System.Drawing.Size(699, 398);
            this.groupBoxExplorer.TabIndex = 9;
            this.groupBoxExplorer.TabStop = false;
            this.groupBoxExplorer.Text = "Explorer";
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.textBoxPath);
            this.groupBoxPath.Location = new System.Drawing.Point(18, 28);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(537, 54);
            this.groupBoxPath.TabIndex = 15;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Path";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(6, 22);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(525, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewFolder,
            this.toolStripButtonCopy,
            this.toolStripButtonDelete,
            this.toolStripButtonNewFile,
            this.toolStripDropDownButtonSort});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(721, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonSort
            // 
            this.toolStripDropDownButtonSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascToolStripMenuItem,
            this.descToolStripMenuItem});
            this.toolStripDropDownButtonSort.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonSort.Image")));
            this.toolStripDropDownButtonSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonSort.Name = "toolStripDropDownButtonSort";
            this.toolStripDropDownButtonSort.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButtonSort.Text = "Order";
            // 
            // ascToolStripMenuItem
            // 
            this.ascToolStripMenuItem.Name = "ascToolStripMenuItem";
            this.ascToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ascToolStripMenuItem.Text = "Asc";
            this.ascToolStripMenuItem.Click += new System.EventHandler(this.buttonSortAsc_Click);
            // 
            // descToolStripMenuItem
            // 
            this.descToolStripMenuItem.Name = "descToolStripMenuItem";
            this.descToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.descToolStripMenuItem.Text = "Desc";
            this.descToolStripMenuItem.Click += new System.EventHandler(this.buttonSortDesc_Click);
            // 
            // toolStripButtonNewFolder
            // 
            this.toolStripButtonNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewFolder.Image")));
            this.toolStripButtonNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewFolder.Name = "toolStripButtonNewFolder";
            this.toolStripButtonNewFolder.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewFolder.Text = "New Folder";
            this.toolStripButtonNewFolder.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // toolStripButtonNewFile
            // 
            this.toolStripButtonNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewFile.Image")));
            this.toolStripButtonNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewFile.Name = "toolStripButtonNewFile";
            this.toolStripButtonNewFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewFile.Text = "Delete";
            this.toolStripButtonNewFile.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCopy.Text = "New File";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.buttonNewFile_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "Copy";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(561, 28);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(150, 54);
            this.groupBoxSearch.TabIndex = 14;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(9, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(135, 20);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 498);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxPath);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxExplorer);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuNode.ResumeLayout(false);
            this.groupBoxExplorer.ResumeLayout(false);
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.TreeView treeViewFiles;
        private System.Windows.Forms.GroupBox groupBoxExplorer;
        private System.Windows.Forms.ContextMenuStrip contextMenuNode;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSort;
        private System.Windows.Forms.ToolStripMenuItem ascToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewFolder;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewFile;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}