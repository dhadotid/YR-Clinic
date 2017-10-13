namespace YR_Clinic
{
    partial class FAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdminLogin));
            this.lblError = new System.Windows.Forms.Label();
            this.lblColumnPass = new System.Windows.Forms.Label();
            this.lblColumnUser = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(27, 169);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(200, 13);
            this.lblError.TabIndex = 38;
            this.lblError.Text = "*Incorrect Username or Passowrd!";
            this.lblError.Visible = false;
            // 
            // lblColumnPass
            // 
            this.lblColumnPass.AutoSize = true;
            this.lblColumnPass.Font = new System.Drawing.Font("Nueva Std Cond", 15.75F);
            this.lblColumnPass.Location = new System.Drawing.Point(229, 164);
            this.lblColumnPass.Name = "lblColumnPass";
            this.lblColumnPass.Size = new System.Drawing.Size(159, 21);
            this.lblColumnPass.TabIndex = 37;
            this.lblColumnPass.Text = "*Please Fill The Column!";
            this.lblColumnPass.Visible = false;
            // 
            // lblColumnUser
            // 
            this.lblColumnUser.AutoSize = true;
            this.lblColumnUser.Font = new System.Drawing.Font("Nueva Std Cond", 15.75F);
            this.lblColumnUser.Location = new System.Drawing.Point(229, 100);
            this.lblColumnUser.Name = "lblColumnUser";
            this.lblColumnUser.Size = new System.Drawing.Size(159, 21);
            this.lblColumnUser.TabIndex = 36;
            this.lblColumnUser.Text = "*Please Fill The Column!";
            this.lblColumnUser.Visible = false;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.lblBack.Location = new System.Drawing.Point(340, 269);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(48, 26);
            this.lblBack.TabIndex = 35;
            this.lblBack.Text = "Back";
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(314, 192);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(100, 74);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 34;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.lblLogin.Location = new System.Drawing.Point(210, 269);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(56, 26);
            this.lblLogin.TabIndex = 33;
            this.lblLogin.Text = "Login";
            // 
            // pbLogin
            // 
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(185, 192);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(100, 74);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 32;
            this.pbLogin.TabStop = false;
            this.pbLogin.Click += new System.EventHandler(this.pbLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtPass.Location = new System.Drawing.Point(228, 131);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(186, 30);
            this.txtPass.TabIndex = 31;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtUser.Location = new System.Drawing.Point(228, 67);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(186, 30);
            this.txtUser.TabIndex = 30;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.lblPass.Location = new System.Drawing.Point(133, 134);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(85, 26);
            this.lblPass.TabIndex = 29;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.lblUser.Location = new System.Drawing.Point(133, 70);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(89, 26);
            this.lblUser.TabIndex = 28;
            this.lblUser.Text = "Username";
            // 
            // pbAdmin
            // 
            this.pbAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbAdmin.Image")));
            this.pbAdmin.Location = new System.Drawing.Point(27, 70);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(100, 90);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdmin.TabIndex = 27;
            this.pbAdmin.TabStop = false;
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLogin.ForeColor = System.Drawing.Color.Black;
            this.lblAdminLogin.Location = new System.Drawing.Point(148, 9);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(149, 36);
            this.lblAdminLogin.TabIndex = 26;
            this.lblAdminLogin.Text = "Login Admin";
            // 
            // FAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(440, 304);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblColumnPass);
            this.Controls.Add(this.lblColumnUser);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbAdmin);
            this.Controls.Add(this.lblAdminLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdminLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblColumnPass;
        private System.Windows.Forms.Label lblColumnUser;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Label lblAdminLogin;
    }
}