using SOLID.SRP.NewUser;
using SOLID.SRP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.User
{
    class CheckUserDataBase : Connection
    {
        private string email;
        private string nome;
        private string senha;
        public CheckUserDataBase()
        {
            CheckUser(nome, senha, email);
        }
        private void CheckUser(string nome, string senha, string email)
        {
            try
            {
                //CHECK DATA BASE MYSQL USER
            }
            catch
            {
                //userNotExist
                Add_newUser newUser = new Add_newUser();
                newUser.AddnewUserDateBase();
            }
        }
    }
}
