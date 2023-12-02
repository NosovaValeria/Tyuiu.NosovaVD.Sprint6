using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosovaVD.Sprint6.Task3.V26.Lib;

namespace Tyuiu.NosovaVD.Sprint6.Task3.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]  { { 16, 19, 17, 2, 8 },
                                         { -17, 8, -17, -8, 1 },
                                         { -7, 17, -2, 1, -3},
                                         { -12, 0, -17, 15, 6},
                                         { 17, -6, -17, 18, -19 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridView_NVD.ColumnCount = columns;
            dataGridView_NVD.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView_NVD.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_NVD.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
        private void buttonDone_NVD_Click(object sender, EventArgs e)
        {
            int[,] matr = ds.Calculate(matrix);
            int rows = matr.GetUpperBound(0) + 1;
            int columns = matr.Length / rows;

            dataGridViewItog_NVD.ColumnCount = columns;
            dataGridViewItog_NVD.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewItog_NVD.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewItog_NVD.Rows[i].Cells[j].Value = Convert.ToString(matr[i, j]);
                }
            }
        }
        private void buttonHelp_NVD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-23-2 Носова В.Д.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    
    }
}
