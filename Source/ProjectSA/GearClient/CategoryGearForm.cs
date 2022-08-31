using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearClient
{
    public partial class CategoryGearForm : Form
    {
        public CategoryGearForm()
        {
            InitializeComponent();
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                int code = int.Parse(dgvCategory.SelectedRows[0].Cells["CategoryID"].Value.ToString());
                Category category = new CategoryBUS().GetDetails(code);
                if (category != null)
                {
                    txtID.Text = category.CategoryID.ToString();
                    txtName.Text = category.CategoryName;
                }
            }
        }

        private void CategoryGearForm_Load(object sender, EventArgs e)
        {
            List<Category> categories = new CategoryBUS().GetAll();
            dgvCategory.DataSource = categories;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Category> categories = new CategoryBUS().Search(keyword);
            dgvCategory.DataSource = categories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category()
            {
                CategoryID = 0,
                CategoryName = txtName.Text.Trim(),

            };
            bool result = new CategoryBUS().AddNew(newCategory);
            if (result)
            {
                List<Category> categories = new CategoryBUS().GetAll();
                dgvCategory.DataSource = categories;
            }
            else
            {
                MessageBox.Show("SORRY BABY :<<< !!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category()
            {
                CategoryID = int.Parse(txtID.Text.Trim()),
                CategoryName = txtName.Text.Trim(),
            };
            bool result = new CategoryBUS().Update(newCategory);
            if (result)
            {
                List<Category> categories = new CategoryBUS().GetAll();
                dgvCategory.DataSource = categories;
            }
            else
            {
                MessageBox.Show("Faild!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE ?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(txtID.Text.Trim());
                bool result = new CategoryBUS().Delete(id);
                if (result)
                {
                    List<Category> categories = new CategoryBUS().GetAll();
                    dgvCategory.DataSource = categories;
                }
                else
                {
                    MessageBox.Show("SORRY BABY :<<<<< !!!");
                }
            }
        }

        private void CategoryGearForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
