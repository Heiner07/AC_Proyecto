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
    public partial class FormJugar : Form
    {
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
    }
}
