using System.Runtime.InteropServices;

namespace SistemaBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao banco!");
            ContaSalario contaSalario = new ContaSalario("João", 1000);
            ContaPoupanca contaPoupanca = new ContaPoupanca("Maria", 2000);

            Console.WriteLine(contaPoupanca.Retirada(100));
            Console.WriteLine(contaSalario.Retirada(100));
        }

        public abstract class ContaBancaria
        {
            public string Nome { get; set; }
            public float Saldo { get; set; }

            public abstract float Rendimento();
            public abstract float Retirada(float valor);
        }

        public class ContaSalario : ContaBancaria
        {
            public ContaSalario(string _Nome, float _Saldo)
            {
                Nome = _Nome;
                Saldo = _Saldo;
            }

            public override float Rendimento()
            {
                return 0.02f * Saldo;
            }

            public override float Retirada(float valor)
            {
                float restante =  Saldo + valor - (valor * 0.005f);
                return restante;
            }
        }

        public class ContaPoupanca : ContaBancaria 
        {
            public ContaPoupanca(string _Nome, float _Saldo)
            {
                Nome = _Nome;
                Saldo = _Saldo;
            }

            public override float Rendimento()
            {
                return 0.04f * Saldo;
            }

            public override float Retirada(float valor)
            {
                float restante;
                restante = Saldo + valor - (valor * 0.01f);
                return restante;
            }
        }

    }
}
