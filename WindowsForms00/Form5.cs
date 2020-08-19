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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //datagridview con clases
            //IPersonaRepository repo = new PersonaRepositoryMemoria();
            //dataGridView1.DataSource = repo.BuscarTodos();

            //datagridview con bbdd
            CargarTabla();
          
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings settings =
             ConfigurationManager.ConnectionStrings["miconexion"];
            string cadena = settings.ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                string sql = "insert into Facturas values (@Numero,@Concepto)";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@Numero", txtNumero.Text);
                comando.Parameters.AddWithValue("@Concepto",txtConcepto.Text);
                comando.ExecuteNonQuery();

            };
            CargarTabla();
        }

        private void CargarTabla() {

            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["miconexion"];
            string cadena = settings.ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                string sql = "select * from Facturas";
                SqlCommand comando = new SqlCommand(sql, conexion);
                DataTable table = new DataTable();
                SqlDataReader lector = comando.ExecuteReader();
                table.Load(lector);
                dataGridView1.DataSource = table;
            };

        }
    }
}
