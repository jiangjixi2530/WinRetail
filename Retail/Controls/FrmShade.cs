using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.DialogResult = ShowForm.DialogResult;
            ShowForm.FormClosed += ShowForm_FormClosed;
        }

        void ShowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FrmShade_Shown(object sender, EventArgs e)
        {
            ShowForm.ShowDialog();
        }
    }
}
