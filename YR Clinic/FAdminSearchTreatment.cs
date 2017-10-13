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
    public partial class FAdminSearchTreatment : Form
    {
        public FAdminSearchTreatment()
        {
            InitializeComponent();
        }


        

        private void pbBack_Click_1(object sender, EventArgs e)
        {
            FAdminSearch fas = new FAdminSearch();
            fas.Show();
            this.Hide();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblPayHis_Click(object sender, EventArgs e)
        {

        }
    }
}
