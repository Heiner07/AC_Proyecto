using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class SistemaLoteriaChances
    {
        public Usuario iniciarSesion(String nombre, String contrasenia) {
            ConexionBD verificarUsuario = new ConexionBD();
            return verificarUsuario.iniciarSesion(nombre, contrasenia);    
        }

        public List<Sorteo> ObtenerSorteos()
        {
            ConexionBD bd = new ConexionBD(); // Lo puse por el momento aquí (mientras se mueve a global)
            List<Sorteo> sorteos = bd.ObtenerSorteos();
            return sorteos;
        }
    }
}
