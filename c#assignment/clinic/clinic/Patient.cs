using System;
namespace clinic
{
    public class Patient
    {
        public string PatientName { get; set; }
        public int PatientAge { get; set; }
        public string PatientContactNumber { get; set; }

        public Patient()
        {
        }


        public Patient(string pName, int pAge, string pContactNumber)
        {

            this.PatientName = pName;
            this.PatientAge = pAge;
            this.PatientContactNumber = pContactNumber;

        }
    }
}
