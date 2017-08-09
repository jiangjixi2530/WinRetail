using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Retail.Controls;
using System.Windows.Forms;
using BaseTool;

namespace Retail
{
    public class SysHelper
    {
        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="msg"></param>
        public static void AlertMsg(string msg)
        {
            AlertMsg alert = new AlertMsg(msg);
            ((BaseMain)Global.MainForm).ShadeShowDialog(alert);
        }
        /// <summary>
        /// 显示确认信息
        /// </summary>
        /// <param name="Content">确认内容</param>
        /// <param name="Title">确认标题</param>
        /// <returns></returns>
        public static DialogResult ConfirmMsg(string Content, string Title = "提示")
        {
            AlertMsg confirm = new AlertMsg(Content, Title, Controls.AlertMsg.AlertType.Confirm);
            return ((BaseMain)Global.MainForm).ShadeShowDialog(confirm);
        }
        /// <summary>
        /// 显示加载框
        /// </summary>
        public static void ShowLoading()
        {
            FrmLoading load = new FrmLoading();
            ((BaseMain)Global.MainForm).ShadeShowDialog(load);
        }
    }
}
