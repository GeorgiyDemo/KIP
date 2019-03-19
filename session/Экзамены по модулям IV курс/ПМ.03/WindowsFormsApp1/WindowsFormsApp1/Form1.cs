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

        private void фИОBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фИОBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aNDREY);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aNDREY.ФИО". При необходимости она может быть перемещена или удалена.
            this.фИОTableAdapter.Fill(this.aNDREY.ФИО);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm meow = new LoginForm();
            meow.Show();
        }
    }
}
