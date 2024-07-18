using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_biblioteca.Models
{
    public class Libro : Publicacion
    {
        public string Autor {get; set; }
        public string ISBN {get; set; }
        public string Genero {get; set; }
        public double Precio {get; set; }

        public Libro(string titulo, string autor, int publicacion, string isbn, string genero, double precio )
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.AñoPublicacion= publicacion;
            this.ISBN = isbn;
            this.Genero = genero;
            this.Precio = precio;
        }

        public void DescripcionDetallada(){
            Console.WriteLine($"El libro {Titulo} escrito por {Autor} en el año {AñoPublicacion} identificado con {ISBN} del genero {Genero} con un valor de {Precio:c} COP");
        }
    }
}