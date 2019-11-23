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
        public PlanPremios PlanPremios { get; set; }

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
