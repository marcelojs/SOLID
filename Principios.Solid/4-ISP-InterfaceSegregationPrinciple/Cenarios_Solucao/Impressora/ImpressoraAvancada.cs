using Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Solucao.Impressora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Solucao.Impressora
{
    public class ImpressoraAvancada : IImpressoraAvancada
    {
        public void Digitalizar(object obj)
        {
            //
        }

        public void EmitirFax()
        {
            throw new NotImplementedException();
        }

        public void ImprimirColorido(object obj)
        {
            throw new NotImplementedException();
        }

        public void ImprimirPretoBranco(object obj)
        {
            throw new NotImplementedException();
        }

        public void LimpezaMemoria()
        {
            throw new NotImplementedException();
        }

        public void Xerox()
        {
            throw new NotImplementedException();
        }
    }
}
