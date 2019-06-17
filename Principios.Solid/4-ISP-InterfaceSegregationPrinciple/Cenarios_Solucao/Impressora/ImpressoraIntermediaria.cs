using Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Solucao.Impressora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Solucao.Impressora
{
    public class ImpressoraIntermediaria : IImpressoraIntermediaria
    {
        public void ImprimirColorido(object obj)
        {
            //Processos impressão de documento colorido
        }

        public void ImprimirPretoBranco(object obj)
        {
            //Processos impressão de documento preto e branco
        }

        public void LimpezaMemoria()
        {
            //Processos de limpeza de memória da placa da impressora
        }

        public void Xerox()
        {
            //Processos de xerox
        }
    }
}
