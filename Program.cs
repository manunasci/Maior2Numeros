using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maior 2 Numeros");

            Console.WriteLine("Digite o primeiro número");
            string numero = Console.ReadLine();
            double numero1 = double.Parse(numero);

            Console.WriteLine("Digite o sengudo número");
            string Numero2 = Console.ReadLine();
            double numero2 = double.Parse(Numero2);

            if (numero1 > numero2)
            {
                Console.WriteLine("O maior número é " + numero1);
            }

            else
            {
                Console.WriteLine("O maior número é " + numero2);
            }
        }
    }
}
