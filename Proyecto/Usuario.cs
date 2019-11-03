using System;

namespace Proyecto
{
    public class Usuario
    {
        public String NombreUsuario { get; set; }
        public int Rol { get; set; }

        
        public Usuario(String nombreUsuario, int rol) {
            this.NombreUsuario = nombreUsuario;
            this.Rol = rol;
        
        }

        public void EstablecerNombreUsuario(String nombre) {
            NombreUsuario = nombre;
        
        }

        public void EstablecerRol(int rolEntrante) {
            Rol = rolEntrante;        
        
        }
        public String ObtenerNombre => NombreUsuario;

        public int ObtenerRol => Rol;
    }
}
