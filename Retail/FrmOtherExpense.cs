using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataDal;
using DataLinq;

namespace Retail
{
    public partial class FrmOtherExpense : Form
    {
        private OtherChargesAssestDao ObjectDal = new OtherChargesAssestDao();
        private BindingList<OtherChargesAssest> ObjectList;
        public FrmOtherExpense()
        {
            InitializeComponent();
        }

        private void PanelWeek_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
                                                       Color.FromArgb(199, 199, 199), 1, ButtonBorderStyle.Solid, //左边
                                                       Color.FromArgb(199, 199, 199), 1, ButtonBorderStyle.Solid, //上边
                                                       Color.FromArgb(199, 199, 199), 1, ButtonBorderStyle.Solid, //右边
                                                       Color.FromArgb(199, 199, 199), 1, ButtonBorderStyle.Solid //下边
                                                       );
        }

        private void labDateClick(object sender, EventArgs e)
        {
            switch (((Label)sender).Name)
            {
                case "labToday":
                    this.txtStartDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    this.txtEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    this.labToday.Image = Retail.Properties.Resources.Pic_DateChose_prs;
                    this.labToday.ForeColor = Color.White;
                    this.PanelWeek.BackColor = Color.Transparent;
                    this.PanelWeek.BackColor = Color.White;
                    this.labWeek.BackColor = Color.White;
                    this.labWeek.ForeColor = Color.Black;
                    this.labMonth.Image = Retail.Properties.Resources.riqiyou_nor;
                    this.labMonth.ForeColor = Color.Black;
                    break;
                case "labWeek":
                    this.txtStartDate.Text = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
                    this.txtEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    this.labToday.Image = Retail.Properties.Resources.Pic_DateChose_nor;
                    this.labToday.ForeColor = Color.Black;
                    this.PanelWeek.BackColor = Color.FromArgb(27, 130, 207);
                    this.labWeek.ForeColor = Color.White;
                    this.labWeek.BackColor = Color.FromArgb(27, 130, 207);
                    this.labMonth.Image = Retail.Properties.Resources.riqiyou_nor;
                    this.labMonth.ForeColor = Color.Black;
                    break;
                case "labMonth":
                    this.txtStartDate.Text = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
                    this.txtEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    this.labToday.Image = Retail.Properties.Resources.Pic_DateChose_nor;
                    this.labToday.ForeColor = Color.Black;
                    this.PanelWeek.BackColor = Color.White;
                    this.labWeek.ForeColor = Color.Black;
                    this.labWeek.BackColor = Color.White;
                    this.labWeek.ForeColor = Color.Black;
                    this.labMonth.Image = Retail.Properties.Resources.riqiyou_prs;
                    this.labMonth.ForeColor = Color.White;
                    break;
            }
            QueryList();
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
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOtherExpense_Load(object sender, EventArgs e)
        {
            this.txtStartDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.txtEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            QueryList();
        }
        /// <summary>
        /// 查询其他费用数据列表
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        private void QueryList()
        {
            List<OtherChargesAssest> list = ObjectDal.GetList(DateTime.Parse(this.txtStartDate.Text), DateTime.Parse(this.txtEndDate.Text));
            ObjectList = new BindingList<OtherChargesAssest>(list);
            this.DataGrid.DataSource = ObjectList;
            this.labTotalCount.Text = ObjectList.Count.ToString() + "项";
            decimal Amount = 0;
            foreach (OtherChargesAssest item in list)
            {
                Amount += item.ChargeAmount;
            }
            this.labTotalAmount.Text = "￥" + Amount.ToString("0.00");
            this.labNoData.Visible = list.Count == 0;
            this.labNoData.Location = new Point((this.DataGrid.Width - this.labNoData.Width) / 2, (this.DataGrid.Height - this.labNoData.Height) / 2);
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            QueryList();
        }
    }
}
