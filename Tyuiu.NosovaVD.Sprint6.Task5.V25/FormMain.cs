using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosovaVD.Sprint6.Task5.V25.Lib;
namespace Tyuiu.NosovaVD.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V25.txt";
        private void buttonDone_NVD_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNums_NVD.ColumnCount = 2;
                dataGridViewNums_NVD.Columns[0].Width = 20;
                dataGridViewNums_NVD.Columns[1].Width = 50;

                this.chartNums_NVD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartNums_NVD.ChartAreas[0].AxisY.Title = "Ось Y";

                chartNums_NVD.Series[0].Points.Clear();
                dataGridViewNums_NVD.Rows.Clear();
                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewNums_NVD.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartNums_NVD.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_NVD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_NVD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-2 Носова Валерия Дмитриевна", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
