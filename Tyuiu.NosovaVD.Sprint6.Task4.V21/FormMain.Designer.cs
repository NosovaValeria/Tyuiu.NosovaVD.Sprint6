
namespace Tyuiu.NosovaVD.Sprint6.Task4.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxIn_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStart_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxOut_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxResult_NVD = new System.Windows.Forms.TextBox();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.groupBoxUslovie_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_NVD = new System.Windows.Forms.TextBox();
            this.buttonSave_NVD = new System.Windows.Forms.Button();
            this.chartFunction_NVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_NVD = new System.Windows.Forms.Panel();
            this.panelLeft_NVD = new System.Windows.Forms.Panel();
            this.splitterOne_NVD = new System.Windows.Forms.Splitter();
            this.panelRight_NVD = new System.Windows.Forms.Panel();
            this.groupBoxIn_NVD.SuspendLayout();
            this.groupBoxOut_NVD.SuspendLayout();
            this.groupBoxUslovie_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_NVD)).BeginInit();
            this.panelTop_NVD.SuspendLayout();
            this.panelLeft_NVD.SuspendLayout();
            this.panelRight_NVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIn_NVD
            // 
            this.groupBoxIn_NVD.Controls.Add(this.textBoxEnd_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStart_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStopStep_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStartStep_NVD);
            this.groupBoxIn_NVD.Location = new System.Drawing.Point(525, 3);
            this.groupBoxIn_NVD.Name = "groupBoxIn_NVD";
            this.groupBoxIn_NVD.Size = new System.Drawing.Size(265, 82);
            this.groupBoxIn_NVD.TabIndex = 12;
            this.groupBoxIn_NVD.TabStop = false;
            this.groupBoxIn_NVD.Text = "Ввод данных:";
            // 
            // textBoxEnd_NVD
            // 
            this.textBoxEnd_NVD.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEnd_NVD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnd_NVD.Location = new System.Drawing.Point(133, 21);
            this.textBoxEnd_NVD.Name = "textBoxEnd_NVD";
            this.textBoxEnd_NVD.Size = new System.Drawing.Size(114, 15);
            this.textBoxEnd_NVD.TabIndex = 6;
            this.textBoxEnd_NVD.Text = "Конец шага:";
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
            // groupBoxOut_NVD
            // 
            this.groupBoxOut_NVD.Controls.Add(this.textBoxResult_NVD);
            this.groupBoxOut_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_NVD.Name = "groupBoxOut_NVD";
            this.groupBoxOut_NVD.Size = new System.Drawing.Size(273, 350);
            this.groupBoxOut_NVD.TabIndex = 0;
            this.groupBoxOut_NVD.TabStop = false;
            this.groupBoxOut_NVD.Text = "Вывод";
            // 
            // textBoxResult_NVD
            // 
            this.textBoxResult_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_NVD.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_NVD.Multiline = true;
            this.textBoxResult_NVD.Name = "textBoxResult_NVD";
            this.textBoxResult_NVD.ReadOnly = true;
            this.textBoxResult_NVD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_NVD.Size = new System.Drawing.Size(267, 329);
            this.textBoxResult_NVD.TabIndex = 0;
            // 
            // buttonHelp_NVD
            // 
            this.buttonHelp_NVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_NVD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_NVD.Location = new System.Drawing.Point(1015, 12);
            this.buttonHelp_NVD.Name = "buttonHelp_NVD";
            this.buttonHelp_NVD.Size = new System.Drawing.Size(96, 73);
            this.buttonHelp_NVD.TabIndex = 11;
            this.buttonHelp_NVD.Text = "Справка";
            this.buttonHelp_NVD.UseVisualStyleBackColor = false;
            this.buttonHelp_NVD.Click += new System.EventHandler(this.buttonHelp_NVD_Click);
            // 
            // buttonDone_NVD
            // 
            this.buttonDone_NVD.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_NVD.Location = new System.Drawing.Point(796, 12);
            this.buttonDone_NVD.Name = "buttonDone_NVD";
            this.buttonDone_NVD.Size = new System.Drawing.Size(102, 73);
            this.buttonDone_NVD.TabIndex = 10;
            this.buttonDone_NVD.Text = "Выполнить";
            this.buttonDone_NVD.UseVisualStyleBackColor = false;
            this.buttonDone_NVD.Click += new System.EventHandler(this.buttonDone_NVD_Click);
            // 
            // groupBoxUslovie_NVD
            // 
            this.groupBoxUslovie_NVD.Controls.Add(this.textBoxUslovie_NVD);
            this.groupBoxUslovie_NVD.Location = new System.Drawing.Point(3, 3);
            this.groupBoxUslovie_NVD.Name = "groupBoxUslovie_NVD";
            this.groupBoxUslovie_NVD.Size = new System.Drawing.Size(516, 91);
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
            this.textBoxUslovie_NVD.Size = new System.Drawing.Size(504, 61);
            this.textBoxUslovie_NVD.TabIndex = 3;
            this.textBoxUslovie_NVD.Text = resources.GetString("textBoxUslovie_NVD.Text");
            // 
            // buttonSave_NVD
            // 
            this.buttonSave_NVD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_NVD.Location = new System.Drawing.Point(905, 12);
            this.buttonSave_NVD.Name = "buttonSave_NVD";
            this.buttonSave_NVD.Size = new System.Drawing.Size(104, 73);
            this.buttonSave_NVD.TabIndex = 13;
            this.buttonSave_NVD.Text = "Сохранить";
            this.buttonSave_NVD.UseVisualStyleBackColor = false;
            this.buttonSave_NVD.Click += new System.EventHandler(this.buttonSave_NVD_Click);
            // 
            // chartFunction_NVD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_NVD.ChartAreas.Add(chartArea1);
            this.chartFunction_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_NVD.Legends.Add(legend1);
            this.chartFunction_NVD.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_NVD.Name = "chartFunction_NVD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_NVD.Series.Add(series1);
            this.chartFunction_NVD.Size = new System.Drawing.Size(856, 350);
            this.chartFunction_NVD.TabIndex = 14;
            this.chartFunction_NVD.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "TitleOne_NVD";
            title1.Text = "График функции";
            this.chartFunction_NVD.Titles.Add(title1);
            // 
            // panelTop_NVD
            // 
            this.panelTop_NVD.Controls.Add(this.groupBoxUslovie_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonDone_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonSave_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonHelp_NVD);
            this.panelTop_NVD.Controls.Add(this.groupBoxIn_NVD);
            this.panelTop_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NVD.Name = "panelTop_NVD";
            this.panelTop_NVD.Size = new System.Drawing.Size(1132, 100);
            this.panelTop_NVD.TabIndex = 7;
            // 
            // panelLeft_NVD
            // 
            this.panelLeft_NVD.Controls.Add(this.groupBoxOut_NVD);
            this.panelLeft_NVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NVD.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_NVD.Name = "panelLeft_NVD";
            this.panelLeft_NVD.Size = new System.Drawing.Size(273, 350);
            this.panelLeft_NVD.TabIndex = 8;
            // 
            // splitterOne_NVD
            // 
            this.splitterOne_NVD.Location = new System.Drawing.Point(273, 100);
            this.splitterOne_NVD.Name = "splitterOne_NVD";
            this.splitterOne_NVD.Size = new System.Drawing.Size(3, 350);
            this.splitterOne_NVD.TabIndex = 17;
            this.splitterOne_NVD.TabStop = false;
            // 
            // panelRight_NVD
            // 
            this.panelRight_NVD.Controls.Add(this.chartFunction_NVD);
            this.panelRight_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NVD.Location = new System.Drawing.Point(276, 100);
            this.panelRight_NVD.Name = "panelRight_NVD";
            this.panelRight_NVD.Size = new System.Drawing.Size(856, 350);
            this.panelRight_NVD.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.panelRight_NVD);
            this.Controls.Add(this.splitterOne_NVD);
            this.Controls.Add(this.panelLeft_NVD);
            this.Controls.Add(this.panelTop_NVD);
            this.MinimumSize = new System.Drawing.Size(1150, 497);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 21 | Носова В.Д.";
            this.groupBoxIn_NVD.ResumeLayout(false);
            this.groupBoxIn_NVD.PerformLayout();
            this.groupBoxOut_NVD.ResumeLayout(false);
            this.groupBoxOut_NVD.PerformLayout();
            this.groupBoxUslovie_NVD.ResumeLayout(false);
            this.groupBoxUslovie_NVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_NVD)).EndInit();
            this.panelTop_NVD.ResumeLayout(false);
            this.panelLeft_NVD.ResumeLayout(false);
            this.panelRight_NVD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIn_NVD;
        private System.Windows.Forms.TextBox textBoxEnd_NVD;
        private System.Windows.Forms.TextBox textBoxStart_NVD;
        private System.Windows.Forms.TextBox textBoxStopStep_NVD;
        private System.Windows.Forms.TextBox textBoxStartStep_NVD;
        private System.Windows.Forms.GroupBox groupBoxOut_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.GroupBox groupBoxUslovie_NVD;
        private System.Windows.Forms.TextBox textBoxUslovie_NVD;
        private System.Windows.Forms.Button buttonSave_NVD;
        private System.Windows.Forms.TextBox textBoxResult_NVD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NVD;
        private System.Windows.Forms.Panel panelTop_NVD;
        private System.Windows.Forms.Panel panelLeft_NVD;
        private System.Windows.Forms.Splitter splitterOne_NVD;
        private System.Windows.Forms.Panel panelRight_NVD;
    }
}

