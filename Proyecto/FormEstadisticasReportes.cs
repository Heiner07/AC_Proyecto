using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormEstadisticasReportes : Form
    {
        SistemaLoteriaChances sistemaLoteriaChances;
        DataTable dtSorteos;
        List<Sorteo> sorteos;
     
        String filtroTipoSorteos, filtroEstadisticas;

        public FormEstadisticasReportes(SistemaLoteriaChances sistemaLoteriaChances)
        {
            InitializeComponent();
            this.sistemaLoteriaChances = sistemaLoteriaChances;
            this.filtroTipoSorteos = "";
            this.filtroEstadisticas = "";
           
            InicializarTablas();
            EstablecerValoresTablaSorteos();
        }

        private void EstablecerValoresTablaSorteos()
        {
            dtSorteos = new DataTable();
            dtSorteos.Columns.Add("Tipo", typeof(string));
            dtSorteos.Columns.Add("Número", typeof(string));
            dtSorteos.Columns.Add("Fecha", typeof(string));
            dtSorteos.Columns.Add("Jugado", typeof(bool));
            dgvSorteos.DataSource = dtSorteos;
            DataGridViewButtonColumn btnResultado = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "Reporte",
                Name = "btn",
                Text = "resultados"
            };
            dgvSorteos.Columns.Add(btnResultado);
            DataGridViewButtonColumn btnPlanPremios = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "Reporte",
                Name = "btn2",
                Text = "plan de premios"
            };
            dgvSorteos.Columns.Add(btnPlanPremios);

            dgvSorteos.Columns[0].Width = 70;
            dgvSorteos.Columns[1].Width = 65;
            dgvSorteos.Columns[2].Width = 85;
            dgvSorteos.Columns[3].Width = 80;
            dgvSorteos.Columns[5].Width = 120;
            CargarSorteos();
        }

        private void CargarSorteos()
        {
            sorteos = sistemaLoteriaChances.ObtenerSorteos();
            dtSorteos.Clear();
            if (sorteos != null)
            {
                int cantidadSorteos = sorteos.Count;
                Sorteo sorteo;

                for (int i = 0; i < cantidadSorteos; i++)
                {
                    sorteo = sorteos[i];
                    dtSorteos.Rows.Add(new object[] { sorteo.TipoSorteo, sorteo.NumeroSorteo,
                        sorteo.Fecha.ToShortDateString(), sorteo.Estado });
                }
            }
            else
            {
                MessageBox.Show("Ocurrió un error recuperando los datos de la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarTablas()
        {
            
            InicializarTablaNumerosMasJugados();
            InicializarTablaNumerosMasGanadoresPrimer();
            InicializarTablaNumerosConMayorDineroRepartido();
            InicializarTablaPorcentajeNumeros();
        }

        private void InicializarTablaNumerosMasJugados()
        {
            DataTable dtNumerosMasJugados = new DataTable();
            dtNumerosMasJugados.Columns.Add("Número", typeof(string));
            dtNumerosMasJugados.Columns.Add("Cantidad", typeof(string));
            List<Resultado> numerosMasJugados = sistemaLoteriaChances.ObtenerTopNumerosMasJugados(filtroEstadisticas);
            if (numerosMasJugados != null)
            {
                int largoNumerosMasJugados = numerosMasJugados.Count;
                for (int i = 0; i < largoNumerosMasJugados; i++)
                {
                    dtNumerosMasJugados.Rows.Add(new object[] {
                        numerosMasJugados[i].NumeroGanador.ToString("00"),
                        numerosMasJugados[i].MontoGanado.ToString("#,#", CultureInfo.InvariantCulture) });
                }
                dgvNumerosMasJugados.DataSource = dtNumerosMasJugados;
            }
        }

        private void InicializarTablaNumerosMasGanadoresPrimer()
        {
            DataTable dtNumerosMasGanadores = new DataTable();
            dtNumerosMasGanadores.Columns.Add("Número", typeof(string));
            dtNumerosMasGanadores.Columns.Add("Cantidad", typeof(string));
            List<Resultado> numerosGanadores = sistemaLoteriaChances.ObtenerTopNumerosPrimerPremio(filtroEstadisticas);
            if (numerosGanadores != null)
            {
                int largoNumerosGanadores = numerosGanadores.Count;
                for (int i = 0; i < largoNumerosGanadores; i++)
                {
                    dtNumerosMasGanadores.Rows.Add(new object[] {
                        numerosGanadores[i].NumeroGanador.ToString("00"),
                        numerosGanadores[i].MontoGanado.ToString("#,#", CultureInfo.InvariantCulture)});
                }
                dgvTop5GanadoresPrimer.DataSource = dtNumerosMasGanadores;
            }
        }

        private void InicializarTablaNumerosConMayorDineroRepartido()
        {
            DataTable dtNumerosConMayorDineroRepartido = new DataTable();
            dtNumerosConMayorDineroRepartido.Columns.Add("Número", typeof(string));
            dtNumerosConMayorDineroRepartido.Columns.Add("Monto repartido", typeof(string));
            List<Resultado> numerosMayorDinero = sistemaLoteriaChances.ObtenerTopNumerosMasDineroRepartido(filtroEstadisticas);
            if (numerosMayorDinero != null)
            {
                int largoNumerosMayorDinero = numerosMayorDinero.Count;
                for (int i = 0; i < largoNumerosMayorDinero; i++)
                {
                    dtNumerosConMayorDineroRepartido.Rows.Add(new object[] {
                        numerosMayorDinero[i].NumeroGanador.ToString("00"),
                        numerosMayorDinero[i].MontoGanado.ToString("#,#", CultureInfo.InvariantCulture) });
                }
                dgvTopNumeroDineroRepartido.DataSource = dtNumerosConMayorDineroRepartido;
            }
            dgvTopNumeroDineroRepartido.Columns[1].Width = 150;
        }

        private void InicializarTablaPorcentajeNumeros()
        {
            DataTable dtProcentajeNumeros = new DataTable();
            dtProcentajeNumeros.Columns.Add("Número", typeof(string));
            dtProcentajeNumeros.Columns.Add("Porcentaje", typeof(String));
            List<PorcentajeNumeros> porcentajeNumeros = sistemaLoteriaChances.ObtenerPorcentajeAparicionNumeros();
            if (porcentajeNumeros != null)
            {
                for (int i = 0; i < 100; i++)
                {
                    PorcentajeNumeros resultado = porcentajeNumeros.Find(
                    delegate (PorcentajeNumeros pn)
                    {
                        return pn.Numero == i;
                    }
                    );
                    if (resultado != null)
                    {
                        dtProcentajeNumeros.Rows.Add(new object[] { i.ToString("00"), resultado.Porcentaje });
                    }
                    else { dtProcentajeNumeros.Rows.Add(new object[] { i.ToString("00"), 0}); }

                }
                
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                     dtProcentajeNumeros.Rows.Add(new object[] { i.ToString("00"), 0 }); 

                }

            }
            dgvPorcentajeAparicion.DataSource = dtProcentajeNumeros;
        }

        private void TbBusqueda_TextChanged(object sender, EventArgs e)
        {
            dtSorteos.DefaultView.RowFilter = $"{filtroTipoSorteos}Número LIKE '{tbBusqueda.Text}%'";
        }

        private void RbFiltroTodos_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "";
            filtroEstadisticas = "";
            InicializarTablas();
            TbBusqueda_TextChanged(sender, e);
        }

        private void RbFiltroLoteria_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "Tipo = 'Lotería' AND ";
            filtroEstadisticas = "Lotería";
            InicializarTablas();
            TbBusqueda_TextChanged(sender, e);
        }

        private void RbFiltroChances_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "Tipo = 'Chances' AND ";
            filtroEstadisticas = "Chances";
            InicializarTablas();
            TbBusqueda_TextChanged(sender, e);
        }

        private void ManejarReporteResultados(DataGridViewCellEventArgs e)
        {
            String tipoSorteo = dtSorteos.DefaultView[e.RowIndex]["Tipo"].ToString();
            int numeroSorteo = Convert.ToInt32(dtSorteos.DefaultView[e.RowIndex]["Número"].ToString());
            Sorteo sorteo = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipoSorteo, numeroSorteo);
            if (sorteo.Estado)
            {
                FormReporteResultados reporteResultados = new FormReporteResultados(sistemaLoteriaChances, sorteo);
                reporteResultados.ShowDialog();
            }
            else
            {
                MessageBox.Show("El sorteo no ha sido jugado. No hay resultados para mostrar",
                    "Reporte resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ManejarReportePlanPremios(DataGridViewCellEventArgs e)
        {
            String tipoSorteo = dtSorteos.DefaultView[e.RowIndex]["Tipo"].ToString();
            int numeroSorteo = Convert.ToInt32(dtSorteos.DefaultView[e.RowIndex]["Número"].ToString());
            Sorteo sorteo = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipoSorteo, numeroSorteo);
            if (sorteo.PlanPremios.Premios.Count > 0)
            {
                FormReportePlanPremios reportePlanPremios = new FormReportePlanPremios(sistemaLoteriaChances, sorteo);
                reportePlanPremios.ShowDialog();
            }
            else
            {
                MessageBox.Show("El sorteo no tiene plan de premios. No hay premios para mostrar",
                    "Reporte plan de premios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvSorteos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    ManejarReporteResultados(e);
                }
                else if (e.ColumnIndex == 1)
                {
                    ManejarReportePlanPremios(e);
                }
            }
        }
    }
}
