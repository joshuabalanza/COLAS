using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLAS
{
    public partial class AdminModule : Form
    {
        int activetext;
        public AdminModule()
        {
            InitializeComponent();
        }

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
            indiRequests.Visible = false;
            indiStaffs.Visible = false;
            indiProfessors.Visible = false;
            indiSchedules.Visible = false;
            indiInventory.Visible = false;
            indiStudents.Visible = false;
            //End of active panel

            //Content Panel
            pnDashboard.BringToFront();

        }

        public void Requests()
        {
            //Title
            lblTitlePage.Text = "REQUESTS";
            lblTitlePage.Visible = false;
            TitleLine.Visible = false;

            //Active Panel
            indiDashboard.Visible = false;
            indiRequests.Visible = true;
            indiStaffs.Visible = false;
            indiProfessors.Visible = false;
            indiSchedules.Visible = false;
            indiInventory.Visible = false;
            indiStudents.Visible = false;
            //End of active panel

            //Content Panel
            pnRequests.BringToFront();
        }

        public void Staffs()
        {
            //Title
            lblTitlePage.Text = "STAFFS";
            lblTitlePage.Visible = false;
            TitleLine.Visible = false;

            //Active Panel
            indiDashboard.Visible = false;
            indiRequests.Visible = false;
            indiStaffs.Visible = true;
            indiProfessors.Visible = false;
            indiSchedules.Visible = false;
            indiInventory.Visible = false;
            indiStudents.Visible = false;
            //End of active panel

            //Content Panel
            pnStaffs.BringToFront();
        }

        public void Professors()
        {
            //Title
            lblTitlePage.Text = "PROFESSORS";
            lblTitlePage.Visible = false;
            TitleLine.Visible = false;

            //Active Panel
            indiDashboard.Visible = false;
            indiRequests.Visible = false;
            indiStaffs.Visible = false;
            indiProfessors.Visible = true;
            indiSchedules.Visible = false;
            indiInventory.Visible = false;
            indiStudents.Visible = false;
            //End of active panel

            //Content Panel
            pnProf.BringToFront();
        }

        public void Schedules()
        {
            //Title
            lblTitlePage.Text = "SCHEDULES";
            lblTitlePage.Visible = false;
            TitleLine.Visible = false;

            //Active Panel
            indiDashboard.Visible = false;
            indiRequests.Visible = false;
            indiStaffs.Visible = false;
            indiProfessors.Visible = false;
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
            indiRequests.Visible = false;
            indiStaffs.Visible = false;
            indiProfessors.Visible = false;
            indiSchedules.Visible = false;
            indiInventory.Visible = true;
            indiStudents.Visible = false;
            //End of active panel

            //Content Panel
            pnInventory.BringToFront();
        }

        public void Students()
        {
            //Title
            lblTitlePage.Text = "STUDENTS";
            lblTitlePage.Visible = false;
            TitleLine.Visible = false;

            //Active Panel
            indiDashboard.Visible = false;
            indiRequests.Visible = false;
            indiStaffs.Visible = false;
            indiProfessors.Visible = false;
            indiSchedules.Visible = false;
            indiInventory.Visible = false;
            indiStudents.Visible = true;
            //End of active panel

            //Content Panel
            pnStudents.BringToFront();
        }


        private void AdminModule_Load(object sender, EventArgs e)
        {
            //Active Panel
            Dashboard();
            //End of active panel

            //Profile Pic
            ProfilePic();
            //End of profile pic

            
        }

        private void pbRequests_Click(object sender, EventArgs e)
        {
            Requests();
        }

        private void pbDashboard_Click(object sender, EventArgs e)
        {
            Dashboard();
        }

        private void pbStaffs_Click(object sender, EventArgs e)
        {
            Staffs();
        }

        private void pbProf_Click(object sender, EventArgs e)
        {
            Professors();
        }

        private void pbSched_Click(object sender, EventArgs e)
        {
            Schedules();
        }

        private void pbInventory_Click(object sender, EventArgs e)
        {
            Inventory();
        }

        private void pbStudents_Click(object sender, EventArgs e)
        {
            Students();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            Dashboard();
        }

        private void lblRequests_Click(object sender, EventArgs e)
        {
            Requests();
        }

        private void lblStaffs_Click(object sender, EventArgs e)
        {
            Staffs();
        }

        private void lblProf_Click(object sender, EventArgs e)
        {
            Professors();
        }

        private void lblSched_Click(object sender, EventArgs e)
        {
            Schedules();
        }

        private void lblInventory_Click(object sender, EventArgs e)
        {
            Inventory();
        }

        private void lblStudents_Click(object sender, EventArgs e)
        {
            Students();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnDashboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
