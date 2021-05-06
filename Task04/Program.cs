using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            var battle = new string[10, 10];
            var chars = "XOOO";
            var random = new Random();

            for (int i = 0; i < battle.GetLength(0); i++)
            {
                Console.Write(" ");
                for (int j = 0; j < battle.GetLength(1); j++)
                {
                    Console.Write(chars[random.Next(chars.Length)]);
                }
                Console.WriteLine();
            }

        }
    }
}
