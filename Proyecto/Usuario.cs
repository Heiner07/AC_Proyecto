using System;

namespace Proyecto
{
    public class Usuario
    {
        public String NombreUsuario;
        public int Rol;

        
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
