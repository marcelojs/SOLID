using Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Violacao.Impressora.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Violacao.Impressora
{
    public class ImpressoraBasica : IImpressora
    {
        public void ImprimirPretoBranco(object obj)
        {
            //Processos de impressão de documento preto e branco da impressora
        }

        public void LimpezaMemoria()
        {
            //Processos de limpeza de memória da placa da impressora
        }

        public void Digitalizar(object obj)
        {
            throw new NotImplementedException("Funcionalidade DIGITALIZAÇÃO não existe para esse modelo de impressora");
        }

        public void EmitirFax()
        {
            throw new NotImplementedException("Funcionalidade FAX não existe para esse modelo de impressora");
        }

        public void ImprimirColorido(object obj)
        {
            throw new NotImplementedException("Funcionalidade IMPRIMIR COLORIDO não existe para esse modelo de impressora");
        }

        public void Xerox()
        {
            throw new NotImplementedException("Funcionalidade XEROX não existe para esse modelo de impressora");
        }
    }
}
