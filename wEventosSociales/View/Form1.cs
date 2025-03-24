using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wEventosSociales;
using System.Drawing.Drawing2D;

namespace wEventosSociales
{
    public partial class FormCrearEvento : Form
    {
        private clsGuardarBD evento = new clsGuardarBD(); // Objeto para guardar datos del evento
        private clsDatosCompartidos datosCompartidos = new clsDatosCompartidos(); // Almacén temporal de datos

        public FormCrearEvento()
        {
            InitializeComponent();
            // Cambiar el tamaño de la fuente del TextBox txtDescripcion
            txtDescripcion.Font = new Font(txtDescripcion.Font.FontFamily, 13, FontStyle.Regular);
        }

        private void formCrearEvento_Load(object sender, EventArgs e)
        {
            // Agregar opciones al ComboBox cboTipoEvento
            cboTipoEvento.Items.AddRange(new string[] { "Boda", "Cumpleaños", "Conferencia", "Reunión" });

            // Agregar opciones al ComboBox cboNivelEvento
            cboNivelEvento.Items.AddRange(new string[] { "Bronce", "Plata", "Oro" });

            // Mostrar el usuario loggeado en la interfaz
            lblUsuario.Text = $"Usuario: {clsSesion.strNombreUsuarioLoggeado}";
        }

        private async void btnPlanificacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si todos los campos están llenos
                if (cboTipoEvento.SelectedItem != null && cboNivelEvento.SelectedItem != null && !string.IsNullOrEmpty(txtUbicacion.Text)
                    && dtpFecha.Value != null && dtpHora.Value != null && !string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtInvitadosAprox.Text))
                {
                    if (!int.TryParse(txtInvitadosAprox.Text, out int invitados))
                    {
                        MessageBox.Show("Por favor, ingrese solo valores numéricos en el campo de invitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Crear el evento con los datos ingresados
                    evento.strUbicacion = txtUbicacion.Text;
                    evento.datFecha = dtpFecha.Value;
                    evento.datHora = dtpHora.Value.TimeOfDay;
                    evento.strDescripcion = $"{cboTipoEvento.SelectedItem}\n{txtDescripcion.Text}";
                    evento.intInvitadosAprox = int.Parse(txtInvitadosAprox.Text);
                    evento.intCodNivel = cboNivelEvento.SelectedIndex + 1; // Corresponde a los niveles del evento (Bronce, Plata, Oro)
                    evento.intCodUsuario = clsSesion.intCodUsuarioLoggeado; // Usamos el código del usuario desde clsSesion

                    // Guardar temporalmente (si aplica) y luego mostrar la planificación
                    FormPlanificacion formPlanificacion = new FormPlanificacion(evento, datosCompartidos);

                    // Ocultar el formulario actual y mostrar el siguiente
                    this.Hide();
                    formPlanificacion.Show();

                    // Insertar los datos del evento en la base de datos
                    if (await evento.InsertarEventoAsync())
                    {
                        MessageBox.Show("Evento creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el evento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ingresar el dato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoEvento.SelectedItem == null)
            {
                return;
            }

            string tipoEvento = cboTipoEvento.SelectedItem.ToString().Trim(); // Elimina espacios en blanco al inicio y al final

            switch (tipoEvento)
            {
                case "Boda":
                case "Cumpleaños":
                case "Conferencia":
                case "Reunión":
                    lblDescripcionEvento.Visible = true;
                    break;
                default:
                    txtDescripcion.Text = "";
                    break;
            }

            if (evento != null) // Evita error si el objeto evento no está instanciado
            {
                evento.strTipoEvento = tipoEvento;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Restablecer todos los campos del formulario
            cboTipoEvento.SelectedIndex = -1; // Desseleccionar ComboBox
            cboNivelEvento.SelectedIndex = -1; // Desseleccionar ComboBox
            txtUbicacion.Clear();
            txtInvitadosAprox.Clear();
            txtDescripcion.Clear();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        { }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        { }
    }
}