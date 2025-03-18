using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace wEventosSociales
{
    public class clsConexion
    {
        public string cadenaConexion = "server=B13-204-22901;database=dboCreacionEventos; integrated security=true";
        public SqlConnection conexion;

        public async Task ConectarAsync()
        {
            conexion = new SqlConnection(cadenaConexion);
            await conexion.OpenAsync();
        }

        public void DesconectarDB()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        // Método para obtener el intCodUsuario del usuario loggeado
        public async Task<int> GetUsuarioLoggeadoAsync(string strNombreUsuario)
        {
            try
            {
                await ConectarAsync();
                string consulta = "SELECT cod_usuario FROM tblUsuario WHERE nombre_usuario = @strNombreUsuario";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@strNombreUsuario", strNombreUsuario);

                int intCodUsuario = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                return intCodUsuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el usuario loggeado: " + ex.Message);
                return -1;
            }
            finally
            {
                DesconectarDB();
            }
        }
    }
}
