namespace Proyecto
{
    partial class Form1
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btEstadisticasReportes = new System.Windows.Forms.Button();
            this.btResultados = new System.Windows.Forms.Button();
            this.btJugar = new System.Windows.Forms.Button();
            this.btSorteos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btEstadisticasReportes);
            this.panelMenu.Controls.Add(this.btResultados);
            this.panelMenu.Controls.Add(this.btJugar);
            this.panelMenu.Controls.Add(this.btSorteos);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.MinimumSize = new System.Drawing.Size(300, 653);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 653);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 115);
            this.panel1.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Black;
            this.panelPrincipal.Controls.Add(this.pictureBox2);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(300, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(632, 653);
            this.panelPrincipal.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.LogoJPS;
            this.pictureBox2.Location = new System.Drawing.Point(177, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            this.btEstadisticasReportes.Size = new System.Drawing.Size(300, 50);
            this.btEstadisticasReportes.TabIndex = 4;
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
            this.btResultados.Size = new System.Drawing.Size(300, 50);
            this.btResultados.TabIndex = 3;
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
            this.btJugar.Size = new System.Drawing.Size(300, 50);
            this.btJugar.TabIndex = 2;
            this.btJugar.Text = "Jugar Sorteos";
            this.btJugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btJugar.UseVisualStyleBackColor = false;
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
            this.btSorteos.Size = new System.Drawing.Size(300, 50);
            this.btSorteos.TabIndex = 1;
            this.btSorteos.Text = "Mantenimiento Sorteos";
            this.btSorteos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSorteos.UseVisualStyleBackColor = false;
            this.btSorteos.Click += new System.EventHandler(this.btSorteos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.LogoHorizontalJPS;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JPS - Lotería y Chances";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSorteos;
        private System.Windows.Forms.Button btEstadisticasReportes;
        private System.Windows.Forms.Button btResultados;
        private System.Windows.Forms.Button btJugar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

