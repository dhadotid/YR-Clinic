namespace YR_Clinic
{
    partial class FAdminDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdminDoctor));
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.pbSearchDoctor = new System.Windows.Forms.PictureBox();
            this.txtSearchDoctor = new System.Windows.Forms.TextBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pbUpdate = new System.Windows.Forms.PictureBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNullGender = new System.Windows.Forms.Label();
            this.lblNullDOB = new System.Windows.Forms.Label();
            this.lblNullName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtIdDoctor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.txtIdSpecialist = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNullIdSpecialist = new System.Windows.Forms.Label();
            this.dgvSpecialist = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.pbSearchSpecialist = new System.Windows.Forms.PictureBox();
            this.txtSearchSpecialist = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchSpecialist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToAddRows = false;
            this.dgvDoctor.AllowUserToDeleteRows = false;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Location = new System.Drawing.Point(520, 118);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.ReadOnly = true;
            this.dgvDoctor.Size = new System.Drawing.Size(639, 244);
            this.dgvDoctor.TabIndex = 105;
            this.dgvDoctor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoctor_RowHeaderMouseClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label15.Location = new System.Drawing.Point(631, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 26);
            this.label15.TabIndex = 104;
            this.label15.Text = "Search Doctor";
            // 
            // pbSearchDoctor
            // 
            this.pbSearchDoctor.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchDoctor.Image")));
            this.pbSearchDoctor.Location = new System.Drawing.Point(970, 67);
            this.pbSearchDoctor.Name = "pbSearchDoctor";
            this.pbSearchDoctor.Size = new System.Drawing.Size(51, 38);
            this.pbSearchDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchDoctor.TabIndex = 103;
            this.pbSearchDoctor.TabStop = false;
            // 
            // txtSearchDoctor
            // 
            this.txtSearchDoctor.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtSearchDoctor.Location = new System.Drawing.Point(758, 72);
            this.txtSearchDoctor.Name = "txtSearchDoctor";
            this.txtSearchDoctor.Size = new System.Drawing.Size(206, 30);
            this.txtSearchDoctor.TabIndex = 102;
            this.txtSearchDoctor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchDoctor_KeyUp);
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(1100, 13);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(59, 49);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 101;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label13.Location = new System.Drawing.Point(336, 583);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 26);
            this.label13.TabIndex = 100;
            this.label13.Text = "Delete";
            // 
            // pbDelete
            // 
            this.pbDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbDelete.Image")));
            this.pbDelete.Location = new System.Drawing.Point(326, 491);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(100, 89);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 99;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label12.Location = new System.Drawing.Point(240, 583);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 26);
            this.label12.TabIndex = 98;
            this.label12.Text = "Update";
            // 
            // pbUpdate
            // 
            this.pbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pbUpdate.Image")));
            this.pbUpdate.Location = new System.Drawing.Point(221, 491);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(100, 89);
            this.pbUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdate.TabIndex = 97;
            this.pbUpdate.TabStop = false;
            this.pbUpdate.Click += new System.EventHandler(this.pbUpdate_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumber.Location = new System.Drawing.Point(195, 430);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(287, 22);
            this.lblPhoneNumber.TabIndex = 94;
            this.lblPhoneNumber.Text = "*Please enter a valid phone number format";
            this.lblPhoneNumber.Visible = false;
            // 
            // lblNullGender
            // 
            this.lblNullGender.AutoSize = true;
            this.lblNullGender.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.lblNullGender.ForeColor = System.Drawing.Color.Red;
            this.lblNullGender.Location = new System.Drawing.Point(195, 372);
            this.lblNullGender.Name = "lblNullGender";
            this.lblNullGender.Size = new System.Drawing.Size(144, 22);
            this.lblNullGender.TabIndex = 93;
            this.lblNullGender.Text = "*Please select gender";
            this.lblNullGender.Visible = false;
            // 
            // lblNullDOB
            // 
            this.lblNullDOB.AutoSize = true;
            this.lblNullDOB.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.lblNullDOB.ForeColor = System.Drawing.Color.Red;
            this.lblNullDOB.Location = new System.Drawing.Point(194, 323);
            this.lblNullDOB.Name = "lblNullDOB";
            this.lblNullDOB.Size = new System.Drawing.Size(252, 22);
            this.lblNullDOB.TabIndex = 92;
            this.lblNullDOB.Text = "*Doctors must be more than 20 years";
            this.lblNullDOB.Visible = false;
            // 
            // lblNullName
            // 
            this.lblNullName.AutoSize = true;
            this.lblNullName.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.lblNullName.ForeColor = System.Drawing.Color.Red;
            this.lblNullName.Location = new System.Drawing.Point(195, 256);
            this.lblNullName.Name = "lblNullName";
            this.lblNullName.Size = new System.Drawing.Size(150, 22);
            this.lblNullName.TabIndex = 91;
            this.lblNullName.Text = "*Please fill in the data";
            this.lblNullName.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label10.Location = new System.Drawing.Point(141, 583);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 26);
            this.label10.TabIndex = 90;
            this.label10.Text = "Add";
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(115, 491);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(100, 89);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 89;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(198, 397);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(228, 30);
            this.txtPhoneNumber.TabIndex = 86;
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.rbFemale.Location = new System.Drawing.Point(341, 339);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 30);
            this.rbFemale.TabIndex = 85;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.rbMale.Location = new System.Drawing.Point(199, 339);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 30);
            this.rbMale.TabIndex = 84;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtDoctorName.Location = new System.Drawing.Point(198, 223);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(228, 30);
            this.txtDoctorName.TabIndex = 82;
            this.txtDoctorName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDoctorName_Validating);
            // 
            // txtIdDoctor
            // 
            this.txtIdDoctor.Enabled = false;
            this.txtIdDoctor.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtIdDoctor.Location = new System.Drawing.Point(198, 131);
            this.txtIdDoctor.Name = "txtIdDoctor";
            this.txtIdDoctor.Size = new System.Drawing.Size(228, 30);
            this.txtIdDoctor.TabIndex = 81;
            this.txtIdDoctor.TextChanged += new System.EventHandler(this.txtIdDoctor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label6.Location = new System.Drawing.Point(13, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 26);
            this.label6.TabIndex = 78;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label5.Location = new System.Drawing.Point(14, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 77;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label4.Location = new System.Drawing.Point(14, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 76;
            this.label4.Text = "Doctor Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 75;
            this.label3.Text = "Doctor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label2.Location = new System.Drawing.Point(14, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 74;
            this.label2.Text = "Id Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 33);
            this.label1.TabIndex = 73;
            this.label1.Text = "Doctor";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.dtp_DOB.Location = new System.Drawing.Point(199, 290);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(227, 30);
            this.dtp_DOB.TabIndex = 106;
            this.dtp_DOB.Value = new System.DateTime(2017, 10, 7, 0, 0, 0, 0);
            this.dtp_DOB.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_DOB_Validating);
            // 
            // txtIdSpecialist
            // 
            this.txtIdSpecialist.Enabled = false;
            this.txtIdSpecialist.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtIdSpecialist.Location = new System.Drawing.Point(198, 167);
            this.txtIdSpecialist.Name = "txtIdSpecialist";
            this.txtIdSpecialist.Size = new System.Drawing.Size(228, 30);
            this.txtIdSpecialist.TabIndex = 108;
            this.txtIdSpecialist.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdSpecialist_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label8.Location = new System.Drawing.Point(14, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 26);
            this.label8.TabIndex = 107;
            this.label8.Text = "Id Specialist";
            // 
            // lblNullIdSpecialist
            // 
            this.lblNullIdSpecialist.AutoSize = true;
            this.lblNullIdSpecialist.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.lblNullIdSpecialist.ForeColor = System.Drawing.Color.Red;
            this.lblNullIdSpecialist.Location = new System.Drawing.Point(195, 200);
            this.lblNullIdSpecialist.Name = "lblNullIdSpecialist";
            this.lblNullIdSpecialist.Size = new System.Drawing.Size(158, 22);
            this.lblNullIdSpecialist.TabIndex = 109;
            this.lblNullIdSpecialist.Text = "*Please select specialist";
            this.lblNullIdSpecialist.Visible = false;
            // 
            // dgvSpecialist
            // 
            this.dgvSpecialist.AllowUserToAddRows = false;
            this.dgvSpecialist.AllowUserToDeleteRows = false;
            this.dgvSpecialist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialist.Location = new System.Drawing.Point(520, 410);
            this.dgvSpecialist.Name = "dgvSpecialist";
            this.dgvSpecialist.ReadOnly = true;
            this.dgvSpecialist.Size = new System.Drawing.Size(639, 199);
            this.dgvSpecialist.TabIndex = 113;
            this.dgvSpecialist.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSpecialist_RowHeaderMouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label9.Location = new System.Drawing.Point(615, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 26);
            this.label9.TabIndex = 112;
            this.label9.Text = "Search Specialist";
            // 
            // pbSearchSpecialist
            // 
            this.pbSearchSpecialist.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchSpecialist.Image")));
            this.pbSearchSpecialist.Location = new System.Drawing.Point(970, 366);
            this.pbSearchSpecialist.Name = "pbSearchSpecialist";
            this.pbSearchSpecialist.Size = new System.Drawing.Size(51, 38);
            this.pbSearchSpecialist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchSpecialist.TabIndex = 111;
            this.pbSearchSpecialist.TabStop = false;
            // 
            // txtSearchSpecialist
            // 
            this.txtSearchSpecialist.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtSearchSpecialist.Location = new System.Drawing.Point(758, 374);
            this.txtSearchSpecialist.Name = "txtSearchSpecialist";
            this.txtSearchSpecialist.Size = new System.Drawing.Size(206, 30);
            this.txtSearchSpecialist.TabIndex = 110;
            this.txtSearchSpecialist.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchSpecialist_KeyUp);
            // 
            // FAdminDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1171, 622);
            this.Controls.Add(this.dgvSpecialist);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbSearchSpecialist);
            this.Controls.Add(this.txtSearchSpecialist);
            this.Controls.Add(this.lblNullIdSpecialist);
            this.Controls.Add(this.txtIdSpecialist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.dgvDoctor);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pbSearchDoctor);
            this.Controls.Add(this.txtSearchDoctor);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pbUpdate);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblNullGender);
            this.Controls.Add(this.lblNullDOB);
            this.Controls.Add(this.lblNullName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.txtIdDoctor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAdminDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Admin Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchSpecialist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbSearchDoctor;
        private System.Windows.Forms.TextBox txtSearchDoctor;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbUpdate;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblNullGender;
        private System.Windows.Forms.Label lblNullDOB;
        private System.Windows.Forms.Label lblNullName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtIdDoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox txtIdSpecialist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNullIdSpecialist;
        private System.Windows.Forms.DataGridView dgvSpecialist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbSearchSpecialist;
        private System.Windows.Forms.TextBox txtSearchSpecialist;
    }
}