using System;
using System.Collections.Generic;

#nullable disable

namespace APIMeraki.Entities
{
    public partial class Servicio
    {
        public int IdServicio { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoCarga { get; set; }
        public int IdTipoVehiculo { get; set; }
        public string DireccionCarga { get; set; }
        public string DireccionEntrega { get; set; }
        public string PersonaRecibe { get; set; }
        public int CelularRecibe { get; set; }
        public int IdConductor { get; set; }
        public decimal? PrecioServicio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int IdEstadoServicio { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Conductore IdConductorNavigation { get; set; }
        public virtual EstadoServicio IdEstadoServicioNavigation { get; set; }
        public virtual TipoCarga IdTipoCargaNavigation { get; set; }
        public virtual TipoVehiculo IdTipoVehiculoNavigation { get; set; }
    }
}
