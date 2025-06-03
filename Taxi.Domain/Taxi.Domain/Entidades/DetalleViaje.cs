using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Domain.Entidades
{
    public class DetalleViaje
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public int ViajeId { get; set; }
        public virtual DetalleViaje Viaje { get; set; }
    }
}
