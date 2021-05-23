using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DataAccess
{
    class DB_employee_code
    {
        public static DataSet EmployeeInformation
        {
            get
            {

                string cs = "server=localhost;user=root;database=employees;port=3306;password=password";
                MySqlConnection conn = new MySqlConnection(cs);

                try
                {
                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();

                    string sql = "SELECT * FROM employees";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + " ," + rdr[1] + " ," + rdr[2] + " ," + rdr[3] + " ," + rdr[4] + " ," + rdr[5]);
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                conn.Close();
                Console.WriteLine("Done.");
            }
        }
    }

    internal class MySqlConnection
    {
        private string cs;

        public MySqlConnection(string cs)
        {
            this.cs = cs;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}


