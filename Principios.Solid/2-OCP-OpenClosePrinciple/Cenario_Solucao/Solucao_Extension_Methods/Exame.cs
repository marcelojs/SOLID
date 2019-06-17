using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._2_OCP_OpenClosePrinciple.Cenario_Solucao.Solucao_Extension_Methods
{
    public class Exame
    {
        public DateTime DateExame { get; set; }
        public decimal Valor { get; set; }

        public void EmitirDocumento()
        {
            //Processos de impressão do documento para o paciente apresentar no dia do exame
        }
    }
}
