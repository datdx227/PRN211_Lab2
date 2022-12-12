using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class DentalPaymentForm : Form
    {
        public DentalPaymentForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Please enter guest name.");
            }
            else
            {
                int total = 0;
                if(chkClean.Checked == true)  total += 100000;
                if(chkWhitening.Checked == true) total += 1200000;
                if (chkXRay.Checked == true) total += 200000;
                total += Convert.ToInt32(numFilling.Value)*80000;
                txtTotal.Text = "$" + total;
            }
        }
    }
}
