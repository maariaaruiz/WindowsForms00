using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Insuficiente");
            comboBox1.Items.Add("Suficiente");
            comboBox1.Items.Add("Bien");
            comboBox1.Items.Add("Notable");
            comboBox1.Items.Add("Sobresaliente");

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");

            listBox1.Items.Add("Matematicas");
            listBox1.Items.Add("Lengua");
            listBox1.Items.Add("Quimica");
            listBox1.Items.Add("Fisica");
            listBox1.Items.Add("Historia");

        }


        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            MessageBox.Show(combo.SelectedItem.ToString());
        }

        /*
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListControl list = sender as ListControl;
            MessageBox.Show(list.Text);
        }*/

        private void btnMarcados_Click(object sender, EventArgs e)
        {
            IList lista = listBox1.SelectedItems;
            string textoTotal = "";
            foreach (string texto in lista)
            {
                textoTotal += texto + " ";
            }
            MessageBox.Show("Seleccionados: "+textoTotal);
        }
    }
}
