using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private Double[,] data;
        private List<List<Double>> listRows;
        private List<List<Double>> listCols;
        private Bitmap bitmap;
        private double p1;
        private double p2;
        private double q1;
        private double q2;
        private double y;
        public Form1()
        {
            InitializeComponent();
            LoadTable();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) => LoadTable();

        private void LoadTable()
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 2;
        }


        private void GetResultCalc()
        {
            rtbOutput.Clear();
            data = GetArrayFromDataGridView(true);

            int rowSize = data.GetUpperBound(0);
            int colSize = data.GetUpperBound(1);
            listRows = new List<List<Double>>(colSize);
            listCols = new List<List<Double>>(rowSize);
            List<Double> maxList = new List<Double>();
            List<Double> minList = new List<Double>();


            // Запись значений строк в список строк
            for (int row = 0; row < rowSize + 1; row++)
            {
                List<Double> temp = new List<Double>(rowSize);
                for (int col = 0; col < colSize + 1; col++)
                {
                    temp.Add(data[row, col]);
                }
                listRows.Add(temp);
            }

            // Запись значений столбцов в список столбцов
            for (int col = 0; col < colSize + 1; col++)
            {
                List<Double> temp = new List<Double>();
                for (int row = 0; row < rowSize + 1; row++)
                {
                    temp.Add(data[row, col]);
                }
                listCols.Add(temp);
            }

            foreach (List<Double> list in listRows)
                minList.Add(list.Min());
            

            foreach (List<Double> list in listCols)
                maxList.Add(list.Max());

            Double maxmin = minList.Max();
            Double minmax = maxList.Min();

            tBMinMax.Text = (minmax).ToString();
            tBMaxMin.Text = (maxmin).ToString();
            if (minmax == maxmin)
            {
                rtbOutput.Text += $"Цена игры (V): {minmax} \n";
                return;
            }
            rtbOutput.Text += $"Задача является смешанной \n";

            p1 = (data[1, 1] - data[1, 0]) / (data[0, 0] + data[1, 1] - data[1, 0] - data[0, 1]);
            p2 = (data[0, 0] - data[0, 1]) / (data[0, 0] + data[1, 1] - data[1, 0] - data[0, 1]);
            q1 = (data[1, 1] - data[0, 1]) / (data[0, 0] + data[1, 1] - data[1, 0] - data[0, 1]);
            q2 = (data[0, 0] - data[1, 0]) / (data[0, 0] + data[1, 1] - data[1, 0] - data[0, 1]);
            y = (data[0,0] * data[1,1] - data[0, 1] * data[1, 0]) / (data[0, 0] + data[1, 1] - data[1, 0] - data[0, 1]);

            rtbOutput.Text += $"\nЦена игры (V) = {y.ToString("0.00")}";
            rtbOutput.Text += $"\nq1 = {q1.ToString("0.00")}";
            rtbOutput.Text += $"\nq2 = {q2.ToString("0.00")}";
            rtbOutput.Text += $"\np1 = {p1.ToString("0.00")}";
            rtbOutput.Text += $"\np2 = {p2.ToString("0.00")}";
        }
        
        private Double[,] GetArrayFromDataGridView(Boolean isDouble)
        {
            int rCount = dataGridView1.RowCount;
            int cCount = dataGridView1.ColumnCount;
            Double[,] data = new double[rCount, cCount];
            for (int r = 0; r < rCount; r++)
                for (int c = 0; c < cCount; c++)
                {
                    var x = dataGridView1.Rows[r].Cells[c].Value;
                    data[r, c] = Convert.ToDouble(x);
                }
            return data;
        }

        private void bExecute_Click(object sender, EventArgs e) => GetResultCalc();

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
            g.RenderingOrigin = new Point(300, 300);
            Pen boldPen = new Pen(new SolidBrush(Color.Black), 4);
            boldPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            Pen lightPen = new Pen(new SolidBrush(Color.Crimson), 2);
            lightPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            g.DrawLine(boldPen, 0, 0, 0, 300);
            g.DrawLine(boldPen, 300, 300, 300,0);

            for (int i = 0; i <= 300; i+=30)
            {
                g.DrawLine(boldPen,
                    0, i,
                    15, i);
                g.DrawLine(boldPen,
                    300, i,
                    285, i);
            }

            foreach (var list in listCols)
                g.DrawLine(lightPen, 
                    0, 300 - (float)list[0] * 30, 
                    300, 300 - (float)list[1]* 30);
            if(p2 != 0)
            {
                g.DrawString($"V = {y.ToString("0.00")}", new Font("Times New Roman", 8), new SolidBrush(Color.Black), 
                    ((float)p2 * 300) + 30,
                    300 - ((float)y * 30f));
                g.DrawLine(new Pen(Color.Blue), 
                    (float)p2 * 300, 300, 
                    (float)p2 * 300, 300 - (float)y * 30f);
                g.DrawString($"p2 = {p2.ToString("0.00")}", new Font("Times New Roman", 8), new SolidBrush(Color.Black), 
                    40,
                    285);
                g.DrawLine(new Pen(Color.CadetBlue), 
                    0, 285, 
                    (float)p2 * 300, 285);
                g.DrawString($"p1 = {p1.ToString("0.00")}", new Font("Times New Roman", 8), new SolidBrush(Color.Black), 
                    240,
                    285);
                g.DrawLine(new Pen(Color.CadetBlue), 
                    300, 285, 
                    (float)p2 * 300, 285);
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

        private void fillRandomMenuButton_Click(object sender, EventArgs e) => FillRandom();

        private void DrawGraphMenuButton_Click(object sender, EventArgs e) => DrawGraph();
    }
}

