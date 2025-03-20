using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wEventosSociales
{
    public partial class formRegister : Form
    {
        private clsControladorDeUsuarios controlador; // Clase controlador para manejar usuarios

        public formRegister()
        {
            InitializeComponent();
            controlador = new clsControladorDeUsuarios(); // Inicializar el controlador
        }

        private void formRegister_Load(object sender, EventArgs e)
        {

        }

        private async void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            // Validar si los campos están llenos
            if (string.IsNullOrEmpty(txtNombreUsuario.Text) ||
                string.IsNullOrEmpty(txtCorreoUsuario.Text) ||
                string.IsNullOrEmpty(txtContraseniaUno.Text) ||
                string.IsNullOrEmpty(txtContraseniaDos.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar si las contraseñas coinciden
            if (txtContraseniaUno.Text != txtContraseniaDos.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Usar la función de encriptación del controlador
                string contrasenaEncriptada = controlador.EncriptarContrasena(txtContraseniaUno.Text);

                // Registrar el usuario
                bool resultado = await controlador.RegistrarUsuarioAsync(txtNombreUsuario.Text, txtCorreoUsuario.Text, contrasenaEncriptada);

                if (resultado)
                {
                    MessageBox.Show("Usuario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormInfoApp formInfo = new FormInfoApp();
                    formInfo.Show();
                    this.Close();
                    MessageBox.Show($"Bienvenido!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIrIniciarSesion_Click(object sender, EventArgs e)
        {
            formLogin formLogin = new formLogin();
            formLogin.Show();
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
