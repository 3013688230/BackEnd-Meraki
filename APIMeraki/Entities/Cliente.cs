using System;
using System.Collections.Generic;

#nullable disable

namespace APIMeraki.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            Servicios = new HashSet<Servicio>();
        }

        public int IdCliente { get; set; }
        public int IdTipoDocumento { get; set; }
        public int IdGenero { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumeroDocumento { get; set; }
        public int Celular { get; set; }

        public virtual Genero IdGeneroNavigation { get; set; }
        public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
