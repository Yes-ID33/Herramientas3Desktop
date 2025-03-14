using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wEventosSociales
{
    public class clsGuardarBD : clsConexion
    {
        // Propiedades
        public int intCodUsuario { get; set; }
        public string strNombreUsuario { get; set; }
        public string strCorreo { get; set; }
        public string strContrasenaEncriptada { get; set; }
        public int intCodEvento { get; set; }
        public string strTipoEvento { get; set; }
        public DateTime datFecha { get; set; }
        public TimeSpan datHora { get; set; }
        public string strUbicacion { get; set; }
        public int intInvitadosAprox { get; set; }
        public string strDescripcion { get; set; }
        public int intCodNivel { get; set; }
        public string strDescripcionTarea { get; set; }

        // Constructor
        public clsGuardarBD() { }

        // Método para insertar usuario
        public async Task<bool> InsertarUsuarioAsync()
        {
            try
            {
                await ConectarAsync();

                string insertarUsuario = "INSERT INTO tblUsuario (nombre_usuario, correo, contrasena_encriptada) VALUES (@strNombreUsuario, @strCorreo, @strContrasenaEncriptada)";
                SqlCommand cmdUsuario = new SqlCommand(insertarUsuario, conexion);

                cmdUsuario.Parameters.AddWithValue("@strNombreUsuario", this.strNombreUsuario);
                cmdUsuario.Parameters.AddWithValue("@strCorreo", this.strCorreo);
                cmdUsuario.Parameters.AddWithValue("@strContrasenaEncriptada", this.strContrasenaEncriptada);
                await cmdUsuario.ExecuteNonQueryAsync();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar usuario: " + ex.Message);
                return false;
            }
            finally
            {
                DesconectarDB();
            }
        }

        // Método para insertar datos del evento en la base de datos
        public async Task<bool> InsertarEventoAsync()
        {
            try
            {
                await ConectarAsync();

                string insertarEvento = "INSERT INTO tblEvento (tipo_evento, fecha, hora, ubicacion, invitados_aprox, descripcion, cod_usuario) VALUES (@strTipoEvento, @datFecha, @datHora, @strUbicacion, @intInvitadosAprox, @strDescripcion, @intCodUsuario)";
                SqlCommand cmdEvento = new SqlCommand(insertarEvento, conexion);

                cmdEvento.Parameters.AddWithValue("@strTipoEvento", this.strTipoEvento);
                cmdEvento.Parameters.AddWithValue("@datFecha", this.datFecha);
                cmdEvento.Parameters.AddWithValue("@datHora", this.datHora);
                cmdEvento.Parameters.AddWithValue("@strUbicacion", this.strUbicacion);
                cmdEvento.Parameters.AddWithValue("@intInvitadosAprox", this.intInvitadosAprox);
                cmdEvento.Parameters.AddWithValue("@strDescripcion", this.strDescripcion);
                cmdEvento.Parameters.AddWithValue("@intCodUsuario", this.intCodUsuario);
                await cmdEvento.ExecuteNonQueryAsync();

                // Obtener el último código de evento insertado
                int ultimoCodEvento = Convert.ToInt32(await new SqlCommand("SELECT SCOPE_IDENTITY()", conexion).ExecuteScalarAsync());

                string insertarHistorial = "INSERT INTO tblHistorial (cod_evento, cod_usuario, fecha, hora, ubicacion, invitados_aprox, descripcion) VALUES (@intCodEvento, @intCodUsuario, @datFecha, @datHora, @strUbicacion, @intInvitadosAprox, @strDescripcion)";
                SqlCommand cmdHistorial = new SqlCommand(insertarHistorial, conexion);

                cmdHistorial.Parameters.AddWithValue("@intCodEvento", ultimoCodEvento);
                cmdHistorial.Parameters.AddWithValue("@intCodUsuario", this.intCodUsuario);
                cmdHistorial.Parameters.AddWithValue("@datFecha", this.datFecha);
                cmdHistorial.Parameters.AddWithValue("@datHora", this.datHora);
                cmdHistorial.Parameters.AddWithValue("@strUbicacion", this.strUbicacion);
                cmdHistorial.Parameters.AddWithValue("@intInvitadosAprox", this.intInvitadosAprox);
                cmdHistorial.Parameters.AddWithValue("@strDescripcion", this.strDescripcion);
                await cmdHistorial.ExecuteNonQueryAsync();

                string insertarTareaEvento = "INSERT INTO tblTareaEvento (cod_evento, descripcion_tarea, cod_nivel) VALUES (@intCodEvento, @strDescripcionTarea, @intCodNivel)";
                SqlCommand cmdTareaEvento = new SqlCommand(insertarTareaEvento, conexion);

                cmdTareaEvento.Parameters.AddWithValue("@intCodEvento", ultimoCodEvento);
                cmdTareaEvento.Parameters.AddWithValue("@strDescripcionTarea", this.strDescripcionTarea);
                cmdTareaEvento.Parameters.AddWithValue("@intCodNivel", this.intCodNivel);
                await cmdTareaEvento.ExecuteNonQueryAsync();

                MessageBox.Show("Evento creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DesconectarDB();
            }
        }
    }
}
