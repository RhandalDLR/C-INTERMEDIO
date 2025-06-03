using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Domain.Entidades
{
    public class GrupoUsuariosDetalle
    {
        public int Id { get; set; }
                public int GrupoUsuarioId { get; set; }
        public int UsuarioId { get; set; }
        public virtual GrupoUsuario GrupoUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        
        
        public GrupoUsuariosDetalle() { }
        
        public GrupoUsuariosDetalle(int grupoUsuarioId, int usuarioId)
        {
            GrupoUsuarioId = grupoUsuarioId;
            UsuarioId = usuarioId;
        }
    }
}
