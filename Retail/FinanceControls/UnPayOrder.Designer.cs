namespace Retail.FinanceControls
{
    partial class UnPayOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnPayOrder));
            this.PanelOrder = new System.Windows.Forms.Panel();
            this.labUnPayAmountValue = new System.Windows.Forms.Label();
            this.labUnPayAmount = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSelected = new System.Windows.Forms.Button();
            this.labPurchaseAmountValue = new System.Windows.Forms.Label();
            this.labPurchaseCountValue = new System.Windows.Forms.Label();
            this.labTelephoneValue = new System.Windows.Forms.Label();
            this.labRelationValue = new System.Windows.Forms.Label();
            this.labCodeValue = new System.Windows.Forms.Label();
            this.labPurchaseDateValue = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labManufacturer = new System.Windows.Forms.Label();
            this.labPurchaseCount = new System.Windows.Forms.Label();
            this.labRelation = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.PanelOrder.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOrder
            // 
            this.PanelOrder.BackColor = System.Drawing.Color.White;
            this.PanelOrder.Controls.Add(this.labUnPayAmountValue);
            this.PanelOrder.Controls.Add(this.labUnPayAmount);
            this.PanelOrder.Controls.Add(this.btnPay);
            this.PanelOrder.Controls.Add(this.btnSelected);
            this.PanelOrder.Controls.Add(this.labPurchaseAmountValue);
            this.PanelOrder.Controls.Add(this.labPurchaseCountValue);
            this.PanelOrder.Controls.Add(this.labTelephoneValue);
            this.PanelOrder.Controls.Add(this.labRelationValue);
            this.PanelOrder.Controls.Add(this.labCodeValue);
            this.PanelOrder.Controls.Add(this.labPurchaseDateValue);
            this.PanelOrder.Controls.Add(this.panel4);
            this.PanelOrder.Controls.Add(this.labPurchaseCount);
            this.PanelOrder.Controls.Add(this.labRelation);
            this.PanelOrder.Controls.Add(this.labCode);
            this.PanelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOrder.Location = new System.Drawing.Point(0, 0);
            this.PanelOrder.Name = "PanelOrder";
            this.PanelOrder.Size = new System.Drawing.Size(483, 70);
            this.PanelOrder.TabIndex = 5;
            this.PanelOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOrder_Paint);
            // 
            // labUnPayAmountValue
            // 
            this.labUnPayAmountValue.AutoSize = true;
            this.labUnPayAmountValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labUnPayAmountValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labUnPayAmountValue.ForeColor = System.Drawing.Color.Red;
            this.labUnPayAmountValue.Location = new System.Drawing.Point(334, 43);
            this.labUnPayAmountValue.Name = "labUnPayAmountValue";
            this.labUnPayAmountValue.Size = new System.Drawing.Size(43, 17);
            this.labUnPayAmountValue.TabIndex = 126;
            this.labUnPayAmountValue.Text = "99999";
            // 
            // labUnPayAmount
            // 
            this.labUnPayAmount.AutoSize = true;
            this.labUnPayAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labUnPayAmount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labUnPayAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labUnPayAmount.Location = new System.Drawing.Point(276, 43);
            this.labUnPayAmount.Name = "labUnPayAmount";
            this.labUnPayAmount.Size = new System.Drawing.Size(68, 17);
            this.labUnPayAmount.TabIndex = 125;
            this.labUnPayAmount.Text = "未付金额：";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPay.BackgroundImage = global::Retail.Properties.Resources.Pic_btnSelect_nor;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(398, 30);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 30);
            this.btnPay.TabIndex = 124;
            this.btnPay.Text = "单笔付款";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSelected
            // 
            this.btnSelected.BackgroundImage = global::Retail.Properties.Resources.radioUnCheck;
            this.btnSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSelected.FlatAppearance.BorderSize = 0;
            this.btnSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelected.ForeColor = System.Drawing.Color.Transparent;
            this.btnSelected.Location = new System.Drawing.Point(10, 26);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(16, 16);
            this.btnSelected.TabIndex = 82;
            this.btnSelected.UseVisualStyleBackColor = true;
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // labPurchaseAmountValue
            // 
            this.labPurchaseAmountValue.AutoSize = true;
            this.labPurchaseAmountValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labPurchaseAmountValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labPurchaseAmountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labPurchaseAmountValue.Location = new System.Drawing.Point(209, 43);
            this.labPurchaseAmountValue.Name = "labPurchaseAmountValue";
            this.labPurchaseAmountValue.Size = new System.Drawing.Size(57, 17);
            this.labPurchaseAmountValue.TabIndex = 25;
            this.labPurchaseAmountValue.Text = "9999999";
            // 
            // labPurchaseCountValue
            // 
            this.labPurchaseCountValue.AutoSize = true;
            this.labPurchaseCountValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labPurchaseCountValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labPurchaseCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labPurchaseCountValue.Location = new System.Drawing.Point(153, 43);
            this.labPurchaseCountValue.Name = "labPurchaseCountValue";
            this.labPurchaseCountValue.Size = new System.Drawing.Size(43, 17);
            this.labPurchaseCountValue.TabIndex = 24;
            this.labPurchaseCountValue.Text = "99999";
            // 
            // labTelephoneValue
            // 
            this.labTelephoneValue.AutoSize = true;
            this.labTelephoneValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labTelephoneValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labTelephoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labTelephoneValue.Location = new System.Drawing.Point(209, 26);
            this.labTelephoneValue.Name = "labTelephoneValue";
            this.labTelephoneValue.Size = new System.Drawing.Size(0, 17);
            this.labTelephoneValue.TabIndex = 23;
            // 
            // labRelationValue
            // 
            this.labRelationValue.AutoSize = true;
            this.labRelationValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labRelationValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labRelationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labRelationValue.Location = new System.Drawing.Point(153, 26);
            this.labRelationValue.Name = "labRelationValue";
            this.labRelationValue.Size = new System.Drawing.Size(0, 17);
            this.labRelationValue.TabIndex = 22;
            // 
            // labCodeValue
            // 
            this.labCodeValue.AutoSize = true;
            this.labCodeValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labCodeValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labCodeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labCodeValue.Location = new System.Drawing.Point(165, 9);
            this.labCodeValue.Name = "labCodeValue";
            this.labCodeValue.Size = new System.Drawing.Size(0, 17);
            this.labCodeValue.TabIndex = 21;
            // 
            // labPurchaseDateValue
            // 
            this.labPurchaseDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labPurchaseDateValue.AutoSize = true;
            this.labPurchaseDateValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labPurchaseDateValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labPurchaseDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labPurchaseDateValue.Location = new System.Drawing.Point(398, 8);
            this.labPurchaseDateValue.Name = "labPurchaseDateValue";
            this.labPurchaseDateValue.Size = new System.Drawing.Size(74, 17);
            this.labPurchaseDateValue.TabIndex = 17;
            this.labPurchaseDateValue.Text = "2017-07-02";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.labManufacturer);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(29, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 50);
            this.panel4.TabIndex = 3;
            // 
            // labManufacturer
            // 
            this.labManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(207)))));
            this.labManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labManufacturer.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labManufacturer.ForeColor = System.Drawing.Color.White;
            this.labManufacturer.Location = new System.Drawing.Point(0, 0);
            this.labManufacturer.Name = "labManufacturer";
            this.labManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labManufacturer.Size = new System.Drawing.Size(60, 50);
            this.labManufacturer.TabIndex = 0;
            this.labManufacturer.Text = "南京优来客材料";
            this.labManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labPurchaseCount
            // 
            this.labPurchaseCount.AutoSize = true;
            this.labPurchaseCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labPurchaseCount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labPurchaseCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labPurchaseCount.Location = new System.Drawing.Point(95, 43);
            this.labPurchaseCount.Name = "labPurchaseCount";
            this.labPurchaseCount.Size = new System.Drawing.Size(68, 17);
            this.labPurchaseCount.TabIndex = 2;
            this.labPurchaseCount.Text = "采购数量：";
            // 
            // labRelation
            // 
            this.labRelation.AutoSize = true;
            this.labRelation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labRelation.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labRelation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labRelation.Location = new System.Drawing.Point(95, 26);
            this.labRelation.Name = "labRelation";
            this.labRelation.Size = new System.Drawing.Size(68, 17);
            this.labRelation.TabIndex = 1;
            this.labRelation.Text = "联系方式：";
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labCode.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labCode.Location = new System.Drawing.Point(95, 9);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(80, 17);
            this.labCode.TabIndex = 0;
            this.labCode.Text = "采购合同号：";
            // 
            // UnPayOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelOrder);
            this.Name = "UnPayOrder";
            this.Size = new System.Drawing.Size(483, 70);
            this.Load += new System.EventHandler(this.UnPayOrder_Load);
            this.PanelOrder.ResumeLayout(false);
            this.PanelOrder.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOrder;
        private System.Windows.Forms.Label labPurchaseAmountValue;
        private System.Windows.Forms.Label labPurchaseCountValue;
        private System.Windows.Forms.Label labTelephoneValue;
        private System.Windows.Forms.Label labRelationValue;
        private System.Windows.Forms.Label labCodeValue;
        private System.Windows.Forms.Label labPurchaseDateValue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labManufacturer;
        private System.Windows.Forms.Label labPurchaseCount;
        private System.Windows.Forms.Label labRelation;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Button btnSelected;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label labUnPayAmountValue;
        private System.Windows.Forms.Label labUnPayAmount;
    }
}
