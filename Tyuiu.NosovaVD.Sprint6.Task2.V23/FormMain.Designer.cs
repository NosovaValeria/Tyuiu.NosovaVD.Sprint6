
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxOut_NVD = new System.Windows.Forms.GroupBox();
            this.chartFunction_NVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_NVD = new System.Windows.Forms.DataGridView();
            this.namedX_NVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedFx_NVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResultat_NVD = new System.Windows.Forms.Label();
            this.groupBoxIn_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxStop_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStart_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_NVD = new System.Windows.Forms.TextBox();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.groupBoxUslovie_NVD.SuspendLayout();
            this.groupBoxOut_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_NVD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_NVD)).BeginInit();
            this.groupBoxIn_NVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_NVD
            // 
            this.groupBoxUslovie_NVD.Controls.Add(this.textBoxUslovie_NVD);
            this.groupBoxUslovie_NVD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_NVD.Name = "groupBoxUslovie_NVD";
            this.groupBoxUslovie_NVD.Size = new System.Drawing.Size(493, 260);
            this.groupBoxUslovie_NVD.TabIndex = 0;
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
            this.textBoxUslovie_NVD.Size = new System.Drawing.Size(482, 54);
            this.textBoxUslovie_NVD.TabIndex = 3;
            this.textBoxUslovie_NVD.Text = "Протабулировать функцию (4-2x + (2+cos(x))/(2x-2)) на заданном диапазоне. Результ" +
    "ат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxOut_NVD
            // 
            this.groupBoxOut_NVD.Controls.Add(this.chartFunction_NVD);
            this.groupBoxOut_NVD.Controls.Add(this.dataGridViewFunction_NVD);
            this.groupBoxOut_NVD.Controls.Add(this.labelResultat_NVD);
            this.groupBoxOut_NVD.Location = new System.Drawing.Point(519, 12);
            this.groupBoxOut_NVD.Name = "groupBoxOut_NVD";
            this.groupBoxOut_NVD.Size = new System.Drawing.Size(601, 379);
            this.groupBoxOut_NVD.TabIndex = 2;
            this.groupBoxOut_NVD.TabStop = false;
            this.groupBoxOut_NVD.Text = "Вывод данных";
            // 
            // chartFunction_NVD
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_NVD.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_NVD.Legends.Add(legend2);
            this.chartFunction_NVD.Location = new System.Drawing.Point(174, 48);
            this.chartFunction_NVD.Name = "chartFunction_NVD";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_NVD.Series.Add(series2);
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
            // labelResultat_NVD
            // 
            this.labelResultat_NVD.AutoSize = true;
            this.labelResultat_NVD.Location = new System.Drawing.Point(7, 22);
            this.labelResultat_NVD.Name = "labelResultat_NVD";
            this.labelResultat_NVD.Size = new System.Drawing.Size(76, 17);
            this.labelResultat_NVD.TabIndex = 0;
            this.labelResultat_NVD.Text = "Результат";
            // 
            // groupBoxIn_NVD
            // 
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStop_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStart_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStopStep_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStartStep_NVD);
            this.groupBoxIn_NVD.Location = new System.Drawing.Point(12, 278);
            this.groupBoxIn_NVD.Name = "groupBoxIn_NVD";
            this.groupBoxIn_NVD.Size = new System.Drawing.Size(280, 82);
            this.groupBoxIn_NVD.TabIndex = 7;
            this.groupBoxIn_NVD.TabStop = false;
            this.groupBoxIn_NVD.Text = "Ввод данных:";
            // 
            // textBoxStop_NVD
            // 
            this.textBoxStop_NVD.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStop_NVD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStop_NVD.Location = new System.Drawing.Point(133, 21);
            this.textBoxStop_NVD.Name = "textBoxStop_NVD";
            this.textBoxStop_NVD.Size = new System.Drawing.Size(114, 15);
            this.textBoxStop_NVD.TabIndex = 6;
            this.textBoxStop_NVD.Text = "Конец шага:";
            // 
            // textBoxStart_NVD
            // 
            this.textBoxStart_NVD.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStart_NVD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart_NVD.Location = new System.Drawing.Point(13, 21);
            this.textBoxStart_NVD.Name = "textBoxStart_NVD";
            this.textBoxStart_NVD.Size = new System.Drawing.Size(85, 15);
            this.textBoxStart_NVD.TabIndex = 5;
            this.textBoxStart_NVD.Text = "Старт шага:";
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
            this.Controls.Add(this.groupBoxIn_NVD);
            this.Controls.Add(this.groupBoxOut_NVD);
            this.Controls.Add(this.buttonHelp_NVD);
            this.Controls.Add(this.buttonDone_NVD);
            this.Controls.Add(this.groupBoxUslovie_NVD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 23 | Носова В.Д.";
            this.groupBoxUslovie_NVD.ResumeLayout(false);
            this.groupBoxUslovie_NVD.PerformLayout();
            this.groupBoxOut_NVD.ResumeLayout(false);
            this.groupBoxOut_NVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_NVD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_NVD)).EndInit();
            this.groupBoxIn_NVD.ResumeLayout(false);
            this.groupBoxIn_NVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_NVD;
        private System.Windows.Forms.GroupBox groupBoxOut_NVD;
        private System.Windows.Forms.TextBox textBoxUslovie_NVD;
        private System.Windows.Forms.GroupBox groupBoxIn_NVD;
        private System.Windows.Forms.TextBox textBoxStop_NVD;
        private System.Windows.Forms.TextBox textBoxStart_NVD;
        private System.Windows.Forms.TextBox textBoxStopStep_NVD;
        private System.Windows.Forms.TextBox textBoxStartStep_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.DataGridView dataGridViewFunction_NVD;
        private System.Windows.Forms.Label labelResultat_NVD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedX_NVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedFx_NVD;
    }
}

