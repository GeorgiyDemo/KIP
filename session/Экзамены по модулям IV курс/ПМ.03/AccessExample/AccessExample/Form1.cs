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
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../../Exam.mdb;";

        private OleDbConnection myConnection;

        public string CheckLogin(string login, string passwd)
        {
            string query = "SELECT Код FROM users WHERE login='"+login+"' AND password='"+passwd+"'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            if (command.ExecuteScalar() == null)
                return "";
            else
                return command.ExecuteScalar().ToString();

        }

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string bufresult = CheckLogin(LoginTextBox.Text, PasswordTextBox.Text);
            
            if (bufresult != "")
            {
                GlobalStaticClass.usernameid = bufresult;
                MainForm obj = new MainForm();
                obj.Show();
            }
            else
                MessageBox.Show("Неправильный логин или пароль");
            
        }
    }
}
