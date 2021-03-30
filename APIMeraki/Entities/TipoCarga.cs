using System;
using System.Collections.Generic;

#nullable disable

namespace APIMeraki.Entities
{
    public partial class TipoCarga
    {
        public TipoCarga()
        {
            Servicios = new HashSet<Servicio>();
        }

        public int IdTipoCarga { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
