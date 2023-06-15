namespace IntracityTrans
{
    partial class FormNewReport
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dateF_Date = new System.Windows.Forms.DateTimePicker();
            this.lblCur = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dateT_Date = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbTotal = new System.Windows.Forms.CheckBox();
            this.cbID = new System.Windows.Forms.CheckBox();
            this.cbS_Type = new System.Windows.Forms.ComboBox();
            this.lblS_Type = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.panelTitle.Controls.Add(this.BtnExit);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(6);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(902, 73);
            this.panelTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(902, 73);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Создание отчёта о рейсах";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = global::IntracityTrans.Properties.Resources.Close;
            this.BtnExit.Location = new System.Drawing.Point(826, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(76, 73);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblType.Location = new System.Drawing.Point(101, 117);
            this.lblType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(133, 31);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Выборка:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(101, 215);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(281, 31);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Ограничение по дате";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(101, 358);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(301, 31);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Минимальная выручка";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(156, 527);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 67);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(440, 527);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 67);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblID.Location = new System.Drawing.Point(101, 454);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(197, 31);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "Отобразить ID";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFrom.Location = new System.Drawing.Point(101, 266);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(28, 31);
            this.lblFrom.TabIndex = 17;
            this.lblFrom.Text = "с";
            this.lblFrom.Visible = false;
            // 
            // dateF_Date
            // 
            this.dateF_Date.CustomFormat = "";
            this.dateF_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateF_Date.Location = new System.Drawing.Point(166, 260);
            this.dateF_Date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateF_Date.Name = "dateF_Date";
            this.dateF_Date.Size = new System.Drawing.Size(354, 38);
            this.dateF_Date.TabIndex = 18;
            this.dateF_Date.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateF_Date.Visible = false;
            // 
            // lblCur
            // 
            this.lblCur.AutoSize = true;
            this.lblCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCur.Location = new System.Drawing.Point(290, 403);
            this.lblCur.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCur.Name = "lblCur";
            this.lblCur.Size = new System.Drawing.Size(66, 31);
            this.lblCur.TabIndex = 23;
            this.lblCur.Text = "руб.";
            this.lblCur.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(107, 400);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(171, 38);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.Visible = false;
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Все",
            "По водителям",
            "По маршрутам"});
            this.cbType.Location = new System.Drawing.Point(270, 114);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(250, 39);
            this.cbType.TabIndex = 24;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(391, 221);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(28, 27);
            this.cbDate.TabIndex = 27;
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.cbDate_CheckedChanged);
            // 
            // dateT_Date
            // 
            this.dateT_Date.CustomFormat = "";
            this.dateT_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateT_Date.Location = new System.Drawing.Point(166, 307);
            this.dateT_Date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateT_Date.Name = "dateT_Date";
            this.dateT_Date.Size = new System.Drawing.Size(354, 38);
            this.dateT_Date.TabIndex = 29;
            this.dateT_Date.Value = new System.DateTime(2020, 7, 6, 21, 40, 50, 0);
            this.dateT_Date.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTo.Location = new System.Drawing.Point(101, 313);
            this.lblTo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(44, 31);
            this.lblTo.TabIndex = 28;
            this.lblTo.Text = "по";
            this.lblTo.Visible = false;
            // 
            // cbTotal
            // 
            this.cbTotal.AutoSize = true;
            this.cbTotal.Location = new System.Drawing.Point(411, 364);
            this.cbTotal.Name = "cbTotal";
            this.cbTotal.Size = new System.Drawing.Size(28, 27);
            this.cbTotal.TabIndex = 30;
            this.cbTotal.UseVisualStyleBackColor = true;
            this.cbTotal.CheckedChanged += new System.EventHandler(this.cbTotal_CheckedChanged);
            // 
            // cbID
            // 
            this.cbID.AutoSize = true;
            this.cbID.Location = new System.Drawing.Point(307, 460);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(28, 27);
            this.cbID.TabIndex = 31;
            this.cbID.UseVisualStyleBackColor = true;
            // 
            // cbS_Type
            // 
            this.cbS_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbS_Type.FormattingEnabled = true;
            this.cbS_Type.Items.AddRange(new object[] {
            "Все",
            "По водителяи",
            "По маршрутам"});
            this.cbS_Type.Location = new System.Drawing.Point(270, 165);
            this.cbS_Type.Name = "cbS_Type";
            this.cbS_Type.Size = new System.Drawing.Size(250, 39);
            this.cbS_Type.TabIndex = 33;
            this.cbS_Type.Visible = false;
            // 
            // lblS_Type
            // 
            this.lblS_Type.AutoSize = true;
            this.lblS_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblS_Type.Location = new System.Drawing.Point(101, 168);
            this.lblS_Type.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblS_Type.Name = "lblS_Type";
            this.lblS_Type.Size = new System.Drawing.Size(145, 31);
            this.lblS_Type.TabIndex = 32;
            this.lblS_Type.Text = "Название:";
            this.lblS_Type.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IntracityTrans.Properties.Resources.NewReport;
            this.pictureBox1.Location = new System.Drawing.Point(615, 191);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormNewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 638);
            this.Controls.Add(this.cbS_Type);
            this.Controls.Add(this.lblS_Type);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.cbTotal);
            this.Controls.Add(this.dateT_Date);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblCur);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dateF_Date);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormNewReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание отчёта о рейсах";
            this.Load += new System.EventHandler(this.FormNewReport_Load);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dateF_Date;
        private System.Windows.Forms.Label lblCur;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.DateTimePicker dateT_Date;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.CheckBox cbTotal;
        private System.Windows.Forms.CheckBox cbID;
        private System.Windows.Forms.ComboBox cbS_Type;
        private System.Windows.Forms.Label lblS_Type;
    }
}