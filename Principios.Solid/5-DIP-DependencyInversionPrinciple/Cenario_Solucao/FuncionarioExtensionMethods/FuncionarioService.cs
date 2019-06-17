using Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.FuncionarioExtensionMethods.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.FuncionarioExtensionMethods
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public string Adicionar(Funcionario funcionario)
        {
            if (funcionario.EhValido())
                _funcionarioRepository.Adicionar(funcionario);
            else
                return "Dados do funcionário não são válidos";

            return "Funcionário adicionado com sucesso";
        }
    }
}
