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
    public partial class BrandGearForm : Form
    {
        public BrandGearForm()
        {
            InitializeComponent();
        }

        private void dgvBrand_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBrand.SelectedRows.Count > 0)
            {
                int code = int.Parse(dgvBrand.SelectedRows[0].Cells["BrandGearID"].Value.ToString());
                Brand brand = new BrandBUS().GetDetails(code);
                if (brand != null)
                {
                    txtID.Text = brand.BrandGearID.ToString();
                    txtName.Text = brand.BrandGearName;
                }
            }
        }

        private void BrandGearForm_Load(object sender, EventArgs e)
        {
            List<Brand> brands = new BrandBUS().GetAll();
            dgvBrand.DataSource = brands;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Brand> brands = new BrandBUS().Search(keyword);
            dgvBrand.DataSource = brands;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Brand newBrand = new Brand()
            {
                BrandGearID = 0,
                BrandGearName = txtName.Text.Trim(),
            };
            bool result = new BrandBUS().AddNew(newBrand);
            if (result)
            {
                List<Brand> brands = new BrandBUS().GetAll();
                dgvBrand.DataSource = brands;
            }
            else
            {
                MessageBox.Show("SORRY BABY :<<< !!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Brand newBrand = new Brand()
            {
                BrandGearID = int.Parse(txtID.Text.Trim()),
                BrandGearName = txtName.Text.Trim(),
            };
            bool result = new BrandBUS().Update(newBrand);
            if (result)
            {
                List<Brand> brands = new BrandBUS().GetAll();
                dgvBrand.DataSource = brands;
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
                bool result = new BrandBUS().Delete(id);
                if (result)
                {
                    List<Brand> brands = new BrandBUS().GetAll();
                    dgvBrand.DataSource = brands;
                }
                else
                {
                    MessageBox.Show("SORRY BABY :<<<<< !!!");
                }
            }
        }

        private void BrandGearForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
