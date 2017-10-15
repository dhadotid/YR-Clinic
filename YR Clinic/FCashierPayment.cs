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
            txtIdPayment.Text = autoid();
            getvalue();
            loaddatarecipe();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FCashierMenu fcm = new FCashierMenu();
            fcm.Show();
            this.Hide();
        }

        private void getvalue()
        {
            string info = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select b.Id_Treatment,a.Patient_Name, x.DoctorName ,b.Diagnose,b.DateTreatment,c.PaymentDoctor,c.PaymentDrug,c.TotalPayment, y.Id_Recipe from Patient.Patient a join Patient.Treatment b on a.Id_Patient = b.Id_Patient join Patient.Payment c on c.Id_Treatment = b.Id_Treatment join Doctor.Doctor x on b.Id_Doctor = x.Id_Doctor join Recipe.Recipe y on b.Id_Recipe = y.Id_Recipe where Id_Payment ='" + txtIdPayment.Text + "'";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        //string idpay = dr["Id_Payment"].ToString();
                        string idtreat = dr["Id_Treatment"].ToString();
                        string pname = dr["Patient_Name"].ToString();
                        string pdoc = dr["DoctorName"].ToString();
                        string diag = dr["Diagnose"].ToString();
                        string datetreat = dr["DateTreatment"].ToString();
                        string paydoctor = dr["PaymentDoctor"].ToString();
                        string paydrug = dr["PaymentDrug"].ToString();
                        string totpay = dr["TotalPayment"].ToString();
                        idrecipe = dr["Id_Recipe"].ToString();
                        txtIdTreatment.Text = idtreat;
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

        private string autoid()
        {
            string info = "";
            string newcode = "";
            try
            {
                info = con.openconnection();
                if (info == "OK")
                {
                    string query = "select top 1 Id_Payment from Patient.Payment order by Id_Payment desc;";
                    SqlCommand com = new SqlCommand(query, con.con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Id_Payment"].ToString();
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
                FCashierReciptPayment fcrp = new FCashierReciptPayment();
                CRReciptPayment crrp = new CRReciptPayment();
                TextObject to = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["IdPayment"];
                to.Text = txtIdPayment.Text;
                TextObject totreatment = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["IdTreatment"];
                totreatment.Text = txtIdTreatment.Text;
                TextObject topatientname = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["PatientName"];
                topatientname.Text = txtPatientName.Text;
                TextObject todoctorname = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["DoctorName"];
                todoctorname.Text = txtDoctorName.Text;
                TextObject toidrecipe = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["IdRecipe"];
                toidrecipe.Text = idrecipe;
                TextObject todiagnose = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["Diagnose"];
                todiagnose.Text = txtDiagnose.Text;

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

                txtIdPayment.Text = autoid();
            }
        }
    }
}
