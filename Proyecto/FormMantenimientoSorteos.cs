using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            dataGridViewPremiosAdicionales.Columns[0].ReadOnly = true;
        }

        private void EstablecerValoresTablaSorteos()
        {
            dtSorteos = new DataTable();
            dtSorteos.Columns.Add("Tipo", typeof(string));
            dtSorteos.Columns.Add("Número", typeof(string));
            dtSorteos.Columns.Add("Fecha", typeof(string));
            dtSorteos.Columns.Add("Número fracciones", typeof(int));
            dtSorteos.Columns.Add("Costo fracción", typeof(string));
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
                    dtSorteos.Rows.Add(new object[] { sorteo.TipoSorteo, sorteo.NumeroSorteo,
                        sorteo.Fecha.ToShortDateString(), sorteo.CantidadFracciones,
                        sorteo.PrecioFraccion.ToString("#,#", CultureInfo.InvariantCulture),
                        sorteo.LeyendaBillete, sorteo.Estado });
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

        private void EstablecerInterfazEditando()
        {
            lbEditarSorteo.Visible = true;
            lbEditarSorteo.Text = $"Editando sorteo {sorteoEditando.NumeroSorteo} de {sorteoEditando.TipoSorteo}";
            btGuardar.Visible = true;
            btCancelar.Visible = true;
            btCrearNuevoSorteo.Visible = false;
            btCrear.Visible = false;
        }

        private void SalirInterfazEditando()
        {
            lbEditarSorteo.Visible = false;
            btGuardar.Visible = false;
            btCancelar.Visible = false;
            btCrearNuevoSorteo.Visible = true;
            btCrear.Visible = true;
        }

        private void AjustarPanelSorteo()
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

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            PlanPremios planPremios = new PlanPremios();
            if (nudFracciones.Value > 0 && nudCostoFraccion.Value > 0)
            {
                if (cbConPlan.Checked)
                {
                    planPremios.Premios = ObtenerPlanPremios(sorteoEditando.TipoSorteo);
                    if (planPremios.Premios != null)
                    {
                        Sorteo sorteo = new Sorteo(sorteoEditando.IdSorteo, sorteoEditando.NumeroSorteo, sorteoEditando.TipoSorteo, sorteoEditando.Fecha, Convert.ToInt32(nudFracciones.Value), Convert.ToInt32(nudCostoFraccion.Value),
                        tbLeyenda.Text.Equals("") ? "Sin leyenda" : tbLeyenda.Text, false, planPremios);
                        sorteoEditando = sorteo;
                        ModificarSorteo(sorteoEditando);
                    }

                }
                else
                {
                    Sorteo sorteo = new Sorteo(sorteoEditando.IdSorteo, sorteoEditando.NumeroSorteo, sorteoEditando.TipoSorteo, sorteoEditando.Fecha, Convert.ToInt32(nudFracciones.Value), Convert.ToInt32(nudCostoFraccion.Value),
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

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            SalirInterfazEditando();
            rbChances.Enabled = true;
            rbLoteria.Enabled = true;
            dtFecha.Enabled = true;
            enEdicion = false;
            dtPremiosAdicionales.Clear();
            AjustarPanelSorteo();
            panelCrearSorteo.Visible = !panelCrearSorteo.Visible;
        }


        private Boolean ValidarFecha(String tipoSorteo, DateTime fecha) {
            List<Sorteo> sorteos = sistemaLoteriaChances.ObtenerSorteos();
            foreach (Sorteo sorteo in sorteos)
            {
                if (sorteo.Fecha.Date >= fecha.Date)
                {
                    return false;
                }
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
            foreach (Sorteo sorteo in sorteos)
            {
                if (sorteo.TipoSorteo.Equals(tipoSorteo)) {
                    numeroRetornado = sorteo.NumeroSorteo;

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
                    if (montoPremio > 0 && cantidad > 0)
                    {
                        if (montoPremio < tercerPremio)
                        {
                            //Buscamos si existe uno igual
                            Boolean noAgregado = true;
                            foreach (Premio premio in premios)
                            {
                                if (premio.CantidadPremio == cantidad && premio.MontoPremio == montoPremio)
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
                SalirInterfazEditando();
                dtPremiosAdicionales.Clear();
                rbChances.Enabled = true;
                rbLoteria.Enabled = true;
                dtFecha.Enabled = true;
                enEdicion = false;
                CargarSorteos();
                AjustarPanelSorteo();
                panelCrearSorteo.Visible = !panelCrearSorteo.Visible;
            }
            else
            {
                MessageBox.Show("Error al modificar el sorteo", "Modificar sorteo",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtCrear_Click(object sender, EventArgs e)
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
            Boolean fechaValida = ValidarFecha(tipoSorteo, fecha);
            if (fechaValida)
            {
                if (nudFracciones.Value > 0 && nudCostoFraccion.Value > 0)
                {
                    int numeroSorteo = ObtenerNumeroSorteo(tipoSorteo);
                    if (cbConPlan.Checked)
                    {
                        planPremios.Premios = ObtenerPlanPremios(tipoSorteo);
                        if (planPremios.Premios != null)
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

        private void RbLoteria_CheckedChanged(object sender, EventArgs e)
        {
            lbRestriccionSorteo.Text = "Sólo los domingos";
            btAgregarPremioAdicional.Visible = true;
            dataGridViewPremiosAdicionales.Visible = true;
            btBorrarAdicionales.Visible = true;
            lbPremiosAdicionales.Visible = true;
            lbMonto.Visible = true;
            nudMonto.Visible = true;
        }

        private void RbChances_CheckedChanged(object sender, EventArgs e)
        {
            lbRestriccionSorteo.Text = "Sólo martes y viernes";
            btAgregarPremioAdicional.Visible = false;
            dataGridViewPremiosAdicionales.Visible = false;
            btBorrarAdicionales.Visible = false;
            lbPremiosAdicionales.Visible = false;
            lbMonto.Visible = false;
            nudMonto.Visible = false;
        }

        private void RbFiltroTodos_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "";
            TbBusqueda_TextChanged(sender, e);
        }

        private void RbFiltroLoteria_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "Tipo = 'Lotería' AND ";
            TbBusqueda_TextChanged(sender, e);
        }

        private void RbFiltroChances_CheckedChanged(object sender, EventArgs e)
        {
            filtroTipoSorteos = "Tipo = 'Chances' AND ";
            TbBusqueda_TextChanged(sender, e);
        }

        private void TbBusqueda_TextChanged(object sender, EventArgs e)
        {
            dtSorteos.DefaultView.RowFilter = $"{filtroTipoSorteos}Número LIKE '{tbBusqueda.Text}%'";
        }

        private void DataGridViewPremiosAdicionales_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            String valor = (String)e.Value;
            if (valor.Equals(String.Empty) || !EsNumeroPositivo(valor))
            {
                e.Value = dataGridViewPremiosAdicionales.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                e.ParsingApplied = true;
            }
        }

        private void DataGridViewPremiosAdicionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Eliminamos el premioAdicional
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0) {
                if (e.ColumnIndex == 0)
                {
                    DataTable dt = this.dataGridViewPremiosAdicionales.DataSource as DataTable;
                    this.dataGridViewPremiosAdicionales.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void BtBorrarPlanPremios_Click_1(object sender, EventArgs e)
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
            String tipoSorteo = sorteo.TipoSorteo;
            List<Premio> premios = sorteo.PlanPremios.Premios;
            rbChances.Enabled = false;
            rbLoteria.Enabled = false;
            dtFecha.Enabled = false;
            dtFecha.Value = sorteo.Fecha;
            
            if (tipoSorteo.Equals("Lotería"))
            {
                rbLoteria.Checked = true;
            }
            else { rbChances.Checked = true; btAgregarPremioAdicional.Visible = false; }
            nudCostoFraccion.Value = sorteo.PrecioFraccion;
            nudFracciones.Value = sorteo.CantidadFracciones;
            tbLeyenda.Text = sorteo.LeyendaBillete;
            int largoPremios = premios.Count;
            PlanPremiosEstado(cbConPlan.Checked);
            //Por si es null,no va a tener plan de premios
            nudPremio1.Value = 1;
            nudPremio2.Value = 1;
            nudPremio3.Value = 1;
            if (largoPremios != 0)
            {

                nudPremio1.Value = premios[0].MontoPremio;
                nudPremio2.Value = premios[1].MontoPremio;
                nudPremio3.Value = premios[2].MontoPremio;
                //obtengo el resto de los premios adicionales y limpio los dt y datagridview
                cbConPlan.Checked = true;
                dtPremiosAdicionales.Clear();

                for (int i = 3; i < largoPremios; i++)
                {
                    int montoPremio = premios[i].MontoPremio;
                    int cantidadPremio = premios[i].CantidadPremio;
                    dtPremiosAdicionales.Rows.Add(new object[] { montoPremio, cantidadPremio });

                }
            }
        }

        private void PlanPremiosEstado(Boolean estado) {
            nudPremio1.Enabled = estado;
            nudPremio2.Enabled = estado;
            nudPremio3.Enabled = estado;
            nudMonto.Enabled = estado;
            btBorrarAdicionales.Enabled = estado;
            btBorrarPlanPremios.Enabled = estado;
            btAgregarPremioAdicional.Enabled = estado;

        }

        

        private void cbConPlan_CheckedChanged(object sender, EventArgs e)
        {
            PlanPremiosEstado(cbConPlan.Checked);
            
        }

        private void EliminarSorteo(Sorteo sorteo)
        {
            if (sistemaLoteriaChances.EliminarSorteo(sorteo))
            {
                if (enEdicion && sorteo.IdSorteo.Equals(sorteoEditando.IdSorteo))
                {
                    rbChances.Enabled = true;
                    rbLoteria.Enabled = true;
                    dtFecha.Enabled = true;
                    enEdicion = false;
                    SalirInterfazEditando();
                    AjustarPanelSorteo();
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

        private void DataGridViewSorteos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex>=0)
            {
                if (e.ColumnIndex == 0)
                {
                    String tipoSorteo = dtSorteos.DefaultView[e.RowIndex]["Tipo"].ToString();
                    int numeroSorteo = Convert.ToInt32(dtSorteos.DefaultView[e.RowIndex]["Número"].ToString());
                    DialogResult dr = MessageBox.Show($"¿Desea eliminar el sorteo {numeroSorteo} de {tipoSorteo}?",
                        "Eliminar sorteo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Sorteo sorteo = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipoSorteo, numeroSorteo);
                        if (!sorteo.Estado)
                        {
                            if (enEdicion && sorteoEditando.IdSorteo.Equals(sorteo.IdSorteo))
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
                else if (e.ColumnIndex == 1)
                {
                    if (!enEdicion)
                    {
                        
                        String tipoSorteo = dtSorteos.DefaultView[e.RowIndex]["Tipo"].ToString();
                        int numeroSorteo = Convert.ToInt32(dtSorteos.DefaultView[e.RowIndex]["Número"].ToString());
                        Sorteo sorteo = sistemaLoteriaChances.ObtenerSorteoSeleccionado(tipoSorteo, numeroSorteo);
                        if (!sorteo.Estado)
                        {
                            enEdicion = true;
                            sorteoEditando = sorteo;
                            EstablecerInterfazEditando();
                            if (!panelCrearSorteo.Visible)
                            {
                                AjustarPanelSorteo();
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
                            BtGuardar_Click(sender, e);
                            enEdicion = false;
                            DataGridViewSorteos_CellClick(sender, e);
                        }
                        else if(dr == DialogResult.No)
                        {
                            enEdicion = false;
                            DataGridViewSorteos_CellClick(sender, e);
                        }
                        //Está editando uno, aqui pregunto si desea guardarlo antes de editar otro
                    }
                }
            }
        }

        private void BtBorrarPlanPremios_Click(object sender, EventArgs e)
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

        private void BtCrearNuevoSorteo_Click(object sender, EventArgs e)
        {
            AjustarPanelSorteo();
            dtFecha.MinDate = DateTime.Now;
            dtFecha.Value = DateTime.Now;
            nudCostoFraccion.Value = 1;
            nudFracciones.Value = 1;
            nudMonto.Value = 1;
            nudPremio1.Value = 1;
            nudPremio2.Value = 1;
            nudPremio3.Value = 1;
            tbLeyenda.Text = "";
            cbConPlan.Checked = false;
            PlanPremiosEstado(false) ;
            panelCrearSorteo.Visible = !panelCrearSorteo.Visible;
        }

        private void BtAgregarPremioAdicional_Click(object sender, EventArgs e)
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
