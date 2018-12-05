namespace ThreadExample1
{
    partial class Forml
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
            this.textBoxl = new System.Windows.Forms.TextBox();
            this.buttonl = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxl
            // 
            this.textBoxl.Location = new System.Drawing.Point(12, 12);
            this.textBoxl.Multiline = true;
            this.textBoxl.Name = "textBoxl";
            this.textBoxl.Size = new System.Drawing.Size(326, 128);
            this.textBoxl.TabIndex = 0;
            // 
            // buttonl
            // 
            this.buttonl.Location = new System.Drawing.Point(12, 159);
            this.buttonl.Name = "buttonl";
            this.buttonl.Size = new System.Drawing.Size(102, 42);
            this.buttonl.TabIndex = 1;
            this.buttonl.Text = "Открыть";
            this.buttonl.UseVisualStyleBackColor = true;
            this.buttonl.Click += new System.EventHandler(this.buttonl_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Созхранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Forml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 220);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonl);
            this.Controls.Add(this.textBoxl);
            this.Name = "Forml";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Forml_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxl;
        private System.Windows.Forms.Button buttonl;
        private System.Windows.Forms.Button button2;
    }
}

