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
    public partial class FAdminChangePasswordCashier : Form
    {
        DBConnection con = new DBConnection();
        public FAdminChangePasswordCashier()
        {
            InitializeComponent();
            isidgvCashier();
        }

        private void isidgvCashier()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select Id_User, Username, UPassword from AccessLogin where isAdmin = '0'";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader sr = com.ExecuteReader();
                    if (sr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sr);
                        dgvCashier.DataSource = dt;
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
            FAdminCashier fac =  new FAdminCashier();
            fac.Show();
            this.Hide();
        }

        private void txtOldPass_Validating(object sender, CancelEventArgs e)
        {
            if(txtOldPass.Text == "")
            {
                txtOldPass.Focus();
                lblOldPass.Visible = true;
            }
            else
            {
                lblOldPass.Visible = false;
            }
        }

        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            if(txtNewPass.Text == "" || Regex.IsMatch(txtUser.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                txtNewPass.Focus();
                lblNewPass.Visible = true;
            }
            else
            {
                lblNewPass.Visible = false;
            }
        }

        private void txtCoNewPass_Validating(object sender, CancelEventArgs e)
        {
            if(txtCoNewPass.Text == "" || Regex.IsMatch(txtUser.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                txtCoNewPass.Focus();
                lblNullNewCoPas.Visible = true;
            }
            else
            {
                lblNullNewCoPas.Visible = false;
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if(txtCoNewPass.Text != txtNewPass.Text)
            {
                MessageBox.Show("New password and repassword not match");
            }
            else if(txtCoNewPass.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else if(txtIdCashier.Text == "")
            {
                MessageBox.Show("Please select the data");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to save the new data?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "update AccessLogin set Username = @username, UPassword = @Upassword where Id_User = @iduser";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@username", txtUser.Text);
                            com.Parameters.AddWithValue("@Upassword", txtNewPass.Text);
                            com.Parameters.AddWithValue("@iduser", txtIdCashier.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Update data");
                                txtUser.Clear();
                                txtOldPass.Clear();
                                txtNewPass.Clear();
                                txtCoNewPass.Clear();
                                txtIdCashier.Clear();
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
                    string query = "select Id_User, Username, UPassword from AccessLogin where Username like '" + txtSearch.Text + "%' and isAdmin = '0'";
                    //SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con.con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCashier.DataSource = dt;
                }
                if (con.closeconnection() == "OK")
                    info = "OK";
            }
            catch (Exception xe)
            {
                MessageBox.Show(xe.Message);
            }
        }

        private void dgvCashier_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdCashier.Text = dgvCashier.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUser.Text = dgvCashier.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOldPass.Text = dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
