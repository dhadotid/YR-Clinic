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
    public partial class FCashierRecipe : Form
    {
        DBConnection con = new DBConnection();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string harga, expdate, strqty;
        double harga1 = 0, sub = 0;
        public FCashierRecipe()
        {
            InitializeComponent();
            txtRD.Text = autoid();
            txtIdRecipe.Text = autoidrecipe();
            isidgvdrug();

            dt.Columns.Add("ID Drug");
            dt.Columns.Add("DrugName");
            dt.Columns.Add("Dose");
            dt.Columns.Add("Qty");
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
                    string query = "select top 1 Id_RecipeDetail from Recipe.RecipeDetail order by Id_RecipeDetail desc;";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Id_RecipeDetail"].ToString();
                        //string angka = input.Substring(1, 5);
                        if (dr != null)
                        {
                            int number = Convert.ToInt32(input.Substring(2, 5));
                            number += 1;
                            if (number < 10)
                            {
                                newcode = "RD0000" + number;
                            }
                            else if (number >= 10 && number < 100)
                            {
                                newcode = "RD000" + number;
                            }
                            else if (number >= 100 && number < 1000)
                            {
                                newcode = "RD00" + number;
                            }
                            else if (number >= 1000 && number < 10000)
                            {
                                newcode = "RD0" + number;
                            }
                            else if (number >= 10000 && number < 100000)
                            {
                                newcode = "RD" + number;
                            }
                            else
                            {
                                newcode = "full";
                            }
                        }
                        else
                        {
                            newcode = "RD00001";
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
                        newcode = input;
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

        private void isidgvdrug()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select * from Recipe.Drug";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader sr = com.ExecuteReader();
                    if (sr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sr);
                        dgvDrug.DataSource = dt;
                        dgvDrug.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
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

        private void txtDrug_Validating(object sender, CancelEventArgs e)
        {
            if(txtDrug.Text == "")
            {
                txtDrug.Focus();
                lblNullDrug.Visible = true;
            }
            else
            {
                lblNullDrug.Visible = false;
            }
        }

        private void txtDose_Validating(object sender, CancelEventArgs e)
        {
            if(txtDose.Text == "" || Regex.IsMatch(txtDose.Text, @"^[0-9]{1,1}[X,x][0-9]{1,1}$") == false)
            {
                txtDose.Focus();
                lblNullDose.Visible = true;
            }
            else
            {
                lblNullDose.Visible = false;
            }
        }

        private void txtQty_Validating(object sender, CancelEventArgs e)
        {
            if(txtQty.Text == "" || Regex.IsMatch(txtQty.Text, @"^\d+$") == false)
            {
                txtQty.Focus();
                lblQty.Visible = true;
            }
            else
            {
                lblQty.Visible = false;

                harga1 = Convert.ToDouble(harga);
                double qty = Convert.ToDouble(txtQty.Text);
                sub = qty * harga1;
                txtSubtotal.Text = Convert.ToString(sub);
            }
        }

        private int validasidrug()
        {
            int flag = 0;
            if(txtDrug.Text == "")
            {
                lblNullDrug.Visible = true;
                flag = 1;
            }
            return flag;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            if (dgvRecipe.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure the transaction has been completed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    insertdgvrecipe();
                    FCashierMenu fcm = new FCashierMenu();
                    fcm.Show();
                    this.Hide();
                }
            }
            else
            {
                FCashierMenu fcm = new FCashierMenu();
                fcm.Show();
                this.Hide();
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
                    string query = "select * from Recipe.Drug where DrugName like '" + txtSearch.Text + "%'";
                    //SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con.con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDrug.DataSource = dt;
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
        DataTable dt = new DataTable();
        DataRow dr;
        private void dgvRecipe_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dgvRecipe.SelectedRows)
            {
                dgvRecipe.Rows.RemoveAt(row.Index);
            }
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            if(txtDose.Text == "" || txtSubtotal.Text == "")
            {
                MessageBox.Show("Please fill the data");
            }
            else
            {
                if (txtRD.Text == "full")
                {
                    MessageBox.Show("Data already meets maximum limit", "Can not store data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FCashierMenu fcm = new FCashierMenu();
                    fcm.Show();
                    this.Hide();
                }
                else
                {
                    if(validasidrug() == 0)
                    {
                        if (Convert.ToInt32(strqty) < Convert.ToInt32(txtQty.Text))
                        {
                            //obat kurang
                            MessageBox.Show("less drug");
                        }
                        else if(expdate == date)
                        {
                            MessageBox.Show("Can not save record because drug has been expired");
                            txtDrug.Clear();
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Are your sure want to add data " + txtDrug.Text + "?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string drugname = "";
                                string info = "";
                                try
                                {
                                    info = con.openconnection();
                                    if (info == "OK")
                                    {
                                        string query = "select * from Recipe.Drug where Id_Drug ='" + txtDrug.Text + "'";
                                        SqlCommand com = new SqlCommand(query, con.con);
                                        SqlDataReader sdr = com.ExecuteReader();
                                        while (sdr.Read())
                                        {
                                            //string idpay = dr["Id_Payment"].ToString();
                                            drugname = sdr["DrugName"].ToString();

                                        }
                                        sdr.Close();
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
                                dr = dt.NewRow();
                                dr["ID Drug"] = txtDrug.Text;
                                dr["DrugName"] = drugname;
                                dr["Qty"] = txtQty.Text;
                                dr["Dose"] = txtDose.Text;
                                dt.Rows.Add(dr);
                                dgvRecipe.DataSource = dt;

                                txtIdRecipe.Text = autoidrecipe();
                                txtRD.Text = autoid();
                                txtDrug.Clear();
                                txtQty.Clear();
                                txtDose.Clear();
                                txtSubtotal.Clear();
                                isidgvdrug();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the data");
                    }
                }
            }
        }

        private void insertdgvrecipe()
        {
            if (dgvRecipe.Rows.Count > 0)
            {
                for (int i = 0; i < dgvRecipe.Rows.Count; i++)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "exec pcdRecipeDetail @idrecipe,@iddrug,@qty,@dose";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@idrecipe", txtIdRecipe.Text);
                            com.Parameters.AddWithValue("@iddrug", dgvRecipe.Rows[i].Cells["ID Drug"].Value);
                            com.Parameters.AddWithValue("@qty", dgvRecipe.Rows[i].Cells["Qty"].Value);
                            com.Parameters.AddWithValue("@dose", dgvRecipe.Rows[i].Cells["Dose"].Value);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                //MessageBox.Show("Success Insert data");
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

        private void dgvDrug_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDrug.Text = dgvDrug.Rows[e.RowIndex].Cells[0].Value.ToString();
            strqty = dgvDrug.Rows[e.RowIndex].Cells[3].Value.ToString();
            expdate = dgvDrug.Rows[e.RowIndex].Cells[4].Value.ToString();
            harga = dgvDrug.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (Convert.ToInt32(strqty) < 20)
            {
                MessageBox.Show("The remaining drug " + strqty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(strqty) < 0)
            {
                MessageBox.Show("drug stocks have been exhausted");
            }
        }
    }
}
