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
            this.рисункиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисункиИзСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВодоемыРоссииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.РекиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВолгаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.МоскваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.МоряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЧерноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.БалтийскоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.АзовскоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОзераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЛадожскоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОнежскоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.БайкалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рисункиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.ВодоемыРоссииToolStripMenuItem});
            this.рисункиИзСпискаToolStripMenuItem.Name = "рисункиИзСпискаToolStripMenuItem";
            this.рисункиИзСпискаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рисункиИзСпискаToolStripMenuItem.Text = "Рисунки из списка";
            // 
            // ВодоемыРоссииToolStripMenuItem
            // 
            this.ВодоемыРоссииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.РекиToolStripMenuItem,
            this.МоряToolStripMenuItem,
            this.ОзераToolStripMenuItem});
            this.ВодоемыРоссииToolStripMenuItem.Name = "ВодоемыРоссииToolStripMenuItem";
            this.ВодоемыРоссииToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ВодоемыРоссииToolStripMenuItem.Text = "Водоемы России";
            // 
            // РекиToolStripMenuItem
            // 
            this.РекиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ВолгаToolStripMenuItem,
            this.МоскваToolStripMenuItem,
            this.ОкаToolStripMenuItem});
            this.РекиToolStripMenuItem.Name = "РекиToolStripMenuItem";
            this.РекиToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.РекиToolStripMenuItem.Text = "Реки";
            // 
            // ВолгаToolStripMenuItem
            // 
            this.ВолгаToolStripMenuItem.Name = "ВолгаToolStripMenuItem";
            this.ВолгаToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ВолгаToolStripMenuItem.Text = "Волга";
            this.ВолгаToolStripMenuItem.Click += new System.EventHandler(this.ВолгаToolStripMenuItem_Click);
            // 
            // МоскваToolStripMenuItem
            // 
            this.МоскваToolStripMenuItem.Name = "МоскваToolStripMenuItem";
            this.МоскваToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.МоскваToolStripMenuItem.Text = "Москва";
            this.МоскваToolStripMenuItem.Click += new System.EventHandler(this.МоскваToolStripMenuItem_Click);
            // 
            // ОкаToolStripMenuItem
            // 
            this.ОкаToolStripMenuItem.Name = "ОкаToolStripMenuItem";
            this.ОкаToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ОкаToolStripMenuItem.Text = "Ока";
            this.ОкаToolStripMenuItem.Click += new System.EventHandler(this.ОкаToolStripMenuItem_Click);
            // 
            // МоряToolStripMenuItem
            // 
            this.МоряToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ЧерноеToolStripMenuItem,
            this.БалтийскоеToolStripMenuItem,
            this.АзовскоеToolStripMenuItem});
            this.МоряToolStripMenuItem.Name = "МоряToolStripMenuItem";
            this.МоряToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.МоряToolStripMenuItem.Text = "Моря";
            // 
            // ЧерноеToolStripMenuItem
            // 
            this.ЧерноеToolStripMenuItem.Name = "ЧерноеToolStripMenuItem";
            this.ЧерноеToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ЧерноеToolStripMenuItem.Text = "Черное";
            this.ЧерноеToolStripMenuItem.Click += new System.EventHandler(this.ЧерноеToolStripMenuItem_Click);
            // 
            // БалтийскоеToolStripMenuItem
            // 
            this.БалтийскоеToolStripMenuItem.Name = "БалтийскоеToolStripMenuItem";
            this.БалтийскоеToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.БалтийскоеToolStripMenuItem.Text = "Балтийское";
            this.БалтийскоеToolStripMenuItem.Click += new System.EventHandler(this.БалтийскоеToolStripMenuItem_Click);
            // 
            // АзовскоеToolStripMenuItem
            // 
            this.АзовскоеToolStripMenuItem.Name = "АзовскоеToolStripMenuItem";
            this.АзовскоеToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.АзовскоеToolStripMenuItem.Text = "Азовское";
            this.АзовскоеToolStripMenuItem.Click += new System.EventHandler(this.АзовскоеToolStripMenuItem_Click);
            // 
            // ОзераToolStripMenuItem
            // 
            this.ОзераToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ЛадожскоеToolStripMenuItem,
            this.ОнежскоеToolStripMenuItem,
            this.БайкалToolStripMenuItem});
            this.ОзераToolStripMenuItem.Name = "ОзераToolStripMenuItem";
            this.ОзераToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ОзераToolStripMenuItem.Text = "Озера";
            // 
            // ЛадожскоеToolStripMenuItem
            // 
            this.ЛадожскоеToolStripMenuItem.Name = "ЛадожскоеToolStripMenuItem";
            this.ЛадожскоеToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ЛадожскоеToolStripMenuItem.Text = "Ладожское";
            this.ЛадожскоеToolStripMenuItem.Click += new System.EventHandler(this.ЛадожскоеToolStripMenuItem_Click);
            // 
            // ОнежскоеToolStripMenuItem
            // 
            this.ОнежскоеToolStripMenuItem.Name = "ОнежскоеToolStripMenuItem";
            this.ОнежскоеToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ОнежскоеToolStripMenuItem.Text = "Онежское";
            this.ОнежскоеToolStripMenuItem.Click += new System.EventHandler(this.ОнежскоеToolStripMenuItem_Click);
            // 
            // БайкалToolStripMenuItem
            // 
            this.БайкалToolStripMenuItem.Name = "БайкалToolStripMenuItem";
            this.БайкалToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.БайкалToolStripMenuItem.Text = "Байкал";
            this.БайкалToolStripMenuItem.Click += new System.EventHandler(this.БайкалToolStripMenuItem_Click);
            // 
            // открытьИзФайлаToolStripMenuItem
            // 
            this.открытьИзФайлаToolStripMenuItem.Name = "открытьИзФайлаToolStripMenuItem";
            this.открытьИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьИзФайлаToolStripMenuItem.Text = "Открыть из файла";
            this.открытьИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.открытьИзФайлаToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(12, 40);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(21, 31);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = " ";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Изображения";
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
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem рисункиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисункиИзСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВодоемыРоссииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem РекиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВолгаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem МоскваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ОкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem МоряToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЧерноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem БалтийскоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem АзовскоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ОзераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЛадожскоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ОнежскоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem БайкалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
    }
}

