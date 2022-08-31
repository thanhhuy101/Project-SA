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
    public partial class GearForm : Form
    {
        private BindingSource bs = new BindingSource();
        private GearBUS gbus = new GearBUS();
        private CategoryBUS cBUS = new CategoryBUS();
        private BrandBUS bBUS = new BrandBUS();
        private GearBUS geabus = new GearBUS();
        public GearForm()
        {
            InitializeComponent();
        }

        private void dgvGear_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGear.SelectedRows.Count > 0)
            {
                int code = int.Parse(dgvGear.SelectedRows[0].Cells["GearID"].Value.ToString());
                Gear gear = new GearBUS().GetDetails(code);
                if (gear != null)
                {
                    txtID.Text = gear.GearID.ToString();
                    txtName.Text = gear.GearName;
                    cbxCategory.SelectedValue = gear.CategoryID;
                    cbxBrand.SelectedValue = gear.BrandID;
                    txtPrice.Text = gear.GearPrice.ToString();
                }
            }
        }

        private void GearForm_Load(object sender, EventArgs e)
        {
            /*List<Gear> gears = new GearBUS().GetAll();*/
            /*dgvGear.DataSource = gears;*/

            bs.DataSource = geabus.getallGear().Tables[0];
            dgvGear.DataSource = bs;
            cbxCategory.DataSource = cBUS.getAllCategory().Tables[0];
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryID";
            //cbxCategory.ValueMember = "CategoryName";

            cbxBrand.DataSource = bBUS.GetAllBrand().Tables[0];
            cbxBrand.DisplayMember = "BrandGearName";
            cbxBrand.ValueMember = "BrandGearID";
            //cbxBrand.ValueMember = "BrandGearName";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Gear> gears = new GearBUS().Search(keyword);
            dgvGear.DataSource = gears;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Gear newGear = new Gear()
            {
                GearID = 0,
                GearName = txtName.Text.Trim(),
                CategoryID = int.Parse(cbxCategory.SelectedValue.ToString()),
                BrandID = int.Parse(cbxBrand.SelectedValue.ToString()),
                GearPrice = int.Parse(txtPrice.Text.Trim()),
            };
            bool result = new GearBUS().AddNew(newGear);
            if (result)
            {
                bs.DataSource = geabus.getallGear().Tables[0];
                dgvGear.DataSource = bs;
            }
            else
            {
                MessageBox.Show("SORRY BABY :<<< !!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Gear newGear = new Gear()
            {
                GearID = int.Parse(txtID.Text.Trim()),
                GearName = txtName.Text.Trim(),
                CategoryID = int.Parse(cbxCategory.SelectedValue.ToString()),
                BrandID = int.Parse(cbxBrand.SelectedValue.ToString()),
                GearPrice = int.Parse(txtPrice.Text.Trim()),
            };
            bool result = new GearBUS().Update(newGear);
            if (result)
            {
                bs.DataSource = geabus.getallGear().Tables[0];
                dgvGear.DataSource = bs;
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
                bool result = new GearBUS().Delete(id);
                if (result)
                {
                    bs.DataSource = geabus.getallGear().Tables[0];
                    dgvGear.DataSource = bs;
                }
                else
                {
                    MessageBox.Show("SORRY BABY :<<<<< !!!");
                }
            }
        }

        private void GearForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
