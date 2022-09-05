using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente("Pedro Mendez", "", "092333444", "32");
            Doctor doc1 = new Doctor("", "Dermatologo");
            AppointmentService.CreateAppointment(paciente1, doc1, "8 de octubre", DateTime.Now);
        }
    }
}
