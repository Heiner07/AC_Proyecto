using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class SistemaLoteriaChances
    {
        ConexionBD conexion = new ConexionBD();
        Usuario usuario = new Usuario();

        public Usuario IniciarSesion(String nombre, String contrasenia) {
            
            return usuario = conexion.IniciarSesion(nombre, contrasenia);    
        }

        

    }
}
