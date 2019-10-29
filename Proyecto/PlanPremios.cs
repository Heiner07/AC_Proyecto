using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class PlanPremios
    {
        public int idSorteo { get; set; }
        public List<Resultado> resultados = new List<Resultado>();
        public List<Premio> premios = new List<Premio>();

        public void GenerarResultados()
        {
            List<int> montos = GenerarListaMontos();
            foreach (Premio premio in premios)
            {
                Console.WriteLine("Monto:" + premio.montoPremio + ", Cantidad: " + premio.cantidadPremio);
            }
        }

        private List<int> GenerarListaMontos()
        {
            List<int> montos = new List<int>();
            return montos;
        }

        public void EstablecerIdSorteo(int id) {
            idSorteo = id;
        
        }
        public int ObtenerIdSorteo => idSorteo;
        public List<Resultado> ObtenerResultados => resultados;

        public List<Premio> ObtenerPremios => premios;
    }
}
