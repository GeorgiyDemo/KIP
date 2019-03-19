using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
