using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YR_Clinic
{
    public partial class FCashierListDoctor : Form
    {
        public FCashierListDoctor()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FCashierMenu fc = new FCashierMenu();
            fc.Show();
            this.Hide();
        }
    }
}
