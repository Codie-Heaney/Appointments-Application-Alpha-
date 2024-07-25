//Codie Heaney/University of Sunderland/bh97rt
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSys_Alpha
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            //prevents errors on appointment viewing page
            if(AppointmentViewer.arrAppointments.Count > 0)
            {
                //instantiates an instance of the view form that loads all appointments for viewing
                ViewAllAppointmentPage appointmentPage = new ViewAllAppointmentPage();
                appointmentPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("No appointments to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewIn_Click(object sender, EventArgs e)
        {
            //prevents errors on appointment viewing page
            if (AppointmentViewer.arrAppointments.Count > 0)
            {
                //instantiates an instance of the view form that loads and filters for in person appointments for viewing
                ViewAllAppointmentPage appointmentPage = new ViewAllAppointmentPage(true);
                appointmentPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("No appointments to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnViewVir_Click(object sender, EventArgs e)
        {
            //prevents errors on appointment viewing page
            if (AppointmentViewer.arrAppointments.Count > 0)
            {
                //instantiates an instance of the view form that loads and filters for virtual appointments for viewing
                ViewAllAppointmentPage appointmentPage = new ViewAllAppointmentPage(false);
                appointmentPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("No appointments to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateApp_Click(object sender, EventArgs e)
        {
            NewAppointment appointmentPage = new NewAppointment();
            appointmentPage.ShowDialog();
        }
    }
}
