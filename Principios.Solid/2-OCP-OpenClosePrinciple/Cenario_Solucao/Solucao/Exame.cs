using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._2_OCP_OpenClosePrinciple.Cenario_Solucao.Solucao
{
    public abstract class Exame
    {
        public DateTime DateExame { get; set; }
        public decimal Valor { get; set; }

        public abstract void MarcarExame();

        public abstract void Procedimentos();

        public void EmitirDocumento()
        {
            //Processos de impressão do documento para o paciente apresentar no dia do exame
        }

    }
}
