using System;

namespace Library
{
    public class Consulta
    {
        public int NumeroConsulta = 0;
        public int IdConsulta {get; set;}
        public Paciente Patient {get; set;}
        public Doctor Medico {get; set;}
        public DateTime Fecha {get; set;}
        public string Place {get; set;}


        public Consulta(Doctor doctor, Paciente paciente, DateTime date, String lugar)
        {
            this.IdConsulta = NumeroConsulta;
            this.Fecha = date;
            this.Place = lugar;
            this.Medico = doctor;
            this.Patient = paciente;
            NumeroConsulta += 1;
        }


    }
}