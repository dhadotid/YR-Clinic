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
    public partial class FAdminAddAccountCashier : Form
    {
        public FAdminAddAccountCashier()
        {
            InitializeComponent();
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Focus();
                lblNullUser.Visible = true;
            }
            else
            {
                lblNullUser.Visible = false;
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Focus();
                lblPass.Visible = true;
            }
            else
            {
                lblPass.Visible = false;
            }
        }

        private void txtCoPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtCoPass.Text == "")
            {
                txtCoPass.Focus();
                lblCoPass.Visible = true;
            }
            else
            {
                lblCoPass.Visible = false;
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminCashier fac = new FAdminCashier();
            fac.Show();
            this.Hide();
        }
    }
}
