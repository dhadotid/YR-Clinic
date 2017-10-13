using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YR_Clinic
{
    public partial class FAdminChangePasswordCashier : Form
    {
        public FAdminChangePasswordCashier()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminCashier fac =  new FAdminCashier();
            fac.Show();
            this.Hide();
        }

        private void txtOldPass_Validating(object sender, CancelEventArgs e)
        {
            if(txtOldPass.Text == "")
            {
                txtOldPass.Focus();
                lblOldPass.Visible = true;
            }
            else
            {
                lblOldPass.Visible = false;
            }
        }

        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            if(txtNewPass.Text == "")
            {
                txtNewPass.Focus();
                lblNewPass.Visible = true;
            }
            else
            {
                lblNewPass.Visible = false;
            }
        }

        private void txtCoNewPass_Validating(object sender, CancelEventArgs e)
        {
            if(txtCoNewPass.Text == "")
            {
                txtCoNewPass.Focus();
                lblNullNewCoPas.Visible = true;
            }
            else
            {
                lblNullNewCoPas.Visible = false;
            }
        }
    }
}
