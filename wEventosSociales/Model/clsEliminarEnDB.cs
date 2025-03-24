using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace wEventosSociales
{
    public class clsEliminarEnDB : clsConexion
    {
        // Propiedades
        public int codEvento { get; set; }
        public int codUsuario { get; set; } // Código del usuario loggeado

        public clsEliminarEnDB() { }

        /* Método para verificar y eliminar evento si el usuario loggeado es el creador
        public async Task<bool> EliminarEventoAsync(int codEvento, string nombreUsuario)
        {
            try
            {
                int codUsuarioLoggeado = await GetUsuarioLoggeadoAsync(nombreUsuario);
                if (codUsuarioLoggeado == -1)
                {
                    Console.WriteLine("No se pudo obtener el usuario loggeado.");
                    return false;
                }

                await ConectarAsync();
                string consulta = "SELECT cod_usuario FROM tblEvento WHERE cod_evento = @codEvento";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@codEvento", codEvento);

                int usuarioCreador = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                if (usuarioCreador != codUsuarioLoggeado)
                {
                    Console.WriteLine("El usuario loggeado no es el creador del evento.");
                    return false;
                }

                string eliminarHistorial = "DELETE FROM tblHistorial WHERE cod_evento = @codEvento";
                SqlCommand cmdEliminarHistorial = new SqlCommand(eliminarHistorial, conexion);
                cmdEliminarHistorial.Parameters.AddWithValue("@codEvento", codEvento);
                await cmdEliminarHistorial.ExecuteNonQueryAsync();

                string eliminarTareas = "DELETE FROM tblTareaEvento WHERE cod_evento = @codEvento";
                SqlCommand cmdEliminarTareas = new SqlCommand(eliminarTareas, conexion);
                cmdEliminarTareas.Parameters.AddWithValue("@codEvento", codEvento);
                await cmdEliminarTareas.ExecuteNonQueryAsync();

                string eliminarInvitados = "DELETE FROM tblInvitado WHERE cod_evento = @codEvento";
                SqlCommand cmdEliminarInvitados = new SqlCommand(eliminarInvitados, conexion);
                cmdEliminarInvitados.Parameters.AddWithValue("@codEvento", codEvento);
                await cmdEliminarInvitados.ExecuteNonQueryAsync();

                string eliminarEvento = "DELETE FROM tblEvento WHERE cod_evento = @codEvento";
                SqlCommand cmdEliminarEvento = new SqlCommand(eliminarEvento, conexion);
                cmdEliminarEvento.Parameters.AddWithValue("@codEvento", codEvento);
                await cmdEliminarEvento.ExecuteNonQueryAsync();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar evento: " + ex.Message);
                return false;
            }
            finally
            {
                DesconectarDB();
            }
        }
        */
    }
}
