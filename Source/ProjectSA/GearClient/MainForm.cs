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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void listGear_Click(object sender, EventArgs e)
        {
            GearForm gearForm = new GearForm();
            gearForm.Show();
            this.Hide();
        }

        private void listCategoryGear_Click(object sender, EventArgs e)
        {
            CategoryGearForm categorygearForm = new CategoryGearForm();
            categorygearForm.Show();
            this.Hide();
        }

        private void listBrandGear_Click(object sender, EventArgs e)
        {
            BrandGearForm brandgearForm = new BrandGearForm();
            brandgearForm.Show();
            this.Hide();
        }

        private void tsm_logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
            MessageBox.Show("Log out successfully!!!");
            
        }
    }
}
