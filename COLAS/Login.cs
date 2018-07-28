using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLAS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Username()
        {
            if (string.IsNullOrEmpty(txtbxUsername.Text) || string.IsNullOrWhiteSpace(txtbxUsername.Text))
            {
                lblUsername.Visible = true;
            }

            else
            {
                lblUsername.Visible = false;
            }
        }

        private void Password()
        {
            if (string.IsNullOrEmpty(txtbxPassword.Text) || string.IsNullOrWhiteSpace(txtbxPassword.Text))
            {
                lblPassword.Visible = true;
            }

            else
            {
                lblPassword.Visible = false;
            }
        }

        private void Login1()
        {
            pnLogin1.BringToFront();
        }

        private void txtbxUsername_OnValueChanged(object sender, EventArgs e)
        {
            Username();
        }

        private void txtbxPassword_OnValueChanged(object sender, EventArgs e)
        {
            Password();
        }

        private void lblLogin2_Click(object sender, EventArgs e)
        {
            Login1();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnLogin2.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminModule adminmodule = new AdminModule();
            this.Hide();
            adminmodule.Show();
        }
    }
}
