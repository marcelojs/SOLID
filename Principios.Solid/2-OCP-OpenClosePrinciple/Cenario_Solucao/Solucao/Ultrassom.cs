using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._2_OCP_OpenClosePrinciple.Cenario_Solucao.Solucao
{
    public class Ultrassom : Exame
    {
        public override void MarcarExame()
        {
            //Processos para marcar, agendar o exame
        }

        public override void Procedimentos()
        {
            //Processos de procedimentos para realizar antes do exame
        }
    }
}
