namespace AllFormsExample
{
    partial class DatabaseForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new AllFormsExample.databaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетTableAdapter = new AllFormsExample.databaseDataSetTableAdapters.ФакультетTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.курсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествогруппDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыTableAdapter = new AllFormsExample.databaseDataSetTableAdapters.СтудентыTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группаTableAdapter = new AllFormsExample.databaseDataSetTableAdapters.ГруппаTableAdapter();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиегруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилиястаростыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.факультетDataGridViewTextBoxColumn,
            this.курсDataGridViewTextBoxColumn,
            this.количествогруппDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.факультетBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // факультетBindingSource
            // 
            this.факультетBindingSource.DataMember = "Факультет";
            this.факультетBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // факультетTableAdapter
            // 
            this.факультетTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // факультетDataGridViewTextBoxColumn
            // 
            this.факультетDataGridViewTextBoxColumn.DataPropertyName = "Факультет";
            this.факультетDataGridViewTextBoxColumn.HeaderText = "Факультет";
            this.факультетDataGridViewTextBoxColumn.Name = "факультетDataGridViewTextBoxColumn";
            // 
            // курсDataGridViewTextBoxColumn
            // 
            this.курсDataGridViewTextBoxColumn.DataPropertyName = "Курс";
            this.курсDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.курсDataGridViewTextBoxColumn.Name = "курсDataGridViewTextBoxColumn";
            // 
            // количествогруппDataGridViewTextBoxColumn
            // 
            this.количествогруппDataGridViewTextBoxColumn.DataPropertyName = "Количество_групп";
            this.количествогруппDataGridViewTextBoxColumn.HeaderText = "Количество_групп";
            this.количествогруппDataGridViewTextBoxColumn.Name = "количествогруппDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.студентыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(352, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.databaseDataSet;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.названиегруппыDataGridViewTextBoxColumn,
            this.фамилиястаростыDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.факультетIDDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.группаBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 204);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(580, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "Группа";
            this.группаBindingSource.DataSource = this.databaseDataSet;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            // 
            // названиегруппыDataGridViewTextBoxColumn
            // 
            this.названиегруппыDataGridViewTextBoxColumn.DataPropertyName = "Название_группы";
            this.названиегруппыDataGridViewTextBoxColumn.HeaderText = "Название_группы";
            this.названиегруппыDataGridViewTextBoxColumn.Name = "названиегруппыDataGridViewTextBoxColumn";
            // 
            // фамилиястаростыDataGridViewTextBoxColumn
            // 
            this.фамилиястаростыDataGridViewTextBoxColumn.DataPropertyName = "Фамилия_старосты";
            this.фамилиястаростыDataGridViewTextBoxColumn.HeaderText = "Фамилия_старосты";
            this.фамилиястаростыDataGridViewTextBoxColumn.Name = "фамилиястаростыDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // факультетIDDataGridViewTextBoxColumn
            // 
            this.факультетIDDataGridViewTextBoxColumn.DataPropertyName = "Факультет_ID";
            this.факультетIDDataGridViewTextBoxColumn.HeaderText = "Факультет_ID";
            this.факультетIDDataGridViewTextBoxColumn.Name = "факультетIDDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "<=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource факультетBindingSource;
        private databaseDataSetTableAdapters.ФакультетTableAdapter факультетTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факультетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn курсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествогруппDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private databaseDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource группаBindingSource;
        private databaseDataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиегруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилиястаростыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факультетIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}