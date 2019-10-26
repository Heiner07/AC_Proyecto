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
        SistemaLoteriaChances sistemaLC = new SistemaLoteriaChances();

        public FormPrincipal()
        {
            InitializeComponent();
            establecerEstadoBotones(1,false);
            panelCerrarSesion.Visible = false;
            tbContrasenia.PasswordChar = '*';
            tbContrasenia.MaxLength = 10;
        }

        private void personalizarDiseno()
        {
            
        }

        private void establecerEstadoBotones(int rol,Boolean estado)
        {
            if (rol == 0)
            {
                btResultados.Enabled = estado;
                btEstadisticasReportes.Enabled = estado;
            }
            else {
                btSorteos.Enabled = estado;
                btJugar.Enabled = estado;
                btResultados.Enabled = estado;
                btEstadisticasReportes.Enabled = estado;
            }
           
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
            Usuario usuario = sistemaLC.iniciarSesion(tbUsuario.Text,tbContrasenia.Text);
            int rol = usuario.obtenerRol();
            if (rol != -1)
            {
                establecerEstadoBotones(rol, true);
                panelIniciarSesion.Visible = false;
                panelCerrarSesion.Visible = true;
                lbModo.Text = usuario.obtenerNombre();
            }
            else {
                MessageBox.Show("ERROR AL ENTRAR AL SISTEMA");
               
            }

        }
       

        private void btCerrarSesion_Click(object sender, EventArgs e)
        {
            establecerEstadoBotones(1,false);
            panelIniciarSesion.Visible = true;
            panelCerrarSesion.Visible = false;
            tbContrasenia.Text = "";
            tbUsuario.Text = "";
            if (formularioActivo != null)
            {
                formularioActivo.Dispose();
            }
        }

        
    }
}
