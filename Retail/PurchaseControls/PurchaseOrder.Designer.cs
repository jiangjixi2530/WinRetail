namespace Retail.PurchaseControls
{
    partial class PurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrder));
            this.PanelOrder = new System.Windows.Forms.Panel();
            this.labPurchaseAmountValue = new System.Windows.Forms.Label();
            this.labPurchaseCountValue = new System.Windows.Forms.Label();
            this.labTelephoneValue = new System.Windows.Forms.Label();
            this.labRelationValue = new System.Windows.Forms.Label();
            this.labCodeValue = new System.Windows.Forms.Label();
            this.LabStatus = new System.Windows.Forms.Label();
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
            this.PanelOrder.Controls.Add(this.labPurchaseAmountValue);
            this.PanelOrder.Controls.Add(this.labPurchaseCountValue);
            this.PanelOrder.Controls.Add(this.labTelephoneValue);
            this.PanelOrder.Controls.Add(this.labRelationValue);
            this.PanelOrder.Controls.Add(this.labCodeValue);
            this.PanelOrder.Controls.Add(this.LabStatus);
            this.PanelOrder.Controls.Add(this.labPurchaseDateValue);
            this.PanelOrder.Controls.Add(this.panel4);
            this.PanelOrder.Controls.Add(this.labPurchaseCount);
            this.PanelOrder.Controls.Add(this.labRelation);
            this.PanelOrder.Controls.Add(this.labCode);
            this.PanelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOrder.Location = new System.Drawing.Point(0, 0);
            this.PanelOrder.MaximumSize = new System.Drawing.Size(0, 70);
            this.PanelOrder.Name = "PanelOrder";
            this.PanelOrder.Size = new System.Drawing.Size(400, 70);
            this.PanelOrder.TabIndex = 4;
            this.PanelOrder.Click += new System.EventHandler(this.PanelOrder_Click);
            this.PanelOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOrder_Paint);
            // 
            // labPurchaseAmountValue
            // 
            this.labPurchaseAmountValue.AutoSize = true;
            this.labPurchaseAmountValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labPurchaseAmountValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labPurchaseAmountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labPurchaseAmountValue.Location = new System.Drawing.Point(190, 43);
            this.labPurchaseAmountValue.Name = "labPurchaseAmountValue";
            this.labPurchaseAmountValue.Size = new System.Drawing.Size(0, 17);
            this.labPurchaseAmountValue.TabIndex = 25;
            this.labPurchaseAmountValue.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // labPurchaseCountValue
            // 
            this.labPurchaseCountValue.AutoSize = true;
            this.labPurchaseCountValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labPurchaseCountValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labPurchaseCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labPurchaseCountValue.Location = new System.Drawing.Point(134, 43);
            this.labPurchaseCountValue.Name = "labPurchaseCountValue";
            this.labPurchaseCountValue.Size = new System.Drawing.Size(0, 17);
            this.labPurchaseCountValue.TabIndex = 24;
            this.labPurchaseCountValue.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // labTelephoneValue
            // 
            this.labTelephoneValue.AutoSize = true;
            this.labTelephoneValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labTelephoneValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labTelephoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labTelephoneValue.Location = new System.Drawing.Point(190, 26);
            this.labTelephoneValue.Name = "labTelephoneValue";
            this.labTelephoneValue.Size = new System.Drawing.Size(0, 17);
            this.labTelephoneValue.TabIndex = 23;
            this.labTelephoneValue.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // labRelationValue
            // 
            this.labRelationValue.AutoSize = true;
            this.labRelationValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labRelationValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labRelationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labRelationValue.Location = new System.Drawing.Point(134, 26);
            this.labRelationValue.Name = "labRelationValue";
            this.labRelationValue.Size = new System.Drawing.Size(0, 17);
            this.labRelationValue.TabIndex = 22;
            this.labRelationValue.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // labCodeValue
            // 
            this.labCodeValue.AutoSize = true;
            this.labCodeValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labCodeValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labCodeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labCodeValue.Location = new System.Drawing.Point(146, 9);
            this.labCodeValue.Name = "labCodeValue";
            this.labCodeValue.Size = new System.Drawing.Size(0, 17);
            this.labCodeValue.TabIndex = 21;
            this.labCodeValue.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // LabStatus
            // 
            this.LabStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.LabStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabStatus.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.LabStatus.ForeColor = System.Drawing.Color.White;
            this.LabStatus.Location = new System.Drawing.Point(315, 40);
            this.LabStatus.Name = "LabStatus";
            this.LabStatus.Size = new System.Drawing.Size(74, 20);
            this.LabStatus.TabIndex = 18;
            this.LabStatus.Text = "未入库";
            this.LabStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabStatus.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // labPurchaseDateValue
            // 
            this.labPurchaseDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labPurchaseDateValue.AutoSize = true;
            this.labPurchaseDateValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labPurchaseDateValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labPurchaseDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labPurchaseDateValue.Location = new System.Drawing.Point(315, 8);
            this.labPurchaseDateValue.Name = "labPurchaseDateValue";
            this.labPurchaseDateValue.Size = new System.Drawing.Size(74, 17);
            this.labPurchaseDateValue.TabIndex = 17;
            this.labPurchaseDateValue.Text = "2017-07-02";
            this.labPurchaseDateValue.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.labManufacturer);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(10, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 50);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.PanelOrder_Click);
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
            this.labManufacturer.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // labPurchaseCount
            // 
            this.labPurchaseCount.AutoSize = true;
            this.labPurchaseCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labPurchaseCount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labPurchaseCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labPurchaseCount.Location = new System.Drawing.Point(76, 43);
            this.labPurchaseCount.Name = "labPurchaseCount";
            this.labPurchaseCount.Size = new System.Drawing.Size(68, 17);
            this.labPurchaseCount.TabIndex = 2;
            this.labPurchaseCount.Text = "采购数量：";
            this.labPurchaseCount.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // labRelation
            // 
            this.labRelation.AutoSize = true;
            this.labRelation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labRelation.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labRelation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labRelation.Location = new System.Drawing.Point(76, 26);
            this.labRelation.Name = "labRelation";
            this.labRelation.Size = new System.Drawing.Size(68, 17);
            this.labRelation.TabIndex = 1;
            this.labRelation.Text = "联系方式：";
            this.labRelation.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labCode.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labCode.Location = new System.Drawing.Point(76, 9);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(80, 17);
            this.labCode.TabIndex = 0;
            this.labCode.Text = "采购合同号：";
            this.labCode.Click += new System.EventHandler(this.PanelOrder_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelOrder);
            this.Name = "PurchaseOrder";
            this.Size = new System.Drawing.Size(400, 70);
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.PanelOrder.ResumeLayout(false);
            this.PanelOrder.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOrder;
        private System.Windows.Forms.Label LabStatus;
        private System.Windows.Forms.Label labPurchaseDateValue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labManufacturer;
        private System.Windows.Forms.Label labPurchaseCount;
        private System.Windows.Forms.Label labRelation;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label labCodeValue;
        private System.Windows.Forms.Label labRelationValue;
        private System.Windows.Forms.Label labTelephoneValue;
        private System.Windows.Forms.Label labPurchaseCountValue;
        private System.Windows.Forms.Label labPurchaseAmountValue;
    }
}
