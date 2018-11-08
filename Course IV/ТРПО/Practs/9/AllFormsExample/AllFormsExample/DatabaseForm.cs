using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllFormsExample
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm(Color meow)
        {
            BackColor = meow;
            InitializeComponent();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.databaseDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.databaseDataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Факультет". При необходимости она может быть перемещена или удалена.
            this.факультетTableAdapter.Fill(this.databaseDataSet.Факультет);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
