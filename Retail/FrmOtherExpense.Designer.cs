namespace Retail
{
    partial class FrmOtherExpense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.panel_EndDate = new System.Windows.Forms.Panel();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.picEndTime = new System.Windows.Forms.PictureBox();
            this.PanelWeek = new System.Windows.Forms.Panel();
            this.labWeek = new System.Windows.Forms.Label();
            this.labTo = new System.Windows.Forms.Label();
            this.labMonth = new System.Windows.Forms.Label();
            this.panel_StartDate = new System.Windows.Forms.Panel();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.picStartTime = new System.Windows.Forms.PictureBox();
            this.labToday = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.mcStartDate = new System.Windows.Forms.MonthCalendar();
            this.mcEndDate = new System.Windows.Forms.MonthCalendar();
            this.PanelData = new System.Windows.Forms.Panel();
            this.labNoData = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChargesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChargeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsSubmit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubmitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastModifiedUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastModifiedMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelyhje_top = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labTotalAmount = new System.Windows.Forms.Label();
            this.labTotalCount = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.PanelHead.SuspendLayout();
            this.panel_EndDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEndTime)).BeginInit();
            this.PanelWeek.SuspendLayout();
            this.panel_StartDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.PanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.panelyhje_top.SuspendLayout();
            this.s.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelHead.Controls.Add(this.panel_EndDate);
            this.PanelHead.Controls.Add(this.PanelWeek);
            this.PanelHead.Controls.Add(this.labTo);
            this.PanelHead.Controls.Add(this.labMonth);
            this.PanelHead.Controls.Add(this.panel_StartDate);
            this.PanelHead.Controls.Add(this.labToday);
            this.PanelHead.Controls.Add(this.button_select);
            this.PanelHead.Controls.Add(this.label32);
            this.PanelHead.Controls.Add(this.pictureBox5);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(868, 125);
            this.PanelHead.TabIndex = 1;
            this.PanelHead.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelWeek_Paint);
            // 
            // panel_EndDate
            // 
            this.panel_EndDate.BackColor = System.Drawing.Color.White;
            this.panel_EndDate.Controls.Add(this.txtEndDate);
            this.panel_EndDate.Controls.Add(this.picEndTime);
            this.panel_EndDate.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.panel_EndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel_EndDate.Location = new System.Drawing.Point(414, 90);
            this.panel_EndDate.Name = "panel_EndDate";
            this.panel_EndDate.Size = new System.Drawing.Size(120, 30);
            this.panel_EndDate.TabIndex = 106;
            this.panel_EndDate.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelWeek_Paint);
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.White;
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.txtEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtEndDate.Location = new System.Drawing.Point(4, 5);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(92, 19);
            this.txtEndDate.TabIndex = 58;
            // 
            // picEndTime
            // 
            this.picEndTime.BackgroundImage = global::Retail.Properties.Resources.time_nor;
            this.picEndTime.Location = new System.Drawing.Point(99, 6);
            this.picEndTime.Name = "picEndTime";
            this.picEndTime.Size = new System.Drawing.Size(19, 18);
            this.picEndTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEndTime.TabIndex = 48;
            this.picEndTime.TabStop = false;
            this.picEndTime.Click += new System.EventHandler(this.picTime_Click);
            // 
            // PanelWeek
            // 
            this.PanelWeek.Controls.Add(this.labWeek);
            this.PanelWeek.Location = new System.Drawing.Point(390, 30);
            this.PanelWeek.Name = "PanelWeek";
            this.PanelWeek.Size = new System.Drawing.Size(70, 28);
            this.PanelWeek.TabIndex = 104;
            this.PanelWeek.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelWeek_Paint);
            // 
            // labWeek
            // 
            this.labWeek.BackColor = System.Drawing.Color.White;
            this.labWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labWeek.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labWeek.ForeColor = System.Drawing.Color.Black;
            this.labWeek.Location = new System.Drawing.Point(1, 1);
            this.labWeek.Name = "labWeek";
            this.labWeek.Size = new System.Drawing.Size(68, 26);
            this.labWeek.TabIndex = 102;
            this.labWeek.Text = "本周";
            this.labWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labWeek.Click += new System.EventHandler(this.labDateClick);
            // 
            // labTo
            // 
            this.labTo.BackColor = System.Drawing.Color.Transparent;
            this.labTo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.labTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.labTo.Location = new System.Drawing.Point(379, 95);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(24, 19);
            this.labTo.TabIndex = 109;
            this.labTo.Text = "—";
            this.labTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMonth
            // 
            this.labMonth.BackColor = System.Drawing.Color.Transparent;
            this.labMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labMonth.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labMonth.ForeColor = System.Drawing.Color.Black;
            this.labMonth.Image = global::Retail.Properties.Resources.riqiyou_nor;
            this.labMonth.Location = new System.Drawing.Point(460, 30);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(70, 28);
            this.labMonth.TabIndex = 103;
            this.labMonth.Text = "本月";
            this.labMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMonth.Click += new System.EventHandler(this.labDateClick);
            // 
            // panel_StartDate
            // 
            this.panel_StartDate.BackColor = System.Drawing.Color.White;
            this.panel_StartDate.Controls.Add(this.txtStartDate);
            this.panel_StartDate.Controls.Add(this.picStartTime);
            this.panel_StartDate.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.panel_StartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel_StartDate.Location = new System.Drawing.Point(249, 90);
            this.panel_StartDate.Name = "panel_StartDate";
            this.panel_StartDate.Size = new System.Drawing.Size(120, 30);
            this.panel_StartDate.TabIndex = 103;
            this.panel_StartDate.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelWeek_Paint);
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.Color.White;
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtStartDate.Location = new System.Drawing.Point(4, 5);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(92, 19);
            this.txtStartDate.TabIndex = 54;
            // 
            // picStartTime
            // 
            this.picStartTime.BackColor = System.Drawing.Color.Transparent;
            this.picStartTime.BackgroundImage = global::Retail.Properties.Resources.time_nor;
            this.picStartTime.Location = new System.Drawing.Point(99, 6);
            this.picStartTime.Name = "picStartTime";
            this.picStartTime.Size = new System.Drawing.Size(19, 18);
            this.picStartTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStartTime.TabIndex = 44;
            this.picStartTime.TabStop = false;
            this.picStartTime.Click += new System.EventHandler(this.picTime_Click);
            // 
            // labToday
            // 
            this.labToday.BackColor = System.Drawing.Color.Transparent;
            this.labToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labToday.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labToday.ForeColor = System.Drawing.Color.White;
            this.labToday.Image = global::Retail.Properties.Resources.Pic_DateChose_prs;
            this.labToday.Location = new System.Drawing.Point(320, 30);
            this.labToday.Name = "labToday";
            this.labToday.Size = new System.Drawing.Size(77, 28);
            this.labToday.TabIndex = 0;
            this.labToday.Text = "今日";
            this.labToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labToday.Click += new System.EventHandler(this.labDateClick);
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button_select.BackgroundImage = global::Retail.Properties.Resources.Pic_btnSelect_nor;
            this.button_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_select.FlatAppearance.BorderSize = 0;
            this.button_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_select.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button_select.ForeColor = System.Drawing.Color.White;
            this.button_select.Location = new System.Drawing.Point(559, 88);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(75, 33);
            this.button_select.TabIndex = 98;
            this.button_select.Text = "查询";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label32.Location = new System.Drawing.Point(251, 62);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 20);
            this.label32.TabIndex = 97;
            this.label32.Text = "日期";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(207)))));
            this.pictureBox5.Location = new System.Drawing.Point(243, 65);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(5, 15);
            this.pictureBox5.TabIndex = 96;
            this.pictureBox5.TabStop = false;
            // 
            // mcStartDate
            // 
            this.mcStartDate.BackColor = System.Drawing.Color.White;
            this.mcStartDate.Location = new System.Drawing.Point(249, 126);
            this.mcStartDate.MaxSelectionCount = 1;
            this.mcStartDate.Name = "mcStartDate";
            this.mcStartDate.TabIndex = 110;
            this.mcStartDate.Visible = false;
            this.mcStartDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateSelected);
            // 
            // mcEndDate
            // 
            this.mcEndDate.BackColor = System.Drawing.Color.White;
            this.mcEndDate.Location = new System.Drawing.Point(414, 126);
            this.mcEndDate.MaxSelectionCount = 1;
            this.mcEndDate.Name = "mcEndDate";
            this.mcEndDate.TabIndex = 111;
            this.mcEndDate.Visible = false;
            this.mcEndDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateSelected);
            // 
            // PanelData
            // 
            this.PanelData.Controls.Add(this.labNoData);
            this.PanelData.Controls.Add(this.DataGrid);
            this.PanelData.Controls.Add(this.panelyhje_top);
            this.PanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelData.Location = new System.Drawing.Point(0, 125);
            this.PanelData.Name = "PanelData";
            this.PanelData.Size = new System.Drawing.Size(868, 476);
            this.PanelData.TabIndex = 112;
            // 
            // labNoData
            // 
            this.labNoData.AutoSize = true;
            this.labNoData.BackColor = System.Drawing.Color.White;
            this.labNoData.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labNoData.ForeColor = System.Drawing.Color.Gray;
            this.labNoData.Location = new System.Drawing.Point(321, 201);
            this.labNoData.Name = "labNoData";
            this.labNoData.Size = new System.Drawing.Size(92, 17);
            this.labNoData.TabIndex = 107;
            this.labNoData.Text = "本时段内无数据";
            this.labNoData.Visible = false;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrid.ColumnHeadersVisible = false;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCode,
            this.colAssestDate,
            this.colChargesName,
            this.colPaymentName,
            this.colChargeAmount,
            this.colAssestName,
            this.colRemark,
            this.colCreateDate,
            this.colCreateUserID,
            this.colIsSubmit,
            this.colSubmitDate,
            this.colCheckState,
            this.colLastModifiedUserID,
            this.colLastModifiedDate,
            this.colLastModifiedMemo});
            this.DataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 40);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 60;
            this.DataGrid.RowTemplate.Height = 40;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(868, 436);
            this.DataGrid.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "主键";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "登记编号";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colAssestDate
            // 
            this.colAssestDate.DataPropertyName = "AssestDate";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.colAssestDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAssestDate.HeaderText = "登记日期";
            this.colAssestDate.Name = "colAssestDate";
            this.colAssestDate.ReadOnly = true;
            this.colAssestDate.Width = 120;
            // 
            // colChargesName
            // 
            this.colChargesName.DataPropertyName = "ChargesName";
            this.colChargesName.HeaderText = "费用名称";
            this.colChargesName.Name = "colChargesName";
            this.colChargesName.ReadOnly = true;
            // 
            // colPaymentName
            // 
            this.colPaymentName.DataPropertyName = "PaymentName";
            this.colPaymentName.HeaderText = "支付方式";
            this.colPaymentName.Name = "colPaymentName";
            this.colPaymentName.ReadOnly = true;
            // 
            // colChargeAmount
            // 
            this.colChargeAmount.DataPropertyName = "ChargeAmount";
            this.colChargeAmount.HeaderText = "费用金额";
            this.colChargeAmount.Name = "colChargeAmount";
            this.colChargeAmount.ReadOnly = true;
            // 
            // colAssestName
            // 
            this.colAssestName.DataPropertyName = "AssestName";
            this.colAssestName.HeaderText = "登记人";
            this.colAssestName.Name = "colAssestName";
            this.colAssestName.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            this.colRemark.Width = 248;
            // 
            // colCreateDate
            // 
            this.colCreateDate.DataPropertyName = "CreateDate";
            this.colCreateDate.HeaderText = "创建日期";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.ReadOnly = true;
            this.colCreateDate.Visible = false;
            // 
            // colCreateUserID
            // 
            this.colCreateUserID.DataPropertyName = "CreateUserID";
            this.colCreateUserID.HeaderText = "创建人";
            this.colCreateUserID.Name = "colCreateUserID";
            this.colCreateUserID.ReadOnly = true;
            this.colCreateUserID.Visible = false;
            // 
            // colIsSubmit
            // 
            this.colIsSubmit.DataPropertyName = "IsSubmit";
            this.colIsSubmit.HeaderText = "是否提交";
            this.colIsSubmit.Name = "colIsSubmit";
            this.colIsSubmit.ReadOnly = true;
            this.colIsSubmit.Visible = false;
            // 
            // colSubmitDate
            // 
            this.colSubmitDate.DataPropertyName = "SubmitDate";
            this.colSubmitDate.HeaderText = "提交日期";
            this.colSubmitDate.Name = "colSubmitDate";
            this.colSubmitDate.ReadOnly = true;
            this.colSubmitDate.Visible = false;
            // 
            // colCheckState
            // 
            this.colCheckState.DataPropertyName = "CheckState";
            this.colCheckState.HeaderText = "状态";
            this.colCheckState.Name = "colCheckState";
            this.colCheckState.ReadOnly = true;
            this.colCheckState.Visible = false;
            // 
            // colLastModifiedUserID
            // 
            this.colLastModifiedUserID.DataPropertyName = "LastModifiedUserID";
            this.colLastModifiedUserID.HeaderText = "修改人";
            this.colLastModifiedUserID.Name = "colLastModifiedUserID";
            this.colLastModifiedUserID.ReadOnly = true;
            this.colLastModifiedUserID.Visible = false;
            // 
            // colLastModifiedDate
            // 
            this.colLastModifiedDate.DataPropertyName = "LastModifiedDate";
            this.colLastModifiedDate.HeaderText = "修改日期";
            this.colLastModifiedDate.Name = "colLastModifiedDate";
            this.colLastModifiedDate.ReadOnly = true;
            this.colLastModifiedDate.Visible = false;
            // 
            // colLastModifiedMemo
            // 
            this.colLastModifiedMemo.DataPropertyName = "LastModifiedMemo";
            this.colLastModifiedMemo.HeaderText = "修改原因";
            this.colLastModifiedMemo.Name = "colLastModifiedMemo";
            this.colLastModifiedMemo.ReadOnly = true;
            this.colLastModifiedMemo.Visible = false;
            // 
            // panelyhje_top
            // 
            this.panelyhje_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.panelyhje_top.Controls.Add(this.label6);
            this.panelyhje_top.Controls.Add(this.label5);
            this.panelyhje_top.Controls.Add(this.label4);
            this.panelyhje_top.Controls.Add(this.label3);
            this.panelyhje_top.Controls.Add(this.label2);
            this.panelyhje_top.Controls.Add(this.label1);
            this.panelyhje_top.Controls.Add(this.labCode);
            this.panelyhje_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelyhje_top.Location = new System.Drawing.Point(0, 0);
            this.panelyhje_top.Name = "panelyhje_top";
            this.panelyhje_top.Size = new System.Drawing.Size(868, 40);
            this.panelyhje_top.TabIndex = 1;
            this.panelyhje_top.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelWeek_Paint);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(620, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 40);
            this.label6.TabIndex = 9;
            this.label6.Text = "备注";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(520, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "登记人";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(420, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "费用金额";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(320, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "支付方式";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(220, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "费用名称";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "登记日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labCode
            // 
            this.labCode.BackColor = System.Drawing.Color.Transparent;
            this.labCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.labCode.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labCode.Location = new System.Drawing.Point(0, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(100, 40);
            this.labCode.TabIndex = 3;
            this.labCode.Text = "登记编号";
            this.labCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // s
            // 
            this.s.Controls.Add(this.panel8);
            this.s.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.s.Location = new System.Drawing.Point(0, 541);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(868, 60);
            this.s.TabIndex = 113;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel8.Controls.Add(this.labTotalAmount);
            this.panel8.Controls.Add(this.labTotalCount);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(868, 40);
            this.panel8.TabIndex = 7;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelWeek_Paint);
            // 
            // labTotalAmount
            // 
            this.labTotalAmount.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(207)))));
            this.labTotalAmount.Location = new System.Drawing.Point(421, 1);
            this.labTotalAmount.Name = "labTotalAmount";
            this.labTotalAmount.Size = new System.Drawing.Size(98, 38);
            this.labTotalAmount.TabIndex = 8;
            this.labTotalAmount.Text = "￥0.00";
            this.labTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTotalCount
            // 
            this.labTotalCount.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(207)))));
            this.labTotalCount.Location = new System.Drawing.Point(101, 1);
            this.labTotalCount.Name = "labTotalCount";
            this.labTotalCount.Size = new System.Drawing.Size(318, 38);
            this.labTotalCount.TabIndex = 7;
            this.labTotalCount.Text = "0项";
            this.labTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label24.Location = new System.Drawing.Point(1, 1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 38);
            this.label24.TabIndex = 3;
            this.label24.Text = "合计：";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmOtherExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 601);
            this.Controls.Add(this.s);
            this.Controls.Add(this.mcEndDate);
            this.Controls.Add(this.mcStartDate);
            this.Controls.Add(this.PanelData);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOtherExpense";
            this.Text = "FrmOtherExpense";
            this.Load += new System.EventHandler(this.FrmOtherExpense_Load);
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.panel_EndDate.ResumeLayout(false);
            this.panel_EndDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEndTime)).EndInit();
            this.PanelWeek.ResumeLayout(false);
            this.panel_StartDate.ResumeLayout(false);
            this.panel_StartDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.PanelData.ResumeLayout(false);
            this.PanelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.panelyhje_top.ResumeLayout(false);
            this.s.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Label labToday;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labWeek;
        private System.Windows.Forms.Label labMonth;
        private System.Windows.Forms.Panel PanelWeek;
        private System.Windows.Forms.Panel panel_EndDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.PictureBox picEndTime;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.Panel panel_StartDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.PictureBox picStartTime;
        private System.Windows.Forms.MonthCalendar mcStartDate;
        private System.Windows.Forms.MonthCalendar mcEndDate;
        private System.Windows.Forms.Panel PanelData;
        private System.Windows.Forms.Panel panelyhje_top;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Panel s;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChargesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChargeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubmitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastModifiedUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastModifiedMemo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labTotalAmount;
        private System.Windows.Forms.Label labTotalCount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labNoData;

    }
}