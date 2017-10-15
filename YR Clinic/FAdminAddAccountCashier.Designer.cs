namespace YR_Clinic
{
    partial class FAdminAddAccountCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdminAddAccountCashier));
            this.txtIdCashier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lblCoPass = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNullUser = new System.Windows.Forms.Label();
            this.txtCoPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCashier
            // 
            this.txtIdCashier.Enabled = false;
            this.txtIdCashier.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtIdCashier.Location = new System.Drawing.Point(212, 72);
            this.txtIdCashier.Name = "txtIdCashier";
            this.txtIdCashier.Size = new System.Drawing.Size(194, 30);
            this.txtIdCashier.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label5.Location = new System.Drawing.Point(15, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 40;
            this.label5.Text = "Id Cashier";
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(456, 14);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(59, 49);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 39;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(418, 156);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(100, 90);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 38;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // lblCoPass
            // 
            this.lblCoPass.AutoSize = true;
            this.lblCoPass.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.lblCoPass.ForeColor = System.Drawing.Color.Red;
            this.lblCoPass.Location = new System.Drawing.Point(208, 249);
            this.lblCoPass.Name = "lblCoPass";
            this.lblCoPass.Size = new System.Drawing.Size(150, 22);
            this.lblCoPass.TabIndex = 37;
            this.lblCoPass.Text = "*Please fill in the data";
            this.lblCoPass.Visible = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Minion Pro", 10F);
            this.lblPass.ForeColor = System.Drawing.Color.Red;
            this.lblPass.Location = new System.Drawing.Point(-4, 195);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(416, 19);
            this.lblPass.TabIndex = 36;
            this.lblPass.Text = "*Please fill in the data or inccorect format, please enter only alphanumber";
            this.lblPass.Visible = false;
            // 
            // lblNullUser
            // 
            this.lblNullUser.AutoSize = true;
            this.lblNullUser.Font = new System.Drawing.Font("Minion Pro", 10F);
            this.lblNullUser.ForeColor = System.Drawing.Color.Red;
            this.lblNullUser.Location = new System.Drawing.Point(16, 141);
            this.lblNullUser.Name = "lblNullUser";
            this.lblNullUser.Size = new System.Drawing.Size(416, 19);
            this.lblNullUser.TabIndex = 35;
            this.lblNullUser.Text = "*Please fill in the data or inccorect format, please enter only alphanumber";
            this.lblNullUser.Visible = false;
            // 
            // txtCoPass
            // 
            this.txtCoPass.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtCoPass.Location = new System.Drawing.Point(212, 216);
            this.txtCoPass.Name = "txtCoPass";
            this.txtCoPass.PasswordChar = '*';
            this.txtCoPass.Size = new System.Drawing.Size(194, 30);
            this.txtCoPass.TabIndex = 34;
            this.txtCoPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtCoPass_Validating);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtPass.Location = new System.Drawing.Point(212, 162);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(194, 30);
            this.txtPass.TabIndex = 33;
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtUser.Location = new System.Drawing.Point(212, 108);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(194, 30);
            this.txtUser.TabIndex = 32;
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label4.Location = new System.Drawing.Point(15, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label3.Location = new System.Drawing.Point(15, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Add Account Cashier";
            // 
            // FAdminAddAccountCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(527, 278);
            this.Controls.Add(this.txtIdCashier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.lblCoPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNullUser);
            this.Controls.Add(this.txtCoPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAdminAddAccountCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdminAddAccountCashier";
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCashier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lblCoPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblNullUser;
        private System.Windows.Forms.TextBox txtCoPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}