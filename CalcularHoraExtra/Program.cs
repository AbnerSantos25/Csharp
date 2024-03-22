using System;
using System.ComponentModel;

namespace CalcularHoraExtra
{
    static partial class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            List<Horario> Dias = new List<Horario>();
            while (true)
            {
                /*Vamos criar um sistema via console que recebe 4 valores, sendo eles:
                1 - Horario de entrada
                2 - Horario de sainda para almoço
                3 - Horario de retorno do almoço
                4 - Horario de saida
                O sistema deve calcular a quantidade de horas trabalhadas e a quantidade de horas extras, considerando que a jornada de trabalho é de 8 horas diárias.
                */
                Console.WriteLine("Digite o horario de entrada (HH:MM): ");
                string entradaString = Console.ReadLine();
                string[] entradaSplit = entradaString.Split(':');
                Horario entrada = new Horario(int.Parse(entradaSplit[0]), int.Parse(entradaSplit[1]));

                Console.WriteLine("Digite o horario de saida para o almoço (HH:MM): ");
                string saidaAlmocoString = Console.ReadLine();
                string[] saidaAlmocoSplit = saidaAlmocoString.Split(':');
                Horario saidaAlmoco = new Horario(int.Parse(saidaAlmocoSplit[0]), int.Parse(saidaAlmocoSplit[1]));

                Console.WriteLine("Digite o horario de retorno do almoço (HH:MM): ");
                string retornoAlmocoString = Console.ReadLine();
                string[] retornoAlmocoSplit = retornoAlmocoString.Split(':');
                Horario retornoAlmoco = new Horario(int.Parse(retornoAlmocoSplit[0]), int.Parse(retornoAlmocoSplit[1]));

                Console.WriteLine("Digite o horario de saida (HH:MM): ");
                string saidaString = Console.ReadLine();
                string[] saidaSplit = saidaString.Split(':');
                Horario saida = new Horario(int.Parse(saidaSplit[0]), int.Parse(saidaSplit[1]));

                Calcular calcular = new Calcular(entrada, saidaAlmoco, retornoAlmoco, saida);
                calcular.CalcularHoras();
            }
        }

    }

}
