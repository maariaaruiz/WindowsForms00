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
    public partial class Form11 : Form
    {
        DataSet midataset;
        SqlDataAdapter adaptador1 = new SqlDataAdapter();
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

            midataset = new DataSet();//en vez de dataset, mejor una clase con las consultas

            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["miconexion2"];
            string cadena = settings.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
            //  using (SqlConnection conexion = new SqlConnection(cadena))
            // {
            //otra forma de realizar el proceso de conexion
            //configurando el adaptador
            conexion.Open();

            string sql = "select * from Personas";
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandText = sql;
            comando.CommandType = CommandType.Text;

            //comando para insertar
            SqlCommand comandoInsertar = conexion.CreateCommand();
            string sqlInsertar = "insert into Personas values (@DNI,@Nombre,@Apellidos)";
            comandoInsertar.CommandType = CommandType.Text;
            comandoInsertar.CommandText = sqlInsertar;
            comandoInsertar.Parameters.Add("@DNI", SqlDbType.VarChar, 10, "DNI");
            comandoInsertar.Parameters.Add("@Nombre", SqlDbType.VarChar, 20, "NOMBRE");
            comandoInsertar.Parameters.Add("@Apellidos", SqlDbType.VarChar, 20, "APELLIDOS");
            //le indica al comando la clave primaria de la tabla para poder insertar nuevos elementos
            comandoInsertar.Parameters["@DNI"].SourceVersion = DataRowVersion.Original;

            // comando para actualizar
            SqlCommand comandoActualizar = conexion.CreateCommand();
            comandoActualizar.CommandType = CommandType.Text;
            string sqlActualizar = "update Personas set NOMBRE=@Nombre and APELLIDOS=@Apeliidos WHERE @DNI=DNI";
            comandoActualizar.CommandText = sqlActualizar;
            comandoActualizar.Parameters.Add("@DNI", SqlDbType.VarChar, 10, "DNI");
            comandoActualizar.Parameters.Add("@Nombre", SqlDbType.VarChar, 20, "NOMBRE");
            comandoActualizar.Parameters.Add("@Apellidos", SqlDbType.VarChar, 20, "APELLIDOS");
            comandoActualizar.Parameters["@DNI"].SourceVersion = DataRowVersion.Original;

            //comando para borrar
            SqlCommand comandoBorrar = conexion.CreateCommand();
            string sqlBorrar = "delete from Personas WHERE DNI=@DNI";
            comandoBorrar.CommandType = CommandType.Text;
            comandoBorrar.CommandText = sqlBorrar;
            comandoBorrar.Parameters.Add("@DNI", SqlDbType.VarChar, 10, "DNI");


            adaptador1.SelectCommand = comando;
            adaptador1.InsertCommand = comandoInsertar;
            adaptador1.UpdateCommand = comandoActualizar;
           adaptador1.DeleteCommand = comandoBorrar;

            adaptador1.Fill(midataset, "Personas");
            dataGridView1.DataSource = midataset;
          dataGridView1.DataMember = "Personas";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador1.Update(midataset, "Personas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(fila);

            adaptador1.Update(midataset, "Personas");
        }
    }
}
