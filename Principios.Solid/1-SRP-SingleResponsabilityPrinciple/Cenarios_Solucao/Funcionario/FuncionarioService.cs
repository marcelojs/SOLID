using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._1_SRP_SingleResponsabilityPrinciple.Cenarios_Solucao.Funcionario
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
