using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._2_OCP_OpenClosePrinciple.Cenario_Violacao
{
    public class Exame
    {
        public void MarcarExame(TiposExame tiposExame)
        {
            if (tiposExame == TiposExame.Ressonancia)
            {
                //Processos.:
                //Agendar horário
                // ...
                // ...
                //Custo do exame
                // ...
                // ...
                // Demais Processos
                // ...
                //relação de procedimentos que o paciente deve seguir antes do exame
            }
            else if (tiposExame == TiposExame.Tomografia)
            {
                //Processos.:
                //Agendar horário
                // ...
                // ...
                //Custo do exame
                // ...
                // ...
                // Demais Processos
                // ...
                //relação de procedimentos que o paciente deve seguir antes do exame
            }
            else if (tiposExame == TiposExame.Ultrassom)
            {
                //Processos.:
                //Agendar horário
                // ...
                // ...
                // ...
                //Custo do exame
                // ...
                // ...
                // ...
                // Demais Processos
                // ...
                //relação de procedimentos que o paciente deve seguir antes do exame
            }

            //Novos exames serão adicionados modificando essa classe
            // Exames - Mamografia, RaioX, Eletroencefalograma, Cardiograma
        }
    }
}
