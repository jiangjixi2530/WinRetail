using System;
using System.Windows.Forms;
using Win.Soft.Retail.RetailDal;

namespace Retail
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text.Trim()))
            {
                Retail.Controls.AlertMsg alert = new Controls.AlertMsg("请输入账号!");
                alert.ShowDialog();
            }
            else
            {
                SysUserDal dal = new SysUserDal();
                if (dal.Login(this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim()))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    Retail.Controls.AlertMsg alert = new Controls.AlertMsg("账号密码不正确!");
                    alert.ShowDialog();
                    this.txtPassword.Text = string.Empty;
                }
            }
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PicExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.PicLogin.Image = this.iListButton.Images[1];
            this.PicExist.Image = this.iListButton.Images[3];
        }
        /// <summary>
        /// 登录按钮鼠标移入效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PicLogin_MouseEnter(object sender, EventArgs e)
        {
            this.PicLogin.Image = this.iListButton.Images[0];
        }
        /// <summary>
        /// 登录按钮鼠标移出效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PicLogin_MouseLeave(object sender, EventArgs e)
        {
            this.PicLogin.Image = this.iListButton.Images[1];
        }
        /// <summary>
        /// 退出按钮鼠标移入效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicExist_MouseEnter(object sender, EventArgs e)
        {
            this.PicExist.Image = this.iListButton.Images[2];
        }
        /// <summary>
        /// 退出按钮鼠标移出效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicExist_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                this.PicExist.Image = this.iListButton.Images[3];
            }
            catch { }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PicLogin_Click(null, null);
        }
    }
}
