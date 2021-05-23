using System;

namespace MySQLTest
{
    internal class MySqlCommand
    {
        private string sql;
        private MySqlConnection conn;

        public MySqlCommand(string sql, MySqlConnection conn)
        {
            this.sql = sql;
            this.conn = conn;
        }

        internal MySqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}