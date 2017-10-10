using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace SoftUpdate
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Http下载文件
        /// </summary>
        public static string HttpDownloadFile(string url, string path)
        {
            // 设置参数
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //发送请求并获取相应回应数据
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream responseStream = response.GetResponseStream();
            //创建本地文件写入流
            Stream stream = new FileStream(path, FileMode.Create);
            byte[] bArr = new byte[1024];
            int size = responseStream.Read(bArr, 0, (int)bArr.Length);
            while (size > 0)
            {
                stream.Write(bArr, 0, size);
                size = responseStream.Read(bArr, 0, (int)bArr.Length);
            }
            stream.Close();
            responseStream.Close();
            return path;
        }
        /// <summary>   
        /// 利用 WinRAR 进行解压缩   
        /// </summary>   
        /// <param name="path">文件解压路径（绝对）</param>   
        /// <param name="rarPath">将要解压缩的 .rar 文件的存放目录（绝对路径）</param>   
        /// <param name="rarName">将要解压缩的 .rar 文件名（包括后缀）</param>   
        /// <returns>true 或 false。解压缩成功返回 true，反之，false。</returns>   
        public bool UnRAR(string path, string rarPath, string rarName)
        {
            ProcessStartInfo startinfo = new ProcessStartInfo(); ;
            Process process = new Process();
            //string rarName = "1.rar"; //将要解压缩的 .rar 文件名（包括后缀）
            //string path = @"C:\images1"; //文件解压路径（绝对）
            //string rarPath = @"C:\zip"; //将要解压缩的 .rar 文件的存放目录（绝对路径）
            string rarexe = System.Windows.Forms.Application.StartupPath + @"\WinRAR.exe"; //WinRAR安装位置
            try
            {
                //解压缩命令，相当于在要压缩文件(rarName)上点右键->WinRAR->解压到当前文件夹
                string cmd = string.Format("x {0} {1} -y", rarName, path);
                startinfo.FileName = rarexe;
                startinfo.Arguments = cmd;             //设置命令参数
                startinfo.WindowStyle = ProcessWindowStyle.Hidden; //隐藏 WinRAR 窗口
                startinfo.WorkingDirectory = rarPath;
                process.StartInfo = startinfo;
                process.Start();
                process.WaitForExit(); //无限期等待进程 winrar.exe 退出
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                process.Dispose();
                process.Close();
            }
        }
        string msg = string.Empty;
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
                this.labMsg.Text = msg + ".";
            if (i == 2)
                this.labMsg.Text = msg + "..";
            if (i == 3)
            {
                this.labMsg.Text = msg + "...";
                i = 0;
            }
        }

        private void FrmUpdate_Shown(object sender, EventArgs e)
        {
            Thread th = new Thread(Update);
            th.IsBackground = true;
            th.Start();

        }
        private void Update()
        {
            msg = "正在下载更新文件";
            string url = @"http://www.suonier.com/winupdate/UPDATE.rar";
            string path = System.Windows.Forms.Application.StartupPath + @"/UPDATE.rar";
            //下载文件
            string filename = HttpDownloadFile(url, path);
            //解压
            msg = "正在解压更新文件";
            UnRAR(System.Windows.Forms.Application.StartupPath, System.Windows.Forms.Application.StartupPath, "UPDATE.rar");
            msg = "完成更新！";
            this.timer1.Enabled = false;
            this.Invoke((EventHandler)delegate
            {
                this.labMsg.Text = msg;
            });
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = System.Windows.Forms.Application.StartupPath + @"\Retail.exe";
            info.Arguments = "";
            Process pro = Process.Start(info);
            Application.Exit();
        }
    }
}
