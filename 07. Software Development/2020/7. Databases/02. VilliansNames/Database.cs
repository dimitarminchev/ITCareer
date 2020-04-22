using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VilliansNames
{
    public class Database : IDisposable
    {
        // MySQL Connection
        private MySqlConnection conn = null;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Database()
        {
            string connstr = "server=localhost;port=3306;user=root;password=root;database=minionsdb";
            this.conn = new MySqlConnection(connstr);
            conn.Open();
        }

        /// <summary>
        /// Изпълнение на заявка
        /// </summary>
        /// <param name="sql">Заявка</param>
        /// <returns>Резултат</returns>
        public MySqlDataReader Query(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, this.conn);
            return command.ExecuteReader();
        }
        public void Dispose()
        {
            conn.Close();
        }

    }
}
