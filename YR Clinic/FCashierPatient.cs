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
    public partial class FCashierPatient : Form
    {
        DBConnection con = new DBConnection();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        DataSet dst = new DataSet();
        DataView dvp;
        public FCashierPatient()
        {
            InitializeComponent();
            dtp_DOB.Format = DateTimePickerFormat.Custom;
            dtp_DOB.CustomFormat = "yyyy-MM-dd";
            dtp_DOB.Value = DateTime.Today.AddYears(-5);
            txtIdPatient.Text = autoid();
            isidgvPatient();
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
                    string query = "select top 1 Id_Patient from Patient.Patient order by Id_Patient desc;";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Id_Patient"].ToString();
                        //string angka = input.Substring(1, 5);
                        if(dr != null)
                        {
                            int number = Convert.ToInt32(input.Substring(1, 5));
                            number += 1;
                            if (number < 10)
                            {
                                newcode = "P0000" + number;
                            }
                            else if (number >= 10 && number < 100)
                            {
                                newcode = "P000" + number;
                            }
                            else if (number >= 100 && number < 1000)
                            {
                                newcode = "P00" + number;
                            }
                            else if (number >= 1000 && number < 10000)
                            {
                                newcode = "P0" + number;
                            }
                            else if (number >= 10000 && number < 100000)
                            {
                                newcode = "P" + number;
                            }
                            else
                            {
                                newcode = "full";
                            }
                        }
                        else
                        {
                            newcode = "P00001";
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

        private void isidgvPatient()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if(info == "OK")
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

        private void pbBack_Click(object sender, EventArgs e)
        {
            FCashierMenu fcm = new FCashierMenu();
            fcm.Show();
            this.Hide();
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

        /*private void txtDOB_Validating(object sender, CancelEventArgs e)
        {
            if(txtDOB.Text == "" || Regex.IsMatch(txtDOB.Text, @"^\d{1,2}\/\d{1,2}\/\d{4}$") == false || DateTime.Parse(txtDOB.Text) > DateTime.Parse(date))
            {
                txtDOB.Focus();
                lblNullDOB.Visible = true;
            }
            else
            {
                lblNullDOB.Visible = false;
            }
        }*/

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhoneNumber.Text == "" || Regex.IsMatch(txtPhoneNumber.Text, @"^62[0-9]{9,11}$") == false)
            {
                txtPhoneNumber.Focus();
                lblPhoneNumber.Visible = true;
            }
            else
            {
                lblPhoneNumber.Visible = false;
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

        private void FCashierPatient_Load(object sender, EventArgs e)
        {
            //autoid();
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if(txtIdPatient.Text == "full")
            {
                MessageBox.Show("Data already meets maximum limit");
            }
            else
            {
                if(txtIdPatient.Text == "" && txtAddress.Text == "")
                {
                    MessageBox.Show("Please fill in the data");
                }
                else if(validategender() != 0)
                {
                    MessageBox.Show("Please select gender");
                }
                else if(validatedob() != 0)
                {
                    MessageBox.Show("Please insert date of birth correctly");
                }
                else
                {
                    string gender = "";
                    string datedob = dtp_DOB.Value.ToString("yyyy-MM-dd");
                    if (rbMale.Checked)
                    {
                        gender = rbMale.Text;
                    }
                    else if (rbFemale.Checked)
                    {
                        gender = rbFemale.Text;
                    }
                    DialogResult result = MessageBox.Show("Do you want to save record " + txtIdPatient.Text + " with name " + txtName.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        string info = "";
                        try
                        {
                            info = con.openconnection();
                            if (info == "OK")
                            {
                                string query = "exec pcdPatient @nama,@tanggallahir,@alamat,@jeniskelamin";
                                SqlCommand com = new SqlCommand(query, con.con);
                                com.Parameters.AddWithValue("@nama", txtName.Text);
                                com.Parameters.AddWithValue("@tanggallahir", datedob);
                                com.Parameters.AddWithValue("@alamat", txtAddress.Text);
                                com.Parameters.AddWithValue("@jeniskelamin", gender);
                                if (com.ExecuteNonQuery() > 0)
                                {
                                    info = "OK";
                                    MessageBox.Show("Success Insert data");
                                    txtIdPatient.Text = autoid();
                                    txtName.Clear();
                                    dtp_DOB.Value = DateTime.Today.AddYears(-5);
                                    txtPhoneNumber.Clear();
                                    rbFemale.Checked = false;
                                    rbMale.Checked = false;
                                    txtAddress.Clear();
                                    isidgvPatient();
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

        private void dtp_DOB_Validating(object sender, CancelEventArgs e)
        {
            string datedob = dtp_DOB.Value.ToString("yyyy-MM-dd");
            if (DateTime.Parse(datedob) > DateTime.Parse(date))
            {
                dtp_DOB.Focus();
                lblNullDOB.Visible = true;
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
