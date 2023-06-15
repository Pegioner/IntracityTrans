namespace IntracityTrans
{
    partial class FormEditRoutes
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
            this.lblR_Price = new System.Windows.Forms.Label();
            this.txtR_Price = new System.Windows.Forms.TextBox();
            this.txtR_Count = new System.Windows.Forms.TextBox();
            this.txtR_End = new System.Windows.Forms.TextBox();
            this.lblR_Time = new System.Windows.Forms.Label();
            this.lblR_Count = new System.Windows.Forms.Label();
            this.lblR_End = new System.Windows.Forms.Label();
            this.lblR_Start = new System.Windows.Forms.Label();
            this.txtR_Time = new System.Windows.Forms.TextBox();
            this.txtR_Start = new System.Windows.Forms.TextBox();
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
            this.panelTitle.Size = new System.Drawing.Size(1110, 73);
            this.panelTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1110, 73);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Редактирование данных о маршрутах";
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
            this.BtnExit.Location = new System.Drawing.Point(1034, 0);
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
            this.btnEdit.Location = new System.Drawing.Point(305, 492);
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
            this.btnCancel.Location = new System.Drawing.Point(589, 492);
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
            // lblR_Price
            // 
            this.lblR_Price.AutoSize = true;
            this.lblR_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblR_Price.Location = new System.Drawing.Point(50, 384);
            this.lblR_Price.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblR_Price.Name = "lblR_Price";
            this.lblR_Price.Size = new System.Drawing.Size(220, 31);
            this.lblR_Price.TabIndex = 34;
            this.lblR_Price.Text = "Цена за проезд:";
            // 
            // txtR_Price
            // 
            this.txtR_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR_Price.Location = new System.Drawing.Point(389, 381);
            this.txtR_Price.Margin = new System.Windows.Forms.Padding(6);
            this.txtR_Price.Name = "txtR_Price";
            this.txtR_Price.Size = new System.Drawing.Size(400, 38);
            this.txtR_Price.TabIndex = 33;
            // 
            // txtR_Count
            // 
            this.txtR_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR_Count.Location = new System.Drawing.Point(389, 268);
            this.txtR_Count.Margin = new System.Windows.Forms.Padding(6);
            this.txtR_Count.Name = "txtR_Count";
            this.txtR_Count.Size = new System.Drawing.Size(400, 38);
            this.txtR_Count.TabIndex = 32;
            // 
            // txtR_End
            // 
            this.txtR_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR_End.Location = new System.Drawing.Point(389, 212);
            this.txtR_End.Margin = new System.Windows.Forms.Padding(6);
            this.txtR_End.Name = "txtR_End";
            this.txtR_End.Size = new System.Drawing.Size(400, 38);
            this.txtR_End.TabIndex = 31;
            // 
            // lblR_Time
            // 
            this.lblR_Time.AutoSize = true;
            this.lblR_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblR_Time.Location = new System.Drawing.Point(50, 327);
            this.lblR_Time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblR_Time.Name = "lblR_Time";
            this.lblR_Time.Size = new System.Drawing.Size(312, 31);
            this.lblR_Time.TabIndex = 29;
            this.lblR_Time.Text = "Время маршрута (мин):";
            // 
            // lblR_Count
            // 
            this.lblR_Count.AutoSize = true;
            this.lblR_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR_Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblR_Count.Location = new System.Drawing.Point(50, 271);
            this.lblR_Count.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblR_Count.Name = "lblR_Count";
            this.lblR_Count.Size = new System.Drawing.Size(305, 31);
            this.lblR_Count.TabIndex = 28;
            this.lblR_Count.Text = "Количество остановок:";
            // 
            // lblR_End
            // 
            this.lblR_End.AutoSize = true;
            this.lblR_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR_End.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblR_End.Location = new System.Drawing.Point(50, 215);
            this.lblR_End.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblR_End.Name = "lblR_End";
            this.lblR_End.Size = new System.Drawing.Size(280, 31);
            this.lblR_End.TabIndex = 27;
            this.lblR_End.Text = "Конечная остановка:";
            // 
            // lblR_Start
            // 
            this.lblR_Start.AutoSize = true;
            this.lblR_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblR_Start.Location = new System.Drawing.Point(50, 159);
            this.lblR_Start.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblR_Start.Name = "lblR_Start";
            this.lblR_Start.Size = new System.Drawing.Size(296, 31);
            this.lblR_Start.TabIndex = 26;
            this.lblR_Start.Text = "Начальная остановка:";
            // 
            // txtR_Time
            // 
            this.txtR_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR_Time.Location = new System.Drawing.Point(389, 324);
            this.txtR_Time.Margin = new System.Windows.Forms.Padding(6);
            this.txtR_Time.Name = "txtR_Time";
            this.txtR_Time.Size = new System.Drawing.Size(400, 38);
            this.txtR_Time.TabIndex = 25;
            // 
            // txtR_Start
            // 
            this.txtR_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR_Start.Location = new System.Drawing.Point(389, 155);
            this.txtR_Start.Margin = new System.Windows.Forms.Padding(6);
            this.txtR_Start.Name = "txtR_Start";
            this.txtR_Start.Size = new System.Drawing.Size(400, 38);
            this.txtR_Start.TabIndex = 24;
            // 
            // cbID
            // 
            this.cbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(389, 97);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(400, 39);
            this.cbID.TabIndex = 35;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IntracityTrans.Properties.Resources.AddRoutes;
            this.pictureBox1.Location = new System.Drawing.Point(850, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FormEditRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 615);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.lblR_Price);
            this.Controls.Add(this.txtR_Price);
            this.Controls.Add(this.txtR_Count);
            this.Controls.Add(this.txtR_End);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblR_Time);
            this.Controls.Add(this.lblR_Count);
            this.Controls.Add(this.lblR_End);
            this.Controls.Add(this.lblR_Start);
            this.Controls.Add(this.txtR_Time);
            this.Controls.Add(this.txtR_Start);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEditRoutes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование данных о маршрутах";
            this.Load += new System.EventHandler(this.FormEditRoutes_Load);
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
        private System.Windows.Forms.Label lblR_Price;
        public System.Windows.Forms.TextBox txtR_Price;
        public System.Windows.Forms.TextBox txtR_Count;
        public System.Windows.Forms.TextBox txtR_End;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblR_Time;
        private System.Windows.Forms.Label lblR_Count;
        private System.Windows.Forms.Label lblR_End;
        private System.Windows.Forms.Label lblR_Start;
        public System.Windows.Forms.TextBox txtR_Time;
        public System.Windows.Forms.TextBox txtR_Start;
        private System.Windows.Forms.ComboBox cbID;
    }
}