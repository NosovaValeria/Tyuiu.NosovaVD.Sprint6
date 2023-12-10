
namespace Tyuiu.NosovaVD.Sprint6.Task6.V28
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelOne_NVD = new System.Windows.Forms.Panel();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_NVD = new System.Windows.Forms.Button();
            this.panelTwo_NVD = new System.Windows.Forms.Panel();
            this.groupBoxNameedOne_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxNamedOne_NVD = new System.Windows.Forms.TextBox();
            this.panelThree_NVD = new System.Windows.Forms.Panel();
            this.groupBoxTwo_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxIn_NVD = new System.Windows.Forms.TextBox();
            this.splitterOne_NVD = new System.Windows.Forms.Splitter();
            this.panelFour_NVD = new System.Windows.Forms.Panel();
            this.groupBoxThree_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxOut_NVD = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_NVD = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOne_NVD = new System.Windows.Forms.ToolTip(this.components);
            this.panelOne_NVD.SuspendLayout();
            this.panelTwo_NVD.SuspendLayout();
            this.groupBoxNameedOne_NVD.SuspendLayout();
            this.panelThree_NVD.SuspendLayout();
            this.groupBoxTwo_NVD.SuspendLayout();
            this.panelFour_NVD.SuspendLayout();
            this.groupBoxThree_NVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOne_NVD
            // 
            this.panelOne_NVD.Controls.Add(this.buttonHelp_NVD);
            this.panelOne_NVD.Controls.Add(this.buttonDone_NVD);
            this.panelOne_NVD.Controls.Add(this.buttonOpenFile_NVD);
            this.panelOne_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelOne_NVD.Name = "panelOne_NVD";
            this.panelOne_NVD.Size = new System.Drawing.Size(932, 85);
            this.panelOne_NVD.TabIndex = 0;
            // 
            // buttonHelp_NVD
            // 
            this.buttonHelp_NVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_NVD.Image = global::Tyuiu.NosovaVD.Sprint6.Task6.V28.Properties.Resources.help;
            this.buttonHelp_NVD.Location = new System.Drawing.Point(825, 12);
            this.buttonHelp_NVD.Name = "buttonHelp_NVD";
            this.buttonHelp_NVD.Size = new System.Drawing.Size(89, 66);
            this.buttonHelp_NVD.TabIndex = 1;
            this.toolTipOne_NVD.SetToolTip(this.buttonHelp_NVD, "Сведение о программе");
            this.buttonHelp_NVD.UseVisualStyleBackColor = true;
            this.buttonHelp_NVD.Click += new System.EventHandler(this.buttonHelp_NVD_Click);
            // 
            // buttonDone_NVD
            // 
            this.buttonDone_NVD.Enabled = false;
            this.buttonDone_NVD.Image = global::Tyuiu.NosovaVD.Sprint6.Task6.V28.Properties.Resources.page_go;
            this.buttonDone_NVD.Location = new System.Drawing.Point(102, 12);
            this.buttonDone_NVD.Name = "buttonDone_NVD";
            this.buttonDone_NVD.Size = new System.Drawing.Size(87, 66);
            this.buttonDone_NVD.TabIndex = 1;
            this.toolTipOne_NVD.SetToolTip(this.buttonDone_NVD, "Производит поиск в файле и выводит предпоследнее слово каждой строки в результиру" +
        "ющею строку");
            this.buttonDone_NVD.UseVisualStyleBackColor = true;
            this.buttonDone_NVD.Click += new System.EventHandler(this.buttonDone_NVD_Click);
            // 
            // buttonOpenFile_NVD
            // 
            this.buttonOpenFile_NVD.Image = global::Tyuiu.NosovaVD.Sprint6.Task6.V28.Properties.Resources.folder_page;
            this.buttonOpenFile_NVD.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_NVD.Name = "buttonOpenFile_NVD";
            this.buttonOpenFile_NVD.Size = new System.Drawing.Size(84, 66);
            this.buttonOpenFile_NVD.TabIndex = 0;
            this.toolTipOne_NVD.SetToolTip(this.buttonOpenFile_NVD, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_NVD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_NVD.Click += new System.EventHandler(this.buttonOpenFile_NVD_Click);
            // 
            // panelTwo_NVD
            // 
            this.panelTwo_NVD.Controls.Add(this.groupBoxNameedOne_NVD);
            this.panelTwo_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_NVD.Location = new System.Drawing.Point(0, 85);
            this.panelTwo_NVD.Name = "panelTwo_NVD";
            this.panelTwo_NVD.Size = new System.Drawing.Size(932, 87);
            this.panelTwo_NVD.TabIndex = 1;
            // 
            // groupBoxNameedOne_NVD
            // 
            this.groupBoxNameedOne_NVD.Controls.Add(this.textBoxNamedOne_NVD);
            this.groupBoxNameedOne_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNameedOne_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNameedOne_NVD.Name = "groupBoxNameedOne_NVD";
            this.groupBoxNameedOne_NVD.Size = new System.Drawing.Size(932, 87);
            this.groupBoxNameedOne_NVD.TabIndex = 9;
            this.groupBoxNameedOne_NVD.TabStop = false;
            this.groupBoxNameedOne_NVD.Text = "Условие";
            // 
            // textBoxNamedOne_NVD
            // 
            this.textBoxNamedOne_NVD.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNamedOne_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNamedOne_NVD.Location = new System.Drawing.Point(3, 18);
            this.textBoxNamedOne_NVD.Multiline = true;
            this.textBoxNamedOne_NVD.Name = "textBoxNamedOne_NVD";
            this.textBoxNamedOne_NVD.ReadOnly = true;
            this.textBoxNamedOne_NVD.Size = new System.Drawing.Size(926, 66);
            this.textBoxNamedOne_NVD.TabIndex = 3;
            this.textBoxNamedOne_NVD.Text = resources.GetString("textBoxNamedOne_NVD.Text");
            // 
            // panelThree_NVD
            // 
            this.panelThree_NVD.Controls.Add(this.groupBoxTwo_NVD);
            this.panelThree_NVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThree_NVD.Location = new System.Drawing.Point(0, 172);
            this.panelThree_NVD.Name = "panelThree_NVD";
            this.panelThree_NVD.Size = new System.Drawing.Size(451, 331);
            this.panelThree_NVD.TabIndex = 2;
            // 
            // groupBoxTwo_NVD
            // 
            this.groupBoxTwo_NVD.Controls.Add(this.textBoxIn_NVD);
            this.groupBoxTwo_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTwo_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTwo_NVD.Name = "groupBoxTwo_NVD";
            this.groupBoxTwo_NVD.Size = new System.Drawing.Size(451, 331);
            this.groupBoxTwo_NVD.TabIndex = 0;
            this.groupBoxTwo_NVD.TabStop = false;
            this.groupBoxTwo_NVD.Text = "Ввод";
            // 
            // textBoxIn_NVD
            // 
            this.textBoxIn_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_NVD.Location = new System.Drawing.Point(3, 18);
            this.textBoxIn_NVD.Multiline = true;
            this.textBoxIn_NVD.Name = "textBoxIn_NVD";
            this.textBoxIn_NVD.ReadOnly = true;
            this.textBoxIn_NVD.Size = new System.Drawing.Size(445, 310);
            this.textBoxIn_NVD.TabIndex = 0;
            // 
            // splitterOne_NVD
            // 
            this.splitterOne_NVD.Location = new System.Drawing.Point(451, 172);
            this.splitterOne_NVD.Name = "splitterOne_NVD";
            this.splitterOne_NVD.Size = new System.Drawing.Size(3, 331);
            this.splitterOne_NVD.TabIndex = 3;
            this.splitterOne_NVD.TabStop = false;
            // 
            // panelFour_NVD
            // 
            this.panelFour_NVD.Controls.Add(this.groupBoxThree_NVD);
            this.panelFour_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFour_NVD.Location = new System.Drawing.Point(454, 172);
            this.panelFour_NVD.Name = "panelFour_NVD";
            this.panelFour_NVD.Size = new System.Drawing.Size(478, 331);
            this.panelFour_NVD.TabIndex = 4;
            // 
            // groupBoxThree_NVD
            // 
            this.groupBoxThree_NVD.Controls.Add(this.textBoxOut_NVD);
            this.groupBoxThree_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThree_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxThree_NVD.Name = "groupBoxThree_NVD";
            this.groupBoxThree_NVD.Size = new System.Drawing.Size(478, 331);
            this.groupBoxThree_NVD.TabIndex = 1;
            this.groupBoxThree_NVD.TabStop = false;
            this.groupBoxThree_NVD.Text = "Вывод";
            // 
            // textBoxOut_NVD
            // 
            this.textBoxOut_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_NVD.Location = new System.Drawing.Point(3, 18);
            this.textBoxOut_NVD.Multiline = true;
            this.textBoxOut_NVD.Name = "textBoxOut_NVD";
            this.textBoxOut_NVD.ReadOnly = true;
            this.textBoxOut_NVD.Size = new System.Drawing.Size(472, 310);
            this.textBoxOut_NVD.TabIndex = 1;
            // 
            // openFileDialogTask_NVD
            // 
            this.openFileDialogTask_NVD.FileName = "openFileDialog";
            // 
            // toolTipOne_NVD
            // 
            this.toolTipOne_NVD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOne_NVD.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.panelFour_NVD);
            this.Controls.Add(this.splitterOne_NVD);
            this.Controls.Add(this.panelThree_NVD);
            this.Controls.Add(this.panelTwo_NVD);
            this.Controls.Add(this.panelOne_NVD);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 28 | Носова В.Д.";
            this.panelOne_NVD.ResumeLayout(false);
            this.panelTwo_NVD.ResumeLayout(false);
            this.groupBoxNameedOne_NVD.ResumeLayout(false);
            this.groupBoxNameedOne_NVD.PerformLayout();
            this.panelThree_NVD.ResumeLayout(false);
            this.groupBoxTwo_NVD.ResumeLayout(false);
            this.groupBoxTwo_NVD.PerformLayout();
            this.panelFour_NVD.ResumeLayout(false);
            this.groupBoxThree_NVD.ResumeLayout(false);
            this.groupBoxThree_NVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_NVD;
        private System.Windows.Forms.Panel panelTwo_NVD;
        private System.Windows.Forms.GroupBox groupBoxNameedOne_NVD;
        private System.Windows.Forms.TextBox textBoxNamedOne_NVD;
        private System.Windows.Forms.Panel panelThree_NVD;
        private System.Windows.Forms.GroupBox groupBoxTwo_NVD;
        private System.Windows.Forms.Splitter splitterOne_NVD;
        private System.Windows.Forms.Panel panelFour_NVD;
        private System.Windows.Forms.GroupBox groupBoxThree_NVD;
        private System.Windows.Forms.TextBox textBoxIn_NVD;
        private System.Windows.Forms.TextBox textBoxOut_NVD;
        private System.Windows.Forms.Button buttonOpenFile_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_NVD;
        private System.Windows.Forms.ToolTip toolTipOne_NVD;
    }
}

