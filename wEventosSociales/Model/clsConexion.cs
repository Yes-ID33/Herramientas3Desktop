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
        private string cadenaDeConexion = "server=B13-204-22891; database=dboCreacionEventos; integrated security=true";
        protected SqlConnection conexion;
        public async Task ConectarAsync()
        {
            conexion = new SqlConnection(cadenaDeConexion);
            await conexion.OpenAsync();
        }
        
        public void DesconectarDB()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        // Función para obtener el codUsuario del usuario loggeado
        public async Task<int> GetUsuarioLoggeadoAsync(string nombreUsuario)
        {
            try
            {
                await ConectarAsync();
                string consulta = "SELECT cod_usuario FROM tblUsuario WHERE nombre_usuario = @nombreUsuario";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                int codUsuario = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                return codUsuario;
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
