using System;
using System.Collections.Generic;

#nullable disable

namespace APIMeraki.Entities
{
    public partial class EstadoUsuario
    {
        public EstadoUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdEstadoUsuario { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
