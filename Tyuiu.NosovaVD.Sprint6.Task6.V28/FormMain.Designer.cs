
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
            this.panelTop_NVD = new System.Windows.Forms.Panel();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_NVD = new System.Windows.Forms.Button();
            this.panelCenter_NVD = new System.Windows.Forms.Panel();
            this.groupBoxUslovie_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_NVD = new System.Windows.Forms.TextBox();
            this.panelLeft_NVD = new System.Windows.Forms.Panel();
            this.groupBoxIn_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxIn_NVD = new System.Windows.Forms.TextBox();
            this.splitterOne_NVD = new System.Windows.Forms.Splitter();
            this.panelRight_NVD = new System.Windows.Forms.Panel();
            this.groupBoxOut_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxOut_NVD = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_NVD = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOne_NVD = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_NVD.SuspendLayout();
            this.panelCenter_NVD.SuspendLayout();
            this.groupBoxUslovie_NVD.SuspendLayout();
            this.panelLeft_NVD.SuspendLayout();
            this.groupBoxIn_NVD.SuspendLayout();
            this.panelRight_NVD.SuspendLayout();
            this.groupBoxOut_NVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_NVD
            // 
            this.panelTop_NVD.Controls.Add(this.buttonHelp_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonDone_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonOpenFile_NVD);
            this.panelTop_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NVD.Name = "panelTop_NVD";
            this.panelTop_NVD.Size = new System.Drawing.Size(932, 85);
            this.panelTop_NVD.TabIndex = 0;
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
            // panelCenter_NVD
            // 
            this.panelCenter_NVD.Controls.Add(this.groupBoxUslovie_NVD);
            this.panelCenter_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCenter_NVD.Location = new System.Drawing.Point(0, 85);
            this.panelCenter_NVD.Name = "panelCenter_NVD";
            this.panelCenter_NVD.Size = new System.Drawing.Size(932, 87);
            this.panelCenter_NVD.TabIndex = 1;
            // 
            // groupBoxUslovie_NVD
            // 
            this.groupBoxUslovie_NVD.Controls.Add(this.textBoxUslovie_NVD);
            this.groupBoxUslovie_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUslovie_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUslovie_NVD.Name = "groupBoxUslovie_NVD";
            this.groupBoxUslovie_NVD.Size = new System.Drawing.Size(932, 87);
            this.groupBoxUslovie_NVD.TabIndex = 9;
            this.groupBoxUslovie_NVD.TabStop = false;
            this.groupBoxUslovie_NVD.Text = "Условие";
            // 
            // textBoxUslovie_NVD
            // 
            this.textBoxUslovie_NVD.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUslovie_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUslovie_NVD.Location = new System.Drawing.Point(3, 18);
            this.textBoxUslovie_NVD.Multiline = true;
            this.textBoxUslovie_NVD.Name = "textBoxUslovie_NVD";
            this.textBoxUslovie_NVD.ReadOnly = true;
            this.textBoxUslovie_NVD.Size = new System.Drawing.Size(926, 66);
            this.textBoxUslovie_NVD.TabIndex = 3;
            this.textBoxUslovie_NVD.Text = resources.GetString("textBoxUslovie_NVD.Text");
            // 
            // panelLeft_NVD
            // 
            this.panelLeft_NVD.Controls.Add(this.groupBoxIn_NVD);
            this.panelLeft_NVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NVD.Location = new System.Drawing.Point(0, 172);
            this.panelLeft_NVD.Name = "panelLeft_NVD";
            this.panelLeft_NVD.Size = new System.Drawing.Size(451, 331);
            this.panelLeft_NVD.TabIndex = 2;
            // 
            // groupBoxIn_NVD
            // 
            this.groupBoxIn_NVD.Controls.Add(this.textBoxIn_NVD);
            this.groupBoxIn_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_NVD.Name = "groupBoxIn_NVD";
            this.groupBoxIn_NVD.Size = new System.Drawing.Size(451, 331);
            this.groupBoxIn_NVD.TabIndex = 0;
            this.groupBoxIn_NVD.TabStop = false;
            this.groupBoxIn_NVD.Text = "Ввод";
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
            // panelRight_NVD
            // 
            this.panelRight_NVD.Controls.Add(this.groupBoxOut_NVD);
            this.panelRight_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NVD.Location = new System.Drawing.Point(454, 172);
            this.panelRight_NVD.Name = "panelRight_NVD";
            this.panelRight_NVD.Size = new System.Drawing.Size(478, 331);
            this.panelRight_NVD.TabIndex = 4;
            // 
            // groupBoxOut_NVD
            // 
            this.groupBoxOut_NVD.Controls.Add(this.textBoxOut_NVD);
            this.groupBoxOut_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_NVD.Name = "groupBoxOut_NVD";
            this.groupBoxOut_NVD.Size = new System.Drawing.Size(478, 331);
            this.groupBoxOut_NVD.TabIndex = 1;
            this.groupBoxOut_NVD.TabStop = false;
            this.groupBoxOut_NVD.Text = "Вывод";
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
            this.Controls.Add(this.panelRight_NVD);
            this.Controls.Add(this.splitterOne_NVD);
            this.Controls.Add(this.panelLeft_NVD);
            this.Controls.Add(this.panelCenter_NVD);
            this.Controls.Add(this.panelTop_NVD);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 28 | Носова В.Д.";
            this.panelTop_NVD.ResumeLayout(false);
            this.panelCenter_NVD.ResumeLayout(false);
            this.groupBoxUslovie_NVD.ResumeLayout(false);
            this.groupBoxUslovie_NVD.PerformLayout();
            this.panelLeft_NVD.ResumeLayout(false);
            this.groupBoxIn_NVD.ResumeLayout(false);
            this.groupBoxIn_NVD.PerformLayout();
            this.panelRight_NVD.ResumeLayout(false);
            this.groupBoxOut_NVD.ResumeLayout(false);
            this.groupBoxOut_NVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_NVD;
        private System.Windows.Forms.Panel panelCenter_NVD;
        private System.Windows.Forms.GroupBox groupBoxUslovie_NVD;
        private System.Windows.Forms.TextBox textBoxUslovie_NVD;
        private System.Windows.Forms.Panel panelLeft_NVD;
        private System.Windows.Forms.GroupBox groupBoxIn_NVD;
        private System.Windows.Forms.Splitter splitterOne_NVD;
        private System.Windows.Forms.Panel panelRight_NVD;
        private System.Windows.Forms.GroupBox groupBoxOut_NVD;
        private System.Windows.Forms.TextBox textBoxIn_NVD;
        private System.Windows.Forms.TextBox textBoxOut_NVD;
        private System.Windows.Forms.Button buttonOpenFile_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_NVD;
        private System.Windows.Forms.ToolTip toolTipOne_NVD;
    }
}

