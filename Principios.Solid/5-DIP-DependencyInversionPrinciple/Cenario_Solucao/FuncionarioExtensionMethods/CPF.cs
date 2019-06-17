using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.FuncionarioExtensionMethods
{
    public class CPF
    {
        public CPF(string numeroCPF)
        {
            this.NumeroCPF = numeroCPF;
        }

        public const int TamanhoCPF = 11;
        public string NumeroCPF { get; private set; }

        public static bool ValidarNumeroCPF(string numeroCpf)
        {
            if (string.IsNullOrEmpty(numeroCpf))
            {
                if (numeroCpf.Length == TamanhoCPF)
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
