
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
            this.panelOne_NVD = new System.Windows.Forms.Panel();
            this.buttonSaveFile_NVD = new System.Windows.Forms.Button();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_NVD = new System.Windows.Forms.Button();
            this.panelTwo_NVD = new System.Windows.Forms.Panel();
            this.groupBoxNameedOne_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxNamedOne_NVD = new System.Windows.Forms.TextBox();
            this.panelThree_NVD = new System.Windows.Forms.Panel();
            this.groupBoxTwo_NVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_NVD = new System.Windows.Forms.DataGridView();
            this.splitterOne_NVD = new System.Windows.Forms.Splitter();
            this.panelFour_NVD = new System.Windows.Forms.Panel();
            this.groupBoxThree_NVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_NVD = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_NVD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_NVD = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_NVD = new System.Windows.Forms.SaveFileDialog();
            this.panelOne_NVD.SuspendLayout();
            this.panelTwo_NVD.SuspendLayout();
            this.groupBoxNameedOne_NVD.SuspendLayout();
            this.panelThree_NVD.SuspendLayout();
            this.groupBoxTwo_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_NVD)).BeginInit();
            this.panelFour_NVD.SuspendLayout();
            this.groupBoxThree_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NVD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOne_NVD
            // 
            this.panelOne_NVD.Controls.Add(this.buttonSaveFile_NVD);
            this.panelOne_NVD.Controls.Add(this.buttonHelp_NVD);
            this.panelOne_NVD.Controls.Add(this.buttonDone_NVD);
            this.panelOne_NVD.Controls.Add(this.buttonOpenFile_NVD);
            this.panelOne_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelOne_NVD.Name = "panelOne_NVD";
            this.panelOne_NVD.Size = new System.Drawing.Size(1032, 85);
            this.panelOne_NVD.TabIndex = 0;
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
            // panelTwo_NVD
            // 
            this.panelTwo_NVD.Controls.Add(this.groupBoxNameedOne_NVD);
            this.panelTwo_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_NVD.Location = new System.Drawing.Point(0, 85);
            this.panelTwo_NVD.Name = "panelTwo_NVD";
            this.panelTwo_NVD.Size = new System.Drawing.Size(1032, 87);
            this.panelTwo_NVD.TabIndex = 1;
            // 
            // groupBoxNameedOne_NVD
            // 
            this.groupBoxNameedOne_NVD.Controls.Add(this.textBoxNamedOne_NVD);
            this.groupBoxNameedOne_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNameedOne_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNameedOne_NVD.Name = "groupBoxNameedOne_NVD";
            this.groupBoxNameedOne_NVD.Size = new System.Drawing.Size(1032, 87);
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
            this.textBoxNamedOne_NVD.Size = new System.Drawing.Size(1026, 66);
            this.textBoxNamedOne_NVD.TabIndex = 3;
            this.textBoxNamedOne_NVD.Text = resources.GetString("textBoxNamedOne_NVD.Text");
            // 
            // panelThree_NVD
            // 
            this.panelThree_NVD.Controls.Add(this.groupBoxTwo_NVD);
            this.panelThree_NVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThree_NVD.Location = new System.Drawing.Point(0, 172);
            this.panelThree_NVD.Name = "panelThree_NVD";
            this.panelThree_NVD.Size = new System.Drawing.Size(512, 381);
            this.panelThree_NVD.TabIndex = 2;
            // 
            // groupBoxTwo_NVD
            // 
            this.groupBoxTwo_NVD.Controls.Add(this.dataGridViewIn_NVD);
            this.groupBoxTwo_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTwo_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTwo_NVD.Name = "groupBoxTwo_NVD";
            this.groupBoxTwo_NVD.Size = new System.Drawing.Size(512, 381);
            this.groupBoxTwo_NVD.TabIndex = 0;
            this.groupBoxTwo_NVD.TabStop = false;
            this.groupBoxTwo_NVD.Text = "Ввод";
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
            // panelFour_NVD
            // 
            this.panelFour_NVD.Controls.Add(this.groupBoxThree_NVD);
            this.panelFour_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFour_NVD.Location = new System.Drawing.Point(515, 172);
            this.panelFour_NVD.Name = "panelFour_NVD";
            this.panelFour_NVD.Size = new System.Drawing.Size(517, 381);
            this.panelFour_NVD.TabIndex = 4;
            // 
            // groupBoxThree_NVD
            // 
            this.groupBoxThree_NVD.Controls.Add(this.dataGridViewOut_NVD);
            this.groupBoxThree_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThree_NVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxThree_NVD.Name = "groupBoxThree_NVD";
            this.groupBoxThree_NVD.Size = new System.Drawing.Size(517, 381);
            this.groupBoxThree_NVD.TabIndex = 1;
            this.groupBoxThree_NVD.TabStop = false;
            this.groupBoxThree_NVD.Text = "Вывод";
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
            this.Controls.Add(this.panelFour_NVD);
            this.Controls.Add(this.splitterOne_NVD);
            this.Controls.Add(this.panelThree_NVD);
            this.Controls.Add(this.panelTwo_NVD);
            this.Controls.Add(this.panelOne_NVD);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 29 | Носова В.Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelOne_NVD.ResumeLayout(false);
            this.panelTwo_NVD.ResumeLayout(false);
            this.groupBoxNameedOne_NVD.ResumeLayout(false);
            this.groupBoxNameedOne_NVD.PerformLayout();
            this.panelThree_NVD.ResumeLayout(false);
            this.groupBoxTwo_NVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_NVD)).EndInit();
            this.panelFour_NVD.ResumeLayout(false);
            this.groupBoxThree_NVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NVD)).EndInit();
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

