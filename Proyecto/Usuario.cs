using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Usuario
    {
        String nombreUsuario;
        int rol;

        public Usuario(String nombre, int rolUsuario) {
            nombreUsuario = nombre;
            rol = rolUsuario;
        
        }
        public String obtenerNombre() {
            return nombreUsuario;
        }

        public int obtenerRol() {
            return rol;
        
        }
    }
}
