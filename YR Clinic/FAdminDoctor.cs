using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YR_Clinic.config;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Globalization;

namespace YR_Clinic
{
    public partial class FAdminDoctor : Form
    {
        DBConnection con = new DBConnection();
        string date = DateTime.Now.AddYears(-20).ToString("yyyy-MM-dd");
        public FAdminDoctor()
        {
            InitializeComponent();
            dtp_DOB.Format = DateTimePickerFormat.Custom;
            dtp_DOB.CustomFormat = "yyyy-MM-dd";
            dtp_DOB.Value = DateTime.Now.AddYears(-20);
            txtIdDoctor.Text = autoid();
            isidgvDoctor();
            isidgvSpecialist();
        }

        private void isidgvDoctor()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select * from Doctor.Doctor";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader sr = com.ExecuteReader();
                    if (sr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sr);
                        dgvDoctor.DataSource = dt;
                        dgvDoctor.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
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

        private void isidgvSpecialist()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select * from Doctor.Specialist";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader sr = com.ExecuteReader();
                    if (sr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sr);
                        dgvSpecialist.DataSource = dt;
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

        private string autoid()
        {
            string info = "";
            string newcode = "";
            //string str = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select top 1 Id_Doctor from Doctor.Doctor order by Id_Doctor desc;";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Id_Doctor"].ToString();
                        if (dr.HasRows)
                        {
                            int number = Convert.ToInt32(input.Substring(3, 3));
                            number += 1;
                            if (number < 10)
                            {
                                newcode = "D0000" + number;
                            }
                            else if (number >= 10 && number < 100)
                            {
                                newcode = "D000" + number;
                            }
                            else if (number >= 100 && number < 1000)
                            {
                                newcode = "D00" + number;
                            }
                            else if(number >= 1000 && number < 10000)
                            {
                                newcode = "D0" + number;
                            }
                            else if(number >= 10000 && number < 100000)
                            {
                                newcode = "D" + number;
                            }
                            else
                            {
                                newcode = "full";
                            }
                        }
                        else
                        {
                            newcode = "D00001";
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

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminMenu fam = new FAdminMenu();
            fam.Show();
            this.Hide();
        }

        private void txtDoctorName_Validating(object sender, CancelEventArgs e)
        {
            if(txtDoctorName.Text == "")
            {
                txtDoctorName.Focus();
                lblNullName.Visible = true;
            }
            else
            {
                lblNullName.Visible = false;
            }
        }

        private void dtp_DOB_Validating(object sender, CancelEventArgs e)
        {
            string datedob = dtp_DOB.Value.ToString("yyyy-MM-dd");
            if(DateTime.Parse(datedob) > DateTime.Parse(date))
            {
                dtp_DOB.Focus();
                lblNullDOB.Visible = true;
            }
            else
            {
                lblNullDOB.Visible = false;
            }
        }

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

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
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
            else
            {
                lblNullGender.Visible = false;
            }
            return flag;
        }
        private int validaedob()
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
            else
            {
                lblNullDOB.Visible = false;
            }
            return flag;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if(txtIdDoctor.Text == "full")
            {
                MessageBox.Show("Data already meets maximum limit", "Can not store data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FAdminMenu fam = new FAdminMenu();
                fam.Show();
                this.Hide();
            }
            else
            {
                if (txtDoctorName.Text == "" || txtPhoneNumber.Text == "" || txtIdSpecialist.Text == "")
                {
                    MessageBox.Show("Please fill in the data");
                }
                else if (validategender() != 0)
                {
                    MessageBox.Show("Please select gender");
                }
                else if (validaedob() != 0)
                {
                    MessageBox.Show("Please select date of birth more than 20 years");
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
                    DialogResult result = MessageBox.Show("Do you want to save record " + txtIdDoctor.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string info = "";
                        try
                        {
                            info = con.openconnection();
                            if (info == "OK")
                            {
                                string query = "exec pcdDoctor @idspecialist,@doctorname,@doctorgender,@dob,@phone";
                                SqlCommand com = new SqlCommand(query, con.con);
                                com.Parameters.AddWithValue("@idspecialist", txtIdSpecialist.Text);
                                com.Parameters.AddWithValue("@doctorname", txtDoctorName.Text);
                                com.Parameters.AddWithValue("@doctorgender", gender);
                                com.Parameters.AddWithValue("@dob", datedob);
                                com.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
                                if (com.ExecuteNonQuery() > 0)
                                {
                                    info = "OK";
                                    MessageBox.Show("Data saved");
                                    txtIdDoctor.Text = autoid();
                                    txtDoctorName.Clear();
                                    txtIdSpecialist.Clear();
                                    dtp_DOB.Value = DateTime.Today.AddYears(-5);
                                    txtPhoneNumber.Clear();
                                    rbFemale.Checked = false;
                                    rbMale.Checked = false;
                                    //txtAddress.Clear();
                                    isidgvDoctor();
                                    isidgvSpecialist();
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

        private void txtIdDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdSpecialist_Validating(object sender, CancelEventArgs e)
        {
            if (txtIdSpecialist.Text == "")
            {
                lblNullIdSpecialist.Visible = true;
            }
            else
            {
                lblNullIdSpecialist.Visible = false;
            }
        }

        private void dgvSpecialist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdSpecialist.Text = dgvSpecialist.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvDoctor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdDoctor.Text = dgvDoctor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIdSpecialist.Text = dgvDoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDoctorName.Text = dgvDoctor.Rows[e.RowIndex].Cells[2].Value.ToString();
            //string gender = dgvDoctor.Rows[e.RowIndex].Cells[3].Value.ToString();
            if ("Male".Equals(dgvDoctor.Rows[e.RowIndex].Cells[3].Value.ToString()))
            {
                rbMale.Checked = true;
            }
            else if ("Female".Equals(dgvDoctor.Rows[e.RowIndex].Cells[3].Value.ToString()))
            {
                //MessageBox.Show(gender);
                rbFemale.Checked = true;
            }
            dtp_DOB.Value = Convert.ToDateTime(dgvDoctor.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtPhoneNumber.Text = dgvDoctor.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text == "" || validategender() != 0 || validaedob() != 0 || Regex.IsMatch(txtPhoneNumber.Text, @"^62[0-9]{9,11}$") == false)
                MessageBox.Show("Please fill in the data");
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
                            string query = "update Doctor.Doctor set Id_Specialist = @specialist, DoctorName = @dname, DoctorGender = @dgen, DateOfBirth = @dob, Phone = @phone where Id_Doctor = @iddoc";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@specialist", txtIdSpecialist.Text);
                            com.Parameters.AddWithValue("@dname", txtDoctorName.Text);
                            com.Parameters.AddWithValue("@dgen", gender);
                            com.Parameters.AddWithValue("@dob", datedob);
                            com.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
                            com.Parameters.AddWithValue("@iddoc", txtIdDoctor.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Update data");
                                txtIdDoctor.Text = autoid();
                                txtDoctorName.Clear();
                                txtIdSpecialist.Clear();
                                dtp_DOB.Value = DateTime.Today.AddYears(-5);
                                txtPhoneNumber.Clear();
                                rbFemale.Checked = false;
                                rbMale.Checked = false;
                                //txtAddress.Clear();
                                isidgvDoctor();
                                isidgvSpecialist();
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

        private void txtSearchSpecialist_KeyUp(object sender, KeyEventArgs e)
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select * from Doctor.Specialist where Specialist like '" + txtSearchSpecialist.Text + "%'";
                    //SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con.con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSpecialist.DataSource = dt;
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

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text == "" || validaedob() != 0 || validaedob() != 0 || Regex.IsMatch(txtPhoneNumber.Text, @"^62[0-9]{9,11}$") == false)
                MessageBox.Show("Please select the data");
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to delete data doctor " + txtIdDoctor.Text + " Doctor Name: " + txtDoctorName.Text + "?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "delete from Doctor.Doctor where Id_Doctor = @iddoc";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@iddoc", txtIdDoctor.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Delete data");
                                txtIdDoctor.Text = autoid();
                                txtDoctorName.Clear();
                                txtIdSpecialist.Clear();
                                dtp_DOB.Value = DateTime.Today.AddYears(-5);
                                txtPhoneNumber.Clear();
                                rbFemale.Checked = false;
                                rbMale.Checked = false;
                                //txtAddress.Clear();
                                isidgvDoctor();
                                isidgvSpecialist();
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
    }
}
