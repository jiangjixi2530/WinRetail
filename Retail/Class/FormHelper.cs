using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Retail.Class
{
    public class FormHelper
    {
        /// <summary>
        /// 重绘窗体，呈现圆角
        /// </summary>
        /// <param name="sender">Form</param>
        /// <param name="e"></param>
        public static void FormCircular(object sender, PaintEventArgs e)
        {
            Form form = ((Form)sender);
            GraphicsPath oPath = new GraphicsPath();
            int x = 0;
            int y = 0;
            int w = form.Width;
            int h = form.Height;
            Graphics g = form.CreateGraphics();
            oPath.AddArc(0, 0, 18, 18, 180, 90);  //左上角
            oPath.AddArc(w - 18, 0, 18, 18, 270, 90);//右上角
            oPath.AddArc(w - 25, h - 25 , 25 , 25 , 0, 90); //右下角
            oPath.AddArc(0, h - 18, 18, 18, 90, 90);//左下角
            oPath.CloseAllFigures();
            form.Region = new Region(oPath);   
        }
    }
}
