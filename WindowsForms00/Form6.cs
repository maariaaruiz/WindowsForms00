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
    public partial class Form6 : Form
    {
        //en este utilizamos la bbdd prueba
        DataSet midataset;
        DataTable tabla;
        DataTable tabla2;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //ejemplo de generar data table genericamente, esta en memoria
            midataset = new DataSet();
            tabla = new DataTable("Tabla1");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellidos");

            DataRow fila = tabla.NewRow();
            fila["Nombre"] = "Pedro";
            fila["Apellidos"] = "Alvarez";
            tabla.Rows.Add(fila);
            //
            tabla2 = new DataTable("Tabla2");
            tabla2.Columns.Add("Numero");
            tabla2.Columns.Add("Concepto");

            DataRow fila2 = tabla2.NewRow();
            fila2["Numero"] = "1";
            fila2["Concepto"] = "ordenador";
            tabla2.Rows.Add(fila2);

            midataset.Tables.Add(tabla);
            midataset.Tables.Add(tabla2);
            dataGridView1.DataSource = midataset;
            dataGridView1.DataMember = "Tabla1";
            dataGridView1.DataMember = "Tabla2";
        }
    }
}
