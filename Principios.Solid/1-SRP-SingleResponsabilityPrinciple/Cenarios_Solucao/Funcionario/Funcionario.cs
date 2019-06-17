﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._1_SRP_SingleResponsabilityPrinciple.Cenarios_Solucao.Funcionario
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public bool EhValido()
        {
             return CPFService.ValidarCPF(CPF) && EmailService.ValidarEmail(Email);
        }
    }
}
