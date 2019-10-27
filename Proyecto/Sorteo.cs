using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Sorteo
    {
        public int idSorteo { get; set; }
        public int numeroSorteo { get; set; }
        public int cantidadFracciones { get; set; }
        public int precioFraccion { get; set; }
        public String tipoSorteo { get; set; }
        public String leyendaBillete { get; set; }
        public Boolean estado { get; set; }
        public DateTime fecha { get; set; }

        public Sorteo()
        {

        }

        public Sorteo(int idSorteo, int numeroSorteo, String tipoSorteo, DateTime fecha, int cantidadFracciones,
            int precioFraccion, String leyendaBillete, Boolean estado)
        {
            this.idSorteo = idSorteo;
            this.numeroSorteo = numeroSorteo;
            this.tipoSorteo = tipoSorteo;
            this.fecha = fecha;
            this.cantidadFracciones = cantidadFracciones;
            this.precioFraccion = precioFraccion;
            this.leyendaBillete = leyendaBillete;
            this.estado = estado;
        }

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
