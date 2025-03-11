using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wEventosSociales;


namespace wEventosSociales
{
    public partial class FormPlanificacion : Form
    {
        private clsGuardarBD evento;
        private clsDatosCompartidos datosCompartidos;
        public FormPlanificacion(clsGuardarBD evento, clsDatosCompartidos datos)
        {
            InitializeComponent();
            this.evento = evento;
            this.datosCompartidos = datos;
        }

        private void btnListaTareas_Click(object sender, EventArgs e)
        {
            FormListaTareas formListaTareas = new FormListaTareas(this.evento, this.datosCompartidos);
            formListaTareas.Show();
        }

        private void btnAgendaActividades_Click(object sender, EventArgs e)
        {
            FormPlanificacionActividades formPlanificacionActividades = new FormPlanificacionActividades(this.evento, this.datosCompartidos);
            formPlanificacionActividades.Show();
        }

        private void btnGestionInvitados_Click(object sender, EventArgs e)
        {
            FormGestionInvitados formGestionInvitados = new FormGestionInvitados(this.evento, this.datosCompartidos);
            formGestionInvitados.Show();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verificar si los datos de clsDatosCompartidos son nulos o están vacíos
            if (datosCompartidos == null || string.IsNullOrEmpty(datosCompartidos.ContenidoLista) || string.IsNullOrEmpty(datosCompartidos.ContenidoActividades) || string.IsNullOrEmpty(datosCompartidos.ContenidoInvitados))
            {
                // Mostrar un mensaje de advertencia si las variables son nulas o están vacías
                MessageBox.Show("Error al obtener los datos de Datos Compartidos. Por favor, asegúrate de que los datos estén disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si los datos de clsEvento son nulos
            if (evento == null)
            {
                // Mostrar un mensaje de advertencia si las variables son nulas
                MessageBox.Show("Error al obtener los datos del evento. Por favor, asegúrate de que los datos estén disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de confirmación con todos los datos del evento y los datos compartidos
            MessageBox.Show($"Tipo de Evento: {evento.TipoEvento}\n" +
                            $"Fecha: {evento.datFecha.ToShortDateString()}\n" +
                            $"Hora: {evento.datHora}\n" +
                            $"Ubicación: {evento.strUbicacion}\n" +
                            $"Invitados Aproximados: {evento.intInvitadosAprox}\n" +
                            $"Descripción: {evento.strDescripcion}\n\n" +
                            $"Contenido de Lista:\n{datosCompartidos.ContenidoLista}\n\n" +
                            $"Contenido de Actividades:\n{datosCompartidos.ContenidoActividades}\n\n" +
                            $"Lista de Invitados:\n{datosCompartidos.ContenidoInvitados}",
                            "Datos Confirmados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para guardar los datos en la base de datos (este es solo un ejemplo, deberías implementarlo según tus necesidades)

        private void FormPlanificacion_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
