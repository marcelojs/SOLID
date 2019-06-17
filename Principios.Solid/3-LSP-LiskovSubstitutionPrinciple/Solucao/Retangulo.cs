using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._3_LSP_LiskovSubstitutionPrinciple.Solucao
{
    public class Retangulo : Paralelogramo
    {
        protected Retangulo(double altura, double largura) : base(altura, largura)
        {
             ObterArea();
        }
    }
}
