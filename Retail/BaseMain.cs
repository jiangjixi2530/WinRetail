using BaseTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retail.Controls;
namespace Retail
{
    public partial class BaseMain : Form
    {
        /// <summary>
        /// 当前选中菜单
        /// </summary>
        private Panel CurrentPanel = new Panel();
        /// <summary>
        /// 当前窗体
        /// </summary>
        private Form CurrentForm = new Form();
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public BaseMain()
        {
            InitializeComponent();
        }

        private void BaseMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //常量  
            int WM_SYSCOMMAND = 0x0112;

            //窗体移动  
            int SC_MOVE = 0xF010;
            int HTCAPTION = 0x0002;

            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void picMiniMize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 点击菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuClick(object sender, EventArgs e)
        {
            ShowCurrentMenu(CurrentPanel, false);
            if (sender is Panel)
                CurrentPanel = (Panel)sender;
            else
                CurrentPanel = (Panel)((Control)sender).Parent;
            switch (((Control)sender).Name)
            {
                //case "labOtherExpense":
                //    ShowNavForm(new FrmOtherExpense());
                //    break;
                //case "labReportStatistics":
                //    ShowNavForm(new FrmReportStatistics());
                //    break;
                default:
                    ShowNavForm(new FrmPurchase());
                    break;
            }
            ShowCurrentMenu(CurrentPanel, true);
        }
        /// <summary>
        /// 切换窗体
        /// </summary>
        /// <param name="ShowForm"></param>
        public void ShowNavForm(Form ShowForm)
        {
            CurrentForm.Close();
            CurrentForm = ShowForm;
            CurrentForm.WindowState = FormWindowState.Maximized;
            CurrentForm.MdiParent = this;
            CurrentForm.Parent = this.PanelBody;
            CurrentForm.Show();
            CurrentForm.Activate();
        }
        private void BaseMain_Load(object sender, EventArgs e)
        {
            Global.MainForm = this;
            this.labUserName.Text = Global.UserName;
            Thread thTime = new Thread(ShowCurrentTime);
            thTime.IsBackground = true;
            thTime.Start();
            labWeek.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
        }
        /// <summary>
        /// 显示时间线程
        /// </summary>
        private void ShowCurrentTime()
        {
            while (true)
            {
                this.labCurrentTime.Invoke((EventHandler)delegate
               {
                   this.labCurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
               });
                System.Threading.Thread.Sleep(1000);
            }
        }
        private void ShowCurrentMenu(Panel MenuPanel, bool IsSeleted)
        {
            MenuPanel.BackgroundImage = IsSeleted ? Retail.Properties.Resources.MenuSelected : null;
        }
        FrmShade Shade;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm"></param>
        public void ShadeShow(Form frm)
        {
            Shade = new FrmShade(frm);
            Shade.Opacity = 0.6;
            Shade.Show();
        }
        public DialogResult ShadeShowDialog(Form frm)
        {
            Shade = new FrmShade(frm);
            Shade.Opacity = 0.6;
            return Shade.ShowDialog();
        }
        /// <summary>
        /// 关闭遮罩
        /// </summary>
        public void CloseShade()
        {
            if (Shade != null)
            {
                try
                {
                    Shade.Close();
                }
                catch
                {

                }
            }
        }
    }
}
