using System;
using System.Windows.Forms;

namespace MyFileManager
{
    public partial class InputNameForm : Form
    {
        public InputNameForm()
        {
            InitializeComponent();
        }

        private string _textValue;

        public string FileName => _textValue;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _textValue = textBoxName.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
