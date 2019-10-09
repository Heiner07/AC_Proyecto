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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorteos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosMasJugados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopNumeroDineroRepartido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5GanadoresPrimer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorcentajeAparicion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 524);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dgvSorteos);
            this.tabPage1.Controls.Add(this.dgvNumerosMasJugados);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvTopNumeroDineroRepartido);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvTop5GanadoresPrimer);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(470, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 302);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Sorteos existentes";
            // 
            // dgvSorteos
            // 
            this.dgvSorteos.AllowUserToAddRows = false;
            this.dgvSorteos.AllowUserToDeleteRows = false;
            this.dgvSorteos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSorteos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorteos.Location = new System.Drawing.Point(11, 320);
            this.dgvSorteos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSorteos.Name = "dgvSorteos";
            this.dgvSorteos.ReadOnly = true;
            this.dgvSorteos.RowTemplate.Height = 24;
            this.dgvSorteos.Size = new System.Drawing.Size(449, 176);
            this.dgvSorteos.TabIndex = 47;
            // 
            // dgvNumerosMasJugados
            // 
            this.dgvNumerosMasJugados.AllowUserToAddRows = false;
            this.dgvNumerosMasJugados.AllowUserToDeleteRows = false;
            this.dgvNumerosMasJugados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumerosMasJugados.Location = new System.Drawing.Point(11, 20);
            this.dgvNumerosMasJugados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNumerosMasJugados.Name = "dgvNumerosMasJugados";
            this.dgvNumerosMasJugados.ReadOnly = true;
            this.dgvNumerosMasJugados.RowTemplate.Height = 24;
            this.dgvNumerosMasJugados.Size = new System.Drawing.Size(184, 273);
            this.dgvNumerosMasJugados.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Números más jugados";
            // 
            // dgvTopNumeroDineroRepartido
            // 
            this.dgvTopNumeroDineroRepartido.AllowUserToAddRows = false;
            this.dgvTopNumeroDineroRepartido.AllowUserToDeleteRows = false;
            this.dgvTopNumeroDineroRepartido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopNumeroDineroRepartido.Location = new System.Drawing.Point(224, 171);
            this.dgvTopNumeroDineroRepartido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTopNumeroDineroRepartido.Name = "dgvTopNumeroDineroRepartido";
            this.dgvTopNumeroDineroRepartido.ReadOnly = true;
            this.dgvTopNumeroDineroRepartido.RowTemplate.Height = 24;
            this.dgvTopNumeroDineroRepartido.Size = new System.Drawing.Size(236, 122);
            this.dgvTopNumeroDineroRepartido.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Números con mayor dinero repartido";
            // 
            // dgvTop5GanadoresPrimer
            // 
            this.dgvTop5GanadoresPrimer.AllowUserToAddRows = false;
            this.dgvTop5GanadoresPrimer.AllowUserToDeleteRows = false;
            this.dgvTop5GanadoresPrimer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop5GanadoresPrimer.Location = new System.Drawing.Point(224, 20);
            this.dgvTop5GanadoresPrimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTop5GanadoresPrimer.Name = "dgvTop5GanadoresPrimer";
            this.dgvTop5GanadoresPrimer.ReadOnly = true;
            this.dgvTop5GanadoresPrimer.RowTemplate.Height = 24;
            this.dgvTop5GanadoresPrimer.Size = new System.Drawing.Size(236, 122);
            this.dgvTop5GanadoresPrimer.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Números más ganadores del primer premio";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPorcentajeAparicion);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(470, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Porcentaje números";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPorcentajeAparicion
            // 
            this.dgvPorcentajeAparicion.AllowUserToAddRows = false;
            this.dgvPorcentajeAparicion.AllowUserToDeleteRows = false;
            this.dgvPorcentajeAparicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPorcentajeAparicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorcentajeAparicion.Location = new System.Drawing.Point(8, 28);
            this.dgvPorcentajeAparicion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPorcentajeAparicion.Name = "dgvPorcentajeAparicion";
            this.dgvPorcentajeAparicion.ReadOnly = true;
            this.dgvPorcentajeAparicion.RowTemplate.Height = 24;
            this.dgvPorcentajeAparicion.Size = new System.Drawing.Size(194, 467);
            this.dgvPorcentajeAparicion.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Porcentaje de aparición";
            // 
            // FormEstadisticasReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 528);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}