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
    }
}
