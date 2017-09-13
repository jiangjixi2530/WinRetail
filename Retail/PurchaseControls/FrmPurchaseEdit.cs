using BaseTool;
using Retail.Class;
using Retail.ProductControls;
using System;
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

namespace Retail.PurchaseControls
{
    public partial class FrmPurchaseEdit : Form
    {
        /// <summary>
        /// 采购单
        /// </summary>
        private Purchase CurrentOrder;
        /// <summary>
        /// 采购单Dal
        /// </summary>
        private PurchaseDal CurrentDal = new PurchaseDal();
        /// <summary>
        /// 采购单明细
        /// </summary>
        private BindingList<PurchaseDetail> ListDetailSource;
        ///// <summary>
        ///// 当前编辑的采购单
        ///// </summary>
        //public Purchase CurrentOrder
        //{
        //    get { return _CurrentOrder; }
        //    set { _CurrentOrder = value; }
        //}
        Thread saveThread;
        Thread loadProductSelectThread;
        public FrmPurchaseEdit(Purchase order)
        {
            InitializeComponent();
            if (order == null)
                CurrentOrder = new Purchase();
            else
                CurrentOrder = order;
            SetDetail();
        }
        /// <summary>
        /// 设置明细
        /// </summary>
        private void SetDetail()
        {
            this.cmbManufacturerID.SelectedValue = CurrentOrder.ManufacturerID;
            this.txtTelephone.Text = CurrentOrder.Telephone;
            this.txtRelation.Text = CurrentOrder.Relation;
            this.txtCode.Text = CurrentOrder.Code == null ? SysHelper.GetAutoCode(AutoCodeTypeEnum.Purchase) : CurrentOrder.Code;
            this.txtPurchaseDate.Text = CurrentOrder.PurchaseDate.ToString("yyyy-MM-dd");
            this.txtReceiver.Text = CurrentOrder.Receiver;
            this.txtReceiverPhone.Text = CurrentOrder.ReceiverPhone;
            this.txtPurchaseCount.Text = CurrentOrder.PurchaseCount.ToString();
            this.txtPurchaseAmount.Text = CurrentOrder.PurchaseAmount.ToString();
            this.txtReceiveAddress.Text = CurrentOrder.ReceiveAddress;
            List<PurchaseDetail> ListDetail = (new PurchaseDetailDal()).GetPurchaseDetail(CurrentOrder.ID);
            ListDetailSource = new BindingList<PurchaseDetail>(ListDetail);
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
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
        /// <summary>
        /// 点击保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            ComputeTotal();
            CurrentOrder.Code = this.txtCode.Text;
            CurrentOrder.PurchaseDate = Convert.ToDateTime(this.txtPurchaseDate.Text);
            CurrentOrder.ManufacturerID = Convert.ToInt32(cmbManufacturerID.SelectedValue);
            CurrentOrder.Relation = txtRelation.Text;
            CurrentOrder.Telephone = txtTelephone.Text;
            CurrentOrder.ReceiveAddress = txtReceiveAddress.Text;
            CurrentOrder.Receiver = txtReceiver.Text;
            CurrentOrder.ReceiverPhone = txtReceiverPhone.Text;
            CurrentOrder.PurchaseCount = Convert.ToDecimal(this.txtPurchaseCount.Text);
            CurrentOrder.PurchaseAmount = Convert.ToDecimal(this.txtPurchaseAmount.Text);
            CurrentOrder.CreateUserID = Global.UserID;
            saveThread = new Thread(Save);
            saveThread.IsBackground = true;
            saveThread.Start();
            Retail.Controls.FrmLoading.ManualClosed += LoadingManualClosed;
            SysHelper.ShowLoading(saveThread);
        }
        /// <summary>
        /// 手动关闭加载框 将加载时所进行的线程强制关闭
        /// </summary>
        /// <param name="sender"></param>
        private void LoadingManualClosed(object sender)
        {
            try
            {
                ((Thread)sender).Abort();
            }
            catch
            {
            }
        }
        /// <summary>
        /// 数据保存
        /// </summary>
        /// <returns></returns>
        private void Save()
        {
            bool isSuccess = false;
            try
            {
                isSuccess = CurrentDal.SaveObject(CurrentOrder, new List<PurchaseDetail>(ListDetailSource));
            }
            catch
            {

            }
            finally
            {
                this.Invoke((EventHandler)delegate
                    {
                        SysHelper.CloseLoading();
                    });
            }
            if (isSuccess)
            {
                this.Invoke((EventHandler)delegate
                {
                    SysHelper.AlertMsg("数据保存成功！");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                });
            }
            else
            {
                this.Invoke((EventHandler)delegate
                    {
                        SysHelper.AlertMsg("数据保存失败，请验证数据完整性！");
                    });
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 界面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPurchaseEdit_Load(object sender, EventArgs e)
        {
            this.cmbManufacturerID.DisplayMember = "Name";
            this.cmbManufacturerID.ValueMember = "ID";
            ManufacturerDal dal = new ManufacturerDal();
            this.cmbManufacturerID.DataSource = dal.GetList(string.Empty).Tables[0];
            this.DataGridDetail.CellValueChanged += DataGridDetail_CellValueChanged;
            BaseDataDal basedal = new BaseDataDal();
            this.colPurchaseUnitID.DataSource = basedal.GetList(" TypeID=1").Tables[0];
            this.colPurchaseUnitID.ValueMember = "ID";
            this.colPurchaseUnitID.DisplayMember = "Name";
            this.colPurchaseUnitID.ValueType = typeof(Int32);
            this.DataGridDetail.AutoGenerateColumns = false;
            this.DataGridDetail.DataSource = ListDetailSource;
        }
        /// <summary>
        /// 计算总数和总金额
        /// </summary>
        private void ComputeTotal()
        {
            decimal TotalCount = 0, TotalAmount = 0;
            foreach (PurchaseDetail item in ListDetailSource)
            {
                TotalCount += item.PurchaseCount;
                TotalAmount += item.PurchaseAmount;
            }
            this.txtPurchaseAmount.Text = TotalAmount.ToString("f2");
            this.txtPurchaseCount.Text = TotalCount.ToString("f2");

        }
        void DataGridDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string EditColumn = this.DataGridDetail.Columns[e.ColumnIndex].DataPropertyName;
            PurchaseDetail EditDetail = ListDetailSource[e.RowIndex];
            if (EditColumn == "PurchaseCount" || EditColumn == "PurchasePrice")
            {
                EditDetail.PurchaseAmount = EditDetail.PurchaseCount * EditDetail.PurchasePrice;
            }
            this.DataGridDetail.Refresh();
            ComputeTotal();
        }

        private void btnProductSelect_Click(object sender, EventArgs e)
        {
            loadProductSelectThread = new Thread(LoadProductSelect);
            loadProductSelectThread.IsBackground = true;
            loadProductSelectThread.Start();
            SysHelper.ShowLoading();
        }
        private void LoadProductSelect()
        {
            try
            {
                FrmProductSelect frmselect = new FrmProductSelect();
                frmselect.StartPosition = FormStartPosition.Manual;
                frmselect.Location = this.Location;
                frmselect.SetOrderDetail(OrderTypeEnum.Purchase, CurrentOrder, ListDetailSource);
                frmselect.Size = this.Size;
                this.Invoke((EventHandler)delegate
                {
                    SysHelper.CloseLoading();
                    frmselect.ShowDialog();
                    this.DataGridDetail.Refresh();
                });
            }
            catch
            {
                SysHelper.CloseLoading();
            }
        }
        private void DataGridDetail_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    int index = this.DataGridDetail.CurrentRow.Index;
                    if (SysHelper.ConfirmMsg("确定要删除该信息？") == System.Windows.Forms.DialogResult.OK)
                    {
                        ListDetailSource.RemoveAt(index);
                        this.DataGridDetail.Refresh();
                    }
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void DataGridDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            SysHelper.AlertMsg("请检查数据输入是否正确！");
            DataGridDetail.CancelEdit();
        }
    }
}
