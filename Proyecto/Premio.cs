using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Premio
    {
        public int montoPremio { get; set; }
        public int cantidadPremio { get; set; }

        public Premio(int montoPremio, int cantidadPremio) {
            this.montoPremio = montoPremio;
            this.cantidadPremio = cantidadPremio;
        }

        /*
        * Establece la cantidad de premios
        */
        public void EstablecerCantidad(int cantidad) {
            cantidadPremio = cantidad;
        
        }

       
        /*
        * Establece el monto del premio a asignar 
        */
        public void EstablecerMonto(int monto) {
            montoPremio = monto;        
        }

        /*
         *Obtiene la cantidad del premio asignado
         */
        public int ObtenerCantidad => cantidadPremio;


        /*
         *Obtiene el monto del premio asignado 
         */
        public int ObtenerMonto => montoPremio;
    }
}
