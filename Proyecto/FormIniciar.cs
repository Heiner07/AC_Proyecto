using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormIniciar : Form
    {
        public FormIniciar(SistemaLoteriaChances sistemaLoteriaChances)
        {
            InitializeComponent();
            CargarUltimosSorteos(sistemaLoteriaChances);
        }

        private void CargarUltimosSorteos(SistemaLoteriaChances sistemaLoteriaChances)
        {
            Sorteo sorteoLoteria = sistemaLoteriaChances.ObtenerUltimoSorteoTipo("Lotería");
            Sorteo sorteoChances = sistemaLoteriaChances.ObtenerUltimoSorteoTipo("Chances");
            if (sorteoLoteria != null)
            {
                Resultado[] resultados = ObtenerPremiosMayores(sorteoLoteria);
                lbNumeroLoteria.Text = $"Sorteo {sorteoLoteria.NumeroSorteo} - " +
                    $"{sorteoLoteria.Fecha.ToShortDateString()}";
                // Se establecen los valores del primer premio.
                lbLP1Num.Text = $"{resultados[0].NumeroGanador}";
                lbLP1Serie.Text = $"Serie:{resultados[0].SerieGanadora}";
                lbLP1Monto.Text = $"Monto:{resultados[0].MontoGanado}";
                // Se establecen los valores del segundo premio.
                lbLP2Num.Text = $"{resultados[1].NumeroGanador}";
                lbLP2Serie.Text = $"Serie:{resultados[1].SerieGanadora}";
                lbLP2Monto.Text = $"Monto:{resultados[1].MontoGanado}";
                // Se establecen los valores del tercer premio.
                lbLP3Num.Text = $"{resultados[2].NumeroGanador}";
                lbLP3Serie.Text = $"Serie:{resultados[2].SerieGanadora}";
                lbLP3Monto.Text = $"Monto:{resultados[2].MontoGanado}";
            }
            else
            {
                lbNumeroLoteria.Text = $"No hay datos de sorteos jugados.";
                // Se ocultan los labels
                lbLP1Num.Visible = false;
                lbLP1Serie.Visible = false;
                lbLP1Monto.Visible = false;
                lbLP2Num.Visible = false;
                lbLP2Serie.Visible = false;
                lbLP2Monto.Visible = false;
                lbLP3Num.Visible = false;
                lbLP3Serie.Visible = false;
                lbLP3Monto.Visible = false;
            }
            if (sorteoChances != null)
            {
                Resultado[] resultados = ObtenerPremiosMayores(sorteoChances);
                lbNumeroChances.Text = $"Sorteo {sorteoChances.NumeroSorteo} - " +
                    $"{sorteoChances.Fecha.ToShortDateString()}";
                // Se establecen los valores del primer premio.
                lbCP1Num.Text = $"{resultados[0].NumeroGanador}";
                lbCP1Serie.Text = $"Serie:{resultados[0].SerieGanadora}";
                lbCP1Monto.Text = $"Monto:{resultados[0].MontoGanado}";
                // Se establecen los valores del segundo premio.
                lbCP2Num.Text = $"{resultados[1].NumeroGanador}";
                lbCP2Serie.Text = $"Serie:{resultados[1].SerieGanadora}";
                lbCP2Monto.Text = $"Monto:{resultados[1].MontoGanado}";
                // Se establecen los valores del tercer premio.
                lbCP3Num.Text = $"{resultados[2].NumeroGanador}";
                lbCP3Serie.Text = $"Serie:{resultados[2].SerieGanadora}";
                lbCP3Monto.Text = $"Monto:{resultados[2].MontoGanado}";
            }
            else
            {
                lbNumeroChances.Text = $"No hay datos de sorteos jugados.";
                // Se ocultan los labels
                lbCP1Num.Visible = false;
                lbCP1Serie.Visible = false;
                lbCP1Monto.Visible = false;
                lbCP2Num.Visible = false;
                lbCP2Serie.Visible = false;
                lbCP2Monto.Visible = false;
                lbCP3Num.Visible = false;
                lbCP3Serie.Visible = false;
                lbCP3Monto.Visible = false;
            }
        }

        private Resultado[] ObtenerPremiosMayores(Sorteo sorteo)
        {
            Resultado[] premiosMayores = new Resultado[3];
            List<Resultado> resultados = sorteo.PlanPremios.Resultados;
            foreach(Resultado resultado in resultados)
            {
                if(sorteo.PlanPremios.Premios[0].MontoPremio == resultado.MontoGanado)
                {
                    premiosMayores[0] = resultado;
                }
                if (sorteo.PlanPremios.Premios[1].MontoPremio == resultado.MontoGanado)
                {
                    premiosMayores[1] = resultado;
                }
                if (sorteo.PlanPremios.Premios[2].MontoPremio == resultado.MontoGanado)
                {
                    premiosMayores[2] = resultado;
                }
            }

            return premiosMayores;
        }
    }
}
