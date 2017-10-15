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
    public partial class FAdminSearchRecipe : Form
    {
        DBConnection con = new DBConnection();
        public FAdminSearchRecipe()
        {
            InitializeComponent();
            isidgvRecipe();
            txtSearch.Focus();
        }

/*        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminSearch fas = new FAdminSearch();
            fas.Show();
            this.Hide();
        }
        */
        private void pbBack_Click_1(object sender, EventArgs e)
        {
            FAdminSearch fas = new FAdminSearch();
            fas.Show();
            this.Hide();
        }
        private void isidgvRecipe()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select a.Id_Recipe, e.Patient_Name, c.DrugName, c.DrugType, d.Diagnose from Recipe.Recipe a join Recipe.RecipeDetail b on b.Id_Recipe = a.Id_Recipe join Recipe.Drug c on b.Id_Drug = c.Id_Drug join Patient.Treatment d on d.Id_Recipe = a.Id_Recipe join Patient.Patient e on e.Id_Patient = d.Id_Patient";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader sr = com.ExecuteReader();
                    if (sr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sr);
                        dgvRecipe.DataSource = dt;
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
                    string query = "select a.Id_Recipe, e.Patient_Name, c.DrugName, c.DrugType, d.Diagnose from Recipe.Recipe a join Recipe.RecipeDetail b on b.Id_Recipe = a.Id_Recipe join Recipe.Drug c on b.Id_Drug = c.Id_Drug join Patient.Treatment d on d.Id_Recipe = a.Id_Recipe join Patient.Patient e on e.Id_Patient = d.Id_Patient where Patient_Name like '" + txtSearch.Text + "%'";
                    //SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con.con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRecipe.DataSource = dt;
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
