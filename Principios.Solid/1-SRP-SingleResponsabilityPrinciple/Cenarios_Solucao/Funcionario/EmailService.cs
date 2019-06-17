using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._1_SRP_SingleResponsabilityPrinciple.Cenarios_Solucao.Funcionario
{
    public class EmailService
    {
        public static bool ValidarEmail(string email)
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
