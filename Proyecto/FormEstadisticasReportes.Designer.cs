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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTop5GanadoresPrimer = new System.Windows.Forms.DataGridView();
            this.dgvTopNumeroDineroRepartido = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNumerosMasJugados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSorteos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5GanadoresPrimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopNumeroDineroRepartido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosMasJugados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorteos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Números más ganadores del primer premio";
            // 
            // dgvTop5GanadoresPrimer
            // 
            this.dgvTop5GanadoresPrimer.AllowUserToAddRows = false;
            this.dgvTop5GanadoresPrimer.AllowUserToDeleteRows = false;
            this.dgvTop5GanadoresPrimer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop5GanadoresPrimer.Location = new System.Drawing.Point(300, 31);
            this.dgvTop5GanadoresPrimer.Name = "dgvTop5GanadoresPrimer";
            this.dgvTop5GanadoresPrimer.ReadOnly = true;
            this.dgvTop5GanadoresPrimer.RowTemplate.Height = 24;
            this.dgvTop5GanadoresPrimer.Size = new System.Drawing.Size(245, 150);
            this.dgvTop5GanadoresPrimer.TabIndex = 34;
            // 
            // dgvTopNumeroDineroRepartido
            // 
            this.dgvTopNumeroDineroRepartido.AllowUserToAddRows = false;
            this.dgvTopNumeroDineroRepartido.AllowUserToDeleteRows = false;
            this.dgvTopNumeroDineroRepartido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopNumeroDineroRepartido.Location = new System.Drawing.Point(300, 217);
            this.dgvTopNumeroDineroRepartido.Name = "dgvTopNumeroDineroRepartido";
            this.dgvTopNumeroDineroRepartido.ReadOnly = true;
            this.dgvTopNumeroDineroRepartido.RowTemplate.Height = 24;
            this.dgvTopNumeroDineroRepartido.Size = new System.Drawing.Size(245, 150);
            this.dgvTopNumeroDineroRepartido.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Números con mayor dinero repartido";
            // 
            // dgvNumerosMasJugados
            // 
            this.dgvNumerosMasJugados.AllowUserToAddRows = false;
            this.dgvNumerosMasJugados.AllowUserToDeleteRows = false;
            this.dgvNumerosMasJugados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumerosMasJugados.Location = new System.Drawing.Point(16, 31);
            this.dgvNumerosMasJugados.Name = "dgvNumerosMasJugados";
            this.dgvNumerosMasJugados.ReadOnly = true;
            this.dgvNumerosMasJugados.RowTemplate.Height = 24;
            this.dgvNumerosMasJugados.Size = new System.Drawing.Size(245, 336);
            this.dgvNumerosMasJugados.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Números más jugados";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 19);
            this.label10.TabIndex = 40;
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
            this.dgvSorteos.Location = new System.Drawing.Point(16, 421);
            this.dgvSorteos.Name = "dgvSorteos";
            this.dgvSorteos.ReadOnly = true;
            this.dgvSorteos.RowTemplate.Height = 24;
            this.dgvSorteos.Size = new System.Drawing.Size(539, 217);
            this.dgvSorteos.TabIndex = 39;
            // 
            // FormEstadisticasReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 650);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvSorteos);
            this.Controls.Add(this.dgvNumerosMasJugados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTopNumeroDineroRepartido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTop5GanadoresPrimer);
            this.Controls.Add(this.label1);
            this.Name = "FormEstadisticasReportes";
            this.Text = "FormEstadisticasReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5GanadoresPrimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopNumeroDineroRepartido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosMasJugados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorteos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTop5GanadoresPrimer;
        private System.Windows.Forms.DataGridView dgvTopNumeroDineroRepartido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNumerosMasJugados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvSorteos;
    }
}