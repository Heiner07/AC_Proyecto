using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;

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
            EstablecerValoresTablaResultadosSorteo();
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
                    if (!sorteo.Estado && sorteo.PlanPremios.Premios.Count > 0)
                    {
                        dtSorteos.Rows.Add(new object[] { sorteo.TipoSorteo, sorteo.NumeroSorteo,
                        sorteo.Fecha.ToShortDateString() });
                    }
                }
            }
            else
            {
                MessageBox.Show("Ocurrió un error recuperando los datos de la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstablecerValoresTablaResultadosSorteo()
        {
            dtResultados = new DataTable();
            dtResultados.Columns.Add("Serie", typeof(string));
            dtResultados.Columns.Add("Número", typeof(string));
            dtResultados.Columns.Add("Premio", typeof(string));
            dgvResultadosSorteo.DataSource = dtResultados;
        }

        private void DgvSorteos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                    hiloJugar = new Thread(new ThreadStart(JugarSorteo))
                    {
                        IsBackground = false
                    };
                    hiloJugar.Start();
                }
            }
        }

        private void EscribirTextBoxNumero(String numero) {
            if (InvokeRequired)
            {
                lbNum.Invoke((MethodInvoker)(() => lbNum.Text = numero));
                
            }

        }
        private void EscribirTextBoxSerie(String serie)
        {
            if (InvokeRequired)
            {
               
                lbSerie.Invoke((MethodInvoker)(() => lbSerie.Text = serie));
            }

        }
        private void EscribirTextBoxPremio(String premio)
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

        private void InicializarValoresComponentesJugar()
        {
            btOmitirAnimacion.Invoke((MethodInvoker)(() => btOmitirAnimacion.Enabled = true));
            dgvSorteos.Invoke((MethodInvoker)(() => dgvSorteos.Enabled = false));
            lbJugandoSorteo.Invoke((MethodInvoker)(() => lbJugandoSorteo.Text =
            $"Jugando sorteo {sorteoSeleccionado.NumeroSorteo} de {sorteoSeleccionado.TipoSorteo}"));
        }

        private void ManejarAnimacionJugar(SpeechSynthesizer generadorVoz, String numero,
            String serie, String monto, int cantidadMayor)
        {
            if (!omitirAnimacion) Thread.Sleep(2500);

            pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Enabled = false));
            if (!omitirAnimacion)
            {
                EscribirTextBoxSerie(serie);
                generadorVoz.Speak($"Serie {serie}");
                Thread.Sleep(2600);
            }

            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Enabled = false));
            if (!omitirAnimacion)
            {
                EscribirTextBoxNumero(numero);
                generadorVoz.Speak($"Número {numero}");
                Thread.Sleep(2600);
            }

            pictureBox3.Invoke((MethodInvoker)(() => pictureBox3.Enabled = false));
            if (!omitirAnimacion)
            {
                if (cantidadMayor == Convert.ToInt32(monto))
                {
                    EscribirTextBoxPremio("PREMIO MAYOR");
                    generadorVoz.Speak($"Premio mayor {monto}");
                }
                else
                {
                    EscribirTextBoxPremio(monto);
                    generadorVoz.Speak($"Premio {monto}");
                }

                Thread.Sleep(2000);
            }

            EscribirTextBoxNumero("");
            EscribirTextBoxSerie("");
            EscribirTextBoxPremio("");

            if (!omitirAnimacion) CambiarEstadoGifs(true);
        }

        private void JugarSorteo()
        {
            // Se establecen los valores de los componentes de la interfaz para la acción de jugar
            SpeechSynthesizer generadorVoz = new SpeechSynthesizer();
            generadorVoz.SetOutputToDefaultAudioDevice();
            InicializarValoresComponentesJugar();
            String serie, numero, monto;

            // Se le indica al sorteo que genere los resultados
            sorteoSeleccionado.PlanPremios.GenerarResultados(sorteoSeleccionado.TipoSorteo);
            int cantidadMayor = sorteoSeleccionado.PlanPremios.Premios[0].MontoPremio;
            // Se realiza la ejecución (animación) en la ventana, mostrando los resultados.
            Invoke((MethodInvoker)(() => dtResultados.Clear()));
            foreach (Resultado resultado in sorteoSeleccionado.PlanPremios.Resultados)
            {
                serie = resultado.SerieGanadora.ToString("000");
                numero = resultado.NumeroGanador.ToString("00");
                monto = resultado.MontoGanado.ToString("#,#", CultureInfo.InvariantCulture);

                ManejarAnimacionJugar(generadorVoz, numero, serie, monto, cantidadMayor);

                // Se agregan los resultados al data table del gridview
                Invoke((MethodInvoker)(() => dtResultados.Rows.Add(new object[] { serie, numero, monto })));
            }
            CambiarEstadoGifs(false);
            if (sistemaLoteriaChances.JugarSorteo(sorteoSeleccionado))
            {
                lbJugandoSorteo.Invoke((MethodInvoker)(() => lbJugandoSorteo.Text =
                $"Sorteo {sorteoSeleccionado.NumeroSorteo} de {sorteoSeleccionado.TipoSorteo} jugado."));
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
            generadorVoz.Dispose();
        }

        private void TbBusqueda_TextChanged(object sender, EventArgs e)
        {
            dtSorteos.DefaultView.RowFilter = $"{filtroTipoSorteos}Número LIKE '{tbBusqueda.Text}%'";
        }

        private void RbFiltroTodos_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "";
            TbBusqueda_TextChanged(sender, e);
        }

        private void RbFiltroLoteria_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "Tipo = 'Lotería' AND ";
            TbBusqueda_TextChanged(sender, e);
        }

        private void RbFiltroChances_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "Tipo = 'Chances' AND ";
            TbBusqueda_TextChanged(sender, e);
        }

        private void BtOmitirAnimacion_Click(object sender, EventArgs e)
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
