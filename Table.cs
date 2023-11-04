using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Table
    {
        public void tableAddColumn(DataGridView table, string header, int width = 200)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Width = width;
            column.HeaderText = header;

            table.Columns.Add(column);
        }

        public void tableAddRow(DataGridView table, string dataLine, int cellsCntr)
        {
            DataGridViewTextBoxCell[] cells = new DataGridViewTextBoxCell[cellsCntr];
            Creator parser = new Creator();

            for (int i = 0; i < cellsCntr; i++)
            {
                cells[i] = new DataGridViewTextBoxCell();
                cells[i].Value = parser.getField(dataLine, i);
            }

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(cells);
            table.Rows.Add(row);
        }

        public void clearAllRows(DataGridView table)
        {
            table.Rows.Clear();
        }
    }
}
