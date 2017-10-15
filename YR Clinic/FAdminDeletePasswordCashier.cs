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
    public partial class FAdminDeletePasswordCashier : Form
    {
        DBConnection con = new DBConnection();
        public FAdminDeletePasswordCashier()
        {
            InitializeComponent();
            isidgvCashier();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminCashier fac = new FAdminCashier();
            fac.Show();
            this.Hide();
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

        private void dgvCashier_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvCashier.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCashier.SelectedRows[0].Index;

                string idcashier = dgvCashier[0, selectedIndex].Value.ToString();
                DialogResult dr = MessageBox.Show("Do you want to delete account cashier " + idcashier + "?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "delete from AccessLogin where Id_User = @iduser";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@iduser", idcashier);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Delete data");

                                foreach (DataGridViewRow row in dgvCashier.SelectedRows)
                                {
                                    dgvCashier.Rows.RemoveAt(row.Index);
                                }

                                isidgvCashier();
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
    }
}
