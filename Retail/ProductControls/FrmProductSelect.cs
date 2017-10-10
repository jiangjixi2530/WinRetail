using BaseTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Win.Soft.Retail.RetailDal;
using Win.Soft.Retail.RetailModel;

namespace Retail.ProductControls
{
    public partial class FrmProductSelect : Form
    {
        /// <summary>
        /// 产品信息列表
        /// </summary>
        private List<ProductItem> ListProduct = new List<ProductItem>();
        /// <summary>
        /// 根据类别筛选的商品信息
        /// </summary>
        private List<ProductItem> ListProductByCategory = new List<ProductItem>();
        /// <summary>
        /// 产品当前页
        /// </summary>
        private int ProductCurrentPage = 1;
        /// <summary>
        /// 产品类型列表
        /// </summary>
        private List<Category> ListCategory = new List<Category>();
        /// <summary>
        /// 产品类别每页显示数量
        /// </summary>
        private int CategoryPageCount = 0;
        /// <summary>
        /// 产品类别当前页
        /// </summary>
        private int CategoryCurrentPage = 1;
        /// <summary>
        /// 产品类别总页数
        /// </summary>
        private int CategoryTotalPage = 1;
        /// <summary>
        /// 选中的产品类别
        /// </summary>
        private Panel SelectedPanel;
        public FrmProductSelect()
        {
            InitializeComponent();
            InitCategory();
            InitProduct();
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

        private void FrmProductSelect_Shown(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 订单类型
        /// </summary>
        private OrderTypeEnum Type;
        /// <summary>
        /// 采购单明细
        /// </summary>
        BindingList<PurchaseDetail> ListPurchaseDetail;
        /// <summary>
        /// 设置订单
        /// </summary>
        /// <param name="type"></param>
        /// <param name="OrderDetail"></param>
        public void SetOrderDetail(OrderTypeEnum type, object Order, object OrderDetail)
        {
            Type = type;
            switch (type)
            {
                case OrderTypeEnum.Purchase:
                    this.labOrderInfo.Text = "订单类型：采购单 订单号：" + ((Purchase)Order).Code;
                    ListPurchaseDetail = (BindingList<PurchaseDetail>)OrderDetail;
                    ProductItem Productitem;
                    foreach (PurchaseDetail item in ListPurchaseDetail)
                    {
                        Productitem = ListProduct.Find(tmp => tmp.ShowItem.ID == item.ProductID);
                        if (Productitem != null)
                        {
                            Productitem.ShowItem.Count = item.PurchaseCount;
                            Productitem.RefreshCount();
                        }
                    }
                    break;
            }
        }
        private void FrmProductSelect_Load(object sender, EventArgs e)
        {
        }
        #region 产品类别信息
        /// <summary>
        /// 初始化产品类别
        /// </summary>
        private void InitCategory()
        {
            CategoryDal categorydal = new CategoryDal();
            ListCategory = categorydal.DataTableToList(categorydal.GetList(string.Empty).Tables[0]);
            if (ListCategory.Count == 0)
            {
                return;
            }
            SelectedPanel = PanelCategoryAll;
            //产品类别每页显示个数=Panel高度除以类别显示高度+间距
            CategoryPageCount = (this.PanelCategoryCenter.Height + 10) / 40;
            if (ListCategory.Count > 0)
                if (ListCategory.Count % CategoryPageCount == 0)
                {
                    CategoryTotalPage = ListCategory.Count / CategoryPageCount;
                }
                else
                {
                    CategoryTotalPage = ListCategory.Count / CategoryPageCount + 1;
                }
            //显示产品类别总页数，已创建句柄则调用委托
            if (this.IsHandleCreated)
            {
                this.Invoke((EventHandler)delegate
                {
                    this.labCategoryTotalPage.Text = "/" + CategoryTotalPage.ToString();
                });
            }
            else
            {
                this.labCategoryTotalPage.Text = "/" + CategoryTotalPage.ToString();
            }
            CategoryShowByPage(1);
        }
        /// <summary>
        /// 分页显示商品类别
        /// </summary>
        /// <param name="page">要显示的页数</param>
        private void CategoryShowByPage(object page)
        {
            try
            {
                CategoryCurrentPage = int.Parse(page.ToString());
            }
            catch
            {
                CategoryCurrentPage = 1;
            }
            if (PanelCategoryCenter.IsHandleCreated)
                this.Invoke((EventHandler)delegate
                {
                    this.PanelCategoryCenter.Controls.Clear();//刷新界面
                });
            else
                this.PanelCategoryCenter.Controls.Clear();//刷新界面
            int LocationY = 0;
            for (int i = (CategoryCurrentPage - 1) * CategoryPageCount; i < CategoryCurrentPage * CategoryPageCount && i < ListCategory.Count; i++)
            {
                Panel panelCategory = new Panel();
                Label lableCategoryName = new Label();
                lableCategoryName.MaximumSize = new System.Drawing.Size(92, 36);
                lableCategoryName.BackColor = System.Drawing.Color.Transparent;
                lableCategoryName.Text = ListCategory[i].Name;
                lableCategoryName.Cursor = System.Windows.Forms.Cursors.Hand;
                lableCategoryName.Click += new EventHandler(Category_Click);
                lableCategoryName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lableCategoryName.Location = new Point(13, 7);
                lableCategoryName.AutoSize = true;
                panelCategory.Controls.Add(lableCategoryName);
                panelCategory.MaximumSize = new System.Drawing.Size(120, 0);
                panelCategory.Tag = ListCategory[i];
                panelCategory.Cursor = System.Windows.Forms.Cursors.Hand;
                panelCategory.Size = new Size(120, lableCategoryName.Height + 14);
                panelCategory.AutoSize = true;
                panelCategory.Click += new EventHandler(Category_Click);
                panelCategory.Location = new Point(5, LocationY);
                LocationY += panelCategory.Height + 10;
                if (PanelCategoryCenter.IsHandleCreated)
                    this.Invoke((EventHandler)delegate
                    {
                        this.PanelCategoryCenter.Controls.Add(panelCategory);
                    });
                else
                    this.PanelCategoryCenter.Controls.Add(panelCategory);
                if (SelectedPanel.Tag == panelCategory.Tag)
                {
                    SelectedPanel = panelCategory;
                    PanelChangColor(panelCategory, true);
                }
            }
            if (labCategoryCurrentPage.IsHandleCreated)
                this.Invoke((EventHandler)delegate
                {
                    this.labCategoryCurrentPage.Text = CategoryCurrentPage.ToString();
                });
            else
                this.labCategoryCurrentPage.Text = CategoryCurrentPage.ToString();
        }
        /// <summary>
        /// 选择商品类别时修改颜色
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="selected"></param>
        private void PanelChangColor(Panel panel, bool selected)
        {
            Label b = (Label)panel.Controls[0];
            b.ForeColor = selected ? Color.FromArgb(27, 130, 207) : Color.FromArgb(26, 26, 26); ;
            string pPath = "";
            pPath = selected ? "CategorySelected" : "";
            panel.BackgroundImage = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(pPath);
            panel.BackgroundImageLayout = ImageLayout.Stretch;
        }
        /// <summary>
        /// 点击加载商品列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Category_Click(object sender, EventArgs e)
        {
            Panel selected;
            if (sender is Label)
            {
                selected = (Panel)((Label)sender).Parent;
            }
            else
            {
                selected = (Panel)sender;
            }
            if (SelectedPanel == selected)
                return;
            this.txtCondition.Text = string.Empty;
            InitProductByCateGory((Category)selected.Tag);
            PanelChangColor(SelectedPanel, false);
            PanelChangColor(selected, true);
            SelectedPanel = selected;
            ProductCurrentPage = 1;
        }
        #endregion
        #region 产品信息相关

        /// <summary>
        /// 初始化商品
        /// </summary>
        private void InitProduct()
        {
            ProductDal productdal = new ProductDal();
            //查询商品信息
            List<Product> list = productdal.DataTableToList(productdal.GetList(string.Empty).Tables[0]);
            if (list.Count == 0)
                return;
            foreach (Product item in list)
            {
                ProductItem c = new ProductItem(item);
                c.ProductItemClicked += new ProductItemClickEvent(ProductItemClicked);
                ListProduct.Add(c);
            }
            InitProductByCateGory(null);
        }
        /// <summary>
        /// 获取不同类别的商品
        /// </summary>
        /// <param name="category"></param>
        private void InitProductByCateGory(object category)
        {
            //选中的商品类别
            Category SelectedCategory;
            try
            {
                SelectedCategory = (Category)category;
            }
            catch
            {
                SelectedCategory = null;
            }
            //获取该商品类别下的所有商品
            if (SelectedCategory != null)
                ListProductByCategory = ListProduct.FindAll(tmp => tmp.ShowItem.TypeID == SelectedCategory.ID);
            else
                ListProductByCategory = ListProduct;
            PanelProductDetail.ListPageControls = ListProductByCategory.OfType<Control>().ToList();
            PanelProductDetail.RefreshPage(1);
            ProductCurrentPage = 1;
            this.labTotalPage.Text = PanelProductDetail.TotalPage.ToString();
            ProductShowByPage(ProductCurrentPage);
        }

        /// <summary>
        /// 分页显示商品信息
        /// </summary>
        /// <param name="page"></param>
        private void ProductShowByPage(object page)
        {
            try
            {
                ProductShowByPage(int.Parse(page.ToString()));
            }
            catch (Exception)
            {

                ProductShowByPage(1);
            }
        }
        /// <summary>
        /// 分页显示商品信息
        /// </summary>
        /// <param name="CurrentPage"></param>
        /// <param name="selectedProduct"></param>
        private void ProductShowByPage(int CurrentPage)
        {
            //刷新当前页
            if (labCurrentPage.IsHandleCreated)
                this.Invoke((EventHandler)delegate
                {
                    PanelProductDetail.ShowControlByPage(CurrentPage);
                    this.labCurrentPage.Text = PanelProductDetail.CurrentPage.ToString();
                });
            else
            {
                PanelProductDetail.ShowControlByPage(CurrentPage);
                this.labCurrentPage.Text = PanelProductDetail.CurrentPage.ToString();
            }
            ProductCurrentPage = PanelProductDetail.CurrentPage;
        }
        #endregion
        #region 按钮点击事件
        private void btnOK_Click(object sender, EventArgs e)
        {

        }
        private void ProductItemClicked(ProductControls.ProductItem sender)
        {
            switch (Type)
            {
                case OrderTypeEnum.Purchase:
                    PurchaseDetail item = ListPurchaseDetail.ToList<PurchaseDetail>().Find(i => i.ProductID == sender.ShowItem.ID);
                    if (item != null)
                    {
                        if (sender.ShowItem.Count == 0)
                            ListPurchaseDetail.Remove(item);
                        else
                            item.PurchaseCount = sender.ShowItem.Count;
                    }
                    else
                    {
                        item = new PurchaseDetail();
                        item.ProductCode = sender.ShowItem.Code;
                        item.ProductName = sender.ShowItem.Name;
                        item.ProductID = sender.ShowItem.ID;
                        item.PurchaseUnitID = sender.ShowItem.UnitID;
                        item.PurchasePrice = sender.ShowItem.CostPrice;
                        item.PurchaseCount = sender.ShowItem.Count;
                        ListPurchaseDetail.Add(item);
                    }
                    item.PurchaseAmount = item.PurchasePrice * item.PurchaseCount;
                    break;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            ProductShowByPage(ProductCurrentPage + 1);
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            ProductShowByPage(ProductCurrentPage - 1);
        }

        private void btnCateGoryLeft_Click(object sender, EventArgs e)
        {
            if (CategoryPageCount == 1)
                return;
            CategoryShowByPage(CategoryPageCount - 1);
        }

        private void btnCateCoryRight_Click(object sender, EventArgs e)
        {
            if (CategoryPageCount == CategoryTotalPage)
                return;
            CategoryShowByPage(CategoryPageCount + 1);
        }
        #endregion
        #region 查询
        private void picSearch_Click(object sender, EventArgs e)
        {
            SearchProduct(this.txtCondition.Text.Trim());
        }
        private void txtCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                SearchProduct(this.txtCondition.Text.Trim());
                e.Handled = true;
            }

        }
        private void SearchProduct(string condition)
        {
            condition = condition.ToUpper();
            if (string.IsNullOrEmpty(condition))
            {
                PanelProductDetail.ListPageControls = ListProductByCategory.OfType<Control>().ToList();
            }
            else
            {
                PanelProductDetail.ListPageControls = ListProductByCategory.FindAll(tmp => tmp.ShowItem.Name.ToUpper().Contains(condition) || tmp.ShowItem.Code.ToUpper().Contains(condition)).OfType<Control>().ToList();
            }
            PanelProductDetail.RefreshPage();
            ProductCurrentPage = PanelProductDetail.CurrentPage;
            this.labCurrentPage.Text = PanelProductDetail.CurrentPage.ToString();
            this.labTotalPage.Text = PanelProductDetail.TotalPage.ToString();
        }
        #endregion

    }
}
