using System;

namespace Proyecto
{
    public class Sorteo
    {
        public int IdSorteo;
        public int NumeroSorteo;
        public int CantidadFracciones;
        public int PrecioFraccion;
        public String TipoSorteo;
        public String LeyendaBillete;
        public Boolean Estado;
        public DateTime Fecha;
        public PlanPremios PlanPremios;

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
    }
}
