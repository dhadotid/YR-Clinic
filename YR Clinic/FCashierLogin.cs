﻿using System;
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

namespace YR_Clinic
{
    public partial class FCashierLogin : Form
    {
        int counter;
        DBConnection con = new DBConnection();
        public FCashierLogin()
        {
            InitializeComponent();
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            int result = 0;
            string info = "";
            string username, password;
            username = txtUser.Text;
            password = txtPass.Text;
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select count(*) from AccessLogin where Username = @Username and UPassword = @UPassword and isAdmin = '0'";
                    SqlCommand com = new SqlCommand(query, con.con);
                    com.Parameters.AddWithValue("@Username", username);
                    com.Parameters.AddWithValue("@UPassword", password);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        result = Convert.ToInt32(dr[0]);
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
            if (result > 0)
            {
                MessageBox.Show("Welcome, " + username + ". Have a nice day :)", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FCashierMenu fcm = new FCashierMenu();
                fcm.Show();
                this.Hide();
                counter = 0;
            }
            else
            {
                counter += 1;
                if (counter < 3)
                {
                    lblError.Visible = true;
                    txtUser.Focus();
                    txtUser.Clear();
                    txtPass.Clear();
                }
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FMenu fm = new FMenu();
            fm.Show();
            this.Hide();
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if(txtUser.Text == "")
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
            if(txtPass.Text == "")
            {
                txtPass.Focus();
                lblNullPass.Visible = true;
            }
            else
            {
                lblNullPass.Visible = false;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbLogin_Click(this, new EventArgs());
        }
    }
}
