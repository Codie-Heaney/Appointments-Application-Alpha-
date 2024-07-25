using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSys_Alpha
{
    class AppointmentLengthExceeded : Exception
    {
        private static string strMsg = "Appointment Duration cannot be over 60 minutes";
        public AppointmentLengthExceeded() : base(strMsg) { }
    }

    class IncorrectPatientName : Exception
    {
        private static string strMsg = "Patient Name must only contain letters";

        public IncorrectPatientName() : base(strMsg) { }
    }
    class IncorrectTelephone : Exception
    {
        private static string strMsg = "Telephone number must only contain 11 to 9 digits";

        public IncorrectTelephone() : base(strMsg) { }
    }

    class GPIdMissing : Exception
    {
        private static string strMsg = "Doctors ID must begin with GP";

        public GPIdMissing() : base(strMsg) { }
    }
    class IncorrectGPId : Exception
    {
        private static string strMsg = "Doctors ID must contain only letters and numbers";

        public IncorrectGPId() : base(strMsg) { }
    }

    class IncorrectId : Exception
    {
        private static string strMsg = "ID must only contain numbers";

        public IncorrectId() : base(strMsg) { }
    }

    class DuplicateId : Exception
    {
        private static string strMsg = "ID is already in use";

        public DuplicateId() : base(strMsg) { }
    }
    class IncorrectSurname : Exception
    {
        private static string strMsg = "Patient Name requires a surname";

        public IncorrectSurname() : base(strMsg) { }
    }
    class IncorrectRoomAllo : Exception
    {
        private static string strMsg = "Room Allocated must only contain letters and numbers";

        public IncorrectRoomAllo() : base(strMsg) { }
    }
    class IncorrectNurseId : Exception
    {
        private static string strMsg = "Nurse ID must only contain letters and numbers";

        public IncorrectNurseId() : base(strMsg) { }
    }
    class NSIdMissing : Exception
    {
        private static string strMsg = "Nurse ID must start with NS";

        public NSIdMissing() : base(strMsg) { }
    }
    class TRIdMissing : Exception
    {
        private static string strMsg = "Room Allocated must start with TR";

        public TRIdMissing() : base(strMsg) { }
    }
    class IncorrectEmail : Exception
    {
        private static string strMsg = "Email is not a valid email address";

        public IncorrectEmail() : base(strMsg) { }
    }
}
