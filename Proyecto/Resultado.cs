﻿

namespace Proyecto
{
    public class Resultado
    {
        public int NumeroGanador { get; set; }
        public int SerieGanadora { get; set; }
        public int MontoGanado { get; set; }


        public Resultado(int numeroGanador,int serieGanadora, int montoGanado) {
            this.NumeroGanador = numeroGanador;
            this.SerieGanadora = serieGanadora;
            this.MontoGanado = montoGanado;
        
        }
        public int[] ObtenerResultado() {
            return new int[3] { NumeroGanador, SerieGanadora, MontoGanado};

        }
    }
}
