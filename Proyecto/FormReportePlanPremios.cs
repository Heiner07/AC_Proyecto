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
    public partial class FormReportePlanPremios : Form
    {
        Sorteo sorteo;
        DataTable dtPlanPremios;
        SistemaLoteriaChances sistemaLoteriaChances;

        public FormReportePlanPremios(SistemaLoteriaChances sistemaLoteriaChances, Sorteo sorteo)
        {
            InitializeComponent();
            this.sorteo = sorteo;
            this.sistemaLoteriaChances = sistemaLoteriaChances;
            lbTitulo.Text = $"Plan de premios del sorteo {sorteo.numeroSorteo} de {sorteo.tipoSorteo}";
            EstablecerValoresTablaPlanPremiosSorteo();
            CargarPlanPremios();
        }

        private void EstablecerValoresTablaPlanPremiosSorteo()
        {
            dtPlanPremios = new DataTable();
            dtPlanPremios.Columns.Add("Premio", typeof(string));
            dtPlanPremios.Columns.Add("Cantidad", typeof(string));
            dgvPlanPremiosSorteo.DataSource = dtPlanPremios;
        }

        private void CargarPlanPremios()
        {
            List<Premio> premios = sorteo.planPremios.premios;
            foreach (Premio premio in premios)
            {
                dtPlanPremios.Rows.Add(new object[] { premio.montoPremio, premio.cantidadPremio });
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            if (sistemaLoteriaChances.GenerarReportePlanPremiosSorteo(sorteo))
            {
                MessageBox.Show("¡El reporte se generó correctamente! " +
                    $"Se generó el archivo \"PlanDePremios - {sorteo.tipoSorteo}{sorteo.numeroSorteo}.pdf\" en el escritorio.",
                        "Reporte plan de premios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error generando el reporte. " +
                    $"Se intentó crear con el nombre: \"PlanDePremios - {sorteo.tipoSorteo}{sorteo.numeroSorteo}.pdf\"\n" +
                    "El error puede suceder por alguna de las siguientes causas:\n" +
                    "* Existe un archivo con el mismo nombre y no se puede modificar.\n" +
                    "* Existe un archivo con el mismo nombre y está siendo utilizado.\n" +
                    "* No tiene permisos para escribir en la carpeta de destino(Escritorio).\n" +
                    "* No tiene espacio suficiente para crear el archivo.\n" +
                    "* Error interno del programa.\n",
                        "Reporte plan de premios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
