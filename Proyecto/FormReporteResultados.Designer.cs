namespace Proyecto
{
    partial class FormReporteResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteResultados));
            this.dgvResultadosSorteo = new System.Windows.Forms.DataGridView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosSorteo)).BeginInit();
            this.SuspendLayout();
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
            this.dgvResultadosSorteo.Location = new System.Drawing.Point(10, 30);
            this.dgvResultadosSorteo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResultadosSorteo.Name = "dgvResultadosSorteo";
            this.dgvResultadosSorteo.ReadOnly = true;
            this.dgvResultadosSorteo.RowHeadersWidth = 51;
            this.dgvResultadosSorteo.RowTemplate.Height = 24;
            this.dgvResultadosSorteo.Size = new System.Drawing.Size(479, 308);
            this.dgvResultadosSorteo.TabIndex = 44;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(12, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(164, 19);
            this.lbTitulo.TabIndex = 43;
            this.lbTitulo.Text = "Resultados del sorteo";
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(359, 343);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(130, 30);
            this.btAceptar.TabIndex = 45;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // btExportar
            // 
            this.btExportar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportar.Location = new System.Drawing.Point(10, 343);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(130, 30);
            this.btExportar.TabIndex = 46;
            this.btExportar.Text = "Exportar PDF";
            this.btExportar.UseVisualStyleBackColor = true;
            this.btExportar.Click += new System.EventHandler(this.BtExportar_Click);
            // 
            // FormReporteResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 383);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.dgvResultadosSorteo);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReporteResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte resultados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosSorteo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultadosSorteo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btExportar;
    }
}