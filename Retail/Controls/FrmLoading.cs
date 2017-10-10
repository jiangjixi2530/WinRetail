using System;
using System.Drawing;
using System.Windows.Forms;

namespace Retail.Controls
{
    public partial class FrmLoading : Form
    {
        /// <summary>
        /// 单例
        /// </summary>
        private static FrmLoading frmLoading;
        /// <summary>
        /// 锁
        /// </summary>
        private static object _lock = new object();
        /// <summary>
        /// 窗体是否已经打开
        /// </summary>
        private static bool IsloadOpen = false;
        /// <summary>
        /// 手动关闭事件
        /// </summary>
        public static LoadingManualClosed ManualClosed { get; set; }
        /// <summary>
        /// 加载时需要传递的参数
        /// </summary>
        private object LoadParas = null;
        private FrmLoading()
        {
            InitializeComponent();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Red;
            this.Opacity = 0.8;
            this.picClose.Visible = false;
            this.timCloseEnable.Enabled = true;
        }
        /// <summary>
        /// 获取加载框（多线程单例模式 ）
        /// </summary>
        /// <returns></returns>
        public static FrmLoading FrmLoad
        {
            get
            {
                if (frmLoading == null)
                {
                    lock (_lock)
                    {
                        if (frmLoading == null)
                        {
                            frmLoading = new FrmLoading();
                        }
                    }
                }
                return frmLoading;
            }
        }
        #region 隐式重写
        public void Show()
        {
            if (IsloadOpen)
                throw new Exception("窗体已经打开");
            IsloadOpen = true;
            base.Show();
        }
        public DialogResult ShowDialog(object sender = null)
        {
            if (IsloadOpen)
                throw new Exception("窗体已经打开");
            IsloadOpen = true;
            LoadParas = sender;
            return base.ShowDialog();
        }
        public void Close()
        {
            if (IsloadOpen)
                base.Close();
        }
        #endregion

        private void FrmLoading_FormClosed(object sender, FormClosedEventArgs e)
        {
            timCloseEnable.Enabled = false;
            IsloadOpen = false;
            //每次关闭取消事件的注册
            ManualClosed = null;
        }

        private void timCloseEnable_Tick(object sender, EventArgs e)
        {
            this.timCloseEnable.Enabled = false;
            this.picClose.Visible = true;
        }
        /// <summary>
        /// 手动关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picClose_Click(object sender, EventArgs e)
        {
            if (ManualClosed != null)
                ManualClosed(LoadParas);
            Close();
        }
    }
}
