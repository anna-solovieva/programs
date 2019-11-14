using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    class Program
    {
        public static int input_N(int N)
        {
            Console.WriteLine("Введите четное число N:");
            N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 1)
            {
                Console.WriteLine("Ошибка ввода! Введите четное число.");
                N = input_N(N);
            }
            return N;

        }
        public static void TriangleFormation(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k <= (N - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int N = 0;
            N = input_N(N);
            TriangleFormation(N);
        }
    }
}
