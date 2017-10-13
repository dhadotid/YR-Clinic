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
    public partial class FAdminMenu : Form
    {
        public FAdminMenu()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminLogin fal = new FAdminLogin();
            fal.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            FAdminLogin fal = new FAdminLogin();
            fal.Show();
            this.Hide();
        }

        private void pbDoctor_Click(object sender, EventArgs e)
        {
            FAdminDoctor fad = new FAdminDoctor();
            fad.Show();
            this.Hide();
        }

        private void lblDoctor_Click(object sender, EventArgs e)
        {
            FAdminDoctor fad = new FAdminDoctor();
            fad.Show();
            this.Hide();
        }

        private void lblSpecialist_Click(object sender, EventArgs e)
        {
            FAdminSpecialist fas = new FAdminSpecialist();
            fas.Show();
            this.Hide();
        }

        private void pbSpecialist_Click(object sender, EventArgs e)
        {
            FAdminSpecialist fas = new FAdminSpecialist();
            fas.Show();
            this.Hide();
        }

        private void pbDrugs_Click(object sender, EventArgs e)
        {
            FAdminDrugs fad = new FAdminDrugs();
            fad.Show();
            this.Hide();
        }

        private void lblDrugs_Click(object sender, EventArgs e)
        {
            FAdminDrugs fad = new FAdminDrugs();
            fad.Show();
            this.Hide();
        }

        private void pbPatient_Click(object sender, EventArgs e)
        {
            FAdminPatient fap = new FAdminPatient();
            fap.Show();
            this.Hide();
        }

        private void lblPatient_Click(object sender, EventArgs e)
        {
            FAdminPatient fap = new FAdminPatient();
            fap.Show();
            this.Hide();
        }

        private void pbCashier_Click(object sender, EventArgs e)
        {
            FAdminCashier fac = new FAdminCashier();
            fac.Show();
            this.Hide();
        }


        private void lblCashier_Click(object sender, EventArgs e)
        {
            FAdminCashier fac = new FAdminCashier();
            fac.Show();
            this.Hide(); 
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            FAdminSearch fas = new FAdminSearch();
            fas.Show();
            this.Hide();
        }
    }
}
