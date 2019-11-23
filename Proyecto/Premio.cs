

namespace Proyecto
{
    public class Premio
    {
        public int MontoPremio { get; set; }
        public int CantidadPremio { get; set; }

        public Premio(int montoPremio, int cantidadPremio)
        {
            this.MontoPremio = montoPremio;
            this.CantidadPremio = cantidadPremio;
        }
    }
}
