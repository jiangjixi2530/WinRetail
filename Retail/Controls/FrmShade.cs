using System;
using System.Windows.Forms;

namespace Retail.Controls
{
    public partial class FrmShade : Form
    {
        Form ShowForm;
        public FrmShade(Form frm)
        {
            InitializeComponent();
            ShowForm = frm;
        }

        private void FrmShade_Load(object sender, EventArgs e)
        {
            ShowForm.FormClosed += ShowForm_FormClosed;
        }

        void ShowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = ShowForm.DialogResult;
            this.Close();
        }

        private void FrmShade_Shown(object sender, EventArgs e)
        {
            ShowForm.ShowDialog();
        }
    }
}
