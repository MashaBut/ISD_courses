namespace File_Converter
{
    partial class ConvertToPDF
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.SaveCoonvertFileToPDF = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.DarkSalmon;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.Location = new System.Drawing.Point(32, 21);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(138, 39);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open file";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Path
            // 
            this.Path.BackColor = System.Drawing.Color.MistyRose;
            this.Path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Path.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path.Location = new System.Drawing.Point(32, 76);
            this.Path.Multiline = true;
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Size = new System.Drawing.Size(566, 84);
            this.Path.TabIndex = 1;
            // 
            // SaveCoonvertFileToPDF
            // 
            this.SaveCoonvertFileToPDF.BackColor = System.Drawing.Color.DarkSalmon;
            this.SaveCoonvertFileToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCoonvertFileToPDF.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCoonvertFileToPDF.Location = new System.Drawing.Point(460, 185);
            this.SaveCoonvertFileToPDF.Name = "SaveCoonvertFileToPDF";
            this.SaveCoonvertFileToPDF.Size = new System.Drawing.Size(138, 39);
            this.SaveCoonvertFileToPDF.TabIndex = 0;
            this.SaveCoonvertFileToPDF.Text = "Convert file";
            this.SaveCoonvertFileToPDF.UseVisualStyleBackColor = false;
            this.SaveCoonvertFileToPDF.Click += new System.EventHandler(this.SaveCoonvertFileToPDF_Click);
            // 
            // ConvertToPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.Path);
            this.Controls.Add(this.SaveCoonvertFileToPDF);
            this.Controls.Add(this.OpenFile);
            this.Name = "ConvertToPDF";
            this.Size = new System.Drawing.Size(629, 248);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button SaveCoonvertFileToPDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
