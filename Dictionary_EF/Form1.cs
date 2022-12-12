using Dictionary_EF.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Dictionary_EF
{
    public partial class Form1 : Form
    {
        MyDB2Context context = new MyDB2Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                var data = (from d in context.Dictionaries
                            join t in context.WordTypes on d.Id equals t.Id
                            //join t in teachers on c.TeacherID equals t.TeacherID
                            select new
                            {
                                WordID = d.WordId,
                                Word = d.Word,
                                Meaning = d.Meaning,
                                EditDate = d.EditDate,
                                TypeName = t.TypeName
                            }).ToList();
                dgvDictionary.DataSource = data;
                var data2 = context.WordTypes.ToList();
                cbbType.DataSource = data2;
                cbbType.DisplayMember = "TypeName";
                cbbType.ValueMember = "ID";

                txtID.DataBindings.Clear();
                txtID.DataBindings.Add("Text", data, "WordID");

                txtWord.DataBindings.Clear();
                txtWord.DataBindings.Add("Text", data, "Word");

                txtMean.DataBindings.Clear();
                txtMean.DataBindings.Add("Text", data, "Meaning");

                cbbType.DataBindings.Clear();
                cbbType.DataBindings.Add("Text", data, "TypeName");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvDictionary.Rows.Count; i++)
                {
                    if (txtWord.Text == dgvDictionary.Rows[i].Cells[1].FormattedValue.ToString()) // Kiểm tra trùng lặp dữ liệu
                    {
                        MessageBox.Show("This Word already exist!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (txtWord.Text == "" || txtMean.Text == "")
                {
                    MessageBox.Show("Word and Mean cannot blank!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //tao doi tuong de add
                Dictionary p = new Dictionary
                {
                    Word = txtWord.Text,
                    EditDate = DateTime.Now,
                    Meaning = txtMean.Text,
                    Id = Convert.ToInt32(cbbType.SelectedIndex.ToString()) + 1
            };

                //Add vao DB
                context.Dictionaries.Add(p);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Add success!");
                    ShowData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Tim doi tuong de delete
                Dictionary p = context.Dictionaries.FirstOrDefault(x => x.WordId == Int32.Parse(txtID.Text));
                if (p == null)
                {
                    MessageBox.Show("Id không tìm thấy");
                    return;
                }
                //Xoas khoi  DB
                if (MessageBox.Show("Are you sure want to Delete", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    context.Dictionaries.Remove(p);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Delete success!");
                        ShowData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
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
                //Tim doi tuong de update
                Dictionary p = context.Dictionaries.FirstOrDefault(x => x.WordId == Int32.Parse(txtID.Text));
                if (p == null)
                {
                    MessageBox.Show("Id không tìm thấy");
                    return;
                }
                //Update vao DB
                p.Word = txtWord.Text;
                p.Meaning = txtMean.Text;
                p.EditDate = DateTime.Now;
                p.Id = (int)cbbType.SelectedValue;

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Update success!");
                    ShowData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }
    }
}