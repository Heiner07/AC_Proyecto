namespace Proyecto
{
    partial class FormResultados
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
            this.nudSerieFraccion = new System.Windows.Forms.NumericUpDown();
            this.nudNumeroFraccion = new System.Windows.Forms.NumericUpDown();
            this.rbChances = new System.Windows.Forms.RadioButton();
            this.rbLoteria = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumeroSorteo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCantidadFracciones = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.lbMontoGanado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPremiosGanados = new System.Windows.Forms.Label();
            this.lbFelicidades = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerieFraccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFraccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroSorteo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadFracciones)).BeginInit();
            this.panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSerieFraccion
            // 
            this.nudSerieFraccion.Location = new System.Drawing.Point(26, 217);
            this.nudSerieFraccion.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudSerieFraccion.Name = "nudSerieFraccion";
            this.nudSerieFraccion.Size = new System.Drawing.Size(200, 22);
            this.nudSerieFraccion.TabIndex = 37;
            // 
            // nudNumeroFraccion
            // 
            this.nudNumeroFraccion.Location = new System.Drawing.Point(26, 152);
            this.nudNumeroFraccion.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudNumeroFraccion.Name = "nudNumeroFraccion";
            this.nudNumeroFraccion.Size = new System.Drawing.Size(200, 22);
            this.nudNumeroFraccion.TabIndex = 36;
            // 
            // rbChances
            // 
            this.rbChances.AutoSize = true;
            this.rbChances.Location = new System.Drawing.Point(114, 34);
            this.rbChances.Name = "rbChances";
            this.rbChances.Size = new System.Drawing.Size(84, 21);
            this.rbChances.TabIndex = 35;
            this.rbChances.Text = "Chances";
            this.rbChances.UseVisualStyleBackColor = true;
            // 
            // rbLoteria
            // 
            this.rbLoteria.AutoSize = true;
            this.rbLoteria.Checked = true;
            this.rbLoteria.Location = new System.Drawing.Point(26, 34);
            this.rbLoteria.Name = "rbLoteria";
            this.rbLoteria.Size = new System.Drawing.Size(73, 21);
            this.rbLoteria.TabIndex = 34;
            this.rbLoteria.TabStop = true;
            this.rbLoteria.Text = "Lotería";
            this.rbLoteria.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Serie de la fracción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Número de la fracción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tipo de sorteo";
            // 
            // nudNumeroSorteo
            // 
            this.nudNumeroSorteo.Location = new System.Drawing.Point(26, 94);
            this.nudNumeroSorteo.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudNumeroSorteo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroSorteo.Name = "nudNumeroSorteo";
            this.nudNumeroSorteo.Size = new System.Drawing.Size(200, 22);
            this.nudNumeroSorteo.TabIndex = 39;
            this.nudNumeroSorteo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Número de sorteo";
            // 
            // nudCantidadFracciones
            // 
            this.nudCantidadFracciones.Location = new System.Drawing.Point(26, 279);
            this.nudCantidadFracciones.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantidadFracciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadFracciones.Name = "nudCantidadFracciones";
            this.nudCantidadFracciones.Size = new System.Drawing.Size(200, 22);
            this.nudCantidadFracciones.TabIndex = 41;
            this.nudCantidadFracciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Cantidad de fracciones";
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(26, 316);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(108, 30);
            this.btConsultar.TabIndex = 42;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.BtConsultar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "Monto ganado";
            // 
            // panelResultados
            // 
            this.panelResultados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResultados.Controls.Add(this.lbFelicidades);
            this.panelResultados.Controls.Add(this.lbPremiosGanados);
            this.panelResultados.Controls.Add(this.label7);
            this.panelResultados.Controls.Add(this.lbMontoGanado);
            this.panelResultados.Controls.Add(this.label1);
            this.panelResultados.Controls.Add(this.label3);
            this.panelResultados.Controls.Add(this.label6);
            this.panelResultados.Controls.Add(this.label4);
            this.panelResultados.Controls.Add(this.btConsultar);
            this.panelResultados.Controls.Add(this.rbLoteria);
            this.panelResultados.Controls.Add(this.nudCantidadFracciones);
            this.panelResultados.Controls.Add(this.rbChances);
            this.panelResultados.Controls.Add(this.label5);
            this.panelResultados.Controls.Add(this.nudNumeroFraccion);
            this.panelResultados.Controls.Add(this.nudNumeroSorteo);
            this.panelResultados.Controls.Add(this.nudSerieFraccion);
            this.panelResultados.Controls.Add(this.label2);
            this.panelResultados.Location = new System.Drawing.Point(233, 100);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(332, 474);
            this.panelResultados.TabIndex = 45;
            // 
            // lbMontoGanado
            // 
            this.lbMontoGanado.AutoSize = true;
            this.lbMontoGanado.Location = new System.Drawing.Point(26, 399);
            this.lbMontoGanado.Name = "lbMontoGanado";
            this.lbMontoGanado.Size = new System.Drawing.Size(16, 17);
            this.lbMontoGanado.TabIndex = 44;
            this.lbMontoGanado.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 106);
            this.panel1.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 115);
            this.panel2.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.logoLoteria;
            this.pictureBox1.Location = new System.Drawing.Point(5, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.logoChances;
            this.pictureBox2.Location = new System.Drawing.Point(577, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Premios ganados";
            // 
            // lbPremiosGanados
            // 
            this.lbPremiosGanados.AutoSize = true;
            this.lbPremiosGanados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbPremiosGanados.Location = new System.Drawing.Point(25, 446);
            this.lbPremiosGanados.Name = "lbPremiosGanados";
            this.lbPremiosGanados.Size = new System.Drawing.Size(16, 17);
            this.lbPremiosGanados.TabIndex = 46;
            this.lbPremiosGanados.Text = "0";
            // 
            // lbFelicidades
            // 
            this.lbFelicidades.AutoSize = true;
            this.lbFelicidades.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFelicidades.Location = new System.Drawing.Point(22, 355);
            this.lbFelicidades.Name = "lbFelicidades";
            this.lbFelicidades.Size = new System.Drawing.Size(102, 19);
            this.lbFelicidades.TabIndex = 47;
            this.lbFelicidades.Text = "¡Felicidades!";
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 655);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormResultados";
            this.Text = "FormResultados";
            ((System.ComponentModel.ISupportInitialize)(this.nudSerieFraccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFraccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroSorteo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadFracciones)).EndInit();
            this.panelResultados.ResumeLayout(false);
            this.panelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSerieFraccion;
        private System.Windows.Forms.NumericUpDown nudNumeroFraccion;
        private System.Windows.Forms.RadioButton rbChances;
        private System.Windows.Forms.RadioButton rbLoteria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumeroSorteo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCantidadFracciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.Label lbMontoGanado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbPremiosGanados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbFelicidades;
    }
}