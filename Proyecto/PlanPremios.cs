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


        
       /* public List<Resultado> GenerarResultados() { 
            
        
        
        }*/

        public List<Resultado> ObtenerResultados()
        {

            return resultados;

        }
    }
}
