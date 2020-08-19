using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms00
{
    public partial class Form7 : Form
    {
        DataSet midataset;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            midataset = new DataSet();//en vez de dataset, mejor una clase con las consultas

            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["miconexion"];
            string cadena = settings.ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                string sql = "select * from Facturas";
                string sql2 = "select * from LineasFactura";

                SqlDataAdapter adaptador1 = new SqlDataAdapter(sql,conexion);
                SqlDataAdapter adaptador2 = new SqlDataAdapter(sql2,conexion);
                
                //metodo fill, para rellenar el datatable
                adaptador1.Fill(midataset,"Facturas");//le da nombre a una tabla-> le llamamos facturas
                adaptador2.Fill(midataset,"LineasFactura");//le da nombre a una tabla-> le llamamos facturas

                //vamos a utilzar un datarelation
                midataset.Relations.Add("Relacion",
                    midataset.Tables["Facturas"].Columns["NUMERO"],
                    midataset.Tables["LineasFactura"].Columns["FACTURAS_NUMERO"]);
               
                dataGridView1.DataSource = midataset;
                dataGridView2.DataSource = midataset;
                dataGridView1.DataMember = "Facturas";
                dataGridView2.DataMember = "LineasFactura";

            }
        }
    }
}
