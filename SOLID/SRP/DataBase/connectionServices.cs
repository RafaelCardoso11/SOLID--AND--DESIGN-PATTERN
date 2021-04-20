using SOLID.SRP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.DataBase
{
    class connectionServices : Connection
    {
        
         protected string Ip { get; set; }
        protected string Port { get; set; }
        protected string DataBase { get; set; }
        protected string Usuario { get; set; }
        protected string Senha { get; set; }

        public void connectionOpen()
        {
            Connection.con(Ip, DataBase, Port, Usuario, Senha);
        }
    }
}
