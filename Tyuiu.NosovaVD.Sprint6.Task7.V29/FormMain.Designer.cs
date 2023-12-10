
namespace Tyuiu.NosovaVD.Sprint6.Task7.V29
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
            this.buttonSaveFile_NVD = new System.Windows.Forms.Button();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_NVD = new System.Windows.Forms.Button();
            this.panelCenter_NVD = new System.Windows.Forms.Panel();
            this.groupBoxUslovie_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_NVD = new System.Windows.Forms.TextBox();
            this.panelLeft_NVD = new System.Windows.Forms.Panel();
            this.groupBoxIn_NVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_NVD = new System.Windows.Forms.DataGridView();
            this.splitterOne_NVD = new System.Windows.Forms.Splitter();
            this.panelRight_NVD = new System.Windows.Forms.Panel();
            this.groupBoxOut_NVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_NVD = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_NVD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_NVD = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_NVD = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_NVD.SuspendLayout();
            this.panelCenter_NVD.SuspendLayout();
            this.groupBoxUslovie_NVD.SuspendLayout();
            this.panelLeft_NVD.SuspendLayout();
            this.groupBoxIn_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_NVD)).BeginInit();
            this.panelRight_NVD.SuspendLayout();
            this.groupBoxOut_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NVD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_NVD
            // 
            this.panelTop_NVD.Controls.Add(this.buttonSaveFile_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonHelp_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonDone_NVD);
            this.panelTop_NVD.Controls.Add(this.buttonOpenFile_NVD);
            this.panelTop_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NVD.Name = "panelTop_NVD";
            this.panelTop_NVD.Size = new System.Drawing.Size(1032, 85);
            this.panelTop_NVD.TabIndex = 0;
            // 
            // buttonSaveFile_NVD
            // 
            this.buttonSaveFile_NVD.Enabled = false;
            this.buttonSaveFile_NVD.Image = global::Tyuiu.NosovaVD.Sprint6.Task7.V29.Properties.Resources.page_save;
            this.buttonSaveFile_NVD.Location = new System.Drawing.Point(196, 13);
            this.buttonSaveFile_NVD.Name = "buttonSaveFile_NVD";
            this.buttonSaveFile_NVD.Size = new System.Drawing.Size(84, 65);
            this.buttonSaveFile_NVD.TabIndex = 3;
            this.toolTip_NVD.SetToolTip(this.buttonSaveFile_NVD, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_NVD.UseVisualStyleBackColor = true;
            this.buttonSaveFile_NVD.Click += new System.EventHandler(this.buttonSaveFile_NVD_Click);
            this.buttonSaveFile_NVD.MouseEnter += new System.EventHandler(this.buttonSaveFile_NVD_MouseEnter);
            // 
            // buttonHelp_NVD
            // 
            this.buttonHelp_NVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_NVD.Image = global::Tyuiu.NosovaVD.Sprint6.Task7.V29.Properties.Resources.help;
            this.buttonHelp_NVD.Location = new System.Drawing.Point(931, 12);
            this.buttonHelp_NVD.Name = "buttonHelp_NVD";
            this.buttonHelp_NVD.Size = new System.Drawing.Size(89, 66);
            this.buttonHelp_NVD.TabIndex = 2;
            this.toolTip_NVD.SetToolTip(this.buttonHelp_NVD, "Сведение о программе");
            this.buttonHelp_NVD.UseVisualStyleBackColor = true;
            this.buttonHelp_NVD.Click += new System.EventHandler(this.buttonHelp_NVD_Click);
            this.buttonHelp_NVD.MouseEnter += new System.EventHandler(this.buttonHelp_NVD_MouseEnter);
            // 
            // buttonDone_NVD
            // 
            this.buttonDone_NVD.Enabled = false;
            this.buttonDone_NVD.Image = global::Tyuiu.NosovaVD.Sprint6.Task7.V29.Properties.Resources.page_go;
            this.buttonDone_NVD.Location = new System.Drawing.Point(102, 12);
            this.buttonDone_NVD.Name = "buttonDone_NVD";
            this.buttonDone_NVD.Size = new System.Drawing.Size(87, 66);
            this.buttonDone_NVD.TabIndex = 1;
            this.toolTip_NVD.SetToolTip(this.buttonDone_NVD, "Выполнить обработку данных");
            this.buttonDone_NVD.UseVisualStyleBackColor = true;
            this.buttonDone_NVD.Click += new System.EventHandler(this.buttonDone_NVD_Click);
            this.buttonDone_NVD.MouseEnter += new System.EventHandler(this.buttonDone_NVD_MouseEnter);
            // 
            // buttonOpenFile_NVD
            // 
            this.buttonOpenFile_NVD.Image = global::Tyuiu.NosovaVD.Sprint6.Task7.V29.Properties.Resources.folder_page;
            this.buttonOpenFile_NVD.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_NVD.Name = "buttonOpenFile_NVD";
            this.buttonOpenFile_NVD.Size = new System.Drawing.Size(84, 66);
            this.buttonOpenFile_NVD.TabIndex = 0;
            this.toolTip_NVD.SetToolTip(this.buttonOpenFile_NVD, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_NVD.UseVisualStyleBackColor = false;
            this.buttonOpenFile_NVD.Click += new System.EventHandler(this.buttonOpenFile_NVD_Click);
            this.buttonOpenFile_NVD.MouseEnter += new System.EventHandler(this.buttonOpenFile_NVD_MouseEnter);
            // 
            // panelCenter_NVD
            // 
            this.panelCenter_NVD.Controls.Add(this.groupBoxUslovie_NVD);
            this.panelCenter_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCenter_NVD.Location = new System.Drawing.Point(0, 85);
            this.panelCenter_NVD.Name = "panelCenter_NVD";
            this.panelCenter_NVD.Size = new System.Drawing.Size(1032, 87);
            this.panelCenter_NVD.TabIndex = 1;
            // 
            // groupBoxUslovie_NVD
            // 
            this.groupBoxUslovie_NVD.Controls.Add(this.textBoxUslovie_NVD);
            this.groupBoxUslovie_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUslovie_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUslovie_NVD.Name = "groupBoxUslovie_NVD";
            this.groupBoxUslovie_NVD.Size = new System.Drawing.Size(1032, 87);
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
            this.textBoxUslovie_NVD.Size = new System.Drawing.Size(1026, 66);
            this.textBoxUslovie_NVD.TabIndex = 3;
            this.textBoxUslovie_NVD.Text = resources.GetString("textBoxUslovie_NVD.Text");
            // 
            // panelLeft_NVD
            // 
            this.panelLeft_NVD.Controls.Add(this.groupBoxIn_NVD);
            this.panelLeft_NVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NVD.Location = new System.Drawing.Point(0, 172);
            this.panelLeft_NVD.Name = "panelLeft_NVD";
            this.panelLeft_NVD.Size = new System.Drawing.Size(512, 381);
            this.panelLeft_NVD.TabIndex = 2;
            // 
            // groupBoxIn_NVD
            // 
            this.groupBoxIn_NVD.Controls.Add(this.dataGridViewIn_NVD);
            this.groupBoxIn_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_NVD.Name = "groupBoxIn_NVD";
            this.groupBoxIn_NVD.Size = new System.Drawing.Size(512, 381);
            this.groupBoxIn_NVD.TabIndex = 0;
            this.groupBoxIn_NVD.TabStop = false;
            this.groupBoxIn_NVD.Text = "Ввод";
            // 
            // dataGridViewIn_NVD
            // 
            this.dataGridViewIn_NVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_NVD.ColumnHeadersVisible = false;
            this.dataGridViewIn_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_NVD.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIn_NVD.Name = "dataGridViewIn_NVD";
            this.dataGridViewIn_NVD.RowHeadersVisible = false;
            this.dataGridViewIn_NVD.RowHeadersWidth = 51;
            this.dataGridViewIn_NVD.RowTemplate.Height = 24;
            this.dataGridViewIn_NVD.Size = new System.Drawing.Size(506, 360);
            this.dataGridViewIn_NVD.TabIndex = 0;
            // 
            // splitterOne_NVD
            // 
            this.splitterOne_NVD.Location = new System.Drawing.Point(512, 172);
            this.splitterOne_NVD.Name = "splitterOne_NVD";
            this.splitterOne_NVD.Size = new System.Drawing.Size(3, 381);
            this.splitterOne_NVD.TabIndex = 3;
            this.splitterOne_NVD.TabStop = false;
            // 
            // panelRight_NVD
            // 
            this.panelRight_NVD.Controls.Add(this.groupBoxOut_NVD);
            this.panelRight_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NVD.Location = new System.Drawing.Point(515, 172);
            this.panelRight_NVD.Name = "panelRight_NVD";
            this.panelRight_NVD.Size = new System.Drawing.Size(517, 381);
            this.panelRight_NVD.TabIndex = 4;
            // 
            // groupBoxOut_NVD
            // 
            this.groupBoxOut_NVD.Controls.Add(this.dataGridViewOut_NVD);
            this.groupBoxOut_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_NVD.Name = "groupBoxOut_NVD";
            this.groupBoxOut_NVD.Size = new System.Drawing.Size(517, 381);
            this.groupBoxOut_NVD.TabIndex = 1;
            this.groupBoxOut_NVD.TabStop = false;
            this.groupBoxOut_NVD.Text = "Вывод";
            // 
            // dataGridViewOut_NVD
            // 
            this.dataGridViewOut_NVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_NVD.ColumnHeadersVisible = false;
            this.dataGridViewOut_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_NVD.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOut_NVD.Name = "dataGridViewOut_NVD";
            this.dataGridViewOut_NVD.RowHeadersVisible = false;
            this.dataGridViewOut_NVD.RowHeadersWidth = 51;
            this.dataGridViewOut_NVD.RowTemplate.Height = 24;
            this.dataGridViewOut_NVD.Size = new System.Drawing.Size(511, 360);
            this.dataGridViewOut_NVD.TabIndex = 0;
            // 
            // openFileDialogTask_NVD
            // 
            this.openFileDialogTask_NVD.FileName = "openFileDialog";
            // 
            // toolTip_NVD
            // 
            this.toolTip_NVD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_NVD.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.panelRight_NVD);
            this.Controls.Add(this.splitterOne_NVD);
            this.Controls.Add(this.panelLeft_NVD);
            this.Controls.Add(this.panelCenter_NVD);
            this.Controls.Add(this.panelTop_NVD);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 29 | Носова В.Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_NVD.ResumeLayout(false);
            this.panelCenter_NVD.ResumeLayout(false);
            this.groupBoxUslovie_NVD.ResumeLayout(false);
            this.groupBoxUslovie_NVD.PerformLayout();
            this.panelLeft_NVD.ResumeLayout(false);
            this.groupBoxIn_NVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_NVD)).EndInit();
            this.panelRight_NVD.ResumeLayout(false);
            this.groupBoxOut_NVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NVD)).EndInit();
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
        private System.Windows.Forms.Button buttonOpenFile_NVD;
        private System.Windows.Forms.Button buttonDone_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_NVD;
        private System.Windows.Forms.ToolTip toolTip_NVD;
        private System.Windows.Forms.Button buttonSaveFile_NVD;
        private System.Windows.Forms.DataGridView dataGridViewIn_NVD;
        private System.Windows.Forms.DataGridView dataGridViewOut_NVD;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_NVD;
    }
}

