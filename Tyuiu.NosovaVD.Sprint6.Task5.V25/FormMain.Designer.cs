﻿
namespace Tyuiu.NosovaVD.Sprint6.Task5.V25
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelRight_NVD = new System.Windows.Forms.Panel();
            this.chartNums_NVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterOne_NVD = new System.Windows.Forms.Splitter();
            this.panelLeft_NVD = new System.Windows.Forms.Panel();
            this.groupBoxOut_NVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_NVD = new System.Windows.Forms.DataGridView();
            this.panelTop_NVD = new System.Windows.Forms.Panel();
            this.groupBoxUslovie_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_NVD = new System.Windows.Forms.TextBox();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_NVD = new System.Windows.Forms.Button();
            this.buttonInfo_NVD = new System.Windows.Forms.Button();
            this.panelRight_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNums_NVD)).BeginInit();
            this.panelLeft_NVD.SuspendLayout();
            this.groupBoxOut_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_NVD)).BeginInit();
            this.panelTop_NVD.SuspendLayout();
            this.groupBoxUslovie_NVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight_NVD
            // 
            this.panelRight_NVD.Controls.Add(this.chartNums_NVD);
            this.panelRight_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NVD.Location = new System.Drawing.Point(225, 100);
            this.panelRight_NVD.Name = "panelRight_NVD";
            this.panelRight_NVD.Size = new System.Drawing.Size(627, 350);
            this.panelRight_NVD.TabIndex = 22;
            // 
            // chartNums_NVD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNums_NVD.ChartAreas.Add(chartArea1);
            this.chartNums_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartNums_NVD.Legends.Add(legend1);
            this.chartNums_NVD.Location = new System.Drawing.Point(0, 0);
            this.chartNums_NVD.Name = "chartNums_NVD";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartNums_NVD.Series.Add(series1);
            this.chartNums_NVD.Size = new System.Drawing.Size(627, 350);
            this.chartNums_NVD.TabIndex = 0;
            this.chartNums_NVD.Text = "chart1";
            // 
            // splitterOne_NVD
            // 
            this.splitterOne_NVD.Location = new System.Drawing.Point(222, 100);
            this.splitterOne_NVD.Name = "splitterOne_NVD";
            this.splitterOne_NVD.Size = new System.Drawing.Size(3, 350);
            this.splitterOne_NVD.TabIndex = 21;
            this.splitterOne_NVD.TabStop = false;
            // 
            // panelLeft_NVD
            // 
            this.panelLeft_NVD.Controls.Add(this.groupBoxOut_NVD);
            this.panelLeft_NVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NVD.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_NVD.Name = "panelLeft_NVD";
            this.panelLeft_NVD.Size = new System.Drawing.Size(222, 350);
            this.panelLeft_NVD.TabIndex = 20;
            // 
            // groupBoxOut_NVD
            // 
            this.groupBoxOut_NVD.Controls.Add(this.dataGridViewNums_NVD);
            this.groupBoxOut_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_NVD.Name = "groupBoxOut_NVD";
            this.groupBoxOut_NVD.Size = new System.Drawing.Size(222, 350);
            this.groupBoxOut_NVD.TabIndex = 9;
            this.groupBoxOut_NVD.TabStop = false;
            this.groupBoxOut_NVD.Text = "Вывод";
            // 
            // dataGridViewNums_NVD
            // 
            this.dataGridViewNums_NVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_NVD.ColumnHeadersVisible = false;
            this.dataGridViewNums_NVD.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridViewNums_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_NVD.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewNums_NVD.Name = "dataGridViewNums_NVD";
            this.dataGridViewNums_NVD.RowHeadersVisible = false;
            this.dataGridViewNums_NVD.RowHeadersWidth = 51;
            this.dataGridViewNums_NVD.RowTemplate.Height = 24;
            this.dataGridViewNums_NVD.Size = new System.Drawing.Size(216, 329);
            this.dataGridViewNums_NVD.TabIndex = 0;
            // 
            // panelTop_NVD
            // 
            this.panelTop_NVD.Controls.Add(this.groupBoxUslovie_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonDone_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonOpenFile_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonInfo_NVD);
            this.panelTop_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NVD.Name = "panelTop_NVD";
            this.panelTop_NVD.Size = new System.Drawing.Size(852, 100);
            this.panelTop_NVD.TabIndex = 19;
            // 
            // groupBoxUslovie_NVD
            // 
            this.groupBoxUslovie_NVD.Controls.Add(this.textBoxUslovie_NVD);
            this.groupBoxUslovie_NVD.Location = new System.Drawing.Point(3, 3);
            this.groupBoxUslovie_NVD.Name = "groupBoxUslovie_NVD";
            this.groupBoxUslovie_NVD.Size = new System.Drawing.Size(503, 91);
            this.groupBoxUslovie_NVD.TabIndex = 8;
            this.groupBoxUslovie_NVD.TabStop = false;
            this.groupBoxUslovie_NVD.Text = "Условие";
            // 
            // textBoxUslovie_NVD
            // 
            this.textBoxUslovie_NVD.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUslovie_NVD.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie_NVD.Multiline = true;
            this.textBoxUslovie_NVD.Name = "textBoxUslovie_NVD";
            this.textBoxUslovie_NVD.ReadOnly = true;
            this.textBoxUslovie_NVD.Size = new System.Drawing.Size(490, 61);
            this.textBoxUslovie_NVD.TabIndex = 3;
            this.textBoxUslovie_NVD.Text = "Прочитать данные из файла InPutFileTask5V25.txt. Вывести в dataGridView. Дан спис" +
    "ок из чисел. Вывести все числа, не равные 0. Построить диаграмму по этим значени" +
    "ям. ";
            // 
            // buttonDone_NVD
            // 
            this.buttonDone_NVD.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_NVD.Location = new System.Drawing.Point(525, 24);
            this.buttonDone_NVD.Name = "buttonDone_NVD";
            this.buttonDone_NVD.Size = new System.Drawing.Size(102, 61);
            this.buttonDone_NVD.TabIndex = 10;
            this.buttonDone_NVD.Text = "Выполнить";
            this.buttonDone_NVD.UseVisualStyleBackColor = false;
            this.buttonDone_NVD.Click += new System.EventHandler(this.buttonDone_NVD_Click);
            // 
            // buttonOpenFile_NVD
            // 
            this.buttonOpenFile_NVD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenFile_NVD.Location = new System.Drawing.Point(633, 24);
            this.buttonOpenFile_NVD.Name = "buttonOpenFile_NVD";
            this.buttonOpenFile_NVD.Size = new System.Drawing.Size(104, 61);
            this.buttonOpenFile_NVD.TabIndex = 13;
            this.buttonOpenFile_NVD.Text = "Открыть файл";
            this.buttonOpenFile_NVD.UseVisualStyleBackColor = false;
            this.buttonOpenFile_NVD.Click += new System.EventHandler(this.buttonOpenFile_NVD_Click);
            // 
            // buttonInfo_NVD
            // 
            this.buttonInfo_NVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_NVD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInfo_NVD.Location = new System.Drawing.Point(743, 24);
            this.buttonInfo_NVD.Name = "buttonInfo_NVD";
            this.buttonInfo_NVD.Size = new System.Drawing.Size(96, 61);
            this.buttonInfo_NVD.TabIndex = 11;
            this.buttonInfo_NVD.Text = "Справка";
            this.buttonInfo_NVD.UseVisualStyleBackColor = false;
            this.buttonInfo_NVD.Click += new System.EventHandler(this.buttonInfo_NVD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.panelRight_NVD);
            this.Controls.Add(this.splitterOne_NVD);
            this.Controls.Add(this.panelLeft_NVD);
            this.Controls.Add(this.panelTop_NVD);
            this.MinimumSize = new System.Drawing.Size(870, 497);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 25 | Носова В.Д.";
            this.panelRight_NVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartNums_NVD)).EndInit();
            this.panelLeft_NVD.ResumeLayout(false);
            this.groupBoxOut_NVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_NVD)).EndInit();
            this.panelTop_NVD.ResumeLayout(false);
            this.groupBoxUslovie_NVD.ResumeLayout(false);
            this.groupBoxUslovie_NVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight_NVD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNums_NVD;
        private System.Windows.Forms.Splitter splitterOne_NVD;
        private System.Windows.Forms.Panel panelLeft_NVD;
        private System.Windows.Forms.GroupBox groupBoxOut_NVD;
        private System.Windows.Forms.DataGridView dataGridViewNums_NVD;
        private System.Windows.Forms.Panel panelTop_NVD;
        private System.Windows.Forms.GroupBox groupBoxUslovie_NVD;
        private System.Windows.Forms.TextBox textBoxUslovie_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.Button buttonOpenFile_NVD;
        private System.Windows.Forms.Button buttonInfo_NVD;
    }
}

