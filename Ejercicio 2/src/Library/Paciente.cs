using System;

namespace Library
{
    public class Paciente
    {
        public string Name {get; set;}
        public string Id {get; set;}
        public string PhoneNumber {get; set;}
        public string Age {get; set;}
        public Paciente(String name, String id, String phoneNumber, String age)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Age = age;

        }
    }
}