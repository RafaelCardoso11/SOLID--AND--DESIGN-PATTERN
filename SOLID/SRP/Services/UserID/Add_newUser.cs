using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.SRP.DataBase;
using SOLID.SRP.Services;

namespace SOLID.SRP.NewUser
{
    class Add_newUser : Cliente
    {
        public string AddnewUserDateBase()
        {
            return "add email to data base: " + Email  //mysql insert
                + "add Nome to data base: " + Nome  //mysql insert
                + "add Senha to data base: " + Senha //mysql insert
                +  "add CPf to data base: " + Cpf; //mysql insert
        }
    }
}
