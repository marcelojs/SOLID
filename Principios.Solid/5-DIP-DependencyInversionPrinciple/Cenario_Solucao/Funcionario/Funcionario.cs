using Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.Funcionario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.Funcionario
{
    public class Funcionario
    {
        private readonly IEmailService _emailService;
        private readonly ICPFService _CPFService;

        public Funcionario(IEmailService emailService, ICPFService cPFService)
        {
            _emailService = emailService;
            _CPFService = cPFService;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public bool EhValido()
        {
             return _CPFService.ValidarNumeroCPF(CPF) && _emailService.ValidarEndereco(Email);
        }
    }
}
