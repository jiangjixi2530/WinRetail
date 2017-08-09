using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Retail.Controls
{
    [ToolboxBitmap(typeof(TextBox))]
    public class WatermarkTextBox : TextBox
    {
        private string _waterMark;
        private Color _waterMarkColor = Color.DarkGray;
        private const int WM_PAINT = 0xF;

        public WatermarkTextBox()
            : base()
        {
        }

        [Description("水印")]
        public string WaterMark
        {
            get { return _waterMark; }
            set
            {
                _waterMark = value;
                base.Invalidate();
            }
        }

        [Description("水印颜色"),DefaultValue(typeof(Color), "DarkGray")]
        public Color WaterMarkColor
        {
            get { return _waterMarkColor; }
            set
            {
                _waterMarkColor = value;
                base.Invalidate();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                WmPaint(ref m);
            }
        }

        private void WmPaint(ref Message m)
        {
            using (Graphics graphics = Graphics.FromHwnd(base.Handle))
            {
                if (Text.Length == 0
                    && !string.IsNullOrEmpty(_waterMark)
                    && !Focused)
                {
                    TextFormatFlags format =
                        TextFormatFlags.EndEllipsis |
                        TextFormatFlags.VerticalCenter;

                    if (RightToLeft == RightToLeft.Yes)
                    {
                        format |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
                    }

                    TextRenderer.DrawText(
                        graphics,
                        _waterMark,
                        Font,
                        base.ClientRectangle,
                        _waterMarkColor,
                        format);
                }
            }
        }
    }
}