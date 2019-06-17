using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Solucao.Impressora.Interfaces
{
    public interface IImpressoraBasica
    {
        void ImprimirPretoBranco(object obj);
        void LimpezaMemoria();
    }
}
