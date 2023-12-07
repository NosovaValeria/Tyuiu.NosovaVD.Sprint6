using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.NosovaVD.Sprint6.Task7.V29.Lib;

namespace Tyuiu.NosovaVD.Sprint6.Task7.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_NVD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_NVD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static string openFilePath;
        static int rows;
        static int colums;
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }


        DataService ds = new DataService();
        private void buttonOpenFile_NVD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NVD.ShowDialog();
            openFilePath = openFileDialogTask_NVD.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_NVD.ColumnCount = colums;
            dataGridViewInMatrix_NVD.RowCount = rows;
            dataGridViewOutMatrix_NVD.ColumnCount = colums;
            dataGridViewOutMatrix_NVD.RowCount = rows;

            for(int i = 0; i< colums; i++)
            {
                dataGridViewInMatrix_NVD.Columns[i].Width = 25;
                dataGridViewOutMatrix_NVD.Columns[i].Width = 25;
            }

            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < colums; c++)
                {
                    dataGridViewInMatrix_NVD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_NVD.Enabled = true;
        }

        private void buttonDone_NVD_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutMatrix_NVD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_NVD.Enabled = true;
        }

        private void buttonHelp_NVD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSaveFile_NVD_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_NVD.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_NVD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_NVD.ShowDialog();

            string path = saveFileDialogMatrix_NVD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_NVD.RowCount;
            int columns = dataGridViewOutMatrix_NVD.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_NVD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_NVD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_NVD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NVD.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_NVD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NVD.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_NVD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NVD.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_NVD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NVD.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix_NVD.ColumnCount = 50;
            dataGridViewOutMatrix_NVD.ColumnCount = 50;

            dataGridViewInMatrix_NVD.RowCount = 50;
            dataGridViewOutMatrix_NVD.RowCount = 50;

            for(int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_NVD.Columns[i].Width = 25;
                dataGridViewOutMatrix_NVD.Columns[i].Width = 25;
            }
        }

    }
}
