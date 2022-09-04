using System;
using System.Text;

namespace Library
{
    public class DoctorInfo
    {
        public string doctorName {get; set;}
        public string speciality {get; set;}
        public string Doc(string doctorName, string speciality)
        {
            StringBuilder stringBuilder = new StringBuilder("Guardando datos...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(speciality))
            {
                stringBuilder.Append("Unable to schedule appointment, 'speciality' is not valid\n");
                isValid = false;
            }
            return StringBuilder;
        }
    }
}