using Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.Funcionario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.Funcionario
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IEmailService _emailService;
        private readonly ICPFService _cPFService;

        public FuncionarioService(
            IFuncionarioRepository funcionarioRepository,
            IEmailService emailService, 
            ICPFService cPFService)
        {
            _funcionarioRepository = funcionarioRepository;
            _emailService = emailService;
            _cPFService = cPFService;
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
