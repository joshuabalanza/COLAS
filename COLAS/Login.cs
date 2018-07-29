using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//COMMAND import START
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using SpeechLib;
//COMMAND import END

namespace COLAS
{
    public partial class Login : Form
    {
        colas1 colas1 = new colas1();//Class

        //COMMAND Instantiate START
        SpeechRecognitionEngine Sre = new SpeechRecognitionEngine();
        SpeechSynthesizer Ss = new SpeechSynthesizer();
        PromptBuilder Pb = new PromptBuilder();
        //COMMAND Instantiate END

        public Login()
        {
            InitializeComponent();
        }

        AdminModule adminmodule = new AdminModule();
        ProfessorModule professormodule = new ProfessorModule();


        //private struct Commands {
        //    List<string> command = new List<string> {
        //    }
        //}

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
            Sre.RecognizeAsyncStop(); //STOP VOICE COMMAND
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
                colas1.name = "RAUL GUTIERREZ";
                this.Hide();
                adminmodule.Show();
            }

            else if (txtbxUsername.Text == "Prof_Joemen" || txtbxPassword.Text == "barrios")
            {
                colas1.name = "JOEMEN BARRIOS";
                MessageBox.Show("Login Successful");
                this.Hide();
                professormodule.Show();
            }
            else if (txtbxUsername.Text == "Prof_Gena" || txtbxPassword.Text == "villafuerte")
            {
                colas1.name = "GENALYN VILLAFUERTE";
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
            startVoice();//START VOICE COMMAND
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

        private void Login_Load(object sender, EventArgs e)
        { 
            startVoice();
        }



        public void startVoice()
        {
            Choices command = new Choices();
            command.Add(new string[] { "Hey Colas" ,"Log in Admin", "Log in Joemen Barrios", "Log in Genalyn Villafuerte", "Log in Michael Tan"});
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
            if (e.Result.Text == "Hey Colas")
            {

                Pb.ClearContent();
                pbActiveColas.Visible = true;
                pbInactiveColas.Visible = false;
                Sre.RecognizeAsyncStop();
                colas1.stat = "1";
               
            }
            if (colas1.stat == "1")
            {
                if (e.Result.Text == "Log in Admin")
                {
                    Pb.ClearContent();
                    Pb.AppendText("Logging-in, Welcome Sir Raul Gutierrez");
                    Ss.Speak(Pb);
                    Sre.RecognizeAsyncStop();
                    colas1.name = "RAUL GUTIERREZ";
                    adminmodule.Show();
                    this.Hide();
                }
                else
                {
                    switch (e.Result.Text)
                    {
                        case "Log in Joemen Barrios":
                            Pb.ClearContent();
                            Pb.AppendText("Logging-in, Welcome Maam Joemen Barrios");
                            Ss.Speak(Pb);
                            Sre.RecognizeAsyncStop();
                            colas1.name = "JOEMEN BARRIOS";
                            professormodule.Show();
                            this.Hide();
                            break;
                        case "Log in Genalyn Villafuerte":
                            Pb.ClearContent();
                            Pb.AppendText("Logging-in, Welcome Maam Genalyn Villafuerte");
                            Ss.Speak(Pb);
                            Sre.RecognizeAsyncStop();
                            colas1.name = "GENALYN VILLAFUERTE";
                            professormodule.Show();
                            this.Hide();
                            break;
                        case "Log in Michael Tan":
                            Pb.ClearContent();
                            Pb.AppendText("Logging-in, Welcome Sir Michael Tan");
                            Ss.Speak(Pb);
                            Sre.RecognizeAsyncStop();
                            colas1.name = "MICHAEL TAN";
                            professormodule.Show();
                            this.Hide();
                            break;
                    }
                }

            }
          
        }
    }
}
