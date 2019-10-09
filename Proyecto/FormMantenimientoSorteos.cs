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
        private Point posicionPanelSorteos, posicionLbPremioAdicional, posicionNUDPremioAdicional,
            posicionLbCantidad, posicionNUDCantidad;
      
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

            dataGridViewSorteos.Columns[0].Width = 70;
            dataGridViewSorteos.Columns[1].Width = 65;
            dataGridViewSorteos.Columns[2].Width = 85;
            dataGridViewSorteos.Columns[3].Width = 80;
            dataGridViewSorteos.Columns[4].Width = 70;
            dataGridViewSorteos.Columns[6].Width = 60;
        }

        

        private void configurarComponentesPanelSorteos()
        {
            posicionLbPremioAdicional = new Point(25, 3);
            posicionNUDPremioAdicional = new Point(29, 26);
            posicionLbCantidad = new Point(175, 3);
            posicionNUDCantidad = new Point(179, 26);
            lbEditarSorteo.Visible = false;
            btGuardar.Visible = false;
            btCancelar.Visible = false;
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

        private void btBorrarPlanPremios_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Realmente desea borrar el plan de premio?", "Borrando plan de premios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                nudPremio1.Value = 0;
                nudPremio2.Value = 0;
                nudPremio3.Value = 0;
                panelPremiosAdicionales.Controls.Clear();
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
            Label lbCantidad = new Label
            {
                Text = "Cantidad",
                Height = 19,
                Width = 80,
                Font = new Font("Arial", 10),
                Location = posicionLbCantidad
            };
            NumericUpDown nUDPremioAdicional = new NumericUpDown
            {
                Height = 22,
                Width = 140,
                Location = posicionNUDPremioAdicional
            };
            NumericUpDown nUDCantidad = new NumericUpDown
            {
                Height = 22,
                Width = 80,
                Location = posicionNUDCantidad
            };

            panel.Controls.Add(lbPremioAdicional);
            panel.Controls.Add(nUDPremioAdicional);
            panel.Controls.Add(lbCantidad);
            panel.Controls.Add(nUDCantidad);

            panelPremiosAdicionales.Controls.Add(panel);
        }
    }
}
