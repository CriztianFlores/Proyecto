using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTuLuz.DAO
{
    class UsuarioDAO
    {
        //Validar si el usuario existe en la BD
        public static bool validarUsuario(string usuario, string password)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM USUARIOS WHERE USUARIO_NOMBRE LIKE @usu AND USUARIO_PASS LIKE @pass";
                //Agregando parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usu", usuario);
                cmd.Parameters.AddWithValue("@pass", password);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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

        public static DataTable obtenerListadoUsuarios()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT U.*, E.EMPLEADO_NOMBRE AS 'NOMBRE', E.EMPLEADO_APELLIDO AS 'APELLIDO', TD.TIPO_DOC_SIGLA AS 'TIPO DOC', E.EMPLEADO_NUM_DOC AS 'NRO DOCUMENTO' FROM USUARIOS U INNER JOIN EMPLEADOS E ON(U.EMPLEADO_ID = E.EMPLEADO_ID) INNER JOIN TIPOS_DOC TD ON (E.TIPO_DOC_ID = TD.TIPO_DOC_ID);";
                cmd.Parameters.Clear();
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

        public static bool registrarUsuario(Usuario u)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO USUARIOS (USUARIO_NOMBRE, USUARIO_PASS, EMPLEADO_ID, USUARIO_ACTIVO) VALUES(@nombreUsuario, @passUsuario, @idEmmpleado, @estado);";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", u.Username);
                cmd.Parameters.AddWithValue("@passUsuario", u.Password);
                cmd.Parameters.AddWithValue("@idEmmpleado", u.EmpleadoId);
                cmd.Parameters.AddWithValue("@estado", u.Activo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                //Si ejecuto esto y no hubo ninguna excepcion fue porque fue exitosa la insercion
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }
            return resultado;

        }

        public static bool actualizarUsuario(Usuario u, int index)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE USUARIOS SET USUARIO_NOMBRE = @nombreUsuario, USUARIO_PASS= @passUsuario , EMPLEADO_ID = @idEmmpleado , USUARIO_ACTIVO = @estado WHERE USUARIO_ID = @index";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", u.Username);
                cmd.Parameters.AddWithValue("@passUsuario", u.Password);
                cmd.Parameters.AddWithValue("@idEmmpleado", u.EmpleadoId);
                cmd.Parameters.AddWithValue("@estado", u.Activo);
                cmd.Parameters.AddWithValue("@index", index);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                //Si ejecuto esto y no hubo ninguna excepcion fue porque fue exitosa la insercion
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }
            return resultado;
        }


        public static bool eliminarUsuario(int index)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM USUARIOS WHERE USUARIO_ID = @index";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@index", index);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                //Si ejecuto esto y no hubo ninguna excepcion fue porque fue exitosa la insercion
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }
            return resultado;
        }

    }
}
