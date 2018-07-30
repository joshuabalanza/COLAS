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

//COMMAND import START
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using SpeechLib;
//COMMAND import END


namespace COLAS
{
    public partial class ComputerModule : MaterialForm
    {
        public ComputerModule()
        {
            InitializeComponent();
        }

        string validation;

        colas1 colas1 = new colas1();//Class

        //COMMAND Instantiate START
        SpeechRecognitionEngine Sre = new SpeechRecognitionEngine();
        SpeechSynthesizer Ss = new SpeechSynthesizer();
        PromptBuilder Pb = new PromptBuilder();
        //COMMAND Instantiate END



        public void Title()
        {
            this.Text = colas1.name;
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
            validation = Microsoft.VisualBasic.Interaction.InputBox("Input Admin Password");

            if (validation == "admin")
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
