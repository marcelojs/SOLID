using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.Funcionario.Interfaces
{
    public interface IEmailService
    {
        bool ValidarEndereco(string enderecoEmail);
    }
}
