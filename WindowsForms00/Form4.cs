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
    public partial class Form4 : Form
    {
        List<Persona> listaPesonas = new List<Persona>();

        public Form4()
        {
            InitializeComponent();
        }

        //private void Form4_Load(object sender, EventArgs e)
        //{
        //    IPersonaRepository repo = new PersonaRepositoryMemoria();
        //    List <Persona> lista= repo.BuscarTodos();
        //    //fuente de datos del combo sera la lista
        //    comboBox1.DataSource = lista;
        //    comboBox1.ValueMember = "Edad";//campo que guarda y referencia al nombre
        //    comboBox1.DisplayMember = "Nombre";//campo q se muestra
        //}


        //opcion mejor
        private void Form4_Load(object sender, EventArgs e)
        {
            IPersonaRepository repo = new PersonaRepositoryMemoria();
            IList<Persona> lista = repo.BuscarTodos();
            //fuente de datos del combo sera la lista
            comboBox1.DataSource = lista;
            comboBox1.ValueMember = "Edad";//campo que guarda y referencia al nombre
            comboBox1.DisplayMember = "Nombre";//campo q se muestra
        }
    }
}
//ienumerable recorrer elementos
//icollection recorrer y añadir
//ilist recorrer, añadir y actualizar elementos