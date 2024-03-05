using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LargestPrimeFactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numero = 600851475143;
            Console.WriteLine("O maior fator primo de " + numero + " é: " + FatorPrimo.MaiorFatorPrimo(numero));
        }
    }
}
