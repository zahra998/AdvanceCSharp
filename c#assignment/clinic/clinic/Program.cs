using System;

namespace clinic
{
    class MainClass
    {
        public static void Main(string[] args)
        {

        

            Clinic clinic = new Clinic();
            Doctor doctor = new Doctor();
            Patient patient = new Patient();

            Patient patient1 = new Patient("Ali", 25, "98765432");
            Patient patient2 = new Patient("Mohamed", 28, "98127311");
            Patient patient3 = new Patient("Yousef", 22, "91823711");
            Patient patient4 = new Patient("Bader", 20, "93237223");
            Patient patient5 = new Patient("Ali", 25, "98765432");

            clinic.patients.Add(patient1);
            clinic.patients.Add(patient2);
            clinic.patients.Add(patient3);
            clinic.patients.Add(patient4);
            clinic.patients.Add(patient5);

            Doctor doctor1 = new Doctor("Ali", "general");
            Doctor doctor2 = new Doctor("Sara", "general");
            Doctor doctor3 = new Doctor("Mahmood", "general");

            clinic.doctors.Add(doctor1);
            clinic.doctors.Add(doctor2);
            clinic.doctors.Add(doctor3);

            Appointment a1 = new Appointment("Ali", "Mohamed", 4);
           // clinic.appointments.Add(a1);

            clinic.DisplayDoctors();


           
        }
    }
}
