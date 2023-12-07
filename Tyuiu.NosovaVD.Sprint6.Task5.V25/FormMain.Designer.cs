
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelThree_NVD = new System.Windows.Forms.Panel();
            this.chartNums_NVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterOne_NVD = new System.Windows.Forms.Splitter();
            this.panelTwo_NVD = new System.Windows.Forms.Panel();
            this.groupBoxNameedThree_NVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_NVD = new System.Windows.Forms.DataGridView();
            this.panelOne_NVD = new System.Windows.Forms.Panel();
            this.groupBoxNameedOne_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxNaamedOne_NVD = new System.Windows.Forms.TextBox();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_NVD = new System.Windows.Forms.Button();
            this.buttonInfo_NVD = new System.Windows.Forms.Button();
            this.panelThree_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNums_NVD)).BeginInit();
            this.panelTwo_NVD.SuspendLayout();
            this.groupBoxNameedThree_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_NVD)).BeginInit();
            this.panelOne_NVD.SuspendLayout();
            this.groupBoxNameedOne_NVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelThree_NVD
            // 
            this.panelThree_NVD.Controls.Add(this.chartNums_NVD);
            this.panelThree_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThree_NVD.Location = new System.Drawing.Point(225, 100);
            this.panelThree_NVD.Name = "panelThree_NVD";
            this.panelThree_NVD.Size = new System.Drawing.Size(627, 350);
            this.panelThree_NVD.TabIndex = 22;
            // 
            // chartNums_NVD
            // 
            chartArea2.Name = "ChartArea1";
            this.chartNums_NVD.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartNums_NVD.Legends.Add(legend2);
            this.chartNums_NVD.Location = new System.Drawing.Point(6, 17);
            this.chartNums_NVD.Name = "chartNums_NVD";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartNums_NVD.Series.Add(series2);
            this.chartNums_NVD.Size = new System.Drawing.Size(608, 321);
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
            // panelTwo_NVD
            // 
            this.panelTwo_NVD.Controls.Add(this.groupBoxNameedThree_NVD);
            this.panelTwo_NVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTwo_NVD.Location = new System.Drawing.Point(0, 100);
            this.panelTwo_NVD.Name = "panelTwo_NVD";
            this.panelTwo_NVD.Size = new System.Drawing.Size(222, 350);
            this.panelTwo_NVD.TabIndex = 20;
            // 
            // groupBoxNameedThree_NVD
            // 
            this.groupBoxNameedThree_NVD.Controls.Add(this.dataGridViewNums_NVD);
            this.groupBoxNameedThree_NVD.Location = new System.Drawing.Point(3, 6);
            this.groupBoxNameedThree_NVD.Name = "groupBoxNameedThree_NVD";
            this.groupBoxNameedThree_NVD.Size = new System.Drawing.Size(207, 338);
            this.groupBoxNameedThree_NVD.TabIndex = 9;
            this.groupBoxNameedThree_NVD.TabStop = false;
            this.groupBoxNameedThree_NVD.Text = "Вывод";
            // 
            // dataGridViewNums_NVD
            // 
            this.dataGridViewNums_NVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_NVD.ColumnHeadersVisible = false;
            this.dataGridViewNums_NVD.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridViewNums_NVD.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewNums_NVD.Name = "dataGridViewNums_NVD";
            this.dataGridViewNums_NVD.RowHeadersVisible = false;
            this.dataGridViewNums_NVD.RowHeadersWidth = 51;
            this.dataGridViewNums_NVD.RowTemplate.Height = 24;
            this.dataGridViewNums_NVD.Size = new System.Drawing.Size(190, 311);
            this.dataGridViewNums_NVD.TabIndex = 0;
            // 
            // panelOne_NVD
            // 
            this.panelOne_NVD.Controls.Add(this.groupBoxNameedOne_NVD);
            this.panelOne_NVD.Controls.Add(this.buttonDone_NVD);
            this.panelOne_NVD.Controls.Add(this.buttonOpenFile_NVD);
            this.panelOne_NVD.Controls.Add(this.buttonInfo_NVD);
            this.panelOne_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelOne_NVD.Name = "panelOne_NVD";
            this.panelOne_NVD.Size = new System.Drawing.Size(852, 100);
            this.panelOne_NVD.TabIndex = 19;
            // 
            // groupBoxNameedOne_NVD
            // 
            this.groupBoxNameedOne_NVD.Controls.Add(this.textBoxNaamedOne_NVD);
            this.groupBoxNameedOne_NVD.Location = new System.Drawing.Point(3, 3);
            this.groupBoxNameedOne_NVD.Name = "groupBoxNameedOne_NVD";
            this.groupBoxNameedOne_NVD.Size = new System.Drawing.Size(503, 91);
            this.groupBoxNameedOne_NVD.TabIndex = 8;
            this.groupBoxNameedOne_NVD.TabStop = false;
            this.groupBoxNameedOne_NVD.Text = "Условие";
            // 
            // textBoxNaamedOne_NVD
            // 
            this.textBoxNaamedOne_NVD.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNaamedOne_NVD.Location = new System.Drawing.Point(6, 21);
            this.textBoxNaamedOne_NVD.Multiline = true;
            this.textBoxNaamedOne_NVD.Name = "textBoxNaamedOne_NVD";
            this.textBoxNaamedOne_NVD.ReadOnly = true;
            this.textBoxNaamedOne_NVD.Size = new System.Drawing.Size(490, 61);
            this.textBoxNaamedOne_NVD.TabIndex = 3;
            this.textBoxNaamedOne_NVD.Text = "Прочитать данные из файла InPutFileTask5V25.txt. Вывести в dataGridView. Дан спис" +
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
            this.Controls.Add(this.panelThree_NVD);
            this.Controls.Add(this.splitterOne_NVD);
            this.Controls.Add(this.panelTwo_NVD);
            this.Controls.Add(this.panelOne_NVD);
            this.MinimumSize = new System.Drawing.Size(870, 497);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 25 | Носова В.Д.";
            this.panelThree_NVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartNums_NVD)).EndInit();
            this.panelTwo_NVD.ResumeLayout(false);
            this.groupBoxNameedThree_NVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_NVD)).EndInit();
            this.panelOne_NVD.ResumeLayout(false);
            this.groupBoxNameedOne_NVD.ResumeLayout(false);
            this.groupBoxNameedOne_NVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThree_NVD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNums_NVD;
        private System.Windows.Forms.Splitter splitterOne_NVD;
        private System.Windows.Forms.Panel panelTwo_NVD;
        private System.Windows.Forms.GroupBox groupBoxNameedThree_NVD;
        private System.Windows.Forms.DataGridView dataGridViewNums_NVD;
        private System.Windows.Forms.Panel panelOne_NVD;
        private System.Windows.Forms.GroupBox groupBoxNameedOne_NVD;
        private System.Windows.Forms.TextBox textBoxNaamedOne_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.Button buttonOpenFile_NVD;
        private System.Windows.Forms.Button buttonInfo_NVD;
    }
}

