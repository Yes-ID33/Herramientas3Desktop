using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace wEventosSociales
{
    public static class clsSesion
    {
        public static string strNombreUsuarioLoggeado { get; set; }
        public static string strCorreo { get; set; }
        public static int intCodUsuarioLoggeado { get; set; }

        // Método para obtener el nombre de usuario basado en el correo
        public static async Task<string> ObtenerNombreUsuarioAsync(string strCorreo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(clsConexion.CadenaConexion))
                {
                    await conexion.OpenAsync();
                    string consulta = "SELECT nombre_usuario FROM tblUsuario WHERE correo = @strCorreo";
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@strCorreo", strCorreo);

                    string strNombreUsuario = (string)await cmd.ExecuteScalarAsync();
                    return strNombreUsuario;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el nombre del usuario: {ex.Message}");
                return null;
            }
        }

        // Método para obtener el código de usuario basado en el correo
        public static async Task<int> ObtenerCodigoUsuarioAsync(string strCorreo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(clsConexion.CadenaConexion))
                {
                    await conexion.OpenAsync();
                    string consulta = "SELECT cod_usuario FROM tblUsuario WHERE correo = @strCorreo";
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@strCorreo", strCorreo);

                    int intCodUsuario = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    return intCodUsuario;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el código del usuario: {ex.Message}");
                return -1;
            }
        }
    }
}
