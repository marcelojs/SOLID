using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._3_LSP_LiskovSubstitutionPrinciple.Solucao
{
    public class Paralelogramo
    {
        protected Paralelogramo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double ObterArea()
        {
            return Altura* Largura;
        }

        public double Altura { get; private set; }
        public double Largura { get; private set; }
    }
}
