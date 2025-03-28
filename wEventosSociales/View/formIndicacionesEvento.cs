﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using wEventosSociales;

namespace wEventosSociales
{
    public partial class FormListaTareas : Form
    {
        private clsGuardarBD evento; // Declarar una variable para almacenar el objeto clsEvento
        private clsDatosCompartidos datosCompartidos; // Declarar una variable para almacenar el objeto DatosCompartidos
        private string tipoEvento;
        public FormListaTareas(clsGuardarBD evento, clsDatosCompartidos datos)
        {
            InitializeComponent();
            this.evento = evento; // Asignar el objeto recibido al campo local
            this.datosCompartidos = datos; // Asignar el objeto recibido al campo local

            tipoEvento = evento.strTipoEvento;
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        public bool primeravez = true;
        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            if (primeravez)
            {
                MessageBox.Show("Este botón solo sirve para limpiar de a una línea,\n selecciona el campo que quieres borrar con cuidado");
                primeravez = false;
            }
            if (dtgListaIndicaciones.SelectedRows.Count > 0)
            {
                dtgListaIndicaciones.Rows.RemoveAt(dtgListaIndicaciones.SelectedRows[0].Index);
            }
            else
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de StringBuilder para construir la cadena de texto
            StringBuilder sb = new StringBuilder();

            // Recorrer cada fila del DataGridView
            foreach (DataGridViewRow row in dtgListaIndicaciones.Rows)
            {
                // Recorrer cada celda de la fila
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Agregar el valor de la celda al StringBuilder seguido de una coma
                    sb.Append(cell.Value?.ToString() + ",");
                }
                // Agregar una nueva línea al final de la fila
                sb.AppendLine();
            }

            // Guardar el contenido del StringBuilder en la propiedad ContenidoLista de datosCompartidos
            datosCompartidos.ContenidoLista = sb.ToString();

            // Mostrar un mensaje indicando que el contenido se ha guardado temporalmente
            MessageBox.Show("El contenido se ha guardado temporalmente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Los demás métodos (LlenarComboBoxBodas, LlenarComboBoxCumpleaños, etc.) se mantienen igual
    


    private void btnCargarTareas_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                // Llamar al método LeerCSV de la clase clsCSV para cargar los datos en el DataGridView
                clsCSV.LeerCSV(dtgListaIndicaciones, rutaArchivo);
            }
        }

        private void dtgListaTareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtgListaIndicaciones.Columns["ColumnTarea"].Index ||
                e.ColumnIndex == dtgListaIndicaciones.Columns["ColumnInvitado"].Index)
            {
                e.CellStyle.Font = new Font("Arial", 14, FontStyle.Regular);
            }
        }

        private void FormListaTareas_Load(object sender, EventArgs e)
        {
            // Configurar el tamaño de la fuente del encabezado
            dtgListaIndicaciones.Columns["ColumnTarea"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Regular);
            dtgListaIndicaciones.Columns["ColumnInvitado"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Regular);

            // Suscribirse al evento CellFormatting
            dtgListaIndicaciones.CellFormatting += dtgListaTareas_CellFormatting;
            CargarContenidoLista();
        }

        private void CargarContenidoLista()
        {
            // Verificar si la propiedad ContenidoLista no está vacía
            if (!string.IsNullOrEmpty(datosCompartidos.ContenidoLista))
            {
                // Limpiar todas las filas existentes en el DataGridView
                dtgListaIndicaciones.Rows.Clear();

                // Dividir el contenido de ContenidoLista en líneas
                string[] lineas = datosCompartidos.ContenidoLista.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                // Recorrer cada línea del array de líneas
                foreach (string linea in lineas)
                {
                    // Verificar si la línea no está vacía
                    if (!string.IsNullOrEmpty(linea))
                    {
                        // Dividir la línea en celdas utilizando la coma como delimitador
                        string[] celdas = linea.Split(',');

                        // Agregar las celdas como una nueva fila en el DataGridView
                        dtgListaIndicaciones.Rows.Add(celdas);
                    }
                }
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
