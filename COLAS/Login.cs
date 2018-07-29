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

        AdminModule adminmodule = new AdminModule();
        ProfessorModule professormodule = new ProfessorModule();

        private void Username()
        {
            if (string.IsNullOrEmpty(txtbxUsername.Text))
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
            if (string.IsNullOrEmpty(txtbxPassword.Text))
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


        private void lblLogin2_Click(object sender, EventArgs e)
        {
            Login1();
        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {
            Username();
        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {
            Password();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if (txtbxUsername.Text == "Admin_Raul" || txtbxPassword.Text == "admin")
            {
                this.Hide();
                adminmodule.Show();
            }

            else if (txtbxUsername.Text == "Prof_Joemen" || txtbxPassword.Text == "professor")
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                professormodule.Show();
            }


            else if (string.IsNullOrEmpty(txtbxUsername.Text) || string.IsNullOrWhiteSpace(txtbxUsername.Text))
            {
                MessageBox.Show("Please input your username");
            }

            else if (string.IsNullOrEmpty(txtbxPassword.Text) || string.IsNullOrWhiteSpace(txtbxPassword.Text))
            {
                MessageBox.Show("Please input your password");
            }

            else
            {
                MessageBox.Show("Invalid Credentials");
            }
            
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            pnLogin2.BringToFront();
        }

        private void txtbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtbxUsername.Text == "Admin_Raul" && txtbxPassword.Text == "admin")
                {
                    this.Hide();
                    adminmodule.Show();
                }

                else if (txtbxUsername.Text == "Prof_Joemen" && txtbxPassword.Text == "professor")
                {
                    this.Hide();
                    professormodule.Show();
                }

                else if (string.IsNullOrEmpty(txtbxUsername.Text) || string.IsNullOrWhiteSpace(txtbxUsername.Text))
                {
                    MessageBox.Show("Please input your username");
                }

                else if (string.IsNullOrEmpty(txtbxPassword.Text) || string.IsNullOrWhiteSpace(txtbxPassword.Text))
                {
                    MessageBox.Show("Please input your password");
                }

                else
                {
                    MessageBox.Show("Invalid Credentials");
                    txtbxUsername.Clear();
                    txtbxPassword.Clear();
                }
            }
        }
    }
}
