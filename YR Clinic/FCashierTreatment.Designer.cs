namespace YR_Clinic
{
    partial class FCashierTreatment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCashierTreatment));
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbSearchPatient = new System.Windows.Forms.PictureBox();
            this.txtDateTreatment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.lblNullDiagnose = new System.Windows.Forms.Label();
            this.lblNullDoctor = new System.Windows.Forms.Label();
            this.lblNullPatient = new System.Windows.Forms.Label();
            this.txtDiagnose = new System.Windows.Forms.TextBox();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.txtIdDoctor = new System.Windows.Forms.TextBox();
            this.txtIdPatient = new System.Windows.Forms.TextBox();
            this.txtIdTreatment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchDoctor = new System.Windows.Forms.TextBox();
            this.pbSearchDoctor = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPatient.Location = new System.Drawing.Point(577, 115);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(155, 30);
            this.txtSearchPatient.TabIndex = 78;
            this.txtSearchPatient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchPatient_KeyUp);
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(825, 9);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(59, 49);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 77;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbSearchPatient
            // 
            this.pbSearchPatient.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchPatient.Image")));
            this.pbSearchPatient.Location = new System.Drawing.Point(738, 112);
            this.pbSearchPatient.Name = "pbSearchPatient";
            this.pbSearchPatient.Size = new System.Drawing.Size(44, 34);
            this.pbSearchPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchPatient.TabIndex = 76;
            this.pbSearchPatient.TabStop = false;
            // 
            // txtDateTreatment
            // 
            this.txtDateTreatment.Enabled = false;
            this.txtDateTreatment.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTreatment.Location = new System.Drawing.Point(186, 329);
            this.txtDateTreatment.Name = "txtDateTreatment";
            this.txtDateTreatment.Size = new System.Drawing.Size(184, 30);
            this.txtDateTreatment.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(451, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 26);
            this.label9.TabIndex = 74;
            this.label9.Text = "Search Patient";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(296, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 26);
            this.label8.TabIndex = 73;
            this.label8.Text = "Save";
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
            this.pbSave.Location = new System.Drawing.Point(270, 365);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(100, 87);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 72;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(376, 151);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.Size = new System.Drawing.Size(508, 136);
            this.dgvPatient.TabIndex = 71;
            this.dgvPatient.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPatient_RowHeaderMouseClick);
            // 
            // lblNullDiagnose
            // 
            this.lblNullDiagnose.AutoSize = true;
            this.lblNullDiagnose.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNullDiagnose.ForeColor = System.Drawing.Color.Red;
            this.lblNullDiagnose.Location = new System.Drawing.Point(182, 304);
            this.lblNullDiagnose.Name = "lblNullDiagnose";
            this.lblNullDiagnose.Size = new System.Drawing.Size(150, 22);
            this.lblNullDiagnose.TabIndex = 70;
            this.lblNullDiagnose.Text = "*Please fill in the data";
            this.lblNullDiagnose.Visible = false;
            // 
            // lblNullDoctor
            // 
            this.lblNullDoctor.AutoSize = true;
            this.lblNullDoctor.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNullDoctor.ForeColor = System.Drawing.Color.Red;
            this.lblNullDoctor.Location = new System.Drawing.Point(182, 210);
            this.lblNullDoctor.Name = "lblNullDoctor";
            this.lblNullDoctor.Size = new System.Drawing.Size(148, 22);
            this.lblNullDoctor.TabIndex = 69;
            this.lblNullDoctor.Text = "*Please Select Doctor";
            this.lblNullDoctor.Visible = false;
            // 
            // lblNullPatient
            // 
            this.lblNullPatient.AutoSize = true;
            this.lblNullPatient.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNullPatient.ForeColor = System.Drawing.Color.Red;
            this.lblNullPatient.Location = new System.Drawing.Point(182, 153);
            this.lblNullPatient.Name = "lblNullPatient";
            this.lblNullPatient.Size = new System.Drawing.Size(145, 22);
            this.lblNullPatient.TabIndex = 68;
            this.lblNullPatient.Text = "*Please select patient";
            this.lblNullPatient.Visible = false;
            // 
            // txtDiagnose
            // 
            this.txtDiagnose.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnose.Location = new System.Drawing.Point(186, 271);
            this.txtDiagnose.Name = "txtDiagnose";
            this.txtDiagnose.Size = new System.Drawing.Size(184, 30);
            this.txtDiagnose.TabIndex = 67;
            this.txtDiagnose.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiagnose_Validating);
            // 
            // txtRecipe
            // 
            this.txtRecipe.Enabled = false;
            this.txtRecipe.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipe.Location = new System.Drawing.Point(186, 235);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(184, 30);
            this.txtRecipe.TabIndex = 66;
            // 
            // txtIdDoctor
            // 
            this.txtIdDoctor.Enabled = false;
            this.txtIdDoctor.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDoctor.Location = new System.Drawing.Point(186, 177);
            this.txtIdDoctor.Name = "txtIdDoctor";
            this.txtIdDoctor.Size = new System.Drawing.Size(184, 30);
            this.txtIdDoctor.TabIndex = 65;
            // 
            // txtIdPatient
            // 
            this.txtIdPatient.Enabled = false;
            this.txtIdPatient.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPatient.Location = new System.Drawing.Point(186, 120);
            this.txtIdPatient.Name = "txtIdPatient";
            this.txtIdPatient.Size = new System.Drawing.Size(184, 30);
            this.txtIdPatient.TabIndex = 64;
            // 
            // txtIdTreatment
            // 
            this.txtIdTreatment.Enabled = false;
            this.txtIdTreatment.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTreatment.Location = new System.Drawing.Point(186, 81);
            this.txtIdTreatment.Name = "txtIdTreatment";
            this.txtIdTreatment.Size = new System.Drawing.Size(184, 30);
            this.txtIdTreatment.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 26);
            this.label7.TabIndex = 62;
            this.label7.Text = "Date Treatment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 26);
            this.label6.TabIndex = 61;
            this.label6.Text = "Diagnose";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 60;
            this.label5.Text = "Id Recipe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 59;
            this.label4.Text = "Id Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 58;
            this.label3.Text = "Id Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 57;
            this.label2.Text = "Id Treatment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 56;
            this.label1.Text = "Treatment";
            // 
            // txtSearchDoctor
            // 
            this.txtSearchDoctor.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDoctor.Location = new System.Drawing.Point(577, 296);
            this.txtSearchDoctor.Name = "txtSearchDoctor";
            this.txtSearchDoctor.Size = new System.Drawing.Size(155, 30);
            this.txtSearchDoctor.TabIndex = 82;
            this.txtSearchDoctor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchDoctor_KeyUp);
            // 
            // pbSearchDoctor
            // 
            this.pbSearchDoctor.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchDoctor.Image")));
            this.pbSearchDoctor.Location = new System.Drawing.Point(738, 293);
            this.pbSearchDoctor.Name = "pbSearchDoctor";
            this.pbSearchDoctor.Size = new System.Drawing.Size(44, 34);
            this.pbSearchDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchDoctor.TabIndex = 81;
            this.pbSearchDoctor.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(451, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 26);
            this.label10.TabIndex = 80;
            this.label10.Text = "Search Doctor";
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToAddRows = false;
            this.dgvDoctor.AllowUserToDeleteRows = false;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Location = new System.Drawing.Point(377, 333);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.ReadOnly = true;
            this.dgvDoctor.Size = new System.Drawing.Size(508, 136);
            this.dgvDoctor.TabIndex = 79;
            this.dgvDoctor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoctor_RowHeaderMouseClick);
            // 
            // FCashierTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(897, 490);
            this.Controls.Add(this.txtSearchDoctor);
            this.Controls.Add(this.pbSearchDoctor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDoctor);
            this.Controls.Add(this.txtSearchPatient);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbSearchPatient);
            this.Controls.Add(this.txtDateTreatment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.lblNullDiagnose);
            this.Controls.Add(this.lblNullDoctor);
            this.Controls.Add(this.lblNullPatient);
            this.Controls.Add(this.txtDiagnose);
            this.Controls.Add(this.txtRecipe);
            this.Controls.Add(this.txtIdDoctor);
            this.Controls.Add(this.txtIdPatient);
            this.Controls.Add(this.txtIdTreatment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCashierTreatment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCashierTreatment";
            this.Load += new System.EventHandler(this.FCashierTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbSearchPatient;
        private System.Windows.Forms.TextBox txtDateTreatment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Label lblNullDiagnose;
        private System.Windows.Forms.Label lblNullDoctor;
        private System.Windows.Forms.Label lblNullPatient;
        private System.Windows.Forms.TextBox txtDiagnose;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.TextBox txtIdDoctor;
        private System.Windows.Forms.TextBox txtIdPatient;
        private System.Windows.Forms.TextBox txtIdTreatment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchDoctor;
        private System.Windows.Forms.PictureBox pbSearchDoctor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDoctor;
    }
}