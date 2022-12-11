using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 1
                Scrieti o functie care va calcula suma cifrelor unui numar.
             */

            static int DigitSum(int n)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n = n / 10;
                }
                return sum;
            }

            Console.WriteLine("Introduceti un numar pentru a-i calcula suma cifrelor");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Suma cifrelor numarului {n} este {DigitSum(n)}");
        }
    }
}
