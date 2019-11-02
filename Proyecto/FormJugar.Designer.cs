namespace Proyecto
{
    partial class FormJugar
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbJugandoSorteo = new System.Windows.Forms.Label();
            this.btOmitirAnimacion = new System.Windows.Forms.Button();
            this.tbPremio = new System.Windows.Forms.TextBox();
            this.tbSerie = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.dgvResultadosSorteo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSorteos = new System.Windows.Forms.DataGridView();
            this.rbFiltroTodos = new System.Windows.Forms.RadioButton();
            this.rbFiltroChances = new System.Windows.Forms.RadioButton();
            this.rbFiltroLoteria = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosSorteo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorteos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(148, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 633);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.lbJugandoSorteo);
            this.panel2.Controls.Add(this.btOmitirAnimacion);
            this.panel2.Controls.Add(this.tbPremio);
            this.panel2.Controls.Add(this.tbSerie);
            this.panel2.Controls.Add(this.tbNumero);
            this.panel2.Controls.Add(this.dgvResultadosSorteo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(5, 289);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 342);
            this.panel2.TabIndex = 3;
            // 
            // lbJugandoSorteo
            // 
            this.lbJugandoSorteo.AutoSize = true;
            this.lbJugandoSorteo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJugandoSorteo.Location = new System.Drawing.Point(8, 0);
            this.lbJugandoSorteo.Name = "lbJugandoSorteo";
            this.lbJugandoSorteo.Size = new System.Drawing.Size(14, 19);
            this.lbJugandoSorteo.TabIndex = 47;
            this.lbJugandoSorteo.Text = " ";
            // 
            // btOmitirAnimacion
            // 
            this.btOmitirAnimacion.Enabled = false;
            this.btOmitirAnimacion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOmitirAnimacion.Location = new System.Drawing.Point(364, 119);
            this.btOmitirAnimacion.Margin = new System.Windows.Forms.Padding(4);
            this.btOmitirAnimacion.Name = "btOmitirAnimacion";
            this.btOmitirAnimacion.Size = new System.Drawing.Size(127, 25);
            this.btOmitirAnimacion.TabIndex = 46;
            this.btOmitirAnimacion.Text = "Omitir animación";
            this.btOmitirAnimacion.UseVisualStyleBackColor = true;
            this.btOmitirAnimacion.Click += new System.EventHandler(this.btOmitirAnimacion_Click);
            // 
            // tbPremio
            // 
            this.tbPremio.Location = new System.Drawing.Point(265, 120);
            this.tbPremio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPremio.Name = "tbPremio";
            this.tbPremio.ReadOnly = true;
            this.tbPremio.Size = new System.Drawing.Size(64, 22);
            this.tbPremio.TabIndex = 45;
            // 
            // tbSerie
            // 
            this.tbSerie.Location = new System.Drawing.Point(38, 120);
            this.tbSerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.ReadOnly = true;
            this.tbSerie.Size = new System.Drawing.Size(64, 22);
            this.tbSerie.TabIndex = 44;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(154, 120);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ReadOnly = true;
            this.tbNumero.Size = new System.Drawing.Size(64, 22);
            this.tbNumero.TabIndex = 43;
            // 
            // dgvResultadosSorteo
            // 
            this.dgvResultadosSorteo.AllowUserToAddRows = false;
            this.dgvResultadosSorteo.AllowUserToDeleteRows = false;
            this.dgvResultadosSorteo.AllowUserToResizeColumns = false;
            this.dgvResultadosSorteo.AllowUserToResizeRows = false;
            this.dgvResultadosSorteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvResultadosSorteo.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultadosSorteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosSorteo.Location = new System.Drawing.Point(12, 177);
            this.dgvResultadosSorteo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResultadosSorteo.Name = "dgvResultadosSorteo";
            this.dgvResultadosSorteo.ReadOnly = true;
            this.dgvResultadosSorteo.RowHeadersWidth = 51;
            this.dgvResultadosSorteo.RowTemplate.Height = 24;
            this.dgvResultadosSorteo.Size = new System.Drawing.Size(479, 154);
            this.dgvResultadosSorteo.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Resultados del sorteo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Premio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Número";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::Proyecto.Properties.Resources.bomboGif;
            this.pictureBox3.Location = new System.Drawing.Point(265, 24);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.bomboGif;
            this.pictureBox2.Location = new System.Drawing.Point(38, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.bomboGif;
            this.pictureBox1.Location = new System.Drawing.Point(154, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbBusqueda);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dgvSorteos);
            this.panel1.Controls.Add(this.rbFiltroTodos);
            this.panel1.Controls.Add(this.rbFiltroChances);
            this.panel1.Controls.Add(this.rbFiltroLoteria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 282);
            this.panel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(219, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = "Buscar número:";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(351, 58);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(140, 22);
            this.tbBusqueda.TabIndex = 43;
            this.tbBusqueda.TextChanged += new System.EventHandler(this.tbBusqueda_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 19);
            this.label10.TabIndex = 42;
            this.label10.Text = "Sorteos disponibles";
            // 
            // dgvSorteos
            // 
            this.dgvSorteos.AllowUserToAddRows = false;
            this.dgvSorteos.AllowUserToDeleteRows = false;
            this.dgvSorteos.AllowUserToResizeColumns = false;
            this.dgvSorteos.AllowUserToResizeRows = false;
            this.dgvSorteos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvSorteos.BackgroundColor = System.Drawing.Color.White;
            this.dgvSorteos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorteos.Location = new System.Drawing.Point(12, 85);
            this.dgvSorteos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSorteos.Name = "dgvSorteos";
            this.dgvSorteos.ReadOnly = true;
            this.dgvSorteos.RowHeadersWidth = 51;
            this.dgvSorteos.RowTemplate.Height = 24;
            this.dgvSorteos.Size = new System.Drawing.Size(479, 179);
            this.dgvSorteos.TabIndex = 41;
            this.dgvSorteos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSorteos_CellClick);
            // 
            // rbFiltroTodos
            // 
            this.rbFiltroTodos.AutoSize = true;
            this.rbFiltroTodos.Checked = true;
            this.rbFiltroTodos.Location = new System.Drawing.Point(12, 34);
            this.rbFiltroTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFiltroTodos.Name = "rbFiltroTodos";
            this.rbFiltroTodos.Size = new System.Drawing.Size(69, 21);
            this.rbFiltroTodos.TabIndex = 39;
            this.rbFiltroTodos.TabStop = true;
            this.rbFiltroTodos.Text = "Todos";
            this.rbFiltroTodos.UseVisualStyleBackColor = true;
            this.rbFiltroTodos.CheckedChanged += new System.EventHandler(this.rbFiltroTodos_CheckedChanged);
            // 
            // rbFiltroChances
            // 
            this.rbFiltroChances.AutoSize = true;
            this.rbFiltroChances.Location = new System.Drawing.Point(205, 34);
            this.rbFiltroChances.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFiltroChances.Name = "rbFiltroChances";
            this.rbFiltroChances.Size = new System.Drawing.Size(84, 21);
            this.rbFiltroChances.TabIndex = 38;
            this.rbFiltroChances.Text = "Chances";
            this.rbFiltroChances.UseVisualStyleBackColor = true;
            this.rbFiltroChances.CheckedChanged += new System.EventHandler(this.rbFiltroChances_CheckedChanged);
            // 
            // rbFiltroLoteria
            // 
            this.rbFiltroLoteria.AutoSize = true;
            this.rbFiltroLoteria.Location = new System.Drawing.Point(107, 34);
            this.rbFiltroLoteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFiltroLoteria.Name = "rbFiltroLoteria";
            this.rbFiltroLoteria.Size = new System.Drawing.Size(73, 21);
            this.rbFiltroLoteria.TabIndex = 37;
            this.rbFiltroLoteria.Text = "Lotería";
            this.rbFiltroLoteria.UseVisualStyleBackColor = true;
            this.rbFiltroLoteria.CheckedChanged += new System.EventHandler(this.rbFiltroLoteria_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tipo de sorteo";
            // 
            // FormJugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 655);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormJugar";
            this.Text = "FormJugar";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosSorteo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorteos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btOmitirAnimacion;
        private System.Windows.Forms.TextBox tbPremio;
        private System.Windows.Forms.TextBox tbSerie;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.DataGridView dgvResultadosSorteo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvSorteos;
        private System.Windows.Forms.RadioButton rbFiltroTodos;
        private System.Windows.Forms.RadioButton rbFiltroChances;
        private System.Windows.Forms.RadioButton rbFiltroLoteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Label lbJugandoSorteo;
    }
}