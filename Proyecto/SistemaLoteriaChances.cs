using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class SistemaLoteriaChances
    {
        ConexionBD conexionBD = new ConexionBD();
        Usuario usuario;
        List<Sorteo> sorteos = null;

        public Usuario IniciarSesion(String nombre, String contrasenia) {
            this.usuario = conexionBD.IniciarSesion(nombre, contrasenia);
            return usuario;
        }

        public List<Sorteo> ObtenerSorteos()
        {       
            sorteos = conexionBD.ObtenerSorteos();
            return sorteos;
        }

        public Sorteo ObtenerSorteoSeleccionado(String tipoSorteo, int numeroSorteo)
        {
            if (sorteos != null)
            {
                foreach (Sorteo sorteo in sorteos)
                {
                    if (sorteo.tipoSorteo.Equals(tipoSorteo) && sorteo.ObtenerNumeroSorteo.Equals(numeroSorteo))
                    {
                        return sorteo;
                    }
                }
            }
            return null;
        }

        public Boolean CrearSorteo(Sorteo nuevoSorteo)
        {
            return conexionBD.InsertarSorteo(nuevoSorteo);
        }

        public Boolean EliminarSorteo(Sorteo sorteo) {
            return conexionBD.EliminarSorteo(sorteo);
        }

        public Boolean ModificarSorteo(Sorteo sorteo)
        {
            return conexionBD.ModificarSorteo(sorteo);

        }

        public Boolean JugarSorteo(Sorteo sorteo)
        {
            return conexionBD.InsertarResultadosSorteos(sorteo) &&
                conexionBD.EstablecerSorteoJugado(sorteo);
        }
    }
}
