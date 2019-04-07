namespace File_Converter
{
    partial class ConvertToDOCX
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
            this.Path = new System.Windows.Forms.TextBox();
            this.SaveCoonvertFileToDOCX = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Path
            // 
            this.Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Path.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path.Location = new System.Drawing.Point(31, 78);
            this.Path.Multiline = true;
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Size = new System.Drawing.Size(566, 84);
            this.Path.TabIndex = 4;
            // 
            // SaveCoonvertFileToDOCX
            // 
            this.SaveCoonvertFileToDOCX.BackColor = System.Drawing.Color.SlateBlue;
            this.SaveCoonvertFileToDOCX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCoonvertFileToDOCX.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCoonvertFileToDOCX.Location = new System.Drawing.Point(459, 187);
            this.SaveCoonvertFileToDOCX.Name = "SaveCoonvertFileToDOCX";
            this.SaveCoonvertFileToDOCX.Size = new System.Drawing.Size(138, 39);
            this.SaveCoonvertFileToDOCX.TabIndex = 2;
            this.SaveCoonvertFileToDOCX.Text = "Convert file";
            this.SaveCoonvertFileToDOCX.UseVisualStyleBackColor = false;
            this.SaveCoonvertFileToDOCX.Click += new System.EventHandler(this.SaveCoonvertFileToDOCX_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.SlateBlue;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.Location = new System.Drawing.Point(31, 23);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(138, 39);
            this.OpenFile.TabIndex = 3;
            this.OpenFile.Text = "Open file";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConvertToDOCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.Path);
            this.Controls.Add(this.SaveCoonvertFileToDOCX);
            this.Controls.Add(this.OpenFile);
            this.Name = "ConvertToDOCX";
            this.Size = new System.Drawing.Size(629, 248);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button SaveCoonvertFileToDOCX;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
