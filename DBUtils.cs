using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Demo
{
    class DBUtils
    {
        //Функция, которая в дальнейшем будет вызываться для создания подключения, хранит в себе данные, по которым происходит подключение 
        public static MySqlConnection GetDBConnection()
        {
            string host = "192.168.4.9";
            string database = "user8_db";
            int port = 3311;
            string user = "user8";
            string password = "1234";

            return DBMySQLUtils.GetDBConnection(host, database, port, user, password);
        }
    }
}
