using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        bool isValid()
        {
            return EmailServices.isValidEmail(Email) && CPFServices.isValidCpf(Cpf);
        }
    }
}
