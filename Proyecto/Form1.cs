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
    public partial class Form1 : Form
    {
        private Form formularioActivo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void personalizarDiseno()
        {

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

        private void btResultados_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormResultados());
        }

        private void btEstadisticasReportes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormEstadisticasReportes());
        }
    }
}
