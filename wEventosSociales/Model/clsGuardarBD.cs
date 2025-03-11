using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace wEventosSociales
{
    public class clsGuardarBD : clsConexion
    { 
            // Propiedades
            public int codUsuario { get; set; }
            public string nombreUsuario { get; set; }
            public string correo { get; set; }
            public string contrasenaEncriptada { get; set; }
            public int codEvento { get; set; }
            public string TipoEvento { get; set; }
            public DateTime datFecha { get; set; }
            public TimeSpan datHora { get; set; }
            public string strUbicacion { get; set; }
            public int intInvitadosAprox { get; set; }
            public string strDescripcion { get; set; }
            public int codNivel { get; set; }
            public string descripcionTarea { get; set; }

            // Constructor

            // Método para insertar usuario
            public async Task<bool> InsertarUsuarioAsync()
            {
                try
                {
                    await ConectarAsync();

                    string insertarUsuario = "INSERT INTO tblUsuario (nombre_usuario, correo, contrasena_encriptada) VALUES (@nombreUsuario, @correo, @contrasenaEncriptada)";
                    SqlCommand cmdUsuario = new SqlCommand(insertarUsuario, conexion);

                    cmdUsuario.Parameters.AddWithValue("@nombreUsuario", this.nombreUsuario);
                    cmdUsuario.Parameters.AddWithValue("@correo", this.correo);
                    cmdUsuario.Parameters.AddWithValue("@contrasenaEncriptada", this.contrasenaEncriptada);
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

            // Método para insertar datos del evento de manera temporal
            public bool InsertarEventoTemporal()
            {
                try
                {
                    // Aquí puedes almacenar los datos temporalmente en variables o estructuras de datos según tus necesidades.
                    // Por ejemplo, podrías usar una lista o diccionario para almacenar eventos temporalmente.
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar evento temporal: " + ex.Message);
                    return false;
                }
            }

            // Método para insertar datos del evento en la base de datos
            public async Task<bool> InsertarEventoAsync()
            {
                try
                {
                    await ConectarAsync();

                    string insertarEvento = "INSERT INTO tblEvento (fecha, hora, ubicacion, invitados_aprox, descripcion, cod_usuario) VALUES (@fecha, @hora, @ubicacion, @invitadosAprox, @descripcion, @codUsuario)";
                    SqlCommand cmdEvento = new SqlCommand(insertarEvento, conexion);

                    cmdEvento.Parameters.AddWithValue("@fecha", this.datFecha);
                    cmdEvento.Parameters.AddWithValue("@hora", this.datHora);
                    cmdEvento.Parameters.AddWithValue("@ubicacion", this.strUbicacion);
                    cmdEvento.Parameters.AddWithValue("@invitadosAprox", this.intInvitadosAprox);
                    cmdEvento.Parameters.AddWithValue("@descripcion", this.strDescripcion);
                    cmdEvento.Parameters.AddWithValue("@codUsuario", this.codUsuario);
                    await cmdEvento.ExecuteNonQueryAsync();

                    // Obtener el último código de evento insertado
                    int ultimoCodEvento = Convert.ToInt32(await new SqlCommand("SELECT SCOPE_IDENTITY()", conexion).ExecuteScalarAsync());

                    string insertarHistorial = "INSERT INTO tblHistorial (cod_evento, cod_usuario, fecha, hora, ubicacion, invitados_aprox, descripcion) VALUES (@codEvento, @codUsuario, @fecha, @hora, @ubicacion, @invitadosAprox, @descripcion)";
                    SqlCommand cmdHistorial = new SqlCommand(insertarHistorial, conexion);

                    cmdHistorial.Parameters.AddWithValue("@codEvento", ultimoCodEvento);
                    cmdHistorial.Parameters.AddWithValue("@codUsuario", this.codUsuario);
                    cmdHistorial.Parameters.AddWithValue("@fecha", this.datFecha);
                    cmdHistorial.Parameters.AddWithValue("@hora", this.datHora);
                    cmdHistorial.Parameters.AddWithValue("@ubicacion", this.strUbicacion);
                    cmdHistorial.Parameters.AddWithValue("@invitadosAprox", this.intInvitadosAprox);
                    cmdHistorial.Parameters.AddWithValue("@descripcion", this.strDescripcion);
                    await cmdHistorial.ExecuteNonQueryAsync();

                    string insertarTareaEvento = "INSERT INTO tblTareaEvento (cod_evento, descripcion_tarea, cod_nivel) VALUES (@codEvento, @descripcionTarea, @codNivel)";
                    SqlCommand cmdTareaEvento = new SqlCommand(insertarTareaEvento, conexion);

                    cmdTareaEvento.Parameters.AddWithValue("@codEvento", ultimoCodEvento);
                    cmdTareaEvento.Parameters.AddWithValue("@descripcionTarea", this.descripcionTarea);
                    cmdTareaEvento.Parameters.AddWithValue("@codNivel", this.codNivel);
                    await cmdTareaEvento.ExecuteNonQueryAsync();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar evento: " + ex.Message);
                    return false;
                }
                finally
                {
                    DesconectarDB();
                }
            }
        }
    }
