namespace Proyecto
{
    partial class FormMantenimientoSorteos
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbEditarSorteo = new System.Windows.Forms.Label();
            this.btCrearNuevoSorteo = new System.Windows.Forms.Button();
            this.dataGridViewSorteos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panelCrearSorteo = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btBorrarPlanPremios = new System.Windows.Forms.Button();
            this.btCrear = new System.Windows.Forms.Button();
            this.btAgregarPremioAdicional = new System.Windows.Forms.Button();
            this.nudPremio3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudPremio2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPremio1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLeyenda = new System.Windows.Forms.TextBox();
            this.nudCostoFraccion = new System.Windows.Forms.NumericUpDown();
            this.nudFracciones = new System.Windows.Forms.NumericUpDown();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.rbChances = new System.Windows.Forms.RadioButton();
            this.rbLoteria = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSorteos = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridViewPremiosAdicionales = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorteos)).BeginInit();
            this.panelCrearSorteo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremio3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoFraccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFracciones)).BeginInit();
            this.panelSorteos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPremiosAdicionales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.Controls.Add(this.lbEditarSorteo);
            this.panel4.Controls.Add(this.btCrearNuevoSorteo);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(798, 54);
            this.panel4.TabIndex = 1;
            // 
            // lbEditarSorteo
            // 
            this.lbEditarSorteo.AutoSize = true;
            this.lbEditarSorteo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarSorteo.Location = new System.Drawing.Point(257, 18);
            this.lbEditarSorteo.Name = "lbEditarSorteo";
            this.lbEditarSorteo.Size = new System.Drawing.Size(123, 19);
            this.lbEditarSorteo.TabIndex = 33;
            this.lbEditarSorteo.Text = "Editando sorteo";
            // 
            // btCrearNuevoSorteo
            // 
            this.btCrearNuevoSorteo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrearNuevoSorteo.Location = new System.Drawing.Point(12, 12);
            this.btCrearNuevoSorteo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCrearNuevoSorteo.Name = "btCrearNuevoSorteo";
            this.btCrearNuevoSorteo.Size = new System.Drawing.Size(187, 33);
            this.btCrearNuevoSorteo.TabIndex = 1;
            this.btCrearNuevoSorteo.Text = "Crear nuevo sorteo";
            this.btCrearNuevoSorteo.UseVisualStyleBackColor = true;
            this.btCrearNuevoSorteo.Click += new System.EventHandler(this.btCrearNuevoSorteo_Click);
            // 
            // dataGridViewSorteos
            // 
            this.dataGridViewSorteos.AllowUserToAddRows = false;
            this.dataGridViewSorteos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewSorteos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSorteos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSorteos.Location = new System.Drawing.Point(0, 31);
            this.dataGridViewSorteos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSorteos.MultiSelect = false;
            this.dataGridViewSorteos.Name = "dataGridViewSorteos";
            this.dataGridViewSorteos.ReadOnly = true;
            this.dataGridViewSorteos.RowHeadersWidth = 51;
            this.dataGridViewSorteos.RowTemplate.Height = 24;
            this.dataGridViewSorteos.Size = new System.Drawing.Size(782, 148);
            this.dataGridViewSorteos.TabIndex = 2;
            this.dataGridViewSorteos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSorteos_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Sorteos existentes";
            // 
            // panelCrearSorteo
            // 
            this.panelCrearSorteo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCrearSorteo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCrearSorteo.Controls.Add(this.nudMonto);
            this.panelCrearSorteo.Controls.Add(this.label13);
            this.panelCrearSorteo.Controls.Add(this.label12);
            this.panelCrearSorteo.Controls.Add(this.dataGridViewPremiosAdicionales);
            this.panelCrearSorteo.Controls.Add(this.btCancelar);
            this.panelCrearSorteo.Controls.Add(this.btGuardar);
            this.panelCrearSorteo.Controls.Add(this.btBorrarPlanPremios);
            this.panelCrearSorteo.Controls.Add(this.btCrear);
            this.panelCrearSorteo.Controls.Add(this.btAgregarPremioAdicional);
            this.panelCrearSorteo.Controls.Add(this.nudPremio3);
            this.panelCrearSorteo.Controls.Add(this.label9);
            this.panelCrearSorteo.Controls.Add(this.nudPremio2);
            this.panelCrearSorteo.Controls.Add(this.label8);
            this.panelCrearSorteo.Controls.Add(this.nudPremio1);
            this.panelCrearSorteo.Controls.Add(this.label7);
            this.panelCrearSorteo.Controls.Add(this.label6);
            this.panelCrearSorteo.Controls.Add(this.tbLeyenda);
            this.panelCrearSorteo.Controls.Add(this.nudCostoFraccion);
            this.panelCrearSorteo.Controls.Add(this.nudFracciones);
            this.panelCrearSorteo.Controls.Add(this.dtFecha);
            this.panelCrearSorteo.Controls.Add(this.rbChances);
            this.panelCrearSorteo.Controls.Add(this.rbLoteria);
            this.panelCrearSorteo.Controls.Add(this.label5);
            this.panelCrearSorteo.Controls.Add(this.label4);
            this.panelCrearSorteo.Controls.Add(this.label3);
            this.panelCrearSorteo.Controls.Add(this.label2);
            this.panelCrearSorteo.Controls.Add(this.label1);
            this.panelCrearSorteo.Location = new System.Drawing.Point(7, 54);
            this.panelCrearSorteo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCrearSorteo.Name = "panelCrearSorteo";
            this.panelCrearSorteo.Size = new System.Drawing.Size(782, 404);
            this.panelCrearSorteo.TabIndex = 0;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(124, 353);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(95, 28);
            this.btCancelar.TabIndex = 44;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(19, 353);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(91, 28);
            this.btGuardar.TabIndex = 43;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btBorrarPlanPremios
            // 
            this.btBorrarPlanPremios.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrarPlanPremios.Location = new System.Drawing.Point(551, 10);
            this.btBorrarPlanPremios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBorrarPlanPremios.Name = "btBorrarPlanPremios";
            this.btBorrarPlanPremios.Size = new System.Drawing.Size(75, 28);
            this.btBorrarPlanPremios.TabIndex = 42;
            this.btBorrarPlanPremios.Text = "Borrar";
            this.btBorrarPlanPremios.UseVisualStyleBackColor = true;
            this.btBorrarPlanPremios.Click += new System.EventHandler(this.btBorrarPlanPremios_Click);
            // 
            // btCrear
            // 
            this.btCrear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrear.Location = new System.Drawing.Point(19, 321);
            this.btCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(75, 28);
            this.btCrear.TabIndex = 41;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // btAgregarPremioAdicional
            // 
            this.btAgregarPremioAdicional.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarPremioAdicional.Location = new System.Drawing.Point(564, 353);
            this.btAgregarPremioAdicional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAgregarPremioAdicional.Name = "btAgregarPremioAdicional";
            this.btAgregarPremioAdicional.Size = new System.Drawing.Size(80, 30);
            this.btAgregarPremioAdicional.TabIndex = 40;
            this.btAgregarPremioAdicional.Text = "Agregar";
            this.btAgregarPremioAdicional.UseVisualStyleBackColor = true;
            this.btAgregarPremioAdicional.Click += new System.EventHandler(this.btAgregarPremioAdicional_Click);
            // 
            // nudPremio3
            // 
            this.nudPremio3.Location = new System.Drawing.Point(389, 183);
            this.nudPremio3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPremio3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPremio3.Name = "nudPremio3";
            this.nudPremio3.Size = new System.Drawing.Size(200, 22);
            this.nudPremio3.TabIndex = 38;
            this.nudPremio3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 37;
            this.label9.Text = "3° Premio";
            // 
            // nudPremio2
            // 
            this.nudPremio2.Location = new System.Drawing.Point(389, 129);
            this.nudPremio2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPremio2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPremio2.Name = "nudPremio2";
            this.nudPremio2.Size = new System.Drawing.Size(200, 22);
            this.nudPremio2.TabIndex = 36;
            this.nudPremio2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "2° Premio";
            // 
            // nudPremio1
            // 
            this.nudPremio1.Location = new System.Drawing.Point(389, 69);
            this.nudPremio1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPremio1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPremio1.Name = "nudPremio1";
            this.nudPremio1.Size = new System.Drawing.Size(200, 22);
            this.nudPremio1.TabIndex = 34;
            this.nudPremio1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(385, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "1° Premio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Plan de Premios";
            // 
            // tbLeyenda
            // 
            this.tbLeyenda.Location = new System.Drawing.Point(19, 281);
            this.tbLeyenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeyenda.Name = "tbLeyenda";
            this.tbLeyenda.Size = new System.Drawing.Size(200, 22);
            this.tbLeyenda.TabIndex = 31;
            // 
            // nudCostoFraccion
            // 
            this.nudCostoFraccion.Location = new System.Drawing.Point(19, 220);
            this.nudCostoFraccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCostoFraccion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCostoFraccion.Name = "nudCostoFraccion";
            this.nudCostoFraccion.Size = new System.Drawing.Size(200, 22);
            this.nudCostoFraccion.TabIndex = 30;
            this.nudCostoFraccion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudFracciones
            // 
            this.nudFracciones.Location = new System.Drawing.Point(19, 155);
            this.nudFracciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudFracciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFracciones.Name = "nudFracciones";
            this.nudFracciones.Size = new System.Drawing.Size(200, 22);
            this.nudFracciones.TabIndex = 29;
            this.nudFracciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(19, 94);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha.MinDate = new System.DateTime(2019, 10, 26, 16, 17, 3, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 22);
            this.dtFecha.TabIndex = 28;
            this.dtFecha.Value = new System.DateTime(2019, 10, 26, 16, 17, 12, 0);
            // 
            // rbChances
            // 
            this.rbChances.AutoSize = true;
            this.rbChances.Location = new System.Drawing.Point(107, 37);
            this.rbChances.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbChances.Name = "rbChances";
            this.rbChances.Size = new System.Drawing.Size(84, 21);
            this.rbChances.TabIndex = 27;
            this.rbChances.Text = "Chances";
            this.rbChances.UseVisualStyleBackColor = true;
            // 
            // rbLoteria
            // 
            this.rbLoteria.AutoSize = true;
            this.rbLoteria.Checked = true;
            this.rbLoteria.Location = new System.Drawing.Point(19, 37);
            this.rbLoteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLoteria.Name = "rbLoteria";
            this.rbLoteria.Size = new System.Drawing.Size(73, 21);
            this.rbLoteria.TabIndex = 26;
            this.rbLoteria.TabStop = true;
            this.rbLoteria.Text = "Lotería";
            this.rbLoteria.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Leyenda del billete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Costo de la fracción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Número de fracciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha de sorteo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tipo de sorteo";
            // 
            // panelSorteos
            // 
            this.panelSorteos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelSorteos.Controls.Add(this.label11);
            this.panelSorteos.Controls.Add(this.tbBusqueda);
            this.panelSorteos.Controls.Add(this.label10);
            this.panelSorteos.Controls.Add(this.dataGridViewSorteos);
            this.panelSorteos.Location = new System.Drawing.Point(7, 464);
            this.panelSorteos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSorteos.MinimumSize = new System.Drawing.Size(632, 177);
            this.panelSorteos.Name = "panelSorteos";
            this.panelSorteos.Size = new System.Drawing.Size(782, 182);
            this.panelSorteos.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(507, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Buscar número:";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(639, 6);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(140, 22);
            this.tbBusqueda.TabIndex = 4;
            // 
            // dataGridViewPremiosAdicionales
            // 
            this.dataGridViewPremiosAdicionales.AllowUserToAddRows = false;
            this.dataGridViewPremiosAdicionales.AllowUserToDeleteRows = false;
            this.dataGridViewPremiosAdicionales.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPremiosAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPremiosAdicionales.Location = new System.Drawing.Point(389, 242);
            this.dataGridViewPremiosAdicionales.Name = "dataGridViewPremiosAdicionales";
            this.dataGridViewPremiosAdicionales.RowHeadersVisible = false;
            this.dataGridViewPremiosAdicionales.RowTemplate.Height = 24;
            this.dataGridViewPremiosAdicionales.Size = new System.Drawing.Size(255, 107);
            this.dataGridViewPremiosAdicionales.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(385, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 19);
            this.label12.TabIndex = 46;
            this.label12.Text = "Premios adicionales";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(385, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 19);
            this.label13.TabIndex = 47;
            this.label13.Text = "Monto:";
            // 
            // nudMonto
            // 
            this.nudMonto.Location = new System.Drawing.Point(449, 359);
            this.nudMonto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(92, 22);
            this.nudMonto.TabIndex = 48;
            this.nudMonto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormMantenimientoSorteos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 655);
            this.Controls.Add(this.panelSorteos);
            this.Controls.Add(this.panelCrearSorteo);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMantenimientoSorteos";
            this.Text = "FormMantenimientoSorteos";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorteos)).EndInit();
            this.panelCrearSorteo.ResumeLayout(false);
            this.panelCrearSorteo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremio3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoFraccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFracciones)).EndInit();
            this.panelSorteos.ResumeLayout(false);
            this.panelSorteos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPremiosAdicionales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btCrearNuevoSorteo;
        private System.Windows.Forms.DataGridView dataGridViewSorteos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelCrearSorteo;
        private System.Windows.Forms.Panel panelSorteos;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btAgregarPremioAdicional;
        private System.Windows.Forms.NumericUpDown nudPremio3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudPremio2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPremio1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLeyenda;
        private System.Windows.Forms.NumericUpDown nudCostoFraccion;
        private System.Windows.Forms.NumericUpDown nudFracciones;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.RadioButton rbChances;
        private System.Windows.Forms.RadioButton rbLoteria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBorrarPlanPremios;
        private System.Windows.Forms.Label lbEditarSorteo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.DataGridView dataGridViewPremiosAdicionales;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}