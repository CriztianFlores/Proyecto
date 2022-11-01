using EmpresaTuLuz.DAO;
using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTuLuz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese usuario y contrasena");
            }
            else
            {
                string usuario = txtUsuario.Text;
                string password = txtPassword.Text;
                bool resultado = false;
                try
                {
                    resultado = UsuarioDAO.validarUsuario(usuario, password);
                    if (resultado)
                    {
                        Usuario user = new Usuario(usuario, password);
                        PrincipalForm ventanaPrincipal = new PrincipalForm(user);
                        ventanaPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexsistente");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al consultar usuario");
                }  
            }
        }
    }
}
