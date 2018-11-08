using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.databaseDataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.databaseDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Факультет". При необходимости она может быть перемещена или удалена.
            this.факультетTableAdapter.Fill(this.databaseDataSet.Факультет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Группа". При необходимости она может быть перемещена или удалена.


        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount - 1; i++)
            {
                string str = dataGridView3.Rows[i].Cells[1].Value.ToString();
                if (str.Contains(textBox1.Text) == true)
                    dataGridView3.Rows[i].Selected = true;
                else dataGridView3.Rows[i].Selected = false;
                if (textBox1.Text == "")
                    dataGridView3.Rows[i].Selected = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount - 1; i++)
            {
                string str = dataGridView3.Rows[i].Cells[1].Value.ToString();
                if (str == textBox2.Text) dataGridView3.Rows[i].Selected = true;
                else dataGridView3.Rows[i].Selected = false;
            }
        }
    }
}
