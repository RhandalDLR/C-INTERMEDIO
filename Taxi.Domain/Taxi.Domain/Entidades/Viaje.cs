using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Domain.Entidades
{
    public class Viaje
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
      
        public int Calificacion { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Taxi Taxi { get; set; }
    }
}
