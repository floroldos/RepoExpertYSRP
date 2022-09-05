using System;
using System.Text;

namespace Library
{
    public class IsAppointmentValid
    {
        public static bool ConsultaValida(Paciente paciente, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Agendando consulta...\n");
            bool isValid = true;

            if ((string.IsNullOrEmpty(paciente.Name)) || (string.IsNullOrEmpty(paciente.Id)) || (string.IsNullOrEmpty(paciente.Age)) || (string.IsNullOrEmpty(paciente.PhoneNumber)))
            {
                stringBuilder.Append("No se pudo concretar la consulta, error en los datos del paciente.\n");
                isValid = false;
            }
            if ((string.IsNullOrEmpty(doctor.DoctorName)) || (string.IsNullOrEmpty(doctor.Speciality)))
            {
                stringBuilder.Append("No se pudo concretar la consulta, error en los datos del doctor.\n");
                isValid = false;
            }
            if (isValid)
            {
                stringBuilder.Append("Consulta creada con exito.\n");
            }
            Console.WriteLine(stringBuilder.ToString());
            return isValid;
        }
    }
}