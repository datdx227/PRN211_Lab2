using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryEntityFw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyDB2Entities db = new MyDB2Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }
        private void ShowData()
        {  
            var getAllDictionary = (from d in db.Dictionary
                         join t in db.WordType on d.ID equals t.ID
                         //join t in teachers on c.TeacherID equals t.TeacherID
                         select new
                         {
                             d.WordID,
                             d.Word,
                             d.Meaning,
                             d.EditDate,
                             t.TypeName
                         });
            var getAllType = from w in db.WordType select w;
            dgvDictionary.DataSource = getAllDictionary.ToList();
            cbType.DataSource = getAllType.ToList();
            cbType.DisplayMember = "TypeName";
            cbType.ValueMember = "ID";
            //
        }
        private void ClearTxt()
        {
            txtWord.Clear();
            txtMean.Clear();
            cbType.Text = dgvDictionary.Rows[1].Cells[4].FormattedValue.ToString();
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void dgvDictionary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            //cbType.Items.Clear();
            try
            {           
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDictionary.Rows[e.RowIndex];
                txtWord.Text = row.Cells[1].FormattedValue.ToString();
                cbType.Text = row.Cells[4].FormattedValue.ToString();
                //cbType.SelectedValue = cbType.Items.FindByText("text").Value;
                txtMean.Text = row.Cells[2].FormattedValue.ToString();
                txtID.Text = row.Cells[0].FormattedValue.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Click cell in row below!!");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvDictionary.Rows.Count; i++) {
                    if (txtWord.Text == dgvDictionary.Rows[i].Cells[1].FormattedValue.ToString()) // Kiểm tra trùng lặp dữ liệu
                    {
                        MessageBox.Show("This Word already exist!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if(txtWord.Text == "" || txtMean.Text == "")
                {
                    MessageBox.Show("Word and Mean cannot blank!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else                
                {
                    Dictionary d = new Dictionary();
                    d.Word = txtWord.Text.ToString();
                    d.EditDate = DateTime.Now;
                    d.Meaning = txtMean.Text.ToString();
                    d.ID = Convert.ToInt32(cbType.SelectedIndex.ToString()) + 1;
                    db.Dictionary.Add(d);
                    db.SaveChanges();
                    MessageBox.Show("Add Word successfull!");
                    ShowData();
                    ClearTxt();
                }
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
                if(dgvDictionary.SelectedCells == null)
                {
                    MessageBox.Show("Choose one Word to Update!");
                    return;
                }
                else
                {
                    int id = Convert.ToInt32(txtID.Text);
                    Dictionary d = new Dictionary();
                    d = db.Dictionary.Where(a => a.WordID == id).SingleOrDefault();
                    d.Word = txtWord.Text;
                    d.EditDate = DateTime.Now;
                    d.Meaning = txtMean.Text;
                    //d.ID = Convert.ToInt32(cbType.SelectedIndex.ToString()) + 1;
                    db.SaveChanges();
                    MessageBox.Show("Update Word successfull!");
                    ShowData();
                    ClearTxt();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error:" + ex);
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
                    var delete = db.Dictionary.FirstOrDefault(a => a.Word == (txtWord.Text));
                    db.Dictionary.Remove(delete);
                    db.SaveChanges();
                    MessageBox.Show("Delete Word successfull!");
                    ShowData();
                    ClearTxt();
                }
            }
            catch (Exception)
            {
                return ;
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
