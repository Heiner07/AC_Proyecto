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
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.UseColumnTextForButtonValue = true;
            btn2.HeaderText = "Editar";
            btn2.Name = "btn2";
            btn2.Text = "Editar";
            dataGridViewSorteos.Columns.Add(btn2);

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

        private void establecerInterfazEditando()
        {
            lbEditarSorteo.Visible = true;
            btGuardar.Visible = true;
            btCancelar.Visible = true;
            btCrearNuevoSorteo.Visible = false;
            btCrear.Visible = false;
        }

        private void salirInterfazEditando()
        {
            lbEditarSorteo.Visible = false;
            btGuardar.Visible = false;
            btCancelar.Visible = false;
            btCrearNuevoSorteo.Visible = true;
            btCrear.Visible = true;
        }

        private void ajustarPanelSorteo()
        {
            if (panelCrearSorteo.Visible)
            {
                panelSorteos.Height += panelCrearSorteo.Height;
                panelSorteos.Location = new Point(panelSorteos.Location.X, panelCrearSorteo.Location.Y);
            }
            else
            {
                panelSorteos.Height -= panelCrearSorteo.Height;
                panelSorteos.Location = new Point(panelSorteos.Location.X, posicionPanelSorteos.Y);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            salirInterfazEditando();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            salirInterfazEditando();
        }


        private Boolean ValidarFecha(String tipoSorteo, DateTime fecha) {
            if ((fecha.DayOfWeek == DayOfWeek.Tuesday || fecha.DayOfWeek == DayOfWeek.Friday) && tipoSorteo.Equals("Chances"))
            {
                
                MessageBox.Show("Chances valida");
                return true;
            }
            else if (fecha.DayOfWeek == DayOfWeek.Sunday && tipoSorteo.Equals("Loteria"))
            {
                MessageBox.Show("loteria valida");
                return true;

            }
            return false;

        }
        private void btCrear_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtFecha.Value;
            Sorteo sorteo;
            string tipoSorteo; 
            
            if (rbChances.Checked)
            {
                tipoSorteo = "Chances";
            }
            else
            {
                tipoSorteo = "Loteria";

            }
            Boolean fechaValida = ValidarFecha(tipoSorteo,fecha);
            if (fechaValida)
            {
                if (nudFracciones.Value > 0 && nudCostoFraccion.Value > 0)
                {
                    
                    sorteo.EstablecerCantidadFracciones(Convert.ToInt32(nudFracciones.Value));
                    sorteo.EstablecerFecha(fecha);
                    sorteo.EstablecerLeyenda(tbLeyenda.Text);
                    sorteo.EstablecerPrecioFraccion(Convert.ToInt32(nudCostoFraccion.Value));
                    sorteo.EstablecerTipoSorteo(tipoSorteo);
                    
                }
                else
                {
                    MessageBox.Show("La cantidad de fracciones y el costo deben ser mayor a 0");
                }


            }
            else {
                MessageBox.Show("La fecha seleccionada no es válida");

            }
            
            
                   
            

        }

        private void dataGridViewSorteos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex == 0) {
                DialogResult dr = MessageBox.Show("¿Desea eliminar este sorteo?", "Mensaje", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    this.dataGridViewSorteos.Rows.RemoveAt(e.RowIndex);
                    
                }
                
            }else if (e.ColumnIndex == 1)
            {
                establecerInterfazEditando();
                if (!panelCrearSorteo.Visible) {
                    ajustarPanelSorteo();
                }
                panelCrearSorteo.Visible = true;
            }
        }

        private void btBorrarPlanPremios_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Realmente desea borrar el plan de premio?", "Borrando plan de premios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                nudPremio1.Value = 1;
                nudPremio2.Value = 1;
                nudPremio3.Value = 1;
                panelPremiosAdicionales.Controls.Clear();
            }
        }

        private void btCrearNuevoSorteo_Click(object sender, EventArgs e)
        {
            ajustarPanelSorteo();
            dtFecha.MinDate = DateTime.Now;
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
