using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semicrol.Cursos.Servicios;
using Semicrol.Cursos.PersistenciaADO;
using Semicrol.Cursos.Persistencia;
using Semicrol.Cursos.Dominio;

namespace WindowsForms00
{
   
    public partial class Form12 : Form
    {
        List<Factura> lista;
       

        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            IFacturaRepository repositorio = new FacturaRepository();
            ILineaFacturaRepository repolineas = new LineaFacturaRepository();
            IServicioFacturacion servicio = new ServicioFacturas(repositorio, repolineas);


             lista = servicio.BuscarTodasFacturas();
            bindingSource1.DataSource = lista;
            dataGridView1.DataSource = bindingSource1;
           

        }

      
    }
}
