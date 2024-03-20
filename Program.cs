using System.Diagnostics;
namespace Desafio_diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                decimal num, A;
                PegaValor(out num, out A);
                FazDiamante(num, A);
                
                Console.WriteLine("\nShow!\n\nDeseja continuar? [S/N]");
                if (DeveContinuar()) break;
            }
        }

        private static void FazDiamante(decimal num, decimal A)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (Math.Abs(j - A) <= i && i <= A) Console.Write("X");
                    else if (Math.Abs(i - 2 * A) >= Math.Abs(j - A) && i > A) Console.Write("X");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void PegaValor(out decimal num, out decimal A)
        {
            Console.WriteLine("Desafio do diamante de X\n\nPor favor, informe um número natural ímpar (positivo e inteiro):");
            num = Convert.ToDecimal(Console.ReadLine());
            while (num % 2 == 0 || num < 0 || num % 1 != 0)
            {
                Console.WriteLine("Número inválido :(\n\nPor favor, informe um novo número:");
                num = Convert.ToDecimal(Console.ReadLine());
            }

            A = Math.Floor(num / 2);
            Console.WriteLine();
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}
