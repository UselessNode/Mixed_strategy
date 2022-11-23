using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gChart
{
    public partial class Form1 : Form
    {
        Double[,] data;
        List<List<Double>> listRows;
        List<List<Double>> listCols;
        Bitmap bitmap;
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


        void GetResultCalc()
        {
            rtbOutput.Clear();
            data = GetArrayFromDataGridView(true);

            int rowSize = data.GetUpperBound(0);
            int colSize = data.GetUpperBound(1);
            listRows = new List<List<Double>>(colSize);
            listCols = new List<List<Double>>(rowSize);
            List<Double> maxList = new List<Double>();
            List<Double> minList = new List<Double>();

            Double maxmin = Maximin(data, rowSize, colSize, listRows, maxList);
            Double minmax = Minimax(data, rowSize, colSize, listCols, minList);

            tBMinMax.Text = (minmax).ToString();
            tBMaxMin.Text = (maxmin).ToString();
            DrawGraph();
            if (minmax == maxmin)
            {
                rtbOutput.Text += $"Цена игры (V): {minmax} \n";
                return;
            }
            rtbOutput.Text += $"Задача является смешанной \n";
            double a = Math.Abs(data[1,0] - data[0,0]);
            double d = Math.Abs(data[1,1] - data[0,1]);
            double b = 1;
            double e = 1;
            double c = data[0,0];
            double f = data[0,1];

            double x = 0;
            double y = 0;
            SolveSLE(a,b,c,d,e,f,out x, out y);
            rtbOutput.Text += $"{a}*x+{b}*y={c}\n{d}*x+{e}*y={f}\nx = {x}\ty = {y}\nЦена игры (V) = {y}\n";
            rtbOutput.Text += $"\nОптимальные решения:\nX:({x};{1 - x})\nY:({y};{1 - y})";
        }

        private Double Maximin(Double[,] data, int rowSize, int colSize, List<List<Double>> rows, List<Double> minList)
        {
            // Запись значений строк в массив строк
            for (int row = 0; row < rowSize + 1; row++)
            {
                List<Double> temp = new List<Double>();
                for (int col = 0; col < colSize + 1; col++)
                {
                    temp.Add(data[row, col]);
                }
                rows.Add(temp);
            }

            foreach (List<Double> list in rows)
            {
                minList.Add(list.Min());
            }
            return minList.Max();
        }

        private Double Minimax(Double[,] data, int rowSize, int colSize, List<List<Double>> cols, List<Double> maxList)
        {
            // Запись значений столбцов в массив столбцов
            for (int col = 0; col < colSize + 1; col++)
            {
                List<Double> temp = new List<Double>();
                for (int row = 0; row < rowSize + 1; row++)
                {
                    temp.Add(data[row, col]);
                }
                cols.Add(temp);
            }

            foreach (List<Double> list in cols)
            {
                maxList.Add(list.Max());
            }
            return maxList.Min();
        }

        private Double[,] GetArrayFromDataGridView(Boolean isDouble)
        {
            int rCount = dataGridView1.RowCount;
            int cCount = dataGridView1.ColumnCount;
            Double[,] data = new double[rCount, cCount];
            for (int r = 0; r < rCount; r++)
            {
                for (int c = 0; c < cCount; c++)
                {
                    //dataGridView1.Rows[r].Cells[c].Value;
                    var x = dataGridView1.Rows[r].Cells[c].Value;
                    data[r, c] = Convert.ToDouble(x);
                }
            }
            return data;
        }

        private void bExecute_Click(object sender, EventArgs e)
        {
            GetResultCalc();
        }

        void SolveSLE(double a, double b, double c, double d, double e, double f, out double x, out double y)
        {
            x = GetDeterminant(c, b, f, e) / GetDeterminant(a, b, d, e);
            y = GetDeterminant(a, c, d, f) / GetDeterminant(a, b, d, e);
        }

        static double GetDeterminant(double x1, double y1, double x2, double y2)
        {
            return x1 * y2 - y1 * x2;
        }

        private void fillTableRandomMenuButton_Click(object sender, EventArgs e)
        {
            FillRandom();
            GetResultCalc();
        }

        private void FillRandom()
        {
            Random rand = new Random();
            int rCount = dataGridView1.RowCount;
            int cCount = dataGridView1.ColumnCount;
            for (int r = 0; r < rCount; r++)
            {
                for (int c = 0; c < cCount; c++)
                {
                    dataGridView1.Rows[r].Cells[c].Value = rand.Next(10);
                }
            }
        }

        private void clearTableMenuButton_Click(object sender, EventArgs e)
        {
            int rCount = dataGridView1.RowCount;
            int cCount = dataGridView1.ColumnCount;
            for (int r = 0; r < rCount; r++)
            {
                for (int c = 0; c < cCount; c++)
                {
                    dataGridView1.Rows[r].Cells[c].Value = null;
                }
            }
        }

        private void DrawGraph()
        {
            bitmap = new Bitmap(300, 300);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            Pen boldPen = new Pen(new SolidBrush(Color.Black), 4);
            boldPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            Pen lightPen = new Pen(new SolidBrush(Color.Crimson), 2);
            lightPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            List<Point> points0 = new List<Point>();
            List<Point> points1 = new List<Point>();

            for (int i = 0; i <= 300; i += 30)
            {
                points0.Add(new Point(0, i));
                points1.Add(new Point(300, i));
            }
            points0.Reverse(); points1.Reverse();

            g.DrawLine(boldPen, points0[10], points0[0]);
            g.DrawLine(boldPen, points0[0], points1[0]);
            g.DrawLine(boldPen, points1[0], points1[10]);

            foreach (var list in listCols)
                g.DrawLine(lightPen, points0[(int)list[0]], points1[(int)list[1]]);

            for (int i = 0; i <= 300; i += 30)
            {
                g.DrawLine(boldPen, 0, i, 5, i);
                g.DrawLine(boldPen, 300, i, 295, i);
            }
            pictureBox1.Image = bitmap;
        }

        private void SaveGraphicMenuButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            bitmap.Save(filename,ImageFormat.Jpeg);
            MessageBox.Show("Диаграмма сохранена!","Сохранение",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void fillRandomMenuButton_Click(object sender, EventArgs e)
        {
            FillRandom();
        }
    }
}

