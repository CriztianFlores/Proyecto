using EmpresaTuLuz.Entidades;
using System;
using System.Windows.Forms;

namespace EmpresaTuLuz
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Usuario user)
        {
            InitializeComponent();
        }

        private void registrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCliente ventanaRegCliente = new RegistrarCliente();
            ventanaRegCliente.Show();
        }

        private void registrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado ventanaRegEmpleado = new RegistrarEmpleado();
            ventanaRegEmpleado.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados ventanaUsuarios = new Empleados();
            ventanaUsuarios.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Empleados ventanaEmpleados = new Empleados();
            //ventanaEmpleados.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //RegistrarCliente ventanaClientes = new RegistrarCliente();
            //ventanaClientes.Show();
        }

        private void listadoDeCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteListadoCotizaciones ventana = new ReporteListadoCotizaciones();
            ventana.ShowDialog();
        }

        private void graficoDeVentaAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEstadisticaVentas ventana = new ReporteEstadisticaVentas();
            ventana.ShowDialog();
        }

        private void listadoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteListadoVentas ventana = new ReporteListadoVentas();
            ventana.ShowDialog();
        }
    }
}
