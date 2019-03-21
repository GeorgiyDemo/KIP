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
    public partial class SelectForm : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../../Exam.mdb;";
        private OleDbConnection myConnection;

        public SelectForm(string date1, string date2)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "";
            if (GlobalStaticClass.usernameid != "3")
                query = $"SELECT * FROM data WHERE (date_app BETWEEN  #{date1}#  AND  #{date2}#) AND user={GlobalStaticClass.usernameid};";
            else
                query = $"SELECT * FROM data WHERE date_app BETWEEN  #{date1}#  AND  #{date2}#;";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " ");
            reader.Close();

        }
    }
}
