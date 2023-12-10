
namespace Tyuiu.NosovaVD.Sprint6.Task2.V23
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
            this.groupBoxNameedOne_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxNaamedOne_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxNameedThree_NVD = new System.Windows.Forms.GroupBox();
            this.chartFunction_NVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_NVD = new System.Windows.Forms.DataGridView();
            this.namedX_NVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedFx_NVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNamed_NVD = new System.Windows.Forms.Label();
            this.groupBoxNameddTwo_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxNameedOne_NVD = new System.Windows.Forms.TextBox();
            this.textBoxNamedThree_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_NVD = new System.Windows.Forms.TextBox();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.groupBoxNameedOne_NVD.SuspendLayout();
            this.groupBoxNameedThree_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_NVD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_NVD)).BeginInit();
            this.groupBoxNameddTwo_NVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNameedOne_NVD
            // 
            this.groupBoxNameedOne_NVD.Controls.Add(this.textBoxNaamedOne_NVD);
            this.groupBoxNameedOne_NVD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNameedOne_NVD.Name = "groupBoxNameedOne_NVD";
            this.groupBoxNameedOne_NVD.Size = new System.Drawing.Size(493, 260);
            this.groupBoxNameedOne_NVD.TabIndex = 0;
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
            this.textBoxNaamedOne_NVD.Size = new System.Drawing.Size(482, 54);
            this.textBoxNaamedOne_NVD.TabIndex = 3;
            this.textBoxNaamedOne_NVD.Text = "Протабулировать функцию (4-2x + (2+cos(x))/(2x-2)) на заданном диапазоне. Результ" +
    "ат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxNameedThree_NVD
            // 
            this.groupBoxNameedThree_NVD.Controls.Add(this.chartFunction_NVD);
            this.groupBoxNameedThree_NVD.Controls.Add(this.dataGridViewFunction_NVD);
            this.groupBoxNameedThree_NVD.Controls.Add(this.labelNamed_NVD);
            this.groupBoxNameedThree_NVD.Location = new System.Drawing.Point(519, 12);
            this.groupBoxNameedThree_NVD.Name = "groupBoxNameedThree_NVD";
            this.groupBoxNameedThree_NVD.Size = new System.Drawing.Size(601, 379);
            this.groupBoxNameedThree_NVD.TabIndex = 2;
            this.groupBoxNameedThree_NVD.TabStop = false;
            this.groupBoxNameedThree_NVD.Text = "Вывод данных";
            // 
            // chartFunction_NVD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_NVD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_NVD.Legends.Add(legend1);
            this.chartFunction_NVD.Location = new System.Drawing.Point(174, 48);
            this.chartFunction_NVD.Name = "chartFunction_NVD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_NVD.Series.Add(series1);
            this.chartFunction_NVD.Size = new System.Drawing.Size(421, 300);
            this.chartFunction_NVD.TabIndex = 2;
            this.chartFunction_NVD.Text = "chart1";
            // 
            // dataGridViewFunction_NVD
            // 
            this.dataGridViewFunction_NVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_NVD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namedX_NVD,
            this.namedFx_NVD});
            this.dataGridViewFunction_NVD.Location = new System.Drawing.Point(6, 53);
            this.dataGridViewFunction_NVD.Name = "dataGridViewFunction_NVD";
            this.dataGridViewFunction_NVD.RowHeadersVisible = false;
            this.dataGridViewFunction_NVD.RowHeadersWidth = 51;
            this.dataGridViewFunction_NVD.RowTemplate.Height = 24;
            this.dataGridViewFunction_NVD.Size = new System.Drawing.Size(162, 295);
            this.dataGridViewFunction_NVD.TabIndex = 1;
            // 
            // namedX_NVD
            // 
            this.namedX_NVD.HeaderText = "X";
            this.namedX_NVD.MinimumWidth = 6;
            this.namedX_NVD.Name = "namedX_NVD";
            this.namedX_NVD.ReadOnly = true;
            this.namedX_NVD.Width = 50;
            // 
            // namedFx_NVD
            // 
            this.namedFx_NVD.HeaderText = "F(X)";
            this.namedFx_NVD.MinimumWidth = 6;
            this.namedFx_NVD.Name = "namedFx_NVD";
            this.namedFx_NVD.ReadOnly = true;
            this.namedFx_NVD.Width = 50;
            // 
            // labelNamed_NVD
            // 
            this.labelNamed_NVD.AutoSize = true;
            this.labelNamed_NVD.Location = new System.Drawing.Point(7, 22);
            this.labelNamed_NVD.Name = "labelNamed_NVD";
            this.labelNamed_NVD.Size = new System.Drawing.Size(76, 17);
            this.labelNamed_NVD.TabIndex = 0;
            this.labelNamed_NVD.Text = "Результат";
            // 
            // groupBoxNameddTwo_NVD
            // 
            this.groupBoxNameddTwo_NVD.Controls.Add(this.textBoxNameedOne_NVD);
            this.groupBoxNameddTwo_NVD.Controls.Add(this.textBoxNamedThree_NVD);
            this.groupBoxNameddTwo_NVD.Controls.Add(this.textBoxStopStep_NVD);
            this.groupBoxNameddTwo_NVD.Controls.Add(this.textBoxStartStep_NVD);
            this.groupBoxNameddTwo_NVD.Location = new System.Drawing.Point(12, 278);
            this.groupBoxNameddTwo_NVD.Name = "groupBoxNameddTwo_NVD";
            this.groupBoxNameddTwo_NVD.Size = new System.Drawing.Size(280, 82);
            this.groupBoxNameddTwo_NVD.TabIndex = 7;
            this.groupBoxNameddTwo_NVD.TabStop = false;
            this.groupBoxNameddTwo_NVD.Text = "Ввод данных:";
            // 
            // textBoxNameedOne_NVD
            // 
            this.textBoxNameedOne_NVD.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNameedOne_NVD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameedOne_NVD.Location = new System.Drawing.Point(133, 21);
            this.textBoxNameedOne_NVD.Name = "textBoxNameedOne_NVD";
            this.textBoxNameedOne_NVD.Size = new System.Drawing.Size(114, 15);
            this.textBoxNameedOne_NVD.TabIndex = 6;
            this.textBoxNameedOne_NVD.Text = "Конец шага:";
            // 
            // textBoxNamedThree_NVD
            // 
            this.textBoxNamedThree_NVD.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNamedThree_NVD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamedThree_NVD.Location = new System.Drawing.Point(13, 21);
            this.textBoxNamedThree_NVD.Name = "textBoxNamedThree_NVD";
            this.textBoxNamedThree_NVD.Size = new System.Drawing.Size(85, 15);
            this.textBoxNamedThree_NVD.TabIndex = 5;
            this.textBoxNamedThree_NVD.Text = "Старт шага:";
            // 
            // textBoxStopStep_NVD
            // 
            this.textBoxStopStep_NVD.Location = new System.Drawing.Point(133, 45);
            this.textBoxStopStep_NVD.Name = "textBoxStopStep_NVD";
            this.textBoxStopStep_NVD.ReadOnly = true;
            this.textBoxStopStep_NVD.Size = new System.Drawing.Size(114, 22);
            this.textBoxStopStep_NVD.TabIndex = 6;
            this.textBoxStopStep_NVD.Text = "5";
            // 
            // textBoxStartStep_NVD
            // 
            this.textBoxStartStep_NVD.Location = new System.Drawing.Point(13, 45);
            this.textBoxStartStep_NVD.Name = "textBoxStartStep_NVD";
            this.textBoxStartStep_NVD.ReadOnly = true;
            this.textBoxStartStep_NVD.Size = new System.Drawing.Size(114, 22);
            this.textBoxStartStep_NVD.TabIndex = 5;
            this.textBoxStartStep_NVD.Text = "-5";
            // 
            // buttonHelp_NVD
            // 
            this.buttonHelp_NVD.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_NVD.Location = new System.Drawing.Point(298, 308);
            this.buttonHelp_NVD.Name = "buttonHelp_NVD";
            this.buttonHelp_NVD.Size = new System.Drawing.Size(107, 52);
            this.buttonHelp_NVD.TabIndex = 6;
            this.buttonHelp_NVD.Text = "Справка";
            this.buttonHelp_NVD.UseVisualStyleBackColor = false;
            this.buttonHelp_NVD.Click += new System.EventHandler(this.buttonHelp_NVD_Click);
            // 
            // buttonDone_NVD
            // 
            this.buttonDone_NVD.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_NVD.Location = new System.Drawing.Point(411, 308);
            this.buttonDone_NVD.Name = "buttonDone_NVD";
            this.buttonDone_NVD.Size = new System.Drawing.Size(102, 52);
            this.buttonDone_NVD.TabIndex = 5;
            this.buttonDone_NVD.Text = "Выполнить";
            this.buttonDone_NVD.UseVisualStyleBackColor = false;
            this.buttonDone_NVD.Click += new System.EventHandler(this.buttonDone_NVD_Click);
            this.buttonDone_NVD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_NVD_MouseDown);
            this.buttonDone_NVD.MouseEnter += new System.EventHandler(this.buttonDone_NVD_MouseEnter);
            this.buttonDone_NVD.MouseLeave += new System.EventHandler(this.buttonDone_NVD_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 386);
            this.Controls.Add(this.groupBoxNameddTwo_NVD);
            this.Controls.Add(this.groupBoxNameedThree_NVD);
            this.Controls.Add(this.buttonHelp_NVD);
            this.Controls.Add(this.buttonDone_NVD);
            this.Controls.Add(this.groupBoxNameedOne_NVD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 23 | Носова В.Д.";
            this.groupBoxNameedOne_NVD.ResumeLayout(false);
            this.groupBoxNameedOne_NVD.PerformLayout();
            this.groupBoxNameedThree_NVD.ResumeLayout(false);
            this.groupBoxNameedThree_NVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_NVD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_NVD)).EndInit();
            this.groupBoxNameddTwo_NVD.ResumeLayout(false);
            this.groupBoxNameddTwo_NVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNameedOne_NVD;
        private System.Windows.Forms.GroupBox groupBoxNameedThree_NVD;
        private System.Windows.Forms.TextBox textBoxNaamedOne_NVD;
        private System.Windows.Forms.GroupBox groupBoxNameddTwo_NVD;
        private System.Windows.Forms.TextBox textBoxNameedOne_NVD;
        private System.Windows.Forms.TextBox textBoxNamedThree_NVD;
        private System.Windows.Forms.TextBox textBoxStopStep_NVD;
        private System.Windows.Forms.TextBox textBoxStartStep_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.DataGridView dataGridViewFunction_NVD;
        private System.Windows.Forms.Label labelNamed_NVD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedX_NVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedFx_NVD;
    }
}

