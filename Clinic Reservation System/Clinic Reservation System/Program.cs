using System.Reflection.Metadata;

namespace Clinic_Reservation_System
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //create instance of the clinic
            Clinic clinic = new Clinic();
            //subscribe to the appointment event
            clinic.OnAppointmentBooked += Clinic_AppointmentBookedEvent;

            //create few doctors objects
            Doctor doctor1 = new Doctor("Salim", "Internal diseases");
            Doctor doctor2 = new Doctor("Joe", "General");
            Doctor doctor3 = new Doctor("Ahmed", "Dentist");
            Doctor doctor4 = new Doctor("John", "Pediatrics");
            Doctor doctor5 = new Doctor("Mosa", "Ophthalmology");

            clinic.RegisterDoctors(doctor1);
            clinic.RegisterDoctors(doctor2);
            clinic.RegisterDoctors(doctor3);
            clinic.RegisterDoctors(doctor4);
            clinic.RegisterDoctors(doctor5);



            Console.WriteLine("1) Display All Available Doctors\n2) Display Patients\n3) Book An Appointment");

            while (true)
            {
                string option = Console.ReadLine();


                switch (option)
                {
                    case "1":
                        clinic.DisplayDoctors();
                        break;
                    case "2":
                        clinic.DisplayPatients();
                        break;
                    case "3":
                        Console.WriteLine("Enter The patient name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the Patient Age: ");
                        //string sAge = Console.ReadLine();
                        int Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Patient Contact Number");
                        string ContactNumber = Console.ReadLine();
                        Patient patient = new Patient(name, Age, ContactNumber);
                        clinic.RegisterPatient(patient);

                        Console.WriteLine("Enter a date for the appointment, dd MM yyyy");
                        string sdate = Console.ReadLine();
                        DateTime date = DateTime.Parse(sdate);



                        Console.WriteLine("Enter the Doctor Number from 1 - 5");


                        int DocNo = int.Parse(Console.ReadLine());
                        if (DocNo > 0 && DocNo < 6)
                        {
                            clinic.AddAppointment(patient, clinic.GetDoctor(DocNo - 1), date);
                        }
                        else
                        {
                            Console.WriteLine("invalid option");
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }


        }

        private static void Clinic_AppointmentBookedEvent(Appointment a)
        {
            Console.WriteLine($"appointment created successfully \n" +
                $"patient name : {a.Patient.name} with the doctor: {a.PatientDoctor.name} on {a.date.ToString()}");
        }
    }
}