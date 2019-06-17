using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._1_SRP_SingleResponsabilityPrinciple.Cenarios_Solucao.Produto
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
