using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Retail.Controls;
using System.Windows.Forms;
using BaseTool;
using Win.Soft.Retail.RetailDal;
using Win.Soft.Retail.RetailModel;
using System.Threading;

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
        /// <param name="sender">需要携带的参数</param>
        public static void ShowLoading(object sender = null)
        {
            //Thread show = new Thread(() =>
            //{
            //    ((BaseMain)Global.MainForm).Invoke((Action)(() =>
            //     {
            //         ((BaseMain)Global.MainForm).ShadeShowDialog(FrmLoading.FrmLoad);
            //     }));
            //});
            //show.IsBackground = true;
            //show.Start();
            //((BaseMain)Global.MainForm).ShadeShowDialog(FrmLoading.FrmLoad);
            FrmLoading.FrmLoad.ShowDialog(sender);
        }
        public static void CloseLoading()
        {
            try
            {
                FrmLoading.FrmLoad.Close();
            }
            catch
            {

            }
        }
        /// <summary>
        /// 自动生成编码
        /// </summary>
        /// <param name="codeType">单据类型</param>
        /// <returns></returns>
        public static string GetAutoCode(AutoCodeType codeType)
        {
            SysAutoCodeDal dal = new SysAutoCodeDal();
            SysAutoCode AutoCodeSet = dal.GetModel(codeType.ToString());
            if (AutoCodeSet == null)
                return string.Empty;
            string Prefix = AutoCodeSet.Prefix;
            int SeriationLen = AutoCodeSet.SeriationLen;
            int Seriation = 1;
            try
            {
                if (AutoCodeSet.RecentCode.Contains(DateTime.Now.ToString("yyyyMMdd")))
                    Seriation = int.Parse(AutoCodeSet.RecentCode.Substring(AutoCodeSet.RecentCode.Length - SeriationLen, SeriationLen));
                else
                    Seriation = 0;

            }
            catch
            {
                Seriation = 0;
            }
            AutoCodeSet.RecentCode = Prefix + DateTime.Now.ToString("yyyyMMdd") + (Seriation + 1).ToString().PadLeft(SeriationLen, '0');
            dal.Update(AutoCodeSet);
            return AutoCodeSet.RecentCode;
        }
    }
}
