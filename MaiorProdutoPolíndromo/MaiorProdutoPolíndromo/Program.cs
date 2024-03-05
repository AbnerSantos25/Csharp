namespace MaiorProdutoPolíndromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long resposta = 0;
            for (long n1 = 100; n1 < 1000; n1++)
            {
                for (long n2 = 100; n2 < 1000; n2++)
                {
                    long res = n1 * n2;
                    string numeroInvertido = "";
                    for (int i = res.ToString().Length - 1; i >= 0; i--)
                    {
                        numeroInvertido += res.ToString()[i];
                    }
                    long res2 = long.Parse(numeroInvertido);
                    if (res == res2)
                    {
                        if(resposta < res)
                        {
                            resposta = res;
                        }          
                        Console.WriteLine($"{n1} * {n2} = {res}");
                    }
                }
            }

            Console.WriteLine($"Resposta: {resposta}");
        }
    }
}
