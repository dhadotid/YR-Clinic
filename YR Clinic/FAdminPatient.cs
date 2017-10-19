using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YR_Clinic.config;

namespace YR_Clinic
{
    public partial class FAdminPatient : Form
    {
        DBConnection con = new DBConnection();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        public FAdminPatient()
        {
            InitializeComponent();
            dtp_DOB.Format = DateTimePickerFormat.Custom;
            dtp_DOB.CustomFormat = "yyyy-MM-dd";
            dtp_DOB.Value = DateTime.Today.AddYears(-5);
            isidgvPatient();
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

        private int validategender()
        {
            int flag = 0;
            string gender = "";
            if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            else if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }
            if (gender == "")
            {
                lblNullGender.Visible = true;
                flag = 1;
            }
            return flag;
        }
        private int validatedob()
        {
            int flag = 0;
            string datedob = dtp_DOB.Value.ToString("yyyy-MM-dd");
            if (DateTime.Parse(datedob) > DateTime.Parse(date))
            {
                dtp_DOB.Focus();
                lblNullDOB.Visible = true;
                //MessageBox.Show("Please fill in the data");
                flag = 1;
            }
            return flag;
        }

        private void dtp_DOB_Validating(object sender, CancelEventArgs e)
        {
            string datedob = dtp_DOB.Value.ToString("yyyy-MM-dd");
            if (DateTime.Parse(datedob) > DateTime.Parse(date))
            {
                dtp_DOB.Focus();
                lblNullDOB.Visible = true;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if(txtName.Text == "")
            {
                txtName.Focus();
                lblNullName.Visible = true;
            }
            else
            {
                lblNullName.Visible = false;
            }
        }
        
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Focus();
                lblNullAddress.Visible = true;
            }
            else
            {
                lblNullAddress.Visible = false;
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminMenu fam = new FAdminMenu();
            fam.Show();
            this.Hide();
        }

        private void dgvPatient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdPatient.Text = dgvPatient.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvPatient.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtp_DOB.Value = Convert.ToDateTime(dgvPatient.Rows[e.RowIndex].Cells[2].Value.ToString());
            //txtPhoneNumber.Text = dgvPatient.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvPatient.Rows[e.RowIndex].Cells[3].Value.ToString();
            //string gender = dgvDoctor.Rows[e.RowIndex].Cells[3].Value.ToString();
            if ("Male".Equals(dgvPatient.Rows[e.RowIndex].Cells[4].Value.ToString()))
            {
                rbMale.Checked = true;
            }
            else if ("Female".Equals(dgvPatient.Rows[e.RowIndex].Cells[4].Value.ToString()))
            {
                //MessageBox.Show(gender);
                rbFemale.Checked = true;
            }
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            if(validategender() != 0)
            {
                MessageBox.Show("Please select the gender");
                lblNullGender.Visible = true;
            }
            else if(validatedob() != 0)
            {
                MessageBox.Show("Please fill date of birth correctly");
            }
            else if(txtIdPatient.Text == "")
            {
                MessageBox.Show("Please select the data");
            }
            else
            {
                string datedob = dtp_DOB.Value.ToString("yyyy-MM-dd");
                string gender = "";
                if (rbMale.Checked)
                {
                    gender = rbMale.Text;
                }
                else if (rbFemale.Checked)
                {
                    gender = rbFemale.Text;
                }
                DialogResult dialogResult = MessageBox.Show("Do You Want To Update the Data ?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "update Patient.Patient set Patient_Name = @name, DateOfBirth = @dob, Address = @address, GenderPatient = @gender where Id_Patient = @idpatient";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@name", txtName.Text);
                            com.Parameters.AddWithValue("@dob", datedob);
                            com.Parameters.AddWithValue("@address", txtAddress.Text);
                            com.Parameters.AddWithValue("@gender", gender);
                            com.Parameters.AddWithValue("@idpatient", txtIdPatient.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Update data");
                                txtIdPatient.Clear();
                                txtAddress.Clear();
                                dtp_DOB.Value = DateTime.Today.AddYears(-5);
                                txtName.Clear();
                                rbFemale.Checked = false;
                                rbMale.Checked = false;
                                isidgvPatient();
                            }
                            else
                            {
                                info = "Gagal";
                            }
                        }
                        if (con.closeconnection() == "OK")
                            info = "OK";
                    }
                    catch (Exception xe)
                    {
                        MessageBox.Show(xe.Message);
                    }
                }
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if(txtIdPatient.Text == "")
            {
                MessageBox.Show("Please select the data");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to delete data patient " + txtIdPatient.Text + " Patient Name: " + txtName.Text + "?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "delete from Patient.Patient where Id_Patient = @idpatient";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@idpatient", txtIdPatient.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Delete data");
                                txtIdPatient.Clear();
                                txtAddress.Clear();
                                dtp_DOB.Value = DateTime.Today.AddYears(-5);
                                txtName.Clear();
                                rbFemale.Checked = false;
                                rbMale.Checked = false;


                                isidgvPatient();
                            }
                            else
                            {
                                info = "Gagal";
                            }
                        }
                        if (con.closeconnection() == "OK")
                            info = "OK";
                    }
                    catch (Exception xe)
                    {
                        MessageBox.Show(xe.Message);
                    }
                }
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
                    string query = "select * from Patient.Patient where Patient_Name like '" + txtSearch.Text + "%'";
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
    }
}
