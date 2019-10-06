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
    public partial class FormPrincipal : Form
    {
        private Form formularioActivo = null;

        public FormPrincipal()
        {
            InitializeComponent();
            establecerEstadoBotones(false);
            panelCerrarSesion.Visible = false;
        }

        private void personalizarDiseno()
        {
            
        }

        private void establecerEstadoBotones(Boolean estado)
        {
            btSorteos.Enabled = estado;
            btJugar.Enabled = estado;
            btResultados.Enabled = estado;
            btEstadisticasReportes.Enabled = estado;
        }

        private void abrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Dispose();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formularioHijo);
            panelPrincipal.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }

        private void btSorteos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormMantenimientoSorteos());
        }

        private void btJugar_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormJugar());
        }

        private void btResultados_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormResultados());
        }

        private void btEstadisticasReportes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormEstadisticasReportes());
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            establecerEstadoBotones(true);
            panelIniciarSesion.Visible = false;
            panelCerrarSesion.Visible = true;
        }

        private void btCerrarSesion_Click(object sender, EventArgs e)
        {
            establecerEstadoBotones(false);
            panelIniciarSesion.Visible = true;
            panelCerrarSesion.Visible = false;
            if (formularioActivo != null)
            {
                formularioActivo.Dispose();
            }
        }
    }
}
