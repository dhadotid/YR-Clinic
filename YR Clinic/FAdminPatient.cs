using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YR_Clinic
{
    public partial class FAdminPatient : Form
    {
        string date = DateTime.Now.ToString("dd/MM/yyyy");
        public FAdminPatient()
        {
            InitializeComponent();
            dtp_DOB.Format = DateTimePickerFormat.Custom;
            dtp_DOB.CustomFormat = "dd/MM/yyyy";
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
            return flag;
        }
        private int validatedob()
        {
            int flag = 0;
            string datedob = dtp_DOB.Value.ToString("dd/MM/yyyy");
            if (DateTime.Parse(datedob) > DateTime.Parse(date))
            {
                dtp_DOB.Focus();
                lblNullDOB.Visible = true;
                //MessageBox.Show("Please fill in the data");
                flag = 1;
            }
            return flag;
        }

        private void dtp_DOB_Validating(object sender, CancelEventArgs e)
        {
            string datedob = dtp_DOB.Value.ToString("dd/MM/yyyy");
            if (DateTime.Parse(datedob) > DateTime.Parse(date))
            {
                dtp_DOB.Focus();
                lblNullDOB.Visible = true;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if(txtName.Text == "")
            {
                txtName.Focus();
                lblNullName.Visible = true;
            }
            else
            {
                lblNullName.Visible = false;
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

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Focus();
                lblNullAddress.Visible = true;
            }
            else
            {
                lblNullAddress.Visible = false;
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminMenu fam = new FAdminMenu();
            fam.Show();
            this.Hide();
        }
    }
}
