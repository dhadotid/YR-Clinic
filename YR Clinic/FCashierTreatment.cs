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
    public partial class FCashierTreatment : Form
    {
        DBConnection con = new DBConnection();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        public FCashierTreatment()
        {
            InitializeComponent();
            txtDateTreatment.Text = date;
            isidgvPatient();
            isidgvdoctor();
            txtIdTreatment.Text = autoid();
            txtRecipe.Text = autoidrecipe();
        }

        private void isidgvPatient()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select * from Patient.Patient";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader sr = com.ExecuteReader();
                    if (sr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sr);
                        dgvPatient.DataSource = dt;
                        dgvPatient.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
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

        private void isidgvdoctor()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select a.Id_Doctor, a.DoctorName, a.Phone, b.Specialist, b.Fare from Doctor.Doctor a join Doctor.Specialist b on a.Id_Specialist = b.Id_Specialist";
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

        public int validasi()
        {
            int flag = 0;
            if (txtIdDoctor.Text == "")
            {
                lblNullDoctor.Visible = true;
                flag = 1;
            }
            else if(txtIdPatient.Text == "")
            {
                lblNullPatient.Visible = true;
                flag = 1;
            }
            return flag;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FCashierMenu fcm = new FCashierMenu();
            fcm.Show();
            this.Hide();
        }

        private string autoid()
        {
            string info = "";
            string newcode = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select top 1 Id_Treatment from Patient.Treatment order by Id_Treatment desc;";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Id_Treatment"].ToString();
                        //string angka = input.Substring(1, 5);
                        if (dr != null)
                        {
                            int number = Convert.ToInt32(input.Substring(1, 5));
                            number += 1;
                            if (number < 10)
                            {
                                newcode = "T0000" + number;
                            }
                            else if (number >= 10 && number < 100)
                            {
                                newcode = "T000" + number;
                            }
                            else if (number >= 100 && number < 1000)
                            {
                                newcode = "T00" + number;
                            }
                            else if (number >= 1000 && number < 10000)
                            {
                                newcode = "T0" + number;
                            }
                            else if (number >= 10000 && number < 100000)
                            {
                                newcode = "T" + number;
                            }
                            else
                            {
                                newcode = "full";
                            }
                        }
                        else
                        {
                            newcode = "T00001";
                        }
                    }
                    dr.Close();
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
            return newcode;
        }

        private string autoidrecipe()
        {
            string info = "";
            string newcode = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select top 1 Id_Recipe from Recipe.Recipe order by Id_Recipe desc;";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Id_Recipe"].ToString();
                        //string angka = input.Substring(1, 5);
                        if (dr != null)
                        {
                            int number = Convert.ToInt32(input.Substring(1, 5));
                            number += 1;
                            if (number < 10)
                            {
                                newcode = "R0000" + number;
                            }
                            else if (number >= 10 && number < 100)
                            {
                                newcode = "R000" + number;
                            }
                            else if (number >= 100 && number < 1000)
                            {
                                newcode = "R00" + number;
                            }
                            else if (number >= 1000 && number < 10000)
                            {
                                newcode = "R0" + number;
                            }
                            else if (number >= 10000 && number < 100000)
                            {
                                newcode = "R" + number;
                            }
                            else
                            {
                                newcode = "full";
                            }
                        }
                        else
                        {
                            newcode = "R00001";
                        }
                    }
                    dr.Close();
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
            return newcode;
        }

        private void txtDiagnose_Validating(object sender, CancelEventArgs e)
        {
            if(txtDiagnose.Text == "")
            {
                txtDiagnose.Focus();
                lblNullDiagnose.Visible = true;
            }
            else
            {
                lblNullDiagnose.Visible = false;
            }
        }

        private void FCashierTreatment_Load(object sender, EventArgs e)
        {
            txtDateTreatment.Text = date;
        }

        private void dgvPatient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdPatient.Text = dgvPatient.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvDoctor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdDoctor.Text = dgvDoctor.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txtSearchPatient_KeyUp(object sender, KeyEventArgs e)
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select * from Patient.Patient where Patient_Name like '" + txtSearchPatient.Text + "%'";
                    //SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con.con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPatient.DataSource = dt;
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

        private void txtSearchDoctor_KeyUp(object sender, KeyEventArgs e)
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select * from Doctor.Doctor where DoctorName like '" + txtSearchDoctor.Text + "%'";
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

        private void pbSave_Click(object sender, EventArgs e)
        {
            if(validasi() != 0)
            {
                MessageBox.Show("Please fill in the data correctly");
            }
            else if(txtDiagnose.Text == "")
            {
                MessageBox.Show("Please fill in the data correctly");
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to save record " + txtIdPatient.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "exec pcdTreatment @patient,@doctor,@diagnose";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@patient", txtIdPatient.Text);
                            com.Parameters.AddWithValue("@doctor", txtIdDoctor.Text);
                            com.Parameters.AddWithValue("@diagnose", txtDiagnose.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Insert data");
                                txtIdTreatment.Text = autoid();
                                txtRecipe.Text = autoidrecipe();
                                txtIdDoctor.Clear();
                                txtIdPatient.Clear();
                                txtDiagnose.Clear();
                                txtDateTreatment.Text = date;
                                isidgvPatient();
                                isidgvdoctor();
                            }
                            else
                            {
                                info = "Gagal";
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
            }
        }
    }
}
