using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            ShelveBook Ubicacion1 = new ShelveBook("A", "7", book1);
            ShelveBook Ubicacion2 = new ShelveBook("B", "3", book2);
        }
    }
}