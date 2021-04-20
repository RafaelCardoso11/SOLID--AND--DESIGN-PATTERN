using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    class EmailServices
    {
        public static bool isValidEmail(string emailCliente)
        {
            return emailCliente.Contains("@");
        }
    }
}
