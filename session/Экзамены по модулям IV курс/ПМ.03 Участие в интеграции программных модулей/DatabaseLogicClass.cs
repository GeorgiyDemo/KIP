using System;
using System.Windows;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.Data.Sqlite;

namespace SMSTimetable
{

    public class DatabaseLogicClass
    {

        public static string MySQLGet(string sql)
        {
            string name;
            MySqlConnection conn = new 
MySqlConnection(JustTokenClass.SQL_ConnectionString);
            conn.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                name = command.ExecuteScalar().ToString();
            }
            catch (NullReferenceException)
            {
                name = ""; 
            }
            conn.Close();
            return name;
        }

        public static async Task<Boolean> MySQLExecuteAsync(string sql)
        {
            using (var conn = new 
MySqlConnection(JustTokenClass.SQL_ConnectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    await cmd.ExecuteNonQueryAsync();
                }
                return true;
            }
        }

        public static async Task<string> MySQLGetAsync(string SQL)
        {
            string return_str = "";
            using (var conn = new 
MySqlConnection(JustTokenClass.SQL_ConnectionString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand(SQL, conn))
                using (var reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                        return_str += (reader.GetString(0) + ",");
            }
            return return_str;
        }

        public static void SQLiteExecute(string sql)
        {

            SqliteConnection myConn = new SqliteConnection("DataSource=" 
+ JustTokenClass.SQLiteDBPatch + ";");
            SqliteCommand sqCommand = new SqliteCommand(sql);
            sqCommand.Connection = myConn;
            myConn.Open();
            try
            {
                sqCommand.ExecuteNonQuery();
            }
            finally
            {
                myConn.Close();
            }
        }

        public static string SQLiteGet(string sql)
        {
            string outstr = "";
            using (SqliteConnection con = new 
SqliteConnection("DataSource=" + JustTokenClass.SQLiteDBPatch + ";"))
            {
                con.Open();

                using (SqliteCommand cmd = new SqliteCommand(sql, con))
                {
                    using (SqliteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                            outstr += rdr.GetString(0);
                    }
                }

                con.Close();
            }

            return outstr;
        }
    }
}

