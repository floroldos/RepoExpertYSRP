using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    
    }
}

/*Anteriormente, no se cumplía el principio SRP ya que la clase Libro no cumplía una sola función, sino que
varias al mismo tiempo (se creaba el libro y la estantería en la misma clase). Se cambió esto creando una nueva
clase llamada ShelveBook.*/