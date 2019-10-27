using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Usuario
    {
        String nombreUsuario;
        int rol;

        

        public void establecerNombreUsuario(String nombre) {
            nombreUsuario = nombre;
        
        }

        public void establecerRol(int rolEntrante) {
            rol = rolEntrante;        
        
        }
        public String obtenerNombre() {
            return nombreUsuario;
        }

        public int obtenerRol() {
            return rol;
        
        }
    }
}
