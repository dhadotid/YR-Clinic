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
    public partial class FCashierListDoctor : Form
    {
        DBConnection con = new DBConnection();
        public FCashierListDoctor()
        {
            InitializeComponent();
            isidgvDoctor();
            txtSearch.Focus();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FCashierMenu fc = new FCashierMenu();
            fc.Show();
            this.Hide();
        }
        private void isidgvDoctor()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select b.Id_Doctor,b.DoctorName,a.Specialist, b.Phone from Doctor.Specialist a right outer join Doctor.Doctor b on a.Id_Specialist = b.Id_Specialist";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader sr = com.ExecuteReader();
                    if (sr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sr);
                        dgvDoctor.DataSource = dt;
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
                    string query = "select b.Id_Doctor,b.DoctorName,a.Specialist, b.Phone from Doctor.Specialist a right outer join Doctor.Doctor b on a.Id_Specialist = b.Id_Specialist where DoctorName like '" + txtSearch.Text + "%'";
                    //SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con.con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDoctor.DataSource = dt;
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
