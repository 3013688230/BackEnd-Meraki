using System;
using System.Collections.Generic;

#nullable disable

namespace APIMeraki.Entities
{
    public partial class EstadoServicio
    {
        public EstadoServicio()
        {
            Servicios = new HashSet<Servicio>();
        }

        public int IdEstadoServicio { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
