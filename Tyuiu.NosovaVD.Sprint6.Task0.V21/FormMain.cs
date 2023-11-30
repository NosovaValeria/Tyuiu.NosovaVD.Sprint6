using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosovaVD.Sprint6.Task0.V21.Lib;
namespace Tyuiu.NosovaVD.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_NVD_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_NVD.Text = ds.Calculate(Convert.ToInt32(textBoxVarX_NVD.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_NVD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_NVD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТб-23-2 Носова Валерия Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
