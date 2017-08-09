using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Win.Soft.Retail.RetailModel;
namespace Retail.PurchaseControls
{
    public partial class PurchaseOrder : UserControl
    {
        /// <summary>
        /// 点击事件委托
        /// </summary>
        /// <param name="sender"></param>
        public delegate void PurchaseOrderClick(object sender);
        /// <summary>
        /// 点击事件
        /// </summary>
        public PurchaseOrderClick PurchaseOrderClicked;
        /// <summary>
        /// 设置背景色
        /// </summary>
        public Color OrderBackColor
        {
            get { return this.PanelOrder.BackColor; }
            set
            {
                this.PanelOrder.BackColor = value;
            }
        }
        public PurchaseOrder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示的采购单
        /// </summary>
        private Purchase _CurrentItem;
        /// <summary>
        /// 显示的采购单
        /// </summary>
        public Purchase CurrentItem
        {
            get { return _CurrentItem; }
            set
            {
                _CurrentItem = value;
                ShowPurchaseInfo();
            }
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(0, 70);
        }
        /// <summary>
        /// 显示详情
        /// </summary>
        private void ShowPurchaseInfo()
        {
            if (CurrentItem == null)
                return;
            this.labManufacturer.Text = CurrentItem.ManufacturerName;
            this.labCodeValue.Text = CurrentItem.Code;
            this.labPurchaseDateValue.Text = CurrentItem.PurchaseDate.ToString("yyyy-MM-dd");
            this.labRelationValue.Text = CurrentItem.Relation;
            this.labTelephoneValue.Text = CurrentItem.Telephone;
            this.labPurchaseCountValue.Text = CurrentItem.PurchaseCount.ToString("0.##");
            this.labPurchaseAmountValue.Text = "¥" + CurrentItem.PurchaseAmount.ToString("0.00");
        }
        public void RefreshData()
        {
            ShowPurchaseInfo();
        }
        private void PanelOrder_Click(object sender, EventArgs e)
        {
            if (PurchaseOrderClicked != null)
                PurchaseOrderClicked(this);
        }

        private void PanelOrder_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics,
                panel.ClientRectangle,
                 Color.FromArgb(210, 210, 210),
                0,
                ButtonBorderStyle.Solid,
                 Color.FromArgb(210, 210, 210),
                0,
                ButtonBorderStyle.Solid,
                 Color.FromArgb(210, 210, 210),
                0,
                ButtonBorderStyle.Solid,
                 Color.FromArgb(210, 210, 210),
                1,
                ButtonBorderStyle.Solid);
        }

    }
}
