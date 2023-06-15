namespace IntracityTrans
{
    partial class FormEditLines
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
            this.cbT_Name = new System.Windows.Forms.ComboBox();
            this.cbR_FirstLast = new System.Windows.Forms.ComboBox();
            this.cbT_Type = new System.Windows.Forms.ComboBox();
            this.lblL_Count = new System.Windows.Forms.Label();
            this.txtL_Count = new System.Windows.Forms.TextBox();
            this.lblL_Rounds = new System.Windows.Forms.Label();
            this.txtL_Rounds = new System.Windows.Forms.TextBox();
            this.cbD_FullName = new System.Windows.Forms.ComboBox();
            this.dateL_Date = new System.Windows.Forms.DateTimePicker();
            this.lblD_Date = new System.Windows.Forms.Label();
            this.lblR_FirstLast = new System.Windows.Forms.Label();
            this.lblD_FullName = new System.Windows.Forms.Label();
            this.lblT_Name = new System.Windows.Forms.Label();
            this.lblT_Type = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
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
            this.panelTitle.Size = new System.Drawing.Size(1160, 73);
            this.panelTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1160, 73);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Редактирование данных о рейсах";
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
            this.BtnExit.Location = new System.Drawing.Point(1084, 0);
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
            this.btnEdit.Location = new System.Drawing.Point(317, 629);
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
            this.btnCancel.Location = new System.Drawing.Point(601, 629);
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
            // cbT_Name
            // 
            this.cbT_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbT_Name.FormattingEnabled = true;
            this.cbT_Name.Location = new System.Drawing.Point(401, 210);
            this.cbT_Name.Name = "cbT_Name";
            this.cbT_Name.Size = new System.Drawing.Size(400, 39);
            this.cbT_Name.TabIndex = 41;
            // 
            // cbR_FirstLast
            // 
            this.cbR_FirstLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbR_FirstLast.FormattingEnabled = true;
            this.cbR_FirstLast.Location = new System.Drawing.Point(401, 328);
            this.cbR_FirstLast.Name = "cbR_FirstLast";
            this.cbR_FirstLast.Size = new System.Drawing.Size(400, 39);
            this.cbR_FirstLast.TabIndex = 40;
            // 
            // cbT_Type
            // 
            this.cbT_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbT_Type.FormattingEnabled = true;
            this.cbT_Type.Location = new System.Drawing.Point(401, 154);
            this.cbT_Type.Name = "cbT_Type";
            this.cbT_Type.Size = new System.Drawing.Size(400, 39);
            this.cbT_Type.TabIndex = 39;
            this.cbT_Type.SelectedIndexChanged += new System.EventHandler(this.cbT_Type_SelectedIndexChanged);
            // 
            // lblL_Count
            // 
            this.lblL_Count.AutoSize = true;
            this.lblL_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL_Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblL_Count.Location = new System.Drawing.Point(50, 522);
            this.lblL_Count.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblL_Count.Name = "lblL_Count";
            this.lblL_Count.Size = new System.Drawing.Size(327, 31);
            this.lblL_Count.TabIndex = 38;
            this.lblL_Count.Text = "Количество поссажиров:";
            // 
            // txtL_Count
            // 
            this.txtL_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL_Count.Location = new System.Drawing.Point(401, 518);
            this.txtL_Count.Margin = new System.Windows.Forms.Padding(6);
            this.txtL_Count.Name = "txtL_Count";
            this.txtL_Count.Size = new System.Drawing.Size(400, 38);
            this.txtL_Count.TabIndex = 37;
            // 
            // lblL_Rounds
            // 
            this.lblL_Rounds.AutoSize = true;
            this.lblL_Rounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL_Rounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblL_Rounds.Location = new System.Drawing.Point(50, 445);
            this.lblL_Rounds.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblL_Rounds.Name = "lblL_Rounds";
            this.lblL_Rounds.Size = new System.Drawing.Size(287, 62);
            this.lblL_Rounds.TabIndex = 36;
            this.lblL_Rounds.Text = "Количество проездов\r\nпо маршруту за рейс:";
            // 
            // txtL_Rounds
            // 
            this.txtL_Rounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL_Rounds.Location = new System.Drawing.Point(401, 456);
            this.txtL_Rounds.Margin = new System.Windows.Forms.Padding(6);
            this.txtL_Rounds.Name = "txtL_Rounds";
            this.txtL_Rounds.Size = new System.Drawing.Size(400, 38);
            this.txtL_Rounds.TabIndex = 35;
            // 
            // cbD_FullName
            // 
            this.cbD_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbD_FullName.FormattingEnabled = true;
            this.cbD_FullName.Location = new System.Drawing.Point(401, 266);
            this.cbD_FullName.Name = "cbD_FullName";
            this.cbD_FullName.Size = new System.Drawing.Size(400, 39);
            this.cbD_FullName.TabIndex = 34;
            // 
            // dateL_Date
            // 
            this.dateL_Date.CustomFormat = "";
            this.dateL_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateL_Date.Location = new System.Drawing.Point(401, 391);
            this.dateL_Date.Name = "dateL_Date";
            this.dateL_Date.Size = new System.Drawing.Size(400, 38);
            this.dateL_Date.TabIndex = 33;
            this.dateL_Date.Value = new System.DateTime(2020, 7, 6, 21, 40, 50, 0);
            // 
            // lblD_Date
            // 
            this.lblD_Date.AutoSize = true;
            this.lblD_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblD_Date.Location = new System.Drawing.Point(50, 397);
            this.lblD_Date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblD_Date.Name = "lblD_Date";
            this.lblD_Date.Size = new System.Drawing.Size(166, 31);
            this.lblD_Date.TabIndex = 32;
            this.lblD_Date.Text = "Дата рейса:";
            // 
            // lblR_FirstLast
            // 
            this.lblR_FirstLast.AutoSize = true;
            this.lblR_FirstLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR_FirstLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblR_FirstLast.Location = new System.Drawing.Point(50, 315);
            this.lblR_FirstLast.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblR_FirstLast.Name = "lblR_FirstLast";
            this.lblR_FirstLast.Size = new System.Drawing.Size(299, 62);
            this.lblR_FirstLast.TabIndex = 30;
            this.lblR_FirstLast.Text = "Начальная и конечная\r\nостановки маршрута:";
            // 
            // lblD_FullName
            // 
            this.lblD_FullName.AutoSize = true;
            this.lblD_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD_FullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblD_FullName.Location = new System.Drawing.Point(50, 269);
            this.lblD_FullName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblD_FullName.Name = "lblD_FullName";
            this.lblD_FullName.Size = new System.Drawing.Size(210, 31);
            this.lblD_FullName.TabIndex = 29;
            this.lblD_FullName.Text = "ФИО водителя:";
            // 
            // lblT_Name
            // 
            this.lblT_Name.AutoSize = true;
            this.lblT_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT_Name.Location = new System.Drawing.Point(50, 213);
            this.lblT_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblT_Name.Name = "lblT_Name";
            this.lblT_Name.Size = new System.Drawing.Size(295, 31);
            this.lblT_Name.TabIndex = 28;
            this.lblT_Name.Text = "Название транспорта:";
            // 
            // lblT_Type
            // 
            this.lblT_Type.AutoSize = true;
            this.lblT_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT_Type.Location = new System.Drawing.Point(50, 157);
            this.lblT_Type.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblT_Type.Name = "lblT_Type";
            this.lblT_Type.Size = new System.Drawing.Size(219, 31);
            this.lblT_Type.TabIndex = 27;
            this.lblT_Type.Text = "Тип транспорта:";
            // 
            // cbID
            // 
            this.cbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(401, 97);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(400, 39);
            this.cbID.TabIndex = 42;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IntracityTrans.Properties.Resources.AddLines;
            this.pictureBox1.Location = new System.Drawing.Point(872, 235);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // FormEditLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 740);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.cbT_Name);
            this.Controls.Add(this.cbR_FirstLast);
            this.Controls.Add(this.cbT_Type);
            this.Controls.Add(this.lblL_Count);
            this.Controls.Add(this.txtL_Count);
            this.Controls.Add(this.lblL_Rounds);
            this.Controls.Add(this.txtL_Rounds);
            this.Controls.Add(this.cbD_FullName);
            this.Controls.Add(this.dateL_Date);
            this.Controls.Add(this.lblD_Date);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblR_FirstLast);
            this.Controls.Add(this.lblD_FullName);
            this.Controls.Add(this.lblT_Name);
            this.Controls.Add(this.lblT_Type);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEditLines";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование данных о рейсах";
            this.Load += new System.EventHandler(this.FormEditLines_Load);
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
        private System.Windows.Forms.ComboBox cbT_Name;
        private System.Windows.Forms.ComboBox cbR_FirstLast;
        private System.Windows.Forms.ComboBox cbT_Type;
        private System.Windows.Forms.Label lblL_Count;
        public System.Windows.Forms.TextBox txtL_Count;
        private System.Windows.Forms.Label lblL_Rounds;
        public System.Windows.Forms.TextBox txtL_Rounds;
        private System.Windows.Forms.ComboBox cbD_FullName;
        private System.Windows.Forms.DateTimePicker dateL_Date;
        private System.Windows.Forms.Label lblD_Date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblR_FirstLast;
        private System.Windows.Forms.Label lblD_FullName;
        private System.Windows.Forms.Label lblT_Name;
        private System.Windows.Forms.Label lblT_Type;
        private System.Windows.Forms.ComboBox cbID;
    }
}