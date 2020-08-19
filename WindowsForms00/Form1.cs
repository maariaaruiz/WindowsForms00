using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario cargado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola desde windows forms");
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNombre.Text+" "+txtApellidos.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double suma;
            suma = Convert.ToInt32(txtNota1.Text) + Convert.ToInt32(txtNota2.Text)+Convert.ToInt32(txtNota3.Text);
            MessageBox.Show("La suma de las notas es "+suma);
        }
    }
}
