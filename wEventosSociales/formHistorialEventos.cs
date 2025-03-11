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
using wEventosSociales;


namespace wEventosSociales
{
    public partial class FormHistorialEventos : Form 
    {
        public string nombreUsuario = null;

        public FormHistorialEventos()
        {
            InitializeComponent();
            txtDescripcionHistorial.Font = new Font(txtDescripcionHistorial.Font.FontFamily, 14, FontStyle.Regular);
            ptbEvento.SizeMode = PictureBoxSizeMode.StretchImage;
            CargarImagenEvento(0);
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHistorialEventos_Load(object sender, EventArgs e)
        {
            CargarDatosInvitados();
            CargarDatosEventos();
            txtDescripcionHistorial.Text = string.Empty; // Limpiar el txtDescripcionHistorial
            CargarImagenEvento(0);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el texto del código se puede convertir a un entero
                if (int.TryParse(txtCodigo.Text, out int codigoEvento))
                {
                    clsEliminarEnDB p1 = new clsEliminarEnDB();

                    // Llamar al método eliminarDato con el código del evento
                    if (await p1.EliminarEventoAsync(codigoEvento, nombreUsuario))
                    {
                        MessageBox.Show("Registro eliminado correctamente.");

                        // Recargar las tablas
                        CargarDatosInvitados();
                        CargarDatosEventos();
                        txtCodigo.Clear();
                        ptbEvento.Image = null; // Limpiar el PictureBox
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar registro.", "ERROR", MessageBoxButtons.OK);
                        txtCodigo.Focus();
                        CargarImagenEvento(0);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un código de evento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Focus();
                    CargarImagenEvento(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro: " + ex.Message);
            }
        }

        private void CargarDatosInvitados()
        {
            string connectionString = "server=B13-204-22891;database=dboCreacionEventos;Integrated Security=True;";
            string query = "SELECT * FROM tblInvitado";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dtgInvitadosHistorial.Columns.Clear();  // Clear existing columns if any
                dtgInvitadosHistorial.DataSource = dataTable;

                // Configure the column headers
                dtgInvitadosHistorial.Columns["intCodigoInvitado"].HeaderText = "Código Invitado";
                dtgInvitadosHistorial.Columns["intCodigoEvento"].HeaderText = "Código Evento";
                dtgInvitadosHistorial.Columns["strNombre"].HeaderText = "Nombre";
                dtgInvitadosHistorial.Columns["strCorreo"].HeaderText = "Correo";
                dtgInvitadosHistorial.Columns["intTelefono"].HeaderText = "Teléfono";
            }

            // Cargar descripciones de eventos en txtDescripcionHistorial
            CargarDescripcionesEventos();
        }
        private void CargarDescripcionesEventos()
       {
            string connectionString = "server=B13-204-22891;database=dboCreacionEventos;Integrated Security=True;";
            string query = "SELECT strDescripcion FROM tblEvento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                StringBuilder sb = new StringBuilder();
                while (reader.Read())
                {
                    sb.AppendLine(reader["strDescripcion"].ToString());
                }

                txtDescripcionHistorial.Text = sb.ToString();
            }
        }
        private void CargarDatosEventos()
        {
            string connectionString = "server=B13-204-22891;database=dboCreacionEventos;Integrated Security=True;";
            string query = "SELECT * FROM tblHistorial";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dtgHistorial.Columns.Clear();
                dtgHistorial.DataSource = dataTable;

                // Configure the column headers
                dtgHistorial.Columns["intCodigoHistorial"].HeaderText="Código Historial";
                dtgHistorial.Columns["intCodigoEvento"].HeaderText = "Código Evento";
                dtgHistorial.Columns["datFecha"].HeaderText = "Fecha";
                dtgHistorial.Columns["datHora"].HeaderText = "Hora";
                dtgHistorial.Columns["strUbicacion"].HeaderText = "Ubicación";
                dtgHistorial.Columns["intInvitadosAprox"].HeaderText = "Invitados Aprox";
                dtgHistorial.Columns["strDescripcion"].HeaderText = "Descripción";
            }
        }
        private void btnMostrarEvento_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigoHistorial.Text, out int codigoEvento) && codigoEvento != 0)
            {
                MessageBox.Show("Has ingresado un número para ver el evento en específico. Ingresa 0 para ver todos los eventos.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FiltrarDatosPorEvento(codigoEvento);
                CargarDatosHistorialPorEvento(codigoEvento);
                CargarImagenEvento(codigoEvento); // Cargar la imagen del evento
                txtCodigoHistorial.Clear();
            }
            else if (int.TryParse(txtCodigoHistorial.Text, out codigoEvento) && codigoEvento == 0)
            {
                MessageBox.Show("Estás viendo todos los eventos creados.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosEventos();
                CargarDatosInvitados();
                txtDescripcionHistorial.Clear();
                txtCodigoHistorial.Clear();
                ptbEvento.Image = null; // Limpiar el PictureBox
            }
            else
            {
                MessageBox.Show("Favor solo ingresar números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoHistorial.Focus();
                CargarImagenEvento(0);
            }
        }

        private void FiltrarDatosPorEvento(int codigoEvento)
        {
            string connectionString = "server=B13-204-22891;database=dboCreacionEventos;Integrated Security=True;";
            string queryInvitados = "SELECT * FROM tblInvitado WHERE intCodigoEvento = @codigoEvento";
            string queryDescripcion = "SELECT strDescripcion FROM tblEvento WHERE intCodigoEvento = @codigoEvento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cargar datos de invitados filtrados por evento
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryInvitados, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@codigoEvento", codigoEvento);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dtgInvitadosHistorial.DataSource = dataTable;

                // Configure the column headers
                dtgInvitadosHistorial.Columns["intCodigoInvitado"].HeaderText = "Código Invitado";
                dtgInvitadosHistorial.Columns["intCodigoEvento"].HeaderText = "Código Evento";
                dtgInvitadosHistorial.Columns["strNombre"].HeaderText = "Nombre";
                dtgInvitadosHistorial.Columns["strCorreo"].HeaderText = "Correo";
                dtgInvitadosHistorial.Columns["intTelefono"].HeaderText = "Teléfono";

                // Cargar descripción del evento
                SqlCommand cmd = new SqlCommand(queryDescripcion, connection);
                cmd.Parameters.AddWithValue("@codigoEvento", codigoEvento);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtDescripcionHistorial.Text = reader["strDescripcion"].ToString();
                }
                else
                {
                    txtDescripcionHistorial.Text = "No se encontró la descripción para el evento especificado.";
                }
            }
        }

        private void CargarDatosHistorialPorEvento(int codigoEvento)
        {
            string connectionString = "server=B13-204-22891;database=dboCreacionEventos;Integrated Security=True;";
            string queryHistorial = "SELECT * FROM tblHistorial WHERE intCodigoEvento = @codigoEvento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryHistorial, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@codigoEvento", codigoEvento);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dtgHistorial.Columns.Clear();
                dtgHistorial.DataSource = dataTable;

                dtgHistorial.Columns["intCodigoHistorial"].HeaderText = "Código Historial";
                dtgHistorial.Columns["intCodigoEvento"].HeaderText = "Código Evento";
                dtgHistorial.Columns["datFecha"].HeaderText = "Fecha";
                dtgHistorial.Columns["datHora"].HeaderText = "Hora";
                dtgHistorial.Columns["strUbicacion"].HeaderText = "Ubicación";
                dtgHistorial.Columns["intInvitadosAprox"].HeaderText = "Invitados Aprox";
                dtgHistorial.Columns["strDescripcion"].HeaderText = "Descripción";
            }
        }
        private void CargarImagenEvento(int codigoEvento)
        {
            // Si el código del evento es 0 (lo que significa que no se ha hecho clic en el botón btnMostrarEvento),
            if (codigoEvento == 0)
            {
                return;
            }
            // Definir la ruta base donde se encuentran las imágenes
            string rutaBaseImagenes = @"C:\Users\Usuario\source\repos\Trabajo Final Estructura y Herramientas\imagenes\"; // Ajusta esta ruta según tu estructura de archivos
            string imagenPredeterminada = "Logo_1.png";

            // Obtener la descripción del evento de la base de datos
            string connectionString = "server=B13-204-22891 ;database=dboCreacionEventos;Integrated Security=True;";
            string queryDescripcion = "SELECT strDescripcion FROM tblHistorial WHERE intCodigoEvento = @codigoEvento";
            string descripcion;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryDescripcion, connection);
                cmd.Parameters.AddWithValue("@codigoEvento", codigoEvento);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    descripcion = reader["strDescripcion"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró la descripción para el evento especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string[] palabras = descripcion.Split(' ');
            string tipoEvento = palabras[0];

            // Seleccionar la imagen según el tipo de evento
            string nombreImagen;
            switch (tipoEvento)
            {
                case "Boda":
                    nombreImagen = "boda.png";
                    break;
                case "Cumpleaños":
                    nombreImagen = "cumpleanios.png";
                    break;
                case "Conferencia":
                    nombreImagen = "conferencia.png";
                    break;
                case "Reunion":
                    nombreImagen = "reu.png";
                    break;
                default:
                    nombreImagen = imagenPredeterminada;
                    break;
            }

            // Combinar la ruta base con el nombre de la imagen
            string rutaImagen = System.IO.Path.Combine(rutaBaseImagenes, nombreImagen);

            // Verificar si la imagen existe y cargarla en el PictureBox
            if (System.IO.File.Exists(rutaImagen))
            {
                ptbEvento.Image = Image.FromFile(rutaImagen);
            }
            else
            {
                // Cargar la imagen predeterminada si la imagen específica no existe
                ptbEvento.Image = Image.FromFile(System.IO.Path.Combine(rutaBaseImagenes, imagenPredeterminada));
            }
            // Configurar el PictureBox en modo StretchImage
            ptbEvento.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void dtgHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ptbEvento_Click(object sender, EventArgs e)
        {

        }
    }
}