using System;
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
           
            студентыTableAdapter.Fill(databaseDataSet.Студенты);
            группаTableAdapter.Fill(databaseDataSet.Группа);
            факультетTableAdapter.Fill(databaseDataSet.Факультет);

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
        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
