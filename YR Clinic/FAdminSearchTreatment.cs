using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YR_Clinic.config;

namespace YR_Clinic
{
    public partial class FAdminSearchTreatment : Form
    {
        DBConnection con = new DBConnection();
        public FAdminSearchTreatment()
        {
            InitializeComponent();
            isidgvTreatment();
            txtSearch.Focus();
        }



        private void isidgvTreatment()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select a.Id_Treatment, b.Patient_Name, c.DoctorName, a.Diagnose, a.DateTreatment from Patient.Treatment a join Patient.Patient b on a.Id_Patient = b.Id_Patient join Doctor.Doctor c on a.Id_Doctor = c.Id_Doctor";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader sr = com.ExecuteReader();
                    if (sr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sr);
                        dgvPay.DataSource = dt;
                    }
                }
                if (con.closeconnection() == "OK")
                {
                    info = "OK";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select a.Id_Treatment, b.Patient_Name, c.DoctorName, a.Diagnose, a.DateTreatment from Patient.Treatment a join Patient.Patient b on a.Id_Patient = b.Id_Patient join Doctor.Doctor c on a.Id_Doctor = c.Id_Doctor where Patient_Name like '" + txtSearch.Text + "%'";
                    //SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con.con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPay.DataSource = dt;
                }
                if (con.closeconnection() == "OK")
                {
                    info = "OK";
                }
            }
            catch (Exception xe)
            {
                MessageBox.Show(xe.Message);
            }
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
