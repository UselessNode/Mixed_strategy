using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace gChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTable();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        void LoadTable()
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount =    (int)numericUpDown2.Value;
        }

        private void bRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int rCount = dataGridView1.RowCount;
            int cCount = dataGridView1.ColumnCount;
            Text = $"gChart | {rCount} x {cCount}";
            for (int r = 0; r < rCount; r++)
            {
                for (int c = 0; c < cCount; c++)
                {
                    dataGridView1.Rows[r].Cells[c].Value = rand.Next(10);
                    //dataGridView1.Rows[r].Cells[c].Value = $"{r}:{c}";
                }
            }
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //GetResultCalc();
        }

        void GetResultCalc()
        {

            int[,] data = GetArrayFromDataGridView();
            int rowSize = data.GetUpperBound(0);
            int colSize = data.GetUpperBound(1);
            List<List<int>> cols = new List<List<int>>(colSize);
            List<List<int>> rows = new List<List<int>>(rowSize);
            List<int> maxList = new List<int>();
            List<int> minList = new List<int>();

            // 100% Работает для 2-ух строк
            //List<int> row1 = new List<int>();
            //List<int> row2 = new List<int>();

            //// 100% Работает для 2-ух строк
            //for (int i = 0; i < colSize; i++)
            //{
            //    row1.Add(data[0, i]);
            //    row2.Add(data[1, i]);
            //}

            // 100% работает для 2-ух строк
            //int minRow1 = row1.Min();
            //int minRow2 = row2.Min();
            //int minmax = Math.Max(minRow1, minRow2);
            //
            int maxmin = Maximin(data, rowSize, colSize, cols, maxList);
            int minmax = Minimax(data, rowSize, colSize, rows, minList);

            tBMaxMin.Text = (maxmin).ToString();
            tBMinMax.Text = (minmax).ToString();

            if(maxmin == minmax)
            {
                rtbOutput.Text = $"Цена игры (V): {minmax} \n";
            }

        }

        private int Minimax(int[,] data, int rowSize, int colSize, List<List<int>> rows, List<int> minList)
        {
            // Запись значений строк в массив строк
            for (int row = 0; row < rowSize + 1; row++)
            {
                List<int> temp = new List<int>();
                for (int col = 0; col < colSize + 1; col++)
                {
                    temp.Add(data[row, col]);
                }
                rows.Add(temp);
            }

            foreach (List<int> list in rows)
            {
                minList.Add(list.Min());
            }
            return minList.Max();
        }

        private int Maximin(int[,] data, int rowSize, int colSize, List<List<int>> cols, List<int> maxList)
        {
            // Запись значений столбцов в массив столбцов
            for (int col = 0; col < colSize; col++)
            {
                List<int> temp = new List<int>();
                for (int row = 0; row < rowSize + 1; row++)
                {
                    temp.Add(data[row, col]);
                }
                cols.Add(temp);
            }

            foreach (List<int> list in cols)
            {
                maxList.Add(list.Max());
            }
            return maxList.Min();
        }

        private int[,] GetArrayFromDataGridView()
        {
            int rCount = dataGridView1.RowCount;
            int cCount = dataGridView1.ColumnCount;
            int[,] data = new int[rCount, cCount];
            for (int r = 0; r < rCount; r++)
            {
                for (int c = 0; c < cCount; c++)
                {
                    //dataGridView1.Rows[r].Cells[c].Value;
                    var x = dataGridView1.Rows[r].Cells[c].Value;
                    data[r, c] = Convert.ToInt16(x);
                }
            }
            return data;
        }

        private void bExecute_Click(object sender, EventArgs e)
        {
            GetResultCalc();
        }

    }
}

