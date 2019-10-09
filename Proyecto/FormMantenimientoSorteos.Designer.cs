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
            this.btCrearNuevoSorteo = new System.Windows.Forms.Button();
            this.dataGridViewSorteos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panelCrearSorteo = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btAgregarPremioAdicional = new System.Windows.Forms.Button();
            this.panelPremiosAdicionales = new System.Windows.Forms.Panel();
            this.nudPremio3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudPremio2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPremio1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSorteos = new System.Windows.Forms.Panel();
            this.btBorrarPlanPremios = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbEditarSorteo = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorteos)).BeginInit();
            this.panelCrearSorteo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremio3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelSorteos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbEditarSorteo);
            this.panel4.Controls.Add(this.btCrearNuevoSorteo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 54);
            this.panel4.TabIndex = 1;
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
            this.dataGridViewSorteos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSorteos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSorteos.Location = new System.Drawing.Point(9, 31);
            this.dataGridViewSorteos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSorteos.MultiSelect = false;
            this.dataGridViewSorteos.Name = "dataGridViewSorteos";
            this.dataGridViewSorteos.ReadOnly = true;
            this.dataGridViewSorteos.RowTemplate.Height = 24;
            this.dataGridViewSorteos.Size = new System.Drawing.Size(621, 143);
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
            this.panelCrearSorteo.Controls.Add(this.btCancelar);
            this.panelCrearSorteo.Controls.Add(this.btGuardar);
            this.panelCrearSorteo.Controls.Add(this.btBorrarPlanPremios);
            this.panelCrearSorteo.Controls.Add(this.button2);
            this.panelCrearSorteo.Controls.Add(this.btAgregarPremioAdicional);
            this.panelCrearSorteo.Controls.Add(this.panelPremiosAdicionales);
            this.panelCrearSorteo.Controls.Add(this.nudPremio3);
            this.panelCrearSorteo.Controls.Add(this.label9);
            this.panelCrearSorteo.Controls.Add(this.nudPremio2);
            this.panelCrearSorteo.Controls.Add(this.label8);
            this.panelCrearSorteo.Controls.Add(this.nudPremio1);
            this.panelCrearSorteo.Controls.Add(this.label7);
            this.panelCrearSorteo.Controls.Add(this.label6);
            this.panelCrearSorteo.Controls.Add(this.textBox1);
            this.panelCrearSorteo.Controls.Add(this.numericUpDown2);
            this.panelCrearSorteo.Controls.Add(this.numericUpDown1);
            this.panelCrearSorteo.Controls.Add(this.dateTimePicker1);
            this.panelCrearSorteo.Controls.Add(this.radioButton2);
            this.panelCrearSorteo.Controls.Add(this.radioButton1);
            this.panelCrearSorteo.Controls.Add(this.label5);
            this.panelCrearSorteo.Controls.Add(this.label4);
            this.panelCrearSorteo.Controls.Add(this.label3);
            this.panelCrearSorteo.Controls.Add(this.label2);
            this.panelCrearSorteo.Controls.Add(this.label1);
            this.panelCrearSorteo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrearSorteo.Location = new System.Drawing.Point(0, 54);
            this.panelCrearSorteo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCrearSorteo.Name = "panelCrearSorteo";
            this.panelCrearSorteo.Size = new System.Drawing.Size(642, 404);
            this.panelCrearSorteo.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 41;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btAgregarPremioAdicional
            // 
            this.btAgregarPremioAdicional.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarPremioAdicional.Location = new System.Drawing.Point(360, 362);
            this.btAgregarPremioAdicional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAgregarPremioAdicional.Name = "btAgregarPremioAdicional";
            this.btAgregarPremioAdicional.Size = new System.Drawing.Size(236, 30);
            this.btAgregarPremioAdicional.TabIndex = 40;
            this.btAgregarPremioAdicional.Text = "Agregar premio adicional";
            this.btAgregarPremioAdicional.UseVisualStyleBackColor = true;
            this.btAgregarPremioAdicional.Click += new System.EventHandler(this.btAgregarPremioAdicional_Click);
            // 
            // panelPremiosAdicionales
            // 
            this.panelPremiosAdicionales.AutoScroll = true;
            this.panelPremiosAdicionales.Location = new System.Drawing.Point(360, 210);
            this.panelPremiosAdicionales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPremiosAdicionales.Name = "panelPremiosAdicionales";
            this.panelPremiosAdicionales.Size = new System.Drawing.Size(282, 145);
            this.panelPremiosAdicionales.TabIndex = 39;
            // 
            // nudPremio3
            // 
            this.nudPremio3.Location = new System.Drawing.Point(389, 183);
            this.nudPremio3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPremio3.Name = "nudPremio3";
            this.nudPremio3.Size = new System.Drawing.Size(200, 22);
            this.nudPremio3.TabIndex = 38;
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
            this.nudPremio2.Name = "nudPremio2";
            this.nudPremio2.Size = new System.Drawing.Size(200, 22);
            this.nudPremio2.TabIndex = 36;
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
            this.nudPremio1.Name = "nudPremio1";
            this.nudPremio1.Size = new System.Drawing.Size(200, 22);
            this.nudPremio1.TabIndex = 34;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 281);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 31;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(19, 220);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown2.TabIndex = 30;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(19, 155);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown1.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 94);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 37);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 21);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.Text = "Chances";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 37);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 21);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lotería";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.panelSorteos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSorteos.Controls.Add(this.label10);
            this.panelSorteos.Controls.Add(this.dataGridViewSorteos);
            this.panelSorteos.Location = new System.Drawing.Point(3, 464);
            this.panelSorteos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSorteos.MinimumSize = new System.Drawing.Size(632, 177);
            this.panelSorteos.Name = "panelSorteos";
            this.panelSorteos.Size = new System.Drawing.Size(642, 177);
            this.panelSorteos.TabIndex = 2;
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
            // FormMantenimientoSorteos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 650);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelSorteos.ResumeLayout(false);
            this.panelSorteos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btCrearNuevoSorteo;
        private System.Windows.Forms.DataGridView dataGridViewSorteos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelCrearSorteo;
        private System.Windows.Forms.Panel panelSorteos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btAgregarPremioAdicional;
        private System.Windows.Forms.Panel panelPremiosAdicionales;
        private System.Windows.Forms.NumericUpDown nudPremio3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudPremio2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPremio1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBorrarPlanPremios;
        private System.Windows.Forms.Label lbEditarSorteo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
    }
}