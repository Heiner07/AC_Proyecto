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
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "Eliminar";
            btn.Name = "btn";
            btn.Text = "Eliminar";
            dataGridViewSorteos.Columns.Add(btn);
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.UseColumnTextForButtonValue = true;
            btn2.HeaderText = "Editar";
            btn2.Name = "btn2";
            btn2.Text = "Editar";
            dataGridViewSorteos.Columns.Add(btn2);

        }

        

        private void configurarComponentesPanelSorteos()
        {
            posicionLbPremioAdicional = new Point(25, 3);
            posicionNUDPremioAdicional = new Point(29, 26);
            panelCrearSorteo.Visible = false;
            posicionPanelSorteos = panelSorteos.Location;
            panelSorteos.Location = panelCrearSorteo.Location;
            panelSorteos.Height += panelCrearSorteo.Height;
        }


       
        private void dataGridViewSorteos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 0) {
                DialogResult dr = MessageBox.Show("¿Desea eliminar este sorteo?", "Mensaje", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    this.dataGridViewSorteos.Rows.RemoveAt(e.ColumnIndex);
                    
                }
                

            }
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
                Width = 150,
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
