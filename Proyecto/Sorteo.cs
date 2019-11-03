using System;

namespace Proyecto
{
    public class Sorteo
    {
        public int IdSorteo { get; set; }
        public int NumeroSorteo { get; set; }
        public int CantidadFracciones { get; set; }
        public int PrecioFraccion { get; set; }
        public String TipoSorteo { get; set; }
        public String LeyendaBillete { get; set; }
        public Boolean Estado { get; set; }
        public DateTime Fecha { get; set; }
        public PlanPremios PlanPremios {get;set;}

        public Sorteo()
        {

        }

        public Sorteo(int idSorteo, int numeroSorteo, String tipoSorteo, DateTime fecha, int cantidadFracciones,
            int precioFraccion, String leyendaBillete, Boolean estado,PlanPremios planPremios)
        {
            this.IdSorteo = idSorteo;
            this.NumeroSorteo = numeroSorteo;
            this.TipoSorteo = tipoSorteo;
            this.Fecha = fecha;
            this.CantidadFracciones = cantidadFracciones;
            this.PrecioFraccion = precioFraccion;
            this.LeyendaBillete = leyendaBillete;
            this.Estado = estado;
            this.PlanPremios = planPremios;
        }

        /*
        *Establece el tipo del sorteo correspondiente.
        */
        public void EstablecerNumeroSorteo(int numero)
        {
            NumeroSorteo = numero;

        }


        /*
        *Establece el tipo del sorteo correspondiente.
        */
        public void EstablecerTipoSorteo(String tipo)
        {
            TipoSorteo = tipo;

        }

        /*
         *Establece la fecha del sorteo correspondiente.
        */
        public void EstablecerFecha(DateTime fecha) {
            this.Fecha = fecha;
        
        }

        /*
         *Establece la cantidad de fracciones del sorteo correspondiente.
        */
        public void EstablecerCantidadFracciones(int n)
        {
            CantidadFracciones = n;
        }

        /*
         *Establece el precio de la fracción del sorteo correspondiente.
        */
        public void EstablecerPrecioFraccion(int n)
        {
            PrecioFraccion = n;
        }

        /*
         *Establece la leyenda del sorteo correspondiente.
        */
        public void EstablecerLeyenda(String leyenda)
        {
            LeyendaBillete = leyenda;
        }




        /*
         *Retorna el precio por fracción del sorteo correspondiente.
        */
        public int ObtenerPrecioFraccion => PrecioFraccion;

        /*
        *Retorna la leyenda del sorteo correspondiente.
       */
        public String ObtenerLeyenda => LeyendaBillete;

        /*
         *Retorna la fecha del sorteo correspondiente.
        */
        public DateTime ObtenerFecha => Fecha;

        /*
         *Retorna la cantidad de fracciones del sorteo correspondiente.
        */
        public int ObtenerCantidadFracciones => CantidadFracciones;

        /*
        *Retorna el numero de sorteo correspondiente.
       */
        public int ObtenerNumeroSorteo => NumeroSorteo;

        /*
         *Retorna el tipo de sorteo correspondiente.
        */
        public String ObtenerTipoSorteo => TipoSorteo;

        /*
         *Retorna el estado del sorteo correspondiente.
        */
        public Boolean ObtenerEstado => Estado;
        public int ObtenerIdSorteo => IdSorteo;
        public PlanPremios ObtenerPlanPremios => PlanPremios;

    }
}
