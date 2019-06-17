using Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Solucao.Impressora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Solucao.Impressora
{
    public class ImpressoraBasica : IImpressoraBasica
    {
        public void ImprimirPretoBranco(object obj)
        {
            //Processos impressão documento preto e branco
        }

        public void LimpezaMemoria()
        {
            //Processos limpeza memória da placa da impressora
        }
    }
}
