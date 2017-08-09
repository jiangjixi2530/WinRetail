using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Retail
{
    public partial class FrmPurchase : Form
    {
        /// <summary>
        /// 选中的菜单
        /// </summary>
        private Label selectedLabel = new Label();
        /// <summary>
        /// 显示的功能控件 
        /// </summary>
        private Control showedControl = new Control();

        public FrmPurchase()
        {
            InitializeComponent();
        }

        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            SwitchControl(labPurchase);
        }
        private void SwitchControl(Label label)
        {
            if (label == selectedLabel)
                return;
            selectedLabel.Image = null;
            label.Image = Retail.Properties.Resources.Table_qy_prs;
            selectedLabel = label;
            showedControl.Visible = false;
            switch (label.Name.ToLower())
            {
                case "labpurchase":
                    purchaseControl1.Dock = DockStyle.Fill;
                    purchaseControl1.Visible = true;
                    showedControl = purchaseControl1;
                    break;
                case "labpayment":
                    payMentControl1.Dock = DockStyle.Fill;
                    payMentControl1.Visible = true;
                    showedControl = payMentControl1;
                    break;
                default: 
                    break;
            }
        }

        private void FunctionClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            SwitchControl(label);
        }
    }
}
