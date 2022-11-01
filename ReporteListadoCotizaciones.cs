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
    public partial class ReporteListadoCotizaciones : Form
    {
        public ReporteListadoCotizaciones()
        {
            InitializeComponent();
        }

        private void ReporteListadoCotizaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PROYECTODataSet.COTIZACIONES' table. You can move, or remove it, as needed.
            //this.COTIZACIONESTableAdapter.Fill(this.PROYECTODataSet.COTIZACIONES);

            this.rvCotizaciones.RefreshReport();
        }

        private void rvCotizaciones_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CotizacionDAO.obtenerListadoCotizaciones();

            ReportDataSource ds = new ReportDataSource("DatosCotizaciones",tabla);

            rvCotizaciones.LocalReport.DataSources.Clear();
            rvCotizaciones.LocalReport.DataSources.Add(ds);
            rvCotizaciones.LocalReport.Refresh();
        }
    }
}
