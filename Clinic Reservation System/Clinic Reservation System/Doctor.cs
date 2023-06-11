using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Reservation_System
{
    internal class Doctor
    {
        public string name { get; set; }
        public string specializtion { get; set; }

        public Doctor(string name, string specializtion)
        {
            this.name = name;
            this.specializtion = specializtion;
        }
    }
}
