using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Violacao
{
    public class CPFService
    {
        public static bool ValidarCPF(string numeroCpf)
        {
            if (string.IsNullOrEmpty(numeroCpf))
            {
                if (numeroCpf.Length == 11)
                {

                    // Outras validações de CPF
                    // ...
                    // ...
                    // ...
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
