using System;
using System.Collections.Generic;
using System.Globalization;
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
            lbFelicidades.Visible = false;
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

        private void CalcularMontoGanado(List<Resultado> resultados, int numeroFraccion,
            int serieFraccion, int cantidadFracciones, int cantidadFraccionesSorteo)
        {
            Boolean gano = false;
            double montoGanado = 0;
            int premios = 0;
            foreach (Resultado resultado in resultados)
            {
                if (resultado.NumeroGanador == numeroFraccion &&
                    resultado.SerieGanadora == serieFraccion)
                {
                    if (cantidadFracciones <= cantidadFraccionesSorteo)
                    {
                        montoGanado += resultado.MontoGanado * ((double)cantidadFracciones / cantidadFraccionesSorteo);
                    }
                    else
                    {
                        montoGanado += resultado.MontoGanado;
                    }
                    premios++;
                    gano = true;
                }
            }
            if (!gano)
            {
                MessageBox.Show("Lástima, la fracción ingresada no fue premiada en el sorteo.",
                        "Consultar resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbFelicidades.Visible = true;
                lbMontoGanado.Text = montoGanado.ToString("#,#", CultureInfo.InvariantCulture);
                lbPremiosGanados.Text = premios.ToString();
            }
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            String tipo = (rbLoteria.Checked) ? "Lotería" : "Chances";
            int numeroSorteo = (int)nudNumeroSorteo.Value;
            int numeroFraccion = (int)nudNumeroFraccion.Value;
            int serieFraccion = (int)nudSerieFraccion.Value;
            int cantidadFracciones = (int)nudCantidadFracciones.Value;
            Sorteo sorteo = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipo, numeroSorteo);
            lbFelicidades.Visible = false;
            lbMontoGanado.Text = "0";
            lbPremiosGanados.Text = "0";
            if (sorteo != null)
            {
                List<Resultado> resultados = sorteo.PlanPremios.Resultados;
                if (sorteo.Estado)
                {
                    CalcularMontoGanado(resultados, numeroFraccion, serieFraccion,
                        cantidadFracciones, sorteo.CantidadFracciones);
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
