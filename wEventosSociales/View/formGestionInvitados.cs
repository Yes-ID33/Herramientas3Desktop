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
using static System.Windows.Forms.LinkLabel;
using wEventosSociales;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;


namespace wEventosSociales
{
    public partial class FormGestionInvitados : Form
    {
        private clsGuardarBD evento;
        private clsDatosCompartidos datosCompartidos; 

        public FormGestionInvitados(clsGuardarBD evento, clsDatosCompartidos datos)
        {
            InitializeComponent();
            this.evento = evento;
            this.datosCompartidos = datos;
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dtgInvitados.Rows[dtgInvitados.CurrentCell.RowIndex].Cells[1].Value != null &&
                !string.IsNullOrWhiteSpace(dtgInvitados.Rows[dtgInvitados.CurrentCell.RowIndex].Cells[0].Value.ToString()))
            {
                Random rnd = new Random();
                string telefono = "3" + rnd.Next(100000000, 999999999).ToString(); // Genera un número de teléfono aleatorio que comienza con 3
                string nombre = dtgInvitados.Rows[dtgInvitados.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string[] palabras = nombre.Split(' ');
                if (palabras.Length >= 2)
                {
                    string correo = palabras[0] + "." + palabras[1] + "@gmail.com";
                    dtgInvitados.Rows[dtgInvitados.CurrentCell.RowIndex].Cells[2].Value = correo;
                }
                else
                {
                    string correo = nombre.Replace(" ", ".") + "@gmail.com";
                    dtgInvitados.Rows[dtgInvitados.CurrentCell.RowIndex].Cells[2].Value = correo;
                }
                dtgInvitados.Rows[dtgInvitados.CurrentCell.RowIndex].Cells[3].Value = telefono;
            }
            else
            {
                MessageBox.Show("Por favor ingrese el nombre en la columna correspondiente", "Advertencia");
            }


        }

        public bool primeravez = true;
        private void btnLimpiarDatos_Click_1(object sender, EventArgs e)
        {
            if (primeravez) 
            {
                MessageBox.Show("Este botón solo sirve para limpiar de a una línea,\n selecciona el campo que quieres borrar con cuidado");
                primeravez = false;
            }
            if (dtgInvitados.SelectedRows.Count > 0)
            {
                dtgInvitados.Rows.RemoveAt(dtgInvitados.SelectedRows[0].Index);
            }
            else
            {
               
            }
        }
      
        private void btnCargarCorreos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                // Llamar al método LeerCSV de la clase clsCSV para cargar los datos en el DataGridView
                clsCSV.LeerCSV(dtgInvitados, rutaArchivo);
            }
        }

        private void FormGestionInvitados_Load(object sender, EventArgs e)
        {
            CargarContenidoInvitados();
        }
        private void CargarContenidoInvitados()
        {
            if (!string.IsNullOrEmpty(datosCompartidos.ContenidoInvitados))
            {
                dtgInvitados.Rows.Clear();
                string[] lineas = datosCompartidos.ContenidoInvitados.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrEmpty(linea))
                    {
                        string[] celdas = linea.Split(',');
                        dtgInvitados.Rows.Add(celdas);
                    }
                }
            }
        }
        private void btnSubirLista_Click(object sender, EventArgs e)
        {
            try
            {
                int totalInvitados = ObtenerTotalInvitados();
                bool todosIngresados = true;

                foreach (DataGridViewRow row in dtgInvitados.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
                    {
                        int intCodigoInvitado = totalInvitados + Convert.ToInt32(row.Cells[0].Value);
                        int intCodigoEvento = this.evento.codEvento; // Suponiendo que este es el código del evento
                        string strNombre = row.Cells[1].Value.ToString();
                        string strCorreo = row.Cells[2].Value.ToString();
                        long intTelefono = Convert.ToInt64(row.Cells[3].Value);

                        SqlConnection conexion = new SqlConnection("server=B13-204-22891;database=dboCreacionEventos; integrated security=true");
                        conexion.Open();

                        // Insertar los datos en la base de datos
                        clsInvitado invitado = new clsInvitado(
                            intCodigoInvitado,
                            intCodigoEvento,
                            strNombre,
                            strCorreo,
                            intTelefono
                        );
                        bool resultado = invitado.InsertarInvitado();

                        if (!resultado)
                        {
                            todosIngresados = false;
                            MessageBox.Show("Error al insertar datos del invitado con código " + intCodigoInvitado);
                        }
                    }
                }

                if (todosIngresados)
                {
                    // Mostrar mensaje de éxito
                    MessageBox.Show("Las invitaciones fueron enviadas correctamente a todos los invitados.", "Enviado con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Datos Ingresados", "Continua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow row in dtgInvitados.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value?.ToString() + ",");
                    }
                    sb.AppendLine();
                }
                datosCompartidos.ContenidoInvitados = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public int ObtenerTotalInvitados()
        {
            int totalInvitados = 0;

            string connectionString = "server=B13-204-22891;database=dboCreacionEventos; integrated security=true";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                string consulta = "SELECT COUNT(*) FROM tblInvitado";

                using (SqlCommand sql = new SqlCommand(consulta, conexion))
                {
                    totalInvitados = (int)sql.ExecuteScalar();
                }
            }

            return totalInvitados;
        }

        private void dtgInvitados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
