using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Sorteo
    {
        int idSorteo,numeroSorteo,cantidadFracciones,precioFraccion;
        String tipoSorteo, leyendaBillete;
        Boolean estado;
        DateTime fecha;

        /**
         * Se encarga de efectuar el sorteo correspondiente.
         */
        public void JugarSorteo() { 
        
        }


        /*
        *Establece el tipo del sorteo correspondiente.
        */
        public void EstablecerNumeroSorteo(int numero)
        {
            numeroSorteo = numero;

        }


        /*
        *Establece el tipo del sorteo correspondiente.
        */
        public void EstablecerTipoSorteo(String tipo)
        {
            tipoSorteo = tipo;

        }

        /*
         *Establece la fecha del sorteo correspondiente.
        */
        public void EstablecerFecha(DateTime fecha) {
            this.fecha = fecha;
        
        }

        /*
         *Establece la cantidad de fracciones del sorteo correspondiente.
        */
        public void EstablecerCantidadFracciones(int n)
        {
            cantidadFracciones = n;
        }

        /*
         *Establece el precio de la fracción del sorteo correspondiente.
        */
        public void EstablecerPrecioFraccion(int n)
        {
            precioFraccion = n;
        }

        /*
         *Establece la leyenda del sorteo correspondiente.
        */
        public void EstablecerLeyenda(String leyenda)
        {
            leyendaBillete = leyenda;
        }




        /*
         *Retorna el precio por fracción del sorteo correspondiente.
        */
        public int ObtenerPrecioFraccion => precioFraccion;

        /*
        *Retorna la leyenda del sorteo correspondiente.
       */
        public String ObtenerLeyenda => leyendaBillete;

        /*
         *Retorna la fecha del sorteo correspondiente.
        */
        public DateTime ObtenerFecha => fecha;

        /*
         *Retorna la cantidad de fracciones del sorteo correspondiente.
        */
        public int ObtenerCantidadFracciones => cantidadFracciones;

        /*
        *Retorna el numero de sorteo correspondiente.
       */
        public int ObtenerNumeroSorteo => numeroSorteo;

        /*
         *Retorna el tipo de sorteo correspondiente.
        */
        public String ObtenerTipoSorteo => tipoSorteo;

        /*
         *Retorna el estado del sorteo correspondiente.
        */
        public Boolean ObtenerEstado => estado;


    }
}
