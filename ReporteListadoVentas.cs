using EmpresaTuLuz.DAO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTuLuz
{
    public partial class ReporteListadoVentas : Form
    {
        public ReporteListadoVentas()
        {
            InitializeComponent();
        }

        private void ReporteListadoVentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PROYECTODataSet.VENTAS' table. You can move, or remove it, as needed.
            this.VENTASTableAdapter.Fill(this.PROYECTODataSet.VENTAS);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = VentasDAO.obtenerListadoDeVentas();

            ReportDataSource ds = new ReportDataSource("DatosVentas", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
