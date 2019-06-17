using Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.FuncionarioExtensionMethods.Interfaces;
using Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.FuncionarioExtensionMethods.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Solucao.FuncionarioExtensionMethods
{
    public class Funcionario
    {
        public Funcionario(int id, string nome, string cpf, string email, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            VerificarEmail(email);
            VerificarCPF(cpf);
        }

        public int Id { get;private  set; }
        public string Nome { get; private set; }
        public CPF CPF { get; private set; }
        public Email Email { get; private set; }
        public DateTime DataNascimento { get; set; }

        public void VerificarEmail(string email)
        {
            if (this.ValidarEnderecoEmail(email))
                Email = new Email(email);
            else
                Email = null;
        }

        public void VerificarCPF(string cpf)
        {
            if (this.ValidarNumeroCPF(cpf))
                CPF = new CPF(cpf);
            else
                CPF = null;
        }

        public bool EhValido()
        {
            return (Email == null ? false : true) && (CPF == null ? false : true);
        }
    }
}
