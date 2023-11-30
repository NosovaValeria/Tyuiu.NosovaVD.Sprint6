using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosovaVD.Sprint6.Task1.V18.Lib;
namespace Tyuiu.NosovaVD.Sprint6.Task1.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_NVD_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStartStep_NVD.Text);
                int stopstep = Convert.ToInt32(textBoxStopStep_NVD.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                string str;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startstep, stopstep);
                textBoxResult_NVD.Text = "";
                textBoxResult_NVD.AppendText("+------------------------+" + Environment.NewLine);
                textBoxResult_NVD.AppendText("|    X     |     f(x)    |" + Environment.NewLine);
                textBoxResult_NVD.AppendText("+------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {                 
                    if(i == 5)
                    {
                        str = String.Format("| {0, 6:d}   |  {1,6:f2}    |", startstep, valueArray[i]);
                    }
                    else
                    {
                        str = String.Format("| {0, 6:d}   |  {1,6:f2}   |", startstep, valueArray[i]);
                    }
                    textBoxResult_NVD.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                textBoxResult_NVD.AppendText("+------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NVD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-2 Носова Валерия Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 
    }
}
