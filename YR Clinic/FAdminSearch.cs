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
    public partial class FAdminSearch : Form
    {
        public FAdminSearch()
        {
            InitializeComponent();
        }

        private void pbTreatment_Click(object sender, EventArgs e)
        {
            FAdminSearchTreatment fast = new FAdminSearchTreatment();
            fast.Show();
            this.Hide();
        }

        private void pbRecipe_Click(object sender, EventArgs e)
        {
            FAdminSearchRecipe fasr = new FAdminSearchRecipe();
            fasr.Show();
            this.Hide();
        }

        private void pbPayment_Click(object sender, EventArgs e)
        {
            FAdminPaymentHistory faph = new FAdminPaymentHistory();
            faph.Show();
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
