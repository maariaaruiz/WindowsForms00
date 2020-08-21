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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //con strone dataset

            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["miconexion"];
            string cadena = settings.ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
              //  QueriesTableAdapter q = new QueriesTableAdapter();
                string sql = "select * from Facturas";
                string sql2 = "select * from LineasFactura";

                SqlDataAdapter adaptador1 = new SqlDataAdapter(sql, conexion);
                SqlDataAdapter adaptador2 = new SqlDataAdapter(sql2, conexion);

                ////metodo fill, para rellenar el datatable
                adaptador1.Fill(dataSet11, "Facturas");//le da nombre a una tabla-> le llamamos facturas
                adaptador2.Fill(dataSet11, "LineasFactura");//le da nombre a una tabla-> le llamamos facturas

                //      QueriesTableAdapter q = new QueriesTableAdapter();
                //q.GetFacturas();


                dataGridView1.DataSource = dataSet11;
                dataGridView2.DataSource = dataSet11;

                dataGridView1.DataMember = "Facturas";
                  dataGridView2.DataMember = "LineasFactura";
              
            }
        }
    }
}
