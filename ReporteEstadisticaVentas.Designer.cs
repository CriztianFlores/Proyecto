
namespace EmpresaTuLuz
{
    partial class ReporteEstadisticaVentas
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
            this.rvEstadisticaVentaProducto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvEstadisticaVentaProducto
            // 
            this.rvEstadisticaVentaProducto.LocalReport.ReportEmbeddedResource = "EmpresaTuLuz.EstadisticaProducto.rdlc";
            this.rvEstadisticaVentaProducto.Location = new System.Drawing.Point(24, 87);
            this.rvEstadisticaVentaProducto.Name = "rvEstadisticaVentaProducto";
            this.rvEstadisticaVentaProducto.ServerReport.BearerToken = null;
            this.rvEstadisticaVentaProducto.Size = new System.Drawing.Size(765, 451);
            this.rvEstadisticaVentaProducto.TabIndex = 0;
            this.rvEstadisticaVentaProducto.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteEstadisticaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 608);
            this.Controls.Add(this.rvEstadisticaVentaProducto);
            this.Name = "ReporteEstadisticaVentas";
            this.Text = "Estadistica Ventas de Producto";
            this.Load += new System.EventHandler(this.ReporteEstadisticaVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvEstadisticaVentaProducto;
    }
}