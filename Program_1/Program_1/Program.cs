using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    class Program
    {
        public static int input_N(int N)
        {
            Console.WriteLine("Введите размерность массива N от 0 до 20: ");
            N = Convert.ToInt32(Console.ReadLine());
            if (N < 0 || N > 20)
            {
                Console.WriteLine("Ошибка ввода! Введите целое число из промежутка от 0 до 20");
                N = input_N(N);
            }
            return N;

        }
        public static void input_mass(int[] mass, int N)
        {
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                mass[i] = rnd.Next(50);
            }
        }
        public static void output_mass(int[] mass, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();

        }
        static public void sort_bubble(int[] mass, int N)
        { //метод сортировки пузырьком
            for (int i = N - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        int tmp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = tmp;
                    }
                }
            }
        }
        static public void sort_bubble_obr(int[] mass, int N)
        {
            for (int i = 1; i < N; ++i)
            {
                for (int r = 0; r < N - i; r++)
                {
                    if (mass[r] < mass[r + 1])
                    {
                        int temp = mass[r];
                        mass[r] = mass[r + 1];
                        mass[r + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int N = 0;
            N = input_N(N);
            int[] mass = new int[N];
            input_mass(mass, N);
            output_mass(mass, N);
            sort_bubble(mass, N);
            output_mass(mass, N);
            sort_bubble_obr(mass, N);
            output_mass(mass, N);
        }
    }
}
