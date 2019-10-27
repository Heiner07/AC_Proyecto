using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Usuario
    {
        public String nombreUsuario { get; set; }
        public int rol { get; set; }

        
        public Usuario(String nombreUsuario, int rol) {
            this.nombreUsuario = nombreUsuario;
            this.rol = rol;
        
        }

        public void EstablecerNombreUsuario(String nombre) {
            nombreUsuario = nombre;
        
        }

        public void EstablecerRol(int rolEntrante) {
            rol = rolEntrante;        
        
        }
        public String ObtenerNombre => nombreUsuario;

        public int ObtenerRol => rol;
    }
}
