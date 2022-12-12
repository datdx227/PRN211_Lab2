using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartupForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void rbtnLion_Click(object sender, EventArgs e)
        {
            pbxBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RadioButton rb = sender as RadioButton;
            if (rb == rbtnLion)
                { pbxBox.Image = Properties.Resources.Logo_Olympique_Lyonnais_2022; }
            if(rb == rbtnFullham)
                { pbxBox.Image = Properties.Resources.Fulham_FC; }
            if (rb == rbtnArs)
            { pbxBox.Image = Properties.Resources.bd897dca5c4907d1635a775ea72bc47b; }
            if (rb == rbtnTot)
            { pbxBox.Image = Properties.Resources._0c9f18dd2fd0fccb4c0d51fc75bc5245; }
            if (rb == rbtnMU)
            { pbxBox.Image = Properties.Resources.logo_manchester_united_4; }
            if (rb == rbtnAle)
            { pbxBox.Image = Properties.Resources.Logo_Atletico_Madrid; }
            if (rb == rbtnReal)
            { pbxBox.Image = Properties.Resources.mobile_173832438; }
            if (rb == rbtnBarce)
            { pbxBox.Image = Properties.Resources.logo_barca_inkythuatso_2_01_05_10_08_55; }
            if (rb == rbtnInter)
            { pbxBox.Image = Properties.Resources.images; }
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T)
            {
                btnExit.PerformClick();
            }
            if (e.KeyCode == Keys.L)
            {
                btnLunar.PerformClick();
            }
        }

        private void btnLunar_Click(object sender, EventArgs e)
        {
            this.Hide();
            lunarForm lf = new lunarForm();
            lf.Show();
        }
    }
}
