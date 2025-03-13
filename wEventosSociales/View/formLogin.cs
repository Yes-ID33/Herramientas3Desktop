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
    public partial class formLogin: Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=");

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
                // Abrir la conexión
                await conexion.OpenAsync();

                // Consulta para verificar usuario y contraseña
                string consulta = "SELECT cod_usuario, nombre_usuario FROM tblUsuario WHERE correo = @correo AND contrasena_encriptada = @contrasena";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@correo", txtUsuario.Text);
                comando.Parameters.AddWithValue("@contrasena", txtContrasenia.Text);

                SqlDataReader lector = await comando.ExecuteReaderAsync();

                if (lector.HasRows)
                {
                    // Si se encuentra el usuario, cerramos el login y mostramos la aplicación principal
                    lector.Read();  // Leer el primer (y único) resultado
                    int codUsuario = lector.GetInt32(0);
                    string nombreUsuario = lector.GetString(1);

                    MessageBox.Show($"Bienvenido {nombreUsuario}!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abre la ventana principal
                    FormInfoApp formInfoApp = new FormInfoApp();  // Pasa el codUsuario para mantenerlo disponible
                    formInfoApp.Show();
                    this.Close();  // Cierra el formulario de login
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
                // Asegurarse de cerrar la conexión en cualquier caso
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
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
