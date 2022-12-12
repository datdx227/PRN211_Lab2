namespace SercurityPanel
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void EventHandler(object? sender, EventArgs e);

        private void btn0_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            //MessageBox.Show(b.);            
            txtSecurityCode.Text += "" + b.Text;
            //this.txtSecurityCode.PasswordChar = '*';
            
        }

        private void btnFF_Click(object sender, EventArgs e)
        {           
            List<Security> list = new List<Security>();
            if(txtSecurityCode.Text.Equals("8345")) 
            { 
                list.Add(new Security(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo), "Cutstodians"));
            }
            else if (txtSecurityCode.Text.Equals("1645") || txtSecurityCode.Text.Equals("1689"))
            {
                list.Add(new Security(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo), "Technicians"));
            }
            else if (txtSecurityCode.Text.Equals("9998") || txtSecurityCode.Text.Equals("1006") || txtSecurityCode.Text.Equals("1007") || txtSecurityCode.Text.Equals("1008"))
            {
                list.Add(new Security(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo), "Scientist"));
            }
            else 
            { 
                list.Add(new Security(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo), "Restricted Access!"));
            }
            foreach (Security security in list) { 
                lblAccessLog.Items.Add(security);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "" ;
        }
    }
}