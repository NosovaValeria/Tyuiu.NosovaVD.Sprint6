
namespace Tyuiu.NosovaVD.Sprint6.Task0.V21
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
            this.groupBoxUslovie_NVD = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_NVD = new System.Windows.Forms.PictureBox();
            this.textBoxUslovie_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxIn_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxVarX_NVD = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxResult_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxResText_NVD = new System.Windows.Forms.GroupBox();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.groupBoxUslovie_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_NVD)).BeginInit();
            this.groupBoxIn_NVD.SuspendLayout();
            this.groupBoxOut_NVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_NVD
            // 
            this.groupBoxUslovie_NVD.Controls.Add(this.pictureBoxFormula_NVD);
            this.groupBoxUslovie_NVD.Controls.Add(this.textBoxUslovie_NVD);
            this.groupBoxUslovie_NVD.Location = new System.Drawing.Point(12, 25);
            this.groupBoxUslovie_NVD.Name = "groupBoxUslovie_NVD";
            this.groupBoxUslovie_NVD.Size = new System.Drawing.Size(666, 184);
            this.groupBoxUslovie_NVD.TabIndex = 2;
            this.groupBoxUslovie_NVD.TabStop = false;
            this.groupBoxUslovie_NVD.Text = "Условие";
            // 
            // pictureBoxFormula_NVD
            // 
            this.pictureBoxFormula_NVD.Image = global::Tyuiu.NosovaVD.Sprint6.Task0.V21.Properties.Resources.Формула;
            this.pictureBoxFormula_NVD.Location = new System.Drawing.Point(289, 21);
            this.pictureBoxFormula_NVD.Name = "pictureBoxFormula_NVD";
            this.pictureBoxFormula_NVD.Size = new System.Drawing.Size(371, 55);
            this.pictureBoxFormula_NVD.TabIndex = 2;
            this.pictureBoxFormula_NVD.TabStop = false;
            // 
            // textBoxUslovie_NVD
            // 
            this.textBoxUslovie_NVD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxUslovie_NVD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_NVD.Location = new System.Drawing.Point(17, 31);
            this.textBoxUslovie_NVD.Multiline = true;
            this.textBoxUslovie_NVD.Name = "textBoxUslovie_NVD";
            this.textBoxUslovie_NVD.ReadOnly = true;
            this.textBoxUslovie_NVD.Size = new System.Drawing.Size(242, 22);
            this.textBoxUslovie_NVD.TabIndex = 1;
            this.textBoxUslovie_NVD.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxIn_NVD
            // 
            this.groupBoxIn_NVD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxIn_NVD.Controls.Add(this.textBoxVarX_NVD);
            this.groupBoxIn_NVD.Controls.Add(this.groupBoxVarX_NVD);
            this.groupBoxIn_NVD.Location = new System.Drawing.Point(12, 215);
            this.groupBoxIn_NVD.Name = "groupBoxIn_NVD";
            this.groupBoxIn_NVD.Size = new System.Drawing.Size(406, 137);
            this.groupBoxIn_NVD.TabIndex = 3;
            this.groupBoxIn_NVD.TabStop = false;
            this.groupBoxIn_NVD.Text = "Ввод данных";
            // 
            // textBoxVarX_NVD
            // 
            this.textBoxVarX_NVD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxVarX_NVD.Location = new System.Drawing.Point(106, 77);
            this.textBoxVarX_NVD.Name = "textBoxVarX_NVD";
            this.textBoxVarX_NVD.Size = new System.Drawing.Size(181, 22);
            this.textBoxVarX_NVD.TabIndex = 1;
            this.textBoxVarX_NVD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_NVD_KeyPress);
            // 
            // groupBoxVarX_NVD
            // 
            this.groupBoxVarX_NVD.Location = new System.Drawing.Point(106, 56);
            this.groupBoxVarX_NVD.Name = "groupBoxVarX_NVD";
            this.groupBoxVarX_NVD.Size = new System.Drawing.Size(181, 43);
            this.groupBoxVarX_NVD.TabIndex = 7;
            this.groupBoxVarX_NVD.TabStop = false;
            this.groupBoxVarX_NVD.Text = "Переменная X:";
            // 
            // groupBoxOut_NVD
            // 
            this.groupBoxOut_NVD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxOut_NVD.Controls.Add(this.textBoxResult_NVD);
            this.groupBoxOut_NVD.Controls.Add(this.groupBoxResText_NVD);
            this.groupBoxOut_NVD.Location = new System.Drawing.Point(424, 215);
            this.groupBoxOut_NVD.Name = "groupBoxOut_NVD";
            this.groupBoxOut_NVD.Size = new System.Drawing.Size(254, 137);
            this.groupBoxOut_NVD.TabIndex = 4;
            this.groupBoxOut_NVD.TabStop = false;
            this.groupBoxOut_NVD.Text = "Вывод данных";
            // 
            // textBoxResult_NVD
            // 
            this.textBoxResult_NVD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxResult_NVD.Location = new System.Drawing.Point(11, 77);
            this.textBoxResult_NVD.Name = "textBoxResult_NVD";
            this.textBoxResult_NVD.ReadOnly = true;
            this.textBoxResult_NVD.Size = new System.Drawing.Size(200, 22);
            this.textBoxResult_NVD.TabIndex = 2;
            // 
            // groupBoxResText_NVD
            // 
            this.groupBoxResText_NVD.Location = new System.Drawing.Point(11, 56);
            this.groupBoxResText_NVD.Name = "groupBoxResText_NVD";
            this.groupBoxResText_NVD.Size = new System.Drawing.Size(96, 24);
            this.groupBoxResText_NVD.TabIndex = 3;
            this.groupBoxResText_NVD.TabStop = false;
            this.groupBoxResText_NVD.Text = "Результат";
            // 
            // buttonDone_NVD
            // 
            this.buttonDone_NVD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDone_NVD.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_NVD.Location = new System.Drawing.Point(504, 373);
            this.buttonDone_NVD.Name = "buttonDone_NVD";
            this.buttonDone_NVD.Size = new System.Drawing.Size(154, 38);
            this.buttonDone_NVD.TabIndex = 0;
            this.buttonDone_NVD.Text = "Выполнить";
            this.buttonDone_NVD.UseVisualStyleBackColor = false;
            this.buttonDone_NVD.Click += new System.EventHandler(this.buttonDone_NVD_Click);
            // 
            // buttonHelp_NVD
            // 
            this.buttonHelp_NVD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHelp_NVD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHelp_NVD.Location = new System.Drawing.Point(435, 373);
            this.buttonHelp_NVD.Name = "buttonHelp_NVD";
            this.buttonHelp_NVD.Size = new System.Drawing.Size(44, 37);
            this.buttonHelp_NVD.TabIndex = 6;
            this.buttonHelp_NVD.Text = "?";
            this.buttonHelp_NVD.UseVisualStyleBackColor = false;
            this.buttonHelp_NVD.Click += new System.EventHandler(this.buttonHelp_NVD_Click);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(705, 425);
            this.Controls.Add(this.buttonHelp_NVD);
            this.Controls.Add(this.buttonDone_NVD);
            this.Controls.Add(this.groupBoxOut_NVD);
            this.Controls.Add(this.groupBoxIn_NVD);
            this.Controls.Add(this.groupBoxUslovie_NVD);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 21 | Носова В.Д.";
            this.groupBoxUslovie_NVD.ResumeLayout(false);
            this.groupBoxUslovie_NVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_NVD)).EndInit();
            this.groupBoxIn_NVD.ResumeLayout(false);
            this.groupBoxIn_NVD.PerformLayout();
            this.groupBoxOut_NVD.ResumeLayout(false);
            this.groupBoxOut_NVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxUslovie_NVD;
        private System.Windows.Forms.GroupBox groupBoxIn_NVD;
        private System.Windows.Forms.GroupBox groupBoxOut_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
        private System.Windows.Forms.TextBox textBoxVarX_NVD;
        private System.Windows.Forms.GroupBox groupBoxVarX_NVD;
        private System.Windows.Forms.TextBox textBoxUslovie_NVD;
        private System.Windows.Forms.GroupBox groupBoxResText_NVD;
        private System.Windows.Forms.TextBox textBoxResult_NVD;
        private System.Windows.Forms.PictureBox pictureBoxFormula_NVD;
    }
}

