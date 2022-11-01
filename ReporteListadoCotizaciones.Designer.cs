
namespace EmpresaTuLuz
{
    partial class ReporteListadoCotizaciones
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.COTIZACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROYECTODataSet = new EmpresaTuLuz.PROYECTODataSet();
            this.rvCotizaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.COTIZACIONESTableAdapter = new EmpresaTuLuz.PROYECTODataSetTableAdapters.COTIZACIONESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.COTIZACIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROYECTODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // COTIZACIONESBindingSource
            // 
            this.COTIZACIONESBindingSource.DataMember = "COTIZACIONES";
            this.COTIZACIONESBindingSource.DataSource = this.PROYECTODataSet;
            // 
            // PROYECTODataSet
            // 
            this.PROYECTODataSet.DataSetName = "PROYECTODataSet";
            this.PROYECTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvCotizaciones
            // 
            this.rvCotizaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosCotizaciones";
            reportDataSource1.Value = this.COTIZACIONESBindingSource;
            this.rvCotizaciones.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCotizaciones.LocalReport.ReportEmbeddedResource = "EmpresaTuLuz.listadoCotizaciones.rdlc";
            this.rvCotizaciones.Location = new System.Drawing.Point(0, 0);
            this.rvCotizaciones.Name = "rvCotizaciones";
            this.rvCotizaciones.ServerReport.BearerToken = null;
            this.rvCotizaciones.Size = new System.Drawing.Size(674, 574);
            this.rvCotizaciones.TabIndex = 0;
            this.rvCotizaciones.Load += new System.EventHandler(this.rvCotizaciones_Load);
            // 
            // COTIZACIONESTableAdapter
            // 
            this.COTIZACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteListadoCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 574);
            this.Controls.Add(this.rvCotizaciones);
            this.Name = "ReporteListadoCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de cotizaciones";
            this.Load += new System.EventHandler(this.ReporteListadoCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.COTIZACIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROYECTODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCotizaciones;
        private System.Windows.Forms.BindingSource COTIZACIONESBindingSource;
        private PROYECTODataSet PROYECTODataSet;
        private PROYECTODataSetTableAdapters.COTIZACIONESTableAdapter COTIZACIONESTableAdapter;
    }
}