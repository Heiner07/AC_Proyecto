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
        private Button[] botones;
        SistemaLoteriaChances sistemaLC = new SistemaLoteriaChances();


        public FormPrincipal()
        {
            InitializeComponent();
            botones = new Button[] { btSorteos, btJugar, btResultados, btEstadisticasReportes };
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
            if(!JugandoSorteo())
            {
                if (formularioActivo != null)
                {
                    formularioActivo.Close();
                    formularioActivo.Dispose();
                }
                if (formularioAbierto != -1) botones[formularioAbierto].BackColor = Color.Brown;
                if (numeroForm != -1) botones[numeroForm].BackColor = Color.Crimson;
                formularioAbierto = numeroForm;

                formularioActivo = formularioHijo;
                formularioHijo.TopLevel = false;
                formularioHijo.FormBorderStyle = FormBorderStyle.None;
                formularioHijo.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(formularioHijo);
                panelPrincipal.Tag = formularioHijo;

                formularioHijo.BringToFront();
                formularioHijo.Show();
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
            if (formularioAbierto != 0)
            {
                abrirFormularioHijo(new FormMantenimientoSorteos(sistemaLC), 0);
            }
        }

        private void btJugar_Click(object sender, EventArgs e)
        {
            if (formularioAbierto != 1)
            {
                abrirFormularioHijo(new FormJugar(sistemaLC), 1);
            }
        }

        private void btResultados_Click(object sender, EventArgs e)
        {
            if (formularioAbierto != 2)
            {
                abrirFormularioHijo(new FormResultados(sistemaLC), 2);
            }
        }

        private void btEstadisticasReportes_Click(object sender, EventArgs e)
        {
            if (formularioAbierto != 3)
            {
                abrirFormularioHijo(new FormEstadisticasReportes(sistemaLC), 3);
            }
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = sistemaLC.IniciarSesion(tbUsuario.Text,tbContrasenia.Text);
            if (usuario != null)
            {
                int rol = 1;//usuario.obtenerRol();
                if (rol != -1)
                {
                    establecerEstadoBotones(rol, true);
                    panelIniciarSesion.Visible = false;
                    panelCerrarSesion.Visible = true;
                    lbModo.Text = usuario.ObtenerNombre;
                    panelPrincipal.BackColor = Color.White;
                    abrirFormularioHijo(new FormIniciar(sistemaLC), -1);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos",
                        "Iniciando sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Error de conexión con la base de datos",
                        "Iniciando sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void btCerrarSesion_Click(object sender, EventArgs e)
        {
            if (!JugandoSorteo())
            {
                establecerEstadoBotones(1, false);
                panelIniciarSesion.Visible = true;
                panelCerrarSesion.Visible = false;
                tbContrasenia.Text = "";
                tbUsuario.Text = "";
                if (formularioActivo != null)
                {
                    formularioActivo.Close();
                    formularioActivo.Dispose();
                }
                panelPrincipal.BackColor = Color.Maroon;
                if (formularioAbierto != -1) botones[formularioAbierto].BackColor = Color.Brown;
            }
            else
            {
                MessageBox.Show("No se puede salir, un sorteo se está realizando.\n" +
                    "Puede terminarlo de forma rápida presionando el botón \"Omitir " +
                    "animación\" o espere a que termine.",
                    "Realizando sorteo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (JugandoSorteo())
            {
                MessageBox.Show("No se puede salir, un sorteo se está realizando.\n" +
                    "Puede terminarlo de forma rápida presionando el botón \"Omitir " +
                    "animación\" o espere a que termine.",
                    "Realizando sorteo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (formularioAbierto != -1)
            {
                abrirFormularioHijo(new FormIniciar(sistemaLC), -1);
            }
        }

        private Boolean JugandoSorteo()
        {
            return ((formularioAbierto == 1 && ((FormJugar)formularioActivo).RealizandoSorteo()));
        }
    }
}
