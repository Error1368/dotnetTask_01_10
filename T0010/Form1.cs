using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T0010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int matrixSize = Convert.ToInt32(sliderSize.Value);
            int cellSize = tableInput.Height / (matrixSize + 1);
            tableInput.Columns.Clear();
            for(int i = 0; i < matrixSize; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.Frozen = true;
                column.CellTemplate = new DataGridViewTextBoxCell();
                column.HeaderCell = new TableColumnTumbler(tableInput, i);
                column.Width = cellSize;
                tableInput.Columns.Add(column);
            }

            Random randomizer = new Random();
            for (int i = 0; i < matrixSize; i++) {
                string[] values = new string[matrixSize];
                for (int j = 0; j < matrixSize; j++) {
                    string value = Convert.ToString(randomizer.Next(-5, 5));
                    values[j] = value;    
                }
                tableInput.Rows.Add(values);
                tableInput.Rows[tableInput.Rows.Count - 1].HeaderCell = new TableRowTumbler(tableInput, i);
                tableInput.Rows[tableInput.Rows.Count - 1].Height = cellSize;
            }
        }

        private void buttonProcessing_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[tableInput.RowCount, tableInput.ColumnCount];
            for (int i = 0; i < tableInput.RowCount; i++)
            {
                for (int j = 0; j < tableInput.ColumnCount; j++)
                    matrix[i, j] = Convert.ToInt32(tableInput[j, i].Value);
            }

            matrix = processMatrix(matrix);

            tableOutput.Columns.Clear();
            if (matrix.GetLength(0) > 0)
            {
                int cellWidth = tableOutput.Width / (matrix.GetLength(1) + 1);
                int cellHeight = tableOutput.Height /(matrix.GetLength(0) + 1);
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    DataGridViewColumn column = new DataGridViewColumn();
                    column.Frozen = true;
                    column.CellTemplate = new DataGridViewTextBoxCell();
                    column.Width = cellWidth;
                    tableOutput.Columns.Add(column);
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    string[] values = new string[matrix.GetLength(1)];
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        string value = Convert.ToString(matrix[i, j]);
                        values[j] = value;
                    }
                    tableOutput.Rows.Add(values);
                    tableOutput.Rows[tableOutput.Rows.Count - 1].Height = cellHeight;
                }
            }
    }

        private int[,] processMatrix(int[,] input) {
            List<int> deletedRows = new List<int>(), deletedColumns = new List<int>();
            for (int i = 0; i < input.GetLength(0); i++)
            {
                bool isNotZeroRow = false;
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i, j] != 0)
                    {
                        isNotZeroRow = true;
                        break;
                    }
                }
                if (!isNotZeroRow)
                    deletedRows.Add(i);
            }
            if (input.GetLength(0) - deletedRows.Count > 0)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    bool isNotZeroColumn = false;
                    for (int i = 0; i < input.GetLength(0); i++)
                    {
                        if (input[i, j] != 0)
                        {
                            isNotZeroColumn = true;
                            break;
                        }
                    }
                    if (!isNotZeroColumn)
                        deletedColumns.Add(j);
                }
            }

            int[,] result = new int[input.GetLength(0) - deletedRows.Count, input.GetLength(1) - deletedColumns.Count];
            int deltaI = 0;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                if (!deletedRows.Contains(i))
                {
                    int deltaJ = 0;
                    for (int j = 0; j < input.GetLength(1); j++)
                    {
                        if (!deletedColumns.Contains(j))
                        {
                            result[i - deltaI, j - deltaJ] = input[i,j];
                        }
                        else
                            deltaJ++;
                    }
                }
                else
                    deltaI++;
            }
            return result;
        }

        private partial class TableColumnTumbler : DataGridViewColumnHeaderCell
        {
            //Тумблер для зануления\заполнения рандомом конкретного столбца
            private bool zeroLine = false;
            private int index;
            private DataGridView parent;
            private static Random randomizer = new Random();

            public TableColumnTumbler(DataGridView parent, int index)
            {
                this.parent = parent;
                this.index = index;
            }
            override
            protected void OnClick(DataGridViewCellEventArgs e)
            {
                if (!this.zeroLine)
                    for (int i = 0; i < parent.RowCount; i++)
                        parent[index, i].Value = "0";
                else
                    for (int i = 0; i < parent.RowCount; i++)
                        parent[index, i].Value = Convert.ToString(randomizer.Next(-5, 5));
                this.zeroLine = !zeroLine;
            }

        }

        private partial class TableRowTumbler : DataGridViewRowHeaderCell
        {
            //Тумблер для зануления\заполнения рандомом конкретной строки
            private bool zeroLine = false;
            private int index;
            private DataGridView parent;
            private static Random randomizer = new Random();

            public TableRowTumbler(DataGridView parent, int index)
            {
                this.parent = parent;
                this.index = index;
            }
            override
            protected void OnClick(DataGridViewCellEventArgs e)
            {
                if (!this.zeroLine)
                    for (int i = 0; i < parent.ColumnCount; i++)
                        parent[i, index].Value = "0";
                else
                    for (int i = 0; i < parent.ColumnCount; i++)
                        parent[i, index].Value = Convert.ToString(randomizer.Next(-5, 5));
                this.zeroLine = !zeroLine;
            }

        }

    }
}
