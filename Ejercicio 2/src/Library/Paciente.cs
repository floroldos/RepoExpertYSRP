using System;
using System.Text;

namespace Library
{
    public class PatientInfo
    {
        public string Name {get; set;}
        public string Id {get; set;}
        public string PhoneNumber {get; set;}

        public static string Patient(string name, string id, string phoneNumber)
        
        {
            StringBuilder stringBuilder = new StringBuilder("Guardando datos...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("No se ha podido guardar. 'Nombre' es inválido.\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("No se ha podido guardar. 'ID' es inválido.\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("No se ha podido guardar. 'Nombre' es inválido.\n");
                isValid = false;
            }
            if (isValid)
            {
                stringBuilder.Append("Los datos han sido guardados.");
            }
        
        return stringBuilder.ToString();

        }
    }
}