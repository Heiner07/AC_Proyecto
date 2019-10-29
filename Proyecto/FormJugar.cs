﻿using System;
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
                    if (!sorteo.estado)
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

        private Sorteo ObtenerSorteoSeleccionado(String tipoSorteo, int numeroSorteo)
        {
            foreach (Sorteo sorteo in sorteos)
            {
                if (sorteo.tipoSorteo.Equals(tipoSorteo) && sorteo.ObtenerNumeroSorteo.Equals(numeroSorteo))
                {
                    return sorteo;
                }
            }return null;
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
                    sorteoSeleccionado = ObtenerSorteoSeleccionado(tipoSorteo, numeroSorteo);
                    cambiarEstadoGifs();
                    hiloJugar = new Thread(new ThreadStart(jugarSorteo))
                    {
                        IsBackground = false
                    };
                    hiloJugar.Start();
                    btOmitirAnimacion.Enabled = true;
                }
            }
        }

        private void escribirTextBoxNumero(String numero) {
            if (InvokeRequired)
            {
                tbNumero.Invoke((MethodInvoker)(() => tbNumero.Text = numero));
               
            }

        }
        private void escribirTextBoxSerie(String serie)
        {
            if (InvokeRequired)
            {
               
                tbSerie.Invoke((MethodInvoker)(() => tbSerie.Text = serie));
            }

        }
        private void escribirTextBoxPremio(String premio)
        {
            if (InvokeRequired)
            {
                
                tbPremio.Invoke((MethodInvoker)(() => tbPremio.Text = premio));
            }

        }

        private void cambiarEstadoGifs()
        {
            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Enabled = true));
            pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Enabled = true));
            pictureBox3.Invoke((MethodInvoker)(() => pictureBox3.Enabled = true));
        }


        private void jugarSorteo()
        {
            sorteoSeleccionado.planPremios.GenerarResultados();
            Invoke((MethodInvoker)(() => dtResultados.Clear()));
            foreach (Resultado resultado in sorteoSeleccionado.planPremios.resultados)
            {
                if(!omitirAnimacion) Thread.Sleep(2500);

                pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Enabled = false));
                if (!omitirAnimacion)
                {
                    escribirTextBoxSerie(Convert.ToString(resultado.serieGanadora));
                    Thread.Sleep(2600);
                }

                pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Enabled = false));
                if (!omitirAnimacion)
                {
                    escribirTextBoxNumero(Convert.ToString(resultado.numeroGanador));
                    Thread.Sleep(2600);
                }

                pictureBox3.Invoke((MethodInvoker)(() => pictureBox3.Enabled = false));
                if (!omitirAnimacion)
                {
                    escribirTextBoxPremio(Convert.ToString(resultado.montoGanado));
                    Thread.Sleep(2000);
                }

                escribirTextBoxNumero("");
                escribirTextBoxSerie("");
                escribirTextBoxPremio("");

                if (!omitirAnimacion) cambiarEstadoGifs();

                Invoke((MethodInvoker)(() => dtResultados.Rows.Add(new object[] { resultado.serieGanadora,
                    resultado.numeroGanador, resultado.montoGanado })));
            }
            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Enabled = false));
            pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Enabled = false));
            pictureBox3.Invoke((MethodInvoker)(() => pictureBox3.Enabled = false));
            Invoke((MethodInvoker)(() => MessageBox.Show("¡Sorteo jugado!",
                    "Jugar sorteo", MessageBoxButtons.OK, MessageBoxIcon.Information)));
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
