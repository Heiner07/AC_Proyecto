using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormReporteResultados : Form
    {
        Sorteo sorteo;
        DataTable dtResultados;
        SistemaLoteriaChances sistemaLoteriaChances;

        public FormReporteResultados(SistemaLoteriaChances sistemaLoteriaChances, Sorteo sorteo)
        {
            InitializeComponent();
            this.sorteo = sorteo;
            this.sistemaLoteriaChances = sistemaLoteriaChances;
            lbTitulo.Text = $"Resultados del sorteo {sorteo.NumeroSorteo} de {sorteo.TipoSorteo}";
            EstablecerValoresTablaResultadosSorteo();
            CargarResultados();
        }

        private void EstablecerValoresTablaResultadosSorteo()
        {
            dtResultados = new DataTable();
            dtResultados.Columns.Add("Serie", typeof(string));
            dtResultados.Columns.Add("Número", typeof(string));
            dtResultados.Columns.Add("Premio", typeof(string));
            dgvResultadosSorteo.DataSource = dtResultados;
        }

        private void CargarResultados()
        {
            List<Resultado> resultados = sorteo.PlanPremios.resultados;
            foreach(Resultado resultado in resultados)
            {
                dtResultados.Rows.Add(new object[] {
                    resultado.SerieGanadora.ToString("000"),
                    resultado.NumeroGanador.ToString("00"),
                    resultado.MontoGanado.ToString("#,#", CultureInfo.InvariantCulture)});
            }
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtExportar_Click(object sender, EventArgs e)
        {
            if (sistemaLoteriaChances.GenerarReporteResultadosSorteo(sorteo))
            {
                MessageBox.Show("¡El reporte se generó correctamente! " +
                    $"Se generó el archivo \"Resultados - {sorteo.TipoSorteo}{sorteo.NumeroSorteo}.pdf\" en el escritorio.",
                        "Reporte resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error generando el reporte. " +
                    $"Se intentó crear con el nombre: \"Resultados - {sorteo.TipoSorteo}{sorteo.NumeroSorteo}.pdf\"\n" +
                    "El error puede suceder por alguna de las siguientes causas:\n" +
                    "* Existe un archivo con el mismo nombre y no se puede modificar.\n" +
                    "* Existe un archivo con el mismo nombre y está siendo utilizado.\n" +
                    "* No tiene permisos para escribir en la carpeta de destino(Escritorio).\n" +
                    "* No tiene espacio suficiente para crear el archivo.\n" +
                    "* Error interno del programa.\n",
                        "Reporte resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
