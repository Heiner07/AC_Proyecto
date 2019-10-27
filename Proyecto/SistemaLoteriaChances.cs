using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class SistemaLoteriaChances
    {
        public Usuario IniciarSesion(String nombre, String contrasenia) {
            ConexionBD verificarUsuario = new ConexionBD();
            return verificarUsuario.IniciarSesion(nombre, contrasenia);    
        }

        public List<Sorteo> ObtenerSorteos()
        {
            ConexionBD bd = new ConexionBD(); // Lo puse por el momento aquí (mientras se mueve a global)
            List<Sorteo> sorteos = bd.ObtenerSorteos();
            return sorteos;
        }
    }
}
