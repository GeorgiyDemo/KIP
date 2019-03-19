using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessExample
{
    public partial class MainForm : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../../Exam.mdb;";
        private OleDbConnection myConnection;

        public MainForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDataSet.data". При необходимости она может быть перемещена или удалена.
            this.dataTableAdapter.Fill(this.examDataSet.data);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDataSet.data". При необходимости она может быть перемещена или удалена.
            this.dataTableAdapter.Fill(this.examDataSet.data);

        }

        private void dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examDataSet);

        }

        private void OneElementButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT user FROM data WHERE Код=1";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            textBox1.Text = command.ExecuteScalar().ToString();
        }

        private void MultiElementsButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM data WHERE user=2";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " ");
            reader.Close();
        }

        private void InsertElementButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO data (user, active, passive) VALUES ("+UserTextBox.Text+", '"+ActiveTextBox.Text+"', '"+PassiveTextBox.Text+"')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }
    }
}
