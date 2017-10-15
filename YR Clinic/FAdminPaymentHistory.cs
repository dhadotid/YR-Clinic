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
    public partial class FAdminPaymentHistory : Form
    {
        DBConnection con = new DBConnection();
        public FAdminPaymentHistory()
        {
            InitializeComponent();
            isidgvPay();
            txtSearch.Focus();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminSearch fas = new FAdminSearch();
            fas.Show();
            this.Hide();
        }

        private void isidgvPay()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select b.Id_Treatment,a.Patient_Name, x.DoctorName ,b.Diagnose,b.DateTreatment,c.PaymentDoctor,c.PaymentDrug,c.TotalPayment from Patient.Patient a join Patient.Treatment b on a.Id_Patient = b.Id_Patient join Patient.Payment c on c.Id_Treatment = b.Id_Treatment join Doctor.Doctor x on b.Id_Doctor = x.Id_Doctor";
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

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select b.Id_Treatment,a.Patient_Name, x.DoctorName ,b.Diagnose,b.DateTreatment,c.PaymentDoctor,c.PaymentDrug,c.TotalPayment from Patient.Patient a join Patient.Treatment b on a.Id_Patient = b.Id_Patient join Patient.Payment c on c.Id_Treatment = b.Id_Treatment join Doctor.Doctor x on b.Id_Doctor = x.Id_Doctor where Patient_Name like '" + txtSearch.Text + "%'";
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
    }
}
