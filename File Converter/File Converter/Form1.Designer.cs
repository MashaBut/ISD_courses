namespace File_Converter
{
    partial class Form1
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
            this.ToPDF = new System.Windows.Forms.Button();
            this.ToDocx = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.convertToPDF1 = new File_Converter.ConvertToPDF();
            this.convertToDOCX1 = new File_Converter.ConvertToDOCX();
            this.SuspendLayout();
            // 
            // ToPDF
            // 
            this.ToPDF.BackColor = System.Drawing.Color.Brown;
            this.ToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToPDF.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToPDF.Location = new System.Drawing.Point(132, 32);
            this.ToPDF.Name = "ToPDF";
            this.ToPDF.Size = new System.Drawing.Size(189, 59);
            this.ToPDF.TabIndex = 0;
            this.ToPDF.Text = "To PDF";
            this.ToPDF.UseVisualStyleBackColor = false;
            this.ToPDF.Click += new System.EventHandler(this.ToPDF_Click);
            // 
            // ToDocx
            // 
            this.ToDocx.BackColor = System.Drawing.Color.RoyalBlue;
            this.ToDocx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDocx.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDocx.Location = new System.Drawing.Point(398, 32);
            this.ToDocx.Name = "ToDocx";
            this.ToDocx.Size = new System.Drawing.Size(189, 59);
            this.ToDocx.TabIndex = 0;
            this.ToDocx.Text = "To DOCX";
            this.ToDocx.UseVisualStyleBackColor = false;
            this.ToDocx.Click += new System.EventHandler(this.ToDocx_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(657, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // convertToPDF1
            // 
            this.convertToPDF1.BackColor = System.Drawing.Color.IndianRed;
            this.convertToPDF1.Location = new System.Drawing.Point(50, 97);
            this.convertToPDF1.Name = "convertToPDF1";
            this.convertToPDF1.Size = new System.Drawing.Size(629, 248);
            this.convertToPDF1.TabIndex = 2;
            // 
            // convertToDOCX1
            // 
            this.convertToDOCX1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.convertToDOCX1.Location = new System.Drawing.Point(50, 97);
            this.convertToDOCX1.Name = "convertToDOCX1";
            this.convertToDOCX1.Size = new System.Drawing.Size(629, 248);
            this.convertToDOCX1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(728, 381);
            this.Controls.Add(this.convertToDOCX1);
            this.Controls.Add(this.convertToPDF1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToDocx);
            this.Controls.Add(this.ToPDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToPDF;
        private System.Windows.Forms.Button ToDocx;
        private System.Windows.Forms.Button button1;
        private ConvertToPDF convertToPDF1;
        private ConvertToDOCX convertToDOCX1;
    }
}

