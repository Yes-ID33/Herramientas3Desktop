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
        public static string CadenaConexion = "server=DESKTOP-DQC08B4;database=dboCreacionEventos; integrated security=true";
        public static SqlConnection conexion;

        public async Task ConectarAsync()
        {
            conexion = new SqlConnection(CadenaConexion);
            await conexion.OpenAsync();
        }

        public void DesconectarDB()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
