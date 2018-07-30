using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;


namespace COLAS
{
    public partial class ComputerModule : MaterialForm
    {
        public ComputerModule()
        {
            InitializeComponent();
        }

        string validation;


        public void Title()
        {
            this.Text = "Cherry Rose Concha";
        }

        private void ComputerModule_Load(object sender, EventArgs e)
        {
            Title();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ComputerModule_FormClosing(object sender, FormClosingEventArgs e)
        {
            validation = Microsoft.VisualBasic.Interaction.InputBox("Validate your credentials","Input Password");

            if (validation == "concha")
            {
                Login login = new Login();
                login.Show();

                e.Cancel = false;
            }

            else
            {
                MessageBox.Show("Closing failed");
                e.Cancel = true;
            }
     
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
