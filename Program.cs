using Gestor_biblioteca.Models;

var newLibro = new Libro("El señor de los anillos","J.R.R. Tolkien",1954,"32-45-c","Fantasia", 65000);
var newLibro1 = new Libro("El señor de los anillos","J.R.R. Tolkien",1954,"32-45-c","Fantasia", 65000);

newLibro.DescripcionDetallada();

var biblioteca = new Biblioteca();
biblioteca.AgregarLibro(newLibro);
biblioteca.AgregarLibro(newLibro1);


biblioteca.MostrarLibro();

biblioteca.EliminarLibro(newLibro);
biblioteca.MostrarLibro();


void Menu(){
    Console.WriteLine("1. Agregar libro");
    Console.WriteLine("2. Eliminar libro");
    Console.WriteLine("3. Mostrar libros");
    Console.WriteLine("4. Salir");
    Console.Write("Elija una opción: ");
    var opc = Console.Read();
    while ()
    {
        
    }
}