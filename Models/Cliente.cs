using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FullStackMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
      public string Nombre { get; set; }

        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Empresa { get; set; }

        public List<Subcliente> Subclientes { get; set; }
        //public ICollection<Subcliente> Subclientes { get; set; }
    }
}
