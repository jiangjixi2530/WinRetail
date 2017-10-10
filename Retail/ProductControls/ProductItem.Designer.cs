namespace Retail.ProductControls
{
    partial class ProductItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.labCode = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.ProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductPanel
            // 
            this.ProductPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProductPanel.BackgroundImage = global::Retail.Properties.Resources.ProductBg_nor;
            this.ProductPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProductPanel.Controls.Add(this.labCode);
            this.ProductPanel.Controls.Add(this.labPrice);
            this.ProductPanel.Controls.Add(this.labName);
            this.ProductPanel.Location = new System.Drawing.Point(0, 5);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(88, 82);
            this.ProductPanel.TabIndex = 1;
            this.ProductPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductItem_Click);
            // 
            // labCode
            // 
            this.labCode.BackColor = System.Drawing.Color.Transparent;
            this.labCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labCode.Location = new System.Drawing.Point(1, 8);
            this.labCode.Margin = new System.Windows.Forms.Padding(0);
            this.labCode.MaximumSize = new System.Drawing.Size(85, 20);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(85, 17);
            this.labCode.TabIndex = 2;
            this.labCode.Text = "LJLKJC00.1111";
            this.labCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductItem_Click);
            // 
            // labPrice
            // 
            this.labPrice.BackColor = System.Drawing.Color.Transparent;
            this.labPrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(59)))));
            this.labPrice.Location = new System.Drawing.Point(1, 61);
            this.labPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(85, 17);
            this.labPrice.TabIndex = 3;
            this.labPrice.Text = "￥100.23";
            this.labPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductItem_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labName.Location = new System.Drawing.Point(2, 23);
            this.labName.Margin = new System.Windows.Forms.Padding(0);
            this.labName.MaximumSize = new System.Drawing.Size(85, 40);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(79, 40);
            this.labName.TabIndex = 4;
            this.labName.Text = "单向可1调式快装接插件";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductItem_Click);
            // 
            // labCount
            // 
            this.labCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCount.ForeColor = System.Drawing.Color.White;
            this.labCount.Image = global::Retail.Properties.Resources.ProductCount;
            this.labCount.Location = new System.Drawing.Point(64, 0);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(27, 15);
            this.labCount.TabIndex = 5;
            this.labCount.Text = "99";
            this.labCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.ProductPanel);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(98, 92);
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labCount;
    }
}
