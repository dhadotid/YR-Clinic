namespace YR_Clinic
{
    partial class FAdminChangePasswordCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdminChangePasswordCashier));
            this.lblNullNewCoPas = new System.Windows.Forms.Label();
            this.txtCoNewPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCashier = new System.Windows.Forms.DataGridView();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtIdCashier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNullNewCoPas
            // 
            this.lblNullNewCoPas.AutoSize = true;
            this.lblNullNewCoPas.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.lblNullNewCoPas.ForeColor = System.Drawing.Color.Red;
            this.lblNullNewCoPas.Location = new System.Drawing.Point(216, 344);
            this.lblNullNewCoPas.Name = "lblNullNewCoPas";
            this.lblNullNewCoPas.Size = new System.Drawing.Size(150, 22);
            this.lblNullNewCoPas.TabIndex = 65;
            this.lblNullNewCoPas.Text = "*Please fill in the data";
            this.lblNullNewCoPas.Visible = false;
            // 
            // txtCoNewPass
            // 
            this.txtCoNewPass.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtCoNewPass.Location = new System.Drawing.Point(216, 311);
            this.txtCoNewPass.Name = "txtCoNewPass";
            this.txtCoNewPass.PasswordChar = '*';
            this.txtCoNewPass.Size = new System.Drawing.Size(206, 30);
            this.txtCoNewPass.TabIndex = 64;
            this.txtCoNewPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtCoNewPass_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label7.Location = new System.Drawing.Point(16, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 26);
            this.label7.TabIndex = 63;
            this.label7.Text = "Confirm New Password";
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(722, 116);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(52, 40);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 62;
            this.pbSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtSearch.Location = new System.Drawing.Point(575, 126);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(141, 30);
            this.txtSearch.TabIndex = 61;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label8.Location = new System.Drawing.Point(507, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 26);
            this.label8.TabIndex = 60;
            this.label8.Text = "Search";
            // 
            // dgvCashier
            // 
            this.dgvCashier.AllowUserToAddRows = false;
            this.dgvCashier.AllowUserToDeleteRows = false;
            this.dgvCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashier.Location = new System.Drawing.Point(463, 162);
            this.dgvCashier.Name = "dgvCashier";
            this.dgvCashier.ReadOnly = true;
            this.dgvCashier.Size = new System.Drawing.Size(370, 309);
            this.dgvCashier.TabIndex = 59;
            this.dgvCashier.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCashier_RowHeaderMouseClick);
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(774, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(59, 49);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 58;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.lblSave.Location = new System.Drawing.Point(353, 448);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(46, 26);
            this.lblSave.TabIndex = 57;
            this.lblSave.Text = "Save";
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
            this.pbSave.Location = new System.Drawing.Point(322, 369);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(100, 76);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 56;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.lblNewPass.ForeColor = System.Drawing.Color.Red;
            this.lblNewPass.Location = new System.Drawing.Point(216, 285);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(150, 22);
            this.lblNewPass.TabIndex = 55;
            this.lblNewPass.Text = "*Please fill in the data";
            this.lblNewPass.Visible = false;
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.lblOldPass.ForeColor = System.Drawing.Color.Red;
            this.lblOldPass.Location = new System.Drawing.Point(212, 227);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(150, 22);
            this.lblOldPass.TabIndex = 54;
            this.lblOldPass.Text = "*Please fill in the data";
            this.lblOldPass.Visible = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtNewPass.Location = new System.Drawing.Point(216, 252);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(206, 30);
            this.txtNewPass.TabIndex = 53;
            this.txtNewPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPass_Validating);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Enabled = false;
            this.txtOldPass.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtOldPass.Location = new System.Drawing.Point(216, 195);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(206, 30);
            this.txtOldPass.TabIndex = 52;
            this.txtOldPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtOldPass_Validating);
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtUser.Location = new System.Drawing.Point(216, 137);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(206, 30);
            this.txtUser.TabIndex = 51;
            // 
            // txtIdCashier
            // 
            this.txtIdCashier.Enabled = false;
            this.txtIdCashier.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtIdCashier.Location = new System.Drawing.Point(216, 79);
            this.txtIdCashier.Name = "txtIdCashier";
            this.txtIdCashier.Size = new System.Drawing.Size(206, 30);
            this.txtIdCashier.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label5.Location = new System.Drawing.Point(16, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 49;
            this.label5.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "Id Cashier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 36);
            this.label1.TabIndex = 45;
            this.label1.Text = "Change Password Cashier";
            // 
            // FAdminChangePasswordCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(848, 484);
            this.Controls.Add(this.lblNullNewCoPas);
            this.Controls.Add(this.txtCoNewPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvCashier);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtIdCashier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAdminChangePasswordCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdminChangePasswordCashier";
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNullNewCoPas;
        private System.Windows.Forms.TextBox txtCoNewPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCashier;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtIdCashier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}