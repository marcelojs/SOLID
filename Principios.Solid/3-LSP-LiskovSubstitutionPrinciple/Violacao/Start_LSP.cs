using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._3_LSP_LiskovSubstitutionPrinciple.Violacao
{
    public class Start_LSP
    {
        public static void CalularAreaQuadrado()
        {
            var quadrado = new Quadrado() { Altura = 5, Largura = 10 };
            ObterAreaRetangulo(quadrado);
        }

        private static void ObterAreaRetangulo(Retangulo retangulo)
        {
            Console.Clear();
            Console.WriteLine("Calcular área do retangulo");
            Console.WriteLine("Altura .: " + retangulo.Altura);
            Console.WriteLine("Largura.: " + retangulo.Largura);
            Console.WriteLine("Área .:" + retangulo.Area);
            Console.ReadKey();
        }


    }
}
