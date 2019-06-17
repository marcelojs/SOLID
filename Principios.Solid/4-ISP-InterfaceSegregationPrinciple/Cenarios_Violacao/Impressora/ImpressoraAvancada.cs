using Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Violacao.Impressora.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Violacao.Impressora
{
    public class ImpressoraAvancada : IImpressora
    {
        public void Digitalizar(object obj)
        {
            //Processos de digitalização
        }

        public void EmitirFax()
        {
            //Processos de emissão de fax
        }

        public void ImprimirColorido(object obj)
        {
            //Processos de impressão de documento colorido
        }

        public void ImprimirPretoBranco(object obj)
        {
            //Processos de impressão de documento preto e branco
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
