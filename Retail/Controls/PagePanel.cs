using BaseTool;
using Retail.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Retail.Controls
{
    public class PagePanel : Panel
    {
        /// <summary>
        /// 首页
        /// </summary>
        private const int HOME_PAGE = 1;
        /// <summary>
        /// 左右外边距
        /// </summary>
        private int outSpaceLeftAndRight = 0;
        /// <summary>
        /// 上下外边距
        /// </summary>
        private int outSpaceUpAndLower = 0;
        /// <summary>
        /// 列数
        /// </summary>
        private int columnsCount = 1;
        /// <summary>
        /// 行数
        /// </summary>
        private int rowsCount = 1;
        /// <summary>
        /// 每页数量
        /// </summary>
        private int pageControlCount = 1;
        /// <summary>
        /// 正在分页
        /// </summary>
        private bool isPaging = false;
        private int totalPage = 1;
        [Description("总页数"), Category("自定义属性")]
        public int TotalPage
        {
            get { return totalPage; }
        }
        private int currentPage = 1;

        [Description("当前所在页"), Category("自定义属性")]
        public int CurrentPage
        {
            get { return currentPage; }
        }
        private PageMethodEnum pageMethod = PageMethodEnum.Normal;
        [Description("分页方法"), Category("自定义属性")]
        public PageMethodEnum PageMethod
        {
            set { pageMethod = value; }
            get { return pageMethod; }
        }
        private int spaceUpAndLower = 10;
        [Description("控件之间的上下间距"), Category("自定义属性")]
        public int SpaceUpAndLower
        {
            get { return spaceUpAndLower; }
            set { spaceUpAndLower = value; }
        }
        private int spaceLeftAndRight = 10;
        [Description("控件之间的左右间距"), Category("自定义属性")]
        public int SpaceLeftAndRight
        {
            get { return spaceLeftAndRight; }
            set { spaceLeftAndRight = value; }
        }
        /// <summary>
        /// 无控件显示时的提示
        /// </summary>
        public Control noDataControl = new Control();
        private List<Control> listPageControls;
        /// <summary>
        /// 
        /// </summary>
        public List<Control> ListPageControls
        {
            get { return listPageControls; }
            set
            {
                listPageControls = value;
            }
        }


        /// <summary>
        /// 添加控件
        /// </summary>
        /// <param name="control">控件</param>
        /// <param name="index">位置</param>
        /// <returns></returns>
        public bool AddControl(Control control, int index = 0)
        {
            ListPageControls.Insert(index, control);
            ControlsPaging();
            return true;
        }
        /// <summary>
        /// 批量添加控件
        /// </summary>
        /// <param name="list">添加的控件集合</param>
        /// <param name="index">开始添加的位置</param>
        /// <returns></returns>
        public bool AddControlList(List<Control> list, int index = 0)
        {
            if (index < 0)
                index = 0;
            else
                if (index > ListPageControls.Count)
                    index = ListPageControls.Count;
            foreach (Control c in list)
            {
                ListPageControls.Insert(index, c);
                index++;
            }
            ControlsPaging();
            return true;
        }
        /// <summary>
        /// 删除控件
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public bool DeleteControl(Control control)
        {
            ListPageControls.Remove(control);
            ControlsPaging();
            return true;
        }
        /// <summary>
        /// 批量删除控件
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool DeleteControlList(List<Control> list)
        {
            foreach (Control c in list)
            {
                ListPageControls.Remove(c);
            }
            ControlsPaging();
            return true;
        }
        /// <summary>
        /// 左右边距剩余宽度平均分配，控件之间的左右间距自行设置，默认是10
        /// 上下边距根据剩余高度平均分配，控件之间的上下边距自行设置，默认是10
        /// </summary>
        public PagePanel()
        {

        }
        /// <summary>
        /// 重写 防止刷新时界面闪烁
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED 
                return cp;
            }
        }
        /// <summary>
        /// 控件集合分页
        /// </summary>
        private void ControlsPaging()
        {
            isPaging = true;
            if (this.IsHandleCreated)
                this.Invoke((EventHandler)delegate
                {
                    this.Controls.Clear();
                });
            else
                this.Controls.Clear();
            if (ListPageControls == null || ListPageControls.Count == 0)
            {
                currentPage = 1;
                totalPage = 1;
                if (this.IsHandleCreated)
                    this.Invoke((EventHandler)delegate
                    {
                        this.noDataControl.Visible = true;
                        this.Controls.Add(noDataControl);
                    });
                else
                {
                    noDataControl.Visible = true;
                    this.Controls.Add(noDataControl);
                }
                return;
            }
            switch (PageMethod)
            {
                case PageMethodEnum.Normal:
                    PagingByNormal();
                    break;
                case PageMethodEnum.Single:
                    PagingBySingle();
                    break;
            }
            isPaging = false;
        }
        /// <summary>
        /// 统一大小的分页
        /// </summary>
        private void PagingByNormal()
        {
            columnsCount = (Width + SpaceLeftAndRight) / (ListPageControls[0].Width + SpaceLeftAndRight);
            columnsCount = columnsCount == 0 ? 1 : columnsCount;
            outSpaceLeftAndRight = (Width - (ListPageControls[0].Width + SpaceLeftAndRight) * columnsCount + SpaceLeftAndRight) / 2;
            rowsCount = (Height + SpaceUpAndLower) / (ListPageControls[0].Height + SpaceUpAndLower);
            rowsCount = rowsCount == 0 ? 1 : rowsCount;
            outSpaceUpAndLower = (Height - (ListPageControls[0].Height + SpaceUpAndLower) * rowsCount + SpaceUpAndLower) / 2;
            pageControlCount = columnsCount * rowsCount;
            totalPage = ListPageControls.Count / pageControlCount;
            if (ListPageControls.Count % pageControlCount > 0)
                totalPage++;
        }
        /// <summary>
        /// 不规则单列分页
        /// </summary>
        private void PagingBySingle()
        {
            totalPage = 1;
            currentPage = 1;
            int UseHeight = 0;
            for (int i = 0; i < this.ListPageControls.Count; i++)
            {
                if (this.Height - outSpaceUpAndLower - UseHeight >= this.ListPageControls[i].Height)
                {
                    UseHeight += ListPageControls[i].Height + spaceUpAndLower;
                }
                else
                {
                    totalPage++;
                    UseHeight = ListPageControls[i].Height + spaceUpAndLower;
                }
            }
        }
        /// <summary>
        /// 分页显示
        /// </summary>
        /// <param name="Page"></param>
        public void ShowControlByPage(object Page)
        {
            int page = (int)Page;
            if (page > totalPage || page < HOME_PAGE)
                return;
            switch (PageMethod)
            {
                case PageMethodEnum.Normal:
                    ShowNormalByPage(page);
                    break;
                case PageMethodEnum.Single:
                    ShowSingleByPage(page);
                    break;
            }
        }
        /// <summary>
        /// 统一大小
        /// </summary>
        /// <param name="Page"></param>
        private void ShowNormalByPage(int Page)
        {
            if (this.IsHandleCreated)
                this.Invoke((EventHandler)delegate
                {
                    this.Controls.Clear();
                });
            else
                this.Controls.Clear();
            int showCount = 0;
            for (int i = (Page - 1) * pageControlCount; i < Page * pageControlCount && i < this.ListPageControls.Count; i++)
            {
                this.ListPageControls[i].Location = new Point((showCount % columnsCount) * (ListPageControls[i].Width + SpaceLeftAndRight) + outSpaceLeftAndRight, (showCount / columnsCount) * (ListPageControls[i].Height + spaceUpAndLower) + outSpaceUpAndLower);
                if (this.IsHandleCreated)
                    this.Invoke((EventHandler)delegate
                    {
                        this.Controls.Add(this.ListPageControls[i]);
                    });
                else
                    this.Controls.Add(this.ListPageControls[i]);
                showCount++;
            }
            currentPage = Page;
        }
        /// <summary>
        /// 不规则单列
        /// </summary>
        /// <param name="Page"></param>
        private void ShowSingleByPage(int Page)
        {
            totalPage = 1;
            int UseHeight = 0;
            for (int i = 0; i < this.ListPageControls.Count; i++)
            {
                if (this.Height - UseHeight >= this.ListPageControls[i].Height)
                {
                    UseHeight += ListPageControls[i].Height;
                }
                else
                {
                    totalPage++;
                    UseHeight = ListPageControls[i].Height;
                }
                if (Page == totalPage)
                {
                    if (ListPageControls[i].Created)
                        this.Invoke((EventHandler)delegate
                        {
                            ListPageControls[i].Visible = true;
                        });
                    else
                        ListPageControls[i].Visible = true;
                }
                else
                {
                    if (ListPageControls[i].Created)
                        this.Invoke((EventHandler)delegate
                        {
                            ListPageControls[i].Visible = false;
                        });
                    else
                        ListPageControls[i].Visible = false;
                }
            }
            currentPage = Page;
        }
        /// <summary>
        /// 刷新Panel,重新分页
        /// </summary>
        /// <param name="page">显示页数</param>
        public void RefreshPage(int page = 1)
        {
            ControlsPaging();
            ShowControlByPage(page);
        }
        protected override void OnClientSizeChanged(EventArgs e)
        {
            if (!isPaging && ListPageControls != null && ListPageControls.Count > 0)
            {
                ControlsPaging();
                ShowControlByPage(HOME_PAGE);
            }
            base.OnClientSizeChanged(e);
        }
    }
}
