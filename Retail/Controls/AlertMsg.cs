using Retail.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail.Controls
{
    public partial class AlertMsg : Form
    {
        /// <summary>
        /// 消息提示类型
        /// </summary>
        public enum AlertType
        {
            /// <summary>
            /// 提示框
            /// </summary>
            Alert,
            /// <summary>
            /// 询问框
            /// </summary>
            Confirm
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public AlertMsg()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Content">消息内容</param>
        public AlertMsg(string Content)
        {
            InitializeComponent();
            ControlShow(Content);
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Content">消息内容</param>
        /// <param name="Title">消息标题</param>
        public AlertMsg(string Content, string Title)
        {
            InitializeComponent();
            ControlShow(Content, Title);
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Content">消息内容</param>
        /// <param name="Title">消息标题</param>
        /// <param name="Type">弹窗类型</param>
        public AlertMsg(string Content, string Title, AlertType Type)
        {
            InitializeComponent();
            ControlShow(Content, Title, Type);
        }
        private void AlertMsg_Paint(object sender, PaintEventArgs e)
        {
            FormHelper.FormCircular(sender, e);
        }
        private void ControlShow(string Content, string Tilte = "提示", AlertType Type = AlertType.Alert)
        {
            this.labTitle.Text = Tilte;
            this.labMsg.Text = Content;
            switch (Type)
            {
                case AlertType.Alert:
                    this.btnOk.Visible = true;
                    this.btnOk.Location = new Point((this.Width - this.btnOk.Width) / 2, 190);
                    break;
                case AlertType.Confirm:
                    this.btnConfirm.Visible = true;
                    this.btnConfirm.Location = new Point((this.Width - this.btnConfirm.Width - this.btnCancel.Width - 10) / 2, 190);
                    this.btnCancel.Visible = true;
                    this.btnCancel.Location = new Point((this.btnConfirm.Location.X + this.btnConfirm.Width + 10), 190);
                    break;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
