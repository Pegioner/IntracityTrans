namespace IntracityTrans
{
    partial class FormEditDrivers
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
            this.dateD_DOS = new System.Windows.Forms.DateTimePicker();
            this.dateD_DOB = new System.Windows.Forms.DateTimePicker();
            this.lblD_Salary = new System.Windows.Forms.Label();
            this.lblT_Type = new System.Windows.Forms.Label();
            this.lblD_DOB = new System.Windows.Forms.Label();
            this.lblD_FullName = new System.Windows.Forms.Label();
            this.txtD_Salary = new System.Windows.Forms.TextBox();
            this.txtD_FullName = new System.Windows.Forms.TextBox();
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
            this.panelTitle.Size = new System.Drawing.Size(1050, 73);
            this.panelTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1050, 73);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Редактирование данных о водителях";
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
            this.BtnExit.Location = new System.Drawing.Point(974, 0);
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
            this.btnEdit.Location = new System.Drawing.Point(274, 435);
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
            this.btnCancel.Location = new System.Drawing.Point(558, 435);
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
            // dateD_DOS
            // 
            this.dateD_DOS.CustomFormat = "";
            this.dateD_DOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateD_DOS.Location = new System.Drawing.Point(358, 266);
            this.dateD_DOS.Name = "dateD_DOS";
            this.dateD_DOS.Size = new System.Drawing.Size(400, 38);
            this.dateD_DOS.TabIndex = 28;
            this.dateD_DOS.Value = new System.DateTime(2020, 7, 6, 21, 40, 50, 0);
            // 
            // dateD_DOB
            // 
            this.dateD_DOB.CustomFormat = "";
            this.dateD_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateD_DOB.Location = new System.Drawing.Point(358, 210);
            this.dateD_DOB.Name = "dateD_DOB";
            this.dateD_DOB.Size = new System.Drawing.Size(400, 38);
            this.dateD_DOB.TabIndex = 27;
            this.dateD_DOB.Value = new System.DateTime(2020, 7, 6, 21, 40, 50, 0);
            // 
            // lblD_Salary
            // 
            this.lblD_Salary.AutoSize = true;
            this.lblD_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD_Salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblD_Salary.Location = new System.Drawing.Point(50, 328);
            this.lblD_Salary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblD_Salary.Name = "lblD_Salary";
            this.lblD_Salary.Size = new System.Drawing.Size(180, 31);
            this.lblD_Salary.TabIndex = 25;
            this.lblD_Salary.Text = "Оклад (руб.):";
            // 
            // lblT_Type
            // 
            this.lblT_Type.AutoSize = true;
            this.lblT_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT_Type.Location = new System.Drawing.Point(50, 272);
            this.lblT_Type.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblT_Type.Name = "lblT_Type";
            this.lblT_Type.Size = new System.Drawing.Size(279, 31);
            this.lblT_Type.TabIndex = 24;
            this.lblT_Type.Text = "Дата начала работы:";
            // 
            // lblD_DOB
            // 
            this.lblD_DOB.AutoSize = true;
            this.lblD_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD_DOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblD_DOB.Location = new System.Drawing.Point(50, 216);
            this.lblD_DOB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblD_DOB.Name = "lblD_DOB";
            this.lblD_DOB.Size = new System.Drawing.Size(217, 31);
            this.lblD_DOB.TabIndex = 23;
            this.lblD_DOB.Text = "Дата рождения:";
            // 
            // lblD_FullName
            // 
            this.lblD_FullName.AutoSize = true;
            this.lblD_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD_FullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblD_FullName.Location = new System.Drawing.Point(50, 160);
            this.lblD_FullName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblD_FullName.Name = "lblD_FullName";
            this.lblD_FullName.Size = new System.Drawing.Size(86, 31);
            this.lblD_FullName.TabIndex = 22;
            this.lblD_FullName.Text = "ФИО:";
            // 
            // txtD_Salary
            // 
            this.txtD_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_Salary.Location = new System.Drawing.Point(358, 325);
            this.txtD_Salary.Margin = new System.Windows.Forms.Padding(6);
            this.txtD_Salary.Name = "txtD_Salary";
            this.txtD_Salary.Size = new System.Drawing.Size(400, 38);
            this.txtD_Salary.TabIndex = 21;
            // 
            // txtD_FullName
            // 
            this.txtD_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_FullName.Location = new System.Drawing.Point(358, 156);
            this.txtD_FullName.Margin = new System.Windows.Forms.Padding(6);
            this.txtD_FullName.Name = "txtD_FullName";
            this.txtD_FullName.Size = new System.Drawing.Size(400, 38);
            this.txtD_FullName.TabIndex = 20;
            // 
            // cbID
            // 
            this.cbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(358, 97);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(400, 39);
            this.cbID.TabIndex = 32;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IntracityTrans.Properties.Resources.AddDrivers;
            this.pictureBox1.Location = new System.Drawing.Point(807, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FormEditDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 550);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.dateD_DOS);
            this.Controls.Add(this.dateD_DOB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblD_Salary);
            this.Controls.Add(this.lblT_Type);
            this.Controls.Add(this.lblD_DOB);
            this.Controls.Add(this.lblD_FullName);
            this.Controls.Add(this.txtD_Salary);
            this.Controls.Add(this.txtD_FullName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEditDrivers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование данных о водителях";
            this.Load += new System.EventHandler(this.FormEditDrivers_Load);
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
        private System.Windows.Forms.DateTimePicker dateD_DOS;
        private System.Windows.Forms.DateTimePicker dateD_DOB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblD_Salary;
        private System.Windows.Forms.Label lblT_Type;
        private System.Windows.Forms.Label lblD_DOB;
        private System.Windows.Forms.Label lblD_FullName;
        public System.Windows.Forms.TextBox txtD_Salary;
        public System.Windows.Forms.TextBox txtD_FullName;
        private System.Windows.Forms.ComboBox cbID;
    }
}