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
    public partial class ViewAllAppointmentPage : Form
    {

        //constructor that will load the form with a filtered appointment list
        public ViewAllAppointmentPage(bool filter)
        {
            InitializeComponent();
            AppointmentViewer.LoadFilterApp(filter);
            LoadComboBox();
        }

        //constructor that will load the form with all appointments in the list
        public ViewAllAppointmentPage()
        {
            InitializeComponent();
            AppointmentViewer.LoadAppointments();
            LoadComboBox();
            
        }

        //method to load the id's into the combo box made seperate or there would be identical code in both constructors when it doesn't need to be
        private void LoadComboBox()
        {
            foreach (Appointment appointment in AppointmentViewer.arrAppointments)
            {
                cbxAppSelect.Items.Add(appointment.Id);
            }
            cbxAppSelect.SelectedIndex = 0;     //set the default to the first option instead of null to prevent selection error on a null id
        }

        private void btnSelectShow_Click(object sender, EventArgs e)
        {
            foreach(Appointment appointment in AppointmentViewer.arrAppointments)
            {
                if(cbxAppSelect.SelectedItem.ToString() == appointment.Id)
                {
                    txtAppView.Text = appointment.ToString();   //set text box to show the appointment selected found by its ID 
                    break;
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtAppView.Text = null;     //delete any text in the box before appending to the text box, just incase there is text already in it
            foreach (Appointment appointment in AppointmentViewer.arrAppointments)
            {
                txtAppView.Text += appointment.ToString() + "\r\n\r\n";     //append the text box to show all appointments in its list and space them out
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            for(int i=0; i < AppointmentViewer.arrAppointments.Count; i++)
            {
                if (cbxAppSelect.SelectedItem.ToString() == AppointmentViewer.arrAppointments[i].Id)
                {
                    //determine the appointment type and create a new appointment form in edit mode
                    if (AppointmentViewer.arrAppointments[i].GetType() == typeof(VirtualApp))
                    {
                        VirtualApp appointment = (VirtualApp)AppointmentViewer.arrAppointments[i];  //cast appointment to correct type
                        //delete appointment and save new list to prevent duplicate appointments
                        AppointmentViewer.strarrAppIds.Remove(AppointmentViewer.arrAppointments[i].Id);
                        AppointmentViewer.arrAppointments.Remove(AppointmentViewer.arrAppointments[i]);
                        AppointmentViewer.SaveAppointments();
                        NewAppointment newAppointmentForm = new NewAppointment(appointment);
                        newAppointmentForm.ShowDialog();
                        break;
                    }
                    else if (AppointmentViewer.arrAppointments[i].GetType() == typeof(InPersonApp))
                    {
                        InPersonApp appointment = (InPersonApp)AppointmentViewer.arrAppointments[i];    //cast appointment to correct type
                        //delete appointment and save new list to prevent duplicate appointments
                        AppointmentViewer.strarrAppIds.Remove(AppointmentViewer.arrAppointments[i].Id);
                        AppointmentViewer.arrAppointments.Remove(AppointmentViewer.arrAppointments[i]);
                        AppointmentViewer.SaveAppointments();
                        NewAppointment newAppointmentForm = new NewAppointment(appointment);
                        newAppointmentForm.ShowDialog();
                        break;
                    }
                }
            }
            this.Close();
        }
    }
}
