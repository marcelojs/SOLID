using Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.Funcionario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.Funcionario
{
    public class EmailService : IEmailService
    {
        public bool ValidarEndereco(string email)
        {
            if (string.IsNullOrEmpty(email))
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
