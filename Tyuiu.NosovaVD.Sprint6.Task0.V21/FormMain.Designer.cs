
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
            this.groupBoxNamedTwo_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxNamedFour_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxNamedThree_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxNamedSix_NVD = new System.Windows.Forms.GroupBox();
            this.groupBoxNamedFour_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxResult_NVD = new System.Windows.Forms.TextBox();
            this.groupBoxNameddTwo_NVD = new System.Windows.Forms.GroupBox();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.pictureBoxFormula_NVD = new System.Windows.Forms.PictureBox();
            this.groupBoxNamedTwo_NVD.SuspendLayout();
            this.groupBoxNamedThree_NVD.SuspendLayout();
            this.groupBoxNamedFour_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_NVD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNamedTwo_NVD
            // 
            this.groupBoxNamedTwo_NVD.Controls.Add(this.pictureBoxFormula_NVD);
            this.groupBoxNamedTwo_NVD.Controls.Add(this.textBoxNamedFour_NVD);
            this.groupBoxNamedTwo_NVD.Location = new System.Drawing.Point(12, 25);
            this.groupBoxNamedTwo_NVD.Name = "groupBoxNamedTwo_NVD";
            this.groupBoxNamedTwo_NVD.Size = new System.Drawing.Size(666, 184);
            this.groupBoxNamedTwo_NVD.TabIndex = 2;
            this.groupBoxNamedTwo_NVD.TabStop = false;
            this.groupBoxNamedTwo_NVD.Text = "Условие";
            // 
            // textBoxNamedFour_NVD
            // 
            this.textBoxNamedFour_NVD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxNamedFour_NVD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamedFour_NVD.Location = new System.Drawing.Point(17, 31);
            this.textBoxNamedFour_NVD.Multiline = true;
            this.textBoxNamedFour_NVD.Name = "textBoxNamedFour_NVD";
            this.textBoxNamedFour_NVD.ReadOnly = true;
            this.textBoxNamedFour_NVD.Size = new System.Drawing.Size(242, 22);
            this.textBoxNamedFour_NVD.TabIndex = 1;
            this.textBoxNamedFour_NVD.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxNamedThree_NVD
            // 
            this.groupBoxNamedThree_NVD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxNamedThree_NVD.Controls.Add(this.textBoxVarX_NVD);
            this.groupBoxNamedThree_NVD.Controls.Add(this.groupBoxNamedSix_NVD);
            this.groupBoxNamedThree_NVD.Location = new System.Drawing.Point(12, 215);
            this.groupBoxNamedThree_NVD.Name = "groupBoxNamedThree_NVD";
            this.groupBoxNamedThree_NVD.Size = new System.Drawing.Size(406, 137);
            this.groupBoxNamedThree_NVD.TabIndex = 3;
            this.groupBoxNamedThree_NVD.TabStop = false;
            this.groupBoxNamedThree_NVD.Text = "Ввод данных";
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
            // groupBoxNamedSix_NVD
            // 
            this.groupBoxNamedSix_NVD.Location = new System.Drawing.Point(106, 56);
            this.groupBoxNamedSix_NVD.Name = "groupBoxNamedSix_NVD";
            this.groupBoxNamedSix_NVD.Size = new System.Drawing.Size(181, 43);
            this.groupBoxNamedSix_NVD.TabIndex = 7;
            this.groupBoxNamedSix_NVD.TabStop = false;
            this.groupBoxNamedSix_NVD.Text = "Переменная X:";
            // 
            // groupBoxNamedFour_NVD
            // 
            this.groupBoxNamedFour_NVD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxNamedFour_NVD.Controls.Add(this.textBoxResult_NVD);
            this.groupBoxNamedFour_NVD.Controls.Add(this.groupBoxNameddTwo_NVD);
            this.groupBoxNamedFour_NVD.Location = new System.Drawing.Point(424, 215);
            this.groupBoxNamedFour_NVD.Name = "groupBoxNamedFour_NVD";
            this.groupBoxNamedFour_NVD.Size = new System.Drawing.Size(254, 137);
            this.groupBoxNamedFour_NVD.TabIndex = 4;
            this.groupBoxNamedFour_NVD.TabStop = false;
            this.groupBoxNamedFour_NVD.Text = "Вывод данных";
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
            // groupBoxNameddTwo_NVD
            // 
            this.groupBoxNameddTwo_NVD.Location = new System.Drawing.Point(11, 56);
            this.groupBoxNameddTwo_NVD.Name = "groupBoxNameddTwo_NVD";
            this.groupBoxNameddTwo_NVD.Size = new System.Drawing.Size(96, 24);
            this.groupBoxNameddTwo_NVD.TabIndex = 3;
            this.groupBoxNameddTwo_NVD.TabStop = false;
            this.groupBoxNameddTwo_NVD.Text = "Результат";
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
            // pictureBoxFormula_NVD
            // 
            this.pictureBoxFormula_NVD.Image = global::Tyuiu.NosovaVD.Sprint6.Task0.V21.Properties.Resources.Формула;
            this.pictureBoxFormula_NVD.Location = new System.Drawing.Point(289, 21);
            this.pictureBoxFormula_NVD.Name = "pictureBoxFormula_NVD";
            this.pictureBoxFormula_NVD.Size = new System.Drawing.Size(371, 55);
            this.pictureBoxFormula_NVD.TabIndex = 2;
            this.pictureBoxFormula_NVD.TabStop = false;
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(705, 425);
            this.Controls.Add(this.buttonHelp_NVD);
            this.Controls.Add(this.buttonDone_NVD);
            this.Controls.Add(this.groupBoxNamedFour_NVD);
            this.Controls.Add(this.groupBoxNamedThree_NVD);
            this.Controls.Add(this.groupBoxNamedTwo_NVD);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 21 | Носова В.Д.";
            this.groupBoxNamedTwo_NVD.ResumeLayout(false);
            this.groupBoxNamedTwo_NVD.PerformLayout();
            this.groupBoxNamedThree_NVD.ResumeLayout(false);
            this.groupBoxNamedThree_NVD.PerformLayout();
            this.groupBoxNamedFour_NVD.ResumeLayout(false);
            this.groupBoxNamedFour_NVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_NVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxNamedTwo_NVD;
        private System.Windows.Forms.GroupBox groupBoxNamedThree_NVD;
        private System.Windows.Forms.GroupBox groupBoxNamedFour_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
        private System.Windows.Forms.TextBox textBoxVarX_NVD;
        private System.Windows.Forms.GroupBox groupBoxNamedSix_NVD;
        private System.Windows.Forms.TextBox textBoxNamedFour_NVD;
        private System.Windows.Forms.GroupBox groupBoxNameddTwo_NVD;
        private System.Windows.Forms.TextBox textBoxResult_NVD;
        private System.Windows.Forms.PictureBox pictureBoxFormula_NVD;
    }
}

