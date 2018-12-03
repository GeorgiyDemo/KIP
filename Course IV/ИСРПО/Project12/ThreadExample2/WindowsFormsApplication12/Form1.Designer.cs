namespace WindowsFormsApplication12
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
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
            this.textBoxl.Location = new System.Drawing.Point(30, 12);
            this.textBoxl.Name = "textBoxl";
            this.textBoxl.Size = new System.Drawing.Size(292, 20);
            this.textBoxl.TabIndex = 0;
            // 
            // buttonl
            // 
            this.buttonl.Location = new System.Drawing.Point(10, 168);
            this.buttonl.Name = "buttonl";
            this.buttonl.Size = new System.Drawing.Size(162, 59);
            this.buttonl.TabIndex = 1;
            this.buttonl.Text = "1";
            this.buttonl.UseVisualStyleBackColor = true;
            this.buttonl.Click += new System.EventHandler(this.buttonl_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 241);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonl);
            this.Controls.Add(this.textBoxl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxl;
        private System.Windows.Forms.Button buttonl;
        private System.Windows.Forms.Button button2;
    }
}

