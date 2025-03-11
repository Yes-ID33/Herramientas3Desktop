using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace wEventosSociales
{
    public class clsCSV
    {
        // Método para leer datos desde un archivo CSV y cargarlos en un DataGridView
        public static void LeerCSV(DataGridView dataGridView, string rutaArchivo)
        {
            try
            {
                // Limpiar el DataGridView antes de cargar nuevos datos
                dataGridView.Rows.Clear();
                int columnCount = dataGridView.ColumnCount;

                // Leer todas las líneas del archivo CSV
                string[] lines = File.ReadAllLines(rutaArchivo);

                foreach (string line in lines)
                {
                    // Dividir cada línea en partes utilizando el punto y coma como separador
                    string[] parts = line.Split(';');
                    if (parts.Length == columnCount)
                    {
                        // Agregar las partes como una nueva fila en el DataGridView
                        dataGridView.Rows.Add(parts);
                    }
                    else
                    {
                        // Mostrar un mensaje indicando que el CSV no coincide con la cantidad de columnas
                        MessageBox.Show("El archivo CSV seleccionado no tiene la cantidad correcta de columnas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}