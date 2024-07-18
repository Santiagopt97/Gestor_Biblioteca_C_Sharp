using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_biblioteca.Models
{
    public class Publicacion
    {
        private int Id {get; set; }
        public string? Titulo {get; set; }
        public int AñoPublicacion {get; set; }
    }
}