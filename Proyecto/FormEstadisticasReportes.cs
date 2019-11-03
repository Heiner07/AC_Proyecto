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
           
            inicializarTablas();
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
                    dtSorteos.Rows.Add(new object[] { sorteo.tipoSorteo, sorteo.numeroSorteo,
                        sorteo.fecha.ToShortDateString(), sorteo.estado });
                }
            }
            else
            {
                MessageBox.Show("Ocurrió un error recuperando los datos de la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inicializarTablas()
        {
            
            inicializarTablaNumerosMasJugados();
            inicializarTablaNumerosMasGanadoresPrimer();
            inicializarTablaNumerosConMayorDineroRepartido();
            inicializarTablaPorcentajeNumeros();
        }

        private void inicializarTablaNumerosMasJugados()
        {
            DataTable dtNumerosMasJugados = new DataTable();
            dtNumerosMasJugados.Columns.Add("Número", typeof(int));
            dtNumerosMasJugados.Columns.Add("Cantidad", typeof(int));
            List<Resultado> numerosMasJugados = sistemaLoteriaChances.ObtenerTopNumerosMasJugados(filtroEstadisticas);
            if (numerosMasJugados != null)
            {
                int largoNumerosMasJugados = numerosMasJugados.Count;
                for (int i = 0; i < largoNumerosMasJugados; i++)
                {
                    dtNumerosMasJugados.Rows.Add(new object[] { numerosMasJugados[i].numeroGanador, numerosMasJugados[i].montoGanado });
                }
                dgvNumerosMasJugados.DataSource = dtNumerosMasJugados;
            }
        }

        private void inicializarTablaNumerosMasGanadoresPrimer()
        {
            DataTable dtNumerosMasGanadores = new DataTable();
            dtNumerosMasGanadores.Columns.Add("Número", typeof(int));
            dtNumerosMasGanadores.Columns.Add("Cantidad", typeof(int));
            List<Resultado> numerosGanadores = sistemaLoteriaChances.ObtenerTopNumerosPrimerPremio(filtroEstadisticas);
            if (numerosGanadores != null)
            {
                int largoNumerosGanadores = numerosGanadores.Count;
                for (int i = 0; i < largoNumerosGanadores; i++)
                {
                    dtNumerosMasGanadores.Rows.Add(new object[] { numerosGanadores[i].numeroGanador, numerosGanadores[i].montoGanado});
                }
                dgvTop5GanadoresPrimer.DataSource = dtNumerosMasGanadores;
            }
        }

        private void inicializarTablaNumerosConMayorDineroRepartido()
        {
            DataTable dtNumerosConMayorDineroRepartido = new DataTable();
            dtNumerosConMayorDineroRepartido.Columns.Add("Número", typeof(int));
            dtNumerosConMayorDineroRepartido.Columns.Add("Monto repartido", typeof(int));
            List<Resultado> numerosMayorDinero = sistemaLoteriaChances.ObtenerTopNumerosMasDineroRepartido(filtroEstadisticas);
            if (numerosMayorDinero != null)
            {
                int largoNumerosMayorDinero = numerosMayorDinero.Count;
                for (int i = 0; i < largoNumerosMayorDinero; i++)
                {
                    dtNumerosConMayorDineroRepartido.Rows.Add(new object[] { numerosMayorDinero[i].numeroGanador, numerosMayorDinero[i].montoGanado });
                }
                dgvTopNumeroDineroRepartido.DataSource = dtNumerosConMayorDineroRepartido;
            }
        }

        private void inicializarTablaPorcentajeNumeros()
        {
            DataTable dtProcentajeNumeros = new DataTable();
            dtProcentajeNumeros.Columns.Add("Número", typeof(int));
            dtProcentajeNumeros.Columns.Add("Porcentaje", typeof(Double));
            List<PorcentajeNumeros> porcentajeNumeros = sistemaLoteriaChances.ObtenerPorcentajeAparicionNumeros();
            if (porcentajeNumeros != null)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(porcentajeNumeros.Count);
                    PorcentajeNumeros resultado = porcentajeNumeros.Find(
                    delegate (PorcentajeNumeros pn)
                    {
                        return pn.numero == i;
                    }
                    );
                    if (resultado != null)
                    {
                        dtProcentajeNumeros.Rows.Add(new object[] { i, resultado.porcentaje });
                    }
                    else { dtProcentajeNumeros.Rows.Add(new object[] { i, 0}); }

                }
                
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                     dtProcentajeNumeros.Rows.Add(new object[] { i, 0 }); 

                }

            }
            dgvPorcentajeAparicion.DataSource = dtProcentajeNumeros;
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            dtSorteos.DefaultView.RowFilter = $"{filtroTipoSorteos}Número LIKE '{tbBusqueda.Text}%'";
            inicializarTablas();
        }



     
        private void rbFiltroTodos_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "";
            filtroEstadisticas = "";
            tbBusqueda_TextChanged(sender, e);
        }

        private void rbFiltroLoteria_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "Tipo = 'Lotería' AND ";
            filtroEstadisticas = "Lotería";
            tbBusqueda_TextChanged(sender, e);
        }

        private void rbFiltroChances_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "Tipo = 'Chances' AND ";
            filtroEstadisticas = "Chances";
            tbBusqueda_TextChanged(sender, e);
        }

        private void dgvSorteos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    String tipoSorteo = dtSorteos.DefaultView[e.RowIndex]["Tipo"].ToString();
                    int numeroSorteo = Convert.ToInt32(dtSorteos.DefaultView[e.RowIndex]["Número"].ToString());
                    Sorteo sorteo = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipoSorteo, numeroSorteo);
                    if (sorteo.estado)
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
                else if (e.ColumnIndex == 1)
                {
                    String tipoSorteo = dtSorteos.DefaultView[e.RowIndex]["Tipo"].ToString();
                    int numeroSorteo = Convert.ToInt32(dtSorteos.DefaultView[e.RowIndex]["Número"].ToString());
                    Sorteo sorteo = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipoSorteo, numeroSorteo);
                    if (sorteo.planPremios.premios.Count > 0)
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
            }
        }
    }
}
