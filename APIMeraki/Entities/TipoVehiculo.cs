using System;
using System.Collections.Generic;

#nullable disable

namespace APIMeraki.Entities
{
    public partial class TipoVehiculo
    {
        public TipoVehiculo()
        {
            Servicios = new HashSet<Servicio>();
        }

        public int IdTipoVehiculo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
