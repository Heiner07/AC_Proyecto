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

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            String tipo = (rbLoteria.Checked) ? "Lotería" : "Chances";
            int numeroSorteo = (int)nudNumeroSorteo.Value;
            int numeroFraccion = (int)nudNumeroFraccion.Value;
            int serieFraccion = (int)nudSerieFraccion.Value;
            int cantidadFracciones = (int)nudCantidadFracciones.Value;
            double montoGanado = 0;
            Sorteo sorteo = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipo, numeroSorteo);
            Boolean gano = false;
            if (sorteo != null)
            {
                List<Resultado> resultados = sorteo.PlanPremios.Resultados;
                if (sorteo.Estado)
                {
                    foreach(Resultado resultado in resultados)
                    {
                        if(resultado.NumeroGanador == numeroFraccion &&
                            resultado.SerieGanadora == serieFraccion)
                        {
                            if(cantidadFracciones <= sorteo.CantidadFracciones)
                            {
                                montoGanado = resultado.MontoGanado * ((double)cantidadFracciones / sorteo.CantidadFracciones);
                            }
                            else
                            {
                                montoGanado = resultado.MontoGanado;
                            }
                            lbMontoGanado.Text = montoGanado.ToString("#,#", CultureInfo.InvariantCulture);
                            MessageBox.Show("¡Felicidades! Ha ganado "+lbMontoGanado.Text,
                                "Consultar resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gano = true;
                        }
                    }
                    if (!gano)
                    {
                        MessageBox.Show("Lástima, la fracción ingresada no fue premiada en el sorteo.",
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
