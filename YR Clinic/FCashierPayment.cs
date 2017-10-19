using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FCashierPayment : Form
    {
        DBConnection con = new DBConnection();
        string idrecipe;
        double kembalian;
        public FCashierPayment()
        {
            InitializeComponent();
            //txtIdPayment.Text = autoid();
            loadpatient();
            //getvalue();
            //loaddatarecipe();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FCashierMenu fcm = new FCashierMenu();
            fcm.Show();
            this.Hide();
        }

        private void loadpatient()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select a.Id_Treatment, b.Patient_Name, a.Diagnose from Patient.Treatment a join Patient.Patient b on a.Id_Patient = b.Id_Patient join Patient.Payment x on a.Id_Treatment = x.Id_Treatment where x.isPay = '0'";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader sr = com.ExecuteReader();
                    if (sr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sr);
                        dgvPatient.DataSource = dt;
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

        private void getvalue()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select b.Id_Treatment,a.Patient_Name, x.DoctorName ,b.Diagnose,b.DateTreatment,c.PaymentDoctor,c.PaymentDrug,c.TotalPayment, y.Id_Recipe from Patient.Patient a join Patient.Treatment b on a.Id_Patient = b.Id_Patient join Patient.Payment c on c.Id_Treatment = b.Id_Treatment join Doctor.Doctor x on b.Id_Doctor = x.Id_Doctor join Recipe.Recipe y on b.Id_Recipe = y.Id_Recipe where b.Id_Treatment ='" + txtIdTreatment.Text + "'";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        //string idpay = dr["Id_Payment"].ToString();
                        string pname = dr["Patient_Name"].ToString();
                        string pdoc = dr["DoctorName"].ToString();
                        string diag = dr["Diagnose"].ToString();
                        string datetreat = dr["DateTreatment"].ToString();
                        string paydoctor = dr["PaymentDoctor"].ToString();
                        string paydrug = dr["PaymentDrug"].ToString();
                        string totpay = dr["TotalPayment"].ToString();
                        idrecipe = dr["Id_Recipe"].ToString();
                        txtPatientName.Text = pname;
                        txtDoctorName.Text = pdoc;
                        txtDiagnose.Text = diag;
                        txtDateTreatment.Text = Convert.ToDateTime(datetreat).ToString("yyyy-MM-dd"); //datetreat;
                        txtPaymentDoctor.Text = paydoctor;
                        txtPaymentDrug.Text = paydrug;
                        txtTotalPayment.Text = totpay;
                        
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
        }

        private void loadidPayment()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select Id_Payment from Patient.Payment where Id_Treatment = '" + txtIdTreatment.Text + "'";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        string idpay = dr["Id_Payment"].ToString();
                        txtIdPayment.Text = idpay;

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
        }
        
        private void loaddatarecipe()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select e.DrugName,e.DrugType,e.ExpDate,d.Dose, d.Qty,e.Price,d.Subtotal from Patient.Patient a join Patient.Treatment b on a.Id_Patient = b.Id_Patient join Recipe.Recipe c on c.Id_Recipe = b.Id_Recipe join Recipe.RecipeDetail d on d.Id_Recipe = c.Id_Recipe join Recipe.Drug e on e.Id_Drug = d.Id_Drug where Id_Treatment = '" + txtIdTreatment.Text  +"'";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader sr = com.ExecuteReader();
                    if (sr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sr);
                        dgvPayment.DataSource = dt;
                        dgvPayment.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
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

        private void txtMoney_Validating(object sender, CancelEventArgs e)
        {
            if (txtMoney.Text == "" || Regex.IsMatch(txtMoney.Text, @"^\d+$") == false || Convert.ToDouble(txtMoney.Text) < Convert.ToDouble(txtTotalPayment.Text))
            {
                txtMoney.Focus();
                lblNullMoney.Visible = true;
            }
            else
            {
                lblNullMoney.Visible = false;
            }
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if(txtMoney.Text == "")
            {
                txtChange.Clear();
            }
            else
            {
                try
                {
                    kembalian = Convert.ToDouble(txtMoney.Text) - Convert.ToDouble(txtTotalPayment.Text);
                    txtChange.Text = Convert.ToString(kembalian);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if(txtMoney.Text == "" || txtChange.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else if(Convert.ToDouble(txtMoney.Text) < Convert.ToDouble(txtTotalPayment.Text))
            {
                MessageBox.Show("less money");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do You Want To Save the Data ?", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string info = "";
                    try
                    {
                        info = con.openconnection();
                        if (info == "OK")
                        {
                            string query = "update Patient.Payment set isPay = '1' where Id_Payment = @idpayment";
                            SqlCommand com = new SqlCommand(query, con.con);
                            //com.Parameters.AddWithValue("@ispay", "1");
                            com.Parameters.AddWithValue("@idpayment", txtIdPayment.Text);
                            if (com.ExecuteNonQuery() > 0)
                            {
                                info = "OK";
                                MessageBox.Show("Success Save data");

                                FCashierReciptPayment fcrp = new FCashierReciptPayment();
                                CRReciptPayment crrp = new CRReciptPayment();
                                TextObject totreatment = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["IdTreatment"];
                                totreatment.Text = txtIdTreatment.Text;
                                TextObject topatientname = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["PatientName"];
                                topatientname.Text = txtPatientName.Text;
                                TextObject todoctorname = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["DoctorName"];
                                todoctorname.Text = txtDoctorName.Text;
                                TextObject todiagnose = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["Diagnose"];
                                todiagnose.Text = txtDiagnose.Text;
                                //details drug
                                TextObject topaydrug = (TextObject)crrp.ReportDefinition.Sections["Section4"].ReportObjects["PaymentDrug"];
                                topaydrug.Text = txtPaymentDrug.Text;
                                TextObject topaydoc = (TextObject)crrp.ReportDefinition.Sections["Section4"].ReportObjects["PaymentDoctor"];
                                topaydoc.Text = txtPaymentDoctor.Text;
                                TextObject totalpay = (TextObject)crrp.ReportDefinition.Sections["Section4"].ReportObjects["TotalPayment"];
                                totalpay.Text = txtTotalPayment.Text;
                                TextObject tomoney = (TextObject)crrp.ReportDefinition.Sections["Section4"].ReportObjects["Moneyy"];
                                tomoney.Text = txtMoney.Text;
                                TextObject tochange = (TextObject)crrp.ReportDefinition.Sections["Section4"].ReportObjects["Changee"];
                                tochange.Text = txtChange.Text;
                                /*
                                string query1 = "select a.Id_RecipeDetail, b.DrugName, a.Qty, a.Dose from Recipe.RecipeDetail a join Recipe.Drug b on a.Id_Drug = b.Id_Drug join Recipe.Recipe c on c.Id_Recipe = a.Id_Recipe join Patient.Treatment x on x.Id_Recipe = c.Id_Recipe where Id_Treatment = '" + txtIdTreatment.Text + "'";
                                SqlCommand com1 = new SqlCommand(query1, con.con);
                                SqlDataReader dr1 = com1.ExecuteReader();
                                if (dr1.HasRows)
                                {
                                    DataTable dt = new DataTable();
                                    dt.Load(dr1);
                                }
                                */
                                fcrp.crViewPayment.ReportSource = crrp;
                                fcrp.crViewPayment.Refresh();
                                fcrp.Show();
                                this.Hide();
                                txtTotalPayment.Clear();
                                txtPaymentDrug.Clear();
                                txtPaymentDoctor.Clear();
                                txtIdTreatment.Clear();
                                txtIdPayment.Clear();
                                txtPatientName.Clear();
                                txtDoctorName.Clear();
                                txtDiagnose.Clear();
                                txtDateTreatment.Clear();
                                txtMoney.Focus();

                                //txtIdPayment.Text = autoid();
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

        private void dgvPatient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdTreatment.Text = dgvPatient.Rows[e.RowIndex].Cells[0].Value.ToString();

            getvalue();
            loaddatarecipe();
            loadidPayment();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select a.Id_Recipe, b.Patient_Name, c.Diagnose from Patient.Treatment c join Patient.Patient b on c.Id_Patient = b.Id_Patient join Recipe.Recipe a on c.Id_Recipe = a.Id_Recipe join Patient.Payment x on c.Id_Treatment = x.Id_Treatment where x.isPay = 0 and b.Patient_Name like '" + txtSearch.Text + "%'";
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
