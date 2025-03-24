using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wEventosSociales
{
    public partial class FormInfoApp: Form
    {
        public FormInfoApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FormInfoEventos_Load(object sender, EventArgs e)
        {
            




        }

        private void txtInfoTareas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReservarEventos_Click(object sender, EventArgs e)
        {
            FormCrearEvento Form1 = new FormCrearEvento();
            Form1.Show();
            this.Close();
        }

        
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCrearEvento Form1 = new FormCrearEvento();
            Form1.Show();
            this.Close();
        }

     

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
