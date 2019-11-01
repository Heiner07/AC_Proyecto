﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormMantenimientoSorteos : Form
    {
        private Point posicionPanelSorteos, posicionLbPremioAdicional, posicionNUDPremioAdicional,
            posicionLbCantidad, posicionNUDCantidad;

        SistemaLoteriaChances sistemaLoteriaChances;
        DataTable dtPremiosAdicionales, dtSorteos;
        List<Sorteo> sorteos;
        String filtroTipoSorteos;
        Boolean enEdicion;
        Sorteo sorteoEditando;

        public FormMantenimientoSorteos(SistemaLoteriaChances sistemaLoteriaChances)
        {
            InitializeComponent();
            this.sistemaLoteriaChances = sistemaLoteriaChances;
            this.filtroTipoSorteos = "";
            this.enEdicion = false;
            this.sorteoEditando = new Sorteo();
            ConfigurarTablaPremiosAdicionales();
            ConfigurarComponentesPanelSorteos();
            EstablecerValoresTablaSorteos();
           
        }

        private void ConfigurarTablaPremiosAdicionales()
        {
            this.dtPremiosAdicionales = new DataTable();
            this.dtPremiosAdicionales.Columns.Add("Monto", typeof(int));
            this.dtPremiosAdicionales.Columns.Add("Cantidad", typeof(int));
            dataGridViewPremiosAdicionales.DataSource = dtPremiosAdicionales;
            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "Eliminar",
                Name = "btn",
                Text = "Eliminar",
                
            };
            dataGridViewPremiosAdicionales.Columns.Add(btn);
            dataGridViewPremiosAdicionales.Columns[0].Width = 80;
            dataGridViewPremiosAdicionales.Columns[1].Width = 80;
            dataGridViewPremiosAdicionales.Columns[2].Width = 70;

           // dataGridViewPremiosAdicionales.Columns[0].ReadOnly = true;
        }

        private void EstablecerValoresTablaSorteos()
        {
            dtSorteos = new DataTable();
            dtSorteos.Columns.Add("Tipo", typeof(string));
            dtSorteos.Columns.Add("Número", typeof(string));
            dtSorteos.Columns.Add("Fecha", typeof(string));
            dtSorteos.Columns.Add("Número fracciones", typeof(int));
            dtSorteos.Columns.Add("Costo fracción", typeof(int));
            dtSorteos.Columns.Add("Leyenda", typeof(string));
            dtSorteos.Columns.Add("Jugado", typeof(bool));
            dataGridViewSorteos.DataSource = dtSorteos;
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "Eliminar",
                Name = "btn",
                Text = "Eliminar"
            };
            dataGridViewSorteos.Columns.Add(btnEliminar);
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "Editar",
                Name = "btn2",
                Text = "Editar"
            };
            dataGridViewSorteos.Columns.Add(btnEditar);

            dataGridViewSorteos.Columns[0].Width = 70;
            dataGridViewSorteos.Columns[1].Width = 65;
            dataGridViewSorteos.Columns[2].Width = 85;
            dataGridViewSorteos.Columns[3].Width = 80;
            dataGridViewSorteos.Columns[4].Width = 70;
            dataGridViewSorteos.Columns[6].Width = 60;
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
                    dtSorteos.Rows.Add(new object[] { sorteo.tipoSorteo, sorteo.numeroSorteo,
                        sorteo.fecha.ToShortDateString(), sorteo.cantidadFracciones, sorteo.precioFraccion,
                        sorteo.leyendaBillete, sorteo.estado });
                }
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
            lbEditarSorteo.Text = $"Editando sorteo {sorteoEditando.numeroSorteo} de {sorteoEditando.tipoSorteo}";
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

        private Boolean EsNumeroPositivo(String numero)
        {
            try
            {
                int entero = Convert.ToInt32(numero);
                if (entero < 1)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            PlanPremios planPremios = new PlanPremios();
            if (nudFracciones.Value > 0 && nudCostoFraccion.Value > 0)
            {
                if (cbConPlan.Checked)
                {
                    planPremios.premios = ObtenerPlanPremios(sorteoEditando.ObtenerTipoSorteo);
                    if (planPremios.premios != null)
                    {
                        Sorteo sorteo = new Sorteo(sorteoEditando.ObtenerIdSorteo, sorteoEditando.ObtenerNumeroSorteo, sorteoEditando.ObtenerTipoSorteo, sorteoEditando.ObtenerFecha, Convert.ToInt32(nudFracciones.Value), Convert.ToInt32(nudCostoFraccion.Value),
                        tbLeyenda.Text.Equals("") ? "Sin leyenda" : tbLeyenda.Text, false, planPremios);
                        sorteoEditando = sorteo;
                        ModificarSorteo(sorteoEditando);
                    }

                }
                else
                {
                    Sorteo sorteo = new Sorteo(sorteoEditando.ObtenerIdSorteo, sorteoEditando.ObtenerNumeroSorteo, sorteoEditando.ObtenerTipoSorteo, sorteoEditando.ObtenerFecha, Convert.ToInt32(nudFracciones.Value), Convert.ToInt32(nudCostoFraccion.Value),
                    tbLeyenda.Text.Equals("") ? "Sin leyenda" : tbLeyenda.Text, false, planPremios);
                    sorteoEditando = sorteo;
                    ModificarSorteo(sorteoEditando);
                }
            }
            else
            {
                MessageBox.Show("La cantidad de fracciones y el costo deben ser mayor a 0", "Modificar sorteo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //salirInterfazEditando();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            btAgregarPremioAdicional.Visible = true;
            salirInterfazEditando();
            rbChances.Enabled = true;
            rbLoteria.Enabled = true;
            dtFecha.Enabled = true;
            enEdicion = false;           
            dtPremiosAdicionales.Clear();
            ajustarPanelSorteo();
            panelCrearSorteo.Visible = !panelCrearSorteo.Visible;
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
            else if (fecha.DayOfWeek == DayOfWeek.Sunday && tipoSorteo.Equals("Lotería"))
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

        private List<Premio> ObtenerPlanPremios(String tipoSorteo) {
            List<Premio> premios = new List<Premio>();
            int primerPremio = Convert.ToInt32(nudPremio1.Value);
            int segundoPremio = Convert.ToInt32(nudPremio2.Value);
            int tercerPremio = Convert.ToInt32(nudPremio3.Value);
            if (primerPremio > 0 && segundoPremio > 0 && tercerPremio > 0 && (primerPremio > segundoPremio) && (segundoPremio > tercerPremio)) {
                premios.Add(new Premio(primerPremio, 1));
                premios.Add(new Premio(segundoPremio, 1));
                premios.Add(new Premio(tercerPremio, 1));
            }
            else {
                MessageBox.Show("Error en los 3 premios principales", "Crear sorteo",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
           
            if (tipoSorteo.Equals("Lotería"))
            {
                DataTable dt = this.dataGridViewPremiosAdicionales.DataSource as DataTable;
                int largoPremiosAdicionales = this.dataGridViewPremiosAdicionales.Rows.Count;
                for (int i = 0; i < largoPremiosAdicionales; i++)
                {
                    int montoPremio = Convert.ToInt32(dt.Rows[i]["Monto"].ToString());
                    int cantidad = Convert.ToInt32(dt.Rows[i]["Cantidad"].ToString());
                    if (montoPremio > 0 && cantidad > 0 )
                    {
                        if (montoPremio < tercerPremio)
                        {
                            //Buscamos si existe uno igual
                            Boolean noAgregado = true;
                            foreach (Premio premio in premios)
                            {
                                if (premio.ObtenerCantidad == cantidad && premio.ObtenerMonto == montoPremio)
                                    noAgregado = false;
                            }
                            //Si no está agregado, los agregamos a la lista
                            if (noAgregado)
                            {
                                premios.Add(new Premio(montoPremio, cantidad));
                            }
                        }
                        else {
                            MessageBox.Show("El premio adicional debe ser mayor al tercer premio", "Sorteo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }

                    }
                }
            }
            return premios;

        }
        private void CrearSorteo(Sorteo sorteo) {
            if (sistemaLoteriaChances.CrearSorteo(sorteo))
            {
                MessageBox.Show("¡¡¡Se insertó con éxito!!!", "Crear sorteo",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSorteos();
                //ajustarPanelSorteo();
                //panelCrearSorteo.Visible = !panelCrearSorteo.Visible;
            }
            else {
                MessageBox.Show("Error al guardar el sorteo", "Crear sorteo",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ModificarSorteo(Sorteo sorteo)
        {
            if (sistemaLoteriaChances.ModificarSorteo(sorteo))
            {
                MessageBox.Show("¡¡¡Se Modificó con éxito!!!", "Modificar sorteo",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                btAgregarPremioAdicional.Visible = true;
                salirInterfazEditando();
                dtPremiosAdicionales.Clear();
                rbChances.Enabled = true;
                rbLoteria.Enabled = true;
                dtFecha.Enabled = true;
                enEdicion = false;
                CargarSorteos();
                ajustarPanelSorteo();
                panelCrearSorteo.Visible = !panelCrearSorteo.Visible;
            }
            else
            {
                MessageBox.Show("Error al modificar el sorteo", "Modificar sorteo",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
                tipoSorteo = "Lotería";

            }
            Boolean fechaValida = ValidarFecha(tipoSorteo,fecha);
            if (fechaValida)
            {
                if (nudFracciones.Value > 0 && nudCostoFraccion.Value > 0)
                {

                    //  Premio premio = new Premio(Convert.ToInt32(nudPremio1.Value),1);
                    int numeroSorteo = ObtenerNumeroSorteo(tipoSorteo);
                    if (cbConPlan.Checked)
                    {
                        planPremios.premios = ObtenerPlanPremios(tipoSorteo);
                        if (planPremios.premios != null)
                        {
                            Sorteo sorteo = new Sorteo(1, numeroSorteo, tipoSorteo, fecha, Convert.ToInt32(nudFracciones.Value), Convert.ToInt32(nudCostoFraccion.Value),
                            tbLeyenda.Text.Equals("") ? "Sin leyenda" : tbLeyenda.Text, false, planPremios);
                            CrearSorteo(sorteo);
                        }
                        
                    }
                    else {
                        Sorteo sorteo = new Sorteo(1, numeroSorteo, tipoSorteo, fecha, Convert.ToInt32(nudFracciones.Value), Convert.ToInt32(nudCostoFraccion.Value),
                        tbLeyenda.Text.Equals("") ? "Sin leyenda" : tbLeyenda.Text, false, planPremios);
                        CrearSorteo(sorteo);
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad de fracciones y el costo deben ser mayor a 0", "Crear sorteo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("La fecha seleccionada no es válida", "Crear sorteo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void rbLoteria_CheckedChanged(object sender, EventArgs e)
        {
            lbRestriccionSorteo.Text = "Sólo los domingos";
            btAgregarPremioAdicional.Visible = true;
            dataGridViewPremiosAdicionales.Visible = true;
            btBorrarAdicionales.Visible = true;
            lbPremiosAdicionales.Visible = true;
            lbMonto.Visible = true;
            nudMonto.Visible = true;
        }

        private void rbChances_CheckedChanged(object sender, EventArgs e)
        {
            lbRestriccionSorteo.Text = "Sólo martes y viernes";
            btAgregarPremioAdicional.Visible = false;
            dataGridViewPremiosAdicionales.Visible = false;
            btBorrarAdicionales.Visible = false;
            lbPremiosAdicionales.Visible = false;
            lbMonto.Visible = false;
            nudMonto.Visible = false;
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

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            dtSorteos.DefaultView.RowFilter = $"{filtroTipoSorteos}Número LIKE '{tbBusqueda.Text}%'";
        }

        private void dataGridViewPremiosAdicionales_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            String valor = (String)e.Value;
            if(valor.Equals(String.Empty) || !EsNumeroPositivo(valor))
            {
                e.Value = dataGridViewPremiosAdicionales.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                e.ParsingApplied = true;
            }
        }

        private void dataGridViewPremiosAdicionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Eliminamos el premioAdicional
            if (e.ColumnIndex >= 0 && e.RowIndex>=0) { 
                if (e.ColumnIndex == 0)
                {
                    DataTable dt = this.dataGridViewPremiosAdicionales.DataSource as DataTable;
                    //int montoPremio = Convert.ToInt32(dt.Rows[e.RowIndex]["Monto"].ToString());
                    //Console.WriteLine(this.dataGridViewPremiosAdicionales.RowCount);
                    this.dataGridViewPremiosAdicionales.Rows.RemoveAt(e.RowIndex);
                    //Console.WriteLine(this.dataGridViewPremiosAdicionales.RowCount);
                }
            }
        }

        private void btBorrarPlanPremios_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Realmente desea borrar el plan de premio?", "Borrando plan de premios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                nudPremio1.Value = 1;
                nudPremio2.Value = 1;
                nudPremio3.Value = 1;
                dtPremiosAdicionales.Clear();
            }
        }

        private void CargarDatosEdicion(Sorteo sorteo)
        {
            String tipoSorteo = sorteo.ObtenerTipoSorteo;
            List<Premio> premios = sorteo.ObtenerPlanPremios.ObtenerPremios;
            rbChances.Enabled = false;
            rbLoteria.Enabled = false;
            dtFecha.Enabled = false;
//            btAgregarPremioAdicional.Visible = true;
            dtFecha.Value = sorteo.ObtenerFecha;
            if (tipoSorteo.Equals("Lotería"))
            {
                rbLoteria.Checked = true;
            }
            else { rbChances.Checked = true; btAgregarPremioAdicional.Visible = false; }
            nudCostoFraccion.Value = sorteo.ObtenerPrecioFraccion;
            nudFracciones.Value = sorteo.ObtenerCantidadFracciones;
            tbLeyenda.Text = sorteo.ObtenerLeyenda;
            int largoPremios = premios.Count;
            //Por si es null,no va a tener plan de premios
            if (largoPremios != 0)
            {
                
                nudPremio1.Value = premios[0].ObtenerMonto;
                nudPremio2.Value = premios[1].ObtenerMonto;
                nudPremio3.Value = premios[2].ObtenerMonto;
                //obtengo el resto de los premios adicionales y limpio los dt y datagridview
                cbConPlan.Checked = true;
                dtPremiosAdicionales.Clear();
              
                for (int i=3;i<largoPremios;i++)
                {              
                    int montoPremio = premios[i].ObtenerMonto;
                    int cantidadPremio = premios[i].ObtenerCantidad;
                    dtPremiosAdicionales.Rows.Add(new object[] { montoPremio, cantidadPremio });

                }


            }
            

        }

        private void EliminarSorteo(Sorteo sorteo)
        {
            if (sistemaLoteriaChances.EliminarSorteo(sorteo))
            {
                if (enEdicion && sorteo.ObtenerIdSorteo.Equals(sorteoEditando.ObtenerIdSorteo))
                {

                    rbChances.Enabled = true;
                    rbLoteria.Enabled = true;
                    dtFecha.Enabled = true;
                    enEdicion = false;
                    salirInterfazEditando();
                    ajustarPanelSorteo();
                    panelCrearSorteo.Visible = !panelCrearSorteo.Visible;
                }
                CargarSorteos();
                MessageBox.Show("El sorteo se eliminó con éxito",
                    "Eliminar sorteo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El sorteo no se pudo eliminar",
                    "Eliminar sorteo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void dataGridViewSorteos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex>=0)
            {
                if (e.ColumnIndex == 0 || e.ColumnIndex == 7)
                {
                    String tipoSorteo = dtSorteos.DefaultView[e.RowIndex]["Tipo"].ToString();
                    int numeroSorteo = Convert.ToInt32(dtSorteos.DefaultView[e.RowIndex]["Número"].ToString());
                    DialogResult dr = MessageBox.Show($"¿Desea eliminar el sorteo {numeroSorteo} de {tipoSorteo}?",
                        "Eliminar sorteo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Sorteo sorteo = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipoSorteo, numeroSorteo);
                        if (!sorteo.ObtenerEstado)
                        {
                            if (enEdicion && sorteoEditando.idSorteo.Equals(sorteo.ObtenerIdSorteo))
                            {
                                DialogResult drEliminar = MessageBox.Show("Es el mismo sorteo que está editando, ¿desea eliminarlo?", "Eliminar sorteo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                if (drEliminar == DialogResult.Yes)
                                {
                                    EliminarSorteo(sorteo);
                                }
                                        

                            }
                            else
                            {
                                EliminarSorteo(sorteo);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El sorteo no se puede eliminar, ya se jugó",
                                "Eliminar sorteo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                else if (e.ColumnIndex == 1 || e.ColumnIndex == 8)
                {
                    if (!enEdicion)
                    {
                        
                        String tipoSorteo = dtSorteos.DefaultView[e.RowIndex]["Tipo"].ToString();
                        int numeroSorteo = Convert.ToInt32(dtSorteos.DefaultView[e.RowIndex]["Número"].ToString());
                        Sorteo sorteo = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipoSorteo, numeroSorteo);
                        if (!sorteo.ObtenerEstado)
                        {
                            enEdicion = true;
                            sorteoEditando = sorteo;
                            establecerInterfazEditando();
                            if (!panelCrearSorteo.Visible)
                            {
                                ajustarPanelSorteo();
                            }
                            panelCrearSorteo.Visible = true;
                            CargarDatosEdicion(sorteo);

                        }
                        else
                        {
                            MessageBox.Show("El sorteo no se puede editar, ya se jugó",
                                "Editar sorteo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("¿Desea guardar el sorteo que está editando?", "Editar sorteo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            btGuardar_Click(sender, e);
                            enEdicion = false;
                            dataGridViewSorteos_CellClick(sender, e);
                        }
                        else if(dr == DialogResult.No)
                        {
                            enEdicion = false;
                            dataGridViewSorteos_CellClick(sender, e);
                        }




                        //Está editando uno, aqui pregunto si desea guardarlo antes de editar otro

                    }

                }
            }
        }

        private void btBorrarPlanPremios_Click(object sender, EventArgs e)
        {
            if (dtPremiosAdicionales.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Realmente desea borrar los premios adicionales?", "Borrando premios adicionales", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    dtPremiosAdicionales.Clear();
                }
            }
            else {
                MessageBox.Show("No tiene premios adicionales",
                                     "Borrando premios adicionales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btCrearNuevoSorteo_Click(object sender, EventArgs e)
        {
            ajustarPanelSorteo();
            dtFecha.MinDate = DateTime.Now;
            dtFecha.Value = DateTime.Now;
            nudCostoFraccion.Value = 1;
            nudFracciones.Value = 1;
            nudMonto.Value = 1;
            nudPremio1.Value = 1;
            nudPremio2.Value = 1;
            nudPremio3.Value = 1;
            //btAgregarPremioAdicional.Enabled = true;
          //  btAgregarPremioAdicional. = true;
            tbLeyenda.Text = "";
            cbConPlan.Checked = false;
            panelCrearSorteo.Visible = !panelCrearSorteo.Visible;
            //btAgregarPremioAdicional.Visible = true;
        }

        private void btAgregarPremioAdicional_Click(object sender, EventArgs e)
        {
            Boolean agregado = false; // Me indica si el monto ya está agregado
            int monto = (int)nudMonto.Value;
            int cantidadPremiosAdicionales = dtPremiosAdicionales.Rows.Count;
            for(int i = 0; i < cantidadPremiosAdicionales; i++)
            {
                if ((int)dtPremiosAdicionales.Rows[i][0] == monto)
                {
                    int cantidadActual = (int)dtPremiosAdicionales.Rows[i][1];
                    dtPremiosAdicionales.Rows[i][1] = cantidadActual + 1;
                    agregado = true;
                }
            }
            if (!agregado)
            {
                dtPremiosAdicionales.Rows.Add(new object[] { monto, 1 });
            }
        }
    }
}
