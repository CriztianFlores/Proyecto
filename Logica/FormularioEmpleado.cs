using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresaTuLuz.Entidades;

namespace EmpresaTuLuz
{
    public partial class RegistrarEmpleado : Form
    {
        public RegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void RegistrarEmpleado_Load(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Variables para crear objeto
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string numeroDocumento = txtNumDoc.Text;

            //Validar datos permitidos
            bool tieneNombre = false;
            bool tieneApellido = false;
            bool tieneTipoDoc = false;
            bool tieneNumDoc = false;
            bool tieneBarrio = false;
            bool tieneIdJefe = false;

            bool situacionJefe = false;



            // Variables para validar si existe en la grilla
            bool existeEnLaGrilla = false;


            //Campos vacios
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el nombre del empleado.");
                txtNombre.Focus();
            }
            if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el apellido del empleado.");
                txtApellido.Focus();
            }
            //Agregar el de tipo doc
            if (txtNumDoc.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el numero de documento del empleado.");
                txtNumDoc.Focus();
            }
            //Agregar el de los combo box

            //Validar el combobox del jefe y el checkbox de no tiene
            if(!chkNoTieneJefe.Checked && tieneIdJefe)
            {
                situacionJefe = true;
            }
            else
            {
                situacionJefe = false;
            }

            existeEnLaGrilla = existeEnGrilla(numeroDocumento);
            if (existeEnLaGrilla)
            {
                MessageBox.Show("Persona registrada previamente.");
            }

            //Ultima validacion que permite crear el empleado
            if(tieneNombre && tieneApellido && tieneTipoDoc && tieneNumDoc && tieneBarrio && situacionJefe)
            {
                //Crear objeto Empleado
                //Empleado emp = new Empleado(nombre, apellido);
                //agregarEmpleado(emp);
            }

        }

        private void agregarEmpleado(Empleado emp)
        {
            //Creo una fila
            DataGridViewRow fila = new DataGridViewRow();

            //Creo una celda - valor de cada columna
            //Columna nombre
            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = emp.Nombre;
            fila.Cells.Add(celdaNombre);

            //Columna apellido
            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = emp.Apellido;
            fila.Cells.Add(celdaApellido);

            //Agrego la fila a la tabla
            gdrEmpleados.Rows.Add(fila);


            MessageBox.Show("Persona agregada con exito");
            limpiarCampos();
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTieneJefe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoTieneJefe.Checked)
            {
                cbIdJefe.Enabled = false;
            }
            else
            {
                cbIdJefe.Enabled = true;
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumDoc.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            chkNoTieneJefe.Checked = false;
        }

        private bool existeEnGrilla(string criterioABuscar)
        {
            bool resultado = false;
            for (int i = 0; i < gdrEmpleados.Rows.Count; i++)
            {
                if (gdrEmpleados.Rows[i].Cells["Documento"].Value.Equals(criterioABuscar))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }
    }
}
