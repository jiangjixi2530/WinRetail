﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Win.Soft.Retail.RetailDal;
using Win.Soft.Retail.RetailModel;

namespace Retail.FinanceControls
{
    public partial class PayMentControl : UserControl
    {

        /// <summary>
        /// 未结清的采购单信息
        /// </summary>
        private BindingList<Purchase> listUnPurchase;
        /// <summary>
        /// 采购单业务类
        /// </summary>
        private PurchaseDal purchaseDal = new PurchaseDal();
        private List<UnPayOrder> listUnPayOrder = new List<UnPayOrder>();
        public PayMentControl()
        {
            InitializeComponent();
        }

        private void FrmPayMent_Load(object sender, EventArgs e)
        {
            this.txtPurchaseStartDate.Text = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
            this.txtPurchaseEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnPurchaseQuery_Click(object sender, EventArgs e)
        {
            Thread threadQuery = new Thread(PurchaseDataQuery);
            threadQuery.IsBackground = true;
            threadQuery.Start();
        }
        /// <summary>
        /// 数据查询
        /// </summary>
        /// <param name="frm"></param>
        private void PurchaseDataQuery(object frm)
        {
            DateTime StartDate = Convert.ToDateTime(this.txtPurchaseStartDate.Text);
            DateTime EndDate = Convert.ToDateTime(this.txtPurchaseEndDate.Text);
            listUnPurchase = new BindingList<Purchase>(purchaseDal.GetUnPayPurchase(StartDate, EndDate));
            listUnPayOrder = new List<UnPayOrder>();
            foreach (Purchase item in listUnPurchase)
            {
                UnPayOrder control = new UnPayOrder(item);
                control.Width = PanelUnPayCenter.Width - 2;
                listUnPayOrder.Add(control);
            }
            PanelUnPayCenter.ListPageControls = listUnPayOrder.OfType<Control>().ToList();
            PanelUnPayCenter.RefreshPage();
        }
        #region 功能切换
        /// <summary>
        /// 未结清账款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labUnPay_Click(object sender, EventArgs e)
        {
            this.PanelPurchaseUnPay.Dock = DockStyle.Fill;
            this.PanelPurchaseUnPay.Visible = true;
            this.panelPurchasePaid.Visible = false;
            labPaied.BackColor = Color.White;
            labPaied.ForeColor = Color.FromArgb(76, 76, 76);
            labUnPay.BackColor = Color.FromArgb(27, 130, 207);
            labUnPay.ForeColor = Color.White;
        }
        /// <summary>
        /// 付款订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labPaied_Click(object sender, EventArgs e)
        {
            this.panelPurchasePaid.Dock = DockStyle.Fill;
            this.panelPurchasePaid.Visible = true;
            this.PanelPurchaseUnPay.Visible = false;
            labUnPay.BackColor = Color.White;
            labUnPay.ForeColor = Color.FromArgb(76, 76, 76);
            labPaied.BackColor = Color.FromArgb(27, 130, 207);
            labPaied.ForeColor = Color.White;
        }
        #endregion

        private void panelFunction_Paint(object sender, PaintEventArgs e)
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

        private void PanelAll_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics,
                panel.ClientRectangle,
                 Color.FromArgb(210, 210, 210),
                1,
                ButtonBorderStyle.Solid,
                 Color.FromArgb(210, 210, 210),
                1,
                ButtonBorderStyle.Solid,
                 Color.FromArgb(210, 210, 210),
                1,
                ButtonBorderStyle.Solid,
                 Color.FromArgb(210, 210, 210),
                1,
                ButtonBorderStyle.Solid);
        }

        private void picTime_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            switch (pic.Name)
            {
                case "picStartTime":
                    this.mcPurchaseStartDate.Location = new Point(26, 128);
                    this.mcPurchaseEndDate.Visible = false;
                    this.mcPurchaseStartDate.Visible = !this.mcPurchaseStartDate.Visible;
                    this.mcPurchaseStartDate.BringToFront();
                    break;
                case "picEndTime":
                    this.mcPurchaseEndDate.Location = new Point(191, 128);
                    this.mcPurchaseStartDate.Visible = false;
                    this.mcPurchaseEndDate.Visible = !this.mcPurchaseEndDate.Visible;
                    this.mcPurchaseEndDate.BringToFront();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 窗体变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayMentControl_SizeChanged(object sender, EventArgs e)
        {
            panelDataList.Width = this.Width / 2 - 5;
            panelPurchasePaid.Width = panelDataList.Width;
        }
        /// <summary>
        /// 日期选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateSelected(object sender, DateRangeEventArgs e)
        {
            switch (((MonthCalendar)sender).Name)
            {
                case "mcPurchaseStartDate":
                    this.mcPurchaseStartDate.Visible = false;
                    this.txtPurchaseStartDate.Text = mcPurchaseStartDate.SelectionStart.ToString("yyyy-MM-dd");
                    break;
                case "mcPurchaseEndDate":
                    this.mcPurchaseEndDate.Visible = false;
                    this.txtPurchaseEndDate.Text = mcPurchaseEndDate.SelectionStart.ToString("yyyy-MM-dd");
                    break;
            }
        }
    }
}
