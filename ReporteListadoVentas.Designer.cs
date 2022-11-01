
namespace EmpresaTuLuz
{
    partial class ReporteListadoVentas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PROYECTODataSet = new EmpresaTuLuz.PROYECTODataSet();
            this.VENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VENTASTableAdapter = new EmpresaTuLuz.PROYECTODataSetTableAdapters.VENTASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PROYECTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENTASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosVentas";
            reportDataSource1.Value = this.VENTASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmpresaTuLuz.listadoVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PROYECTODataSet
            // 
            this.PROYECTODataSet.DataSetName = "PROYECTODataSet";
            this.PROYECTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VENTASBindingSource
            // 
            this.VENTASBindingSource.DataMember = "VENTAS";
            this.VENTASBindingSource.DataSource = this.PROYECTODataSet;
            // 
            // VENTASTableAdapter
            // 
            this.VENTASTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteListadoVentas";
            this.Text = "ReporteListadoVentas";
            this.Load += new System.EventHandler(this.ReporteListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PROYECTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENTASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VENTASBindingSource;
        private PROYECTODataSet PROYECTODataSet;
        private PROYECTODataSetTableAdapters.VENTASTableAdapter VENTASTableAdapter;
    }
}