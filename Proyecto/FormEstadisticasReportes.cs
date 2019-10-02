﻿using System;
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
        public FormEstadisticasReportes()
        {
            InitializeComponent();
            inicializarTablas();
            establecerValoresTablaSorteos();
        }

        private void establecerValoresTablaSorteos()
        {
            DataTable dtSorteos = new DataTable();
            dtSorteos.Columns.Add("Tipo", typeof(string));
            dtSorteos.Columns.Add("Número", typeof(string));
            dtSorteos.Columns.Add("Fecha", typeof(string));
            dtSorteos.Columns.Add("Jugado", typeof(bool));
            for (int i = 0; i < 5; i++)
            {
                dtSorteos.Rows.Add(new object[] { "Lotería", i.ToString(), "30/09/2019", true });
            }
            dgvSorteos.DataSource = dtSorteos;
        }

        private void inicializarTablas()
        {
            inicializarTablaNumerosMasJugados();
            inicializarTablaNumerosMasGanadoresPrimer();
            inicializarTablaNumerosConMayorDineroRepartido();
        }

        private void inicializarTablaNumerosMasJugados()
        {
            DataTable dtNumerosMasJugados = new DataTable();
            dtNumerosMasJugados.Columns.Add("Posición", typeof(int));
            dtNumerosMasJugados.Columns.Add("Número", typeof(int));
            for (int i = 0; i < 10; i++)
            {
                dtNumerosMasJugados.Rows.Add(new object[] { i+1, i * i + i });
            }dgvNumerosMasJugados.DataSource = dtNumerosMasJugados;
        }

        private void inicializarTablaNumerosMasGanadoresPrimer()
        {
            DataTable dtNumerosMasGanadores = new DataTable();
            dtNumerosMasGanadores.Columns.Add("Posición", typeof(int));
            dtNumerosMasGanadores.Columns.Add("Número", typeof(int));
            for (int i = 0; i < 5; i++)
            {
                dtNumerosMasGanadores.Rows.Add(new object[] { i + 1, i * i + i });
            }
            dgvTop5GanadoresPrimer.DataSource = dtNumerosMasGanadores;
        }

        private void inicializarTablaNumerosConMayorDineroRepartido()
        {
            DataTable dtNumerosConMayorDineroRepartido = new DataTable();
            dtNumerosConMayorDineroRepartido.Columns.Add("Posición", typeof(int));
            dtNumerosConMayorDineroRepartido.Columns.Add("Número", typeof(int));
            for (int i = 0; i < 5; i++)
            {
                dtNumerosConMayorDineroRepartido.Rows.Add(new object[] { i + 1, i * i + i });
            }
            dgvTopNumeroDineroRepartido.DataSource = dtNumerosConMayorDineroRepartido;
        }
    }
}