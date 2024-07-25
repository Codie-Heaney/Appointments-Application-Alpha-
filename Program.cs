//Codie Heaney/University of Sunderland/bh97rt
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace AppSys_Alpha
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppointmentViewer.LoadAppointments();
            AppointmentViewer.LoadAppointmentIds();

            Application.Run(new MainPage());
            //Application.Run(new NewAppointment());
        }
    }

    [Serializable]
    abstract public class Appointment   //appointment class definition to be used by both InPersonApp and VirtualApp classes
    {
        //appointment instance variables
        private string strId;
        public string strDate;
        public string strTime;
        private int intDuration;
        private string strPatientName;
        private string strPhoneNo;
        private string strDoctorId;

        //appointment property validation
        public string Id
        {
            get { return strId; }
            set
            {
                if (!Regex.IsMatch(value, @"^[0-9]+$"))
                {
                    throw (new IncorrectId());
                }
                if (AppointmentViewer.strarrAppIds.Contains(value))
                {
                    throw (new DuplicateId());
                }
                strId = value;
            }
        }
        public int Duration {
            get { return intDuration; }
            set {
                if(value > 60)
                {
                    throw (new AppointmentLengthExceeded());
                }
                intDuration = value;
            } 
        }
        public string PatientName {
            get { return strPatientName; }
            set
            {
                if(!Regex.IsMatch(value, @"^[a-zA-Z ]+$"))
                {
                    throw (new IncorrectPatientName());
                }
                if (!Regex.IsMatch(value, @"\s"))
                {
                    throw (new IncorrectSurname());
                }

                strPatientName = value;
            } 
        }
        public string PhoneNo {
            get { return strPhoneNo; }
            set {
                if(!Regex.IsMatch(value, @"^[0-9]+$") || value.Length > 11 || value.Length < 9)
                {
                    throw (new IncorrectTelephone());
                }
                strPhoneNo = value;
            }
        }
        public string DoctorId {
            get { return strDoctorId; }
            set {
                if (value.Length == 0)
                {
                    throw (new GPIdMissing());
                }
                if (Char.ToLower(value[0]) != 'g' || Char.ToLower(value[1]) != 'p')
                {
                    throw (new GPIdMissing());
                }
                if(!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                {
                    throw (new IncorrectGPId());
                }

                strDoctorId = value;
            } 
        }

        //parent class constructer for all basic appointment details
        public Appointment(string id, string date, string time, int duration, string patientName, string phoneNo, string doctorId)
        {
            Id = id;
            PatientName = patientName;
            DoctorId = doctorId;
            PhoneNo = phoneNo;
            Duration = duration;
            //validation not required for date and time, the form won't allow misinformation to be entered
            strDate = date;
            strTime= time;
        }

        //base ToString() method that all subclasses append their extra details on to
        public override string ToString()
        {
            return "ID: " + strId + "\r\nDate: " + strDate + "\r\nTime: " + strTime + "\r\nDuration: " + Convert.ToString(intDuration) + " minutes\r\nPatient Name: " + strPatientName + "\r\nPhone Number: " + strPhoneNo + "\r\nDoctor ID: " + strDoctorId;
        }
    }

    [Serializable]
    public class InPersonApp : Appointment  //inherits from appointment class
    {
        //InPersonApp instance variables
        private string strRoomAllo;
        public bool blNurseReq;
        private string strNurseId;

        //inperson appointment property validation
        public string RoomAllo
        {
            get { return strRoomAllo; }
            set
            {
                if (value.Length == 0)
                {
                    throw (new TRIdMissing());
                }
                if (Char.ToLower(value[0]) != 't' || Char.ToLower(value[1]) != 'r')
                {
                    throw (new TRIdMissing());
                }
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                {
                    throw (new IncorrectRoomAllo());
                }
                strRoomAllo = value;
            }
        }
        public string NurseId
        {
            get { return strNurseId; }
            set
            {
                if (value.Length == 0)
                {
                    throw (new NSIdMissing());
                }
                if (Char.ToLower(value[0]) != 'n' || Char.ToLower(value[1]) != 's')
                {
                    throw (new NSIdMissing());
                }
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                {
                    throw (new IncorrectNurseId());
                }
                strNurseId = value;
            }
        }

        //constuctor with and without the nurse id
        public InPersonApp(string id, string date, string time, int duration, string patientName, string phoneNo, string doctorId, string roomAllocated, bool nurseReq, string nurseId) : base(id, date, time, duration, patientName, phoneNo, doctorId)     //constructer when nurse id is required
        {
            RoomAllo = roomAllocated;
            blNurseReq= nurseReq;
            NurseId = nurseId;
        }
        public InPersonApp(string id, string date, string time, int duration, string patientName, string phoneNo, string doctorId, string roomAllocated, bool nurseReq) : base(id, date, time, duration, patientName, phoneNo, doctorId)    //constructer whithout a nurse id
        {
            RoomAllo = roomAllocated;
            blNurseReq = nurseReq;
            strNurseId = "N/a";
        }

        public override string ToString()
        {
            if(!blNurseReq) return base.ToString() + "\r\nRoom Allocated: " + strRoomAllo + "\r\nNurse Required: No\r\nNurse ID: " + strNurseId;
            else return base.ToString() + "\r\nRoom Allocated: " + strRoomAllo + "\r\nNurse Required: Yes\r\nNurse ID: " + strNurseId;
        }
    }

    [Serializable]
    public class VirtualApp : Appointment   //inherits from appointment class
    {
        //VirtualApp instance variables
        public bool blVideoCall;
        private string strEmailAdd;

        //virtual appointment property validation
        public string EmailAdd
        {
            get { return strEmailAdd; }
            set
            {
                try
                {
                    MailAddress maMail = new MailAddress(value);
                    strEmailAdd = value;
                }
                catch
                {
                    throw (new IncorrectEmail());
                }
            }
        }

        //constructers for with and without the email address
        public VirtualApp(string id, string date, string time, int duration, string patientName, string phoneNo, string doctorId, bool videoCall, string emailAdd) : base(id, date, time, duration, patientName, phoneNo, doctorId)      //constructer with an email address
        {
            blVideoCall= videoCall;
            EmailAdd= emailAdd;
        }
        public VirtualApp(string id, string date, string time, int duration, string patientName, string phoneNo, string doctorId, bool videoCall) : base(id, date, time, duration, patientName, phoneNo, doctorId)   //constructer without an email address
        {
            blVideoCall = videoCall;
            strEmailAdd = "N/a";
        }

        public override string ToString()
        {
            if (!blVideoCall) return base.ToString() + "\r\nEmail Address: " + strEmailAdd + "\r\nVideo Call: No";
            else return base.ToString() + "\r\nEmail Address: " + strEmailAdd + "\r\nVideo Call: Yes";
        }
    }

    static class AppointmentViewer
    {
        //this list stores all types of appointments made and makes use of polymorphism 
        static public List<Appointment> arrAppointments { get; set; } = new List<Appointment>();
        static public List<string> strarrAppIds { get; set; } = new List<string>();

        static public void LoadAppointments()
        {
            //deserialize the appointmentlist.dat file and cast it to a list<appointments> object to be stored
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("AppointmentList.dat", FileMode.OpenOrCreate, FileAccess.Read);
            try
            {
                arrAppointments = (List<Appointment>)binaryFormatter.Deserialize(fileStream);
            }
            catch
            {
                Console.WriteLine("File Created");
            }
            fileStream.Close();
            //Console.WriteLine(arrAppointments[1].ToString());
        }
        static public void LoadFilterApp(bool inPerson)
        {
            LoadAppointments();     //load all appointments in the array before filtering
            for(int i=0;i<arrAppointments.Count;i++)
            {
                if (arrAppointments[i] is VirtualApp && inPerson)       //checks if appointment in the list is a VirtualApp object and if we are looking for an in person appointment delete it
                {
                    arrAppointments.RemoveAt(i);
                    i--;    //the list count is shortened so lowering i by 1 prevents skipping an item
                }
                else if (arrAppointments[i] is InPersonApp && !inPerson)       //checks if appointment in the list is a InPersonApp object and if we aren't looking for an in person appointment delete it
                {
                    arrAppointments.RemoveAt(i);
                    i--;    //the list count is shortened so lowering i by 1 prevents skipping an item
                }
            }
        }
        static public void LoadAppointmentIds()
        {
            //adds all appointment ids to seperate list
            foreach(Appointment appointment in arrAppointments)
            {
                strarrAppIds.Add(appointment.Id);
            }
        }
        static public void AddNewAppointment(Appointment newAppointment)
        {
            LoadAppointments();
            //update lists with new appointment info
            arrAppointments.Add(newAppointment);
            strarrAppIds.Add(newAppointment.Id);
            SaveAppointments();
        }
        static public void SaveAppointments()
        {
            //Save the list of appointments to a dat file using serialization
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("AppointmentList.dat", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fileStream, arrAppointments);
            fileStream.Close();
        }

    }
}
