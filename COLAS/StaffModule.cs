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
    public partial class StaffModule : Form
    {
        public StaffModule()
        {
            InitializeComponent();
        }

        public void Dashboard()
        {
            //Title
            lblTitlePage.Visible = true;
            TitleLine.Visible = true;
            lblTitlePage.Text = "DASHBOARD";


            //Active Panel
            indiDashboard.Visible = true;
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
            indiSchedules.Visible = false;
            indiInventory.Visible = false;
            indiStudents.Visible = true;
            //End of active panel

            //Content Panel
            pnStudents.BringToFront();
        }

        private void pbDashboard_Click(object sender, EventArgs e)
        {
            Dashboard();
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

        private void StaffModule_Load(object sender, EventArgs e)
        {
            //Active Panel
            Dashboard();
            //End of active panel

        }
    }
}
