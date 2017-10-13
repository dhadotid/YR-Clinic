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
    public partial class FAdminDrugs : Form
    {
        DBConnection con = new DBConnection();
        string date = DateTime.Now.AddDays(+5).ToString("yyyy-MM-dd");
        public FAdminDrugs()
        {
            InitializeComponent();
            isicombobox();
            txtIdDrug.Text = autoid();
            isidgvdrug();
            dtp_ExpDate.Format = DateTimePickerFormat.Custom;
            dtp_ExpDate.CustomFormat = "yyyy-MM-dd";
            dtp_ExpDate.Value = DateTime.Now.AddYears(+2);
        }
        public void isicombobox()
        {
            cbDrugType.Items.Clear();
            cbDrugType.Items.Add("Capsule");
            cbDrugType.Items.Add("Tablet");
            cbDrugType.Items.Add("Syrup");
            cbDrugType.Items.Add("Cream");
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
                    string query = "select top 1 Id_Drug from Recipe.Drug order by Id_Drug desc;";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Id_Drug"].ToString();
                        if (dr.HasRows)
                        {
                            int number = Convert.ToInt32(input.Substring(3, 5));
                            number += 1;
                            if (number < 10)
                            {
                                newcode = "DRG0000" + number;
                            }
                            else if (number >= 10 && number < 100)
                            {
                                newcode = "DRG000" + number;
                            }
                            else if (number >= 100 && number < 1000)
                            {
                                newcode = "DRG00" + number;
                            }
                            else if (number >= 1000 && number < 10000)
                            {
                                newcode = "DRG0" + number;
                            }
                            else if (number >= 10000 && number < 100000)
                            {
                                newcode = "DRG" + number;
                            }
                            else
                            {
                                newcode = "full";
                            }
                        }
                        else
                        {
                            newcode = "DRG00001";
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

        private void txtDrugName_Validating(object sender, CancelEventArgs e)
        {
            if(txtDrugName.Text == "")
            {
                txtDrugName.Focus();
                lblNullName.Visible = true;
            }
            else
            {
                lblNullName.Visible = false;
            }
        }

        private void cbDrugType_Validating(object sender, CancelEventArgs e)
        {
            if (cbDrugType.SelectedIndex == -1)
            {
                cbDrugType.Focus();
                lblNullType.Visible = true;
            }
            else
            {
                lblNullType.Visible = false;
            }
        }

        private void txtStock_Validating(object sender, CancelEventArgs e)
        {
            if (txtStock.Text == "" || Regex.IsMatch(txtStock.Text, @"^\d+$") == false)
            {
                txtStock.Focus();
                lblStock.Visible = true;
            }
            else
            {
                lblStock.Visible = false;
            }
        }
        
        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrice.Text == "" || Regex.IsMatch(txtPrice.Text, @"^\d+$") == false || txtPrice.Text.Length < 2)
            {
                txtPrice.Focus();
                lblPrice.Visible = true;
            }
            else
            {
                lblPrice.Visible = false;
            }
        }

        private void dgvDrug_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdDrug.Text = dgvDrug.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDrugName.Text = dgvDrug.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbDrugType.Text = dgvDrug.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStock.Text = dgvDrug.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtp_ExpDate.Value = Convert.ToDateTime(dgvDrug.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtPrice.Text = dgvDrug.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dtp_ExpDate_Validating(object sender, CancelEventArgs e)
        {
            string exp = dtp_ExpDate.Value.ToString("yyyy-MM-dd");
            if (DateTime.Parse(exp) < DateTime.Parse(date))
            {
                dtp_ExpDate.Focus();
                lblNullDOB.Visible = true;
            }
            else
            {
                lblNullDOB.Visible = false;
            }
        }
        private int validateexp()
        {
            int flag = 0;
            string exp = dtp_ExpDate.Value.ToString("yyyy-MM-dd");
            if (DateTime.Parse(exp) < DateTime.Parse(date))
            {
                dtp_ExpDate.Focus();
                lblNullDOB.Visible = true;
                flag = 1;
            }
            else
            {
                lblNullDOB.Visible = false;
            }
            return flag;
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if(txtDrugName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else if(validateexp() != 0)
            {
                lblNullDOB.Visible = true;
                MessageBox.Show("Please insert expdate more than 5 day");
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to save record " + txtIdDrug.Text + " drug name " + txtDrugName.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string info = "";
                    string drugtype = cbDrugType.SelectedItem.ToString();
                    string expdate = dtp_ExpDate.Value.ToString("yyyy-MM-dd");
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "exec pcdDrug @drugname,@drugtype, @stock, @expdate, @price";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@drugname", txtDrugName.Text);
                            com.Parameters.AddWithValue("@drugtype", drugtype);
                            com.Parameters.AddWithValue("@stock", txtStock.Text);
                            com.Parameters.AddWithValue("@expdate", expdate);
                            com.Parameters.AddWithValue("@price", txtPrice.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Insert data");
                                cbDrugType.SelectedIndex = -1;
                                txtStock.Clear();
                                dtp_ExpDate.Value = DateTime.Now.AddYears(+2);
                                txtPrice.Clear();
                                txtIdDrug.Clear();
                                txtDrugName.Clear();
                                txtDrugName.Focus();

                                txtIdDrug.Text = autoid();
                                isidgvdrug();
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

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            if (txtDrugName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else if (validateexp() != 0)
            {
                lblNullDOB.Visible = true;
                MessageBox.Show("Please insert expdate more than 5 day");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do You Want To Update the Data ?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string info = "";
                    string drugtype = cbDrugType.SelectedItem.ToString();
                    string expdate = dtp_ExpDate.Value.ToString("yyyy-MM-dd");
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "update Recipe.Drug set DrugName = @drgname, DrugType = @drgtype, Stock = @stock, ExpDate = @exp, Price = @prc where Id_Drug = @iddrg";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@drgname", txtDrugName.Text);
                            com.Parameters.AddWithValue("@drgtype", drugtype);
                            com.Parameters.AddWithValue("@stock", txtStock.Text);
                            com.Parameters.AddWithValue("@exp", expdate);
                            com.Parameters.AddWithValue("@prc", txtPrice.Text);
                            com.Parameters.AddWithValue("@iddrg", txtIdDrug.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Update data");
                                cbDrugType.SelectedIndex = -1;
                                txtStock.Clear();
                                dtp_ExpDate.Value = DateTime.Now.AddYears(+2);
                                txtPrice.Clear();
                                txtIdDrug.Clear();
                                txtDrugName.Clear();
                                txtDrugName.Focus();

                                txtIdDrug.Text = autoid();
                                isidgvdrug();
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
            if (txtDrugName.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Please select the data");
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to delete data drug " + txtIdDrug.Text + " Drug Name: " + txtDrugName.Text + "?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "delete from Recipe.Drug where Id_Drug = @iddrg";
                            SqlCommand com = new SqlCommand(query, con.con);
                            com.Parameters.AddWithValue("@iddrg", txtIdDrug.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Delete data");
                                cbDrugType.SelectedIndex = -1;
                                txtStock.Clear();
                                dtp_ExpDate.Value = DateTime.Now.AddYears(+2);
                                txtPrice.Clear();
                                txtIdDrug.Clear();
                                txtDrugName.Clear();
                                txtDrugName.Focus();

                                txtIdDrug.Text = autoid();
                                isidgvdrug();
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
