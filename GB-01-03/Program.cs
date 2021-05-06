using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[m, n];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(100);
                   
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int b = 0; b < j;b++ )
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(array[i,j]+" ");
                }
                Console.WriteLine();
            }



        }
    }
}
