using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace proyectoAlacena
{
    class utilidades
    {
        public static void autosizeGrid(DataGridView dataGrid)
        {
            dataGrid.ForeColor = Color.Black;

            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.AllowUserToResizeColumns = true;

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid.AllowUserToAddRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ReadOnly = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;


        }
        public static void autosizeGrid(DataGridView dataGrid, int tamaño)
        {
            dataGrid.ForeColor = Color.Black;

            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.AllowUserToResizeColumns = true;

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGrid.DefaultCellStyle.Font = new Font("Segoe UI", tamaño);
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", tamaño, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", tamaño, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid.AllowUserToAddRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ReadOnly = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;


        }

        internal static void colorearModificados(DataGridView dataGrid)
        {
            for (int x = 0; x < dataGrid.Rows.Count; x++)
            {
                if (dataGrid.Rows[x].Cells["modificado"].Value == null)
                    continue;

                if ((dataGrid.Rows[x].Cells["modificado"].Value.ToString() == "1"))
                    dataGrid.Rows[x].DefaultCellStyle.BackColor = Color.Yellow;

            }
        }
    }
}
