namespace Retail
{
    partial class FrmPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchase));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.labPayMent = new System.Windows.Forms.Label();
            this.labPurchase = new System.Windows.Forms.Label();
            this.PanelFunction = new System.Windows.Forms.Panel();
            this.purchaseControl1 = new Retail.PurchaseControls.PurchaseControl();
            this.payMentControl1 = new Retail.FinanceControls.PayMentControl();
            this.PanelMenu.SuspendLayout();
            this.PanelFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.labPayMent);
            this.PanelMenu.Controls.Add(this.labPurchase);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(130, 640);
            this.PanelMenu.TabIndex = 0;
            // 
            // labPayMent
            // 
            this.labPayMent.AutoSize = true;
            this.labPayMent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPayMent.ForeColor = System.Drawing.Color.Black;
            this.labPayMent.Location = new System.Drawing.Point(5, 70);
            this.labPayMent.MinimumSize = new System.Drawing.Size(120, 30);
            this.labPayMent.Name = "labPayMent";
            this.labPayMent.Size = new System.Drawing.Size(120, 30);
            this.labPayMent.TabIndex = 3;
            this.labPayMent.Text = "供应商付款";
            this.labPayMent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labPayMent.Click += new System.EventHandler(this.FunctionClick);
            // 
            // labPurchase
            // 
            this.labPurchase.AutoSize = true;
            this.labPurchase.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(207)))));
            this.labPurchase.Image = global::Retail.Properties.Resources.Table_qy_prs;
            this.labPurchase.Location = new System.Drawing.Point(5, 20);
            this.labPurchase.MinimumSize = new System.Drawing.Size(120, 30);
            this.labPurchase.Name = "labPurchase";
            this.labPurchase.Size = new System.Drawing.Size(120, 30);
            this.labPurchase.TabIndex = 2;
            this.labPurchase.Text = "采购下单";
            this.labPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labPurchase.Click += new System.EventHandler(this.FunctionClick);
            // 
            // PanelFunction
            // 
            this.PanelFunction.Controls.Add(this.purchaseControl1);
            this.PanelFunction.Controls.Add(this.payMentControl1);
            this.PanelFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFunction.Location = new System.Drawing.Point(130, 0);
            this.PanelFunction.Name = "PanelFunction";
            this.PanelFunction.Size = new System.Drawing.Size(754, 640);
            this.PanelFunction.TabIndex = 1;
            // 
            // purchaseControl1
            // 
            this.purchaseControl1.BackColor = System.Drawing.Color.White;
            this.purchaseControl1.Location = new System.Drawing.Point(6, 3);
            this.purchaseControl1.Name = "purchaseControl1";
            this.purchaseControl1.Size = new System.Drawing.Size(900, 640);
            this.purchaseControl1.TabIndex = 0;
            // 
            // payMentControl1
            // 
            this.payMentControl1.BackColor = System.Drawing.Color.White;
            this.payMentControl1.Location = new System.Drawing.Point(3, 36);
            this.payMentControl1.Name = "payMentControl1";
            this.payMentControl1.Size = new System.Drawing.Size(969, 624);
            this.payMentControl1.TabIndex = 1;
            // 
            // FrmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 640);
            this.Controls.Add(this.PanelFunction);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPurchase";
            this.Text = "FrmPurchase";
            this.Load += new System.EventHandler(this.FrmPurchase_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.PanelFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Label labPurchase;
        private System.Windows.Forms.Panel PanelFunction;
        private System.Windows.Forms.Label labPayMent;
        private PurchaseControls.PurchaseControl purchaseControl1;
        private FinanceControls.PayMentControl payMentControl1;
    }
}