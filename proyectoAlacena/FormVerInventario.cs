using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoAlacena
{
    public partial class FormVerInventario : Form
    {
        private string query_consulta="";
        public BindingSource bindingInicial = new BindingSource();
        public DataTable tablaInicial = new DataTable(); 

        public FormVerInventario(string query_consulta)
        {
            // TODO: Complete member initialization
            this.query_consulta = query_consulta;
            InitializeComponent();
            llenarProductos();
            //llenarAlmacenes();
            actualizarDataGridView();      
        }

        private void actualizarDataGridView()
        {
            DataTable tablaInventario = DataBase.runSelectQuery(query_consulta);
            if (tablaInventario != null)
            {
                dataGridViewInventario.DataSource = tablaInventario;
                utilidades.autosizeGrid(dataGridViewInventario, 7);
                guardarbindingInicial();
                //Quitamos las columnas de configuración. 
                dataGridViewInventario.Columns["modificado"].Visible = false;
                dataGridViewInventario.Columns["id_tipo"].Visible = false;
            }
        }
        private void guardarbindingInicial()
        {
            DataTable temporal = (DataTable)dataGridViewInventario.DataSource;
            tablaInicial = temporal;
            bindingInicial.DataSource = temporal.Copy();
        }

        private void llenarProductos()
        {
            string queryProductos = "Select nombre from lu_producto group by nombre";
            DataTable producto = DataBase.runSelectQuery(queryProductos);
        }

        private void FormVerInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
