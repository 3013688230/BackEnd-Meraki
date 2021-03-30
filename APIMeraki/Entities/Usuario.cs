using System;
using System.Collections.Generic;

#nullable disable

namespace APIMeraki.Entities
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public int IdEstado { get; set; }

        public virtual EstadoUsuario IdEstadoNavigation { get; set; }
        public virtual Role IdRolNavigation { get; set; }
    }
}
