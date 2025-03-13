using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wEventosSociales;


namespace wEventosSociales
{
    public partial class FormPlanificacionActividades : Form
    {
        private clsGuardarBD evento; // Declarar una variable para almacenar el objeto clsEvento
        private clsDatosCompartidos datosCompartidos; // Declarar una variable para almacenar el objeto DatosCompartidos
        private string tipoEvento;



        public FormPlanificacionActividades(clsGuardarBD evento, clsDatosCompartidos datos)
        {
            InitializeComponent();
            this.evento = evento; // Asignar el objeto recibido al campo local
            this.datosCompartidos = datos; // Asignar el objeto recibido al campo local
            tipoEvento = evento.strTipoEvento; // Obtener el tipo de evento del objeto evento
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void FormPlanificacionActividades_Load(object sender, EventArgs e)
        {
            // Suscribir el evento SelectedIndexChanged al ComboBox cboActividades
            cboActividades.SelectedIndexChanged += cboActividades_SelectedIndexChanged_1;

            switch (tipoEvento)
            {
                case "Boda":
                    LlenarComboBoxBodas();
                    break;
                case "Cumpleaños":
                    LlenarComboBoxCumpleaños();
                    break;
                case "Conferencia":
                    LlenarComboBoxConferencias();
                    break;
                case "Reunion":
                    LlenarComboBoxReuniones();
                    break;
                default:
                    // Si no se selecciona ningún tipo de evento válido, se limpia el ComboBox
                    cboActividades.Items.Clear();
                    break;
            }
            CargarContenidoActividades();
        }

        private void CargarContenidoActividades()
        {
            if (!string.IsNullOrEmpty(datosCompartidos.ContenidoActividades))
            {
                dgvActividades.Rows.Clear();
                string[] lineas = datosCompartidos.ContenidoActividades.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrEmpty(linea))
                    {
                        string[] celdas = linea.Split(',');
                        dgvActividades.Rows.Add(celdas);
                    }
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que se hayan seleccionado todos los campos
            if (cboActividades.SelectedItem != null && cboUbicacion.SelectedItem != null)
            {
                // Obtener los valores seleccionados
                string actividad = cboActividades.SelectedItem.ToString();
                string ubicacion = cboUbicacion.SelectedItem.ToString();
                string hora = dtpHoraActividades.Value.ToString("HH:mm");

                // Agregar los valores al DataGridView
                dgvActividades.Rows.Add(actividad, ubicacion, hora);
            }
            else
            {
                MessageBox.Show("Por favor seleccione una actividad y una ubicación.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
        private void btnCargarCampos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                // Llamar al método LeerCSV de la clase clsCSV para cargar los datos en el DataGridView
                clsCSV.LeerCSV(dgvActividades, rutaArchivo);
            }

        }



        private void LlenarComboBoxBodas()
        {
            cboActividades.Items.Clear();
            cboActividades.Items.Add("Decoración floral");
            cboActividades.Items.Add("Música en vivo");
            cboActividades.Items.Add("Buffet de bodas");
            cboActividades.Items.Add("Fotografía y video");

            //cboUbicacion

            cboUbicacion.Items.Clear();
            cboUbicacion.Items.Add("Jardín al aire libre");
            cboUbicacion.Items.Add("Salón de eventos");
            cboUbicacion.Items.Add("Playa privada");
            cboUbicacion.Items.Add("Iglesia");
        }

        private void LlenarComboBoxCumpleaños()
        {
            cboActividades.Items.Clear();
            cboActividades.Items.Add("Pastel de cumpleaños");
            cboActividades.Items.Add("Juegos y entretenimiento");
            cboActividades.Items.Add("Decoración temática");

            //cboUbicacion

            cboUbicacion.Items.Clear();
            cboUbicacion.Items.Add("Parque de diversiones");
            cboUbicacion.Items.Add("Salón de fiestas");
            cboUbicacion.Items.Add("Casa particular");
            cboUbicacion.Items.Add("Restaurante");
        }

        private void LlenarComboBoxConferencias()
        {
            cboActividades.Items.Clear();
            cboActividades.Items.Add("Alquiler de salas");
            cboActividades.Items.Add("Equipo audiovisual");
            cboActividades.Items.Add("Coffee break");

            //cboUbicacion

            cboUbicacion.Items.Clear();
            cboUbicacion.Items.Add("Centro de convenciones");
            cboUbicacion.Items.Add("Hotel");
            cboUbicacion.Items.Add("Universidad");
            cboUbicacion.Items.Add("Oficina corporativa");
        }

        private void LlenarComboBoxReuniones()
        {
            cboActividades.Items.Clear();
            cboActividades.Items.Add("Sala de reuniones");
            cboActividades.Items.Add("Equipos de conferencia");
            cboActividades.Items.Add("Servicio de catering");

            //cboUbicacion

            cboUbicacion.Items.Clear();
            cboUbicacion.Items.Add("Oficina");
            cboUbicacion.Items.Add("Salón de eventos");
            cboUbicacion.Items.Add("Café");
            cboUbicacion.Items.Add("Restaurante");
        }

        private void cboActividades_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnGuardarActividades_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in dgvActividades.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value?.ToString() + ",");
                }
                sb.AppendLine();
            }
            datosCompartidos.ContenidoActividades = sb.ToString();
            MessageBox.Show("El contenido se ha guardado temporalmente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Los demás métodos (LlenarComboBoxBodas, LlenarComboBoxCumpleaños, etc.) se mantienen igual
    

    private void cboUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool primeravez = true;
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            if (primeravez)
            {
                MessageBox.Show("Este botón solo sirve para limpiar de a una línea,\n selecciona el campo que quieres borrar con cuidado");
                primeravez = false;
            }
            if (dgvActividades.SelectedRows.Count > 0)
            {
                dgvActividades.Rows.RemoveAt(dgvActividades.SelectedRows[0].Index);
            }
            else
            {

            }
        }

        private void dgvActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
