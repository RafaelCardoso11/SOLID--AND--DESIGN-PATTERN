using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.DataBase
{
    partial class insertDataBaseConnection : connectionServices
    {
      
        public string ServerInsert()
        {
            return Ip = this.server;
        }
        public string DataBaseInsert()
        {
            return DataBase = this.dataBase;
        }
        public string UserInsert()
        {
            return Usuario = this.user;
        }
        public string PasswordInsert()
        {
            return Senha = this.port;
        }
        public string PortInsert()
        {
            return Port = this.port;
        }
    }
}
