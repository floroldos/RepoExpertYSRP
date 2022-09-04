using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment(DateTime.Now, "Wall Street");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment( DateTime.Now, "Queen Street");
            Console.WriteLine(appointmentResult2);
        }
    }
}
