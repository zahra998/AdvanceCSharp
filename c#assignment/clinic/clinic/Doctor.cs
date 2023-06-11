using System;
namespace clinic
{
    public class Doctor
    {

        public string DoctorName { get; set; }
        public string DoctorSpecializtion { get; set; }
        public Doctor(){
            }

        public Doctor(string dName, string dSpecializtion)
        {
            this.DoctorName = dName;
            this.DoctorSpecializtion = dSpecializtion;
        }
    }
}
