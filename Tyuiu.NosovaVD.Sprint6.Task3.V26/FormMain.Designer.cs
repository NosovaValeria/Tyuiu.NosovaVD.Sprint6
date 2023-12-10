
namespace Tyuiu.NosovaVD.Sprint6.Task3.V26
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
            this.groupBoxIn_NVD = new System.Windows.Forms.GroupBox();
            this.dataGridView_NVD = new System.Windows.Forms.DataGridView();
            this.labelUslovie_NVD = new System.Windows.Forms.Label();
            this.groupBoxOut_NVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewItog_NVD = new System.Windows.Forms.DataGridView();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.groupBoxIn_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NVD)).BeginInit();
            this.groupBoxOut_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItog_NVD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIn_NVD
            // 
            this.groupBoxIn_NVD.Controls.Add(this.dataGridView_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.labelUslovie_NVD);
            this.groupBoxIn_NVD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIn_NVD.Name = "groupBoxIn_NVD";
            this.groupBoxIn_NVD.Size = new System.Drawing.Size(566, 426);
            this.groupBoxIn_NVD.TabIndex = 0;
            this.groupBoxIn_NVD.TabStop = false;
            this.groupBoxIn_NVD.Text = "Условие";
            // 
            // dataGridView_NVD
            // 
            this.dataGridView_NVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NVD.ColumnHeadersVisible = false;
            this.dataGridView_NVD.Location = new System.Drawing.Point(358, 21);
            this.dataGridView_NVD.Name = "dataGridView_NVD";
            this.dataGridView_NVD.RowHeadersVisible = false;
            this.dataGridView_NVD.RowHeadersWidth = 50;
            this.dataGridView_NVD.RowTemplate.Height = 24;
            this.dataGridView_NVD.Size = new System.Drawing.Size(196, 319);
            this.dataGridView_NVD.TabIndex = 1;
            // 
            // labelUslovie_NVD
            // 
            this.labelUslovie_NVD.AutoSize = true;
            this.labelUslovie_NVD.Location = new System.Drawing.Point(7, 31);
            this.labelUslovie_NVD.Name = "labelUslovie_NVD";
            this.labelUslovie_NVD.Size = new System.Drawing.Size(345, 119);
            this.labelUslovie_NVD.TabIndex = 0;
            this.labelUslovie_NVD.Text = "Дан массив 5 на 5 элементов. \r\nЗаменить четные значения в третьей строке на 0.\r\n1" +
    "6  19  17   2   8\r\n -17   8 -17  -8   1\r\n  -7  17  -2   1  -3\r\n -12   0 -17  15 " +
    "  6\r\n  17  -6 -17  18 -19";
            // 
            // groupBoxOut_NVD
            // 
            this.groupBoxOut_NVD.Controls.Add(this.dataGridViewItog_NVD);
            this.groupBoxOut_NVD.Location = new System.Drawing.Point(585, 12);
            this.groupBoxOut_NVD.Name = "groupBoxOut_NVD";
            this.groupBoxOut_NVD.Size = new System.Drawing.Size(203, 360);
            this.groupBoxOut_NVD.TabIndex = 1;
            this.groupBoxOut_NVD.TabStop = false;
            this.groupBoxOut_NVD.Text = "Вывод данных";
            // 
            // dataGridViewItog_NVD
            // 
            this.dataGridViewItog_NVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItog_NVD.ColumnHeadersVisible = false;
            this.dataGridViewItog_NVD.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewItog_NVD.Name = "dataGridViewItog_NVD";
            this.dataGridViewItog_NVD.RowHeadersVisible = false;
            this.dataGridViewItog_NVD.RowHeadersWidth = 50;
            this.dataGridViewItog_NVD.RowTemplate.Height = 24;
            this.dataGridViewItog_NVD.Size = new System.Drawing.Size(191, 298);
            this.dataGridViewItog_NVD.TabIndex = 0;
            // 
            // buttonHelp_NVD
            // 
            this.buttonHelp_NVD.Location = new System.Drawing.Point(591, 403);
            this.buttonHelp_NVD.Name = "buttonHelp_NVD";
            this.buttonHelp_NVD.Size = new System.Drawing.Size(36, 35);
            this.buttonHelp_NVD.TabIndex = 2;
            this.buttonHelp_NVD.Text = "?";
            this.buttonHelp_NVD.UseVisualStyleBackColor = true;
            this.buttonHelp_NVD.Click += new System.EventHandler(this.buttonHelp_NVD_Click);
            // 
            // buttonDone_NVD
            // 
            this.buttonDone_NVD.Location = new System.Drawing.Point(647, 403);
            this.buttonDone_NVD.Name = "buttonDone_NVD";
            this.buttonDone_NVD.Size = new System.Drawing.Size(141, 35);
            this.buttonDone_NVD.TabIndex = 3;
            this.buttonDone_NVD.Text = "Выполнить";
            this.buttonDone_NVD.UseVisualStyleBackColor = true;
            this.buttonDone_NVD.Click += new System.EventHandler(this.buttonDone_NVD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_NVD);
            this.Controls.Add(this.buttonHelp_NVD);
            this.Controls.Add(this.groupBoxOut_NVD);
            this.Controls.Add(this.groupBoxIn_NVD);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 26 | Носова В.Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxIn_NVD.ResumeLayout(false);
            this.groupBoxIn_NVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NVD)).EndInit();
            this.groupBoxOut_NVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItog_NVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIn_NVD;
        private System.Windows.Forms.Label labelUslovie_NVD;
        private System.Windows.Forms.DataGridView dataGridView_NVD;
        private System.Windows.Forms.GroupBox groupBoxOut_NVD;
        private System.Windows.Forms.DataGridView dataGridViewItog_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
    }
}

