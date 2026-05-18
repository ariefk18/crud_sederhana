using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace crud
{
    class Koneksi
    {
        public MySqlConnection GetConn()
        {
            string str = "server=localhost;database=db_toko;uid=root;pwd=";
            MySqlConnection conn = new MySqlConnection(str);
            return conn;
        }
    }
}
