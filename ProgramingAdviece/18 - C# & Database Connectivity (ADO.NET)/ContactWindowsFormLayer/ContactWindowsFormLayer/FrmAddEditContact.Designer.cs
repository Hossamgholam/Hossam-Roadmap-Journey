namespace ContactWindowsFormLayer
{
    partial class FrmAddEditContact
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.LbAddOEdite = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCloseContact = new System.Windows.Forms.Button();
            this.BtnSaveContac = new System.Windows.Forms.Button();
            this.pnlima = new System.Windows.Forms.Panel();
            this.BtnRemoveImage = new System.Windows.Forms.Button();
            this.BtnSetImage = new System.Windows.Forms.Button();
            this.PbContact = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.TBID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.DTPDOF = new System.Windows.Forms.DateTimePicker();
            this.CBCountry = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.pnlima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbContact)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.MaximumSize = new System.Drawing.Size(0, 70);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(832, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // LbAddOEdite
            // 
            this.LbAddOEdite.AutoSize = true;
            this.LbAddOEdite.BackColor = System.Drawing.Color.White;
            this.LbAddOEdite.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddOEdite.Location = new System.Drawing.Point(20, 20);
            this.LbAddOEdite.Name = "LbAddOEdite";
            this.LbAddOEdite.Size = new System.Drawing.Size(266, 41);
            this.LbAddOEdite.TabIndex = 1;
            this.LbAddOEdite.Text = "Add New Contact";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnCloseContact);
            this.panel1.Controls.Add(this.BtnSaveContac);
            this.panel1.Controls.Add(this.pnlima);
            this.panel1.Controls.Add(this.pnlInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(832, 483);
            this.panel1.TabIndex = 2;
            // 
            // BtnCloseContact
            // 
            this.BtnCloseContact.BackColor = System.Drawing.Color.Gray;
            this.BtnCloseContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseContact.ForeColor = System.Drawing.Color.White;
            this.BtnCloseContact.Location = new System.Drawing.Point(310, 429);
            this.BtnCloseContact.Name = "BtnCloseContact";
            this.BtnCloseContact.Size = new System.Drawing.Size(120, 45);
            this.BtnCloseContact.TabIndex = 23;
            this.BtnCloseContact.Text = "close";
            this.BtnCloseContact.UseVisualStyleBackColor = false;
            this.BtnCloseContact.Click += new System.EventHandler(this.BtnCloseContact_Click);
            // 
            // BtnSaveContac
            // 
            this.BtnSaveContac.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSaveContac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveContac.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveContac.ForeColor = System.Drawing.Color.White;
            this.BtnSaveContac.Location = new System.Drawing.Point(86, 429);
            this.BtnSaveContac.Name = "BtnSaveContac";
            this.BtnSaveContac.Size = new System.Drawing.Size(120, 45);
            this.BtnSaveContac.TabIndex = 22;
            this.BtnSaveContac.Text = "SAVE";
            this.BtnSaveContac.UseVisualStyleBackColor = false;
            this.BtnSaveContac.Click += new System.EventHandler(this.BtnSaveContac_Click);
            // 
            // pnlima
            // 
            this.pnlima.Controls.Add(this.BtnRemoveImage);
            this.pnlima.Controls.Add(this.BtnSetImage);
            this.pnlima.Controls.Add(this.PbContact);
            this.pnlima.Location = new System.Drawing.Point(568, 23);
            this.pnlima.Name = "pnlima";
            this.pnlima.Size = new System.Drawing.Size(220, 300);
            this.pnlima.TabIndex = 21;
            // 
            // BtnRemoveImage
            // 
            this.BtnRemoveImage.BackColor = System.Drawing.Color.IndianRed;
            this.BtnRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveImage.FlatAppearance.BorderSize = 0;
            this.BtnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveImage.Location = new System.Drawing.Point(39, 252);
            this.BtnRemoveImage.MinimumSize = new System.Drawing.Size(110, 40);
            this.BtnRemoveImage.Name = "BtnRemoveImage";
            this.BtnRemoveImage.Size = new System.Drawing.Size(140, 40);
            this.BtnRemoveImage.TabIndex = 3;
            this.BtnRemoveImage.Text = "Remove";
            this.BtnRemoveImage.UseVisualStyleBackColor = false;
            this.BtnRemoveImage.Click += new System.EventHandler(this.BtnRemoveImage_Click);
            // 
            // BtnSetImage
            // 
            this.BtnSetImage.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSetImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetImage.FlatAppearance.BorderSize = 0;
            this.BtnSetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetImage.ForeColor = System.Drawing.Color.White;
            this.BtnSetImage.Location = new System.Drawing.Point(39, 206);
            this.BtnSetImage.MinimumSize = new System.Drawing.Size(110, 40);
            this.BtnSetImage.Name = "BtnSetImage";
            this.BtnSetImage.Size = new System.Drawing.Size(140, 40);
            this.BtnSetImage.TabIndex = 2;
            this.BtnSetImage.Text = "Set Image";
            this.BtnSetImage.UseVisualStyleBackColor = false;
            this.BtnSetImage.Click += new System.EventHandler(this.BtnSetImage_Click);
            // 
            // PbContact
            // 
            this.PbContact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PbContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbContact.Location = new System.Drawing.Point(20, 20);
            this.PbContact.Name = "PbContact";
            this.PbContact.Size = new System.Drawing.Size(180, 180);
            this.PbContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbContact.TabIndex = 1;
            this.PbContact.TabStop = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.TBID);
            this.pnlInfo.Controls.Add(this.label9);
            this.pnlInfo.Controls.Add(this.TBAddress);
            this.pnlInfo.Controls.Add(this.DTPDOF);
            this.pnlInfo.Controls.Add(this.CBCountry);
            this.pnlInfo.Controls.Add(this.label8);
            this.pnlInfo.Controls.Add(this.label7);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.TBPhone);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.TBEmail);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.TBLastName);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.TBFirstName);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.pnlImage);
            this.pnlInfo.Location = new System.Drawing.Point(23, 6);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(500, 417);
            this.pnlInfo.TabIndex = 0;
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(140, 15);
            this.TBID.Name = "TBID";
            this.TBID.ReadOnly = true;
            this.TBID.Size = new System.Drawing.Size(250, 30);
            this.TBID.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBAddress
            // 
            this.TBAddress.Location = new System.Drawing.Point(140, 331);
            this.TBAddress.Multiline = true;
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(250, 70);
            this.TBAddress.TabIndex = 20;
            // 
            // DTPDOF
            // 
            this.DTPDOF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDOF.Location = new System.Drawing.Point(140, 286);
            this.DTPDOF.Name = "DTPDOF";
            this.DTPDOF.Size = new System.Drawing.Size(250, 30);
            this.DTPDOF.TabIndex = 19;
            // 
            // CBCountry
            // 
            this.CBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCountry.FormattingEnabled = true;
            this.CBCountry.Location = new System.Drawing.Point(140, 241);
            this.CBCountry.Name = "CBCountry";
            this.CBCountry.Size = new System.Drawing.Size(250, 31);
            this.CBCountry.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Address";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "DOB   ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Country";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(140, 196);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(250, 30);
            this.TBPhone.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(140, 151);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(250, 30);
            this.TBEmail.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email      ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(140, 106);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(250, 30);
            this.TBLastName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Last Name  :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(140, 61);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(250, 30);
            this.TBFirstName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name    :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlImage
            // 
            this.pnlImage.Location = new System.Drawing.Point(560, 40);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(220, 300);
            this.pnlImage.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbAddOEdite);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAddEditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Contact";
            this.Load += new System.EventHandler(this.FrmAddEditContact_Load);
            this.panel1.ResumeLayout(false);
            this.pnlima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbContact)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label LbAddOEdite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBAddress;
        private System.Windows.Forms.DateTimePicker DTPDOF;
        private System.Windows.Forms.ComboBox CBCountry;
        private System.Windows.Forms.PictureBox PbContact;
        private System.Windows.Forms.Panel pnlima;
        private System.Windows.Forms.Button BtnRemoveImage;
        private System.Windows.Forms.Button BtnSetImage;
        private System.Windows.Forms.Button BtnSaveContac;
        private System.Windows.Forms.Button BtnCloseContact;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}