using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Reservation_System
{

    internal class Clinic : IClinic
    {

        public delegate void AppointmentBookedDelegate(Appointment a);
        public event AppointmentBookedDelegate OnAppointmentBooked;



        private List<Doctor> doctors = new List<Doctor>();
        private List<Patient> patients = new List<Patient>();
        private List<Appointment> appointments = new List<Appointment>();

        public Clinic()
        {
            Doctor doctor1 = new Doctor("Salim", "Internal diseases");
            Doctor doctor2 = new Doctor("Joe", "General");
            Doctor doctor3 = new Doctor("Ahmed", "Dentist");
            Doctor doctor4 = new Doctor("John", "Pediatrics");
            Doctor doctor5 = new Doctor("Mosa", "Ophthalmology");

            doctors.Add(doctor1);
            doctors.Add(doctor2);
            doctors.Add(doctor3);
            doctors.Add(doctor4);
            doctors.Add(doctor5);

        }
        public void DisplayDoctors()
        {
            Console.WriteLine("\n######### List of Clinic's Doctors #########");
            foreach (Doctor doctor in doctors)
            {
                Console.WriteLine($"Doctor name: {doctor.name}\nSpecialization{doctor.specializtion}");
                Console.WriteLine("--------------------------------------------");
            }
        }

        public void DisplayPatients()
        {
            Console.WriteLine("\n######### List of Clinic's Patients #########");
            foreach (Patient patient in patients)
            {
                Console.WriteLine($"Name: {patient.name}\nAge: {patient.age}\n ContactNumber:{patient.ContactNumber}\n");
                Console.WriteLine("--------------------------------------------");
            }
        }

        public void RegisterPatient(Patient patient)
        {


            patients.Add(patient);
            

        }
        public void RegisterDoctors(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void AddAppointment(Patient p, Doctor doc, DateTime d)
        {
            var ap = new Appointment(p, doc, d);
            appointments.Add(ap);
            if (OnAppointmentBooked != null)
            {
                OnAppointmentBooked(ap);
            }
        }
        public void BookingAppointment(Appointment a)
        {
            OnAppointmentBooked?.Invoke(a);
        }

        public Doctor GetDoctor(int index)
        {
            return doctors[index];
        }


    }
}
