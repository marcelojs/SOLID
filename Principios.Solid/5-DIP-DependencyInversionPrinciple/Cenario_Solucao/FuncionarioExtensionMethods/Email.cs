using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.FuncionarioExtensionMethods
{
    public class Email
    {
        public Email(string endereco)
        {
            this.Endereco = endereco;
        }

        public string Endereco { get; private set; }

        public static bool ValidarEnderecoEmail(string enderecoEmail)
        {
            if (string.IsNullOrEmpty(enderecoEmail))
            {
                //Outras validações para email
                // ...
                // ...
                // ...

                return true;
            }
            else
                return false;
        }
    }
}
