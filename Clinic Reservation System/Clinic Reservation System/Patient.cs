using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Reservation_System
{
    internal class Patient
    {

        public string name { get; set; }
        public int age { get; set; }

        public string ContactNumber { get; set; }



        public Patient(string name, int age, string ContactNumber)
        {

            this.name = name;
            this.age = age;
            this.ContactNumber = ContactNumber;

        }
    }
}
