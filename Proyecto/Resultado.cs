using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Resultado
    {
        public int numeroGanador { get; set; }
        public int serieGanadora { get; set; }
        public int montoGanado { get; set; }


        public Resultado(int numeroGanador,int serieGanadora, int montoGanado) {
            this.numeroGanador = numeroGanador;
            this.serieGanadora = serieGanadora;
            this.montoGanado = montoGanado;
        
        }
        public int[] ObtenerResultado() {
            return new int[3] { numeroGanador, serieGanadora, montoGanado};

        }
    }
}
