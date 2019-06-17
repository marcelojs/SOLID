using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._4_ISP_InterfaceSegregationPrinciple.Cenarios_Violacao.Impressora.Interface
{
    public interface IImpressora
    {
        void ImprimirPretoBranco(object obj);
        void ImprimirColorido(object obj);
        void EmitirFax();
        void Digitalizar(object obj);
        void Xerox();
        void LimpezaMemoria();
    }
}
