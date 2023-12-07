
namespace Tyuiu.NosovaVD.Sprint6.Task6.V28
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxOne_NVD = new System.Windows.Forms.PictureBox();
            this.labelInfo_NVD = new System.Windows.Forms.Label();
            this.buttonOK_NVD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_NVD)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOne_NVD
            // 
            this.pictureBoxOne_NVD.Image = global::Tyuiu.NosovaVD.Sprint6.Task6.V28.Properties.Resources.user_female;
            this.pictureBoxOne_NVD.Location = new System.Drawing.Point(12, 49);
            this.pictureBoxOne_NVD.Name = "pictureBoxOne_NVD";
            this.pictureBoxOne_NVD.Size = new System.Drawing.Size(76, 79);
            this.pictureBoxOne_NVD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOne_NVD.TabIndex = 0;
            this.pictureBoxOne_NVD.TabStop = false;
            // 
            // labelInfo_NVD
            // 
            this.labelInfo_NVD.AutoSize = true;
            this.labelInfo_NVD.Location = new System.Drawing.Point(94, 9);
            this.labelInfo_NVD.Name = "labelInfo_NVD";
            this.labelInfo_NVD.Size = new System.Drawing.Size(363, 153);
            this.labelInfo_NVD.TabIndex = 1;
            this.labelInfo_NVD.Text = resources.GetString("labelInfo_NVD.Text");
            // 
            // buttonOK_NVD
            // 
            this.buttonOK_NVD.Location = new System.Drawing.Point(348, 180);
            this.buttonOK_NVD.Name = "buttonOK_NVD";
            this.buttonOK_NVD.Size = new System.Drawing.Size(88, 31);
            this.buttonOK_NVD.TabIndex = 2;
            this.buttonOK_NVD.Text = "Ок";
            this.buttonOK_NVD.UseVisualStyleBackColor = true;
            this.buttonOK_NVD.Click += new System.EventHandler(this.buttonOK_NVD_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 223);
            this.Controls.Add(this.buttonOK_NVD);
            this.Controls.Add(this.labelInfo_NVD);
            this.Controls.Add(this.pictureBoxOne_NVD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_NVD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOne_NVD;
        private System.Windows.Forms.Label labelInfo_NVD;
        private System.Windows.Forms.Button buttonOK_NVD;
    }
}