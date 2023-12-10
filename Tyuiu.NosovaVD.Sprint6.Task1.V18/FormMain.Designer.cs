
namespace Tyuiu.NosovaVD.Sprint6.Task1.V18
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
            this.textBoxResult_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxOut_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxResText_NVD = new System.Windows.Forms.TextBox();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.groupBoxIn_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxStop_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStart_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_NVD = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxOut_NVD.SuspendLayout();
            this.groupBoxIn_NVD.SuspendLayout();
            this.groupBoxUslovie_NVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxResult_NVD
            // 
            this.textBoxResult_NVD.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_NVD.Location = new System.Drawing.Point(6, 55);
            this.textBoxResult_NVD.Multiline = true;
            this.textBoxResult_NVD.Name = "textBoxResult_NVD";
            this.textBoxResult_NVD.ReadOnly = true;
            this.textBoxResult_NVD.Size = new System.Drawing.Size(284, 326);
            this.textBoxResult_NVD.TabIndex = 0;
            // 
            // groupBoxOut_NVD
            // 
            this.groupBoxOut_NVD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxOut_NVD.Controls.Add(this.textBoxResText_NVD);
            this.groupBoxOut_NVD.Controls.Add(this.textBoxResult_NVD);
            this.groupBoxOut_NVD.Location = new System.Drawing.Point(492, 23);
            this.groupBoxOut_NVD.Name = "groupBoxOut_NVD";
            this.groupBoxOut_NVD.Size = new System.Drawing.Size(296, 387);
            this.groupBoxOut_NVD.TabIndex = 1;
            this.groupBoxOut_NVD.TabStop = false;
            this.groupBoxOut_NVD.Text = "Вывод данных";
            // 
            // textBoxResText_NVD
            // 
            this.textBoxResText_NVD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxResText_NVD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResText_NVD.Location = new System.Drawing.Point(6, 27);
            this.textBoxResText_NVD.Name = "textBoxResText_NVD";
            this.textBoxResText_NVD.Size = new System.Drawing.Size(83, 15);
            this.textBoxResText_NVD.TabIndex = 1;
            this.textBoxResText_NVD.Text = "Результат:";
            // 
            // buttonDone_NVD
            // 
            this.buttonDone_NVD.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_NVD.Location = new System.Drawing.Point(384, 346);
            this.buttonDone_NVD.Name = "buttonDone_NVD";
            this.buttonDone_NVD.Size = new System.Drawing.Size(102, 52);
            this.buttonDone_NVD.TabIndex = 2;
            this.buttonDone_NVD.Text = "Выполнить";
            this.buttonDone_NVD.UseVisualStyleBackColor = false;
            this.buttonDone_NVD.Click += new System.EventHandler(this.buttonDone_NVD_Click);
            // 
            // buttonHelp_NVD
            // 
            this.buttonHelp_NVD.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_NVD.Location = new System.Drawing.Point(271, 346);
            this.buttonHelp_NVD.Name = "buttonHelp_NVD";
            this.buttonHelp_NVD.Size = new System.Drawing.Size(107, 52);
            this.buttonHelp_NVD.TabIndex = 3;
            this.buttonHelp_NVD.Text = "Справка";
            this.buttonHelp_NVD.UseVisualStyleBackColor = false;
            this.buttonHelp_NVD.Click += new System.EventHandler(this.buttonHelp_NVD_Click);
            // 
            // groupBoxIn_NVD
            // 
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStop_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStart_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStopStep_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.textBoxStartStep_NVD);
            this.groupBoxIn_NVD.Location = new System.Drawing.Point(12, 325);
            this.groupBoxIn_NVD.Name = "groupBoxIn_NVD";
            this.groupBoxIn_NVD.Size = new System.Drawing.Size(253, 73);
            this.groupBoxIn_NVD.TabIndex = 4;
            this.groupBoxIn_NVD.TabStop = false;
            this.groupBoxIn_NVD.Text = "Ввод данных:";
            // 
            // textBoxStop_NVD
            // 
            this.textBoxStop_NVD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxStop_NVD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStop_NVD.Location = new System.Drawing.Point(133, 21);
            this.textBoxStop_NVD.Name = "textBoxStop_NVD";
            this.textBoxStop_NVD.Size = new System.Drawing.Size(114, 15);
            this.textBoxStop_NVD.TabIndex = 6;
            this.textBoxStop_NVD.Text = "Конец шага:";
            // 
            // textBoxStart_NVD
            // 
            this.textBoxStart_NVD.BackColor = System.Drawing.SystemColors.InactiveBorder;
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
            // groupBoxUslovie_NVD
            // 
            this.groupBoxUslovie_NVD.Controls.Add(this.textBoxUslovie_NVD);
            this.groupBoxUslovie_NVD.Location = new System.Drawing.Point(10, 23);
            this.groupBoxUslovie_NVD.Name = "groupBoxUslovie_NVD";
            this.groupBoxUslovie_NVD.Size = new System.Drawing.Size(474, 296);
            this.groupBoxUslovie_NVD.TabIndex = 5;
            this.groupBoxUslovie_NVD.TabStop = false;
            this.groupBoxUslovie_NVD.Text = "Условие";
            // 
            // textBoxUslovie_NVD
            // 
            this.textBoxUslovie_NVD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxUslovie_NVD.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie_NVD.Multiline = true;
            this.textBoxUslovie_NVD.Name = "textBoxUslovie_NVD";
            this.textBoxUslovie_NVD.ReadOnly = true;
            this.textBoxUslovie_NVD.Size = new System.Drawing.Size(348, 56);
            this.textBoxUslovie_NVD.TabIndex = 0;
            this.textBoxUslovie_NVD.Text = "Протабулировать функцию ((2.0 * Sin(x))/(3.0*x+1.2) + Cos(x) - 7.0 * x * 2.0) на " +
    "заданном диапазоне. Результат вывести в таблице.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 426);
            this.Controls.Add(this.groupBoxUslovie_NVD);
            this.Controls.Add(this.groupBoxIn_NVD);
            this.Controls.Add(this.buttonHelp_NVD);
            this.Controls.Add(this.buttonDone_NVD);
            this.Controls.Add(this.groupBoxOut_NVD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 18 | Носова В.Д.";
            this.groupBoxOut_NVD.ResumeLayout(false);
            this.groupBoxOut_NVD.PerformLayout();
            this.groupBoxIn_NVD.ResumeLayout(false);
            this.groupBoxIn_NVD.PerformLayout();
            this.groupBoxUslovie_NVD.ResumeLayout(false);
            this.groupBoxUslovie_NVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult_NVD;
        private System.Windows.Forms.GroupBox groupBoxOut_NVD;
        private System.Windows.Forms.TextBox textBoxResText_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
        private System.Windows.Forms.GroupBox groupBoxIn_NVD;
        private System.Windows.Forms.TextBox textBoxStopStep_NVD;
        private System.Windows.Forms.TextBox textBoxStartStep_NVD;
        private System.Windows.Forms.TextBox textBoxStart_NVD;
        private System.Windows.Forms.TextBox textBoxStop_NVD;
        private System.Windows.Forms.GroupBox groupBoxUslovie_NVD;
        private System.Windows.Forms.TextBox textBoxUslovie_NVD;
    }
}

