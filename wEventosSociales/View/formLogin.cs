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
        private clsControladorDeUsuarios controlador; // Clase controlador para manejar usuarios

        public formLogin()
        {
            InitializeComponent();
            controlador = new clsControladorDeUsuarios(); // Inicializar el controlador
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
                // Usar la función de encriptación del controlador
                string contrasenaEncriptada = controlador.EncriptarContrasena(txtContrasenia.Text);

                // Verificar las credenciales de inicio de sesión
                var resultado = await controlador.IniciarSesionAsync(txtUsuario.Text, contrasenaEncriptada);

                if (resultado.Item1) // Si el inicio de sesión fue exitoso
                {
                    MessageBox.Show($"Bienvenido {resultado.Item3}!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el formulario principal
                    FormInfoApp principalForm = new FormInfoApp();
                    principalForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error al intentar iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


