using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static bool CreateAppointment(Paciente paciente, Doctor doctor, string lugar, DateTime fecha)
        {
            bool ValidateAppointment = IsAppointmentValid.ConsultaValida(paciente, doctor);
            if (ValidateAppointment)
            {
                Console.WriteLine("La consulta ha sido creada.");
                return true;

            }
            else
            {
                Console.WriteLine("Ha ocurrido un error al crear la consulta.");
                return false;
            }
        }

    }
}
