namespace Proyecto
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCerrarSesion = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btCerrarSesion = new System.Windows.Forms.Button();
            this.lbModo = new System.Windows.Forms.Label();
            this.panelIniciarSesion = new System.Windows.Forms.Panel();
            this.btIniciarSesion = new System.Windows.Forms.Button();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEstadisticasReportes = new System.Windows.Forms.Button();
            this.btResultados = new System.Windows.Forms.Button();
            this.btJugar = new System.Windows.Forms.Button();
            this.btSorteos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCerrarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelIniciarSesion.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.MinimumSize = new System.Drawing.Size(300, 653);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 673);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelCerrarSesion);
            this.panel1.Controls.Add(this.panelIniciarSesion);
            this.panel1.Controls.Add(this.btEstadisticasReportes);
            this.panel1.Controls.Add(this.btResultados);
            this.panel1.Controls.Add(this.btJugar);
            this.panel1.Controls.Add(this.btSorteos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 649);
            this.panel1.TabIndex = 0;
            // 
            // panelCerrarSesion
            // 
            this.panelCerrarSesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCerrarSesion.Controls.Add(this.pictureBox3);
            this.panelCerrarSesion.Controls.Add(this.btCerrarSesion);
            this.panelCerrarSesion.Controls.Add(this.lbModo);
            this.panelCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCerrarSesion.Location = new System.Drawing.Point(0, 317);
            this.panelCerrarSesion.Name = "panelCerrarSesion";
            this.panelCerrarSesion.Size = new System.Drawing.Size(282, 166);
            this.panelCerrarSesion.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(17, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // btCerrarSesion
            // 
            this.btCerrarSesion.BackColor = System.Drawing.Color.Brown;
            this.btCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCerrarSesion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCerrarSesion.Location = new System.Drawing.Point(0, 123);
            this.btCerrarSesion.Name = "btCerrarSesion";
            this.btCerrarSesion.Size = new System.Drawing.Size(282, 40);
            this.btCerrarSesion.TabIndex = 11;
            this.btCerrarSesion.Text = "Cerrar Sesión";
            this.btCerrarSesion.UseVisualStyleBackColor = false;
            this.btCerrarSesion.Click += new System.EventHandler(this.btCerrarSesion_Click);
            // 
            // lbModo
            // 
            this.lbModo.AutoSize = true;
            this.lbModo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModo.Location = new System.Drawing.Point(102, 24);
            this.lbModo.Name = "lbModo";
            this.lbModo.Size = new System.Drawing.Size(65, 19);
            this.lbModo.TabIndex = 1;
            this.lbModo.Text = "Usuario";
            // 
            // panelIniciarSesion
            // 
            this.panelIniciarSesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIniciarSesion.Controls.Add(this.btIniciarSesion);
            this.panelIniciarSesion.Controls.Add(this.tbContrasenia);
            this.panelIniciarSesion.Controls.Add(this.label2);
            this.panelIniciarSesion.Controls.Add(this.tbUsuario);
            this.panelIniciarSesion.Controls.Add(this.label1);
            this.panelIniciarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIniciarSesion.Location = new System.Drawing.Point(0, 483);
            this.panelIniciarSesion.Name = "panelIniciarSesion";
            this.panelIniciarSesion.Size = new System.Drawing.Size(282, 166);
            this.panelIniciarSesion.TabIndex = 10;
            // 
            // btIniciarSesion
            // 
            this.btIniciarSesion.BackColor = System.Drawing.Color.Brown;
            this.btIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIniciarSesion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btIniciarSesion.Location = new System.Drawing.Point(0, 123);
            this.btIniciarSesion.Name = "btIniciarSesion";
            this.btIniciarSesion.Size = new System.Drawing.Size(282, 40);
            this.btIniciarSesion.TabIndex = 10;
            this.btIniciarSesion.Text = "Iniciar Sesión";
            this.btIniciarSesion.UseVisualStyleBackColor = false;
            this.btIniciarSesion.Click += new System.EventHandler(this.btIniciarSesion_Click);
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(7, 92);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(258, 22);
            this.tbContrasenia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(7, 35);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(258, 22);
            this.tbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // btEstadisticasReportes
            // 
            this.btEstadisticasReportes.BackColor = System.Drawing.Color.Brown;
            this.btEstadisticasReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEstadisticasReportes.FlatAppearance.BorderSize = 0;
            this.btEstadisticasReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstadisticasReportes.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEstadisticasReportes.ForeColor = System.Drawing.Color.White;
            this.btEstadisticasReportes.Image = global::Proyecto.Properties.Resources.estadisticas;
            this.btEstadisticasReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEstadisticasReportes.Location = new System.Drawing.Point(0, 265);
            this.btEstadisticasReportes.Name = "btEstadisticasReportes";
            this.btEstadisticasReportes.Size = new System.Drawing.Size(282, 50);
            this.btEstadisticasReportes.TabIndex = 9;
            this.btEstadisticasReportes.Text = "Estadísticas y Reportes";
            this.btEstadisticasReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEstadisticasReportes.UseVisualStyleBackColor = false;
            this.btEstadisticasReportes.Click += new System.EventHandler(this.btEstadisticasReportes_Click);
            // 
            // btResultados
            // 
            this.btResultados.BackColor = System.Drawing.Color.Brown;
            this.btResultados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btResultados.FlatAppearance.BorderSize = 0;
            this.btResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResultados.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResultados.ForeColor = System.Drawing.Color.White;
            this.btResultados.Image = global::Proyecto.Properties.Resources.resultados;
            this.btResultados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btResultados.Location = new System.Drawing.Point(0, 215);
            this.btResultados.Name = "btResultados";
            this.btResultados.Size = new System.Drawing.Size(282, 50);
            this.btResultados.TabIndex = 8;
            this.btResultados.Text = "Resultados";
            this.btResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btResultados.UseVisualStyleBackColor = false;
            this.btResultados.Click += new System.EventHandler(this.btResultados_Click);
            // 
            // btJugar
            // 
            this.btJugar.BackColor = System.Drawing.Color.Brown;
            this.btJugar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btJugar.FlatAppearance.BorderSize = 0;
            this.btJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btJugar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJugar.ForeColor = System.Drawing.Color.White;
            this.btJugar.Image = global::Proyecto.Properties.Resources.lottery2;
            this.btJugar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btJugar.Location = new System.Drawing.Point(0, 165);
            this.btJugar.Name = "btJugar";
            this.btJugar.Size = new System.Drawing.Size(282, 50);
            this.btJugar.TabIndex = 7;
            this.btJugar.Text = "Jugar Sorteos";
            this.btJugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btJugar.UseVisualStyleBackColor = false;
            this.btJugar.Click += new System.EventHandler(this.btJugar_Click);
            // 
            // btSorteos
            // 
            this.btSorteos.BackColor = System.Drawing.Color.Brown;
            this.btSorteos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSorteos.FlatAppearance.BorderSize = 0;
            this.btSorteos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSorteos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSorteos.ForeColor = System.Drawing.Color.White;
            this.btSorteos.Image = global::Proyecto.Properties.Resources.mantenimientoSorteos;
            this.btSorteos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSorteos.Location = new System.Drawing.Point(0, 115);
            this.btSorteos.Name = "btSorteos";
            this.btSorteos.Size = new System.Drawing.Size(282, 50);
            this.btSorteos.TabIndex = 6;
            this.btSorteos.Text = "Mantenimiento Sorteos";
            this.btSorteos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSorteos.UseVisualStyleBackColor = false;
            this.btSorteos.Click += new System.EventHandler(this.btSorteos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 115);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.LogoHorizontalJPS;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.Color.Maroon;
            this.panelPrincipal.Controls.Add(this.pictureBox2);
            this.panelPrincipal.Location = new System.Drawing.Point(6, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(642, 650);
            this.panelPrincipal.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.LogoJPS;
            this.pictureBox2.Location = new System.Drawing.Point(182, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panelPrincipal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 673);
            this.panel3.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(961, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JPS - Lotería y Chances";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCerrarSesion.ResumeLayout(false);
            this.panelCerrarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelIniciarSesion.ResumeLayout(false);
            this.panelIniciarSesion.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEstadisticasReportes;
        private System.Windows.Forms.Button btResultados;
        private System.Windows.Forms.Button btJugar;
        private System.Windows.Forms.Button btSorteos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelIniciarSesion;
        private System.Windows.Forms.Button btIniciarSesion;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCerrarSesion;
        private System.Windows.Forms.Button btCerrarSesion;
        private System.Windows.Forms.Label lbModo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

