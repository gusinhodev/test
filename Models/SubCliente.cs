using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FullStackMVC.Models
{
    public class Subcliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        //public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Empresa { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
