using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wEventosSociales
{
    public class clsInvitado : clsConexion
    {
        public int intCodInvitado { get; set; }
        public int intCodEvento { get; set; }
        public string strNombre { get; set; }
        public string strCorreo { get; set; }
        public long intTelefono { get; set; }

        public clsInvitado(int intCodInvitado, int intCodEvento, string strNombre, string strCorreo, long intTelefono)
        {
            this.intCodInvitado = intCodInvitado;
            this.intCodEvento = intCodEvento;
            this.strNombre = strNombre;
            this.strCorreo = strCorreo;
            this.intTelefono = intTelefono;
        }

        // Método para insertar un invitado en la tabla tblInvitado
        public bool InsertarInvitado()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();

                    // Consulta SQL para insertar un invitado
                    string insertar = "INSERT INTO tblInvitado (cod_evento, nombre, correo, telefono) VALUES (@intCodEvento, @strNombre, @strCorreo, @intTelefono)";

                    using (SqlCommand sql = new SqlCommand(insertar, conexion))
                    {
                        // Parámetros
                        sql.Parameters.AddWithValue("@intCodEvento", this.intCodEvento);
                        sql.Parameters.AddWithValue("@strNombre", this.strNombre);
                        sql.Parameters.AddWithValue("@strCorreo", this.strCorreo);
                        sql.Parameters.AddWithValue("@intTelefono", this.intTelefono);

                        // Ejecutar la consulta
                        sql.ExecuteNonQuery();
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes personalizarlo según tus necesidades)
                Console.WriteLine("Error al insertar el invitado: " + ex.Message);
                return false;
            }
        }
    }
}
