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
    public partial class FormMantenimientoSorteos : Form
    {
        private Point posicionPanelSorteos, posicionLbPremioAdicional, posicionNUDPremioAdicional;

        public FormMantenimientoSorteos()
        {
            InitializeComponent();
            configurarComponentesPanelSorteos();
            establecerValoresTablaSorteos();
        }

        private void establecerValoresTablaSorteos()
        {
            DataTable dtSorteos = new DataTable();
            dtSorteos.Columns.Add("Tipo",typeof(string));
            dtSorteos.Columns.Add("Número", typeof(string));
            dtSorteos.Columns.Add("Fecha", typeof(string));
            dtSorteos.Columns.Add("Número fracciones", typeof(int));
            dtSorteos.Columns.Add("Costo fracción", typeof(int));
            dtSorteos.Columns.Add("Leyenda", typeof(string));
            dtSorteos.Columns.Add("Jugado", typeof(bool));
            for (int i = 0; i < 5; i++)
            {
                dtSorteos.Rows.Add(new object[] { "Lotería", i.ToString(), "30/09/2019", 5, 2000, "Medio año", true });
            }
            dataGridViewSorteos.DataSource = dtSorteos;
        }

        private void configurarComponentesPanelSorteos()
        {
            posicionLbPremioAdicional = new Point(20, 3);
            posicionNUDPremioAdicional = new Point(22, 26);
            panelCrearSorteo.Visible = false;
            posicionPanelSorteos = panelSorteos.Location;
            panelSorteos.Location = panelCrearSorteo.Location;
            panelSorteos.Height += panelCrearSorteo.Height;
        }

        private void btCrearNuevoSorteo_Click(object sender, EventArgs e)
        {
            if (panelCrearSorteo.Visible)
            {
                panelSorteos.Location = panelCrearSorteo.Location;
                panelSorteos.Height += panelCrearSorteo.Height;
            }
            else
            {
                panelSorteos.Location = posicionPanelSorteos;
                panelSorteos.Height -= panelCrearSorteo.Height;
            }
            
            panelCrearSorteo.Visible = !panelCrearSorteo.Visible;
        }

        private void btAgregarPremioAdicional_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 55
            };
            Label lbPremioAdicional = new Label
            {
                Text = "Premio adicional",
                Height = 19,
                Width = 130,
                Font = new Font("Arial", 10),
                Location = posicionLbPremioAdicional
            };
            NumericUpDown nUDPremioAdicional = new NumericUpDown
            {
                Height = 22,
                Width = 140,
                Location = posicionNUDPremioAdicional
            };

            panel.Controls.Add(lbPremioAdicional);
            panel.Controls.Add(nUDPremioAdicional);

            panelPremiosAdicionales.Controls.Add(panel);
        }
    }
}
