using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._3_LSP_LiskovSubstitutionPrinciple.Solucao
{
    public class Quadrado : Paralelogramo
    {
        protected Quadrado(double altura, double largura) : base(altura, largura)
        {
            if (altura != largura)
                throw new Exception("Os lados do quadrado devem ser iguais");
            else
                ObterArea();
        }

       
    }
}
