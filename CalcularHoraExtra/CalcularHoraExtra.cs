using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalcularHoraExtra.Program;

namespace CalcularHoraExtra
{
    public class Calcular
    {
        public Horario Entrada { get; set; }
        public Horario SaidaAlmoco { get; set; }
        public Horario RetornoAlmoco { get; set; }
        public Horario Saida { get; set; }

        // Construtor da classe
        public Calcular(Horario entrada, Horario saidaAlmoco, Horario retornoAlmoco, Horario saida)
        {
            Entrada = entrada;
            SaidaAlmoco = saidaAlmoco;
            RetornoAlmoco = retornoAlmoco;
            Saida = saida;
        }

        public void CalcularHoras()
        {
            Horario totalTrabalhado = (Saida - Entrada) - (SaidaAlmoco - RetornoAlmoco);
            Horario horasTrabalhadas = new Horario(9, 0);
            Horario horasExtras;
            if (totalTrabalhado < horasTrabalhadas)
            {
                horasExtras = totalTrabalhado - horasTrabalhadas;
                Console.WriteLine("Horas trabalhadas: " + totalTrabalhado.Hora + ":" + totalTrabalhado.Minuto);
                Console.WriteLine("Horas Negativas: -" + horasExtras.Hora + ":" + horasExtras.Minuto);
            }
            else
            {
                horasExtras = totalTrabalhado - horasTrabalhadas;
                Console.WriteLine("Horas trabalhadas: " + totalTrabalhado.Hora + ":" + totalTrabalhado.Minuto);
                Console.WriteLine("Horas Extras Positivas" + horasExtras.Hora + ":" + horasExtras.Minuto);
            }

        }

           
    }
}
