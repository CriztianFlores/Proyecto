using EmpresaTuLuz.DAO;
using EmpresaTuLuz.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmpresaTuLuz
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            //Limpiar campos de registro nuevo usuario
            limpiarCampos();
            //Cargo la tabla de usuarios
            cargarGrilla();
            //Cargo el comboBox de empleado_id
            cargarComboEmpleado();
            //No esta en edicion
            enModoNormal();

        }

        public void enModoNormal()
        {
            gbAgregar.Enabled = true;
            gbBuscar.Enabled = true;
            gbEdicion.Enabled = false;
            gbDatos.Enabled = false;
        }

        public void enModoClickTabla()
        {
            gbAgregar.Enabled = false;
            gbBuscar.Enabled = false;
            gbEdicion.Enabled = true;
            gbDatos.Enabled = false;
        }

        public void enModoAgregar()
        {
            gbAgregar.Enabled = false;
            gbBuscar.Enabled = false;
            gbEdicion.Enabled = false;
            gbDatos.Enabled = true;
        }

        public void agregarUsuario(Usuario u)
        {
            DataGridViewRow fila = new DataGridViewRow();
            DataGridViewTextBoxCell celdaDocumento = new DataGridViewTextBoxCell();
        }

        public bool esUsuarioValido(int parametro)
        {
            //Variables para los datos
            string nombreUser = txtUsuario.Text;
            string passUser = txtPassword.Text;
            int empleado_id = 0;
            byte estado;
            bool esInactivo = chkInactivo.Checked;
            if (esInactivo)
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }
            //Validar espacios en blanco
            bool tieneUsuario = false;
            bool tienePassword = false;
            bool tieneEmpleado = false;
            bool passCoinciden = false;
            bool existeEnLaGrilla = true;

            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el nombre de usuario");
                txtUsuario.Focus();
            }
            else
            {
                tieneUsuario = true;
            }

            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el password de usuario");
                txtPassword.Focus();
            }
            else
            {
                tienePassword = true;
            }

            if (!txtPassword.Text.Equals(txtRepetirPassword.Text))
            {
                MessageBox.Show("Las passwords no coinciden");
            }
            else
            {
                passCoinciden = true;
            }

            if (cbEmpleadoId.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el id del empleado asociado al nuevo usuario");
                cbEmpleadoId.Focus();
            }
            else
            {
                tieneEmpleado = true;
                empleado_id = (int)cbEmpleadoId.SelectedValue;
            }

            if (tieneUsuario && tienePassword && tieneEmpleado && passCoinciden)
            {
                //Validar existencia en grilla
                if(parametro != 1)
                {
                    existeEnLaGrilla = existeEnGrilla(nombreUser);
                }
                
                if (existeEnLaGrilla)
                {
                    if (parametro == 1)
                    {
                        return true;
                    }
                    MessageBox.Show("El usuario ingresado ya existe. Ingrese otro usuario");
                    limpiarCampos();
                    txtUsuario.Focus();
                }
            }
            return !existeEnLaGrilla;
        }
        
        //EVENTO BOTON AGREGAR
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (esUsuarioValido(0))
            {
                try
                {
                    bool estado_invalido = true;
                    //Crear usuario
                    if (chkInactivo.Checked)
                    {
                        estado_invalido = false;
                    }
                    Usuario u = new Usuario(txtUsuario.Text, txtPassword.Text, (int)cbEmpleadoId.SelectedValue, estado_invalido);
                    bool resultado = UsuarioDAO.registrarUsuario(u);
                    if (resultado)
                    {
                        MessageBox.Show("Usuario registrado con exito");
                        limpiarCampos();
                        cargarGrilla();
                        enModoNormal();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar nuevo usuario");
                        enModoNormal();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al registrar nuevo usuario");
                    enModoNormal();
                }
            }
        }

        //Carga de componentes------------------------------------------------------------------------------

        private void cargarComboEmpleado()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM EMPLEADOS";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                DataTable tabla1 = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                da1.Fill(tabla1);

                cbEmpleadoId.DataSource = tabla;
                cbEmpleadoId.DisplayMember = "EMPLEADO_ID";
                cbEmpleadoId.ValueMember = "EMPLEADO_ID";
                cbEmpleadoId.SelectedIndex = -1;

                cbBuscarEmpleado.DataSource = tabla1;
                cbBuscarEmpleado.DisplayMember = "EMPLEADO_ID";
                cbBuscarEmpleado.ValueMember = "EMPLEADO_ID";
                cbBuscarEmpleado.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void cargarGrilla()
        {
            grillaUsuarios.DataSource = UsuarioDAO.obtenerListadoUsuarios();
        }

        //
        private bool existeEnGrilla(string criterioABuscar)
        {
            bool resultado = false;
            for (int i = 0; i < grillaUsuarios.Rows.Count; i++)
            {
                if (grillaUsuarios.Rows[i].Cells["USUARIO_NOMBRE"].Value.Equals(criterioABuscar))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }

        //Evento click boton Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        //Limpia el recuadro agregar Datos Usuario
        private void limpiarCampos()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtRepetirPassword.Text = "";
            chkInactivo.Checked = false;
            cbEmpleadoId.SelectedIndex = -1;
        }

        //Doy click en una fila de la tabla...
        private void grillaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enModoClickTabla();
            int indice = e.RowIndex;
            if (indice > -1)
            {
                DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[indice];
                string usuario = filaSeleccionada.Cells["USUARIO_NOMBRE"].Value.ToString();
                Usuario u = obtenerUsuario(usuario);
                cargarCampos(u);
            }
                
        }

        //Obtengo el usuario de nombre...
        private Usuario obtenerUsuario(string usuario_nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Usuario u = new Usuario();
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM USUARIOS WHERE USUARIO_NOMBRE LIKE @usuario_nombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario_nombre", usuario_nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if(dr != null && dr.Read())
                {
                    u.Username = dr["USUARIO_NOMBRE"].ToString();
                    u.Password = dr["USUARIO_PASS"].ToString();
                    u.EmpleadoId = int.Parse(dr["EMPLEADO_ID"].ToString());
                    u.Activo = bool.Parse(dr["USUARIO_ACTIVO"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return u;
        }

        //Recibe usuario y llena casilleros
        private void cargarCampos(Usuario u)
        {
            txtUsuario.Text = u.Username;
            txtPassword.Text = u.Password;
            txtRepetirPassword.Text = u.Password;
            cbEmpleadoId.SelectedValue = u.EmpleadoId;
            if(u.Activo)
            {
                chkInactivo.Checked = false;
            }
            else
            {
                chkInactivo.Checked = true;
            }
        }

        //Actualiza los datos de una modificacion
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea realmente modificar al usuario?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (esUsuarioValido(1))
                {

                    try
                    {
                        bool estado_invalido = true;
                        int posicionSeleccionada = grillaUsuarios.CurrentRow.Index;
                        DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[posicionSeleccionada];
                        int index = int.Parse(filaSeleccionada.Cells["USUARIO_ID"].Value.ToString());
                        //Crear usuario
                        if (chkInactivo.Checked)
                        {
                            estado_invalido = false;
                        }
                        Usuario u = new Usuario(txtUsuario.Text, txtPassword.Text, (int)cbEmpleadoId.SelectedValue, estado_invalido);
                        bool resultado = UsuarioDAO.actualizarUsuario(u, index);
                        if (resultado)
                        {
                            MessageBox.Show("Usuario modificado con exito");
                            limpiarCampos();
                            cargarGrilla();
                            txtUsuario.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar usuario");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al modificar usuario");
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No pasa nada");
                }

            }
        }

        //EVENTO BOTON ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Desea realmente eliminar al usuario?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    int posicionSeleccionada = grillaUsuarios.CurrentRow.Index;
                    DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[posicionSeleccionada];
                    int index = int.Parse(filaSeleccionada.Cells["USUARIO_ID"].Value.ToString());
                    bool resultado2 = bool.Parse(filaSeleccionada.Cells["USUARIO_ACTIVO"].Value.ToString());


                    bool resultado = UsuarioDAO.eliminarUsuario(index);
                    if (resultado)
                    {
                        MessageBox.Show("Usuario eliminado con exito");
                        limpiarCampos();
                        cargarGrilla();
                        txtUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar usuario");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar usuario");
                    txtUsuario.Focus();
                }
            }
            
            
        }

        //EVENTO BOTON BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int empleado_id = -3;
            if (cbBuscarEmpleado.SelectedIndex != -1)
            {
                empleado_id = (int)cbBuscarEmpleado.SelectedValue;

                grillaUsuarios.DataSource = obtenerListadoUsuariosEmpleado(empleado_id);

            }
            else
            {
                MessageBox.Show("Seleccione un empleado");
            }
        }

        //Devuelve tabla, metodo del EVENTO BUSCAR
        public DataTable obtenerListadoUsuariosEmpleado(int index)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM USUARIOS WHERE EMPLEADO_ID LIKE @index";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@index",index);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            enModoAgregar();
        }
    }
}
