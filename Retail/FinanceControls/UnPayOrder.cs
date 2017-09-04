using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Win.Soft.Retail.RetailModel;

namespace Retail.FinanceControls
{
    public partial class UnPayOrder : UserControl
    {
        /// <summary>
        /// 未结清账单
        /// </summary>
        private Purchase unPayOrderInfo;
        /// <summary>
        /// 未结清采购单
        /// </summary>
        public Purchase UnPayOrderInfo
        {
            get { return unPayOrderInfo; }
        }
        /// <summary>
        /// 是否选中
        /// </summary>
        private bool isSelected = false;
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelected
        {
            get { return isSelected; }
            set 
            { 
                isSelected = value;
                if(value)
                {
                    btnSelected.BackgroundImage = Retail.Properties.Resources.radioChecked;
                }
                else
                {
                    btnSelected.BackgroundImage = Retail.Properties.Resources.radioUnCheck;
                }
            }
        }
        public UnPayOrder(Purchase orderInfo)
        {
            InitializeComponent();
            unPayOrderInfo = orderInfo;
        }

        private void UnPayOrder_Load(object sender, EventArgs e)
        {
            if (unPayOrderInfo == null)
                return;
            this.labManufacturer.Text = unPayOrderInfo.ManufacturerName;
            this.labCodeValue.Text = unPayOrderInfo.Code;
            this.labPurchaseDateValue.Text = unPayOrderInfo.PurchaseDate.ToString("yyyy-MM-dd");
            this.labRelationValue.Text = unPayOrderInfo.Relation;
            this.labTelephoneValue.Text = unPayOrderInfo.Telephone;
            this.labPurchaseCountValue.Text = unPayOrderInfo.PurchaseCount.ToString("0.##");
            this.labPurchaseAmountValue.Text = "¥" + unPayOrderInfo.PurchaseAmount.ToString("0.00");
            this.labUnPayAmountValue.Text = "¥" + unPayOrderInfo.UnPayAmount.ToString("0.00");
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

        private void btnSelected_Click(object sender, EventArgs e)
        {
            IsSelected = !isSelected;
            try
            {
                if (this.Parent.Parent.Parent.Parent is PayMentControl)
                {
                    PayMentControl payMent = (PayMentControl)this.Parent.Parent.Parent.Parent;
                    if (payMent.UnPayOrderSelectChangeEvent != null)
                        payMent.UnPayOrderSelectChangeEvent(this);
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// 单笔付款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Parent.Parent.Parent.Parent is PayMentControl)
                {
                    PayMentControl payMent = (PayMentControl)this.Parent.Parent.Parent.Parent;
                    if (payMent.SinglePayEvent != null)
                        payMent.SinglePayEvent(this);
                }
            }
            catch
            {

            }
        }
    }
}
