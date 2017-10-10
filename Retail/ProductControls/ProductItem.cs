using System;
using System.Windows.Forms;
using Win.Soft.Retail.RetailModel;

namespace Retail.ProductControls
{
    public partial class ProductItem : UserControl
    {
        /// <summary>
        /// 是否选中
        /// </summary>
        private bool isSelected = false;
        /// <summary>
        /// 点击事件
        /// </summary>
        public ProductItemClickEvent ProductItemClicked;
        /// <summary>
        /// 显示的产品
        /// </summary>
        public Product ShowItem;
        public ProductItem(Product item)
        {
            InitializeComponent();
            ShowItem = item;
            LoadData();
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadData()
        {
            this.labCode.Text = ShowItem.Code;
            this.labName.Text = ShowItem.Name;
            this.labPrice.Text = ShowItem.CostPrice.ToString();
            this.labCount.Text = ShowItem.Count.ToString("0.##");
            this.labCount.Visible = ShowItem.Count > 0;
        }
        public void RefreshCount()
        {
            if (this.IsHandleCreated)
                this.Invoke((EventHandler)delegate
                {
                    this.labCount.Text = ShowItem.Count.ToString("0.##");
                    this.labCount.Visible = ShowItem.Count > 0;
                });
            else
            {
                this.labCount.Text = ShowItem.Count.ToString("0.##");
                this.labCount.Visible = ShowItem.Count > 0;
            }
        }
        /// <summary>
        /// 产品点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductItem_Click(object sender, MouseEventArgs e)
        {
            //左击 增加
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ShowItem.Count++;
            }
            else
            {
                if (ShowItem.Count == 0)
                    return;
                ShowItem.Count--;
            }
            this.labCount.Text = ShowItem.Count.ToString("0.##");
            this.labCount.Visible = ShowItem.Count > 0;
            if (ProductItemClicked != null)
                ProductItemClicked(this);
        }
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                ProductPanel.BackgroundImage = value ? Properties.Resources.ProductBg_prs : Properties.Resources.ProductBg_nor;
            }
        }

    }
}
