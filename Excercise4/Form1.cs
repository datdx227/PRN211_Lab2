using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Formats.Asn1;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ex5_DictionaryADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection conn;
        DataProvider d = new DataProvider();
        private void Form1_Load(object sender, EventArgs e)
        {

            ShowData();
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void ShowData()
        {
            //dgvDictionary.DataSource = d.executeQuery("SELECT WordID, Word, Meaning, FORMAT(EditDate,'d', 'en-US') AS date, TypeName FROM Dictionary JOIN WordType ON Dictionary.ID = WordType.ID");
            dgvDictionary.DataSource = d.getAllDictionary();
            //cbType.DataSource = d.executeQuery("SELECT TypeName FROM WordType");
            cbType.DataSource = d.getAllType();
            cbType.DisplayMember = "TypeName";
            //cbType.ValueMember = "TypeId";if (String.IsNullOrEmpty(txtWord.Text))            
        }
        private void ClearTxt()
        {
            txtWord.Clear();
            txtMean.Clear();
            cbType.Text = dgvDictionary.Rows[1].Cells[4].Value.ToString();
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void dgvDictionary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            //cbType.Items.Clear();
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDictionary.Rows[e.RowIndex];
                txtWord.Text = row.Cells[1].Value.ToString();
                cbType.Text = row.Cells[4].Value.ToString();
                //cbType.SelectedValue = cbType.Items.FindByText("text").Value;
                txtMean.Text = row.Cells[2].Value.ToString();
                txtID.Text = row.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Click cell in row below!!");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDictionary.SelectedCells == null)
                {
                    MessageBox.Show("Choose one Word to Update!");
                    return;
                }
                    if (txtWord.Text == "" || txtMean.Text == "")
                {
                    MessageBox.Show("Word can not empty!");
                }
                else 
                { 
                string sql = "UPDATE [dbo].[Dictionary] SET Word = N'" + txtWord.Text + "', EditDate =  GETDATE(), Meaning = N'" + txtMean.Text + "', ID = " +(Convert.ToInt32(cbType.SelectedIndex.ToString()) + 1) + "WHERE WordID = " + txtID.Text;
                //    "INSERT INTO Dictionary(Word, EditDate, Meaning, ID)" +
                //"VALUE (N'" + txtWord.Text+"', "+ DateTime.Now+", N'"+ txtMean.Text+"'," + (Convert.ToInt32(cbType.SelectedIndex.ToString()) + 1)+")";

                d.executeNonQuery(sql);
                ShowData();
                ClearTxt();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDictionary.SelectedCells == null)
                {
                    MessageBox.Show("Choose one Word to Delete!");
                    return;
                }
                if (MessageBox.Show("Are you sure want to Delete", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM [dbo].[Dictionary] WHERE WordID = " + txtID.Text;
                    //    "INSERT INTO Dictionary(Word, EditDate, Meaning, ID)" +
                    //"VALUE (N'" + txtWord.Text+"', "+ DateTime.Now+", N'"+ txtMean.Text+"'," + (Convert.ToInt32(cbType.SelectedIndex.ToString()) + 1)+")";

                    d.executeNonQuery(sql);
                    ShowData();
                    ClearTxt();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i < dgvDictionary.Rows.Count; i++)
                {
                    if (txtWord.Text == dgvDictionary.Rows[i].Cells[1].FormattedValue.ToString()) // Kiểm tra trùng lặp dữ liệu
                    {
                        MessageBox.Show("This Word already exist!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnUpdate.Enabled = true;
                        return;
                    }
                }
                string sql = "INSERT INTO[dbo].[Dictionary] (Word, EditDate, Meaning, ID) VALUES(N'" + txtWord.Text + "', GETDATE(),N'" + txtMean.Text + "'," + (Convert.ToInt32(cbType.SelectedIndex.ToString()) + 1) + ");";
                //    "INSERT INTO Dictionary(Word, EditDate, Meaning, ID)" +
                //"VALUE (N'" + txtWord.Text+"', "+ DateTime.Now+", N'"+ txtMean.Text+"'," + (Convert.ToInt32(cbType.SelectedIndex.ToString()) + 1)+")";

                d.executeNonQuery(sql);
                ShowData();
                ClearTxt();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Add error: " + ex.Message);
            }
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtWord.Text))
            {
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
                //btnDelete.Enabled = false;
            }
            else
            {
                btnInsert.Enabled = true;
                //btnUpdate.Enabled = true;
                //btnDelete.Enabled = true;
            }
        }
    }
}