﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormJugar : Form
    {
        // Creando e inicializando el hilo
       //Thread hiloSorteo = new Thread(jugarSorteo);
         
        public FormJugar()
        {
            InitializeComponent();
            establecerValoresTablaSorteos();
            establecerValoresTablaResultadosSorteo();
           
        }

        private void establecerValoresTablaSorteos()
        {
            DataTable dtSorteos = new DataTable();
            dtSorteos.Columns.Add("Tipo", typeof(string));
            dtSorteos.Columns.Add("Número", typeof(string));
            dtSorteos.Columns.Add("Fecha", typeof(string));
            dtSorteos.Columns.Add("Jugar", typeof(string));
            for (int i = 0; i < 5; i++)
            {
                dtSorteos.Rows.Add(new object[] { "Lotería", i.ToString(), "30/09/2019" });
            }
            dgvSorteos.DataSource = dtSorteos;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "Jugar";
            btn.Name = "btn";
            btn.Text = "Jugar";
            dgvSorteos.Columns.Add(btn);
        }

        private void establecerValoresTablaResultadosSorteo()
        {
            DataTable dtResultados = new DataTable();
            dtResultados.Columns.Add("Número", typeof(string));
            dtResultados.Columns.Add("Serie", typeof(string));
            dtResultados.Columns.Add("Premio", typeof(string));
            for (int i = 0; i < 5; i++)
            {
                dtResultados.Rows.Add(new object[] { "42", i.ToString(), "1000000" });
            }
            dgvResultadosSorteo.DataSource = dtResultados;
           
        }

        private void dgvSorteos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult dr = MessageBox.Show("¿Desea jugar este sorteo?", "Mensaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    this.dgvSorteos.Rows.RemoveAt(e.ColumnIndex);
                    cambiarEstadoGifs(true);
                    Thread hiloSorteo = new Thread(new ThreadStart(jugarSorteo));
                    hiloSorteo.IsBackground = true;
                    hiloSorteo.Start();
                    //hiloSorteo.Start();


                }


            }
        }
        public void escribirTextBox(String numero,String serie,String premio) {
            if (InvokeRequired)
            {
                tbNumero.Invoke((MethodInvoker)(() => tbNumero.Text = numero));
                tbSerie.Invoke((MethodInvoker)(() => tbSerie.Text = serie));
                tbPremio.Invoke((MethodInvoker)(() => tbPremio.Text = premio));
            }

        }

        public void cambiarEstadoGifs(Boolean estado) {
            
                if (!estado)
                {
                    if (InvokeRequired)
                    {
                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Enabled = false));
                        pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Enabled = false));
                        pictureBox3.Invoke((MethodInvoker)(() => pictureBox3.Enabled = false));
                    }
                }
                else
                {
                    pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Enabled = true));
                    pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Enabled = true));
                    pictureBox3.Invoke((MethodInvoker)(() => pictureBox3.Enabled = true));
                }
            

        }
         void jugarSorteo() {
            for (int i = 0;i<4;i++) {
                escribirTextBox("0" + i, "0" + i+1,"10000");

                Thread.Sleep(3000);
            
            }
            cambiarEstadoGifs(false);
            MessageBox.Show("Sorteo jugado");
        }
    }
}
