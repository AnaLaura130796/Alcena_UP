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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
        //se debe poner una función que muestre el inventario si es que existen modificaciones.
            buscarModificaciones();
        }

        private void buscarModificaciones()
        {
            string queryNoModificados = "SELECT¨* FROM lu_producto WHERE modificado =0";
            DataTable tablanomodificados = DataBase.runSelectQuery(queryNoModificados);
            if (tablanomodificados == null)
                return;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_consulta_Click(object sender, EventArgs e)
        {
            string query_consulta = "SELECT a.nombre, b.tipo, a.fechaEntrada FROM lu_producto a INNER JOIN tipo_alimento b ON b.id = a.id_tipo";
            FormVerInventario ventanaInvenatrio = new FormVerInventario(query_consulta);
            ventanaInvenatrio.ShowDialog();
        }
    }
}
