using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Services
{
      class Connection
    {
        public static void con(string ip, string db, string port, string name, string senha) 
        {
            MySqlConnection con = new MySqlConnection();
            con.Open();
        }
    }
}
