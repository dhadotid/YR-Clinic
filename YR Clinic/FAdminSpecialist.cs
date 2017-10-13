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
    public partial class FAdminSpecialist : Form
    {
        DBConnection con = new DBConnection();
        public FAdminSpecialist()
        {
            InitializeComponent();
            //txtIdSpecialist.Text = autoid();
            txtIdSpecialist.Text =  autoid();
            isidgvSpecialist();
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
                    string query = "select top 1 Id_Specialist from Doctor.Specialist order by Id_Specialist desc;";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Id_Specialist"].ToString();
                        if (input.Length > 0)
                        {
                            int number = Convert.ToInt32(input.Substring(3, 3));
                            number += 1;
                            if (number < 10)
                            {
                                newcode = "SPC00" + number;
                            }
                            else if (number >= 10 && number < 100)
                            {
                                newcode = "SPC0" + number;
                            }
                            else if (number >= 100 && number < 1000)
                            {
                                newcode = "SPC" + number;
                            }
                            else
                            {
                                newcode = "full";
                            }
                        }
                        else
                        {
                            newcode = "SPC001";
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

        private void txtSpecialist_Validating(object sender, CancelEventArgs e)
        {
            if(txtSpecialist.Text == "")
            {
                txtSpecialist.Focus();
                lblNullName.Visible = true;
            }
            else
            {
                lblNullName.Visible = false;
            }
        }

        private void txtFare_Validating(object sender, CancelEventArgs e)
        {
            if (txtFare.Text == "" || Regex.IsMatch(txtFare.Text, @"^\d+$") == false || txtFare.Text.Length < 5)
            {
                txtFare.Focus();
                lblNullFare.Visible = true;
            }
            else
            {
                lblNullFare.Visible = false;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbSearch_Click(this, new EventArgs());
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {

        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if(txtSpecialist.Text == "" || txtFare.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else
            {
                string info = "";
                bool test = true;
                try
                {
                    info = con.openconnection();
                    if (info == "OK")
                    {
                        string query = "select count(Specialist) as Specialist from Doctor.Specialist where Specialist = '" + txtSpecialist.Text + "'";
                        SqlCommand com = new SqlCommand(query, con.con);
                        SqlDataReader dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            //string idpay = dr["Id_Payment"].ToString();
                            string specialist = dr["Specialist"].ToString();
                            if(specialist == "0")
                            {
                                DialogResult result = MessageBox.Show("Do you want to save record " + txtIdSpecialist.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    test = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Specialist already available");
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
                if (test == false)
                    insertdata();
            }
        }

        private void insertdata()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "exec pcdSpecialist @specialist,@fare";
                    SqlCommand com = new SqlCommand(query, con.con);
                    com.Parameters.AddWithValue("@specialist", txtSpecialist.Text);
                    com.Parameters.AddWithValue("@fare", txtFare.Text);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        info = "OK";
                        MessageBox.Show("Success Insert data");
                        txtIdSpecialist.Text = autoid();
                        txtSpecialist.Clear();
                        txtFare.Clear();
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

        private void dgvSpecialist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdSpecialist.Text = dgvSpecialist.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSpecialist.Text = dgvSpecialist.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFare.Text = dgvSpecialist.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select * from Doctor.Specialist where Specialist like '" + txtSearch.Text + "%'";
                    //SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con.con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSpecialist.DataSource = dt;
                }
                if (con.closeconnection() == "OK")
                    info = "OK";
            }
            catch (Exception xe)
            {
                MessageBox.Show(xe.Message);
            }
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            if (txtSpecialist.Text == "" || txtFare.Text == "")
                MessageBox.Show("Please fill in the data");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do You Want To Update the Data ?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "update Doctor.Specialist set Specialist = @specialist, Fare = @fare where Id_Specialist = @idspecialist";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@specialist", txtSpecialist.Text);
                            com.Parameters.AddWithValue("@fare", txtFare.Text);
                            com.Parameters.AddWithValue("@idspecialist", txtIdSpecialist.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Update data");
                                txtIdSpecialist.Text = autoid();
                                txtSpecialist.Clear();
                                txtFare.Clear();
                                isidgvSpecialist();
                                txtIdSpecialist.Text = autoid();
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
            if (txtSpecialist.Text == "" || txtFare.Text == "")
                MessageBox.Show("Please select the data");
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to delete specialist " + txtIdSpecialist.Text + " " + txtSpecialist.Text + "?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "delete from Doctor.Specialist where Id_Specialist = @idspecialist";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@idspecialist", txtIdSpecialist.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Delete data");
                                txtIdSpecialist.Text = autoid();
                                txtSpecialist.Clear();
                                txtFare.Clear();
                                isidgvSpecialist();
                                txtIdSpecialist.Text = autoid();
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
