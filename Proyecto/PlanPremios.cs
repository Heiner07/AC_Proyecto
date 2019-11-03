using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class PlanPremios
    {
        public int IdSorteo;
        public List<Resultado> resultados = new List<Resultado>();
        public List<Premio> premios = new List<Premio>();

        public void GenerarResultados(String tipo)
        {
            List<int> montos = GenerarListaMontos();
            int numero = 0;
            int serie = 0;
            int monto = 0;
            int indice = 0;
            Random random = new Random();
            while (montos.Count > 0)
            {
                indice = (tipo.Equals("Chances"))? 0 : random.Next(0, montos.Count);
                numero = random.Next(0, 99);
                serie = random.Next(0, 999);
                monto = montos[indice];
                montos.RemoveAt(indice);
                resultados.Add(new Resultado(numero, serie, monto));
            }
        }

        private List<int> GenerarListaMontos()
        {
            List<int> montos = new List<int>();
            int cantidad = 0;
            foreach(Premio premio in premios){
                cantidad = premio.CantidadPremio;
                while (cantidad > 0)
                {
                    montos.Add(premio.MontoPremio);
                    cantidad--;
                }
            }
            return montos;
        }

        public void EstablecerIdSorteo(int id) {
            IdSorteo = id;
        
        }
        public int ObtenerIdSorteo => IdSorteo;
        public List<Resultado> ObtenerResultados => resultados;

        public List<Premio> ObtenerPremios => premios;
    }
}
