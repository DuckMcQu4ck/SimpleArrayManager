namespace SimpleArrayManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label_ArrayRange = new System.Windows.Forms.Label();
            this.TextBox_arrayRange = new System.Windows.Forms.TextBox();
            this.TextBox_ArrayOutput = new System.Windows.Forms.TextBox();
            this.Btn_generate = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_ArrayRange
            // 
            this.Label_ArrayRange.AutoSize = true;
            this.Label_ArrayRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ArrayRange.Location = new System.Drawing.Point(12, 25);
            this.Label_ArrayRange.Name = "Label_ArrayRange";
            this.Label_ArrayRange.Size = new System.Drawing.Size(180, 20);
            this.Label_ArrayRange.TabIndex = 0;
            this.Label_ArrayRange.Text = "Размерность массива:";
            // 
            // TextBox_arrayRange
            // 
            this.TextBox_arrayRange.Location = new System.Drawing.Point(198, 27);
            this.TextBox_arrayRange.Name = "TextBox_arrayRange";
            this.TextBox_arrayRange.Size = new System.Drawing.Size(180, 20);
            this.TextBox_arrayRange.TabIndex = 1;
            // 
            // TextBox_ArrayOutput
            // 
            this.TextBox_ArrayOutput.Location = new System.Drawing.Point(16, 70);
            this.TextBox_ArrayOutput.Multiline = true;
            this.TextBox_ArrayOutput.Name = "TextBox_ArrayOutput";
            this.TextBox_ArrayOutput.ReadOnly = true;
            this.TextBox_ArrayOutput.Size = new System.Drawing.Size(362, 113);
            this.TextBox_ArrayOutput.TabIndex = 3;
            // 
            // Btn_generate
            // 
            this.Btn_generate.Location = new System.Drawing.Point(384, 25);
            this.Btn_generate.Name = "Btn_generate";
            this.Btn_generate.Size = new System.Drawing.Size(88, 22);
            this.Btn_generate.TabIndex = 4;
            this.Btn_generate.Text = "Generate";
            this.Btn_generate.UseVisualStyleBackColor = true;
            this.Btn_generate.Click += new System.EventHandler(this.Btn_generate_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.Location = new System.Drawing.Point(384, 70);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(88, 113);
            this.Btn_clear.TabIndex = 5;
            this.Btn_clear.Text = "Clear";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 195);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_generate);
            this.Controls.Add(this.TextBox_ArrayOutput);
            this.Controls.Add(this.TextBox_arrayRange);
            this.Controls.Add(this.Label_ArrayRange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleArrayManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ArrayRange;
        private System.Windows.Forms.TextBox TextBox_arrayRange;
        private System.Windows.Forms.TextBox TextBox_ArrayOutput;
        private System.Windows.Forms.Button Btn_generate;
        private System.Windows.Forms.Button Btn_clear;
    }
}

