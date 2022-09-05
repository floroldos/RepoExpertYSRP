using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string DoctorName {get; set;}
        public string Speciality {get; set;}
        public Doctor(String doctorName, String speciality)
        {
            this.DoctorName = doctorName;
            this.Speciality = speciality;
        }
    }
}