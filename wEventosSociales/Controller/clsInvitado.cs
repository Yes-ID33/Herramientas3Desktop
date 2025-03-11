using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wEventosSociales
{
    public class clsInvitado
    {
        public int intCodigoInvitado { get; set; }
        public int intCodigoEvento { get; set; }
        public string strNombre { get; set; }
        public string strCorreo { get; set; }
        public long intTelefono { get; set; }

        public clsInvitado(int intCodigoInvitado, int intCodigoEvento, string strNombre, string strCorreo, long intTelefono)
        {
            this.intCodigoInvitado = intCodigoInvitado;
            this.intCodigoEvento = intCodigoEvento;
            this.strNombre = strNombre;
            this.strCorreo = strCorreo;
            this.intTelefono = intTelefono;
        }

        // Método para insertar un invitado en la tabla tblInvitados
        public bool InsertarInvitado()
        {
            try
            {
                // Cadena de conexión
                string connectionString = "server=B13-204-22891;database=dboCreacionEventos; integrated security=true";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    // Consulta SQL para insertar un invitado
                    string insertar = "insert into tblInvitado values (@intCodigoInvitado, @intCodigoEvento, @strNombre, @strCorreo, @intTelefono)";

                    using (SqlCommand sql = new SqlCommand(insertar, conexion))
                    {
                        // Parámetros
                        sql.Parameters.AddWithValue("@intCodigoInvitado", this.intCodigoInvitado);
                        sql.Parameters.AddWithValue("@intCodigoEvento", this.intCodigoEvento);
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
