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
    public partial class FAdminCashier : Form
    {
        public FAdminCashier()
        {
            InitializeComponent();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            FAdminAddAccountCashier faac = new FAdminAddAccountCashier();
            faac.Show();
            this.Hide();
        }

        private void pbChange_Click(object sender, EventArgs e)
        {
            FAdminChangePasswordCashier fcpc = new FAdminChangePasswordCashier();
            fcpc.Show();
            this.Hide();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            FAdminDeletePasswordCashier fdpc = new FAdminDeletePasswordCashier();
            fdpc.Show();
            this.Hide();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminMenu fam = new FAdminMenu();
            fam.Show();
            this.Hide();
        }
    }
}
