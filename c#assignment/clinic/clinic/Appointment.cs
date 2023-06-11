using System;
namespace clinic
{
    public class Appointment
    {

        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public int Day { get; set; }


        public Appointment()
        {
        }

        public Appointment(string dName, string pName, int day)
        {
            this.DoctorName = dName;
            this.PatientName = pName;
            this.Day = Day;

        }
    }
}
