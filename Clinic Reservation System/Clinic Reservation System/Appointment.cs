using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Reservation_System
{
    internal class Appointment
    {
        public Patient Patient { get; set; }
        public Doctor PatientDoctor { get; set; }

        public DateTime date { get; set; }
        public Appointment(Patient patient, Doctor doctor, DateTime date)
        {
            if (validateDate(date))
            {
                this.Patient = patient;
                this.PatientDoctor = doctor;
            }
            else
            {
                Console.WriteLine("invalid operation please choose another day ");
                return;
            }
        }

        public bool validateDate(DateTime date)
        {
            if (date.DayOfWeek.ToString() == "Friday" || date.DayOfWeek.ToString() == "Saturday")
            {
                return false;
            }
            else
            {
                this.date = date;
                return true;
            }
        }
    }
}
