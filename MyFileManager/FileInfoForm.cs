using System.IO;
using System.Windows.Forms;

namespace MyFileManager
{
    public partial class FileInfoForm : Form
    {
        public FileInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Writes info about file to textboxes
        /// </summary>
        /// <param name="path"></param>
        public void SetFileInfo(string path)
        {
            var fi = new FileInfo(path);
            textBoxDir.Text = fi.DirectoryName;
            textBoxFile.Text = fi.Name;
            textBoxSize.Text = fi.Length.ToString();
            textBoxCreated.Text = fi.CreationTime.ToString();
            textBoxFileData.Text = FileUtils.GetFileString(path);
        }

        public void ResetInfo() => textBoxFileData.Text = "";
    }
}
