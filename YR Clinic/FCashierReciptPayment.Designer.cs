namespace YR_Clinic
{
    partial class FCashierReciptPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCashierReciptPayment));
            this.crViewPayment = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CRReciptPayment1 = new YR_Clinic.CRReciptPayment();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crViewPayment
            // 
            this.crViewPayment.ActiveViewIndex = 0;
            this.crViewPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewPayment.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewPayment.Location = new System.Drawing.Point(0, 0);
            this.crViewPayment.Name = "crViewPayment";
            this.crViewPayment.ReportSource = this.CRReciptPayment1;
            this.crViewPayment.Size = new System.Drawing.Size(1018, 593);
            this.crViewPayment.TabIndex = 0;
            this.crViewPayment.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(922, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FCashierReciptPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 593);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.crViewPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCashierReciptPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCashierReciptPayment";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crViewPayment;
        private CRReciptPayment CRReciptPayment1;
        private System.Windows.Forms.Button btnBack;
    }
}