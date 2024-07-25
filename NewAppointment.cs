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
    public partial class NewAppointment : Form
    {
        private Appointment appEdit = null;
        //CheckedListBox cblAppointmentType;
        public NewAppointment()
        {
            InitializeComponent();
            //prevent setting date in the past
            mcalDate.MinDate = mcalDate.TodayDate;
        }
        public NewAppointment(VirtualApp appointment)
        {
            InitializeComponent();
            appEdit = appointment;
            lblSubTitle.Text = "Edit Appointment Information";
            tbId.Text = appointment.Id;
            mcalDate.SetDate(DateTime.Parse(appointment.strDate));
            dtpTime.Text = appointment.strTime;
            numDuration.Text = appointment.Duration.ToString();
            tbPatientName.Text = appointment.PatientName;
            tbTelephone.Text = appointment.PhoneNo;
            tbDoctorid.Text = appointment.DoctorId;
            cbVirtual.Checked = true;
            cbVideoCall.Checked = appointment.blVideoCall;
            gpbVirtual.Visible = true;
            if (cbVideoCall.Checked)
            {
                HideVirtual(true, appointment.EmailAdd);
            }
        }
        public NewAppointment(InPersonApp appointment)
        {
            InitializeComponent();
            appEdit = appointment;
            lblSubTitle.Text = "Edit Appointment Information";
            tbId.Text = appointment.Id;
            mcalDate.SetDate(DateTime.Parse(appointment.strDate));
            dtpTime.Text = appointment.strTime;
            numDuration.Text = appointment.Duration.ToString();
            tbPatientName.Text = appointment.PatientName;
            tbTelephone.Text = appointment.PhoneNo;
            tbDoctorid.Text = appointment.DoctorId;
            cbInperson.Checked = true;
            tbRoomAllo.Text = appointment.RoomAllo;
            cbNurseReq.Checked = appointment.blNurseReq;
            gpbInperson.Visible = true;
            if(cbNurseReq.Checked)
            {
                HideInperson(true, appointment.NurseId);
            }
        }
        public bool createVirtualApp(bool appType)
        {
            //get all user input data
            string strId = tbId.Text;
            string strDate = mcalDate.SelectionStart.ToShortDateString();
            string strTime = dtpTime.Text;
            int intDuration = Convert.ToInt32(numDuration.Text);
            string strPatientName = tbPatientName.Text;
            string strTelephone = tbTelephone.Text;
            string strDoctorId = tbDoctorid.Text;
            string strRoomAllo = tbRoomAllo.Text;
            bool blNurseReq = cbNurseReq.Checked;
            string strNurseId = tbNurseId.Text;
            bool blVideoCall = cbVideoCall.Checked;
            string strEmail = tbEmail.Text;

            Appointment newAppointment = null;

            try
            {
                //create the appointment type based on extra requirements and apppointment type set
                if (blNurseReq && !appType)
                {
                    newAppointment = new InPersonApp(strId, strDate, strTime, intDuration, strPatientName, strTelephone, strDoctorId, strRoomAllo, blNurseReq, strNurseId);

                }
                else if (!blNurseReq && !appType)
                {
                    newAppointment = new InPersonApp(strId, strDate, strTime, intDuration, strPatientName, strTelephone, strDoctorId, strRoomAllo, blNurseReq);
                }
                else if (blVideoCall && appType)
                {
                    newAppointment = new VirtualApp(strId, strDate, strTime, intDuration, strPatientName, strTelephone, strDoctorId, blVideoCall, strEmail);
                }
                else if (!blVideoCall && appType)
                {
                    newAppointment = new VirtualApp(strId, strDate, strTime, intDuration, strPatientName, strTelephone, strDoctorId, blVideoCall);
                }
                AppointmentViewer.AddNewAppointment(newAppointment);
                return true;
            }catch(Exception exceptionCaught)
            {
                MessageBox.Show(exceptionCaught.Message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //hide virtual email input
        private void HideVirtual(bool state, string email)
        {
            tbEmail.Visible = state;
            tbEmail.Text = email;
            lbEmail.Visible = state;
        }

        //hide inperson nurse id input
        private void HideInperson(bool state, string nurseid)
        {
            tbNurseId.Visible = state;
            tbNurseId.Text = nurseid;
            lbNurseId.Visible = state;
        }
        private void cbVirtual_MouseUp(object sender, MouseEventArgs e)
        {
            gpbVirtual.Visible = !gpbVirtual.Visible;       //invert current visability

            //hide all inperson app inputs
            gpbInperson.Visible = false;
            cbInperson.Checked = false;
            cbVideoCall.Checked = false;
            HideVirtual(false, "");
        }

        private void cbInperson_MouseUp(object sender, MouseEventArgs e)
        {
            gpbInperson.Visible = !gpbInperson.Visible;       //invert current visability

            //hide all virtual app inputs
            gpbVirtual.Visible = false;
            cbVirtual.Checked = false;
            tbRoomAllo.Text = "";
            cbNurseReq.Checked = false;
            HideInperson(false, "");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(!cbVirtual.Checked && !cbInperson.Checked) {
                MessageBox.Show("Must select an appointment type to proceed", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (createVirtualApp(cbVirtual.Checked))
            {
                MessageBox.Show("Appointment Registered!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void cbNurseReq_MouseUp(object sender, MouseEventArgs e)
        {
            HideInperson(cbNurseReq.Checked, "");
        }

        private void cbVideoCall_MouseUp(object sender, MouseEventArgs e)
        {
            HideVirtual(cbVideoCall.Checked, "");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(appEdit!=null)
            {
                AppointmentViewer.AddNewAppointment(appEdit);   //save old appointment if no edits confirmed
            }
            this.Close();
        }
    }
}
