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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //un metodo para hacer lo mismo pero con != radiobutton
        //o 3 metodos cada uno con su rb
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            lblRadios.Text = radio.Text;
        }

        private void btnSeleccionado_Click(object sender, EventArgs e)
        {
            if (rbAzul.Checked)
            {
                MessageBox.Show("Seleccionado: " + rbAzul.Text);
            }else if (rbRojo.Checked)
            {
                MessageBox.Show("Seleccionado: " + rbRojo.Text);
            }
            else
            {
                MessageBox.Show("Seleccionado: " + rbVerde.Text);
            }
        }



        private void rbCalificacion_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            lblCalificacion.Text = radio.Text;
        }

        private void rbDatos_CheckedChanged(object sender, EventArgs e)
        {
            lblNombre.Visible = true;
            lblApellidos.Visible = true;
            txtNombre.Visible = true;
            txtApellidos.Visible = true;

            if (rbBasico.Checked)
            {
                lblEdad.Visible = false;
                lblTelefono.Visible = false;
                txtEdad.Visible = false;
                txtTelefono.Visible = false;
            }
            else
            {
                lblEdad.Visible = true;
                lblTelefono.Visible = true;
                txtEdad.Visible = true;
                txtTelefono.Visible = true;
            }

        
    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEsInformatico.Checked)
            {
                MessageBox.Show("La caja esta checkeada");
            }
            else
            {
                MessageBox.Show("La caja no esta checkeada");
            }
        }


        //private void rbRojo_CheckedChanged(object sender, EventArgs e)
        //{
        //    lblRadios.Text = rbRojo.Text;
        //}

        //private void rbAzul_CheckedChanged(object sender, EventArgs e)
        //{
        //    lblRadios.Text = rbAzul.Text;
        //}
    }
}
