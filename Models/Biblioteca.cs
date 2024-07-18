using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_biblioteca.Models
{
    public class Biblioteca
    {
        private int Id {get; set; }
        public List<Libro> ListaLibros { get; set; }

        public Biblioteca()
        {
            ListaLibros = new List<Libro>();  // Inicializo la lista de libros en el constructor del objeto Biblioteca.  //
        }

        public void AgregarLibro(Libro nuevoLibro){
            ListaLibros.Add(nuevoLibro);
            Console.WriteLine($"El libro agregado es: {nuevoLibro.Titulo}");
        }

        public void EliminarLibro(Libro nuevoLibro){
            ListaLibros.Remove(nuevoLibro);
            Console.WriteLine($"El libro eliminado: {nuevoLibro.Titulo}");
        }

        public void MostrarLibro(){
            foreach(Libro libro in ListaLibros){
                Console.WriteLine($@"Libro {libro.Titulo} 
Autor {libro.Autor} 
año {libro.AñoPublicacion} 
codigo {libro.ISBN} 
genero {libro.Genero} 
precio {libro.Precio:c} COP");
            }
        }
    }
}