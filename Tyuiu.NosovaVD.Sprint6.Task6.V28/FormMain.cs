﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.NosovaVD.Sprint6.Task6.V28.Lib;
namespace Tyuiu.NosovaVD.Sprint6.Task6.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_NVD_Click(object sender, EventArgs e)
        {
             openFileDialogTask_NVD.ShowDialog();
            openFilePath = openFileDialogTask_NVD.FileName;
            textBoxIn_NVD.Text = File.ReadAllText(openFilePath);
            groupBoxIn_NVD.Text = groupBoxIn_NVD.Text + " " + openFileDialogTask_NVD.FileName;
            buttonDone_NVD.Enabled = true;
        }

        private void buttonDone_NVD_Click(object sender, EventArgs e)
        {
            textBoxOut_NVD.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_NVD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();        
        }

    }
}
