

namespace Proyecto
{
    public class Premio
    {
        public int MontoPremio { get; set; }
        public int CantidadPremio { get; set; }

        public Premio(int montoPremio, int cantidadPremio) {
            this.MontoPremio = montoPremio;
            this.CantidadPremio = cantidadPremio;
        }

        /*
        * Establece la cantidad de premios
        */
        public void EstablecerCantidad(int cantidad) {
            CantidadPremio = cantidad;
        
        }

       
        /*
        * Establece el monto del premio a asignar 
        */
        public void EstablecerMonto(int monto) {
            MontoPremio = monto;        
        }

        /*
         *Obtiene la cantidad del premio asignado
         */
        public int ObtenerCantidad => CantidadPremio;


        /*
         *Obtiene el monto del premio asignado 
         */
        public int ObtenerMonto => MontoPremio;
    }
}
