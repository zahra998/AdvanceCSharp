using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Reservation_System
{
    internal interface IClinic
    {

        public void RegisterPatient(Patient patient);

        public void DisplayDoctors();

        public void DisplayPatients();
    }
}
