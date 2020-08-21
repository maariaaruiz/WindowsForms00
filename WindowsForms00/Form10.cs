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
    public partial class Form10 : Form
    {
        DataSet midataset;
        SqlDataAdapter adaptador1 = new SqlDataAdapter();

        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            
            midataset = new DataSet();//en vez de dataset, mejor una clase con las consultas

            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["miconexion"];
            string cadena = settings.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
        
            conexion.Open();

                string sql = "select * from Facturas";
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                //comando para insertar
                SqlCommand comandoInsertar = conexion.CreateCommand(); 
                string sqlInsertar = "insert into Facturas values (@Numero,@Concepto)";
                comandoInsertar.CommandType = CommandType.Text;
                comandoInsertar.CommandText = sqlInsertar;
                comandoInsertar.Parameters.Add("@Numero",SqlDbType.Int,10,"NUMERO");
                comandoInsertar.Parameters.Add("@Concepto",SqlDbType.VarChar,20,"CONCEPTO");
                //le indica al comando la clave primaria de la tabla para poder insertar nuevos elementos
                comandoInsertar.Parameters["@Numero"].SourceVersion = DataRowVersion.Original;

                // comando para actualizar
                SqlCommand comandoActualizar = conexion.CreateCommand();
                comandoActualizar.CommandType = CommandType.Text;
                string sqlActualizar = "update Facturas set CONCEPTO=@Concepto WHERE @Numero=NUMERO";
                comandoActualizar.CommandText = sqlActualizar;
                comandoActualizar.Parameters.Add("@Numero", SqlDbType.Int, 10);
                comandoActualizar.Parameters.Add("@Concepto", SqlDbType.VarChar, 20);
                comandoActualizar.Parameters["@Numero"].SourceVersion = DataRowVersion.Original;


            //comando para borrar-mirar
            SqlCommand comandoBorrar = conexion.CreateCommand();
            string sqlBorrar = "delete from Facturas WHERE NUMERO=@num";
            comandoBorrar.CommandType = CommandType.Text;
            comandoBorrar.CommandText = sqlBorrar;
            comandoBorrar.Parameters.Add("@num", SqlDbType.Int, 10,"NUMERO");
       

            adaptador1.SelectCommand = comando;
            adaptador1.InsertCommand = comandoInsertar;
            adaptador1.UpdateCommand = comandoActualizar;
            adaptador1.DeleteCommand = comandoBorrar;

            adaptador1.Fill(midataset, "Facturas");//le da nombre a una tabla-> le llamamos facturas
           
            //con binding puedes pasar elementos en una lista, o acceder al primero. al utlimo,...
            bindingSource1.DataSource = midataset.Tables["Facturas"];
            dataGridView1.DataSource = bindingSource1;

            //linkar datos de la lista a textbox u otros ele,emtnos
            txtNumero.DataBindings.Add("Text", bindingSource1, "Numero");
            txtConcepto.DataBindings.Add("Text", bindingSource1, "Concepto");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                adaptador1.Update(midataset,"Facturas");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(fila);

             adaptador1.Update(midataset, "Facturas");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bindingSource1.Sort = "Concepto";
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            label3.Text = bindingSource1.Position.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = "Concepto='" + txtFiltro.Text + "'";
         
        }

        private void label6_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = "";
            bindingSource1.RemoveFilter();
        }
    }
}
