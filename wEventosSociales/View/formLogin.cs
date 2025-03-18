using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wEventosSociales
{
    public partial class formLogin : Form
    {
        private clsConexion conectar; // Clase para manejar la conexión

        public formLogin()
        {
            InitializeComponent();
            conectar = new clsConexion(); // Inicializar la clase de conexión
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            // Validar si el usuario y la contraseña están vacíos
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Por favor, ingresa tu usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Abrir la conexión con clsConexion
                await conectar.ConectarAsync();

                // Consulta para verificar usuario y contraseña
                string consulta = "SELECT cod_usuario, nombre_usuario FROM tblUsuario WHERE correo = @correo AND contrasena_encriptada = @contrasena";
                SqlCommand comando = new SqlCommand(consulta, conectar.conexion); // Usar la conexión desde clsConexion
                comando.Parameters.AddWithValue("@correo", txtUsuario.Text);
                comando.Parameters.AddWithValue("@contrasena", txtContrasenia.Text);

                SqlDataReader lector = await comando.ExecuteReaderAsync();

                if (lector.HasRows)
                {
                    lector.Read();
                    int codUsuario = lector.GetInt32(0);
                    string strNombreUsuario = lector.GetString(1);

                    MessageBox.Show($"Bienvenido {strNombreUsuario}!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abre el formulario principal
                    FormInfoApp principalForm = new FormInfoApp(); // Se puede pasar información del usuario si es necesario
                    principalForm.Show();
                    this.Close(); // Cierra el formulario de login
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Desconectar la base de datos usando clsConexion
                conectar.DesconectarDB();
            }
        }

        private void btnIrCrearCuenta_Click(object sender, EventArgs e)
        {
            formRegister formRegister = new formRegister();
            formRegister.Show();
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

