using System;
using System.Collections.Generic;

namespace clinic
{
    enum Days { Sat = 1, Sun, Mon, Tues, Wed, Thurs, Fri }
    public delegate bool AppointmentBookedDelegate(Patient patient);  // delegate

    public class Clinic
    {

        public event AppointmentBookedDelegate AppointmentBookedEvent; // event


        public List<Patient> patients = new List<Patient>();

        public List<Doctor> doctors = new List<Doctor>();

        List<Appointment> appointments = new List<Appointment>();




        public int doctoreChoosen, useinput, chooseDay;


        public void DisplayDoctors()
        {
            start:
            Console.WriteLine("\nPlease choose the number of a docture that you want to book with: ");
            Console.WriteLine("--------------------------------------------");

            for(int i = 1 ; i < doctors.Count;i++) {

                foreach (Doctor doctor in doctors)
                {
                    Console.WriteLine($" {i} - Doctor name: {doctor.DoctorName},  Specialization: {doctor.DoctorSpecializtion}");
                    i++;
                }
            }

            doctoreChoosen = int.Parse(Console.ReadLine().ToLower());

            // do the validation
            if (doctoreChoosen > 0 && doctoreChoosen <= doctors.Count) {

                RegisterPatient();
            }
            else
            {
                Console.WriteLine("Please enter a valied doctor number");
                goto start;
            }
        }
        public void RegisterPatient()
        {
            Console.WriteLine("");
            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine((int)day + ": " + day);
            }

            startPoint:
            Console.WriteLine("Choose a day by entering a number:  ");
            chooseDay = int.Parse(Console.ReadLine());

            if (chooseDay > 0 && chooseDay <= 7)
            {

                while (chooseDay == 1 || chooseDay == 7)
                {
                    Console.WriteLine("The clinic is close at the weekend please choose another day: ");

                    goto startPoint;
                }

                Console.WriteLine("Pationt name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Pationt age: ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Pationt contact number: ");
                string contact = Console.ReadLine().ToLower();


                Patient patient6 = new Patient(name, age, contact);

                patients.Add(patient6);

               // DisplayPatients();
            }
            else
            {
                Console.WriteLine("invaled day number: ");
                goto startPoint;
            }

        }
      
        public void DisplayPatients(Patient patient, AppointmentBookedDelegate cond)
        {

            /*
            Console.WriteLine("Pationt info");

            foreach (Patient p in patients)
            {
               

               // Console.WriteLine("\n" + title);
                Console.WriteLine("----------------------------------------------------\n");

                    if (cond(p))
                    {
                        Console.WriteLine($"Name: {patient.PatientName}\nAge: {patient.PatientAge}\n ContactNumber:{patient.PatientContactNumber}");

                    }

            }
            */
        }
        public void CreateAppointment(Doctor d,  Patient p)
        {
            /*

          List<Appointment> appointments = new List<Appointment> {

              new Appointment { DoctorName = d.DoctorName, PatientName = p.PatientName, Day = chooseDay}

          }; */

            Appointment a1 = new Appointment{DoctorName = d.DoctorName, PatientName = p.PatientName, Day = chooseDay};

            appointments.Add(a1);
        }
    }
}
