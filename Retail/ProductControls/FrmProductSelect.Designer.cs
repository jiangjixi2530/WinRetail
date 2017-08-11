namespace Retail.ProductControls
{
    partial class FrmProductSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelCategoryCenter = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCateGoryLeft = new System.Windows.Forms.Button();
            this.btnCateCoryRight = new System.Windows.Forms.Button();
            this.labCategoryTotalPage = new System.Windows.Forms.Label();
            this.labCategoryCurrentPage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelCategoryAll = new System.Windows.Forms.Panel();
            this.labCategoryAll = new System.Windows.Forms.Label();
            this.labOrderInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labTotalPage = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrePage = new System.Windows.Forms.Button();
            this.labCurrentPage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.PanelProductDetail = new Retail.Controls.PagePanel();
            this.txtCondition = new Retail.Controls.WatermarkTextBox();
            this.PanelLeft.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelCategoryAll.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.PanelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.PanelLeft.Controls.Add(this.PanelCategoryCenter);
            this.PanelLeft.Controls.Add(this.panel4);
            this.PanelLeft.Controls.Add(this.panel2);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(130, 524);
            this.PanelLeft.TabIndex = 0;
            // 
            // PanelCategoryCenter
            // 
            this.PanelCategoryCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCategoryCenter.Location = new System.Drawing.Point(0, 43);
            this.PanelCategoryCenter.Name = "PanelCategoryCenter";
            this.PanelCategoryCenter.Size = new System.Drawing.Size(130, 442);
            this.PanelCategoryCenter.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCateGoryLeft);
            this.panel4.Controls.Add(this.btnCateCoryRight);
            this.panel4.Controls.Add(this.labCategoryTotalPage);
            this.panel4.Controls.Add(this.labCategoryCurrentPage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 485);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 39);
            this.panel4.TabIndex = 37;
            // 
            // btnCateGoryLeft
            // 
            this.btnCateGoryLeft.BackgroundImage = global::Retail.Properties.Resources.PrePage;
            this.btnCateGoryLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCateGoryLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCateGoryLeft.FlatAppearance.BorderSize = 0;
            this.btnCateGoryLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCateGoryLeft.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.btnCateGoryLeft.ForeColor = System.Drawing.Color.Gray;
            this.btnCateGoryLeft.Location = new System.Drawing.Point(20, 4);
            this.btnCateGoryLeft.Name = "btnCateGoryLeft";
            this.btnCateGoryLeft.Size = new System.Drawing.Size(25, 30);
            this.btnCateGoryLeft.TabIndex = 52;
            this.btnCateGoryLeft.UseVisualStyleBackColor = true;
            this.btnCateGoryLeft.Click += new System.EventHandler(this.btnCateGoryLeft_Click);
            // 
            // btnCateCoryRight
            // 
            this.btnCateCoryRight.BackgroundImage = global::Retail.Properties.Resources.NextPage;
            this.btnCateCoryRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCateCoryRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCateCoryRight.FlatAppearance.BorderSize = 0;
            this.btnCateCoryRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCateCoryRight.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.btnCateCoryRight.ForeColor = System.Drawing.Color.Gray;
            this.btnCateCoryRight.Location = new System.Drawing.Point(85, 4);
            this.btnCateCoryRight.Name = "btnCateCoryRight";
            this.btnCateCoryRight.Size = new System.Drawing.Size(25, 30);
            this.btnCateCoryRight.TabIndex = 50;
            this.btnCateCoryRight.UseVisualStyleBackColor = true;
            this.btnCateCoryRight.Click += new System.EventHandler(this.btnCateCoryRight_Click);
            // 
            // labCategoryTotalPage
            // 
            this.labCategoryTotalPage.AutoSize = true;
            this.labCategoryTotalPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCategoryTotalPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labCategoryTotalPage.Location = new System.Drawing.Point(59, 12);
            this.labCategoryTotalPage.Name = "labCategoryTotalPage";
            this.labCategoryTotalPage.Size = new System.Drawing.Size(20, 17);
            this.labCategoryTotalPage.TabIndex = 51;
            this.labCategoryTotalPage.Text = "/1";
            // 
            // labCategoryCurrentPage
            // 
            this.labCategoryCurrentPage.AutoSize = true;
            this.labCategoryCurrentPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCategoryCurrentPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(207)))));
            this.labCategoryCurrentPage.Location = new System.Drawing.Point(50, 12);
            this.labCategoryCurrentPage.Name = "labCategoryCurrentPage";
            this.labCategoryCurrentPage.Size = new System.Drawing.Size(15, 17);
            this.labCategoryCurrentPage.TabIndex = 49;
            this.labCategoryCurrentPage.Text = "1";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.PanelCategoryAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 43);
            this.panel2.TabIndex = 36;
            // 
            // PanelCategoryAll
            // 
            this.PanelCategoryAll.AutoSize = true;
            this.PanelCategoryAll.BackgroundImage = global::Retail.Properties.Resources.CategorySelected;
            this.PanelCategoryAll.Controls.Add(this.labCategoryAll);
            this.PanelCategoryAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelCategoryAll.Location = new System.Drawing.Point(5, 10);
            this.PanelCategoryAll.Name = "PanelCategoryAll";
            this.PanelCategoryAll.Size = new System.Drawing.Size(120, 30);
            this.PanelCategoryAll.TabIndex = 35;
            this.PanelCategoryAll.Click += new System.EventHandler(this.Category_Click);
            // 
            // labCategoryAll
            // 
            this.labCategoryAll.AutoSize = true;
            this.labCategoryAll.BackColor = System.Drawing.Color.Transparent;
            this.labCategoryAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCategoryAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(207)))));
            this.labCategoryAll.Location = new System.Drawing.Point(13, 7);
            this.labCategoryAll.Name = "labCategoryAll";
            this.labCategoryAll.Size = new System.Drawing.Size(32, 17);
            this.labCategoryAll.TabIndex = 0;
            this.labCategoryAll.Text = "全部";
            this.labCategoryAll.Click += new System.EventHandler(this.Category_Click);
            // 
            // labOrderInfo
            // 
            this.labOrderInfo.AutoSize = true;
            this.labOrderInfo.BackColor = System.Drawing.Color.Transparent;
            this.labOrderInfo.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labOrderInfo.ForeColor = System.Drawing.Color.Gray;
            this.labOrderInfo.Location = new System.Drawing.Point(8, 10);
            this.labOrderInfo.Name = "labOrderInfo";
            this.labOrderInfo.Size = new System.Drawing.Size(327, 21);
            this.labOrderInfo.TabIndex = 3;
            this.labOrderInfo.Text = "订单类型：采购单   合同号：PR2017071201";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.labOrderInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(130, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 43);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 8F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label15.Location = new System.Drawing.Point(516, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 11);
            this.label15.TabIndex = 121;
            this.label15.Text = "tips：鼠标左点击增加，右点击减少";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::Retail.Properties.Resources.Pic_btnSelect_nor;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(705, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "确定";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.label1);
            this.PanelBottom.Controls.Add(this.labTotalPage);
            this.PanelBottom.Controls.Add(this.btnNextPage);
            this.PanelBottom.Controls.Add(this.btnPrePage);
            this.PanelBottom.Controls.Add(this.labCurrentPage);
            this.PanelBottom.Controls.Add(this.panel3);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(130, 485);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(787, 39);
            this.PanelBottom.TabIndex = 5;
            this.PanelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(695, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 120;
            this.label1.Text = "/";
            // 
            // labTotalPage
            // 
            this.labTotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTotalPage.AutoSize = true;
            this.labTotalPage.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labTotalPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labTotalPage.Location = new System.Drawing.Point(704, 13);
            this.labTotalPage.Name = "labTotalPage";
            this.labTotalPage.Size = new System.Drawing.Size(15, 17);
            this.labTotalPage.TabIndex = 119;
            this.labTotalPage.Text = "1";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.BackgroundImage = global::Retail.Properties.Resources.btn_fy_nor;
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.btnNextPage.ForeColor = System.Drawing.Color.Gray;
            this.btnNextPage.Location = new System.Drawing.Point(725, 7);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(50, 26);
            this.btnNextPage.TabIndex = 118;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrePage
            // 
            this.btnPrePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrePage.BackgroundImage = global::Retail.Properties.Resources.btn_fy_nor;
            this.btnPrePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrePage.FlatAppearance.BorderSize = 0;
            this.btnPrePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrePage.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.btnPrePage.ForeColor = System.Drawing.Color.Gray;
            this.btnPrePage.Location = new System.Drawing.Point(628, 7);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(50, 26);
            this.btnPrePage.TabIndex = 117;
            this.btnPrePage.Text = "上一页";
            this.btnPrePage.UseVisualStyleBackColor = true;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // labCurrentPage
            // 
            this.labCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labCurrentPage.AutoSize = true;
            this.labCurrentPage.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labCurrentPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(207)))));
            this.labCurrentPage.Location = new System.Drawing.Point(684, 13);
            this.labCurrentPage.Name = "labCurrentPage";
            this.labCurrentPage.Size = new System.Drawing.Size(15, 17);
            this.labCurrentPage.TabIndex = 116;
            this.labCurrentPage.Text = "1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picSearch);
            this.panel3.Controls.Add(this.txtCondition);
            this.panel3.Location = new System.Drawing.Point(5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 30);
            this.panel3.TabIndex = 115;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // picSearch
            // 
            this.picSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearch.Image = global::Retail.Properties.Resources.goods_search;
            this.picSearch.Location = new System.Drawing.Point(175, 5);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(20, 20);
            this.picSearch.TabIndex = 116;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // PanelCenter
            // 
            this.PanelCenter.Controls.Add(this.PanelProductDetail);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(130, 43);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(787, 442);
            this.PanelCenter.TabIndex = 6;
            // 
            // PanelProductDetail
            // 
            this.PanelProductDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelProductDetail.ListPageControls = null;
            this.PanelProductDetail.Location = new System.Drawing.Point(0, 0);
            this.PanelProductDetail.Name = "PanelProductDetail";
            this.PanelProductDetail.PageMethod = BaseTool.PageMethodEnum.Normal;
            this.PanelProductDetail.Size = new System.Drawing.Size(787, 442);
            this.PanelProductDetail.SpaceLeftAndRight = 10;
            this.PanelProductDetail.SpaceUpAndLower = 10;
            this.PanelProductDetail.TabIndex = 0;
            // 
            // txtCondition
            // 
            this.txtCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCondition.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.txtCondition.Location = new System.Drawing.Point(1, 6);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(170, 19);
            this.txtCondition.TabIndex = 115;
            this.txtCondition.WaterMark = "产品编号/产品名称";
            this.txtCondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCondition_KeyPress);
            // 
            // FrmProductSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 524);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductSelect";
            this.Text = "FrmProductSelect";
            this.Load += new System.EventHandler(this.FrmProductSelect_Load);
            this.Shown += new System.EventHandler(this.FrmProductSelect_Shown);
            this.PanelLeft.ResumeLayout(false);
            this.PanelLeft.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelCategoryAll.ResumeLayout(false);
            this.PanelCategoryAll.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.PanelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Label labOrderInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picSearch;
        private Controls.WatermarkTextBox txtCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTotalPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrePage;
        private System.Windows.Forms.Label labCurrentPage;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Panel PanelCategoryAll;
        private System.Windows.Forms.Label labCategoryAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCateGoryLeft;
        private System.Windows.Forms.Button btnCateCoryRight;
        private System.Windows.Forms.Label labCategoryTotalPage;
        private System.Windows.Forms.Label labCategoryCurrentPage;
        private System.Windows.Forms.Panel PanelCategoryCenter;
        private Controls.PagePanel PanelProductDetail;
        private System.Windows.Forms.Label label15;
    }
}