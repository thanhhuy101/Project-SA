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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            bool result = new AccountBUS().CheckAccount(account);
            if (result)
            {
                new MainForm().Show();               
                this.Hide();
                MessageBox.Show("Welcome to Gear Store!!!!");
            }
            else { MessageBox.Show("Can't login to Gear Store !"); }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account()
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            bool result = new AccountBUS().AddNew(newAccount);
            if (result) MessageBox.Show("Create account succesfully!");
            else MessageBox.Show("Create account fail!");
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
