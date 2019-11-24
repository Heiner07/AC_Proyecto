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
        
    }
}
