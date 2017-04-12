using System;
using System.Windows.Forms;
using System.IO;

namespace MyFileManager
{
    public partial class FolderInfoForm : Form
    {
        public FolderInfoForm()
        {
            InitializeComponent();
        }

        private DirectoryInfo _direcoryInfo;

        public void SetFolderInfo(string path)
        {
            _direcoryInfo = new DirectoryInfo(path);
            textBoxName.Text = _direcoryInfo.Name;
            textBoxPath.Text = path;
            textBoxCreated.Text = _direcoryInfo.CreationTime.ToString();
            try
            {
                textBoxContains.Text = FileUtils.CountFilesInFolder(path);
            }
            catch (Exception ex)
            {
                textBoxContains.Text = ex.Message;
            }
            if ((_direcoryInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                checkBoxHidden.Checked = true;
            }
            if ((_direcoryInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                checkBoxReadOnly.Checked = true;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if ((_direcoryInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                if (!checkBoxHidden.Checked)
                {
                    FileUtils.RemoveHidden(_direcoryInfo);
                }
            }
            else
            {
                if (checkBoxHidden.Checked)
                    File.SetAttributes(_direcoryInfo.FullName, _direcoryInfo.Attributes | FileAttributes.Hidden);
            }

            if ((_direcoryInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                if (!checkBoxReadOnly.Checked)
                {
                    FileUtils.RemoveReadOnly(_direcoryInfo);
                }
            }
            else
            {
                if (checkBoxReadOnly.Checked)
                    File.SetAttributes(_direcoryInfo.FullName, _direcoryInfo.Attributes | FileAttributes.ReadOnly);
            }
            Close();
        }
    }
}
