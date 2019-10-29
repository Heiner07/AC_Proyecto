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
        private int formularioAbierto = -1; //0:Sorteos, 1:Jugar, 2:Resultados, 3:Estadísticas
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

        private void abrirFormularioHijo(Form formularioHijo, int numeroForm)
        {
            if((formularioAbierto == 1 && !((FormJugar)formularioActivo).RealizandoSorteo()) ||
                formularioAbierto != 1)
            {
                if (formularioActivo != null)
                {
                    formularioActivo.Close();
                }
                formularioActivo = formularioHijo;
                formularioHijo.TopLevel = false;
                formularioHijo.FormBorderStyle = FormBorderStyle.None;
                formularioHijo.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(formularioHijo);
                panelPrincipal.Tag = formularioHijo;
                formularioHijo.BringToFront();
                formularioHijo.Show();
                formularioAbierto = numeroForm;
            }
            else
            {
                MessageBox.Show("No se puede salir, un sorteo se está realizando.\n"+
                    "Puede terminarlo de forma rápida presionando el botón \"Omitir " +
                    "animación\" o espere a que termine.",
                    "Realizando sorteo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSorteos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormMantenimientoSorteos(sistemaLC), 0);
        }

        private void btJugar_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormJugar(sistemaLC), 1);
        }

        private void btResultados_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormResultados(), 2);
        }

        private void btEstadisticasReportes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormEstadisticasReportes(sistemaLC), 3);
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = sistemaLC.IniciarSesion(tbUsuario.Text,tbContrasenia.Text);
            int rol = 1;//usuario.obtenerRol();
            if (rol != -1)
            {
                establecerEstadoBotones(rol, true);
                panelIniciarSesion.Visible = false;
                panelCerrarSesion.Visible = true;
                lbModo.Text = usuario.ObtenerNombre;
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

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formularioAbierto == 1 && ((FormJugar)formularioActivo).RealizandoSorteo())
            {
                MessageBox.Show("No se puede salir, un sorteo se está realizando.\n" +
                    "Puede terminarlo de forma rápida presionando el botón \"Omitir " +
                    "animación\" o espere a que termine.",
                    "Realizando sorteo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
