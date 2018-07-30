using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech;

//COMMAND import START
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using SpeechLib;
//COMMAND import END

namespace COLAS
{
    public partial class ProfessorModule : Form
    {
        public ProfessorModule()
        {
            InitializeComponent();
        }

        colas1 colas1 = new colas1();//Class

        //COMMAND Instantiate START
        SpeechRecognitionEngine Sre = new SpeechRecognitionEngine();
        SpeechSynthesizer Ss = new SpeechSynthesizer();
        PromptBuilder Pb = new PromptBuilder();
        //COMMAND Instantiate END

        public void startVoice()
        {
            Choices command = new Choices();
            command.Add(new string[] { "dashboard", "schedule", "inventory", "student", "Log out", "Activate Computer Laboratory" });
            Grammar grammar = new Grammar(new GrammarBuilder(command));
            try
            {
                Sre.RequestRecognizerUpdate();
                Sre.LoadGrammarAsync(grammar);
                Sre.SpeechRecognized += Sre_SpeechRecognized;
                Sre.SetInputToDefaultAudioDevice();
                Sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }
        }

        void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Pb.ClearContent();
            SpVoice obj = new SpVoice();

            switch (e.Result.Text)
            {
                case "dashboard":
                    Pb.ClearContent();
                    Dashboard();
                    Pb.AppendText("dashboard panel opened");
                    Ss.Speak(Pb);
                    break;
                case "schedule":
                    Pb.ClearContent();
                    Schedules();
                    Pb.AppendText("schedule panel opened");
                    Ss.Speak(Pb);
                    break;
                case "inventory":
                    Pb.ClearContent();
                    Inventory();
                    Pb.AppendText("inventory panel opened");
                    Ss.Speak(Pb);
                    break;
                case "student":
                    Pb.ClearContent();
                    Students();
                    Pb.AppendText("student panel opened");
                    Ss.Speak(Pb);
                    break;
                case "Log out":
                    Pb.ClearContent();
                    Pb.AppendText("logging out");
                    Ss.Speak(Pb);
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                    break;
                //Computer Module Testing
                case "Activate Computer Laboratory":
                    ComputerModule computermodule = new ComputerModule();
                    Pb.ClearContent();
                    Pb.AppendText("Computer Laboratory Activated");
                    Ss.Speak(Pb);
                    Sre.RecognizeAsyncStop();
                    computermodule.Show();
                    this.Hide();
                    break;
                    //End of Computer Module
            }


        }
        //END VOICE COMMAND







        private void ProfilePic()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbProfilePic.Width - 1, pbProfilePic.Height - 1);
            Region rg = new Region(gp);
            pbProfilePic.Region = rg;
        }


        public void Dashboard()
        {
            //Title
            lblTitlePage.Visible = true;
            TitleLine.Visible = true;
            lblTitlePage.Text = "DASHBOARD";


            //Active Panel
            indiDashboard.Visible = true;
            //indiRequests.Visible = false;
            //indiStaffs.Visible = false;
            //indiProfessors.Visible = false;
            indiSchedules.Visible = false;
            indiInventory.Visible = false;
            indiStudents.Visible = false;
            //End of active panel

            //Content Panel
            pnDashboard.BringToFront();

        }
        
        public void Schedules()
        {
            //Title
            lblTitlePage.Text = "SCHEDULES";
            lblTitlePage.Visible = false;
            TitleLine.Visible = false;

            //Active Panel
            indiDashboard.Visible = false;
            //indiRequests.Visible = false;
            //indiStaffs.Visible = false;
            //indiProfessors.Visible = false;
            indiSchedules.Visible = true;
            indiInventory.Visible = false;
            indiStudents.Visible = false;
            //End of active panel

            //Content Panel
            pnSchedules.BringToFront();
        }

        public void Inventory()
        {
            //Title
            lblTitlePage.Text = "INVENTORY";
            lblTitlePage.Visible = false;
            TitleLine.Visible = false;

            //Active Panel
            indiDashboard.Visible = false;
            //indiRequests.Visible = false;
            //indiStaffs.Visible = false;
            //indiProfessors.Visible = false;
            indiSchedules.Visible = false;
            indiInventory.Visible = true;
            indiStudents.Visible = false;
            //End of active panel

            //Content Panel
            //pnInventory.BringToFront();
        }

        public void Students()
        {
            //Title
            lblTitlePage.Text = "STUDENTS";
            lblTitlePage.Visible = false;
            TitleLine.Visible = false;

            //Active Panel
            indiDashboard.Visible = false;
            //indiRequests.Visible = false;
            //indiStaffs.Visible = false;
            //indiProfessors.Visible = false;
            indiSchedules.Visible = false;
            indiInventory.Visible = false;
            indiStudents.Visible = true;
            //End of active panel

            //Content Panel
            //pnStudents.BringToFront();
        }

        private void ProfessorModule_Load(object sender, EventArgs e)
        {
            startVoice();
            lblUsers.Text = colas1.name;
            ProfilePic();
            Dashboard();
        }

        private void pbDashboard_Click(object sender, EventArgs e)
        {
            Dashboard();
        }

        private void pbSched_Click(object sender, EventArgs e)
        {
            Schedules();
        }

        private void pbStudents_Click(object sender, EventArgs e)
        {
            Students();
        }

        private void pbInventory_Click(object sender, EventArgs e)
        {
            Inventory();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
