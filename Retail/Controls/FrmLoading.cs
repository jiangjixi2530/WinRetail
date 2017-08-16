using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Retail.Controls
{
    public partial class FrmLoading : Form
    {
        /// <summary>
        /// 单例
        /// </summary>
        private static FrmLoading frmLoading;
        private static object _lock = new object();
        /// <summary>
        /// 窗体是否已经打开
        /// </summary>
        private static bool IsloadOpen = false;
        private FrmLoading()
        {
            InitializeComponent();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Red;
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
        public override void Show()
        {
            if (IsloadOpen)
                throw new Exception("窗体已经打开");
            IsloadOpen = true;
            base.Show();
        }
        public override void ShowDialog()
        {
            if (IsloadOpen)
                throw new Exception("窗体已经打开");
            IsloadOpen = true;
            base.ShowDialog();
        }
        #endregion

        private void FrmLoading_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsloadOpen = false;
        }
    }
}
