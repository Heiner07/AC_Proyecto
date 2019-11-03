using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Proyecto
{
    public partial class FormJugar : Form
    {
        Thread hiloJugar; // Se encarga de realizar la ejecución de jugar el sorteo
        Boolean omitirAnimacion;
        SistemaLoteriaChances sistemaLoteriaChances;
        DataTable dtSorteos, dtResultados;
        List<Sorteo> sorteos;
        String filtroTipoSorteos;
        Sorteo sorteoSeleccionado;

        public FormJugar(SistemaLoteriaChances sistemaLoteriaChances)
        {
            InitializeComponent();
            this.sistemaLoteriaChances = sistemaLoteriaChances;
            this.filtroTipoSorteos = "";
            this.hiloJugar = null;
            this.omitirAnimacion = false;
            EstablecerValoresTablaSorteos();
            establecerValoresTablaResultadosSorteo();
        }

        private void EstablecerValoresTablaSorteos()
        {
            dtSorteos = new DataTable();
            dtSorteos.Columns.Add("Tipo", typeof(string));
            dtSorteos.Columns.Add("Número", typeof(string));
            dtSorteos.Columns.Add("Fecha", typeof(string));
            dgvSorteos.DataSource = dtSorteos;
            DataGridViewButtonColumn btnJugar = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "Jugar",
                Name = "btn",
                Text = "Jugar"
            };
            dgvSorteos.Columns.Add(btnJugar);
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
                    if (!sorteo.estado && sorteo.planPremios.premios.Count > 0)
                    {
                        dtSorteos.Rows.Add(new object[] { sorteo.tipoSorteo, sorteo.numeroSorteo,
                        sorteo.fecha.ToShortDateString() });
                    }
                }
            }
            else
            {
                MessageBox.Show("Ocurrió un error recuperando los datos de la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void establecerValoresTablaResultadosSorteo()
        {
            dtResultados = new DataTable();
            dtResultados.Columns.Add("Serie", typeof(string));
            dtResultados.Columns.Add("Número", typeof(string));
            dtResultados.Columns.Add("Premio", typeof(string));
            dgvResultadosSorteo.DataSource = dtResultados;
        }

        private void dgvSorteos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                String tipoSorteo = dtSorteos.DefaultView[e.RowIndex]["Tipo"].ToString();
                int numeroSorteo = Convert.ToInt32(dtSorteos.DefaultView[e.RowIndex]["Número"].ToString());

                DialogResult dr = MessageBox.Show($"¿Desea jugar el sorteo {numeroSorteo} de {tipoSorteo}?",
                    "Jugar sorteo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    sorteoSeleccionado = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipoSorteo, numeroSorteo);
                    CambiarEstadoGifs(true);
                    hiloJugar = new Thread(new ThreadStart(jugarSorteo))
                    {
                        IsBackground = false
                    };
                    hiloJugar.Start();
                }
            }
        }

        private void escribirTextBoxNumero(String numero) {
            if (InvokeRequired)
            {
                lbNum.Invoke((MethodInvoker)(() => lbNum.Text = numero));
                
            }

        }
        private void escribirTextBoxSerie(String serie)
        {
            if (InvokeRequired)
            {
               
                lbSerie.Invoke((MethodInvoker)(() => lbSerie.Text = serie));
            }

        }
        private void escribirTextBoxPremio(String premio)
        {
            if (InvokeRequired)
            {
                
                lbPremio.Invoke((MethodInvoker)(() => lbPremio.Text = premio));


            }

        }

        private void CambiarEstadoGifs(Boolean estado)
        {
            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Enabled = estado));
            pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Enabled = estado));
            pictureBox3.Invoke((MethodInvoker)(() => pictureBox3.Enabled = estado));
        }


        private void jugarSorteo()
        {
            // Se establecen los valores de los componentes de la interfaz para la acción de jugar
            SpeechSynthesizer generadorVoz = new SpeechSynthesizer();
            generadorVoz.SetOutputToDefaultAudioDevice();
            btOmitirAnimacion.Invoke((MethodInvoker)(() => btOmitirAnimacion.Enabled = true));
            dgvSorteos.Invoke((MethodInvoker)(() => dgvSorteos.Enabled = false));
            lbJugandoSorteo.Invoke((MethodInvoker)(() => lbJugandoSorteo.Text =
            $"Jugando sorteo {sorteoSeleccionado.numeroSorteo} de {sorteoSeleccionado.tipoSorteo}"));

            // Se le indica al sorteo que genere los resultados
            sorteoSeleccionado.planPremios.GenerarResultados(sorteoSeleccionado.tipoSorteo);

            // Se realiza la ejecución (animación) en la ventana, mostrando los resultados.
            Invoke((MethodInvoker)(() => dtResultados.Clear()));
            foreach (Resultado resultado in sorteoSeleccionado.planPremios.resultados)
            {
                if(!omitirAnimacion) Thread.Sleep(2500);

                pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Enabled = false));
                if (!omitirAnimacion)
                {
                    escribirTextBoxSerie(Convert.ToString(resultado.serieGanadora));
                    generadorVoz.Speak($"Serie {resultado.serieGanadora}");
                    Thread.Sleep(2600);
                }

                pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Enabled = false));
                if (!omitirAnimacion)
                {
                    escribirTextBoxNumero(Convert.ToString(resultado.numeroGanador));
                    generadorVoz.Speak($"Número {resultado.numeroGanador}");
                    Thread.Sleep(2600);
                }

                pictureBox3.Invoke((MethodInvoker)(() => pictureBox3.Enabled = false));
                if (!omitirAnimacion)
                {
                    escribirTextBoxPremio(Convert.ToString(resultado.montoGanado));
                    generadorVoz.Speak($"Premio {resultado.montoGanado}");
                    Thread.Sleep(2000);
                }

                escribirTextBoxNumero("");
                escribirTextBoxSerie("");
                escribirTextBoxPremio("");

                if (!omitirAnimacion) CambiarEstadoGifs(true);
                // Se agregan los resultados al data table del gridview
                Invoke((MethodInvoker)(() => dtResultados.Rows.Add(new object[] { resultado.serieGanadora,
                    resultado.numeroGanador, resultado.montoGanado })));
            }
            CambiarEstadoGifs(false);
            if (sistemaLoteriaChances.JugarSorteo(sorteoSeleccionado))
            {
                lbJugandoSorteo.Invoke((MethodInvoker)(() => lbJugandoSorteo.Text =
                $"Sorteo {sorteoSeleccionado.numeroSorteo} de {sorteoSeleccionado.tipoSorteo} jugado."));
                Invoke((MethodInvoker)(() => MessageBox.Show("¡Sorteo jugado! Los resultados se han almacenado correctamente",
                    "Jugar sorteo", MessageBoxButtons.OK, MessageBoxIcon.Information)));
            }
            else
            {
                Invoke((MethodInvoker)(() => MessageBox.Show("Ocurrió un error guardando los resultados del sorteo.",
                    "Jugar sorteo", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }

            // Se actualizan los estados e información de los componentes una vez finalizado el sorteo
            btOmitirAnimacion.Invoke((MethodInvoker)(() => btOmitirAnimacion.Enabled = false));
            dgvSorteos.Invoke((MethodInvoker)(() => dgvSorteos.Enabled = true));
            Invoke((MethodInvoker)(() => CargarSorteos()));
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            dtSorteos.DefaultView.RowFilter = $"{filtroTipoSorteos}Número LIKE '{tbBusqueda.Text}%'";
        }

        private void rbFiltroTodos_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "";
            tbBusqueda_TextChanged(sender, e);
        }

        private void rbFiltroLoteria_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "Tipo = 'Lotería' AND ";
            tbBusqueda_TextChanged(sender, e);
        }

        private void rbFiltroChances_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "Tipo = 'Chances' AND ";
            tbBusqueda_TextChanged(sender, e);
        }

        private void btOmitirAnimacion_Click(object sender, EventArgs e)
        {
            omitirAnimacion = true;
            btOmitirAnimacion.Enabled = false;
        }

        public Boolean RealizandoSorteo()
        {
            if(hiloJugar != null)
            {
                return hiloJugar.IsAlive;
            }
            return false;
        }
    }
}
