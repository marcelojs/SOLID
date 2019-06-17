using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._1_SRP_SingleResponsabilityPrinciple.Cenarios_Solucao.Produto
{
    public class ProdutoService
    {
        public string AdicionarProduto(Produto produto)
        {
            var produtoRepository = new ProdutoRepository();
            produtoRepository.InsertProduto(produto);
            return "Produto adicionado com sucesso";
        }


    }
}
