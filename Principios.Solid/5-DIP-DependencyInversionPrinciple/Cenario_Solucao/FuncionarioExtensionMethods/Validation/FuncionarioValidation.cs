using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.FuncionarioExtensionMethods.Validation
{
    public static class FuncionarioValidation
    {
        public static bool ValidarNumeroCPF(this Funcionario funcionario, string numeroCPF)
        {
            return CPF.ValidarNumeroCPF(numeroCPF);
        }

        public static bool ValidarEnderecoEmail(this Funcionario funcionario, string endereco)
        {
            return Email.ValidarEnderecoEmail(endereco);
        }
    }
}
