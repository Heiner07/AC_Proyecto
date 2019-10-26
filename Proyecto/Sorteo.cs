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
        public void jugarSorteo() { 
        
        }

       
        
        /*
         *Establece la fecha del sorteo correspondiente.
        */
        public void establecerFecha(DateTime fecha) {
            this.fecha = fecha;
        
        }

        /*
         *Establece la cantidad de fracciones del sorteo correspondiente.
        */
        public void establecerCantidadFracciones(int n)
        {
            cantidadFracciones = n;
        }

        /*
         *Establece el precio de la fracción del sorteo correspondiente.
        */
        public void establecerPrecioFraccion(int n)
        {
            precioFraccion = n;
        }

        /*
         *Establece la leyenda del sorteo correspondiente.
        */
        public void establecerLeyenda(String leyenda)
        {
            leyendaBillete = leyenda;
        }




        /*
         *Retorna el precio por fracción del sorteo correspondiente.
        */
        public int obtenerPrecioFraccion()
        {
            return precioFraccion;
        }

        /*
        *Retorna la leyenda del sorteo correspondiente.
       */
        public String obtenerLeyenda() {
            return leyendaBillete;
        }

        /*
         *Retorna la fecha del sorteo correspondiente.
        */
        public DateTime obtenerFecha()
        {
            return fecha;
        }

        /*
         *Retorna la cantidad de fracciones del sorteo correspondiente.
        */
        public int obtenerCantidadFracciones()
        {
            return cantidadFracciones;
        }

        /*
        *Retorna el numero de sorteo correspondiente.
       */
        public int obtenerNumeroSorteo()
        {
            return numeroSorteo;

        }

        /*
         *Retorna el tipo de sorteo correspondiente.
        */
        public String obtenerTipoSorteo()
        {
            return tipoSorteo;
        }

        /*
         *Retorna el estado del sorteo correspondiente.
        */
        public Boolean obtenerEstado()
        {
            return estado;
        }


    }
}
