using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Win.Soft.Retail.RetailDal;
using Win.Soft.Retail.RetailModel;
using System.Threading;
using Retail.Controls;
using BaseTool;
namespace Retail.PurchaseControls
{
    public partial class PurchaseControl : UserControl
    {
        /// <summary>
        /// 采购单列表
        /// </summary>
        private List<Purchase> ListPurchase = new List<Purchase>();
        /// <summary>
        /// 采购单控件列表
        /// </summary>
        private List<PurchaseOrder> ListPurchaseOrder = new List<PurchaseOrder>();
        /// <summary>
        /// 采购单业务类
        /// </summary>
        private PurchaseDal dal = new PurchaseDal();
        /// <summary>
        /// 当前页
        /// </summary>
        private int CurrentPage = 1;
        /// <summary>
        /// 总页数
        /// </summary>
        private int TotalPage = 1;
        /// <summary>
        /// 选中的采购单
        /// </summary>
        private PurchaseOrder OrderSelected;
        public PurchaseControl()
        {
            InitializeComponent();
        }
        private void PurchaseControl_Load(object sender, EventArgs e)
        {
            this.labNoData.Visible = false;
            this.txtStartDate.Text = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
            this.txtEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.DataGridDetail.AutoGenerateColumns = false;
        }
        public void ShowData()
        {
            Thread ThQuery = new Thread(QueryData);
            ThQuery.IsBackground = true;
            ThQuery.Start();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        private void QueryData()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtEndDate.Text.Trim()) || string.IsNullOrEmpty(this.txtStartDate.Text.Trim()))
                {
                    SysHelper.AlertMsg("请选择查询日期");
                }
                else
                {
                    this.Invoke((EventHandler)delegate
                    {
                        this.PanelOrderList.Controls.Clear();
                        ListPurchaseOrder = new List<PurchaseOrder>();
                        ListPurchase = dal.GetDataList(this.txtStartDate.Text.Trim(), this.txtEndDate.Text.Trim() + " 23:59");
                        foreach (Purchase item in ListPurchase)// for (int i = ListPurchase.Count - 1; i >= 0; i--)
                        {
                            PurchaseOrder ordercontrol = new PurchaseOrder();
                            ordercontrol.CurrentItem = item;
                            ordercontrol.Dock = DockStyle.Top;
                            ordercontrol.PurchaseOrderClicked += new PurchaseOrder.PurchaseOrderClick((sender) => PurchaseOrderClick(sender));
                            this.PanelOrderList.Controls.Add(ordercontrol);
                            ListPurchaseOrder.Add(ordercontrol);
                        }
                        ShowDataByPage(1);
                    });
                }
            }
            catch
            {
                SysHelper.AlertMsg("查询发生异常，请确认查询条件和网络状态！");
            }

        }
        private void PurchaseOrderClick(object sender)
        {
            PurchaseOrder selected = (PurchaseOrder)sender;
            if (OrderSelected != null)
            {
                OrderSelected.OrderBackColor = Color.White;
            }
            OrderSelected = selected;
            OrderSelected.OrderBackColor = Color.LightBlue;// Color.FromArgb(222, 235, 255);
            ShowOrderDetail(OrderSelected.CurrentItem);
        }
        /// <summary>
        /// 显示数据
        /// </summary>
        private void ShowDataByPage(int Page)
        {
            int totalPage = 1, UseHeight = 0;
            this.Invoke((EventHandler)delegate
                   {
                       if (ListPurchase.Count == 0)
                           this.labNoData.Visible = true;
                       else
                           this.labNoData.Visible = false;
                       for (int i = ListPurchaseOrder.Count - 1; i >= 0; i--)
                       {
                           if (PanelCenter.Height - UseHeight >= ListPurchaseOrder[i].Height)
                           {
                               UseHeight += ListPurchaseOrder[i].Height;
                           }
                           else
                           {
                               totalPage++;
                               UseHeight = ListPurchaseOrder[i].Height;
                           }
                           if (totalPage == Page)
                               ListPurchaseOrder[i].Visible = true;
                           else
                               ListPurchaseOrder[i].Visible = false;
                       }
                       this.labTotalPage.Text = totalPage.ToString();
                       TotalPage = totalPage;
                       this.labCurrentPage.Text = Page.ToString();
                       CurrentPage = Page;
                   });
        }

        private void PanelPaint(object sender, PaintEventArgs e)
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

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            if (CurrentPage == 1)
                return;
            else
                ShowDataByPage(CurrentPage - 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage == TotalPage)
                return;
            else
                ShowDataByPage(CurrentPage + 1);
        }

        private void picTime_Click(object sender, EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "picStartTime":
                    this.mcEndDate.Visible = false;
                    this.mcStartDate.Visible = !this.mcStartDate.Visible;
                    break;
                case "picEndTime":
                    this.mcStartDate.Visible = false;
                    this.mcEndDate.Visible = !this.mcEndDate.Visible;
                    break;
            }
        }
        private void DateSelected(object sender, DateRangeEventArgs e)
        {
            switch (((MonthCalendar)sender).Name)
            {
                case "mcStartDate":
                    this.mcStartDate.Visible = false;
                    this.txtStartDate.Text = mcStartDate.SelectionStart.ToString("yyyy-MM-dd");
                    break;
                case "mcEndDate":
                    this.mcEndDate.Visible = false;
                    txtEndDate.Text = mcEndDate.SelectionStart.ToString("yyyy-MM-dd");
                    break;
            }
        }

        private void PanelOrderPaint(object sender, PaintEventArgs e)
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
                ButtonBorderStyle.Dashed);
        }

        private void PurchaseControl_SizeChanged(object sender, EventArgs e)
        {
            BaseDataDal basedal = new BaseDataDal();
            this.colPurchaseUnitID.DataSource = basedal.GetList(" TypeID=1").Tables[0];
            this.colPurchaseUnitID.ValueMember = "ID";
            this.colPurchaseUnitID.DisplayMember = "Name";
            this.colPurchaseUnitID.ValueType = typeof(Int32);
            this.PanelLeft.Width = (this.Width - 10) / 2;
            this.PanelRight.Width = this.PanelLeft.Width;
            this.PanelCondition.Location = new Point((this.PanelHead.Width - this.PanelCondition.Width) / 2, 10);
            this.PanelOrderList.Width = this.PanelCenter.Width - 2;
            this.labNoData.Location = new Point((this.PanelCenter.Width - this.labNoData.Width) / 2, (this.PanelCenter.Height - this.labNoData.Height) / 2);
            this.labTitleProductCode.Width = (this.PanelDetailTitle.Width - 250) / 2;
            this.labTitleProductName.Width = this.labTitleProductCode.Width;
            this.colProductCode.Width = this.labTitleProductName.Width;
            this.colProductName.Width = this.labTitleProductName.Width;
            Point DefaultLocation = new Point((this.PanelOrderControl.Width - 440) / 2, 8);
            this.btnDelete.Location = DefaultLocation;
            DefaultLocation = new Point(DefaultLocation.X + 90, DefaultLocation.Y);
            this.btnModify.Location = DefaultLocation;
            DefaultLocation = new Point(DefaultLocation.X + 90, DefaultLocation.Y);
            this.btnStockIn.Location = DefaultLocation;
            DefaultLocation = new Point(DefaultLocation.X + 90, DefaultLocation.Y);
            this.btnPay.Location = DefaultLocation;
            DefaultLocation = new Point(DefaultLocation.X + 90, DefaultLocation.Y);
            this.btnPrint.Location = DefaultLocation;
        }
        /// <summary>
        /// 显示订单信息
        /// </summary>
        /// <param name="SelectedOrder"></param>
        private void ShowOrderDetail(Purchase PurchaseOrder)
        {
            this.labManufacturerName.Text = PurchaseOrder.ManufacturerName;
            this.labTelePhone.Text = PurchaseOrder.Telephone;
            this.labCode.Text = PurchaseOrder.Code;
            this.labPurchaseDate.Text = PurchaseOrder.PurchaseDate.ToString("yyyy-MM-dd HH:mm:ss");
            this.labPurchaseCount.Text = PurchaseOrder.PurchaseCount.ToString();
            this.labPurchaseAmount.Text = PurchaseOrder.PurchaseAmount.ToString();
            this.labCreateDate.Text = PurchaseOrder.CreateDate.ToString("yyyy-MM-dd HH:mm:ss");
            this.labCreateUser.Text = PurchaseOrder.CreateUser;
            if (PurchaseOrder.IsPay)
            {
                this.labPayStatus.BackColor = Color.LightBlue;
                this.labPayStatus.ForeColor = Color.White;
                this.labPayStatus.Text = "已付款";
            }
            else
            {
                this.labPayStatus.BackColor = Color.Red;
                this.labPayStatus.ForeColor = Color.Black;
                this.labPayStatus.Text = "未付款";
            }
            if (PurchaseOrder.IsStockIn)
            {
                this.labStockStatus.BackColor = Color.LightBlue;
                this.labStockStatus.ForeColor = Color.White;
                this.labStockStatus.Text = "已入库";
            }
            else
            {
                this.labStockStatus.BackColor = Color.Red;
                this.labStockStatus.ForeColor = Color.Black;
                this.labStockStatus.Text = "未入库";
            }
            List<PurchaseDetail> ListDetail = (new PurchaseDetailDal()).GetPurchaseDetail(PurchaseOrder.ID);
            BindingList<PurchaseDetail> ListSource = new BindingList<PurchaseDetail>(ListDetail);
            this.DataGridDetail.DataSource = ListSource;
            this.btnDelete.Enabled = PurchaseOrder.IsSubmit == 0;
            this.btnModify.Enabled = PurchaseOrder.IsSubmit == 0;
            this.btnStockIn.Enabled = !PurchaseOrder.IsStockIn;
            this.btnPay.Enabled = !PurchaseOrder.IsPay;
            this.btnPrint.Enabled = true;
        }
        /// <summary>
        /// 功能按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name.ToLower())
            {
                case "btndelete":
                    Delete(OrderSelected.CurrentItem);
                    break;
                case "btnmodify":
                    using (FrmPurchaseEdit edit = new FrmPurchaseEdit(OrderSelected.CurrentItem))
                    {
                        if (((BaseMain)Global.MainForm).ShadeShowDialog(edit) == DialogResult.OK)
                        {
                            OrderSelected.RefreshData();
                            ShowOrderDetail(OrderSelected.CurrentItem);
                        }
                    }
                    break;
                case "btnadd":
                    using (FrmPurchaseEdit add = new FrmPurchaseEdit(new Purchase()))
                    {
                        if (((BaseMain)Global.MainForm).ShadeShowDialog(add) == DialogResult.OK)
                        {
                            QueryData();
                        }
                    }
                    break;
                default:
                    break;

            }
        }
        private void Delete(Purchase Order)
        {
            if (SysHelper.ConfirmMsg("确定要删除该订单吗？", "删除采购单") == System.Windows.Forms.DialogResult.OK)
            {
                if (dal.DeletePurchaseOrder(Order))
                {
                    this.PanelOrderList.Controls.Remove(OrderSelected);
                    ListPurchaseOrder.Remove(OrderSelected);
                    this.labManufacturerName.Text = string.Empty;
                    this.labTelePhone.Text = string.Empty;
                    this.labCode.Text = string.Empty;
                    this.labPurchaseDate.Text = string.Empty;
                    this.labPurchaseCount.Text = string.Empty;
                    this.labPurchaseAmount.Text = string.Empty;
                    this.labCreateDate.Text = string.Empty;
                    this.labCreateUser.Text = string.Empty;
                    this.labStockStatus.Text = string.Empty;
                    this.labStockStatus.Text = string.Empty;
                    this.btnDelete.Enabled = false;
                    this.btnModify.Enabled = false;
                    this.btnStockIn.Enabled = false;
                    this.btnPay.Enabled = false;
                    this.btnPrint.Enabled = false;
                    this.DataGridDetail.DataSource = null;
                }
            }
        }
    }
}
