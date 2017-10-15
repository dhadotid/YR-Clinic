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
    public partial class FAdminAddAccountCashier : Form
    {
        DBConnection con = new DBConnection();
        public FAdminAddAccountCashier()
        {
            InitializeComponent();
            txtIdCashier.Text = autoid();
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (txtUser.Text == "" || Regex.IsMatch(txtUser.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                txtUser.Focus();
                lblNullUser.Visible = true;
            }
            else
            {
                lblNullUser.Visible = false;
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass.Text == "" || Regex.IsMatch(txtUser.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                txtPass.Focus();
                lblPass.Visible = true;
            }
            else
            {
                lblPass.Visible = false;
            }
        }

        private void txtCoPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtCoPass.Text == "" || txtCoPass.Text != txtPass.Text)
            {
                txtCoPass.Focus();
                lblCoPass.Visible = true;
            }
            else
            {
                lblCoPass.Visible = false;
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminCashier fac = new FAdminCashier();
            fac.Show();
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
                    string query = "select top 1 Id_User from AccessLogin order by Id_User desc;";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Id_User"].ToString();
                        if (input.Length > 0)
                        {
                            int number = Convert.ToInt32(input.Substring(3, 2));
                            number += 1;
                            if (number < 10)
                            {
                                newcode = "USR0" + number;
                            }
                            else if (number >= 10 && number < 100)
                            {
                                newcode = "USR" + number;
                            }
                            else
                            {
                                newcode = "full";
                            }
                        }
                        else
                        {
                            newcode = "USR01";
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

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if(txtIdCashier.Text == "full")
            {
                MessageBox.Show("data already full");
                FAdminCashier fac = new FAdminCashier();
                fac.Show();
                this.Hide();
            }
            else if(txtPass.Text == "" || txtCoPass.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else if(txtPass.Text != txtCoPass.Text)
            {
                MessageBox.Show("Password and repassword not match");
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
                        string query = "select count(Username) as Username from AccessLogin where Username = '" + txtUser.Text + "'";
                        SqlCommand com = new SqlCommand(query, con.con);
                        SqlDataReader dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            //string idpay = dr["Id_Payment"].ToString();
                            string username = dr["Username"].ToString();
                            if (username == "0")
                            {
                                DialogResult result = MessageBox.Show("Do you want to save record " + txtUser.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    test = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username already available");
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
                    string query = "exec pcdAL @username,@password,@isadmin";
                    SqlCommand com = new SqlCommand(query, con.con);
                    com.Parameters.AddWithValue("@username", txtUser.Text);
                    com.Parameters.AddWithValue("@password", txtPass.Text);
                    com.Parameters.AddWithValue("@isadmin", "0");
                    if (com.ExecuteNonQuery() > 0)
                    {
                        info = "OK";
                        MessageBox.Show("Success Insert data");
                        txtUser.Clear();
                        txtPass.Clear();
                        txtCoPass.Clear();
                        txtIdCashier.Text = autoid();
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
