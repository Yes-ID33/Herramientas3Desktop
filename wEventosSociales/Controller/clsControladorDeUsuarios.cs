using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace wEventosSociales
{
    public class clsControladorDeUsuarios : clsConexion
    {
        //método para encriptar contraseñas
        public string EncriptarContrasena(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contrasena);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // Método para iniciar sesión
        public async Task<(bool, int, string)> IniciarSesionAsync(string correo, string contrasena)
        {
            try
            {
                // Conectar a la base de datos
                await ConectarAsync();

                // Consulta SQL para verificar usuario y contraseña
                string consulta = "SELECT cod_usuario, nombre_usuario FROM tblUsuario WHERE correo = @correo AND contrasena_encriptada = @contrasena";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@contrasena", contrasena);

                // Ejecutar la consulta
                SqlDataReader lector = await comando.ExecuteReaderAsync();

                if (lector.HasRows)
                {
                    lector.Read();
                    int codUsuario = lector.GetInt32(0);
                    string nombreUsuario = lector.GetString(1);
                    return (true, codUsuario, nombreUsuario); // Retorna que el inicio de sesión fue exitoso junto con los datos del usuario
                }

                return (false, 0, null); // Retorna falso si no se encontró el usuario
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al iniciar sesión: {ex.Message}");
                return (false, 0, null);
            }
            finally
            {
                // Desconectar de la base de datos
                DesconectarDB();
            }
        }

        // Método para registrar un nuevo usuario
        public async Task<bool> RegistrarUsuarioAsync(string nombreUsuario, string correo, string contrasena)
        {
            try
            {
                // Conectar a la base de datos
                await ConectarAsync();

                // Consulta SQL para insertar un nuevo usuario
                string consulta = "INSERT INTO tblUsuario (nombre_usuario, correo, contrasena_encriptada) VALUES (@nombre, @correo, @contrasena)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", nombreUsuario);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@contrasena", contrasena); // Considera encriptar la contraseña

                // Ejecutar la consulta y verificar si se afectó alguna fila
                int resultado = await comando.ExecuteNonQueryAsync();

                return resultado > 0; // Retorna true si se creó el usuario
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar usuario: {ex.Message}");
                return false;
            }
            finally
            {
                // Desconectar de la base de datos
                DesconectarDB();
            }
        }
    }
}