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
    }
}
