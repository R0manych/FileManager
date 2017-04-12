using System;
using System.Windows.Forms;

namespace MyFileManager
{
    public partial class ConfirmFirm : Form
    {
        public ConfirmFirm()
        {
            InitializeComponent();
        }

        public bool Result => _result;

        private bool _result; 
        private void buttonOK_Click(object sender, EventArgs e)
        {
            _result = true;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _result = false;
            Close();
        }
    }
}
