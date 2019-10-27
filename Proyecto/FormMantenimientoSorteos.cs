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

        SistemaLoteriaChances sistemaLoteriaChances;

        public FormMantenimientoSorteos(SistemaLoteriaChances sistemaLoteriaChances)
        {
            InitializeComponent();
            this.sistemaLoteriaChances = sistemaLoteriaChances;
            ConfigurarComponentesPanelSorteos();
            EstablecerValoresTablaSorteos();
           
        }

        private void EstablecerValoresTablaSorteos()
        {
            List<Sorteo> sorteos = sistemaLoteriaChances.ObtenerSorteos();
            if(sorteos != null)
            {
                int cantidadSorteos = sorteos.Count;
                Sorteo sorteo;
                DataTable dtSorteos = new DataTable();
                dtSorteos.Columns.Add("Tipo", typeof(string));
                dtSorteos.Columns.Add("Número", typeof(string));
                dtSorteos.Columns.Add("Fecha", typeof(string));
                dtSorteos.Columns.Add("Número fracciones", typeof(int));
                dtSorteos.Columns.Add("Costo fracción", typeof(int));
                dtSorteos.Columns.Add("Leyenda", typeof(string));
                dtSorteos.Columns.Add("Jugado", typeof(bool));
                for (int i = 0; i < cantidadSorteos; i++)
                {
                    sorteo = sorteos[i];
                    dtSorteos.Rows.Add(new object[] { sorteo.tipoSorteo, sorteo.numeroSorteo,
                        sorteo.fecha.ToShortDateString(), sorteo.cantidadFracciones, sorteo.precioFraccion,
                        sorteo.leyendaBillete, sorteo.estado });
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
            else
            {
                MessageBox.Show("Ocurrió un error recuperando los datos de la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void ConfigurarComponentesPanelSorteos()
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
            List<Sorteo> sorteos = sistemaLoteriaChances.ObtenerSorteos();
            foreach (Sorteo sorteo in sorteos)
            {
               // if (sorteo.ObtenerTipoSorteo.Equals(tipoSorteo))
                //{
                    if (sorteo.ObtenerFecha.Date >= fecha.Date)
                    {
                        return false;
                    }

                //}
                
            }
            
            if ((fecha.DayOfWeek == DayOfWeek.Tuesday || fecha.DayOfWeek == DayOfWeek.Friday) && tipoSorteo.Equals("Chances"))
            {
                return true;
            }
            else if (fecha.DayOfWeek == DayOfWeek.Sunday && tipoSorteo.Equals("Loteria"))
            {
                
                return true;

            }
            return false;

        }

        private int ObtenerNumeroSorteo(String tipoSorteo) {
            List<Sorteo> sorteos = sistemaLoteriaChances.ObtenerSorteos();
            int numeroRetornado = 0;
            foreach(Sorteo sorteo in sorteos)
            {
                if (sorteo.ObtenerTipoSorteo.Equals(tipoSorteo)) {
                    numeroRetornado = sorteo.ObtenerNumeroSorteo;
                    
                }
            }
            numeroRetornado++;
            return numeroRetornado;

        }
        private void ObtenerPlanPremios() {
            

        
        }
        private void btCrear_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtFecha.Value;
            PlanPremios planPremios = new PlanPremios();
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

                    //Preguntar si quiere guardar el plan de premios
                     Premio premio = new Premio(Convert.ToInt32(nudPremio1.Value),1);
                    ObtenerPlanPremios();
                    planPremios.premios.Add(new Premio(Convert.ToInt32(nudPremio1.Value), 1));
                    planPremios.premios.Add(new Premio(Convert.ToInt32(nudPremio2.Value), 1));
                    planPremios.premios.Add(new Premio(Convert.ToInt32(nudPremio3.Value), 1));
                    


                    int numeroSorteo = ObtenerNumeroSorteo(tipoSorteo);
                    Sorteo sorteo = new Sorteo(1, numeroSorteo, tipoSorteo,fecha, Convert.ToInt32(nudFracciones.Value), Convert.ToInt32(nudCostoFraccion.Value),
                    tbLeyenda.Text.Equals("") ? "Sin leyenda": tbLeyenda.Text,false, planPremios);
                    if (sistemaLoteriaChances.CrearSorteo(sorteo))
                    {
                        MessageBox.Show("¡¡¡Se insertó con éxito!!!");
                        dataGridViewSorteos.Columns.Clear();
                        EstablecerValoresTablaSorteos();
                    }
                    else { MessageBox.Show("Error al guardar el sorteo"); }
                   
                    
                    
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

        
        private void rbLoteria_CheckedChanged(object sender, EventArgs e)
        {
            lbRestriccionSorteo.Text = "Sólo los domingos";
            btAgregarPremioAdicional.Visible = true;
        }

        private void rbChances_CheckedChanged(object sender, EventArgs e)
        {
            lbRestriccionSorteo.Text = "Sólo martes y viernes";
            btAgregarPremioAdicional.Visible = false;
        }

        private void dataGridViewSorteos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex == 0) {
                DialogResult dr = MessageBox.Show("¿Desea eliminar este sorteo?", "Mensaje", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                
                if (dr == DialogResult.Yes)
                {
                    
                    DataTable dt = this.dataGridViewSorteos.DataSource as DataTable;
                    String tipoSorteo = dt.Rows[e.RowIndex]["Tipo"].ToString();
                    int numeroSorteo = Convert.ToInt32(dt.Rows[e.RowIndex]["Número"].ToString());
                    List<Sorteo> sorteos = sistemaLoteriaChances.ObtenerSorteos();
                    foreach(Sorteo sorteo in sorteos) {
                        if (sorteo.tipoSorteo.Equals(tipoSorteo) && sorteo.ObtenerNumeroSorteo.Equals(numeroSorteo)) {
                            if (!sorteo.ObtenerEstado)
                            {
                                if (sistemaLoteriaChances.EliminarSorteo(sorteo)) {
                                    dataGridViewSorteos.Columns.Clear();
                                    EstablecerValoresTablaSorteos();
                                    MessageBox.Show("El sorteo se eliminó con éxito");

                                }
                                else { MessageBox.Show("El sorteo no se puede eliminar"); }

                            }
                            else {
                                MessageBox.Show("El sorteo no se puede eliminar, ya se jugó");
                            }
                        }
                    }
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
