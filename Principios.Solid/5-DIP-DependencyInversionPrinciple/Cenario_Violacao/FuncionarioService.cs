using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._5_DIP_DependencyInversionPrinciple.Cenario_Violacao
{
    public class FuncionarioService
    {
        public string AdicionarFuncionario(Funcionario funcionario)
        {
            var funcionarioRepository = new FuncionarioRepository();
            funcionarioRepository.InsertFuncionario(funcionario);
            return "Funcionário adicionado com sucesso";
        }
    }
}
