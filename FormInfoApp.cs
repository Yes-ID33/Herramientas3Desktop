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
            FormInfoApp Form1 = new FormInfoApp();
            Form1.Show();
            this.Close();
        }
    }
}
