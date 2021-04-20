using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    class CPFServices
    {
        public static bool isValidCpf(string cpf)
        {
            return cpf.Length == 11;
        }
    }
  
}
