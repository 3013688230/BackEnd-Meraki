using System;
using System.Collections.Generic;

#nullable disable

namespace APIMeraki.Entities
{
    public partial class Genero
    {
        public Genero()
        {
            Clientes = new HashSet<Cliente>();
            Conductores = new HashSet<Conductore>();
            Propietarios = new HashSet<Propietario>();
        }

        public int IdGenero { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Conductore> Conductores { get; set; }
        public virtual ICollection<Propietario> Propietarios { get; set; }
    }
}
