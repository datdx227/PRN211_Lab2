using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StartupForm
{
    public partial class lunarForm : Form
    {
        public lunarForm()
        {
            InitializeComponent();
        }

        private void txtDuong_Enter(object sender, EventArgs e)
        {
            txtDuong.BackColor = Color.Pink;
        }

        private void txtDuong_Leave(object sender, EventArgs e)
        {
            txtDuong.BackColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int namduong;
            string strCan = "";
            string strChi = "";
            try
            {
                namduong = Convert.ToInt32(txtDuong.Text);
                if (namduong < 0)
                {
                    MessageBox.Show("Nhap sai!");
                }
                else
                {
                    switch (namduong % 10)
                    {
                        case 0:
                            strCan = "Canh";
                            break;
                        case 1:
                            strCan = "Tân";
                            break;
                        case 2:
                            strCan = "Nhâm";
                            break;
                        case 3:
                            strCan = "Quý";
                            break;
                        case 4:
                            strCan = "Giáp";
                            break;
                        case 5:
                            strCan = "Ất";
                            break;
                        case 6:
                            strCan = "Bính";
                            break;
                        case 7:
                            strCan = "Đinh";
                            break;
                        case 8:
                            strCan = "Mậu";
                            break;
                        case 9:
                            strCan = "Kỷ";
                            break;
                    }
                    switch (namduong % 12)
                    {
                        case 0:
                            strChi = "Thân";
                            break;
                        case 1:
                            strChi = "Dậu";
                            break;
                        case 2:
                            strChi = "Tuất";
                            break;
                        case 3:
                            strChi = "Hợi";
                            break;
                        case 4:
                            strChi = "Tí";
                            break;
                        case 5:
                            strChi = "Sửu";
                            break;
                        case 6:
                            strChi = "Dần";
                            break;
                        case 7:
                            strChi = "Mão";
                            break;
                        case 8:
                            strChi = "Thìn";
                            break;
                        case 9:
                            strChi = "Tỵ";
                            break;
                        case 10:
                            strChi = "Ngọ";
                            break;
                        case 11:
                            strChi = "Mùi";
                            break;
                    }
                    txtAm.Text = strCan + " " + strChi;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chỉ nhập số 0-10000!!");
            }                        
        }

        private void txtDuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
    }
}
