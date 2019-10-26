using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class SistemaLoteriaChances
    {
        public Usuario iniciarSesion(String nombre, String contrasenia) {
            ConexionBD verificarUsuario = new ConexionBD();
            return verificarUsuario.iniciarSesion(nombre, contrasenia);    
        }

    }
}
