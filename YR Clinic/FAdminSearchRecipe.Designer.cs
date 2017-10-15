namespace YR_Clinic
{
    partial class FAdminSearchRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdminSearchRecipe));
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRecipe = new System.Windows.Forms.DataGridView();
            this.lblPayHis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(602, 13);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(59, 49);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 23;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click_1);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(411, 118);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(54, 41);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 22;
            this.pbSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.txtSearch.Location = new System.Drawing.Point(206, 131);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(199, 30);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 14.25F);
            this.label1.Location = new System.Drawing.Point(138, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search";
            // 
            // dgvRecipe
            // 
            this.dgvRecipe.AllowUserToAddRows = false;
            this.dgvRecipe.AllowUserToDeleteRows = false;
            this.dgvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipe.Location = new System.Drawing.Point(12, 165);
            this.dgvRecipe.Name = "dgvRecipe";
            this.dgvRecipe.ReadOnly = true;
            this.dgvRecipe.Size = new System.Drawing.Size(649, 303);
            this.dgvRecipe.TabIndex = 19;
            // 
            // lblPayHis
            // 
            this.lblPayHis.AutoSize = true;
            this.lblPayHis.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayHis.Location = new System.Drawing.Point(12, 10);
            this.lblPayHis.Name = "lblPayHis";
            this.lblPayHis.Size = new System.Drawing.Size(155, 36);
            this.lblPayHis.TabIndex = 18;
            this.lblPayHis.Text = "Search Recipe";
            // 
            // FAdminSearchRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(673, 479);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRecipe);
            this.Controls.Add(this.lblPayHis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAdminSearchRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdminSearchRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRecipe;
        private System.Windows.Forms.Label lblPayHis;

    }
}