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
    public partial class ReporteEstadisticaVentas : Form
    {
        public ReporteEstadisticaVentas()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaVentas_Load(object sender, EventArgs e)
        {

            this.rvEstadisticaVentaProducto.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CotizacionDAO.obtenerEstadisticaProductoVendido();

            ReportDataSource ds = new ReportDataSource("DatosEstadisticasProductos", tabla);

            rvEstadisticaVentaProducto.LocalReport.DataSources.Clear();
            rvEstadisticaVentaProducto.LocalReport.DataSources.Add(ds);
            rvEstadisticaVentaProducto.LocalReport.Refresh();
        }
    }
}
