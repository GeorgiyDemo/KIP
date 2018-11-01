namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.рисункиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисункиИзСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.садовыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полевыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.комнатныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сиреньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.астраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пионToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ромашкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колокольчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фиалкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.орхидеяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бегонияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гибиусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.рисункиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 258);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // рисункиToolStripMenuItem
            // 
            this.рисункиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рисункиИзСпискаToolStripMenuItem,
            this.открытьИзФайлаToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.рисункиToolStripMenuItem.Name = "рисункиToolStripMenuItem";
            this.рисункиToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.рисункиToolStripMenuItem.Text = "Рисунки";
            // 
            // рисункиИзСпискаToolStripMenuItem
            // 
            this.рисункиИзСпискаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветыToolStripMenuItem});
            this.рисункиИзСпискаToolStripMenuItem.Name = "рисункиИзСпискаToolStripMenuItem";
            this.рисункиИзСпискаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рисункиИзСпискаToolStripMenuItem.Text = "Рисунки из списка";
            // 
            // открытьИзФайлаToolStripMenuItem
            // 
            this.открытьИзФайлаToolStripMenuItem.Name = "открытьИзФайлаToolStripMenuItem";
            this.открытьИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьИзФайлаToolStripMenuItem.Text = "Открыть из файла";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как....";
            // 
            // цветыToolStripMenuItem
            // 
            this.цветыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.садовыеToolStripMenuItem,
            this.полевыеToolStripMenuItem,
            this.комнатныеToolStripMenuItem});
            this.цветыToolStripMenuItem.Name = "цветыToolStripMenuItem";
            this.цветыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.цветыToolStripMenuItem.Text = "Цветы";
            // 
            // садовыеToolStripMenuItem
            // 
            this.садовыеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сиреньToolStripMenuItem,
            this.астраToolStripMenuItem,
            this.пионToolStripMenuItem});
            this.садовыеToolStripMenuItem.Name = "садовыеToolStripMenuItem";
            this.садовыеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.садовыеToolStripMenuItem.Text = "Садовые";
            // 
            // полевыеToolStripMenuItem
            // 
            this.полевыеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ромашкаToolStripMenuItem,
            this.колокольчикToolStripMenuItem,
            this.фиалкаToolStripMenuItem});
            this.полевыеToolStripMenuItem.Name = "полевыеToolStripMenuItem";
            this.полевыеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.полевыеToolStripMenuItem.Text = "Полевые";
            // 
            // комнатныеToolStripMenuItem
            // 
            this.комнатныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.орхидеяToolStripMenuItem,
            this.бегонияToolStripMenuItem,
            this.гибиусToolStripMenuItem});
            this.комнатныеToolStripMenuItem.Name = "комнатныеToolStripMenuItem";
            this.комнатныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.комнатныеToolStripMenuItem.Text = "Комнатные";
            // 
            // сиреньToolStripMenuItem
            // 
            this.сиреньToolStripMenuItem.Name = "сиреньToolStripMenuItem";
            this.сиреньToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сиреньToolStripMenuItem.Text = "Сирень";
            this.сиреньToolStripMenuItem.Click += new System.EventHandler(this.сиреньToolStripMenuItem_Click);
            // 
            // астраToolStripMenuItem
            // 
            this.астраToolStripMenuItem.Name = "астраToolStripMenuItem";
            this.астраToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.астраToolStripMenuItem.Text = "Астра";
            this.астраToolStripMenuItem.Click += new System.EventHandler(this.астраToolStripMenuItem_Click);
            // 
            // пионToolStripMenuItem
            // 
            this.пионToolStripMenuItem.Name = "пионToolStripMenuItem";
            this.пионToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пионToolStripMenuItem.Text = "Пион";
            this.пионToolStripMenuItem.Click += new System.EventHandler(this.пионToolStripMenuItem_Click);
            // 
            // ромашкаToolStripMenuItem
            // 
            this.ромашкаToolStripMenuItem.Name = "ромашкаToolStripMenuItem";
            this.ромашкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ромашкаToolStripMenuItem.Text = "Ромашка";
            // 
            // колокольчикToolStripMenuItem
            // 
            this.колокольчикToolStripMenuItem.Name = "колокольчикToolStripMenuItem";
            this.колокольчикToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.колокольчикToolStripMenuItem.Text = "Колокольчик";
            // 
            // фиалкаToolStripMenuItem
            // 
            this.фиалкаToolStripMenuItem.Name = "фиалкаToolStripMenuItem";
            this.фиалкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фиалкаToolStripMenuItem.Text = "Фиалка";
            // 
            // орхидеяToolStripMenuItem
            // 
            this.орхидеяToolStripMenuItem.Name = "орхидеяToolStripMenuItem";
            this.орхидеяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.орхидеяToolStripMenuItem.Text = "Орхидея";
            // 
            // бегонияToolStripMenuItem
            // 
            this.бегонияToolStripMenuItem.Name = "бегонияToolStripMenuItem";
            this.бегонияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.бегонияToolStripMenuItem.Text = "Бегония";
            // 
            // гибиусToolStripMenuItem
            // 
            this.гибиусToolStripMenuItem.Name = "гибиусToolStripMenuItem";
            this.гибиусToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гибиусToolStripMenuItem.Text = "Гибиус";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem рисункиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисункиИзСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem садовыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сиреньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem астраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пионToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полевыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ромашкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колокольчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фиалкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem комнатныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem орхидеяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бегонияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гибиусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
    }
}

