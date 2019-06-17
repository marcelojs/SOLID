using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Violacao
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
