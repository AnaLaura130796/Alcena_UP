using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace proyectoAlacena
{
    class DataBase
    {
        public static string tipoUsuario = "";
        static string[] stringConexion = System.IO.File.ReadAllLines(@"" + System.Windows.Forms.Application.StartupPath + "\\conexion.txt");
        public static MySqlConnection _conn = new MySqlConnection(stringConexion[0]);
        public static DataTable tablaEquipos;
        public static string connectionStringTablaInsercion;
        public static OleDbConnection __connExcel;
        public static MySqlDataAdapter adapt;
        public static DataTable tablaBusqueda;
        public static string userType;

        public static DataTable runSelectQuery(string query)
        {
            query = query.Replace("\n", "");
            query = query.Replace("'", "\'");

            Console.WriteLine(query);
            DataTable tablaSelect = new DataTable();
            string sql = query;

            try
            {

                var comm = new MySqlCommand(sql, DataBase._conn);
                DataBase._conn.Open();
                DataBase.adapt = new MySqlDataAdapter(comm);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(DataBase.adapt);
                DataBase.tablaBusqueda = new DataTable();
                DataBase.adapt.Fill(tablaSelect);
                DataBase._conn.Close();

                if (tablaSelect == null)
                {

                    return null;
                }
                else if (tablaSelect.Rows.Count < 1)
                {
                    return null;
                }

                return tablaSelect;

            }
            catch (Exception e)
            {
                DataBase.ManageException(e);
                Console.WriteLine(sql);
                return null;

            }
        }
        public static void ManageException(Exception e)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            MessageBox.Show(e.ToString());
            MessageBox.Show("Es posible que su conexión de red no este funcionando o que el servidor no este respondiendo en estos momentos");
        }
    }
}
