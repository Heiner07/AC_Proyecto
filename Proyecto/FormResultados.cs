using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormResultados : Form
    {
        List<Sorteo> sorteos;
        SistemaLoteriaChances sistemaLoteriaChances;

        public FormResultados(SistemaLoteriaChances sistemaLoteriaChances)
        {
            InitializeComponent();
            this.sistemaLoteriaChances = sistemaLoteriaChances;
            CargarSorteos();
        }

        private void CargarSorteos()
        {
            sorteos = sistemaLoteriaChances.ObtenerSorteos();
            if (sorteos == null)
            {
                MessageBox.Show("Ocurrió un error recuperando los datos de la base de datos",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Sorteo ObtenerSorteoSeleccionado(String tipoSorteo, int numeroSorteo)
        {
            foreach (Sorteo sorteo in sorteos)
            {
                if (sorteo.tipoSorteo.Equals(tipoSorteo) && sorteo.ObtenerNumeroSorteo.Equals(numeroSorteo))
                {
                    return sorteo;
                }
            }
            return null;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            String tipo = (rbLoteria.Checked) ? "Lotería" : "Chances";
            int numeroSorteo = (int)nudNumeroSorteo.Value;
            int numeroFraccion = (int)nudNumeroFraccion.Value;
            int serieFraccion = (int)nudSerieFraccion.Value;
            int cantidadFracciones = (int)nudCantidadFracciones.Value;
            double montoGanado = 0;
            Sorteo sorteo = ObtenerSorteoSeleccionado(tipo, numeroSorteo);
            Boolean gano = false;
            if (sorteo != null)
            {
                List<Resultado> resultados = sorteo.planPremios.resultados;
                if (sorteo.estado)
                {
                    foreach(Resultado resultado in resultados)
                    {
                        if(resultado.numeroGanador == numeroFraccion &&
                            resultado.serieGanadora == serieFraccion)
                        {
                            if(cantidadFracciones <= sorteo.cantidadFracciones)
                            {
                                montoGanado = resultado.montoGanado * ((double)cantidadFracciones / sorteo.cantidadFracciones);
                            }
                            else
                            {
                                montoGanado = resultado.montoGanado;
                            }
                            lbMontoGanado.Text = Convert.ToString(montoGanado);
                            MessageBox.Show("¡Felicidades! Ha ganado "+montoGanado,
                                "Consultar resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gano = true;
                        }
                    }
                    if (!gano)
                    {
                        MessageBox.Show("Lastima, la fracción ingresado no fue premiada en el sorteo.",
                                "Consultar resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbMontoGanado.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("El sorteo no se ha jugado",
                    "Consultar resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El número de sorteo ingresado no existe",
                    "Consultar resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
