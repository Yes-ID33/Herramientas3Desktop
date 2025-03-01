using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace wEventosSociales
{
    public partial class formLogin: Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=");

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Open();
            String consulta = "select = from Usario where Usuario='" + txtUsuario.Text + "' and Contraseña='" + txtContrasenia.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            /*lector = comando.EndExecuteReader();

            if (lector.HasRows == true)
            {
                MessageBox.Show("bienvenido");
                //Form2 form2 = new Form2.show();
                this.Close();

            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecto o no tienes cuenta");
            }
            conexion.Close();
            */
        }

        private void btnIrCrearCuenta_Click(object sender, EventArgs e)
        {
            formRegister formRegister = new formRegister();
            formRegister.Show();
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
