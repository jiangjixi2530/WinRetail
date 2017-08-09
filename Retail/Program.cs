using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //处理未捕获的异常   
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //处理UI线程异常   
            Application.ThreadException += Application_ThreadException;
            //处理非UI线程异常   
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            if (Application_activity())
            {
                return;
            }
            if (File.Exists(System.Windows.Forms.Application.StartupPath + @"/UPDATE.rar"))
                //删除
                File.Delete(System.Windows.Forms.Application.StartupPath + @"/UPDATE.rar");
            if (ExistsNewVersion())
                return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm login = new LoginForm();
            //是否成功登录
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new BaseMain());
                login.Dispose();
            }
        }
        private static bool ExistsNewVersion()
        {
            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            byte[] postdata = Encoding.UTF8.GetBytes(string.Empty);
            Byte[] pageData = client.UploadData(@"http://www.suonier.com/winupdate/VersionHandler.ashx", "POST", postdata);
            String resultHtm = Encoding.UTF8.GetString(pageData);
            string newversion = Encoding.UTF8.GetString(pageData);
            string nowversion = ConfigurationManager.AppSettings["version"];
            if (int.Parse(newversion) > int.Parse(nowversion))
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = System.Windows.Forms.Application.StartupPath + @"\SoftUpdate.exe";
                info.Arguments = "";
                info.Verb = "runas";
                Process pro = Process.Start(info);
                Application.Exit();
                return true;
            }
            return false;
        }
        //检查是否有未结束的进程资源
        private static bool Application_activity()
        {
            var aProcessName = Process.GetCurrentProcess().ProcessName;
            if ((Process.GetProcessesByName(aProcessName)).GetUpperBound(0) > 0)
            {
                Thread.Sleep(1000);
                if ((Process.GetProcessesByName(aProcessName)).GetUpperBound(0) > 0)
                {
                    return true;
                }
            }
            return false;
        }
                                       
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var ex = e.Exception;
            if (ex != null)
            {
            }

            //MessageBox.Show("系统出现未知异常，请重启系统！");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                //LogHelper.Log(ex);
                //MessageBox.Show(ex.ToString());
            }

            //MessageBox.Show("系统出现未知异常，请重启系统！");
        }

    }
}
