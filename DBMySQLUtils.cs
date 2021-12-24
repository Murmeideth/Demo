using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Demo
{
    class DBMySQLUtils
    {
        //Функция подключения, отправляющая данные на сервер, запрашивая подключение по указанным данным
        public static MySqlConnection GetDBConnection(string host, string database, int port, string user, string password)
        {
            String connString = "Server =" + host + "; Database =" + database + "; Port ="+ port.ToString() + "; User =" + user + "; Password =" + password + ";";
            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}
