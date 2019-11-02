namespace Proyecto
{
    partial class FormReportePlanPremios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportePlanPremios));
            this.btExportar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.dgvPlanPremiosSorteo = new System.Windows.Forms.DataGridView();
            this.lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPremiosSorteo)).BeginInit();
            this.SuspendLayout();
            // 
            // btExportar
            // 
            this.btExportar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportar.Location = new System.Drawing.Point(12, 343);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(130, 30);
            this.btExportar.TabIndex = 50;
            this.btExportar.Text = "Exportar PDF";
            this.btExportar.UseVisualStyleBackColor = true;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(256, 343);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(130, 30);
            this.btAceptar.TabIndex = 49;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // dgvPlanPremiosSorteo
            // 
            this.dgvPlanPremiosSorteo.AllowUserToAddRows = false;
            this.dgvPlanPremiosSorteo.AllowUserToDeleteRows = false;
            this.dgvPlanPremiosSorteo.AllowUserToResizeColumns = false;
            this.dgvPlanPremiosSorteo.AllowUserToResizeRows = false;
            this.dgvPlanPremiosSorteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvPlanPremiosSorteo.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlanPremiosSorteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanPremiosSorteo.Location = new System.Drawing.Point(12, 30);
            this.dgvPlanPremiosSorteo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPlanPremiosSorteo.Name = "dgvPlanPremiosSorteo";
            this.dgvPlanPremiosSorteo.ReadOnly = true;
            this.dgvPlanPremiosSorteo.RowHeadersWidth = 51;
            this.dgvPlanPremiosSorteo.RowTemplate.Height = 24;
            this.dgvPlanPremiosSorteo.Size = new System.Drawing.Size(374, 308);
            this.dgvPlanPremiosSorteo.TabIndex = 48;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(14, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(203, 19);
            this.lbTitulo.TabIndex = 47;
            this.lbTitulo.Text = "Plan de premios del sorteo";
            // 
            // FormReportePlanPremios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 383);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.dgvPlanPremiosSorteo);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReportePlanPremios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte plan de premios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPremiosSorteo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.DataGridView dgvPlanPremiosSorteo;
        private System.Windows.Forms.Label lbTitulo;
    }
}