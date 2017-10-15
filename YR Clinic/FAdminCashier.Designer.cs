namespace YR_Clinic
{
    partial class FAdminCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdminCashier));
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbChange = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.lblDelete.Location = new System.Drawing.Point(509, 208);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(192, 26);
            this.lblDelete.TabIndex = 23;
            this.lblDelete.Text = "Delete Account Cashier";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.lblChange.Location = new System.Drawing.Point(240, 208);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(209, 26);
            this.lblChange.TabIndex = 22;
            this.lblChange.Text = "Change Password Cashier";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.lblAdd.Location = new System.Drawing.Point(5, 208);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(176, 26);
            this.lblAdd.TabIndex = 21;
            this.lblAdd.Text = "Add Account Cashier";
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(639, 13);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(62, 50);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 20;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbDelete
            // 
            this.pbDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbDelete.Image")));
            this.pbDelete.Location = new System.Drawing.Point(559, 109);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(100, 96);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 19;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbChange
            // 
            this.pbChange.Image = ((System.Drawing.Image)(resources.GetObject("pbChange.Image")));
            this.pbChange.Location = new System.Drawing.Point(296, 109);
            this.pbChange.Name = "pbChange";
            this.pbChange.Size = new System.Drawing.Size(100, 96);
            this.pbChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChange.TabIndex = 18;
            this.pbChange.TabStop = false;
            this.pbChange.Click += new System.EventHandler(this.pbChange_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(38, 109);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(109, 96);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 17;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cashier";
            // 
            // FAdminCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(721, 242);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.pbChange);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAdminCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdminCashier";
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbChange;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label label1;

    }
}