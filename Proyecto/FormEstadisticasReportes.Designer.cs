namespace Proyecto
{
    partial class FormEstadisticasReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbFiltroTodos = new System.Windows.Forms.RadioButton();
            this.rbFiltroChances = new System.Windows.Forms.RadioButton();
            this.rbFiltroLoteria = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSorteos = new System.Windows.Forms.DataGridView();
            this.dgvNumerosMasJugados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTopNumeroDineroRepartido = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTop5GanadoresPrimer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPorcentajeAparicion = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorteos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosMasJugados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopNumeroDineroRepartido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5GanadoresPrimer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorcentajeAparicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 650);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbFiltroTodos);
            this.tabPage1.Controls.Add(this.rbFiltroChances);
            this.tabPage1.Controls.Add(this.rbFiltroLoteria);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.tbBusqueda);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dgvSorteos);
            this.tabPage1.Controls.Add(this.dgvNumerosMasJugados);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvTopNumeroDineroRepartido);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvTop5GanadoresPrimer);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(782, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbFiltroTodos
            // 
            this.rbFiltroTodos.AutoSize = true;
            this.rbFiltroTodos.Checked = true;
            this.rbFiltroTodos.Location = new System.Drawing.Point(242, 2);
            this.rbFiltroTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFiltroTodos.Name = "rbFiltroTodos";
            this.rbFiltroTodos.Size = new System.Drawing.Size(69, 21);
            this.rbFiltroTodos.TabIndex = 54;
            this.rbFiltroTodos.TabStop = true;
            this.rbFiltroTodos.Text = "Todos";
            this.rbFiltroTodos.UseVisualStyleBackColor = true;
            this.rbFiltroTodos.CheckedChanged += new System.EventHandler(this.RbFiltroTodos_CheckedChanged);
            // 
            // rbFiltroChances
            // 
            this.rbFiltroChances.AutoSize = true;
            this.rbFiltroChances.Location = new System.Drawing.Point(396, 2);
            this.rbFiltroChances.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFiltroChances.Name = "rbFiltroChances";
            this.rbFiltroChances.Size = new System.Drawing.Size(84, 21);
            this.rbFiltroChances.TabIndex = 53;
            this.rbFiltroChances.Text = "Chances";
            this.rbFiltroChances.UseVisualStyleBackColor = true;
            this.rbFiltroChances.CheckedChanged += new System.EventHandler(this.RbFiltroChances_CheckedChanged);
            // 
            // rbFiltroLoteria
            // 
            this.rbFiltroLoteria.AutoSize = true;
            this.rbFiltroLoteria.Location = new System.Drawing.Point(317, 2);
            this.rbFiltroLoteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFiltroLoteria.Name = "rbFiltroLoteria";
            this.rbFiltroLoteria.Size = new System.Drawing.Size(73, 21);
            this.rbFiltroLoteria.TabIndex = 52;
            this.rbFiltroLoteria.Text = "Lotería";
            this.rbFiltroLoteria.UseVisualStyleBackColor = true;
            this.rbFiltroLoteria.CheckedChanged += new System.EventHandler(this.RbFiltroLoteria_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "Filtrar estadísticas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(424, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 19);
            this.label11.TabIndex = 50;
            this.label11.Text = "Buscar número:";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(556, 387);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(140, 22);
            this.tbBusqueda.TabIndex = 49;
            this.tbBusqueda.TextChanged += new System.EventHandler(this.TbBusqueda_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 19);
            this.label10.TabIndex = 48;
            this.label10.Text = "Sorteos existentes";
            // 
            // dgvSorteos
            // 
            this.dgvSorteos.AllowUserToAddRows = false;
            this.dgvSorteos.AllowUserToDeleteRows = false;
            this.dgvSorteos.AllowUserToResizeColumns = false;
            this.dgvSorteos.AllowUserToResizeRows = false;
            this.dgvSorteos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSorteos.BackgroundColor = System.Drawing.Color.White;
            this.dgvSorteos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorteos.Location = new System.Drawing.Point(92, 413);
            this.dgvSorteos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSorteos.Name = "dgvSorteos";
            this.dgvSorteos.ReadOnly = true;
            this.dgvSorteos.RowHeadersWidth = 51;
            this.dgvSorteos.RowTemplate.Height = 24;
            this.dgvSorteos.Size = new System.Drawing.Size(604, 196);
            this.dgvSorteos.TabIndex = 47;
            this.dgvSorteos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSorteos_CellContentClick);
            // 
            // dgvNumerosMasJugados
            // 
            this.dgvNumerosMasJugados.AllowUserToAddRows = false;
            this.dgvNumerosMasJugados.AllowUserToDeleteRows = false;
            this.dgvNumerosMasJugados.AllowUserToResizeColumns = false;
            this.dgvNumerosMasJugados.AllowUserToResizeRows = false;
            this.dgvNumerosMasJugados.BackgroundColor = System.Drawing.Color.White;
            this.dgvNumerosMasJugados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumerosMasJugados.Location = new System.Drawing.Point(92, 50);
            this.dgvNumerosMasJugados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNumerosMasJugados.Name = "dgvNumerosMasJugados";
            this.dgvNumerosMasJugados.ReadOnly = true;
            this.dgvNumerosMasJugados.RowHeadersWidth = 51;
            this.dgvNumerosMasJugados.RowTemplate.Height = 24;
            this.dgvNumerosMasJugados.Size = new System.Drawing.Size(245, 326);
            this.dgvNumerosMasJugados.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Números más jugados";
            // 
            // dgvTopNumeroDineroRepartido
            // 
            this.dgvTopNumeroDineroRepartido.AllowUserToAddRows = false;
            this.dgvTopNumeroDineroRepartido.AllowUserToDeleteRows = false;
            this.dgvTopNumeroDineroRepartido.AllowUserToResizeColumns = false;
            this.dgvTopNumeroDineroRepartido.AllowUserToResizeRows = false;
            this.dgvTopNumeroDineroRepartido.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopNumeroDineroRepartido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopNumeroDineroRepartido.Location = new System.Drawing.Point(376, 226);
            this.dgvTopNumeroDineroRepartido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTopNumeroDineroRepartido.Name = "dgvTopNumeroDineroRepartido";
            this.dgvTopNumeroDineroRepartido.ReadOnly = true;
            this.dgvTopNumeroDineroRepartido.RowHeadersWidth = 51;
            this.dgvTopNumeroDineroRepartido.RowTemplate.Height = 24;
            this.dgvTopNumeroDineroRepartido.Size = new System.Drawing.Size(320, 150);
            this.dgvTopNumeroDineroRepartido.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Números con mayor dinero repartido";
            // 
            // dgvTop5GanadoresPrimer
            // 
            this.dgvTop5GanadoresPrimer.AllowUserToAddRows = false;
            this.dgvTop5GanadoresPrimer.AllowUserToDeleteRows = false;
            this.dgvTop5GanadoresPrimer.AllowUserToResizeColumns = false;
            this.dgvTop5GanadoresPrimer.AllowUserToResizeRows = false;
            this.dgvTop5GanadoresPrimer.BackgroundColor = System.Drawing.Color.White;
            this.dgvTop5GanadoresPrimer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop5GanadoresPrimer.Location = new System.Drawing.Point(376, 50);
            this.dgvTop5GanadoresPrimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTop5GanadoresPrimer.Name = "dgvTop5GanadoresPrimer";
            this.dgvTop5GanadoresPrimer.ReadOnly = true;
            this.dgvTop5GanadoresPrimer.RowHeadersWidth = 51;
            this.dgvTop5GanadoresPrimer.RowTemplate.Height = 24;
            this.dgvTop5GanadoresPrimer.Size = new System.Drawing.Size(320, 150);
            this.dgvTop5GanadoresPrimer.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Números más ganadores del primer premio";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.dgvPorcentajeAparicion);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(782, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Porcentaje números";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPorcentajeAparicion
            // 
            this.dgvPorcentajeAparicion.AllowUserToAddRows = false;
            this.dgvPorcentajeAparicion.AllowUserToDeleteRows = false;
            this.dgvPorcentajeAparicion.AllowUserToResizeColumns = false;
            this.dgvPorcentajeAparicion.AllowUserToResizeRows = false;
            this.dgvPorcentajeAparicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPorcentajeAparicion.BackgroundColor = System.Drawing.Color.White;
            this.dgvPorcentajeAparicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorcentajeAparicion.Location = new System.Drawing.Point(260, 36);
            this.dgvPorcentajeAparicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPorcentajeAparicion.Name = "dgvPorcentajeAparicion";
            this.dgvPorcentajeAparicion.ReadOnly = true;
            this.dgvPorcentajeAparicion.RowHeadersWidth = 51;
            this.dgvPorcentajeAparicion.RowTemplate.Height = 24;
            this.dgvPorcentajeAparicion.Size = new System.Drawing.Size(268, 575);
            this.dgvPorcentajeAparicion.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Porcentaje de aparición";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 106);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 115);
            this.panel2.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.logoChances;
            this.pictureBox2.Location = new System.Drawing.Point(550, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.logoLoteria;
            this.pictureBox1.Location = new System.Drawing.Point(20, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // FormEstadisticasReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 655);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEstadisticasReportes";
            this.Text = "FormEstadisticasReportes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorteos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosMasJugados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopNumeroDineroRepartido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5GanadoresPrimer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorcentajeAparicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvSorteos;
        private System.Windows.Forms.DataGridView dgvNumerosMasJugados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTopNumeroDineroRepartido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTop5GanadoresPrimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPorcentajeAparicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFiltroTodos;
        private System.Windows.Forms.RadioButton rbFiltroChances;
        private System.Windows.Forms.RadioButton rbFiltroLoteria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}