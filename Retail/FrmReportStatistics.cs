using DataDal;
using Retail.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail
{
    public partial class FrmReportStatistics : Form
    {
        public FrmReportStatistics()
        {
            InitializeComponent();
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
            // QueryList();
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

        private void button_select_Click(object sender, EventArgs e)
        {
            Query();
        }
        UserInfoDal dal = new UserInfoDal();
        private void Query()
        {
            string StartDate = this.txtStartDate.Text;
            string EndDate = this.txtEndDate.Text;
            if(!string.IsNullOrEmpty(StartDate)&&!string.IsNullOrEmpty(EndDate))
            {
                string ContractSql = @"SELECT COUNT(*) AS OrderCount,SUM(ISNULL(UAmount,TotalAmount)) AS OrderAmount
                                    FROM dbo.VR_ExportContract WHERE SubmitDate BETWEEN '{0}' AND '{1}'";
                DataTable ContractDt = dal.ExecuteSqlToDt(string.Format(ContractSql, StartDate, EndDate));
                this.labOrderCount.Text = ContractDt.Rows[0][0].ToString();
                this.labOrderAmount.Text = ContractDt.Rows[0][1].ToString();
                string ActualReceiveSql = @"SELECT COUNT(*) AS ReceiveCount,SUM(ReceiveAmount) AS ReceiveAmount FROM dbo.FI_CustomActualReceive
                                            WHERE SubmitDate BETWEEN '{0}' AND '{1}'";
                DataTable ReceiveDt = dal.ExecuteSqlToDt(string.Format(ActualReceiveSql, StartDate, EndDate));
                this.labReceiveCount.Text = ReceiveDt.Rows[0][0].ToString();
                this.labReceiveAmount.Text = ReceiveDt.Rows[0][1].ToString();
                string DeliverSql = @"SELECT COUNT(ExportContractID) DeliverCount FROM dbo.DeliverRecord d
                                    WHERE SubmitDate BETWEEN '{0}' AND '{1}'";
                 DataTable DeliverDt=dal.ExecuteSqlToDt(string.Format(DeliverSql,StartDate,EndDate));
                 this.labDeliverRecordCount.Text = DeliverDt.Rows[0][0].ToString();
                 string OtherSql = @"SELECT  COUNT(*) AS OtherCount,SUM(ChargeAmount) AS OtherAmount FROM dbo.OtherChargesAssest
                                      WHERE AssestDate  BETWEEN '{0}' AND '{1}'";
                 DataTable OtherDt = dal.ExecuteSqlToDt(string.Format(OtherSql, StartDate, EndDate));
                 this.labOtherCount.Text = OtherDt.Rows[0][0].ToString();
                 this.labOtherAmount.Text = OtherDt.Rows[0][1].ToString();
            }
            else
            {
                AlertMsg msg = new AlertMsg("请选择日期");
                msg.ShowDialog();
            }
        }
    }

}
