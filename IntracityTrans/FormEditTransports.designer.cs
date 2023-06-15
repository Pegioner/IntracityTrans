namespace IntracityTrans
{
    partial class FormEditTransports
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.cbT_Type = new System.Windows.Forms.ComboBox();
            this.dateT_Start = new System.Windows.Forms.DateTimePicker();
            this.lblT_Start = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblT_Count = new System.Windows.Forms.Label();
            this.lblT_Type = new System.Windows.Forms.Label();
            this.lblT_VIN = new System.Windows.Forms.Label();
            this.lblT_Name = new System.Windows.Forms.Label();
            this.txtT_Count = new System.Windows.Forms.TextBox();
            this.txtT_VIN = new System.Windows.Forms.TextBox();
            this.txtT_Name = new System.Windows.Forms.TextBox();
            this.cbID = new System.Windows.Forms.ComboBox();
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
            this.panelTitle.Size = new System.Drawing.Size(1041, 73);
            this.panelTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1041, 73);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Редактирование данных о транспорте";
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
            this.BtnExit.Location = new System.Drawing.Point(965, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(76, 73);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(250, 489);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 67);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(534, 489);
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
            this.lblID.Location = new System.Drawing.Point(50, 100);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 31);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // cbT_Type
            // 
            this.cbT_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbT_Type.FormattingEnabled = true;
            this.cbT_Type.Location = new System.Drawing.Point(334, 268);
            this.cbT_Type.Name = "cbT_Type";
            this.cbT_Type.Size = new System.Drawing.Size(400, 39);
            this.cbT_Type.TabIndex = 30;
            // 
            // dateT_Start
            // 
            this.dateT_Start.CustomFormat = "";
            this.dateT_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateT_Start.Location = new System.Drawing.Point(334, 380);
            this.dateT_Start.Name = "dateT_Start";
            this.dateT_Start.Size = new System.Drawing.Size(400, 38);
            this.dateT_Start.TabIndex = 29;
            this.dateT_Start.Value = new System.DateTime(2020, 7, 6, 21, 40, 50, 0);
            // 
            // lblT_Start
            // 
            this.lblT_Start.AutoSize = true;
            this.lblT_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT_Start.Location = new System.Drawing.Point(50, 386);
            this.lblT_Start.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblT_Start.Name = "lblT_Start";
            this.lblT_Start.Size = new System.Drawing.Size(252, 31);
            this.lblT_Start.TabIndex = 28;
            this.lblT_Start.Text = "Дата поступления:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IntracityTrans.Properties.Resources.AddTransport;
            this.pictureBox1.Location = new System.Drawing.Point(795, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblT_Count
            // 
            this.lblT_Count.AutoSize = true;
            this.lblT_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT_Count.Location = new System.Drawing.Point(50, 327);
            this.lblT_Count.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblT_Count.Name = "lblT_Count";
            this.lblT_Count.Size = new System.Drawing.Size(236, 31);
            this.lblT_Count.TabIndex = 26;
            this.lblT_Count.Text = "Количество мест:";
            // 
            // lblT_Type
            // 
            this.lblT_Type.AutoSize = true;
            this.lblT_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT_Type.Location = new System.Drawing.Point(50, 271);
            this.lblT_Type.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblT_Type.Name = "lblT_Type";
            this.lblT_Type.Size = new System.Drawing.Size(219, 31);
            this.lblT_Type.TabIndex = 25;
            this.lblT_Type.Text = "Тип транспорта:";
            // 
            // lblT_VIN
            // 
            this.lblT_VIN.AutoSize = true;
            this.lblT_VIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_VIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT_VIN.Location = new System.Drawing.Point(50, 215);
            this.lblT_VIN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblT_VIN.Name = "lblT_VIN";
            this.lblT_VIN.Size = new System.Drawing.Size(154, 31);
            this.lblT_VIN.TabIndex = 24;
            this.lblT_VIN.Text = "VIN номер:";
            // 
            // lblT_Name
            // 
            this.lblT_Name.AutoSize = true;
            this.lblT_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT_Name.Location = new System.Drawing.Point(50, 159);
            this.lblT_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblT_Name.Name = "lblT_Name";
            this.lblT_Name.Size = new System.Drawing.Size(145, 31);
            this.lblT_Name.TabIndex = 23;
            this.lblT_Name.Text = "Название:";
            // 
            // txtT_Count
            // 
            this.txtT_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_Count.Location = new System.Drawing.Point(334, 324);
            this.txtT_Count.Margin = new System.Windows.Forms.Padding(6);
            this.txtT_Count.Name = "txtT_Count";
            this.txtT_Count.Size = new System.Drawing.Size(400, 38);
            this.txtT_Count.TabIndex = 22;
            // 
            // txtT_VIN
            // 
            this.txtT_VIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_VIN.Location = new System.Drawing.Point(334, 211);
            this.txtT_VIN.Margin = new System.Windows.Forms.Padding(6);
            this.txtT_VIN.Name = "txtT_VIN";
            this.txtT_VIN.Size = new System.Drawing.Size(400, 38);
            this.txtT_VIN.TabIndex = 21;
            // 
            // txtT_Name
            // 
            this.txtT_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_Name.Location = new System.Drawing.Point(334, 155);
            this.txtT_Name.Margin = new System.Windows.Forms.Padding(6);
            this.txtT_Name.Name = "txtT_Name";
            this.txtT_Name.Size = new System.Drawing.Size(400, 38);
            this.txtT_Name.TabIndex = 20;
            // 
            // cbID
            // 
            this.cbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(334, 97);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(400, 39);
            this.cbID.TabIndex = 31;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // FormEditTransports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 600);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.cbT_Type);
            this.Controls.Add(this.dateT_Start);
            this.Controls.Add(this.lblT_Start);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblT_Count);
            this.Controls.Add(this.lblT_Type);
            this.Controls.Add(this.lblT_VIN);
            this.Controls.Add(this.lblT_Name);
            this.Controls.Add(this.txtT_Count);
            this.Controls.Add(this.txtT_VIN);
            this.Controls.Add(this.txtT_Name);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEditTransports";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование данных о транспорте";
            this.Load += new System.EventHandler(this.FormEditTransports_Load);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbT_Type;
        private System.Windows.Forms.DateTimePicker dateT_Start;
        private System.Windows.Forms.Label lblT_Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblT_Count;
        private System.Windows.Forms.Label lblT_Type;
        private System.Windows.Forms.Label lblT_VIN;
        private System.Windows.Forms.Label lblT_Name;
        public System.Windows.Forms.TextBox txtT_Count;
        public System.Windows.Forms.TextBox txtT_VIN;
        public System.Windows.Forms.TextBox txtT_Name;
        private System.Windows.Forms.ComboBox cbID;
    }
}